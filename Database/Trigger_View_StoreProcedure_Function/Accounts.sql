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
GO
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
CREATE FUNCTION GetAccountById (@IdAccount CHAR(6))
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