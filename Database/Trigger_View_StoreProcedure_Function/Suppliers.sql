/*
CREATE TABLE Suppliers(
	IdSupplier CHAR(6) PRIMARY KEY,
	NameSupplier NVARCHAR(100) NOT NULL,
	AddressSupplier NVARCHAR(150) NOT NULL,
	PhoneNumber CHAR(10) UNIQUE NOT NULL,
);
*/
GO
USE QuanLyTaiChinhCuaHangXayDung;
GO

--Trigger kiểm tra PhoneNumber là chuổi số điện thoại Việt Nam
CREATE TRIGGER trg_checkPhoneNumberSuppliers
ON Suppliers
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @PhoneNumber CHAR(10);
    DECLARE @RegexPattern NVARCHAR(100) = '^(0[3|5|7|8|9])[0-9]{8}$';

    SELECT @PhoneNumber = PhoneNumber FROM inserted;

    IF @PhoneNumber NOT LIKE @RegexPattern
    BEGIN
        RAISERROR('Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại Việt Nam.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO

--Store Procedure thưc hiện việc thêm dữ liệu vào bảng Suppliers
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

--Store Procedure thưc hiện việc cập nhật liệu trong bảng Suppliers
CREATE PROCEDURE SP_UpdateSupplier
    @IdSupplier CHAR(6),
    @NameSupplier NVARCHAR(100),
    @PhoneNumber CHAR(10),
    @AddressSupplier NVARCHAR(150),
    @Result INT OUTPUT
AS
BEGIN
    BEGIN TRY
        UPDATE Suppliers
		SET NameSupplier=@NameSupplier, PhoneNumber=@PhoneNumber, AddressSupplier=@AddressSupplier
		WHERE IdSupplier=@IdSupplier;

        SET @Result = 1;
    END TRY
    BEGIN CATCH
        SET @Result = 0;
    END CATCH
END;
GO

--Store Procedure thưc hiện việc xóa dữ liệu trong bảng Suppliers
CREATE PROCEDURE SP_DeleteSupplier
	@IdSupplier CHAR(6),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		DELETE FROM Suppliers WHERE Suppliers.IdSupplier=@IdSupplier;

		SET @Result=1;
	END TRY
	BEGIN CATCH
		SET @Result=0
	END CATCH;
END;
GO

--Function lấy ra thông tin của tất cả nhà cung cấp
CREATE FUNCTION Fn_GetAllSupplier ()
RETURNS TABLE
AS
	RETURN (
		SELECT S.IdSupplier 'Id', S.NameSupplier 'Tên', S.PhoneNumber 'Số điện thoại', S.AddressSupplier 'Địa chỉ'
		FROM Suppliers S
	);
GO

--Function lấy thông tin nhà cung cấp thông qua mã nhà cung cấp
CREATE FUNCTION Fn_GetSupplierById (@IdSupplier CHAR(6))
RETURNS TABLE
AS
	RETURN (
		SELECT S.IdSupplier 'Id', S.NameSupplier 'Tên', S.PhoneNumber 'Số điện thoại', S.AddressSupplier 'Địa chỉ'
		FROM Suppliers S
		WHERE S.IdSupplier = @IdSupplier
	);
GO

--Function lấy IdSupplier bằng PhoneNumber của Supplier
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
