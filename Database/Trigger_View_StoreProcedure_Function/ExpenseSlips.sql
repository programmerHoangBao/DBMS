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

--Tính tổng giá trị của phí phiếu thu trong một ngày cụ thể
CREATE FUNCTION Fn_CalculateTotalInDateOfExpenseSlipReceive
(
    @InputDate DATE
)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @Total DECIMAL(18, 2);
   
    SELECT @Total = SUM(TotalMoney)
    FROM ExpenseSlips
    WHERE 
        (YEAR(DateCreate) = YEAR(@InputDate) AND 
         MONTH(DateCreate) = MONTH(@InputDate) AND 
         DAY(DateCreate) = DAY(@InputDate)) AND
		 ExpenseSlips.TypeExpenseSlip=N'Phiếu Thu';
    
    RETURN ISNULL(@Total, 0);
END;
GO

--Tính tổng giá trị của phí phiếu chi trong một ngày cụ thể
CREATE FUNCTION Fn_CalculateTotalInDateOfExpenseSlipSpend
(
    @InputDate DATE
)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @Total DECIMAL(18, 2);
   
    SELECT @Total = SUM(TotalMoney)
    FROM ExpenseSlips
    WHERE 
        (YEAR(DateCreate) = YEAR(@InputDate) AND 
         MONTH(DateCreate) = MONTH(@InputDate) AND 
         DAY(DateCreate) = DAY(@InputDate)) AND
		 ExpenseSlips.TypeExpenseSlip=N'Phiếu Chi';
    
    RETURN ISNULL(@Total, 0);
END;
GO

--Tính tổng giá trị của phí phiếu thu trong một tháng cụ thể trong năm
CREATE FUNCTION Fn_CalculateTotalInMonthOfExpenseSlipReceive
(
    @Month INT,
	@Year INT
)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @Total DECIMAL(18, 2);
   
    SELECT @Total = SUM(TotalMoney)
    FROM ExpenseSlips
    WHERE 
        (YEAR(DateCreate) = @Year) AND 
        (MONTH(DateCreate) = @Month) AND
		(ExpenseSlips.TypeExpenseSlip=N'Phiếu Thu');
    
    RETURN ISNULL(@Total, 0);
END;
GO

--Tính tổng giá trị của phí phiếu chi trong tháng cụ thể trong năm
CREATE FUNCTION Fn_CalculateTotalInMonthOfExpenseSlipSpend
(
    @Month INT,
	@Year INT
)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @Total DECIMAL(18, 2);
   
    SELECT @Total = SUM(TotalMoney)
    FROM ExpenseSlips
    WHERE 
        (YEAR(DateCreate) = @Year) AND 
        (MONTH(DateCreate) = @Month) AND
		(ExpenseSlips.TypeExpenseSlip=N'Phiếu Chi');
    
    RETURN ISNULL(@Total, 0);
END;
GO

--Tính tổng giá trị của phí phiếu thu trong năm cụ thể
CREATE FUNCTION Fn_CalculateTotalInYearOfExpenseSlipReceive
(
	@Year INT
)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @Total DECIMAL(18, 2);
   
    SELECT @Total = SUM(TotalMoney)
    FROM ExpenseSlips
    WHERE 
        (YEAR(DateCreate) = @Year) AND 
		(ExpenseSlips.TypeExpenseSlip=N'Phiếu Thu');
    
    RETURN ISNULL(@Total, 0);
END;
GO

--Tính tổng giá trị của phí chi trong một năm cụ thể
CREATE FUNCTION Fn_CalculateTotalInYearOfExpenseSlipSpend
(
	@Year INT
)
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @Total DECIMAL(18, 2);
   
    SELECT @Total = SUM(TotalMoney)
    FROM ExpenseSlips
    WHERE 
        (YEAR(DateCreate) = @Year) AND 
		(ExpenseSlips.TypeExpenseSlip=N'Phiếu Chi');
    
    RETURN ISNULL(@Total, 0);
END;
GO