using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Model
{
    internal class TypeProducts
    {
        private string idTypeProduct;
        private string nameTypeProduct;

        public TypeProducts()
        {
        }

        public string IdTypeProduct { get => idTypeProduct; set => idTypeProduct = value; }
        public string NameTypeProduct { get => nameTypeProduct; set => nameTypeProduct = value; }
    }
}
