USE QuanLyTaiChinhCuaHangXayDung;
GO

--Function tạo bảng hiển thị danh thu của từng ngày trong tháng, năm cụ thể
CREATE FUNCTION Fn_CalculateDailyRevenue(
    @Month INT,
    @Year INT
)
RETURNS @RevenueTable TABLE
(
    Day INT,
    Revenue DECIMAL(18, 2)
)
AS
BEGIN
    DECLARE @Day INT;
    DECLARE @TotalExport DECIMAL(18, 2);	--Tông giá trị hóa đơn xuất hàng
    DECLARE @TotalReceive DECIMAL(18, 2);	--Tổng giá trị phiếu thu
    DECLARE @TotalSpend DECIMAL(18, 2);		--Tổng giá trị phiếu chi
    DECLARE @Revenue DECIMAL(18, 2);

    SET @Day = 1;
    WHILE @Day <= 31
    BEGIN
        -- Tính tổng giá trị hóa đơn xuất hàng cho ngày cụ thể
        SELECT @TotalExport = SUM(Total)
        FROM Bills
        WHERE TypeBill = N'Hóa Đơn Xuất Hàng'
          AND DAY(DateCreate) = @Day
          AND MONTH(DateCreate) = @Month
          AND YEAR(DateCreate) = @Year;

        -- Tính tổng giá trị phiếu thu cho ngày cụ thể
        SELECT @TotalReceive = SUM(TotalMoney)
        FROM ExpenseSlips
        WHERE TypeExpenseSlip = N'Phiếu Thu'
          AND DAY(DateCreate) = @Day
          AND MONTH(DateCreate) = @Month
          AND YEAR(DateCreate) = @Year;

        -- Tính tổng giá trị phiếu chi cho ngày cụ thể
        SELECT @TotalSpend = SUM(TotalMoney)
        FROM ExpenseSlips
        WHERE TypeExpenseSlip = N'Phiếu Chi'
          AND DAY(DateCreate) = @Day
          AND MONTH(DateCreate) = @Month
          AND YEAR(DateCreate) = @Year;

        -- Tính doanh thu cho ngày cụ thể
        SET @Revenue = ISNULL(@TotalExport, 0) + (ISNULL(@TotalReceive, 0) - ISNULL(@TotalSpend, 0));

        -- Thêm kết quả vào bảng trả về
        IF @TotalExport IS NOT NULL OR @TotalReceive IS NOT NULL OR @TotalSpend IS NOT NULL
        BEGIN
            INSERT INTO @RevenueTable (Day, Revenue)
            VALUES (@Day, @Revenue);
        END

        SET @Day = @Day + 1;
    END

    RETURN;
END;
GO

--Function tạo bảng hiển thị tổng danh thu của các tháng trong năm
CREATE FUNCTION Fn_CalculateMonthlyRevenue(@Year INT)
RETURNS @RevenueTable TABLE
(
    Month INT,
    Revenue DECIMAL(18, 2)
)
AS
BEGIN
    DECLARE @Month INT;
    DECLARE @TotalExport DECIMAL(18, 2);	--Tổng giá trị hóa đơn xuất hàng
    DECLARE @TotalImport DECIMAL(18, 2);	--Tổng gía trị hóa đơn nhập hàng
    DECLARE @TotalReceive DECIMAL(18, 2);	--Tổng giá trị phiếu thu 
    DECLARE @TotalSpend DECIMAL(18, 2);		--Tổng giá trị phiếu chi
    DECLARE @Revenue DECIMAL(18, 2);		

    SET @Month = 1;
    WHILE @Month <= 12
    BEGIN
        -- Tính tổng giá trị hóa đơn xuất hàng cho tháng cụ thể
        SELECT @TotalExport = SUM(Total)
        FROM Bills
        WHERE TypeBill = N'Hóa Đơn Xuất Hàng'
          AND MONTH(DateCreate) = @Month
          AND YEAR(DateCreate) = @Year;

        -- Tính tổng giá trị hóa đơn nhập hàng cho tháng cụ thể
        SELECT @TotalImport = SUM(Total)
        FROM Bills
        WHERE TypeBill = N'Hóa Đơn Nhập Hàng'
          AND MONTH(DateCreate) = @Month
          AND YEAR(DateCreate) = @Year;

        -- Tính tổng giá trị phiếu thu cho tháng cụ thể
        SELECT @TotalReceive = SUM(TotalMoney)
        FROM ExpenseSlips
        WHERE TypeExpenseSlip = N'Phiếu Thu'
          AND MONTH(DateCreate) = @Month
          AND YEAR(DateCreate) = @Year;

        -- Tính tổng giá trị phiếu chi cho tháng cụ thể
        SELECT @TotalSpend = SUM(TotalMoney)
        FROM ExpenseSlips
        WHERE TypeExpenseSlip = N'Phiếu Chi'
          AND MONTH(DateCreate) = @Month
          AND YEAR(DateCreate) = @Year;

        -- Tính doanh thu cho tháng cụ thể
        SET @Revenue = ISNULL(@TotalExport, 0) - ISNULL(@TotalImport, 0) + (ISNULL(@TotalReceive, 0) - ISNULL(@TotalSpend, 0));

        -- Thêm kết quả vào bảng trả về
        IF @TotalExport IS NOT NULL OR @TotalImport IS NOT NULL OR @TotalReceive IS NOT NULL OR @TotalSpend IS NOT NULL
        BEGIN
            INSERT INTO @RevenueTable (Month, Revenue)
            VALUES (@Month, @Revenue);
        END

        SET @Month = @Month + 1;
    END

    RETURN;
