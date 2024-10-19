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
        bool InsertSupplier(Supplier supplier);
        bool UpdateSupplier(Supplier supplier);
        bool DeleteSupplier(string idSupplier);
        List<Supplier> GetAllSupplier();
        Supplier GetSupplierById(string idSupplier);
        string GetIdSupplierByPhoneNumber(string phoneNumber);

        //Fnction lấy các suppliers bằng cách nhập vào một thông tin bất kì
        Supplier SearchSupplier(string searchTerm);

    }
}
