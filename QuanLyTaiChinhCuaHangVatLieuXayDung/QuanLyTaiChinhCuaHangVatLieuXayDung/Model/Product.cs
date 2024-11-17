using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Model
{
    internal class Product
    {
        private string idProduct;
        private string nameProduct;
        private string unit;
        private decimal unitPriceImport;
        private decimal unitPriceExport;
        private decimal quantityProduct;
        private TypeProduct typeProduct = new TypeProduct();
        private Supplier supplier = new Supplier();
        private byte[] imageProduct;

        public Product()
        {
        }

        public string IdProduct { get => idProduct; set => idProduct = value; }
        public string NameProduct { get => nameProduct; set => nameProduct = value; }
        public string Unit { get => unit; set => unit = value; }
        public decimal UnitPriceImport { get => unitPriceImport; set => unitPriceImport = value; }
        public decimal UnitPriceExport { get => unitPriceExport; set => unitPriceExport = value; }
        public decimal QuantityProduct { get => quantityProduct; set => quantityProduct = value; }
        public byte[] ImageProduct { get => imageProduct; set => imageProduct = value; }
        internal TypeProduct TypeProduct { get => typeProduct; set => typeProduct = value; }
        internal Supplier Supplier { get => supplier; set => supplier = value; }


    }
}
