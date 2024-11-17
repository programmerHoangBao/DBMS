/*
--Bảng Tài khoản
CREATE TABLE Accounts(
	IdAccount CHAR(6) PRIMARY KEY,
	Username NVARCHAR(50) UNIQUE NOT NULL,
	PasswordUser NVARCHAR(15) NOT NULL,
	Email NVARCHAR(100) NOT NULL, 
	RoleUser NVARCHAR(10) NOT NULL,
	CONSTRAINT Check_Role CHECK(RoleUser IN (N'Quản Lý', N'Nhân Viên'))
);
*/

USE QuanLyTaiChinhCuaHangXayDung;
GO
-- Trigger thực hiện việc tạo login và user khi thêm tài khoản vào bảng Accounts
CREATE TRIGGER trg_InsertAccount
ON Accounts
AFTER INSERT
AS
BEGIN
    DECLARE @Username NVARCHAR(50);
    DECLARE @Password NVARCHAR(15);
    DECLARE @Role NVARCHAR(10);
    DECLARE @SQL NVARCHAR(1000);

    SELECT 
        @Username = I.Username,
        @Password = I.PasswordUser,
        @Role = I.RoleUser
    FROM inserted I;

    -- Tạo login
    SET @SQL = 'CREATE LOGIN [' + @Username +'] WITH PASSWORD = ''' + @Password + '''';
    EXEC sp_executesql @SQL;

    -- Tạo user
    SET @SQL = 'CREATE USER [' + @Username + '] FOR LOGIN [' + @Username + ']';
    EXEC sp_executesql @SQL;

    -- Phân quyền dựa trên vai trò
    IF (@Role = N'Quản Lý')
    BEGIN
        SET @SQL = 'ALTER SERVER ROLE ManagerOnServer ADD MEMBER [' + @Username + ']';
        EXEC sp_executesql @SQL;

        SET @SQL = 'ALTER ROLE Manager ADD MEMBER [' + @Username + ']';
        EXEC sp_executesql @SQL;
    END
    ELSE
    BEGIN
        SET @SQL = 'ALTER SERVER ROLE EmployeeOnServer ADD MEMBER [' + @Username + ']';
        EXEC sp_executesql @SQL;

        SET @SQL = 'ALTER ROLE Employee ADD MEMBER [' + @Username + ']';
        EXEC sp_executesql @SQL;
    END
END;
GO

--Trigger kiểm xóa việc xóa Accounts
CREATE TRIGGER trg_DeleteAccount
ON Accounts
AFTER DELETE
AS
BEGIN
    DECLARE @Username NVARCHAR(50);
    DECLARE @SPID INT;
    DECLARE @SQL NVARCHAR(MAX);

    SELECT @Username = Username FROM deleted;

    -- Tìm SPID của người dùng
    WHILE EXISTS (SELECT session_id FROM sys.dm_exec_sessions WHERE login_name = @Username)
    BEGIN
        SELECT @SPID = session_id
        FROM sys.dm_exec_sessions
        WHERE login_name = @Username;

        -- Nếu SPID tồn tại, ngắt kết nối
        IF @SPID IS NOT NULL
        BEGIN
            SET @SQL = 'KILL ' + CAST(@SPID AS NVARCHAR(10));
            EXEC sp_executesql @SQL;
        END
    END

    -- Kiểm tra và xóa user nếu tồn tại
    IF EXISTS (SELECT 1 FROM sys.database_principals WHERE name = @Username)
    BEGIN
        SET @SQL = 'DROP USER [' + @Username + ']';
        EXEC sp_executesql @SQL;
    END

    -- Kiểm tra và xóa login nếu tồn tại
    IF EXISTS (SELECT 1 FROM sys.sql_logins WHERE name = @Username)
    BEGIN
        SET @SQL = 'DROP LOGIN [' + @Username + ']';
        EXEC sp_executesql @SQL;
    END
END;
GO




--Trigger thực hiện cập nhật tài khoản
CREATE TRIGGER trg_UpdateAccount
ON Accounts
AFTER UPDATE
AS
BEGIN
    DECLARE @OldUsername NVARCHAR(50);
    DECLARE @NewUsername NVARCHAR(50);
    DECLARE @OldPassword NVARCHAR(15);
    DECLARE @NewPassword NVARCHAR(15);
    DECLARE @RoleUser NVARCHAR(10);
    DECLARE @SQL NVARCHAR(MAX);

    SELECT 
        @OldUsername = deleted.Username, 
        @NewUsername = inserted.Username, 
        @OldPassword = deleted.PasswordUser, 
        @NewPassword = inserted.PasswordUser, 
        @RoleUser = inserted.RoleUser 
    FROM 
        inserted
    INNER JOIN 
        deleted ON inserted.IdAccount = deleted.IdAccount;

    -- Kiểm tra và cập nhật tên login và user nếu tên người dùng thay đổi
    IF @OldUsername <> @NewUsername
    BEGIN
        -- Đổi tên login
        SET @SQL = 'ALTER LOGIN [' + @OldUsername + '] WITH NAME = [' + @NewUsername + ']';
        EXEC sp_executesql @SQL;

        -- Đổi tên user
        SET @SQL = 'ALTER USER [' + @OldUsername + '] WITH NAME = [' + @NewUsername + ']';
        EXEC sp_executesql @SQL;
    END

    -- Kiểm tra và cập nhật mật khẩu nếu mật khẩu thay đổi
    IF @OldPassword <> @NewPassword
    BEGIN
        -- Cập nhật mật khẩu của login
        SET @SQL = 'ALTER LOGIN [' + @NewUsername + '] WITH PASSWORD = ''' + @NewPassword + '''';
        EXEC sp_executesql @SQL;
    END

END;
GO

--Trigger kiểm tra Email.
CREATE TRIGGER trg_CheckEmail
ON Accounts
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @Email NVARCHAR(100);
    DECLARE @EmailPattern NVARCHAR(100) = '%_@__%.__%';  -- Mẫu cơ bản để kiểm tra email

    SELECT @Email = inserted.Email
    FROM inserted;

    -- Kiểm tra định dạng email cơ bản
    IF @Email NOT LIKE @EmailPattern
    BEGIN
        RAISERROR (N'Email không hợp lệ, vui lòng nhập đúng định dạng email.', 16, 1);
        ROLLBACK;
    END
END;
GO

--Store Procedure thực hiện việc thêm tài khoản
CREATE PROCEDURE SP_InsertAccount
	@IdAccount CHAR(6),
	@Username NVARCHAR(50),
	@PasswordUser NVARCHAR(15),
	@Email NVARCHAR(100),
	@RoleUser NVARCHAR(10),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

		IF ( EXISTS(SELECT 1 FROM Accounts AC WHERE AC.IdAccount=@IdAccount) )
		BEGIN
			SET @Result = 0;
		END
		ELSE
		BEGIN
			INSERT INTO Accounts(IdAccount, Username, PasswordUser, Email, RoleUser) 
			VALUES (@IdAccount, @Username, @PasswordUser, @Email, @RoleUser);

			SET @Result = 1;
		END

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SET @Result = 0;
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrorMessage, 16, 1);
	END CATCH
END;
GO

--Store Procedure thực hiện cập nhật trên bảng Accounts
CREATE PROCEDURE SP_UpadateAccount
	@IdAccount CHAR(6),
	@Username NVARCHAR(50),
	@PasswordUser NVARCHAR(15),
	@Email NVARCHAR(100),
	@RoleUser NVARCHAR(10),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		
		IF ( EXISTS(SELECT 1 FROM Accounts AC WHERE AC.IdAccount=@IdAccount) )
		BEGIN
			UPDATE Accounts 
			SET Username=@Username, PasswordUser=@PasswordUser, RoleUser=@RoleUser 
			WHERE IdAccount=@IdAccount;

			SET @Result = 1;
		END
		ELSE
		BEGIN
			SET @Result = 0;
		END

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SET @Result = 0;
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrorMessage, 16, 1);
	END CATCH
END;
GO

--Store Procedure thực hiện việc xóa tài khoản 
CREATE PROCEDURE SP_DeleteAccount
	@IdAccount CHAR(6),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

		IF ( EXISTS(SELECT 1 FROM Accounts AC WHERE AC.IdAccount=@IdAccount) )
		BEGIN
			DELETE FROM Accounts WHERE IdAccount = @IdAccount;

			SET @Result = 1;
		END
		ELSE
		BEGIN
			SET @Result = 0;
		END

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SET @Result = 0;
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrorMessage, 16, 1);
	END CATCH
END;
GO

--Store Procedure thực hiện việc đăng nhập
CREATE FUNCTION Fn_LoginAccount
(
    @Username NVARCHAR(50),
    @Password NVARCHAR(15)
)
RETURNS INT
AS
BEGIN
    IF 
	(
		EXISTS
		(
			SELECT 1
			FROM Accounts AC
			WHERE AC.Username = @Username AND AC.PasswordUser = @Password
		)
	)
	BEGIN
		RETURN 1;
	END

	RETURN 0;
END;
GO


--Function thực hiện Lấy ra thong tin cảu tất cả Accounts
CREATE FUNCTION Fn_GetAllAccount()
RETURNS TABLE
AS
	RETURN
	(
		SELECT 
			AC.IdAccount, 
			AC.Username, 
			AC.PasswordUser, 
			AC.Email, 
			AC.RoleUser 
		FROM Accounts AC
	);
GO

--Function lấy ra đối tượng Account bằng Id
CREATE FUNCTION Fn_GetAccountById (@IdAccount CHAR(6))
RETURNS TABLE 
AS
	RETURN 
	(
		SELECT 
			AC.IdAccount, 
			AC.Username, 
			AC.PasswordUser, 
			AC.Email, 
			AC.RoleUser 
		FROM Accounts AC 
		WHERE AC.IdAccount = @IdAccount
	);
GO

--Function lấy ra account bằng Username
CREATE FUNCTION Fn_GetAccountByUsername
(
	 @Username NVARCHAR(50)
)
RETURNS TABLE
AS
	RETURN
	(
		SELECT 
			AC.IdAccount, 
			AC.Username, 
			AC.PasswordUser, 
			AC.Email, 
			AC.RoleUser 
		FROM Accounts AC 
		WHERE AC.Username = @Username
	)
GO