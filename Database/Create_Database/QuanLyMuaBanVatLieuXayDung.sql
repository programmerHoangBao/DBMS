GO
CREATE DATABASE QuanLyTaiChinhCuaHangXayDung;
GO
USE QuanLyTaiChinhCuaHangXayDung;
GO

--Bảng khách hàng
CREATE TABLE Customers(
	IdCustomer CHAR(6) PRIMARY KEY,
	NameCustomer NVARCHAR(100) NOT NULL,
	PhoneNumber CHAR(10) UNIQUE NOT NULL,
	AddressCustomer NVARCHAR(150) NOT NULL,
);
GO

--Bảng nhà cung cấp
CREATE TABLE Suppliers(
	IdSupplier CHAR(6) PRIMARY KEY,
	NameSupplier NVARCHAR(100) NOT NULL,
	PhoneNumber CHAR(10) UNIQUE NOT NULL,
	AddressSupplier NVARCHAR(150) NOT NULL,
);
GO

--Bảng loại sản phẩm
CREATE TABLE TypeProducts(
	IdTypeProduct CHAR(6) PRIMARY KEY,
	NameTypeProduct NVARCHAR(100) UNIQUE NOT NULL
);
GO

--Bảng sản phẩm
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
GO

--Bảng hóa đơn
CREATE TABLE Bills(
	IdBill CHAR(6) PRIMARY KEY,
	IdCustomer CHAR(6),
	IdSupplier CHAR (6),
	DateCreate DATE NOT NULL,
	TypeBill NVARCHAR(20) NOT NULL,
	Total DECIMAL(18, 2) NOT NULL,
	FOREIGN KEY (IdCustomer) REFERENCES Customers(IdCustomer) ON DELETE SET NULL,
	FOREIGN KEY (IdSupplier) REFERENCES Suppliers(IdSupplier) ON DELETE SET NULL,
	CHECK (TypeBill IN (N'Hóa Đơn Nhập Hàng', N'Hóa Đơn Xuất Hàng'))
);
GO

--Chi tiết hóa đơn
CREATE TABLE DetailBills(
	IdBill CHAR(6) NOT NULL,
	IdProduct CHAR(6) NOT NULL,
	QuantityProduct DECIMAL(18, 2) NOT NULL CHECK (QuantityProduct > 0),
	CONSTRAINT FK_Bill FOREIGN KEY (IdBill) REFERENCES Bills(IdBill) ON DELETE CASCADE,
	CONSTRAINT FK_Product FOREIGN KEY (IdProduct) REFERENCES Products(IdProduct) ON DELETE CASCADE,
);
GO

--Phiếu thu chi của các loại phí phát sinh như xăng xe, sửa chửa,...
CREATE TABLE ExpenseSlips(
	IdExpenseSlip CHAR(6) PRIMARY KEY,
	DateCreate DATE NOT NULL,
	Content NVARCHAR(MAX),
	TypeExpenseSlip NVARCHAR(10) NOT NULL CHECK (TypeExpenseSlip IN (N'Phiếu Thu', N'Phiếu Chi')),
	TotalMoney DECIMAL(18, 2) NOT NULL CHECK (TotalMoney > 0),
);
GO
