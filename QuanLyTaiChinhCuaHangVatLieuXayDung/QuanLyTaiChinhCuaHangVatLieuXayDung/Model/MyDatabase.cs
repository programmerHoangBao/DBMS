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
            string content = File.ReadAllText(filePath).Trim();
            string serverName = "(LocalDB)\\MSSQLLocalDB";
            string databaseName = @"QuanLyTaiChinhCuaHangXayDung"; 
            string userName = ""; 
            string password = "";
            if (content.Equals("Manager"))
            {
                userName = "ManagerLogin";
                password = "123";
                this.connectionString = ConnectionSqlAuthentication(serverName, databaseName, userName, password);
            }
            else if (content.Equals("Employee"))
            {
                userName = "EmployeeLogin";
                password = "123";
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
        private string CreateConnectionString(string filePath)
        {
            return $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @filePath + ";Integrated Security=True";
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