using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
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

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.BillViews
{
    public partial class Form_SelectProduct : Form
    {

        IProductService productService = new ProductService();
        public List<DetailBill> detailBills;
        List<Product> products = new List<Product>();

        public Form_SelectProduct()
        {
            InitializeComponent();
        }

        private void Form_SelectProduct_Load(object sender, EventArgs e)
        {
            products = productService.GetAllProduct();
            cbb_idProduct.Items.Clear();
            foreach (Product product in products)
            {
                cbb_idProduct.Items.Add(product.IdProduct);
            }
            addDetailBilltoListBox();
        }

        private void btt_add_Click(object sender, EventArgs e)
        {
            if (!cbb_idProduct.Items.Contains(cbb_idProduct.Text))
            {
                MessageBox.Show("Mã sản phẩm không có trong dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checkIdProductExist())
            {
                MessageBox.Show("Mã sản phẩm đã có trong danh sách thêm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DetailBill detailBill = new DetailBill();
                detailBill.IdBill = txt_idBill.Text;
                detailBill.IdProduct = cbb_idProduct.Text;
                detailBill.QuantityProduct = (Decimal)numeric_quantity.Value;
                detailBills.Add(detailBill);
            }
            addDetailBilltoListBox();
        }

        private void addDetailBilltoListBox()
        {
            listbox_selected.Items.Clear();
            foreach (DetailBill detailBill in detailBills)
            {
                listbox_selected.Items.Add(detailBill.ToString());
            }
        }

        private void btt_delete_Click(object sender, EventArgs e)
        {
            if (listbox_selected.SelectedIndex == -1)
            {
                return;
            }
            detailBills.RemoveAt(listbox_selected.SelectedIndex);
            addDetailBilltoListBox();
        }

        bool checkIdProductExist()
        {
            foreach (DetailBill detailBill in detailBills)
            {
                if (detailBill.IdProduct == cbb_idProduct.Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void btt_complete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
