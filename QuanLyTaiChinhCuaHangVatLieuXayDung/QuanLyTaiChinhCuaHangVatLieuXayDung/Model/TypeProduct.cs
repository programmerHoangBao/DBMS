using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Model
{
    internal class TypeProduct
    {
        private string idTypeProduct;
        private string nameTypeProduct;

        public TypeProduct()
        {
        }

        public string IdTypeProduct { get => idTypeProduct; set => idTypeProduct = value; }
        public string NameTypeProduct { get => nameTypeProduct; set => nameTypeProduct = value; }
    }
}
