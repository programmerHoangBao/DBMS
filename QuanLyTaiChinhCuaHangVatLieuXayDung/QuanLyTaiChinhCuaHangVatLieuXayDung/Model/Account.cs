using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Model
{
    internal class Account
    {
        private string idAccount;
        private string username;
        private string password;
        private string email;
        private string role;

        public Account()
        {
        }

        public Account(string idAccount, string username, string password, string email, string role)
        {
            this.idAccount = idAccount;
            this.username = username;
            this.password = password;
            this.email = email;
            this.role = role;
        }

        public string IdAccount { get => idAccount; set => idAccount = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Role { get => role; set => role = value; }

        public bool IsNull()
        {
            return (String.IsNullOrEmpty(this.idAccount) && String.IsNullOrEmpty(this.username)
                && String.IsNullOrEmpty(this.password) && String.IsNullOrEmpty(this.email));
        }
    }
}
