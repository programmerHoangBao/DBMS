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
using QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.DetailBillViews;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.BillViews
{
    public partial class Form_ManagerBill : Form
    {
        private IBillService billService = new BillService();
        IDetailBillService detailBillService = new DetailBillService();
        List<DetailBill> detailBills;
        List<DetailBill> listAddDetailBill;
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
                        foreach(DetailBill detailBill in listAddDetailBill)
                        {
                            if (!detailBillService.InsertDetailBill(detailBill))
                            {
                                MessageBox.Show("Thêm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                if (billService.CheckExistBillInD(txt_idBill.Text))
                                {
                                    billService.DeleteBill(txt_idBill.Text);
                                }
                                return;
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
                        foreach (DetailBill detailBill in listAddDetailBill)
                        {
                            MessageBox.Show("Thêm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (billService.CheckExistBillInD(txt_idBill.Text))
                            {
                                billService.DeleteBill(txt_idBill.Text);
                            }
                            return;
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
                form.ShowDialog();
                listAddDetailBill = form.detailBills;
                detailBills.AddRange(listAddDetailBill);
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

        private void dgv_listbill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            Form_ManagerDetailBill form = new Form_ManagerDetailBill();
            if (cbb_selectTypeBill.SelectedIndex == 0)
            {
                form.dgv_listDetailBill.DataSource = billService.GetListProductImportBill(dgv_listbill.Rows[e.RowIndex].Cells["IdBill"].Value.ToString().Trim());
                form.dgv_listDetailBill.Columns["IdProduct"].HeaderText = "Mã sản phẩm";
                form.dgv_listDetailBill.Columns["NameProduct"].HeaderText = "Tên sản phẩm";
                form.dgv_listDetailBill.Columns["UnitPriceImport"].Visible = true;
                form.dgv_listDetailBill.Columns["Unit"].HeaderText = "Đơn vị";
                form.dgv_listDetailBill.Columns["UnitPriceImport"].HeaderText = "Giá nhập";
                form.dgv_listDetailBill.Columns["QuantityProduct"].HeaderText = "Số lượng";
                form.dgv_listDetailBill.Columns["ImageProduct"].HeaderText = "Hình ảnh";
                form.dgv_listDetailBill.Columns["UnitPriceExport"].Visible = false;

            }
            else
            {
                form.dgv_listDetailBill.DataSource = billService.GetListProductExportBill(dgv_listbill.Rows[e.RowIndex].Cells["IdBill"].Value.ToString().Trim());
                form.dgv_listDetailBill.Columns["IdProduct"].HeaderText = "Mã sản phẩm";
                form.dgv_listDetailBill.Columns["NameProduct"].HeaderText = "Tên sản phẩm";
                form.dgv_listDetailBill.Columns["UnitPriceExport"].Visible = true;
                form.dgv_listDetailBill.Columns["Unit"].HeaderText = "Đơn vị";
                form.dgv_listDetailBill.Columns["UnitPriceExport"].HeaderText = "Giá bán";
                form.dgv_listDetailBill.Columns["QuantityProduct"].HeaderText = "Số lượng";
                form.dgv_listDetailBill.Columns["ImageProduct"].HeaderText = "Hình ảnh";
                form.dgv_listDetailBill.Columns["UnitPriceImport"].Visible = false;
            }
            form.ShowDialog();
        }

        private void dgv_listbill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (cbb_selectTypeBill.SelectedIndex == 0)
            {
                List<Product> products = billService.GetListProductImportBill(txt_idBill.Text);
                detailBills.Clear();
                DetailBill detailBill;
                foreach (Product product in products)
                {
                    detailBill = new DetailBill();
                    detailBill.IdBill = txt_idBill.Text;
                    detailBill.IdProduct = product.IdProduct;
                    detailBill.QuantityProduct = product.QuantityProduct;
                    detailBills.Add(detailBill);
                }
                addDetailBilltoListBox();
                cbb_typeBill.SelectedIndex = 0;
                txt_idBill.Text = dgv_listbill.Rows[e.RowIndex].Cells["IdBill"].Value.ToString();
                txt_idSupOrCus.Text = dgv_listbill.Rows[e.RowIndex].Cells["IdSupplier"].Value.ToString();
            }
            else
            {
                List<Product> products = billService.GetListProductExportBill(txt_idBill.Text);
                detailBills.Clear();
                DetailBill detailBill;
                foreach (Product product in products)
                {
                    detailBill = new DetailBill();
                    detailBill.IdBill = txt_idBill.Text;
                    detailBill.IdProduct = product.IdProduct;
                    detailBill.QuantityProduct = product.QuantityProduct;
                    detailBills.Add(detailBill);
                }
                addDetailBilltoListBox();
                cbb_typeBill.SelectedIndex = 1;
                txt_idBill.Text = dgv_listbill.Rows[e.RowIndex].Cells["IdBill"].Value.ToString();
                txt_idSupOrCus.Text = dgv_listbill.Rows[e.RowIndex].Cells["IdCustomer"].Value.ToString();
            }
        }

        private void uiButtonDeleteBill_Click(object sender, EventArgs e)
        {
            if (dgv_listbill.SelectedRows.Count == -1)
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa");
            }
            else
            {
                if (billService.DeleteBill(dgv_listbill.Rows[dgv_listbill.SelectedIndex].Cells["IdBill"].Value.ToString()))
                {
                    MessageBox.Show("Xóa thành công");
                    DisplaySuppliersOnUIDataGridViewAndUiComboBox(dgv_listbill, cbb_selectTypeBill, cbb_typeBill);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }

        private void uiButtonUpdateBill_Click(object sender, EventArgs e)
        {

        }
    }
}
