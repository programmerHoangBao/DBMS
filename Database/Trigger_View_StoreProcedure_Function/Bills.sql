
USE QuanLyTaiChinhCuaHangXayDung;
GO

--Trigger thực hiện việt set giá trị của TypeBill
CREATE TRIGGER trg_TypeBill
ON Bills
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE b
    SET TypeBill = CASE 
        WHEN EXISTS (SELECT 1 FROM Customers WHERE IdCustomer = i.IdCustomer AND i.IdCustomer IS NOT NULL) THEN 'Import Bill'
        WHEN EXISTS (SELECT 1 FROM Suppliers WHERE IdSupplier = i.IdSupplier AND i.IdSupplier IS NOT NULL) THEN 'Export Bill'
        ELSE b.TypeBill
    END
    FROM Bills b
    INNER JOIN inserted i ON b.IdBill = i.IdBill;
END;
GO

--Strore Procedure thực hiện việc thêm dữ liệu vào Bills
CREATE PROCEDURE SP_InsertBill
	@IdBill CHAR(6),
	@IdCustomer CHAR(6),
	@IdSupplier CHAR (6),
	@DateCreate DATE,
	@TypeBill CHAR(15),
	@Total REAL,
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		INSERT INTO Bills(IdBill, IdCustomer, IdSupplier, DateCreate, TypeBill, Total)
		VALUES (@IdBill, @IdCustomer, @IdSupplier, @DateCreate, @TypeBill, @Total);

		SET @Result = 1;
	END TRY
	BEGIN CATCH
		SET @Result = 0;
	END CATCH
END;
GO

--Strore Procedure thực hiện việc cập nhật dữ liệu vào Bills
CREATE PROCEDURE SP_UpdateBill 
	@IdBill CHAR(6),
	@IdCustomer CHAR(6),
	@IdSupplier CHAR (6),
	@DateCreate DATE,
	@TypeBill CHAR(15),
	@Total REAL,
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		UPDATE Bills 
		SET IdCustomer=@IdCustomer, IdSupplier=@IdSupplier, 
		DateCreate=@DateCreate, TypeBill=@TypeBill, Total=@Total 
		WHERE IdBill = @IdBill;

		SET @Result = 1;
	END TRY
	BEGIN CATCH
		SET @Result = 0;
	END CATCH
END;
GO

--Strore Procedure thực hiện việc xóa dữ liệu vào Bills
CREATE PROCEDURE SP_DeleteBill  
	@IdBill CHAR(6),
AS
BEGIN
	BEGIN TRY
		DELETE FROM Bills WHERE IdBill = @IdBill;

		SET @Result = 1;
	END TRY
	BEGIN CATCH
		SET @Result = 0;
	END CATCH
END;
GO

--Function thực hiện việc tính tổng hóa đơn
CREATE FUNCTION Fn_TotalBillImport (@IdBill CHAR(6))
RETURNS REAL
AS
BEGIN
	DECLARE @TotalBill REAL;

	SELECT @TotalBill=SUM(Products.UnitPriceImport * DetailBills.QuantityProduct) 
	FROM (DetailBills INNER JOIN Products 
			ON DetailBills.IdProduct = Products.IdProduct )
	WHERE DetailBills.IdBill=@IdBill;

	RETURN @TotalBill;
END;
GO

--Function lấy ra tất cả dữ liệu bảng Bills thuộc loại 'Import Bill'
CREATE FUNCTION Fn_GetAllImportBill ()
RETURNS TABLE
AS
	RETURN
	(
		SELECT IdBill, IdSupplier, DateCreate, TypeBill, Total 
		FROM Bills 
		WHERE TypeBill = 'Import Bill'
	);
GO
--Function lấy ra tất cả dữ liệu bảng Bills thuộc loại 'Export Bill'
CREATE FUNCTION Fn_GetAllExportBill ()
RETURNS TABLE
AS
	RETURN
	(
		SELECT IdBill, IdCustomer, DateCreate, TypeBill, Total 
		FROM Bills 
		WHERE TypeBill = 'Export Bill'
	);
GO

