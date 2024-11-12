using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Service;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Service.Implements;
using Sunny.UI;
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
    public partial class Form_ForgotPassword : Form
    {
        private IAccountService accountService = new AccountService();
        private bool visibility = false;
        public Form_ForgotPassword()
        {
            InitializeComponent();
        }

        private void uiSymbolButtonShowOrHidePassword_Click_1(object sender, EventArgs e)
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

        private void uiButtonSave_Click(object sender, EventArgs e)
        {
            string username = this.uiTextBoxUser.Text.Trim();
            string password = this.uiTextBoxPassword.Text.Trim();
            Account account = this.accountService.GetAccountByUsername(username);
            if (account.IsNull())
            {
                MessageBox.Show("Tên tài khoản không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                account.Password = password;
                if (this.accountService.UpdateAccount(account))
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thay đổi mật khẩu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form_ForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
