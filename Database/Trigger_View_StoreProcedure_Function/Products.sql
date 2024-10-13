/*
CREATE TABLE Products(
	IdProduct CHAR(6) PRIMARY KEY,
	NameProduct NVARCHAR(100) NOT NULL,
	Unit NVARCHAR(30) NOT NULL,
	UnitPriceImport REAL NOT NULL,
	UnitPriceExport REAL NOT NULL,
	QuantityProduct REAL NOT NULL,
	IdTypeProduct CHAR(6) NOT NULL,
	IdSupplier CHAR(6) NOT NULL,
	ImageProduct IMAGE,
	CONSTRAINT FK_TypeProduct FOREIGN KEY (IdTypeProduct) REFERENCES TypeProducts(IdTypeProduct),
	CONSTRAINT FK_Supplier FOREIGN KEY (IdSupplier) REFERENCES Suppliers(IdSupplier),
	CONSTRAINT Check_Product CHECK (UnitPriceImport >= 0 AND UnitPriceExport >= 0 AND QuantityProduct >=0) 
);
*/
GO
USE QuanLyTaiChinhCuaHangXayDung
GO

--Store Procedure thực hiện việc thêm dữ liệu vào bảng Products 
CREATE PROCEDURE SP_InsertProduct 
	@IdProduct CHAR(6),
	@NameProduct NVARCHAR(100),
	@Unit NVARCHAR(30),
	@UnitPriceImport REAL,
	@UnitPriceExport REAL,
	@QuantityProduct REAL,
	@IdTypeProduct CHAR(6),
	@IdSupplier CHAR(6),
	@ImageProduct IMAGE,
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		INSERT INTO Products (IdProduct, NameProduct, Unit, UnitPriceImport, UnitPriceExport, 
								QuantityProduct, IdTypeProduct, IdSupplier, ImageProduct)
		VALUES Products (@IdProduct, @NameProduct, @Unit, @UnitPriceImport, @UnitPriceExport, 
								@QuantityProduct, @IdTypeProduct, @IdSupplier, @ImageProduct);

		SET @Result = 1;
	END TRY
	BEGIN CATCH
		SET @Result = 0;
	END CATCH

	RETURN @Result;
END;
GO

--Store Procedure thực hiện việc cập nhật dữ liệu vào bảng Products 
CREATE PROCEDURE SP_UpdateProduct 
	@IdProduct CHAR(6),
	@NameProduct NVARCHAR(100),
	@Unit NVARCHAR(30),
	@UnitPriceImport REAL,
	@UnitPriceExport REAL,
	@QuantityProduct REAL,
	@IdTypeProduct CHAR(6),
	@IdSupplier CHAR(6),
	@ImageProduct IMAGE,
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		UPDATE Products
		SET NameProduct=@NameProduct, Unit=@Unit, UnitPriceImport=@UnitPriceImport, 
			UnitPriceExport=@UnitPriceExport, QuantityProduct=@QuantityProduct, 
			IdTypeProduct=@IdTypeProduct, IdSupplier=@IdSupplier, ImageProduct=@ImageProduct 
		WHERE IdProduct=@IdProduct;

		SET @Result=1;
	END TRY
	BEGIN CATCH
		SET @Result=0;
	END CATCH

	RETURN @Result;
END;
GO

--Store Procedure thực hiện việc xóa dữ liệu vào bảng Products 
CREATE PROCEDURE SP_DeleteProduct
	@IdProduct CHAR(6),
	@Result INT
AS
BEGIN
	BEGIN TRY
		DELETE FROM Products WHERE Products.IdProduct=@IdProduct;

		SET @Result=1;
	END TRY
	BEGIN CATCH
		SET @Result=0;
	END CATCH
END;
GO

--Function thưc hiện việc lấy tất cả dữ liệu trong bảng Products
CREATE FUNCTION Fn_GetAllProduct()
RETURNS TABLE
AS
	RETURN 
	(
		SELECT IdProduct, NameProduct, Unit, UnitPriceImport, UnitPriceExport, 
								QuantityProduct, IdTypeProduct, IdSupplier, ImageProduct
		FROM Products
	);
