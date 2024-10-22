using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Service
{
    internal interface IDetailBillService
    {
        //Hàm thực hiện thêm chi tiết hóa đơn
        bool InsertDetailBill(DetailBill detailBill);

        //Hàm thực hiện cập nhật chi tiết hóa đơn
        bool UpdateDetailBill(DetailBill detailBill);

        //Hàm thực hiện xóa dữ liệu khi biết mã hóa đơn
        bool DeleteDetailBillByIdBill(string idDetailBill);

        //Hàm thực hiện xóa dữ liệu khi biết mã hóa đơn và mã sản phẩm
        bool DeleteDetailBillByIdBillAndIdProduct(string idDetailBill, string idProduct);

    }
}
