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

--trigger không có tồn tại giá trị rỗng ''
CREATE TRIGGER trg_EmptyCustomer
ON Customers
AFTER INSERT, UPDATE
AS
BEGIN
	IF
	(
		EXISTS
		(
			SELECT 1 
			FROM inserted
			WHERE
			(
				IdCustomer = ''
				OR NameCustomer = ''
				OR PhoneNumber = ''
				OR AddressCustomer = ''
			)
		)
	)
	BEGIN
		RAISERROR ('Không được phép thêm giá trị rỗng vào bảng Customers.', 16, 1);
        ROLLBACK 
	END
END;
GO


--Trigger kiểm tra NameCustomer là một tên hợp lệ không chứa kí tự số
CREATE TRIGGER trg_check_namecustomer
ON Customers
INSTEAD OF INSERT, UPDATE
AS
BEGIN
    DECLARE @name NVARCHAR(100);

    SELECT @name = NameCustomer FROM inserted;

    IF @name LIKE '%[0-9]%'
    BEGIN
        RAISERROR ('Tên khách hàng không được chứa ký tự số.', 16, 1);
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
		DECLARE @IdCustomer CHAR(6);

		SELECT @IdCustomer = IdCustomer FROM inserted;

		IF (EXISTS(SELECT 1 FROM Customers WHERE IdCustomer=@IdCustomer))
		BEGIN
			DECLARE @PhoneNumber CHAR(10);
			DECLARE @AddressCustomer NVARCHAR(150);

			SELECT @PhoneNumber = PhoneNumber, 
					@AddressCustomer = AddressCustomer 
			FROM inserted;

			UPDATE Customers 
			SET NameCustomer=@name, PhoneNumber=@PhoneNumber, AddressCustomer=@AddressCustomer
			WHERE IdCustomer=@IdCustomer;
		END
		ELSE
		BEGIN 
			INSERT INTO Customers
			SELECT * FROM inserted;
		END
    END
END;
GO


--Trigger kiểm tra PhoneNumber là chuổi số điện thoại Việt Nam
CREATE TRIGGER trg_checkPhoneNumberCustomers
ON Customers
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
		IF (EXISTS(SELECT 1 FROM Customers C  WHERE C.IdCustomer = @IdCustomer))
		BEGIN
			SET @Result = 0;
		END
		ELSE
		BEGIN
			INSERT INTO Customers (IdCustomer, NameCustomer, PhoneNumber, AddressCustomer)
			VALUES (@IdCustomer, @NameCustomer, @PhoneNumber, @AddressCustomer);

			SET @Result = 1;
		END
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
        IF (EXISTS(SELECT 1 FROM Customers WHERE Customers.IdCustomer=@IdCustomer))
		BEGIN
			UPDATE Customers 
			SET NameCustomer=@NameCustomer, PhoneNumber=@PhoneNumber, AddressCustomer=@AddressCustomer
			WHERE IdCustomer=@IdCustomer;

			SET @Result=1; 
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

----Store Procedure thưc hiện việc xóa dữ liệu trong bảng Customers
CREATE PROCEDURE SP_DeleteCustomer
	@IdCustomer CHAR(6),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		IF (EXISTS(SELECT 1 FROM Customers WHERE Customers.IdCustomer=@IdCustomer))
		BEGIN
			DELETE FROM Customers WHERE Customers.IdCustomer=@IdCustomer;

			SET @Result=1; 
		END
		ELSE
		BEGIN
			SET @Result=0;
		END
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
		SELECT C.IdCustomer , C.NameCustomer , C.PhoneNumber , C.AddressCustomer 
		FROM Customers C 
	);
GO

--Function lấy thông tin khách hàng thông qua mã khách hàng
CREATE FUNCTION Fn_GetCustomerById (@IdCustomer CHAR(6))
RETURNS TABLE
AS
	RETURN (
		SELECT C.IdCustomer , C.NameCustomer , C.PhoneNumber , C.AddressCustomer 
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

--Fnction lấy các customer bằng cách nhập vào một thông tin bất kì
CREATE FUNCTION Fn_SearchCustomer (@SearchTerm NVARCHAR(150))
RETURNS TABLE
AS	
	RETURN
	(
		SELECT DISTINCT
			C.IdCustomer,
			C.NameCustomer,
			C.PhoneNumber,
			C.AddressCustomer
		FROM Customers C 
		WHERE 
			C.IdCustomer LIKE '%' + @SearchTerm +'%'
			OR C.NameCustomer LIKE '%' + @SearchTerm +'%'
			OR C.PhoneNumber LIKE '%' + @SearchTerm +'%'
			OR C.AddressCustomer LIKE '%' + @SearchTerm +'%'
	);
