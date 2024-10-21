using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Service;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Service.Implements;
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

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.ProductView
{
    public partial class Form_ManagerProduct : Form
    {
        MyDatabase myDatabase = new MyDatabase();
        ProductService productservice = new ProductService();
        public Form_ManagerProduct()
        {
            InitializeComponent();
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void Form_ManagerProduct_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadLoaiSP();
            LoadNhaCungCap();
        }
        private void LoadLoaiSP()
        {
            TypeProductService typeProductService = new TypeProductService();
            List<TypeProduct> typeProducts = typeProductService.GetAllTypeProdcut();

            // Thiết lập dữ liệu cho ComboBox
            comboBoxLoaiSP.DataSource = typeProducts;
            comboBoxLoaiSP.DisplayMember = "NameTypeProduct";  // Hiển thị tên loại sản phẩm
            comboBoxLoaiSP.ValueMember = "IdTypeProduct";      // Giá trị là mã loại sản phẩm
        }


        private void LoadNhaCungCap()
        {
            SupplierService supplierService = new SupplierService();
            List<Supplier> suppliers = supplierService.GetAllSupplier();

            comboBoxNhaCungCap.DataSource = suppliers;
            comboBoxNhaCungCap.DisplayMember = "NameSupplier";
            comboBoxNhaCungCap.ValueMember = "IdSupplier";
        }

        private void LoadData()
        {
            List<Product> products = new List<Product>();
            products = this.productservice.GetAllProduct();

            // Tạo danh sách với dữ liệu cần hiển thị cho DataGridView
            var productDisplayList = products.Select(p => new
            {
                IdProduct = p.IdProduct,
                NameProduct = p.NameProduct,
                Unit = p.Unit,
                UnitPriceImport = p.UnitPriceImport,
                UnitPriceExport = p.UnitPriceExport,
                QuantityProduct = p.QuantityProduct,
                IdTypeProduct = p.TypeProduct?.IdTypeProduct,  // Lấy thuộc tính Name từ đối tượng IdTypeProduct
                IdSupplier = p.Supplier?.IdSupplier,  // Lấy thuộc tính SupplierName từ đối tượng IdSupplier
                ImageProduct = p.ImageProduct
            }).ToList();

            // Gán dữ liệu cho DataGridView
            dataGridViewProduct.DataSource = productDisplayList;
            dataGridViewProduct.Columns["IdProduct"].HeaderText = "Mã sản phẩm";
            dataGridViewProduct.Columns["NameProduct"].HeaderText = "Tên sản phẩm";
            dataGridViewProduct.Columns["Unit"].HeaderText = "Đơn vị tính";
            dataGridViewProduct.Columns["UnitPriceImport"].HeaderText = "Giá nhập";
            dataGridViewProduct.Columns["UnitPriceExport"].HeaderText = "Giá bán";
            dataGridViewProduct.Columns["QuantityProduct"].HeaderText = "Số lượng";
            dataGridViewProduct.Columns["IdTypeProduct"].HeaderText = "Mã loại sản phẩm";
            dataGridViewProduct.Columns["IdSupplier"].HeaderText = "Mã nhà cung cấp";
            dataGridViewProduct.Columns["ImageProduct"].HeaderText = "Hình ảnh";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MemoryStream pic = new MemoryStream();
            pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
            Model.Product product = new Model.Product();
            try
            {
                product.IdProduct = textBoxID.Text;
                product.NameProduct = textBoxTenSP.Text;
                product.Unit = textBoxDonViTinh.Text;
                product.UnitPriceImport = Convert.ToDecimal(textBoxGiaNhap.Text);
                product.UnitPriceExport = Convert.ToDecimal(textBoxGiaBan.Text);
                product.QuantityProduct = Convert.ToDecimal(textBoxSoLuong.Text);
                product.TypeProduct = new TypeProduct();
                product.TypeProduct.IdTypeProduct = comboBoxLoaiSP.SelectedValue.ToString();
                product.Supplier = new Supplier();
                product.Supplier.IdSupplier = comboBoxNhaCungCap.SelectedValue.ToString();
                product.ImageProduct = pic.ToArray();
                if (productservice.InsertProduct(product))
                {
                    MessageBox.Show("Sản phẩm đã được thêm", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm không thành công", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ProductService productService = new ProductService();
            MemoryStream pic = new MemoryStream();
            try
            {
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);

                Model.Product product = new Model.Product();
                product.IdProduct = textBoxID.Text;
                product.NameProduct = textBoxTenSP.Text;
                product.Unit = textBoxDonViTinh.Text;
                product.UnitPriceImport = Convert.ToDecimal(textBoxGiaNhap.Text);
                product.UnitPriceExport = Convert.ToDecimal(textBoxGiaBan.Text);
                product.QuantityProduct = Convert.ToDecimal(textBoxSoLuong.Text);
                product.TypeProduct = new TypeProduct();
                product.TypeProduct.IdTypeProduct = comboBoxLoaiSP.SelectedValue.ToString();
                product.Supplier = new Supplier();
                product.Supplier.IdSupplier = comboBoxNhaCungCap.SelectedValue.ToString();
                product.ImageProduct = pic.ToArray();
                if (productService.UpdateProduct(product))
                {
                    MessageBox.Show("Sản phẩm đã được chỉnh sửa", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa sản phẩm không thành công", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "Xóa thành công: ";
                string idProduct = "";

                foreach (DataGridViewRow selectRow in this.dataGridViewProduct.SelectedRows)
                {
                    idProduct = selectRow.Cells["IdProduct"].Value.ToString().Trim();

                    if (this.productservice.DeleteProduct(idProduct))
                    {
                        message += "\n" + "-" + idProduct;
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

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = textBoxSearchProduct.Text;

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    // Gọi hàm tìm kiếm sản phẩm
                    List<Model.Product> products = productservice.SearchProducts(searchTerm);

                    // Hiển thị kết quả lên DataGridView
                    dataGridViewProduct.DataSource = null; // Xóa dữ liệu cũ nếu có
                    dataGridViewProduct.DataSource = products;

                    // Tùy chọn: Làm mới giao diện DataGridView (nếu cần)
                    dataGridViewProduct.Refresh();
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

        private void dataGridViewProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewProduct.CurrentRow.Cells[0].Value.ToString();
            textBoxTenSP.Text = dataGridViewProduct.CurrentRow.Cells[1].Value.ToString();
            textBoxDonViTinh.Text = dataGridViewProduct.CurrentRow.Cells[2].Value.ToString();
            textBoxGiaNhap.Text = dataGridViewProduct.CurrentRow.Cells[3].Value.ToString();
            textBoxGiaBan.Text = dataGridViewProduct.CurrentRow.Cells[4].Value.ToString();
            textBoxSoLuong.Text = dataGridViewProduct.CurrentRow.Cells[5].Value.ToString();
            comboBoxLoaiSP.Text = dataGridViewProduct.CurrentRow.Cells[6].Value.ToString();
            comboBoxNhaCungCap.Text = dataGridViewProduct.CurrentRow.Cells[7].Value.ToString();

            /*byte[] pic;
            pic = (byte[])dataGridViewProduct.CurrentRow.Cells[8].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBox1.Image = Image.FromStream(picture);*/
            if (dataGridViewProduct.CurrentRow.Cells[8].Value != DBNull.Value && dataGridViewProduct.CurrentRow.Cells[8].Value != null)
            {
                try
                {
                    byte[] pic = (byte[])dataGridViewProduct.CurrentRow.Cells[8].Value;
                    if (pic.Length > 0)
                    {
                        MemoryStream picture = new MemoryStream(pic);
                        pictureBox1.Image = Image.FromStream(picture);
                    }
                    else
                    {
                        // Nếu dữ liệu ảnh trống thì xóa ảnh hiện tại
                        pictureBox1.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message);
                    pictureBox1.Image = null; // Nếu có lỗi thì xóa ảnh hiện tại
                }
            }
            else
            {
                // Nếu không có dữ liệu ảnh thì xóa ảnh hiện tại
                pictureBox1.Image = null;
            }
        }

    }
}