--Function thực hiện việc lất ra thông tin của Product bằng IdProduct
CREATE FUNCTION Fn_GetProductById (@IdProduct CHAR(6))
RETURNS TABLE
AS
	RETURN
	(
		SELECT IdProduct, NameProduct, Unit, UnitPriceImport, UnitPriceExport, 
								QuantityProduct, IdTypeProduct, IdSupplier, ImageProduct
		FROM Products
		WHERE Products.IdProduct = @IdProduct
	);
GO

--Function tìm kiếm gần đúng sản phẩm bằng thông tin bất kì của sản phẩm trừ ImageProduct
CREATE FUNCTION Fn_FindSimilarProducts (@searchTerm NVARCHAR(100))
RETURNS @result TABLE (
    IdProduct CHAR(6),
    NameProduct NVARCHAR(100),
    Unit NVARCHAR(30),
    UnitPriceImport REAL,
    UnitPriceExport REAL,
    QuantityProduct REAL,
    IdTypeProduct CHAR(6),
    IdSupplier CHAR(6),
    ImageProduct IMAGE
)
AS
BEGIN
    INSERT INTO @result
    SELECT IdProduct, NameProduct, Unit, UnitPriceImport, UnitPriceExport, 
				QuantityProduct, IdTypeProduct, IdSupplier, ImageProduct
    FROM Products
    WHERE 
		IdProduct LIKE '%' + @searchTerm + '%' OR
        NameProduct LIKE '%' + @searchTerm + '%' OR
        Unit LIKE '%' + @searchTerm + '%' OR
        CAST(UnitPriceImport AS NVARCHAR) LIKE '%' + @searchTerm + '%' OR
        CAST(UnitPriceExport AS NVARCHAR) LIKE '%' + @searchTerm + '%' OR
        CAST(QuantityProduct AS NVARCHAR) LIKE '%' + @searchTerm + '%' OR
        IdTypeProduct LIKE '%' + @searchTerm + '%' OR
        IdSupplier LIKE '%' + @searchTerm + '%';
        
    RETURN;
END;
GO

--Function lấy ra thông tin sản phẩm do nhà cung cấp có mã IdSuppler cung cấp
CREATE FUNCTION Fn_GetProductByIdSupplier (@IdSupplier CHAR(6))
RETURNS TABLE
AS
	RETURN
	(
		SELECT IdProduct, NameProduct, Unit, UnitPriceImport, UnitPriceExport, 
								QuantityProduct, IdTypeProduct, IdSupplier, ImageProduct
		FROM Products 
		WHERE Products.IdSupplier=@IdSupplier
	);
GO
 
--Function lấy ra thông tin sản phẩm khi truyền vào khoảng giá mua vào @MinPrice, @MaxPrice
CREATE FUNCTION Fn_GetProductsByImportPriceRange (@MinPrice REAL, @MaxPrice REAL)
RETURNS TABLE
AS
	RETURN
	(
		SELECT IdProduct, NameProduct, Unit, UnitPriceImport, UnitPriceExport, 
				QuantityProduct, IdTypeProduct, IdSupplier, ImageProduct
		FROM Products P
		WHERE P.UnitPriceImport >= @MinPrice AND P.UnitPriceImport <= @MaxPrice
	);
GO

--Function lấy ra thông tin sản phẩm khi truyền vào khoảng giá bán ra @MinPrice, @MaxPrice
CREATE FUNCTION Fn_GetProductsByExportPriceRange (@MinPrice REAL, @MaxPrice REAL)
RETURNS TABLE
AS
	RETURN
	(
		SELECT IdProduct, NameProduct, Unit, UnitPriceImport, UnitPriceExport, 
				QuantityProduct, IdTypeProduct, IdSupplier, ImageProduct
		FROM Products P
		WHERE P.UnitPriceExport >= @MinPrice AND P.UnitPriceExport <= @MaxPrice
	);
GO

