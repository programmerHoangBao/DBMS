USE master
GO
--Cấp quyền tạo và cập nhật và xóa LOGIN trên SERVER ROLE cho LOGIN quản lý
GRANT ALTER ANY LOGIN TO ManagerOnServer;
GRANT ALTER ANY CONNECTION TO ManagerOnServer;

GO
USE QuanLyTaiChinhCuaHangXayDung
GO
--Cấp quyền cho role Manager
GRANT ALTER ANY USER TO Manager;
GRANT SELECT, INSERT, UPDATE, DELETE ON SCHEMA::dbo TO Manager;
GRANT EXECUTE ON SCHEMA::dbo TO Manager;
GRANT SELECT ON SCHEMA::dbo TO Manager;
GO

--Cấp quyền cho Employee
GRANT SELECT, INSERT, UPDATE, DELETE ON SCHEMA::dbo TO Employee;

--Từ chối các quyền truy vấn đến Accounts
DENY SELECT, INSERT, UPDATE, DELETE ON Accounts TO Employee;

GRANT EXECUTE ON SCHEMA::dbo TO Employee;
GRANT SELECT ON SCHEMA::dbo TO Employee;
GO

-- Từ chối quyền EXECUTE trên các Stored Procedures cho vai trò Employee
DENY EXECUTE ON OBJECT::dbo.SP_InsertAccount TO Employee;
DENY EXECUTE ON OBJECT::dbo.SP_DeleteAccount TO Employee;
GO

-- Từ chối quyền Select trên các Functions cho vai trò Employee
DENY SELECT ON OBJECT::dbo.Fn_GetAllAccount TO Employee;
DENY SELECT ON OBJECT::dbo.Fn_CalculateDailyRevenue TO Employee;
DENY SELECT ON OBJECT::dbo.Fn_CalculateMonthlyRevenue TO Employee;
DENY SELECT ON OBJECT::dbo.Fn_CalculateAnnualRevenue TO Employee;
DENY SELECT ON OBJECT::dbo.Fn_GetTopSellingProductPerType TO Employee;

