using QuanLyTaiChinhCuaHangVatLieuXayDung.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.RevenueViews
{
    public partial class Form_ShowRevenue : Form
    {
        private IRevenueService revenueService;
        public Form_ShowRevenue()
        {
            InitializeComponent();
            this.revenueService = new RevenueService();
        }

        private void Form_ShowRevenue_Load(object sender, EventArgs e)
        {

        }

        private void uiButtonCalculateDailyRevenue_Click(object sender, EventArgs e)
        {
            int month = int.Parse(this.uiTextBoxMonth.Text.Trim());
            int year = int.Parse(this.uiTextBoxYear.Text.Trim());

            DataTable dtDailyRevenue = this.revenueService.CalculateDailyRevenue(month, year);
            if (dtDailyRevenue.Columns.Count > 0)
            {
                this.uiDataGridViewRevenue.DataSource = dtDailyRevenue;
                this.uiDataGridViewRevenue.Columns["Day"].HeaderText = "Ngày";
                this.uiDataGridViewRevenue.Columns["Revenue"].HeaderText = "Danh thu";
            }
        }

        private void uiButtonCalculateMonthlyRevenue_Click(object sender, EventArgs e)
        {
                int year = int.Parse(this.uiTextBoxYear.Text.Trim());

                DataTable dtMonthlyRevenue = this.revenueService.CalculateMonthlyRevenue(year);
                if (dtMonthlyRevenue.Columns.Count > 0)
                {
                    this.uiDataGridViewRevenue.DataSource = dtMonthlyRevenue;
                    this.uiDataGridViewRevenue.Columns["Month"].HeaderText = "Tháng";
                    this.uiDataGridViewRevenue.Columns["Revenue"].HeaderText = "Doanh thu";
                }
        }

        private void uiButtonCalculateAnnualRevenue_Click(object sender, EventArgs e)
        {
            DataTable dtAnnualRevenue = this.revenueService.CalculateAnnualRevenue();
            if (dtAnnualRevenue.Columns.Count > 0)
            {
                this.uiDataGridViewRevenue.DataSource = dtAnnualRevenue;
                this.uiDataGridViewRevenue.Columns["Year"].HeaderText = "Năm";
                this.uiDataGridViewRevenue.Columns["Revenue"].HeaderText = "Doanh thu";
            }
        }

        private void buttonTopSeller_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtDailyRevenue = this.revenueService.CalculateTopCellingProduct();
                if (dtDailyRevenue.Columns.Count > 0)
                {
                    this.uiDataGridViewSellProduct.DataSource = dtDailyRevenue;
                    this.uiDataGridViewSellProduct.Columns["IdTypeProduct"].HeaderText = "Loại sản phẩm";
                    this.uiDataGridViewSellProduct.Columns["NameTypeProduct"].HeaderText = "Tên loại sản phẩm";
                    this.uiDataGridViewSellProduct.Columns["IdProduct"].HeaderText = "Sản phẩm";
                    this.uiDataGridViewSellProduct.Columns["NameProduct"].HeaderText = "Tên sản phẩm";
                    this.uiDataGridViewSellProduct.Columns["TotalQuantitySold"].HeaderText = "Số lượng";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Notification",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
