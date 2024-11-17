using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.User_Control
{
    public partial class UCDisplayProduct : UserControl
    {
        private Product product;
        private string typeBill;

        internal Product Product { get => product; set => product = value; }
        public string TypeBill { get => typeBill; set => typeBill = value; }

        public UCDisplayProduct()
        {
            InitializeComponent();
            this.Product = new Product();
        }

        private void UCDisplayProduct_Load(object sender, EventArgs e)
        {
            ShowProduct();
        }

        
        //Xu ly  ảnh
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        //hiển thị thông tin Product trên label và hiển thị hình ảnh
        private void ShowProduct() 
        {
            this.labelNameProduct.Text += this.Product.NameProduct;
            this.labelQunatity.Text += this.Product.QuantityProduct.ToString();

            if ( this.TypeBill.Equals("Hóa Đơn Nhập Hàng") )
            {
                this.labelPrice.Text = "Gía nhập hàng " + this.Product.UnitPriceImport.ToString()
                                            + "/" + this.Product.Unit;
                this.uiSymbolButtonTransaction.BackColor = Color.Blue;
            }
            else
            {
                this.labelPrice.Text = "Gía xuất hàng " + this.Product.UnitPriceExport.ToString()
                                            + "/" + this.Product.Unit;
            }

            if (this.product.ImageProduct != null && this.product.ImageProduct.Length > 0)
            {
                this.pictureBoxImageProduct.Image = ByteArrayToImage(this.product.ImageProduct);
            }
            else
            {
                this.pictureBoxImageProduct.Image = null;
            }
        }
    }
}
