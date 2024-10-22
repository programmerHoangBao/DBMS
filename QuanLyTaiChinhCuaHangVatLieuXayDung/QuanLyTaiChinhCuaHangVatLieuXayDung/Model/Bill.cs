using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Model
{
    internal class Bill
    {
        private string idBill;
        private string idCustomer;
        private string idSupplier;
        private DateTime dateCreate;
        private string typeBill;
        private decimal total = 0;

        public Bill()
        {
        }

        public Bill(string idBill, string idCustomer, DateTime dateCreate, string typeBill)
        {
            IdBill = idBill;
            IdCustomer = idCustomer;
            DateCreate = dateCreate;
            TypeBill = typeBill;
        }

        public string IdBill { get => idBill; set => idBill = value; }
        public string IdCustomer { get => idCustomer; set => idCustomer = value; }
        public string IdSupplier { get => idSupplier; set => idSupplier = value; }  
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
        public string TypeBill { get => typeBill; set => typeBill = value; }
        public decimal Total { get => total; set => total = value; }
    }
}
