/*
CREATE TABLE Bills(
	IdBill CHAR(6) PRIMARY KEY,
	IdCustomer CHAR(6),
	IdSupplier CHAR (6),
	DateCreate DATE NOT NULL,
	TypeBill NVARCHAR(20) NOT NULL,
	Total DECIMAL(18, 2) NOT NULL,
	FOREIGN KEY (IdCustomer) REFERENCES Customers(IdCustomer) ON DELETE SET NULL,
	FOREIGN KEY (IdSupplier) REFERENCES Suppliers(IdSupplier) ON DELETE SET NULL,
	CHECK (TypeBill IN (N'Hóa Đơn Nhập Hàng', N'Hóa Đơn Xuất Hàng'))
);
*/

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
        WHEN EXISTS (SELECT 1 FROM Customers WHERE IdCustomer = i.IdCustomer AND i.IdCustomer IS NOT NULL) THEN N'Hóa Đơn Xuất Hàng'
        WHEN EXISTS (SELECT 1 FROM Suppliers WHERE IdSupplier = i.IdSupplier AND i.IdSupplier IS NOT NULL) THEN N'Hóa Đơn Nhập Hàng'
        ELSE b.TypeBill
    END
    FROM Bills b
    INNER JOIN inserted i ON b.IdBill = i.IdBill;
END;
GO

--Strore Procedure thực hiện việc thêm hóa đơn thuộc loại nhập hàng vào Bills
CREATE PROCEDURE SP_InsertImportBill
	@IdBill CHAR(6),
	@IdSupplier CHAR(6),
	@DateCreate DATE,
	@TypeBill NVARCHAR(20),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		INSERT INTO Bills(IdBill, IdSupplier, DateCreate, TypeBill)
		VALUES (@IdBill, @IdSupplier, @DateCreate, @TypeBill);

		SET @Result = 1;
	END TRY
	BEGIN CATCH
		SET @Result = 0;
	END CATCH
END;
GO

--Strore Procedure thực hiện việc thêm hóa đơn thuộc loại xuất hàng vào Bills
CREATE PROCEDURE SP_InsertExportBill
	@IdBill CHAR(6),
	@IdCustomer CHAR(6),
	@DateCreate DATE,
	@TypeBill NVARCHAR(20),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		INSERT INTO Bills(IdBill, IdCustomer, DateCreate, TypeBill)
		VALUES (@IdBill, @IdCustomer, @DateCreate, @TypeBill);

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
	@TypeBill NVARCHAR(20),
	@Total DECIMAL(18, 2),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		IF(EXISTS(SELECT 1 FROM Bills WHERE Bills.IdBill=@IdBill))
		BEGIN
			UPDATE Bills 
			SET IdCustomer=@IdCustomer, IdSupplier=@IdSupplier, 
			DateCreate=@DateCreate, TypeBill=@TypeBill, Total=@Total 
			WHERE IdBill = @IdBill;

			SET @Result = 1;
		END
		ELSE
		BEGIN
			SET @Result = 0;
		END
	END TRY
	BEGIN CATCH
		SET @Result = 0;
	END CATCH
END;
GO

--Strore Procedure thực hiện việc xóa dữ liệu vào Bills
CREATE PROCEDURE SP_DeleteBill  
	@IdBill CHAR(6),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		IF(EXISTS(SELECT 1 FROM Bills WHERE Bills.IdBill=@IdBill))
		BEGIN
			DELETE FROM Bills WHERE IdBill = @IdBill;

			SET @Result = 1;
		END
		ELSE
		BEGIN
			SET @Result = 0;
		END
	END TRY
	BEGIN CATCH
		SET @Result = 0;
	END CATCH
END;
GO

--Function thực hiện việc tính tổng giá trị hóa đơn nhập hàng khi có mã hóa đơn xác định
CREATE FUNCTION Fn_TotalImportBill (@IdBill CHAR(6))
RETURNS DECIMAL(18, 2)
AS
BEGIN
	DECLARE @TotalBill DECIMAL(18, 2);

	SELECT @TotalBill=SUM(Products.UnitPriceImport * DetailBills.QuantityProduct) 
	FROM (DetailBills INNER JOIN Products 
			ON DetailBills.IdProduct = Products.IdProduct )
		 INNER JOIN Bills 
			ON Bills.IdBill = DetailBills.IdBill
	WHERE DetailBills.IdBill=@IdBill AND Bills.TypeBill = N'Hóa Đơn Nhập Hàng';

	IF (@TotalBill IS NULL)
	BEGIN
		SET @TotalBill=-1;
	END
	RETURN @TotalBill;
END;
GO

--Function thực hiện việc tính tống giá trị hóa đơn xuất hàng khi có mã hóa đơn
CREATE FUNCTION Fn_TotalExportBill (@IdBill CHAR(6))
RETURNS DECIMAL(18, 2)
AS
BEGIN
	DECLARE @TotalBill DECIMAL(18, 2);

	SELECT @TotalBill=SUM(Products.UnitPriceExport * DetailBills.QuantityProduct) 
	FROM (DetailBills INNER JOIN Products 
			ON DetailBills.IdProduct = Products.IdProduct )
		 INNER JOIN Bills 
			ON Bills.IdBill = DetailBills.IdBill
	WHERE DetailBills.IdBill=@IdBill AND Bills.TypeBill = N'Hóa Đơn Xuất Hàng';

	IF (@TotalBill IS NULL)
	BEGIN
		SET @TotalBill=-1;
	END
	RETURN @TotalBill;
END;
GO

