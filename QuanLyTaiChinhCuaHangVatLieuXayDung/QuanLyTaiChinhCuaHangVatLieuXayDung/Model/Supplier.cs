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
        private string phoneSupplier;
        private string addressSupplier;

        public Supplier()
        {
        }

        public string IdSupplier { get => idSupplier; set => idSupplier = value; }
        public string NameSupplier { get => nameSupplier; set => nameSupplier = value; }
        public string PhoneSupplier { get => phoneSupplier; set => phoneSupplier = value; }
        public string AddressSupplier { get => addressSupplier; set => addressSupplier = value; }
    }
}
