/*
CREATE TABLE Products(
	IdProduct CHAR(6) PRIMARY KEY,
	NameProduct NVARCHAR(100) NOT NULL,
	Unit NVARCHAR(30) NOT NULL,
	UnitPriceImport DECIMAL(18, 2) NOT NULL,	--giá mua vào
	UnitPriceExport DECIMAL(18, 2) NOT NULL,	--giá bán ra
	QuantityProduct DECIMAL(18, 2) NOT NULL,
	IdTypeProduct CHAR(6) NOT NULL,
	IdSupplier CHAR(6),
	ImageProduct VARBINARY(MAX),
	CONSTRAINT FK_TypeProduct FOREIGN KEY (IdTypeProduct) REFERENCES TypeProducts(IdTypeProduct) ON DELETE CASCADE,
	CONSTRAINT FK_Supplier FOREIGN KEY (IdSupplier) REFERENCES Suppliers(IdSupplier) ON DELETE SET NULL,
	CONSTRAINT Check_Product CHECK (UnitPriceImport > 0 AND UnitPriceImport > 0 AND QuantityProduct >= 0) 
);
*/

GO
USE QuanLyTaiChinhCuaHangXayDung
GO
--Trigger đảm bảo không tồn tại giá trị rỗng ''
CREATE TRIGGER trg_EmptyProduct
ON Products
AFTER INSERT, UPDATE
AS
BEGIN
	IF 
	(
		EXISTS
		(
			SELECT 1 
			FROM Products P
			WHERE
				P.IdProduct = ''
				OR P.NameProduct = ''
				OR P.Unit = ''
				OR P.IdTypeProduct =''
				OR P.IdSupplier = ''
		)
	)
	BEGIN
		RAISERROR ('Không được phép thêm giá trị rỗng vào bảng Products.', 16, 1);
        ROLLBACK 
	END
END;
GO


--Store Procedure thực hiện việc thêm dữ liệu vào bảng Products 
CREATE PROCEDURE SP_InsertProduct 
	@IdProduct CHAR(6),
	@NameProduct NVARCHAR(100),
	@Unit NVARCHAR(30),
	@UnitPriceImport DECIMAL(18, 2),
	@UnitPriceExport DECIMAL(18, 2),
	@QuantityProduct DECIMAL(18, 2),
	@IdTypeProduct CHAR(6),
	@IdSupplier CHAR(6),
	@ImageProduct VARBINARY(MAX),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		IF (EXISTS(SELECT 1 FROM Products P WHERE P.IdProduct = @IdProduct))
		BEGIN
			SET @Result = 0;
		END
		ELSE
		BEGIN
			INSERT INTO Products (IdProduct, NameProduct, Unit, UnitPriceImport, UnitPriceExport, 
								QuantityProduct, IdTypeProduct, IdSupplier, ImageProduct)
			VALUES (@IdProduct, @NameProduct, @Unit, @UnitPriceImport, @UnitPriceExport, 
					@QuantityProduct, @IdTypeProduct, @IdSupplier, @ImageProduct);

			SET @Result = 1;
		END
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
	@UnitPriceImport DECIMAL(18, 2),
	@UnitPriceExport DECIMAL(18, 2),
	@QuantityProduct DECIMAL(18, 2),
	@IdTypeProduct CHAR(6),
	@IdSupplier CHAR(6),
	@ImageProduct VARBINARY(MAX),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		IF (EXISTS(SELECT 1 FROM Products WHERE IdProduct=@IdProduct))
		BEGIN
			UPDATE Products
			SET NameProduct=@NameProduct, Unit=@Unit, UnitPriceImport=@UnitPriceImport, 
				UnitPriceExport=@UnitPriceExport, QuantityProduct=@QuantityProduct, 
				IdTypeProduct=@IdTypeProduct, IdSupplier=@IdSupplier, ImageProduct=@ImageProduct 
			WHERE IdProduct=@IdProduct;

			SET @Result=1;
		END
		ELSE
		BEGIN
			SET @Result = 0;
		END
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
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		IF(EXISTS(SELECT 1 FROM Products WHERE IdProduct=@IdProduct))
		BEGIN
			DELETE FROM Products WHERE Products.IdProduct=@IdProduct;

			SET @Result = 1;
		END
		ELSE
		BEGIN
			SET @Result = 0;
		END
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
GO

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
CREATE FUNCTION Fn_SearchProducts (@SearchTerm NVARCHAR(150))
RETURNS TABLE
AS
RETURN 
(
    SELECT DISTINCT
        P.IdProduct, 
        P.NameProduct, 
        P.Unit, 
        P.UnitPriceImport, 
        P.UnitPriceExport, 
        P.QuantityProduct, 
		P.IdTypeProduct,
		P.IdSupplier,
		P.ImageProduct
    FROM 
        Products P
    INNER JOIN 
        TypeProducts T ON P.IdTypeProduct = T.IdTypeProduct
    INNER JOIN 
        Suppliers S ON P.IdSupplier = S.IdSupplier
    WHERE 
        P.IdProduct LIKE '%' + @SearchTerm + '%' 
        OR P.NameProduct LIKE '%' + @SearchTerm + '%'
        OR P.Unit LIKE '%' + @SearchTerm + '%'
		OR CAST(P.UnitPriceImport AS NVARCHAR(150)) LIKE '%' + @SearchTerm + '%' 
		OR CAST(P.UnitPriceExport AS NVARCHAR(150)) LIKE '%' + @SearchTerm + '%' 
		OR T.IdTypeProduct LIKE '%' + @SearchTerm + '%'
        OR T.NameTypeProduct LIKE '%' + @SearchTerm + '%'
		OR S.IdSupplier LIKE '%' + @SearchTerm + '%'
        OR S.NameSupplier LIKE '%' + @SearchTerm + '%'
		OR S.PhoneNumber LIKE '%' + @SearchTerm + '%'
		OR S.AddressSupplier LIKE '%' + @SearchTerm + '%'
);
GO