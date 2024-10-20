/*
CREATE TABLE TypeProducts(
	IdTypeProduct CHAR(6) PRIMARY KEY,
	NameTypeProduct NVARCHAR(100) UNIQUE NOT NULL
);
*/

GO
USE QuanLyTaiChinhCuaHangXayDung
GO

--Trigger đảm bảo trong bảng TypeProducts không có tồn tại giá trị rổng ''
CREATE TRIGGER trg_EmptyTypeProduct
ON TypeProducts
AFTER INSERT, UPDATE
AS
BEGIN
	IF 
	(
		EXISTS
		(
			SELECT 1 
			FROM TypeProducts TP
			WHERE
				TP.IdTypeProduct = ''
				OR TP.NameTypeProduct = ''
		)
	)
	BEGIN
		RAISERROR ('Không được phép thêm giá trị rỗng vào bảng TypeProducts.', 16, 1);
        ROLLBACK 
	END
END;
GO

--Store Procedure thực hiện việc thêm dữ liệu vào TypeProducts
CREATE PROCEDURE SP_InsertTypeProduct
	@IdTypeProduct CHAR(6),
	@NameTypeProduct NVARCHAR(100),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		IF (EXISTS(SELECT 1 FROM TypeProducts TP WHERE TP.IdTypeProduct = @IdTypeProduct))
		BEGIN
			SET @Result = 0;
		END
		ELSE
		BEGIN
			INSERT INTO TypeProducts (IdTypeProduct, NameTypeProduct) 
			VALUES (@IdTypeProduct, @NameTypeProduct);

			SET @Result = 1;
		END

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
		SELECT TP.IdTypeProduct, TP.NameTypeProduct
		FROM TypeProducts TP
	);
GO

--Function Lấy ra thông tin TypeProduct khi biết IdTypeProduct
CREATE FUNCTION Fn_GetTypeProductById (@IdTypeProduct CHAR(6))
RETURNS TABLE
AS
	RETURN
	(
		SELECT IdTypeProduct, NameTypeProduct
		FROM TypeProducts
		WHERE TypeProducts.IdTypeProduct=@IdTypeProduct
	);
GO
