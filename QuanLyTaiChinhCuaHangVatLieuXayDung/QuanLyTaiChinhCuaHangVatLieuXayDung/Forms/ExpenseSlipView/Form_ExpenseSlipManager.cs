using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Service;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Service.Implements;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.ExpenseSlipView
{
    public partial class Form_ExpenseSlipManager : Form
    {
        MyDatabase myDatabase = new MyDatabase();
        ExpenseSlipService expenseslipservice = new ExpenseSlipService();
        public Form_ExpenseSlipManager()
        {
            InitializeComponent();
        }

        private void Form_ExpenseSlipManager_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            List<ExpenseSlip> expenseslips = new List<ExpenseSlip>();
            expenseslips = this.expenseslipservice.GetAllExpenseSlip();
            
            dataGridViewExpenseSlip.DataSource = expenseslips;
            dataGridViewExpenseSlip.Columns["IdExpenseSlip"].HeaderText = "Mã phiếu";
            dataGridViewExpenseSlip.Columns["DateCreate"].HeaderText = "Ngày tạo";
            dataGridViewExpenseSlip.Columns["Content"].HeaderText = "Nội dung";
            dataGridViewExpenseSlip.Columns["TypeExpenseSlip"].HeaderText = "Loại phiếu";
            dataGridViewExpenseSlip.Columns["TotalMoney"].HeaderText = "Tổng tiền";

            comBoBoxTypeExpenseSlip.Items.Clear();
            comBoBoxTypeExpenseSlip.Items.Add("Phiếu Thu");
            comBoBoxTypeExpenseSlip.Items.Add("Phiếu Chi");

            datePickerDayCreate.DateFormat = "dd/MM/yyyy";
            
            labelTotalMoney.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Model.ExpenseSlip expenseslip = new Model.ExpenseSlip();
                expenseslip.IdExpenseSlip = textBoxID.Text;
                expenseslip.DateCreate = datePickerDayCreate.Value;
                expenseslip.Content = textBoxContent.Text;
                expenseslip.TypeExpenseSlip = comBoBoxTypeExpenseSlip.Text;
                expenseslip.TotalMoney = Convert.ToDecimal(textBoxTotalMoney.Text);

                if (expenseslipservice.InsertExpenseSlip(expenseslip))
                {
                    MessageBox.Show("Thêm thành công", "Hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadData();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            ExpenseSlipService expenseslipservice = new ExpenseSlipService();
            try
            {
                Model.ExpenseSlip expenseslip = new Model.ExpenseSlip();
                expenseslip.IdExpenseSlip = textBoxID.Text;
                expenseslip.DateCreate = datePickerDayCreate.Value;
                expenseslip.Content = textBoxContent.Text;
                expenseslip.TypeExpenseSlip = comBoBoxTypeExpenseSlip.Text;
                expenseslip.TotalMoney = Convert.ToDecimal(textBoxTotalMoney.Text);
                if (expenseslipservice.UpdateExpenseSlip(expenseslip))
                {
                    MessageBox.Show("Chỉnh sửa thành công", "Hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa không thành công", "Hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewExpenseSlip_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewExpenseSlip.CurrentRow.Cells[0].Value.ToString();
            dataGridViewExpenseSlip.Text = dataGridViewExpenseSlip.CurrentRow.Cells[1].Value.ToString();
            textBoxContent.Text = dataGridViewExpenseSlip.CurrentRow.Cells[2].Value.ToString();
            comBoBoxTypeExpenseSlip.Text = dataGridViewExpenseSlip.CurrentRow.Cells[3].Value.ToString();
            textBoxTotalMoney.Text = dataGridViewExpenseSlip.CurrentRow.Cells[4].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Xóa thành công: ";
                string idExpenseslip = "";

                foreach (DataGridViewRow selectRow in this.dataGridViewExpenseSlip.SelectedRows)
                {
                    idExpenseslip = selectRow.Cells["IdExpenseSlip"].Value.ToString().Trim();

                    if (this.expenseslipservice.DeleteExpenseSlip(idExpenseslip))
                    {
                        message += "\n" + "-" + idExpenseslip;
                    }
                }

                if (!message.Equals("Xóa thành công: "))
                {
                    MessageBox.Show(message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Khởi tạo lại uiDataGridViewSupplier và uiComboBoxIdSupplier
                    LoadData();
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = textBoxSearchProduct.Text;

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    // Gọi hàm tìm kiếm sản phẩm
                    List<Model.ExpenseSlip> expenseslips = expenseslipservice.SearchExpenseSlip(searchTerm);

                    // Hiển thị kết quả lên DataGridView
                    dataGridViewExpenseSlip.DataSource = null; // Xóa dữ liệu cũ nếu có
                    dataGridViewExpenseSlip.DataSource = expenseslips;

                    // Tùy chọn: Làm mới giao diện DataGridView (nếu cần)
                    dataGridViewExpenseSlip.Refresh();
                }
                else
                {
                    MessageBox.Show("Hãy điền thông tin tìm kiếm.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Notification",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonFillReceive_Click(object sender, EventArgs e)
        {
            List<ExpenseSlip> expenseslips = new List<ExpenseSlip>();
            expenseslips = this.expenseslipservice.GetExpenseSlipReceive();

            dataGridViewExpenseSlip.DataSource = expenseslips;
            dataGridViewExpenseSlip.Columns["IdExpenseSlip"].HeaderText = "Mã phiếu";
            dataGridViewExpenseSlip.Columns["DateCreate"].HeaderText = "Ngày tạo";
            dataGridViewExpenseSlip.Columns["Content"].HeaderText = "Nội dung";
            dataGridViewExpenseSlip.Columns["TypeExpenseSlip"].HeaderText = "Loại phiếu";
            dataGridViewExpenseSlip.Columns["TotalMoney"].HeaderText = "Tổng tiền";

            decimal totalMoney = expenseslipservice.CalculateTotalMoneyExpenseSlipReceive();
            labelTotalMoney.Visible = true;
            labelTotalMoney.Text = labelTotalMoney.Text + totalMoney.ToString();
        }

        private void buttonSpend_Click(object sender, EventArgs e)
        {
            List<ExpenseSlip> expenseslips = new List<ExpenseSlip>();
            expenseslips = this.expenseslipservice.GetExpenseSlipSpend();

            dataGridViewExpenseSlip.DataSource = expenseslips;
            dataGridViewExpenseSlip.Columns["IdExpenseSlip"].HeaderText = "Mã phiếu";
            dataGridViewExpenseSlip.Columns["DateCreate"].HeaderText = "Ngày tạo";
            dataGridViewExpenseSlip.Columns["Content"].HeaderText = "Nội dung";
            dataGridViewExpenseSlip.Columns["TypeExpenseSlip"].HeaderText = "Loại phiếu";
            dataGridViewExpenseSlip.Columns["TotalMoney"].HeaderText = "Tổng tiền";

            decimal totalMoney = expenseslipservice.CalculateTotalMoneyExpenseSlipSpend();
            labelTotalMoney.Visible = true;
            labelTotalMoney.Text = labelTotalMoney.Text + totalMoney.ToString();
        }
    }
}
