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
        WHEN EXISTS (SELECT 1 FROM Customers WHERE IdCustomer = i.IdCustomer AND i.IdCustomer IS NOT NULL) THEN N'Hóa Đơn Nhập Hàng'
        WHEN EXISTS (SELECT 1 FROM Suppliers WHERE IdSupplier = i.IdSupplier AND i.IdSupplier IS NOT NULL) THEN N'Hóa Đơn Xuất Hàng'
        ELSE b.TypeBill
    END
    FROM Bills b
    INNER JOIN inserted i ON b.IdBill = i.IdBill;
END;
GO

--Strore Procedure thực hiện việc thêm hóa đơn thuộc loại nhập hàng vào Bills
CREATE PROCEDURE SP_InsertImportBill
	@IdBill CHAR(6),
	@IdCustomer CHAR(6),
	@DateCreate DATE,
	@TypeBill CHAR(15),
	@Total DECIMAL(18, 2),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		INSERT INTO Bills(IdBill, IdCustomer, DateCreate, TypeBill, Total)
		VALUES (@IdBill, @IdCustomer, @DateCreate, @TypeBill, @Total);

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
	@IdSupplier CHAR(6),
	@DateCreate DATE,
	@TypeBill CHAR(15),
	@Total DECIMAL(18, 2),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		INSERT INTO Bills(IdBill, IdSupplier, DateCreate, TypeBill, Total)
		VALUES (@IdBill, @IdSupplier, @DateCreate, @TypeBill, @Total);

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

--Function lấy ra IdBill qua IdSupplier và DateCreate của N'Hóa Đơn Nhập Hàng'
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
		AND Bills.TypeBill = N'Hóa Đơn Nhập Hàng')
	);
GO

--Function lấy ra IdBill qua IdCustomer và DateCreate của N'Hóa Đơn Xuất Hàng'
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
				AND Bills.TypeBill = N'Hóa Đơn Xuất Hàng')
	);
GO

--Function lấy ra IdBill qua IdSupplier  của bill N'Hóa Đơn Nhập Hàng'
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
		AND Bills.TypeBill = N'Hóa Đơn Nhập Hàng')
	);
GO

--Function lấy ra IdBill qua IdCustomer của bill N'Hóa Đơn Xuất Hàng'
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
				AND Bills.TypeBill = N'Hóa Đơn Xuất Hàng')
	);
GO

--Function tính tổng giá trị bill nhập hàng trong một ngày cụ thể
CREATE FUNCTION Fn_CalculateImportBillTotalByDate
(
    @InputDate DATE
)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @Total DECIMAL(18, 2);
   
    SELECT @Total = SUM(Bills.Total)
    FROM Bills
    WHERE 
        (YEAR(Bills.DateCreate) = YEAR(@InputDate) AND 
         MONTH(Bills.DateCreate) = MONTH(@InputDate) AND 
         DAY(Bills.DateCreate) = DAY(@InputDate)) AND
		 Bills.TypeBill=N'Hóa Đơn Nhập Hàng';
    
    RETURN ISNULL(@Total, 0);
END;
GO

--Function tính tổng giá trị bill xuất hàng trong một ngày cụ thể
CREATE FUNCTION Fn_CalculateExportBillTotalByDate
(
    @InputDate DATE
)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @Total DECIMAL(18, 2);
   
    SELECT @Total = SUM(Bills.Total)
    FROM Bills
    WHERE 
        (YEAR(Bills.DateCreate) = YEAR(@InputDate) AND 
         MONTH(Bills.DateCreate) = MONTH(@InputDate) AND 
         DAY(Bills.DateCreate) = DAY(@InputDate)) AND
		 Bills.TypeBill=N'Hóa Đơn Xuất Hàng';
    
    RETURN ISNULL(@Total, 0);
END;
GO

--Function tính tổng giá trị bill nhập hàng trong một tháng cụ thể trong năm
CREATE FUNCTION Fn_CalculateImportBillByMonth
(
    @Month INT,
	@Year INT
)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @Total DECIMAL(18, 2);
   
    SELECT @Total = SUM(Bills.Total)
    FROM Bills
    WHERE 
         YEAR(Bills.DateCreate) = @Year AND 
         MONTH(Bills.DateCreate) = @Month AND 
		 Bills.TypeBill=N'Hóa Đơn Nhập Hàng';
    
    RETURN ISNULL(@Total, 0);
END;
GO

--Function tính tổng giá trị bill xuất hàng trong một tháng cụ thể trong năm
CREATE FUNCTION Fn_CalculateExportBillByMonth
(
    @Month INT,
	@Year INT
)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @Total DECIMAL(18, 2);
   
    SELECT @Total = SUM(Bills.Total)
    FROM Bills
    WHERE 
         YEAR(Bills.DateCreate) = @Year AND 
         MONTH(Bills.DateCreate) = @Month AND 
		 Bills.TypeBill=N'Hóa Đơn Xuất Hàng';
    
    RETURN ISNULL(@Total, 0);
END;
GO

--Function tính tổng giá trị bill nhập hàng trong một năm cụ thể
CREATE FUNCTION Fn_CalculateImportBillByYear
(
	@Year INT
)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @Total DECIMAL(18, 2);
   
    SELECT @Total = SUM(Bills.Total)
    FROM Bills
    WHERE 
         YEAR(Bills.DateCreate) = @Year AND 
		 Bills.TypeBill=N'Hóa Đơn Nhập Hàng';
    
    RETURN ISNULL(@Total, 0);
END;
GO

--Function tính tổng giá trị bill xuất hàng trong một năm cụ thể
CREATE FUNCTION Fn_CalculateExportBillByYear
(
	@Year INT
)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @Total DECIMAL(18, 2);
   
    SELECT @Total = SUM(Bills.Total)
    FROM Bills
    WHERE 
         YEAR(Bills.DateCreate) = @Year AND 
		 Bills.TypeBill=N'Hóa Đơn Xuất Hàng';
    
    RETURN ISNULL(@Total, 0);
END;
GO