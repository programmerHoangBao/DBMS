/*
CREATE TABLE TypeProducts(
	IdTypeProduct CHAR(6) PRIMARY KEY,
	NameTypeProduct NVARCHAR(100) UNIQUE NOT NULL
);
*/

GO
USE QuanLyTaiChinhCuaHangXayDung
GO

--Store Procedure thực hiện việc thêm dữ liệu vào TypeProducts
CREATE PROCEDURE SP_InsertTypeProduct
	@IdTypeProduct CHAR(6),
	@NameTypeProduct NVARCHAR(100),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		INSERT INTO TypeProducts (IdTypeProduct, NameTypeProduct) 
		VALUES (@IdTypeProduct, @NameTypeProduct);
		
		SET @Result = 1;
	END TRY
	BEGIN CATCH
		SET @Result = 0;
	END CATCH
END;
GO

--Store Procedure thực hiện việc cập nhật liệu vào TypeProducts
CREATE PROCEDURE SP_UpdateTypeProduct
	@IdTypeProduct CHAR(6),
	@NameTypeProduct NVARCHAR(100),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		IF (EXISTS(SELECT 1 FROM TypeProducts WHERE IdTypeProduct=@IdTypeProduct))
		BEGIN
			UPDATE TypeProducts 
			SET NameTypeProduct=@NameTypeProduct 
			WHERE IdTypeProduct=@IdTypeProduct;
		
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

--Store Procedure thực hiện việc xóa dữ liệu vào TypeProducts
CREATE PROCEDURE SP_DeleteTypeProduct 
	@IdTypeProduct CHAR(6),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		IF (EXISTS(SELECT 1 FROM TypeProducts WHERE IdTypeProduct=@IdTypeProduct))
		BEGIN
			DELETE FROM TypeProducts WHERE TypeProducts.IdTypeProduct=@IdTypeProduct;

			SET @Result=1;
		END
		ELSE
		BEGIN 
			SET @Result=0;
		END
	END TRY
	BEGIN CATCH
		SET @Result=0;
	END CATCH
END;
GO

--Function thực hiện việt lất ra tất cả các TypeProduct
CREATE FUNCTION Fn_GetAllTypeProduct()
RETURNS TABLE
AS
	RETURN
	(
		SELECT TP.IdTypeProduct AS 'Id', TP.NameTypeProduct AS 'Mã loại sản phẩm'
		FROM TypeProducts TP
	);
GO

--Function thực hiện việt lất ra NameTypeProduct của TypeProduct thông qua IdTypeProdcut
CREATE FUNCTION Fn_GetNameTypeProductById (@IdTypeProduct CHAR(6))
RETURNS NVARCHAR(100)
AS
BEGIN
	DECLARE @NameTypeProduct NVARCHAR(100);

	SELECT @NameTypeProduct=TP.NameTypeProduct 
	FROM TypeProducts TP
	WHERE TP.IdTypeProduct = @IdTypeProduct;

	RETURN @NameTypeProduct;
END;
GO

--Function thực hiện việt lấy ra IdTypeProduct thông qua NameTypeProduct
CREATE FUNCTION Fn_GetIdByNameTypeProduct (@NameTypeProduct NVARCHAR(100))
RETURNS CHAR(6)
AS
BEGIN
	DECLARE @IdTypeProduct CHAR(6);

	SELECT @IdTypeProduct=TP.IdTypeProduct
	FROM TypeProducts TP
	WHERE TP.NameTypeProduct=@NameTypeProduct;

	RETURN @IdTypeProduct;
END;
GO

--Function Lấy ra thông tin TypeProduct khi biết IdTypeProduct
CREATE FUNCTION Fn_GetTypeProduct (@IdTypeProduct CHAR(6))
RETURNS TABLE
AS
	RETURN
	(
		SELECT IdTypeProduct, NameTypeProduct
		FROM TypeProducts
		WHERE TypeProducts.IdTypeProduct=@IdTypeProduct
	);
