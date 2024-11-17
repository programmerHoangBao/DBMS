using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Model
{
    internal class Supplier
    {
        private string idSupplier;
        private string nameSupplier;
        private string phoneNumber;
        private string addressSupplier;

        public Supplier()
        {
        }

        public Supplier(string idSupplier, string nameSupplier, string phoneNumber, string addressSupplier)
        {
            this.idSupplier = idSupplier;
            this.nameSupplier = nameSupplier;
            this.phoneNumber = phoneNumber;
            this.addressSupplier = addressSupplier;
        }

        public string IdSupplier { get => idSupplier; set => idSupplier = value; }
        public string NameSupplier { get => nameSupplier; set => nameSupplier = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string AddressSupplier { get => addressSupplier; set => addressSupplier = value; }

        public bool IsNull()
        {
            return (String.IsNullOrEmpty(this.idSupplier) || String.IsNullOrEmpty(this.nameSupplier)
                    || String.IsNullOrEmpty(this.phoneNumber) || String.IsNullOrEmpty(this.addressSupplier));
        }
    }
}
