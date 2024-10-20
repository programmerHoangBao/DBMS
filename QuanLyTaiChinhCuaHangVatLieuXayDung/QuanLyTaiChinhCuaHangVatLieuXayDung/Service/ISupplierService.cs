using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Service
{
    internal interface ISupplierService
    {

        //Store Procedure thực hiện việc thêm dữ liệu vào bảng Suppliers
        bool InsertSupplier(Supplier supplier);

        //Store Procedure thực hiện việc cập nhật liệu trong bảng Suppliers
        bool UpdateSupplier(Supplier supplier);

        //Store Procedure thực hiện việc xóa dữ liệu trong bảng Suppliers
        bool DeleteSupplier(string idSupplier);

        //Function lấy ra thông tin của tất cả nhà cung cấp
        List<Supplier> GetAllSupplier();

        //Function lấy thông tin nhà cung cấp thông qua mã nhà cung cấp
        Supplier GetSupplierById(string idSupplier);

        //Function lấy IdSupplier bằng PhoneNumber của Supplier
        string GetIdSupplierByPhoneNumber(string phoneNumber);

        //Fnction lấy các suppliers bằng cách nhập vào một thông tin bất kì
        List<Supplier> SearchSupplier(string searchTerm);

    }
}
