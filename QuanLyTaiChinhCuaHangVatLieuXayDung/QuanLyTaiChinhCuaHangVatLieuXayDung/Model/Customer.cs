using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Model
{
    internal class Customer
    {
        string idCustomer;
        string nameCustomer;
        string phoneNumber;
        string addressCustomer;

        public Customer() { }
        public Customer(string idCustomer, string nameCustomer, string phoneNumber, string addressCustomer)
        {
            IdCustomer = idCustomer;
            NameCustomer = nameCustomer;
            PhoneNumber = phoneNumber;
            AddressCustomer = addressCustomer;
        }

        public string IdCustomer { get => idCustomer; set => idCustomer = value; }
        public string NameCustomer { get => nameCustomer; set => nameCustomer = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string AddressCustomer { get => addressCustomer; set => addressCustomer = value; }
    }
}
