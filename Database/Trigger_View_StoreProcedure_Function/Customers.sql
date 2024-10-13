/*
CREATE TABLE Customers(
	IdCustomer CHAR(6) PRIMARY KEY,
	NameCustomer NVARCHAR(100) NOT NULL,
	PhoneNumber CHAR(10) UNIQUE NOT NULL,
	AddressCustomer NVARCHAR(150) NOT NULL,
);
*/
GO
USE QuanLyTaiChinhCuaHangXayDung;
GO

--Trigger kiểm tra PhoneNumber là chuổi số điện thoại Việt Nam
CREATE TRIGGER trg_checkPhoneNumberCustomers
ON Customers
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

--Store Procedure thưc hiện việc thêm dữ liệu vào bảng Customers
CREATE PROCEDURE SP_InsertCustomer
    @IdCustomer CHAR(6),
    @NameCustomer NVARCHAR(100),
    @PhoneNumber CHAR(10),
    @AddressCustomer NVARCHAR(150),
    @Result INT OUTPUT
AS
BEGIN
    BEGIN TRY
        INSERT INTO Customers (IdCustomer, NameCustomer, PhoneNumber, AddressCustomer)
        VALUES (@IdCustomer, @NameCustomer, @PhoneNumber, @AddressCustomer);

        SET @Result = 1;
    END TRY
    BEGIN CATCH
        SET @Result = 0;
    END CATCH
END;
GO

--Store Procedure thưc hiện việc cập nhật liệu trong bảng Customers
CREATE PROCEDURE SP_UpdateCustomer
    @IdCustomer CHAR(6),
    @NameCustomer NVARCHAR(100),
    @PhoneNumber CHAR(10),
    @AddressCustomer NVARCHAR(150),
    @Result INT OUTPUT
AS
BEGIN
    BEGIN TRY
        UPDATE Customers 
		SET NameCustomer=@NameCustomer, PhoneNumber=@PhoneNumber, AddressCustomer=@AddressCustomer
		WHERE IdCustomer=@IdCustomer;

        SET @Result = 1;
    END TRY
    BEGIN CATCH
        SET @Result = 0;
    END CATCH
END;
GO

----Store Procedure thưc hiện việc xóa dữ liệu trong bảng Customers
CREATE PROCEDURE SP_DeleteCustomer
	@IdCustomer CHAR(6),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		DELETE FROM Customers WHERE Customers.IdCustomer=@IdCustomer;

		SET @Result=1;
	END TRY
	BEGIN CATCH
		SET @Result=0
	END CATCH;
END;
GO

--Function lấy ra thông tin của tất cả khách hàng
CREATE FUNCTION Fn_GetAllCustomer ()
RETURNS TABLE
AS
	RETURN (
		SELECT C.IdCustomer 'Id', C.NameCustomer 'Tên', C.PhoneNumber 'Số điện thoại', C.AddressCustomer 'Địa chỉ'
		FROM Customers C
	);
GO

--Function lấy thông tin khách hàng thông qua mã khách hàng
CREATE FUNCTION Fn_GetCustomerById (@IdCustomer CHAR(6))
RETURNS TABLE
AS
	RETURN (
		SELECT C.IdCustomer 'Id', C.NameCustomer 'Tên', C.PhoneNumber 'Số điện thoại', C.AddressCustomer 'Địa chỉ'
		FROM Customers C 
		WHERE C.IdCustomer = @IdCustomer
	);
GO

--Function lấy IdCustomer bằng PhoneNumber của Customer 
CREATE FUNCTION Fn_GetIdCustomerByPhoneNumber (@PhoneNumber CHAR(10))
RETURNS CHAR(6)
AS
BEGIN
	DECLARE @IdCustomer CHAR(6);
	
	SELECT @IdCustomer = Customers.IdCustomer
	FROM Customers
	WHERE Customers.PhoneNumber = @PhoneNumber;

	RETURN @IdCustomer;
END;
GO