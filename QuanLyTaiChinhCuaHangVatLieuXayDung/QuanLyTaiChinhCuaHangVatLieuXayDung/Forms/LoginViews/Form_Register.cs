using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Service;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Service.Implements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.LoginViews
{
    public partial class Form_Register : Form
    {
        private IAccountService accountService = new AccountService();
        private bool visibility = false;
        public Form_Register()
        {
            InitializeComponent();
        }

        private void uiButtonRegister_Click(object sender, EventArgs e)
        {
            string idAccount = this.uiTextBoxIdAccount.Text.Trim();
            string username = this.uiTextBoxUser.Text.Trim();
            string password = this.uiTextBoxPassword.Text.Trim();
            string email = this.uiTextBoxEmail.Text.Trim();
            string role = "Nhân Viên";
            Account account = new Account(idAccount, username, password, email, role);
            if (this.accountService.InsertAccount(account))
            {
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void uiSymbolButtonShowOrHidePassword_Click(object sender, EventArgs e)
        {
            this.visibility = !(visibility);
            if (this.visibility)
            {
                this.uiTextBoxPassword.PasswordChar = '\0';
                this.uiSymbolButtonShowOrHidePassword.Image = Properties.Resources.Visibility;
            }
            else
            {
                this.uiTextBoxPassword.PasswordChar = '*';
                this.uiSymbolButtonShowOrHidePassword.Image = Properties.Resources.Visibility_Off2;
            }
        }
    }
}
