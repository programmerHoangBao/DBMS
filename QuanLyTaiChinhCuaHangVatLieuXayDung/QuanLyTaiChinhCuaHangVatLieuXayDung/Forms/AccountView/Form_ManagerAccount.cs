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

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.AccountView
{
    public partial class Form_ManagerAccount : Form
    {
        private IAccountService accountService = new AccountService();
        public Form_ManagerAccount()
        {
            InitializeComponent();
        }

        private void Form_ManagerAccount_Load(object sender, EventArgs e)
        {
            ShowDataAccount(this.uiDataGridView_ShowAccouont);
        }
        private void ShowDataAccount(UIDataGridView uIDataGridView)
        {
            uIDataGridView.ClearAll();
            List<Account> accounts = this.accountService.GetAllAccounts();
            uIDataGridView.DataSource = accounts;
            uIDataGridView.Columns["IdAccount"].HeaderText = "Mã tài khoản";
            uIDataGridView.Columns["Username"].HeaderText = "Tên đăng nhập";
            uIDataGridView.Columns["Password"].HeaderText = "Mật khẩu";
            uIDataGridView.Columns["Email"].HeaderText = "Email";
            uIDataGridView.Columns["Role"].HeaderText = "Vai trò";

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Delete";
            buttonColumn.HeaderText = "Xóa tài khoản";
            buttonColumn.Text = "Xóa";
            buttonColumn.UseColumnTextForButtonValue = true;
            uIDataGridView.Columns.Add(buttonColumn);

        }

        private void uiDataGridView_ShowAccouont_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.uiDataGridView_ShowAccouont.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                string idAccount = (string)this.uiDataGridView_ShowAccouont.Rows[e.RowIndex].Cells["IdAccount"].Value;
                if (this.accountService.DeleteAccount(idAccount))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowDataAccount(this.uiDataGridView_ShowAccouont);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
