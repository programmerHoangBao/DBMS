using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Service
{
    internal interface ICustomerService
    {
        bool InsertCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(string idCustomer);
        List<Customer> GetAllCustomer();
        Customer GetCustomerByPhoneNumber(string phoneNumber);
        Customer GetCustomerById(string idCustomer);

        //Function tìm kiếm gần đúng sản phẩm bằng thông tin bất kì của sản phẩm trừ ImageCustomer
        Products SearchCustomer(string searchTerm);
    }
}
