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
        bool InsertSupplier(Suppliers supplier);
        bool UpdateSupplier(Suppliers supplier);
        bool DeleteSupplier(string idSupplier);
        List<Suppliers> GetAllSupplier();
        Suppliers GetSupplierById(string idSupplier);
        string GetIdSupplierByPhoneNumber(string phoneNumber);

        //Fnction lấy các suppliers bằng cách nhập vào một thông tin bất kì
        Suppliers SearchSupplier(string searchTerm);

    }
}
