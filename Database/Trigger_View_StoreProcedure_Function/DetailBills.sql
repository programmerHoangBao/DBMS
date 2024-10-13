/*
--Chi tiết hóa đơn
CREATE TABLE DetailBills(
	IdBill CHAR(6) NOT NULL,
	IdProduct CHAR(6) NOT NULL,
	QuantityProduct REAL NOT NULL CHECK (QuantityProduct > 0),
	CONSTRAINT FK_Bill FOREIGN KEY (IdBill) REFERENCES Bills(IdBill) ON DELETE CASCADE,
	CONSTRAINT FK_Product FOREIGN KEY (IdProduct) REFERENCES Products(IdProduct) ON DELETE CASCADE,
);
GO
*/

GO
USE QuanLyTaiChinhCuaHangXayDung;
GO

--Store Procedure thực hiện thêm dữ liệu vào bảng DetailBills
CREATE PROCEDURE SP_InsertDetailBill 
	@IdBill CHAR(6),
	@IdProduct CHAR(6),
	@QuantityProduct REAL,
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		INSERT INTO DetailBills(IdBill, IdProduct, QuantityProduct)
		VALUES (@IdBill, @IdProduct, @QuantityProduct);

		SET @Result = 1;
	END TRY
	BEGIN CATCH
		SET @Result = 0;
	END CATCH
END;
GO

--Store Procedure thực hiện việc cập nhật sản phẩm vào bảng DeataiBills
CREATE PROCEDURE SP_UpdateDetailBill 
	@IdBill CHAR(6),
	@IdProduct CHAR(6),
	@QuantityProduct REAL,
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		UPDATE DetailBills
		SET IdProduct = @IdProduct, QuantityProduct = @QuantityProduct
		WHERE IdBill = @IdBill;

		SET @Result = 1;
	END TRY
	BEGIN CATCH
		SET @Result = 0;
	END CATCH
END;
GO

--Store Procedure thực hiện việc xóa dữ liệu trong bảng DeataiBills khi biết IdBill
CREATE PROCEDURE SP_DeleteDetailBillByIdBill
	@IdBill CHAR(6),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		DELETE FROM DetailBills WHERE DetailBills.IdBill = @IdBill;

		SET @Result = 1;
	END TRY
	BEGIN CATCH
		SET @Result = 0;
	END CATCH
END;
GO

--Store Procedure thực hiện việc xóa dữ liệu trong bảng DeataiBills khi biết IdBill, IdProduct

CREATE PROCEDURE SP_DeleteDetailBillByIdBillAndIdProduct
	@IdBill CHAR(6),
	@IdProduct CHAR(6),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		DELETE FROM DetailBills WHERE DetailBills.IdBill = @IdBill AND DetailBills.IdProduct = @IdProduct;

		SET @Result = 1;
	END TRY
	BEGIN CATCH
		SET @Result = 0;
	END CATCH
END;
GO
