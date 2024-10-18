/*
CREATE TABLE Suppliers(
	IdSupplier CHAR(6) PRIMARY KEY,
	NameSupplier NVARCHAR(100) NOT NULL,
	AddressSupplier NVARCHAR(150) NOT NULL,
	PhoneNumber CHAR(10) UNIQUE NOT NULL
);
*/
GO
USE QuanLyTaiChinhCuaHangXayDung;
GO

-- Trigger kiểm tra NameSupplier là một tên hợp lệ không chứa kí tự số
CREATE TRIGGER trg_check_namesupplier
ON Suppliers
INSTEAD OF INSERT, UPDATE
AS
BEGIN
    DECLARE @name NVARCHAR(100);

    SELECT @name = NameSupplier FROM inserted;

    IF @name LIKE '%[0-9]%'
    BEGIN
        RAISERROR ('Tên nhà cung cấp không được chứa ký tự số.', 16, 1);
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
		DECLARE @IdSupplier CHAR(6);

		SELECT @IdSupplier = IdSupplier FROM inserted;

		IF (EXISTS(SELECT 1 FROM Suppliers WHERE IdSupplier=@IdSupplier))
		BEGIN
			DECLARE @PhoneNumber CHAR(10);
			DECLARE @AddressSupplier NVARCHAR(150);

			SELECT @PhoneNumber = PhoneNumber, 
					@AddressSupplier = AddressSupplier 
			FROM inserted;

			UPDATE Suppliers
			SET NameSupplier=@name, PhoneNumber=@PhoneNumber, AddressSupplier=@AddressSupplier
			WHERE IdSupplier=@IdSupplier;
		END
		ELSE
		BEGIN 
			INSERT INTO Suppliers
			SELECT * FROM inserted;
		END
    END
END;
GO

-- Trigger kiểm tra PhoneNumber là chuỗi số điện thoại Việt Nam
CREATE TRIGGER trg_checkPhoneNumberSuppliers
ON Suppliers
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @PhoneNumber CHAR(10);

    SELECT @PhoneNumber = PhoneNumber FROM inserted;

    IF @PhoneNumber NOT LIKE '0[35789]%' 
        OR LEN(@PhoneNumber) <> 10
        OR @PhoneNumber NOT LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
    BEGIN
        RAISERROR('Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại Việt Nam hợp lệ.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO

-- Store Procedure thực hiện việc thêm dữ liệu vào bảng Suppliers
CREATE PROCEDURE SP_InsertSupplier
    @IdSupplier CHAR(6),
    @NameSupplier NVARCHAR(100),
    @PhoneNumber CHAR(10),
    @AddressSupplier NVARCHAR(150),
    @Result INT OUTPUT
AS
BEGIN
    BEGIN TRY
        INSERT INTO Suppliers (IdSupplier, NameSupplier, PhoneNumber, AddressSupplier)
        VALUES (@IdSupplier, @NameSupplier, @PhoneNumber, @AddressSupplier);

        SET @Result = 1;
    END TRY
    BEGIN CATCH
        SET @Result = 0;
    END CATCH
END;
GO

-- Store Procedure thực hiện việc cập nhật liệu trong bảng Suppliers
CREATE PROCEDURE SP_UpdateSupplier
    @IdSupplier CHAR(6),
    @NameSupplier NVARCHAR(100),
    @PhoneNumber CHAR(10),
    @AddressSupplier NVARCHAR(150),
    @Result INT OUTPUT
AS
BEGIN
    BEGIN TRY
		IF (EXISTS(SELECT 1 FROM Suppliers WHERE Suppliers.IdSupplier=@IdSupplier))
		BEGIN
			UPDATE Suppliers
			SET NameSupplier=@NameSupplier, PhoneNumber=@PhoneNumber, AddressSupplier=@AddressSupplier
			WHERE IdSupplier=@IdSupplier;

			SET @Result = 1;
		END
		ELSE
		BEGIN
			SET @Result=0;
		END
    END TRY
    BEGIN CATCH
        SET @Result = 0;
    END CATCH
END;
GO

-- Store Procedure thực hiện việc xóa dữ liệu trong bảng Suppliers
CREATE PROCEDURE SP_DeleteSupplier
	@IdSupplier CHAR(6),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		IF (EXISTS(SELECT 1 FROM Suppliers WHERE Suppliers.IdSupplier=@IdSupplier))
		BEGIN
			DELETE FROM Suppliers WHERE Suppliers.IdSupplier=@IdSupplier;

			SET @Result=1;
		END
		ELSE
		BEGIN
			SET @Result=0;
		END
	END TRY
	BEGIN CATCH
		SET @Result=0;
	END CATCH;
END;
GO

-- Function lấy ra thông tin của tất cả nhà cung cấp
CREATE FUNCTION Fn_GetAllSupplier ()
RETURNS TABLE
AS
	RETURN (
		SELECT S.IdSupplier, S.NameSupplier, S.PhoneNumber, S.AddressSupplier
		FROM Suppliers S
	);
GO

-- Function lấy thông tin nhà cung cấp thông qua mã nhà cung cấp
CREATE FUNCTION Fn_GetSupplierById (@IdSupplier CHAR(6))
RETURNS TABLE
AS
	RETURN (
		SELECT S.IdSupplier, S.NameSupplier, S.PhoneNumber, S.AddressSupplier
		FROM Suppliers S
		WHERE S.IdSupplier = @IdSupplier
	);
GO

-- Function lấy IdSupplier bằng PhoneNumber của Supplier
CREATE FUNCTION Fn_GetIdSupplierByPhoneNumber (@PhoneNumber CHAR(10))
RETURNS CHAR(6)
AS
BEGIN
	DECLARE @IdSupplier CHAR(6);
	
	SELECT @IdSupplier = Suppliers.IdSupplier
	FROM Suppliers
	WHERE Suppliers.PhoneNumber = @PhoneNumber;

	RETURN @IdSupplier;
END;
GO


--Fnction lấy các suppliers bằng cách nhập vào một thông tin bất kì
CREATE FUNCTION Fn_SearchSupplier (@SearchTerm NVARCHAR(150))
RETURNS TABLE
AS	
	RETURN
	(
		SELECT DISTINCT
			S.IdSupplier,
			S.NameSupplier,
			S.PhoneNumber,
			S.AddressSupplier
		FROM Suppliers S
		WHERE 
			S.IdSupplier LIKE '%' + @SearchTerm +'%'
			OR S.NameSupplier LIKE '%' + @SearchTerm +'%'
			OR S.PhoneNumber LIKE '%' + @SearchTerm +'%'
			OR S.AddressSupplier LIKE '%' + @SearchTerm +'%'
	);

GO