--Function Tính tổng giá trị hóa đơn của tất cả Bill thuộc loại Import Bill
CREATE FUNCTION Fn_TotalValueOfAllImportBill ()
RETURNS REAL
AS
BEGIN
	DECLARE @TotalValue REAL;

	SELECT @TotalValue=SUM(Bills.Total) 
	FROM Bills 
	WHERE Bills.TypeBill = 'Import Bill';

	RETURN @TotalValue;
END;
GO

--Function tính tổng giá trị hóa đơn của tất cả các Bill thuộc loại Export Bill
CREATE FUNCTION Fn_TotalValueOfAllExportBill ()
RETURNS REAL
AS
BEGIN
	DECLARE @TotalValue REAL;

	SELECT @TotalValue=SUM(Bills.Total) 
	FROM Bills 
	WHERE Bills.TypeBill = 'Export Bill';

	RETURN @TotalValue;
END;
GO

--Function lấy ra danh sách sản phẩm của Bill thuộc loại Import Bill khi biết IdBill
CREATE FUNCTION Fn_GetListProductImportBill (@IdBill CHAR(6))
RETURNS TABLE
AS
	RETURN
	(
		SELECT Products.IdProduct, Products.NameProduct, Products.Unit, 
				Products.UnitPriceImport 
		FROM ((Bills INNER JOIN DetailBills 
				ON Bills.IdBill = DetailBills.IdBill) 
			  INNER JOIN Products
			    ON DetailBills.IdProduct = Products.IdProduct) 
		WHERE (Bills.IdBill = @IdBill AND Bills.TypeBill = 'Import Bill')
	);
GO

--Function lấy ra danh sách sản phẩm của Bill thuộc loại Import Bill khi biết IdBill
CREATE FUNCTION Fn_GetListProductExportBill (@IdBill CHAR(6))
RETURNS TABLE
AS
	RETURN
	(
		SELECT Products.IdProduct, Products.NameProduct, Products.Unit, 
				Products.UnitPriceImport 
		FROM ((Bills INNER JOIN DetailBills 
				ON Bills.IdBill = DetailBills.IdBill) 
			  INNER JOIN Products
			    ON DetailBills.IdProduct = Products.IdProduct) 
		WHERE (Bills.IdBill = @IdBill AND Bills.TypeBill = 'Export Bill')
	);
GO


--Function lấy ra IdBill qua IdCustomer và DateCreate của Exporpt Bill
CREATE FUNCTION Fn_GetIdBillByIdCustomerAndDateCreate (
	@IdCustomer CHAR(6),
	@DateCreate DATE
)
RETURNS TABLE
AS
	RETURN
	(
		SELECT Bills.IdBill
		FROM Bills
		WHERE (Bills.IdCustomer = @IdCustomer 
				AND CAST(Bills.DateCreate AS DATE) = CAST(@DateCreate AS DATE) 
				AND Bills.TypeBill = 'Export Bill')
	);
GO
--Function lấy ra IdBill qua IdSupplier và DateCreate của Import Bill
CREATE FUNCTION Fn_GetIdBillByIdSupplierAndDateCreate (
	@IdSupplier CHAR(6),
	@DateCreate DATE
)
RETURNS TABLE
AS
	RETURN
	(
		SELECT Bills.IdSupplier
		FROM Bills
		WHERE (Bills.IdSupplier = @IdSupplier 
		AND CAST(Bills.DateCreate AS DATE) = CAST(@DateCreate AS DATE) 
		AND Bills.TypeBill = 'Import Bill')
	);
GO

--Function lấy ra IdBill qua IdCustomer của bill Exporpt Bill
CREATE FUNCTION Fn_GetIdBillByIdCustomer (
	@IdCustomer CHAR(6),
	@DateCreate DATE
)
RETURNS TABLE
AS
	RETURN
	(
		SELECT Bills.IdBill
		FROM Bills
		WHERE (Bills.IdCustomer = @IdCustomer 
				AND Bills.TypeBill = 'Export Bill')
	);
GO
--Function lấy ra IdBill qua IdSupplier  của bill Import Bill
CREATE FUNCTION Fn_GetIdBillByIdSupplier (
	@IdSupplier CHAR(6),
	@DateCreate DATE
)
RETURNS TABLE
AS
	RETURN
	(
		SELECT Bills.IdSupplier
		FROM Bills
		WHERE (Bills.IdSupplier = @IdSupplier 
		AND Bills.TypeBill = 'Import Bill')
	);
GO
