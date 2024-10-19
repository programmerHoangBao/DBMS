using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Service;
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
        public Home()
        {
            InitializeComponent();
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
            MyDatabase myDatabase = new MyDatabase();
            try
            {
                myDatabase.GetConnection().Open();
                MessageBox.Show("Database connection successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Database connection failed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void uiPanel_Body_Click(object sender, EventArgs e)
        {

        }
    }
}
