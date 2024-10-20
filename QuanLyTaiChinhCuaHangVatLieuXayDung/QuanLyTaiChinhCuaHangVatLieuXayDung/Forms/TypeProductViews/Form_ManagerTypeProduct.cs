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
using System.Windows.Forms.VisualStyles;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.TypeProductViews
{
    public partial class Form_ManagerTypeProduct : Form
    {
        private ITypeProductService typeProductService;
        public Form_ManagerTypeProduct()
        {
            InitializeComponent();
            this.typeProductService = new TypeProductService();
        }

        private void Form_ManagerTypeProduct_Load(object sender, EventArgs e)
        {
            DisplayTypeProductOnUIDataGridViewAndUIComboBox(this.uiDataGridViewShowTypeProducts, uiComboBoxIdTypeProduct);
        }

        //biểu diển dữ liệu nhà cung cấp trên UIDataGridView và UIComboBox
        private void DisplayTypeProductOnUIDataGridViewAndUIComboBox(UIDataGridView uiDataGridView, UIComboBox uiComboBox)
        {
            //lấy dữ liệu từ database
            List<TypeProduct> typeProducts = new List<TypeProduct>();
            typeProducts = this.typeProductService.GetAllTypeProdcut();

            //Biểu diển dữ liệu trên uiDataGridView
            uiDataGridView.DataSource = typeProducts;
            uiDataGridView.Columns["IdTypeProduct"].HeaderText = "Mã loại sản phẩm";
            uiDataGridView.Columns["NameTypeProduct"].HeaderText = "Tên loại sản phẩm";

            //Biểu diển dữ liệu trên uiComboBox
            uiComboBox.Items.Clear();
            foreach (TypeProduct typeProduct in typeProducts)
            {
                uiComboBox.Items.Add(typeProduct.IdTypeProduct);
            }
        }

        private void dataGridViewShowTypeProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.uiComboBoxIdTypeProduct.Text = this.uiDataGridViewShowTypeProducts.Rows[e.RowIndex].Cells["IdTypeProduct"].Value.ToString().Trim();
                this.uiTextBoxNameTypeProduct.Text = this.uiDataGridViewShowTypeProducts.Rows[e.RowIndex].Cells["NameTypeProduct"].Value.ToString();
            }
            catch 
            {
                MessageBox.Show("Làm ơn chọn dữ liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uiComboBoxIdTypeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string idTypeProduct = this.uiComboBoxIdTypeProduct.SelectedItem.ToString();
                TypeProduct typeProduct = this.typeProductService.GetTypeProductById(idTypeProduct);

                if (!typeProduct.IsNull())
                {
                    this.uiTextBoxNameTypeProduct.Text = typeProduct.NameTypeProduct;
                }
                else
                {
                    MessageBox.Show("Loại sản phẩm không tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnInsertTypeProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string idTypeProduct = this.uiComboBoxIdTypeProduct.Text.Trim();
                string nameTypeProduct = this.uiTextBoxNameTypeProduct.Text.Trim();
                if (this.typeProductService.InsertTypeProduct(new TypeProduct(idTypeProduct, nameTypeProduct)))
                {
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //biểu diển lại dữ liệu trên uiDataGridViewShowTypeProducts và uiComboBoxIdTypeProduct
                    DisplayTypeProductOnUIDataGridViewAndUIComboBox(this.uiDataGridViewShowTypeProducts, uiComboBoxIdTypeProduct);
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

        private void btnUpdateTypeProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string idTypeProduct = this.uiComboBoxIdTypeProduct.Text.Trim();
                string nameTypeProduct = this.uiTextBoxNameTypeProduct.Text.Trim();
                if (this.typeProductService.UpdateTypeProduct(new TypeProduct(idTypeProduct, nameTypeProduct)))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //biểu diển lại dữ liệu trên uiDataGridViewShowTypeProducts và uiComboBoxIdTypeProduct
                    DisplayTypeProductOnUIDataGridViewAndUIComboBox(this.uiDataGridViewShowTypeProducts, uiComboBoxIdTypeProduct);
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

        private void btnDeleteTypeProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Xóa thành công: ";
                string idTypeProduct = "";
                string nameTypeProduct = "";

                foreach (DataGridViewRow selectRow in this.uiDataGridViewShowTypeProducts.SelectedRows)
                {
                    idTypeProduct = selectRow.Cells["IdTypeProduct"].Value.ToString().Trim();
                    nameTypeProduct = selectRow.Cells["NameTypeProduct"].Value.ToString().Trim();
                    if (this.typeProductService.DeleteTypeProduct(idTypeProduct))
                    {
                        message += "\n" + "-" + idTypeProduct + "\t" + nameTypeProduct;
                    }
                }

                if (!message.Equals("Xóa thành công: "))
                {
                    MessageBox.Show(message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //biểu diển lại dữ liệu trên uiDataGridViewShowTypeProducts và uiComboBoxIdTypeProduct
                    DisplayTypeProductOnUIDataGridViewAndUIComboBox(this.uiDataGridViewShowTypeProducts, uiComboBoxIdTypeProduct);
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

        private void uiButtonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                //biểu diển lại dữ liệu trên uiDataGridViewShowTypeProducts và uiComboBoxIdTypeProduct
                DisplayTypeProductOnUIDataGridViewAndUIComboBox(this.uiDataGridViewShowTypeProducts, uiComboBoxIdTypeProduct);

                this.uiComboBoxIdTypeProduct.Text = "";
                this.uiTextBoxNameTypeProduct.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
