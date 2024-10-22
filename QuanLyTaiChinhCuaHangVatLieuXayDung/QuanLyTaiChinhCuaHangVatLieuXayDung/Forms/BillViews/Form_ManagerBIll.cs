using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Service.Implements;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Service;
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

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.BillViews
{
    public partial class Form_ManagerBill : Form
    {
        private IBillService billService = new BillService();
        IDetailBillService detailBillService = new DetailBillService();
        List<DetailBill> detailBills;
        public Form_ManagerBill()
        {
            InitializeComponent();
            detailBills = new List<DetailBill>();
        }

        private void Form_ManagerBill_Load(object sender, EventArgs e)
        {
            DisplaySuppliersOnUIDataGridViewAndUiComboBox(this.dgv_listbill, this.cbb_selectTypeBill, this.cbb_typeBill);
        }
        //Lấy dữ liệu từ Data truyền vào UIDataGridView và UIComboBox
        private void DisplaySuppliersOnUIDataGridViewAndUiComboBox(UIDataGridView uiDataGridView, UIComboBox uiComboBox1, UIComboBox uiComboBox2)
        {
            //Lấy dữ liệu từ database
            List<Bill> bills = new List<Bill>();
            bills = this.billService.GetAllImportBill();

            //set dữ liệu trên uiDataGridView
            uiDataGridView.DataSource = bills;
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

        private void cbb_selectTypeBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_selectTypeBill.SelectedIndex == 0)
            {
                //Lấy dữ liệu từ database
                List<Bill> bills = new List<Bill>();
                bills = this.billService.GetAllImportBill();

                //set dữ liệu trên uiDataGridView
                dgv_listbill.DataSource = bills;
                dgv_listbill.Columns["IdBill"].HeaderText = "Mã hóa đơn";
                dgv_listbill.Columns["IdSupplier"].HeaderText = "Mã nhà cung cấp";
                dgv_listbill.Columns["IdSupplier"].Visible = true;
                dgv_listbill.Columns["DateCreate"].HeaderText = "Ngày tạo hóa đơn";
                dgv_listbill.Columns["TypeBill"].HeaderText = "Loại hóa đơn";
                dgv_listbill.Columns["Total"].HeaderText = "Tổng tiền";
                dgv_listbill.Columns["IdCustomer"].Visible = false;
            }
            else
            {
                //Lấy dữ liệu từ database
                List<Bill> bills = new List<Bill>();
                bills = this.billService.GetAllExportBill();
                //set dữ liệu trên uiDataGridView
                dgv_listbill.DataSource = bills;
                dgv_listbill.Columns["IdBill"].HeaderText = "Mã hóa đơn";
                dgv_listbill.Columns["IdCustomer"].HeaderText = "Mã khách hàng";
                dgv_listbill.Columns["IdCustomer"].Visible = true;
                dgv_listbill.Columns["DateCreate"].HeaderText = "Ngày tạo hóa đơn";
                dgv_listbill.Columns["TypeBill"].HeaderText = "Loại hóa đơn";
                dgv_listbill.Columns["Total"].HeaderText = "Tổng tiền";
                dgv_listbill.Columns["IdSupplier"].Visible = false;
            }
        }

        private void uiButtonInsertSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                string idBill = txt_idBill.Text.Trim();
                DateTime dateCreate = DateTime.Now;
                if (cbb_typeBill.SelectedIndex == 0)
                {
                    string typeBill = "Hóa đơn nhập hàng";
                    string idSupplier = txt_idSupOrCus.Text.Trim();

                    if (this.billService.InsertImportBill(new Bill(idBill, idSupplier, dateCreate, typeBill)))
                    {
                        foreach(DetailBill detailBill in detailBills)
                        {
                            if (!detailBillService.InsertDetailBill(detailBill))
                            {
                                MessageBox.Show("Thêm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cbb_selectTypeBill.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    string typeBill = "Hóa đơn xuất hàng";
                    string idCustomer = txt_idSupOrCus.Text.Trim();

                    if (this.billService.InsertExportBill(new Bill(idBill, idCustomer, dateCreate, typeBill)))
                    {
                        foreach (DetailBill detailBill in detailBills)
                        {
                            if (!detailBillService.InsertDetailBill(detailBill))
                            {
                                MessageBox.Show("Thêm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cbb_selectTypeBill.SelectedIndex = 1;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Notification",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbb_typeBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_typeBill.SelectedIndex == 0)
            {
                lbl_idSupOrCus.Text = "Mã nhà cung cấp:";
            }
            else
            {
                lbl_idSupOrCus.Text = "Mã khách hàng:";
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (txt_idBill.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã đơn hàng","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Form_SelectProduct form = new Form_SelectProduct();
                form.txt_idBill.Text = txt_idBill.Text;
                form.detailBills = detailBills;
                form.ShowDialog();
                detailBills = form.detailBills;
                addDetailBilltoListBox();
            }
        }

        private void addDetailBilltoListBox()
        {
            uiListBox1.Items.Clear();
            foreach (DetailBill detailBill in detailBills)
            {
                uiListBox1.Items.Add(detailBill.ToString());
            }
        }
    }
}
