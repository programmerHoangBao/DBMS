using QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.HomeViews;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Service;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Service.Implements;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.LoginViews
{
    public partial class Form_Login : Form
    {
        private IAccountService accountService = new AccountService();
        private bool visibility = false;
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            SetupPlaceholderText(this.uiTextBoxUser, "Tên đăng nhập.....");
            SetupPlaceholderText(this.uiTextBoxPassword, "Mật khẩu......");
        }
        private void SetupPlaceholderText(UITextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };

            textBox.TextChanged += (sender, e) =>
            {
                if (textBox.Text != placeholder)
                {
                    textBox.ForeColor = Color.Black;
                }
            };
        }
        private string GetCurrentFolderPath()
        {
            string filePath = Assembly.GetExecutingAssembly().Location;
            return Path.GetDirectoryName(filePath);
        }

        private void WriteToFile(string filePath, string username, string password)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(username);
                    sw.WriteLine(password);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void uiSymbolButtonShowOrHidePassword_Click(object sender, EventArgs e)
        {
            this.visibility = !(visibility);
            if ( this.visibility )
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

        private void uiButtonLogin_Click(object sender, EventArgs e)
        {
            string username = this.uiTextBoxUser.Text.Trim();
            string password = this.uiTextBoxPassword.Text.Trim();

            if (this.accountService.Login(username, password))
            {
                Home home = new Home();
                Account account = this.accountService.GetAccountByUsername(username);
                string filePath = GetCurrentFolderPath() + @"\Database\role.txt";

                WriteToFile(filePath, username, password);

                home.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void uiButtonRegister_Click(object sender, EventArgs e)
        {
            Form_Register form_Register = new Form_Register();
            form_Register.Show();
        }

        private void uiLinkLabelForgotPassword_Click(object sender, EventArgs e)
        {
            Form_ForgotPassword form_ForgotPassword = new Form_ForgotPassword();
            form_ForgotPassword.Show();
        }
    }
}
