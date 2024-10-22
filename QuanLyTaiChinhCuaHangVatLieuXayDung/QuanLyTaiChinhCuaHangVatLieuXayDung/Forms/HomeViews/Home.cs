using QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.CustomerViews;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.SupplierViews;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.TypeProductViews;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.BillViews;
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

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.HomeViews
{
    public partial class Home : Form
    {
        private MyDatabase myDatabase = new MyDatabase();
        private Form formChild;     //Form con
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }
        private void OpenFormChild(Form formChild)
        {
            this.uiPanel_Body.Controls.Clear();
            this.formChild = new Form();
            this.formChild = formChild;
            this.formChild.TopLevel = false;
            this.uiPanel_Body.Controls.Add(this.formChild);
            this.formChild.Dock = DockStyle.Fill;
            this.formChild.FormBorderStyle = FormBorderStyle.None;
            this.formChild.Show();
        }

        private void btnTypeProdcut_Click(object sender, EventArgs e)
        {
            Form_ManagerTypeProduct form_ManagerTypeProduct = new Form_ManagerTypeProduct();
            OpenFormChild(form_ManagerTypeProduct);
        }

        private void btnManagerSupplier_Click(object sender, EventArgs e)
        {
            Form_ManagerSupplier form_ManagerSupplier = new Form_ManagerSupplier();
            OpenFormChild(form_ManagerSupplier);
        }

        private void uiSBtnBtnCustomer_Click(object sender, EventArgs e)
        {
            Form_ManagerCustomer form_ManagerCustomer = new Form_ManagerCustomer();
            OpenFormChild(form_ManagerCustomer);
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Form_ManagerBIll form_ManagerBill = new Form_ManagerBIll();
            OpenFormChild(form_ManagerBill);
        }
    }
}
