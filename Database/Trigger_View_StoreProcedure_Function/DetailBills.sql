/*
--Chi tiết hóa đơn
CREATE TABLE DetailBills(
	IdBill CHAR(6) NOT NULL,
	IdProduct CHAR(6) NOT NULL,
	QuantityProduct DECIMAL(18, 2) NOT NULL CHECK (QuantityProduct > 0),
	CONSTRAINT FK_Bill FOREIGN KEY (IdBill) REFERENCES Bills(IdBill) ON DELETE CASCADE,
	CONSTRAINT FK_Product FOREIGN KEY (IdProduct) REFERENCES Products(IdProduct) ON DELETE CASCADE,
);
*/

GO
USE QuanLyTaiChinhCuaHangXayDung;
GO

-- Trigger kiểm tra số lượng sản phẩm trước khi thực hiện xuất sản phẩm
CREATE TRIGGER trg_CheckQuantityExport
ON DetailBills
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM Bills B
        JOIN inserted I ON B.IdBill = I.IdBill
        WHERE B.TypeBill = N'Hóa Đơn Xuất Hàng'
    )
    BEGIN
        IF EXISTS (
            SELECT 1
            FROM DetailBills DB
            JOIN Products P ON DB.IdProduct = P.IdProduct
            JOIN inserted I ON DB.IdBill = I.IdBill
            WHERE DB.QuantityProduct > P.QuantityProduct
        )
        BEGIN
            RAISERROR('Số lượng sản phẩm xuất khẩu vượt quá lượng hàng tồn kho sẵn có.', 16, 1);
            ROLLBACK TRANSACTION;
        END
    END
END;
GO


--Store Procedure thực hiện thêm dữ liệu vào bảng DetailBills
CREATE PROCEDURE SP_InsertDetailBill 
	@IdBill CHAR(6),
	@IdProduct CHAR(6),
	@QuantityProduct DECIMAL(18, 2),
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
	@QuantityProduct DECIMAL(18, 2),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		IF ( EXISTS(SELECT 1 FROM DetailBills WHERE IdBill=@IdBill AND IdProduct=@IdProduct) )
		BEGIN
			UPDATE DetailBills
			SET QuantityProduct = @QuantityProduct
			WHERE IdBill = @IdBill AND IdProduct = @IdProduct;

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

--Store Procedure thực hiện việc xóa dữ liệu trong bảng DeataiBills khi biết IdBill
CREATE PROCEDURE SP_DeleteDetailBillByIdBill
	@IdBill CHAR(6),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		IF ( EXISTS(SELECT 1 FROM DetailBills WHERE IdBill=@IdBill) )
		BEGIN 
			DELETE FROM DetailBills WHERE DetailBills.IdBill = @IdBill;

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

--Store Procedure thực hiện việc xóa dữ liệu trong bảng DeataiBills khi biết IdBill, IdProduct
CREATE PROCEDURE SP_DeleteDetailBillByIdBillAndIdProduct
	@IdBill CHAR(6),
	@IdProduct CHAR(6),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		IF ( EXISTS(SELECT 1 FROM DetailBills WHERE IdBill=@IdBill AND IdProduct=@IdProduct) )
		BEGIN
			DELETE FROM DetailBills WHERE DetailBills.IdBill = @IdBill AND DetailBills.IdProduct = @IdProduct;

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
