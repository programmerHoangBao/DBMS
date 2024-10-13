
--Phiếu thu chi của các loại phí phát sinh như xăng xe, sửa chửa,...
CREATE TABLE ExpenseSlips(
	IdExpenseSlip CHAR(6) PRIMARY KEY,
	DateCrate DATE NOT NULL,
	Content NTEXT,
	TypeExpenseSlip CHAR(15) NOT NULL,
	TotalMoney REAL NOT NULL CHECK (TotalMoney > 0)
);

GO
USE QuanLyTaiChinhCuaHangXayDung;
GO

--Store Procedure thực hiện thêm dữ liệu vào bảng ExpenseSlips
--Store Procedure thực hiện cập nhật dữ liệu vào bảng ExpenseSlips
--Store Procedure thực hiện xóa dữ liệu trong bảng ExpenseSlips
--Function tính tổng giá 