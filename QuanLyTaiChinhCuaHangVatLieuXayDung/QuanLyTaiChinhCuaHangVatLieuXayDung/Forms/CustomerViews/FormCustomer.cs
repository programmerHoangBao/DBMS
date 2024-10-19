using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
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

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.CustomerViews
{
    public partial class FormCustomer : Form
    {
        private CustomerService customerService = new CustomerService();
        private string previousAction = "";

        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            ShowCustomersOnDataGridView();
            uiRadioButton_Insert_CheckedChanged(sender, e);
            uiRadioButton_Insert.Checked = true;
            SetupPlaceholderText(uiTextBoxIdCustomer, "Nhập Mã khách hàng...");
            SetupPlaceholderText(uiTextBoxNameCustomer, "Nhập Tên khách hàng...");
            SetupPlaceholderText(uiTextBoxPhoneNumber, "Nhập Số điện thoại...");
            SetupPlaceholderText(uiTextBoxAddress, "Nhập Địa chỉ...");
            SetupPlaceholderText(uiTextBoxSearch, "Nhập thông tin bất kì: Nguyen Van A...");
        }

        private void ShowCustomersOnDataGridView()
        {
            List<Customer> customers = customerService.GetAllCustomer();
            this.uiDataGridViewCustomer.DataSource = customers;

            //Đổi HeaderText cho dataGridView
            this.uiDataGridViewCustomer.Columns["IdCustomer"].HeaderText = "Mã khách hàng";
            this.uiDataGridViewCustomer.Columns["NameCustomer"].HeaderText = "Tên khách hàng";
            this.uiDataGridViewCustomer.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
            this.uiDataGridViewCustomer.Columns["AddressCustomer"].HeaderText = "Địa chỉ";

            this.uiDataGridViewCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.uiDataGridViewCustomer.Dock = DockStyle.Fill;
        }

        private void uiRadioButton_Insert_CheckedChanged(object sender, EventArgs e)
        {
            uiButton_Update.Enabled = false;
            uiButton_Delete.Enabled = false;
            uiButton_Insert.Enabled = true;
            uiTextBoxNameCustomer.Enabled = true;
            uiTextBoxPhoneNumber.Enabled = true;
            uiTextBoxAddress.Enabled = true;
            if (previousAction == "Delete")
            {
                SetupPlaceholderText(uiTextBoxIdCustomer, "Nhập Mã khách hàng...");
                SetupPlaceholderText(uiTextBoxNameCustomer, "Nhập Tên khách hàng...");
                SetupPlaceholderText(uiTextBoxPhoneNumber, "Nhập Số điện thoại...");
                SetupPlaceholderText(uiTextBoxAddress, "Nhập Địa chỉ...");
            }
            previousAction = "Insert";
        }

        private void uiRadioButton_Update_CheckedChanged(object sender, EventArgs e)
        {
            uiButton_Insert.Enabled = false;
            uiButton_Delete.Enabled = false;
            uiButton_Update.Enabled = true;
            uiTextBoxNameCustomer.Enabled = true;
            uiTextBoxPhoneNumber.Enabled = true;
            uiTextBoxAddress.Enabled = true;
            if (previousAction == "Delete")
            {
                SetupPlaceholderText(uiTextBoxIdCustomer, "Nhập Mã khách hàng...");
                SetupPlaceholderText(uiTextBoxNameCustomer, "Nhập Tên khách hàng...");
                SetupPlaceholderText(uiTextBoxPhoneNumber, "Nhập Số điện thoại...");
                SetupPlaceholderText(uiTextBoxAddress, "Nhập Địa chỉ...");
            }
            previousAction = "Update";
        }

        private void uiRadioButton_Delete_CheckedChanged(object sender, EventArgs e)
        {
            uiButton_Insert.Enabled = false;
            uiButton_Update.Enabled = false;
            uiButton_Delete.Enabled = true;
            uiTextBoxNameCustomer.Enabled = false;
            uiTextBoxPhoneNumber.Enabled = false;
            uiTextBoxAddress.Enabled = false;
            previousAction = "Delete";
        }

        private void uiButton_Insert_Click(object sender, EventArgs e)
        {
            string idCustomer = uiTextBoxIdCustomer.Text.Trim();
            string nameCustomer = uiTextBoxNameCustomer.Text.Trim();
            string phoneNumber = uiTextBoxPhoneNumber.Text.Trim();
            string address = uiTextBoxAddress.Text.Trim();

            customerService.InsertCustomer(new Customer(idCustomer, nameCustomer, phoneNumber, address));
            ShowCustomersOnDataGridView();
        }

        private void uiButton_Update_Click(object sender, EventArgs e)
        {
            string idCustomer = uiTextBoxIdCustomer.Text.Trim();
            string nameCustomer = uiTextBoxNameCustomer.Text.Trim();
            string phoneNumber = uiTextBoxPhoneNumber.Text.Trim();
            string address = uiTextBoxAddress.Text.Trim();

            customerService.UpdateCustomer(new Customer(idCustomer, nameCustomer, phoneNumber, address));
            ShowCustomersOnDataGridView();
        }

        private void uiButton_Delete_Click(object sender, EventArgs e)
        {
            string idCustomer = uiTextBoxIdCustomer.Text.Trim();
            customerService.DeleteCustomer(idCustomer);
            ShowCustomersOnDataGridView();
        }

        void SetupPlaceholderText(UITextBox textBox, string placeholder)
        {
            // Set the initial text to the placeholder
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            // Handle the "Enter" event (when the user starts typing)
            textBox.Enter += (sender, e) =>
            {
                // Only clear the placeholder if it is the current text
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            // Handle the "Leave" event (when the user leaves the textbox)
            textBox.Leave += (sender, e) =>
            {
                // Restore the placeholder if the text is empty or only whitespace
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };

            // Handle cases where data is filled programmatically (e.g., from DataGridView)
            textBox.TextChanged += (sender, e) =>
            {
                // If text is changed programmatically and it's not the placeholder, apply the normal style
                if (textBox.Text != placeholder)
                {
                    textBox.ForeColor = Color.Black;
                }
            };
        }

        private void dataGridViewShowCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.uiTextBoxIdCustomer.Text = this.uiDataGridViewCustomer.Rows[e.RowIndex].Cells["IdCustomer"].Value.ToString().Trim();
                this.uiTextBoxNameCustomer.Text = this.uiDataGridViewCustomer.Rows[e.RowIndex].Cells["NameCustomer"].Value.ToString().Trim();
                this.uiTextBoxPhoneNumber.Text = this.uiDataGridViewCustomer.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString().Trim();
                this.uiTextBoxAddress.Text = this.uiDataGridViewCustomer.Rows[e.RowIndex].Cells["AddressCustomer"].Value.ToString().Trim();
            }
            catch
            {
                return;
            }
        }

        private void uiButtonSearch_Click(object sender, EventArgs e)
        {
            string searchItem = this.uiTextBoxSearch.Text.Trim();
            List<Customer> customers = customerService.SearchCustomer(searchItem);
            this.uiDataGridViewCustomer.DataSource = customers;

            //Đổi HeaderText cho dataGridView
            this.uiDataGridViewCustomer.Columns["IdCustomer"].HeaderText = "Mã khách hàng";
            this.uiDataGridViewCustomer.Columns["NameCustomer"].HeaderText = "Tên khách hàng";
            this.uiDataGridViewCustomer.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
            this.uiDataGridViewCustomer.Columns["AddressCustomer"].HeaderText = "Địa chỉ";

            this.uiDataGridViewCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.uiDataGridViewCustomer.Dock = DockStyle.Fill;
        }
    }
}
