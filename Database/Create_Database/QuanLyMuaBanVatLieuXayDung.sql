GO
CREATE DATABASE QuanLyTaiChinhCuaHangXayDung;
GO
USE QuanLyTaiChinhCuaHangXayDung;
GO
CREATE TABLE Customers(
	IdCustomer CHAR(6) PRIMARY KEY,
	NameCustomer NVARCHAR(100) NOT NULL,
	PhoneNumber CHAR(10) UNIQUE NOT NULL,
	AddressCustomer NVARCHAR(150) NOT NULL,
);
GO
CREATE TABLE Suppliers(
	IdSupplier CHAR(6) PRIMARY KEY,
	NameSupplier NVARCHAR(100) NOT NULL,
	AddressSupplier NVARCHAR(150) NOT NULL,
	PhoneNumber CHAR(10) UNIQUE NOT NULL,
);
GO
CREATE TABLE TypeProducts(
	IdTypeProduct CHAR(6) PRIMARY KEY,
	NameTypeProduct NVARCHAR(100) UNIQUE NOT NULL
);
GO
CREATE TABLE Products(
	IdProduct CHAR(6) PRIMARY KEY,
	NameProduct NVARCHAR(100) NOT NULL,
	Unit NVARCHAR(30) NOT NULL,
	UnitPriceImport REAL NOT NULL,	--giá mua vào
	UnitPriceExport REAL NOT NULL,	--giá bán ra
	QuantityProduct REAL NOT NULL,
	IdTypeProduct CHAR(6) NOT NULL,
	IdSupplier CHAR(6),
	ImageProduct IMAGE,
	CONSTRAINT FK_TypeProduct FOREIGN KEY (IdTypeProduct) REFERENCES TypeProducts(IdTypeProduct) ON DELETE CASCADE,
	CONSTRAINT FK_Supplier FOREIGN KEY (IdSupplier) REFERENCES Suppliers(IdSupplier) ON DELETE SET NULL,
	CONSTRAINT Check_Product CHECK (UnitPriceImport >= 0 AND UnitPriceImport >= 0 AND QuantityProduct >=0) 
);
GO
CREATE TABLE Bills(
	IdBill CHAR(6) PRIMARY KEY,
	IdCustomer CHAR(6),
	IdSupplier CHAR (6),
	DateCreate DATE NOT NULL,
	TypeBill CHAR(15) NOT NULL,--Import Bill và Export Bill
	Total REAL NOT NULL,
	FOREIGN KEY (IdCustomer) REFERENCES Customers(IdCustomer) ON DELETE SET NULL,
	FOREIGN KEY (IdSupplier) REFERENCES Suppliers(IdSupplier) ON DELETE SET NULL,
	CHECK (TypeBill IN ('Import Bill', 'Export Bill'))
);
GO
--Chi tiết hóa đơn
CREATE TABLE DetailBills(
	IdBill CHAR(6) NOT NULL,
	IdProduct CHAR(6) NOT NULL,
	QuantityProduct REAL NOT NULL CHECK (QuantityProduct > 0),
	CONSTRAINT FK_Bill FOREIGN KEY (IdBill) REFERENCES Bills(IdBill) ON DELETE CASCADE,
	CONSTRAINT FK_Product FOREIGN KEY (IdProduct) REFERENCES Products(IdProduct) ON DELETE CASCADE,
);
GO

--Phiếu thu chi của các loại phí phát sinh như xăng xe, sửa chửa,...
CREATE TABLE ExpenseSlips(
	IdExpenseSlip CHAR(6) PRIMARY KEY,
	DateCrate DATE NOT NULL,
	Content NTEXT,
	TypeExpenseSlip CHAR(15) NOT NULL,
	TotalMoney REAL NOT NULL CHECK (TotalMoney > 0)
);
GO
