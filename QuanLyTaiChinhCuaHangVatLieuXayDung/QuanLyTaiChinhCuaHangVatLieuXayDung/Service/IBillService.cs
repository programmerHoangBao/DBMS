using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Service
{
    internal interface IBillService
    {
        //Hàm thực hiện thêm hóa đơn loại nhập hàng
        bool InsertImportBill(Bill bill);

        //Hàm thực hiện thêm hóa đơn loại xuất hàng
        bool InsertExportBill(Bill bill);
        
        //Hàm thực hiện cập nhật hóa đơn
        bool UpdateBill(Bill bill);

        //Hàm xóa hóa đơn
        bool DeleteBill(string idBill);
        
        //Hàm thực hiện tính tổng giá trị nhập hàng khi biết mã hóa đơn
        Decimal TotalImportBillById(string idBill);

        //Hàm thực hiện tính tổng giá trị xuất hàng khi biết mã hóa đơn
        Decimal TotalExportBillById(string idBill);

        //Hàm lấy tất cả hóa đơn nhập hàng
        List<Bill> GetAllImportBill();

        //Hàm lấy tất cả hóa đơn xuất hàng
        List<Bill> GetAllExportBill();

        //Hàm tìm hóa đơn nhập hàng khi biết thông tin bất kì của hóa đơn
        List<Bill> SearchImportBill(string searchTerm);

        //Hàm tìm hóa đơn xuất hàng khi biết thông tin bất kì của hóa đơn
        List<Bill> SearchExportBill(string searchTerm);

        //Hàm lấy thông tin sản phẩm của hóa đơn nhập hàng khi biết mã hóa đơn
        List<Product> GetListProductImportBill(string idBill);

        //Hàm lấy thông tin sản phẩm của hóa đơn xuất hàng khi biết mã hóa đơn
        List<Product> GetListProductExportBill(string idBill);

        //Hàm kiểm tra hóa đơn có sản phẩm nào không
        bool CheckExistBillInD(string idBill);
    }
}