END;
GO

--Function tạo bảng hiển thị danh thu của các trong tất cả các năm kinh doanh
CREATE FUNCTION Fn_CalculateAnnualRevenue()
RETURNS @RevenueTable TABLE
(
    Year INT,
    Revenue DECIMAL(18, 2)
)
AS
BEGIN
    DECLARE @Year INT;
   DECLARE @TotalExport DECIMAL(18, 2);	--Tổng giá trị hóa đơn xuất hàng
    DECLARE @TotalImport DECIMAL(18, 2);	--Tổng gía trị hóa đơn nhập hàng
    DECLARE @TotalReceive DECIMAL(18, 2);	--Tổng giá trị phiếu thu 
    DECLARE @TotalSpend DECIMAL(18, 2);		--Tổng giá trị phiếu chi
    DECLARE @Revenue DECIMAL(18, 2);

    SET @Year = (SELECT MIN(YEAR(DateCreate)) FROM Bills);
    WHILE @Year <= (SELECT MAX(YEAR(DateCreate)) FROM Bills)
    BEGIN
        -- Tính tổng giá trị hóa đơn xuất hàng cho năm cụ thể
        SELECT @TotalExport = SUM(Total)
        FROM Bills
        WHERE TypeBill = N'Hóa Đơn Xuất Hàng'
          AND YEAR(DateCreate) = @Year;

        -- Tính tổng giá trị hóa đơn nhập hàng cho năm cụ thể
        SELECT @TotalImport = SUM(Total)
        FROM Bills
        WHERE TypeBill = N'Hóa Đơn Nhập Hàng'
          AND YEAR(DateCreate) = @Year;

        -- Tính tổng giá trị phiếu thu cho năm cụ thể
        SELECT @TotalReceive = SUM(TotalMoney)
        FROM ExpenseSlips
        WHERE TypeExpenseSlip = N'Phiếu Thu'
          AND YEAR(DateCreate) = @Year;

        -- Tính tổng giá trị phiếu chi cho năm cụ thể
        SELECT @TotalSpend = SUM(TotalMoney)
        FROM ExpenseSlips
        WHERE TypeExpenseSlip = N'Phiếu Chi'
          AND YEAR(DateCreate) = @Year;

        -- Tính doanh thu cho năm cụ thể
        SET @Revenue = ISNULL(@TotalExport, 0) - ISNULL(@TotalImport, 0) + (ISNULL(@TotalReceive, 0) - ISNULL(@TotalSpend, 0));

        -- Thêm kết quả vào bảng trả về
        IF @TotalExport IS NOT NULL OR @TotalImport IS NOT NULL OR @TotalReceive IS NOT NULL OR @TotalSpend IS NOT NULL
        BEGIN
            INSERT INTO @RevenueTable (Year, Revenue)
            VALUES (@Year, @Revenue);
        END

        SET @Year = @Year + 1;
    END

    RETURN;
END;
GO
