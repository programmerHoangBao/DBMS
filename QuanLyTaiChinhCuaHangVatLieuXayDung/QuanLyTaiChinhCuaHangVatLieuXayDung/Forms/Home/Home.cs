using QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.CustomerViews;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Service.Implements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.Home
{
    public partial class Home : Form
    {
        private MyDatabase myDatabase = new MyDatabase();
        private Form formChild;     //Form con
        private DataGridView dataGridView;
        public Home()
        {
            InitializeComponent();
            dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;
            this.uiPanel_Body.Controls.Add(dataGridView);
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

        //Thực hiện hiển thị form con
        void OpenFormChild(Form formChild)
        {
            this.uiPanel_Body.Controls.Clear();
            this.formChild = new Form();
            this.formChild = formChild;
            this.formChild.TopLevel = false;
            this.uiPanel_Body.Controls.Add(this.formChild);
            this.formChild.FormBorderStyle = FormBorderStyle.None;
            this.formChild.Dock = DockStyle.Fill;
            this.formChild.Show();
        }

        private void uiImageButton_Hamburger_menu_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton_Home_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton_Customer_Click(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService();
            List<Customer> customers;

            // GetAllCustomers [pass]
            // customers = customerService.GetAllCustomer();
            //dataGridView.DataSource = customers;

            // InsertCustomer [pass]
            //Console.WriteLine(customerService.InsertCustomer(new Customer("10", "Nguyen Van F", "0398311222", "CaLi")));
            //customers = customerService.GetAllCustomer();
            //dataGridView.DataSource = customers;

            // UpdateCustomer [pass]
            //Console.WriteLine(customerService.UpdateCustomer(new Customer("10", "Nguyen Van Z", "0310101010", "CaLi")));
            //customers = customerService.GetAllCustomer();
            //dataGridView.DataSource = customers;

            // DeleteCustomer [pass]
            //Console.WriteLine(customerService.DeleteCustomer("10"));
            //customers = customerService.GetAllCustomer();
            //dataGridView.DataSource = customers;

            //GetCustomerByID [pass]
            //Console.WriteLine(customerService.GetCustomerById("4").NameCustomer);

            //GetCustomerByPhoneNumber [pass]
            //Console.WriteLine(customerService.GetIdCustomerByPhoneNumber("0398311223"));

            //SearchItem [pass]
            //customers = customerService.SearchCustomer("Ca Mau");
            //dataGridView.DataSource = customers;

            FormCustomer formCustomer = new FormCustomer();
            OpenFormChild(formCustomer);

        }
    }
}
