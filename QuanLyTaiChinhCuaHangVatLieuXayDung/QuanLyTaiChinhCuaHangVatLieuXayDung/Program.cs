using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.HomeViews;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Forms.LoginViews;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Login());
        }
    }
}
