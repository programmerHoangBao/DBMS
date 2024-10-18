/*
--Phiếu thu chi của các loại phí phát sinh như xăng xe, sửa chửa,...
CREATE TABLE ExpenseSlips(
	IdExpenseSlip CHAR(6) PRIMARY KEY,
	DateCreate DATE NOT NULL,
	Content NVARCHAR(MAX),
	TypeExpenseSlip NVARCHAR(10) NOT NULL CHECK (TypeExpenseSlip IN (N'Phiếu Thu', N'Phiếu Chi')),
	TotalMoney DECIMAL(18, 2) NOT NULL CHECK (TotalMoney > 0),
);
*/

GO
USE QuanLyTaiChinhCuaHangXayDung;
GO

--Store Procedure thực hiện thêm dữ liệu vào bảng ExpenseSlips
CREATE PROCEDURE SP_InsertExpenseSlip
	@IdExpenseSlip CHAR(6),
	@DateCreate DATE,
	@Content NVARCHAR(MAX),
	@TypeExpenseSlip CHAR(15),
	@TotalMoney DECIMAL(18, 2),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		INSERT INTO ExpenseSlips(IdExpenseSlip, DateCreate, Content, TypeExpenseSlip, TotalMoney)
		VALUES (@IdExpenseSlip, @DateCreate, @Content, @TypeExpenseSlip, @TotalMoney);

		SET @Result = 1;
	END TRY
	BEGIN CATCH
		SET @Result = 0;
	END CATCH
END;
GO

--Store Procedure thực hiện cập nhật dữ liệu vào bảng ExpenseSlips
CREATE PROCEDURE SP_UpdateExpenseSlip
	@IdExpenseSlip CHAR(6),
	@DateCreate DATE,
	@Content NVARCHAR(MAX),
	@TypeExpenseSlip CHAR(15),
	@TotalMoney DECIMAL(18, 2),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		IF ( EXISTS(SELECT 1 FROM ExpenseSlips WHERE IdExpenseSlip=@IdExpenseSlip) )
		BEGIN
			UPDATE ExpenseSlips
			SET DateCreate=@DateCreate, Content=@Content, 
			TypeExpenseSlip=@TypeExpenseSlip, TotalMoney=@TotalMoney 
			WHERE IdExpenseSlip=@IdExpenseSlip;

			SET @Result = 1;
		END
		ELSE
		BEGIN
			SET @Result = 0;
		END;
	END TRY
	BEGIN CATCH
		SET @Result = 0;
	END CATCH
END;
GO

--Store Procedure thực hiện xóa dữ liệu trong bảng ExpenseSlips
CREATE PROCEDURE SP_DeleteExpenseSlip
	@IdExpenseSlip CHAR(6),
	@Result INT OUTPUT
AS
BEGIN
	BEGIN TRY
		IF ( EXISTS(SELECT 1 FROM ExpenseSlips WHERE IdExpenseSlip=@IdExpenseSlip) )
		BEGIN
			DELETE FROM ExpenseSlips WHERE ExpenseSlips.IdExpenseSlip = @IdExpenseSlip;

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

--Function lấy ra tất cả các ExpenseSlip
CREATE FUNCTION Fn_GetAllExpenseSlip()
RETURNS TABLE
AS
	RETURN
	(
		SELECT 
			EX.IdExpenseSlip,
			EX.Content,
			EX.TypeExpenseSlip,
			EX.TotalMoney
		FROM ExpenseSlips EX
	);
GO

--Function lấy ra ExpenseSlip bằng IdExpenseSlip
CREATE FUNCTION Fn_GetExpenseSlipById (@IdExpenseSlip CHAR(6))
RETURNS TABLE
AS
	RETURN
	(
		SELECT 
			EX.IdExpenseSlip,
			EX.Content,
			EX.TypeExpenseSlip,
			EX.TotalMoney
		FROM ExpenseSlips EX
		WHERE EX.IdExpenseSlip = @IdExpenseSlip
	);
GO

--Function lấy ra các ExpenseSlip thuộc loại phiếu thu 
CREATE FUNCTION Fn_GetExpenseSlipReceive ()
RETURNS TABLE
AS
	RETURN
	(
		SELECT 
			EX.IdExpenseSlip,
			EX.Content,
			EX.TypeExpenseSlip,
			EX.TotalMoney
		FROM ExpenseSlips EX
		WHERE EX.TypeExpenseSlip = N'Phiếu Thu'
	);
GO

--Function lấy ra các ExpenseSlip thuộc loại phiếu chi
CREATE FUNCTION Fn_GetExpenseSlipSpend ()
RETURNS TABLE
AS
	RETURN
	(
		SELECT 
			EX.IdExpenseSlip,
			EX.Content,
			EX.TypeExpenseSlip,
			EX.TotalMoney
		FROM ExpenseSlips EX
		WHERE EX.TypeExpenseSlip = N'Phiếu Chi'
	);
GO

--Function Tổng số chi phí của phiếu thu
CREATE FUNCTION Fn_CalculateTotalMoneyExpenseSlipReceive()
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @TotalMoneyAll DECIMAL(18, 2);

    SELECT @TotalMoneyALL = SUM(TotalMoney)
    FROM ExpenseSlips
    WHERE TypeExpenseSlip = N'Phiếu Thu';

    RETURN @TotalMoneyAll;
END;
GO

--Fuction Tổng số chi phí cho phiếu chi tiêu
CREATE FUNCTION Fn_CalculateTotalMoneyExpenseSlipSpend()
RETURNS DECIMAL(18, 2)
AS
BEGIN
	DECLARE @TotalMoneyAll DECIMAL(18, 2);

	SELECT @TotalMoneyAll = SUM(TotalMoney)
	FROM ExpenseSlips
	WHERE TypeExpenseSlip = N'Phiếu Chi';

	RETURN @TotalMoneyAll;
END;
GO

--Function thực hiện tìm kiến phiếu thu chi bàng một dữ liệu đầu vào bất kì
CREATE FUNCTION Fn_SearchExpenseSlip (@SearchTerm NVARCHAR(MAX))
RETURNS TABLE
AS
	RETURN
	(
		SELECT DISTINCT 
			EX.IdExpenseSlip,
			EX.Content,
			EX.TypeExpenseSlip,
			EX.TotalMoney
		FROM ExpenseSlips EX 
		WHERE
			EX.IdExpenseSlip LIKE '%' + @SearchTerm + '%'
			OR EX.Content LIKE '%' + @SearchTerm + '%'
			OR EX.TypeExpenseSlip LIKE '%' + @SearchTerm + '%'
			OR EX.TotalMoney LIKE '%' + @SearchTerm + '%' 
	);
GO
