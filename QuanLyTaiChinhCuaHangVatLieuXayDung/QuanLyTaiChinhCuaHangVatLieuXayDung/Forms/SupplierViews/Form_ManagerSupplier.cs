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
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.SupplierViews
{
    public partial class Form_ManagerSupplier : Form
    {
        private ISupplierService supplierService;
        public Form_ManagerSupplier()
        {
            InitializeComponent();
            this.supplierService = new SupplierService();
        }

        private void Form_ManagerSupplier_Load(object sender, EventArgs e)
        {
            DisplaySuppliersOnUIDataGridViewAndUiComboBox(this.uiDataGridViewSupplier, this.uiComboBoxIdSupplier);
            SetupPlaceholderText(this.uiTextBoxSearchTerm, "Nhập thông tin bất kì: ");
        }

        //Lấy dữ liệu từ Data truyền vào UIDataGridView và UIComboBox
        private void DisplaySuppliersOnUIDataGridViewAndUiComboBox(UIDataGridView uiDataGridView, UIComboBox uiComboBox)
        {
            //Lấy dữ liệu từ database
            List<Supplier> suppliers = new List<Supplier>();
            suppliers = this.supplierService.GetAllSupplier();

            //set dữ liệu trên uiDataGridView
            uiDataGridView.DataSource = suppliers;
            uiDataGridView.Columns["IdSupplier"].HeaderText = "Mã nhà cung cấp";
            uiDataGridView.Columns["NameSupplier"].HeaderText = "Tên";
            uiDataGridView.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
            uiDataGridView.Columns["AddressSupplier"].HeaderText = "Địa chỉ";

            //set dữ liệu cho uiComboBox
            uiComboBox.Items.Clear();
            foreach (Supplier supplier in suppliers)
            {
                uiComboBox.Items.Add(supplier.IdSupplier);
            }
        }

        //Tạo thuộc tính placeholder cho textBox
        void SetupPlaceholderText(UITextBox textBox, string placeholder)
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

        private void uiDataGridViewSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.uiComboBoxIdSupplier.Text = this.uiDataGridViewSupplier.Rows[e.RowIndex].Cells["IdSupplier"].Value.ToString();
                this.uiTextBoxNameSupplier.Text = this.uiDataGridViewSupplier.Rows[e.RowIndex].Cells["NameSupplier"].Value.ToString();
                this.uiTextBoxPhoneNumber.Text = this.uiDataGridViewSupplier.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
                this.uiTextBoxAddress.Text = this.uiDataGridViewSupplier.Rows[e.RowIndex].Cells["AddressSupplier"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Làm ơn chọn dữ liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void uiComboBoxIdSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Supplier supplier = this.supplierService.GetSupplierById(this.uiComboBoxIdSupplier.Text.ToString());
                if (!supplier.IsNull())
                {
                    this.uiTextBoxNameSupplier.Text = supplier.NameSupplier;
                    this.uiTextBoxPhoneNumber.Text = supplier.PhoneNumber;
                    this.uiTextBoxAddress.Text = supplier.AddressSupplier;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Notification",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnInsertSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                string idSupplier = this.uiComboBoxIdSupplier.Text.Trim();
                string nameSupplier = this.uiTextBoxNameSupplier.Text.Trim();
                string phoneNumber = this.uiTextBoxPhoneNumber.Text.Trim();
                string address = this.uiTextBoxAddress.Text.Trim();

                if (this.supplierService.InsertSupplier(new Supplier(idSupplier, nameSupplier, phoneNumber, address)))
                {
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Khởi tạo lại uiDataGridViewSupplier và uiComboBoxIdSupplier
                    DisplaySuppliersOnUIDataGridViewAndUiComboBox(this.uiDataGridViewSupplier, this.uiComboBoxIdSupplier);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Notification",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uiBtnUpdateSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                string idSupplier = this.uiComboBoxIdSupplier.Text.Trim();
                string nameSupplier = this.uiTextBoxNameSupplier.Text.Trim();
                string phoneNumber = this.uiTextBoxPhoneNumber.Text.Trim();
                string address = this.uiTextBoxAddress.Text.Trim();

                if (this.supplierService.UpdateSupplier(new Supplier(idSupplier, nameSupplier, phoneNumber, address)))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Khởi tạo lại uiDataGridViewSupplier và uiComboBoxIdSupplier
                    DisplaySuppliersOnUIDataGridViewAndUiComboBox(this.uiDataGridViewSupplier, this.uiComboBoxIdSupplier);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Notification",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uiBtnDeleteSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Xóa thành công: ";
                string idSupplier = "";
                
                foreach (DataGridViewRow selectRow in this.uiDataGridViewSupplier.SelectedRows)
                {
                    idSupplier = selectRow.Cells["IdSupplier"].Value.ToString().Trim();
                    
                    if (this.supplierService.DeleteSupplier(idSupplier))
                    {
                        message += "\n" + "-" + idSupplier;
                    }
                }

                if (!message.Equals("Xóa thành công: "))
                {
                    MessageBox.Show(message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Khởi tạo lại uiDataGridViewSupplier và uiComboBoxIdSupplier
                    DisplaySuppliersOnUIDataGridViewAndUiComboBox(this.uiDataGridViewSupplier, this.uiComboBoxIdSupplier);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Notification",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uiBtnSearchSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = this.uiTextBoxSearchTerm.Text.Trim();

                List<Supplier> suppliers = this.supplierService.SearchSupplier(searchTerm);

                if (suppliers.Count > 0)
                {
                    MessageBox.Show("Tìm thấy " + suppliers.Count.ToString() + " nhà cung cấp!", "Thông Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.uiDataGridViewSupplier.DataSource = suppliers;
                    this.uiComboBoxIdSupplier.Text = suppliers[0].IdSupplier;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bất kì nhà cung nào!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Notification",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uiButtonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                //biểu diển lại dữ liệu trên uiDataGridViewShowTypeProducts và uiComboBoxIdTypeProduct
                DisplaySuppliersOnUIDataGridViewAndUiComboBox(this.uiDataGridViewSupplier, uiComboBoxIdSupplier);

                //Xét các textBox về gí trị ban đầu
                foreach (Control control in this.uiPanelInformationSupplier.Controls)
                {
                    if ( !((control is UILabel) || (control is UISymbolLabel)) )
                    {
                        control.Text = "";
                    }
                }

                this.uiTextBoxSearchTerm.Text = "";
                this.uiTextBoxSearchTerm.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