--Function lấy ra tất cả dữ liệu bảng Bills thuộc loại N'Hóa Đơn Nhập Hàng'
CREATE FUNCTION Fn_GetAllImportBill ()
RETURNS TABLE
AS
	RETURN
	(
		SELECT IdBill, IdSupplier, DateCreate, TypeBill, Total 
		FROM Bills 
		WHERE TypeBill = N'Hóa Đơn Nhập Hàng'
	);
GO

--Function lấy ra tất cả dữ liệu bảng Bills thuộc loại N'Hóa Đơn Xuất Hàng'
CREATE FUNCTION Fn_GetAllExportBill ()
RETURNS TABLE
AS
	RETURN
	(
		SELECT IdBill, IdCustomer, DateCreate, TypeBill, Total 
		FROM Bills 
		WHERE TypeBill = N'Hóa Đơn Xuất Hàng'
	);
GO

--Function lấy ra thông tin sản phẩm của Bill thuộc loại N'Hóa Đơn Nhập Hàng' khi biết IdBill
CREATE FUNCTION Fn_GetListProductImportBill (@IdBill CHAR(6))
RETURNS TABLE
AS
	RETURN
	(
		SELECT Products.IdProduct, Products.NameProduct, Products.Unit, 
				Products.UnitPriceImport, DetailBills.QuantityProduct,
				Products.ImageProduct
		FROM ((Bills INNER JOIN DetailBills 
				ON Bills.IdBill = DetailBills.IdBill) 
			  INNER JOIN Products
			    ON DetailBills.IdProduct = Products.IdProduct) 
		WHERE (Bills.IdBill = @IdBill AND Bills.TypeBill = N'Hóa Đơn Nhập Hàng')
	);
GO

--Function lấy ra thông tin sản phẩm của Bill thuộc loại N'Hóa Đơn Xuất Hàng' khi biết IdBill
CREATE FUNCTION Fn_GetListProductExportBill (@IdBill CHAR(6))
RETURNS TABLE
AS
	RETURN
	(
		SELECT Products.IdProduct, Products.NameProduct, Products.Unit, 
				Products.UnitPriceImport, DetailBills.QuantityProduct,
				Products.ImageProduct
		FROM ((Bills INNER JOIN DetailBills 
				ON Bills.IdBill = DetailBills.IdBill) 
			  INNER JOIN Products
			    ON DetailBills.IdProduct = Products.IdProduct) 
		WHERE (Bills.IdBill = @IdBill AND Bills.TypeBill = N'Hóa Đơn Xuất Hàng')
	);
GO

--Function thực hiện tìm hóa đơn nhập hàng khi biết thông tin bất kì của hóa đơn nhập hàng
CREATE FUNCTION Fn_SearchImportBill(@SearchTerm NVARCHAR(150))
RETURNS TABLE 
AS
	RETURN
	(
		SELECT DISTINCT
			B.IdBill,
			B.DateCreate,
			B.IdSupplier,
			B.TypeBill,
			B.Total
		FROM 
			Bills B
		INNER JOIN 
			DetailBills DB ON B.IdBill = DB.IdBill 
		INNER JOIN 
			Products P ON DB.IdProduct = P.IdProduct 
		INNER JOIN 
			Suppliers S ON B.IdSupplier = S.IdSupplier 
		WHERE 
		(
			B.IdBill LIKE '%' + @SearchTerm + '%'
			OR B.DateCreate LIKE '%' + @SearchTerm + '%'
			OR B.Total LIKE '%' + @SearchTerm + '%'
			OR P.IdProduct LIKE '%' + @SearchTerm + '%' 
			OR P.NameProduct LIKE '%' + @SearchTerm + '%'
			OR S.IdSupplier LIKE '%' + @SearchTerm + '%'
			OR S.NameSupplier LIKE '%' + @SearchTerm + '%'
			OR S.PhoneNumber LIKE '%' + @SearchTerm + '%'
			OR S.AddressSupplier LIKE '%' + @SearchTerm + '%'
		) AND B.TypeBill = N'Hóa Đơn Nhập Hàng'
	);
GO

--Function thực hiện tìm hóa đơn xuất hàng khi biết thông tin bất kì của hóa đơn xuất hàng
CREATE FUNCTION Fn_SearchExportBill(@SearchTerm NVARCHAR(150))
RETURNS TABLE
AS
	RETURN
	(
		SELECT DISTINCT
			B.IdBill,
			B.DateCreate,
			B.IdCustomer,
			B.TypeBill,
			B.Total
		FROM 
			Bills B
		INNER JOIN 
			DetailBills DB ON B.IdBill = DB.IdBill 
		INNER JOIN 
			Products P ON DB.IdProduct = P.IdProduct 
		INNER JOIN 
			Customers C ON B.IdCustomer = C.IdCustomer 
		WHERE 
		(
			B.IdBill LIKE '%' + @SearchTerm + '%'
			OR B.DateCreate LIKE '%' + @SearchTerm + '%'
			OR B.Total LIKE '%' + @SearchTerm + '%'
			OR P.IdProduct LIKE '%' + @SearchTerm + '%' 
			OR P.NameProduct LIKE '%' + @SearchTerm + '%' 
			OR C.IdCustomer LIKE '%' + @SearchTerm + '%'
			OR C.NameCustomer LIKE '%' + @SearchTerm + '%'
			OR C.PhoneNumber LIKE '%' + @SearchTerm + '%'
			OR C.AddressCustomer LIKE '%' + @SearchTerm + '%'
		) AND B.TypeBill = N'Hóa Đơn Xuất Hàng'
	);
GO