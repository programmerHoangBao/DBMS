using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Service
{
    internal interface IRevenueService
    {
        //Function tạo bảng hiển thị danh thu của từng ngày trong tháng, năm cụ thể
        DataTable CalculateDailyRevenue(int month, int year);


        //Function tạo bảng hiển thị tổng danh thu của các tháng trong năm
        DataTable CalculateMonthlyRevenue(int year);

        //Function tạo bảng hiển thị danh thu của các trong tất cả các năm kinh doanh
        DataTable CalculateAnnualRevenue();
    }
}
