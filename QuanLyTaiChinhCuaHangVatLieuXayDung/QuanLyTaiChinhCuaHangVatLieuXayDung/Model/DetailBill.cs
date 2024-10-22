using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Model
{
    public class DetailBill
    {
        private string idBill;
        private string idProduct;
        private decimal quantityProduct;

        public DetailBill() { }

        public string IdBill { get => idBill; set => idBill = value; }
        public string IdProduct { get => idProduct; set => idProduct = value; }
        public decimal QuantityProduct { get => quantityProduct; set => quantityProduct = value; }
        // Phương thức để hiển thị chuỗi theo định dạng yêu cầu
        public override string ToString()
        {
            return $"Sản phẩm: {idProduct} | Số lượng: {quantityProduct}";
        }
    }
}
