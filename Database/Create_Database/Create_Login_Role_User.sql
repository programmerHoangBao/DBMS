USE master
GO
--SERVER ROLE cho LOGIN quản lý
CREATE SERVER ROLE ManagerOnServer;
--SERVER ROLE cho LOGIN nhân viên
CREATE SERVER ROLE EmployeeOnServer;

GO

USE QuanLyTaiChinhCuaHangXayDung;
GO
--Tạo ROLE cho user nhân viên
GO
CREATE ROLE Employee;
GO

--Tạo ROLE cho user quản lý
CREATE ROLE Manager;
GO