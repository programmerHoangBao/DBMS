using System;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Model
{
    internal class TypeProduct
    {
        private string idTypeProduct;
        private string nameTypeProduct;

        public TypeProduct()
        {
        }

        public TypeProduct(string idTypeProduct, string nameTypeProduct)
        {
            IdTypeProduct = idTypeProduct;
            NameTypeProduct = nameTypeProduct;
            IdTypeProduct = idTypeProduct;
            NameTypeProduct = nameTypeProduct;
        }

        public string IdTypeProduct { get => idTypeProduct; set => idTypeProduct = value; }
        public string NameTypeProduct { get => nameTypeProduct; set => nameTypeProduct = value; }

        public bool IsNull()
        {
            return (String.IsNullOrEmpty(this.idTypeProduct) && String.IsNullOrEmpty(this.NameTypeProduct));
        }
    }
}
