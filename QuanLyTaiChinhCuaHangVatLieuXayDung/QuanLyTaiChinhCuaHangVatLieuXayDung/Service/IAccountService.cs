using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Service
{
    internal interface IAccountService
    {
        //Thêm tài khoản
        bool InsertAccount(Account account);
        
        //Cập nhật tài khoản
        bool UpdateAccount(Account account);
        
        //Xóa tài khoản
        bool DeleteAccount(string idAccount);

        //Thực hiện loign
        bool Login(string username, string password);

        //Lấy ra toàn bộ Account
        List<Account> GetAllAccounts();

        //Lấy đối tượng Account bằng IdAccount
        Account GetAccountById(string idAccount);

        //Function lấy ra account bằng Username
        Account GetAccountByUsername(string username);
    }
}
