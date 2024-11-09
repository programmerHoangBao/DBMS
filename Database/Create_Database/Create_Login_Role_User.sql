USE master
GO
--Tạo tài khoản đăng nhập cho Quản lý
CREATE LOGIN ManagerLogin WITH PASSWORD = '123';
GO

--Tạo tài khoản đăng nhập cho nhân viên
CREATE LOGIN EmployeeLogin WITH PASSWORD = '123';
GO

USE QuanLyTaiChinhCuaHangXayDung;
GO
--Tạo ROLE nhân viên
GO
CREATE ROLE Employee;
GO

--Tạo ROLE quản lý
CREATE ROLE Manager;
GO

--Tạo User cho role Manager
CREATE USER ManagerUser FOR LOGIN ManagerLogin;
EXEC sp_addrolemember 'Manager', ManagerUser;
GO

--Tạo User cho role Employee
CREATE USER EmployeeUser FOR LOGIN EmployeeLogin
EXEC sp_addrolemember 'Employee', EmployeeUser;
GO