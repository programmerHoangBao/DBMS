using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Model
{
    internal class MyDatabase
    {
        private SqlConnection connection;
        private string connectionString;

        public MyDatabase()
        {
            string filePath = GetCurrentFolderPath() + @"\Database\QuanLyTaiChinhCuaHangXayDung.mdf";
            this.connectionString = CreateConnectionString(filePath);
            this.connection = new SqlConnection(this.connectionString);
        }

        //Lấy đường dẫn đến database
        public static string GetCurrentFolderPath()
        {
            string filePath = Assembly.GetExecutingAssembly().Location;
            return Path.GetDirectoryName(filePath);
        }
        public static string CreateConnectionString(string filePath)
        {
            return $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @filePath + ";Integrated Security=True";
        }

        public void OpenConnection()
        {
            this.connection.Open();
        }

        public void CloseConnection()
        {
            this.connection.Close();
        }

        public SqlConnection GetConnection()
        {
            return this.connection;
        }
    }
}
