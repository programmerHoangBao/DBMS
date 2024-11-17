using Sunny.UI.Win32;
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
            string filePath = GetCurrentFolderPath() + @"\Database\role.txt";
            string[] lines = ReadFile(filePath);
            string serverName = "(LocalDB)\\MSSQLLocalDB";
            string databaseName = @"QuanLyTaiChinhCuaHangXayDung"; 
            string userName = "";
            string password = "";
            if (lines.Length > 1)
            {
                userName = lines[0];
                password = lines[1];
            }
            if (!String.IsNullOrEmpty(userName) && !String.IsNullOrEmpty(password))
            {
                this.connectionString = ConnectionSqlAuthentication(serverName, databaseName, userName, password);
            }
            else
            {
                this.connectionString = ConnectionWindowAuthentication(serverName, databaseName);
            }
            this.connection = new SqlConnection(this.connectionString);
        }

        //Lấy đường dẫn đến database
        private string GetCurrentFolderPath()
        {
            string filePath = Assembly.GetExecutingAssembly().Location;
            return Path.GetDirectoryName(filePath);
        }

        //Tạo đường dẫn  SQL Authentication
        private string ConnectionSqlAuthentication(string server, string database, string user, string pass)
        {
            return $"Server={server};Database={database};User Id={user};Password={pass};";
        }

        private String ConnectionWindowAuthentication(string server, string database)
        {
            return $"Server={server};Database={database};Integrated Security=True;";
        }
        private string[] ReadFile(string filePath)
        {
            string[] lines = new string[0];
            if (File.Exists(filePath))
            {
                lines = File.ReadAllLines(filePath);
            }
            return lines;
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