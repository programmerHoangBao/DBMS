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

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.DetailBillViews
{
    public partial class Form_ManagerDetailBill : Form
    {

        IBillService billService = new BillService();
        IProductService productService = new ProductService();
        IDetailBillService detailBillService = new DetailBillService();
        public Form_ManagerDetailBill()
        {
            InitializeComponent();
        }

        private void Form_ManagerDetailBill_Load(object sender, EventArgs e)
        {

        }
        //Lấy dữ liệu từ Data truyền vào UIDataGridView và UIComboBox
        private void DisplaySuppliersOnUIDataGridViewAndUiComboBox(UIDataGridView uiDataGridView, UIComboBox uiComboBox1, UIComboBox uiComboBox2)
        {
            //Lấy dữ liệu từ database
            List<DetailBill> detailBills = new List<DetailBill>();
            //detailBills = this.detailBillService.G;

            //set dữ liệu trên uiDataGridView
            //uiDataGridView.DataSource = bills;
            uiDataGridView.Columns["IdBill"].HeaderText = "Mã hóa đơn";
            uiDataGridView.Columns["IdSupplier"].HeaderText = "Mã nhà cung cấp";
            uiDataGridView.Columns["IdSupplier"].Visible = true;
            uiDataGridView.Columns["DateCreate"].HeaderText = "Ngày tạo hóa đơn";
            uiDataGridView.Columns["TypeBill"].HeaderText = "Loại hóa đơn";
            uiDataGridView.Columns["Total"].HeaderText = "Tổng tiền";
            uiDataGridView.Columns["IdCustomer"].Visible = false;
            //set dữ liệu cho uiComboBox
            uiComboBox1.Items.Clear();
            uiComboBox1.Items.Add("Nhập hàng");
            uiComboBox1.Items.Add("Xuất hàng");
            uiComboBox1.SelectedIndex = 0;

            uiComboBox2.Items.Clear();
            uiComboBox2.Items.Add("Nhập hàng");
            uiComboBox2.Items.Add("Xuất hàng");
            uiComboBox2.SelectedIndex = 0;
        }
    }
}
