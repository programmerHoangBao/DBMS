using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Service.Implements
{
    internal class AccountService : IAccountService
    {
        private MyDatabase myDatabase = new MyDatabase();

        public AccountService()
        {
        }

        public bool DeleteAccount(string idAccount)
        {
            bool result = false;
            string sqlQuery = "SP_DeleteAccount";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdAccount", idAccount);

                SqlParameter outputParam = new SqlParameter("@Result", System.Data.SqlDbType.Int)
                {
                    Direction = System.Data.ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParam);

                cmd.ExecuteNonQuery();
                result = (int)outputParam.Value == 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.myDatabase.CloseConnection();
            }

            return result;
        }

        public Account GetAccountById(string idAccount)
        {
            Account account = new Account();
            string sqlQuery = "SELECT * FROM dbo.Fn_GetAccountById(@IdAccount)";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdAccount", idAccount);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    account.IdAccount = reader.GetString("IdAccount");
                    account.Username = reader.GetString("Username");
                    account.Password = reader.GetString("PasswordUser");
                    account.Email = reader.GetString("Email");
                    account.Role = reader.GetString("RoleUser");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.myDatabase.CloseConnection();
            }

            return account;
        }

        public Account GetAccountByUsername(string username)
        {
            Account account = new Account();
            string sqlQuery = "SELECT * FROM dbo.Fn_GetAccountByUsername(@Username)";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Username", username);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    account.IdAccount = reader.GetString("IdAccount");
                    account.Username = reader.GetString("Username");
                    account.Password = reader.GetString("PasswordUser");
                    account.Email = reader.GetString("Email");
                    account.Role = reader.GetString("RoleUser");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.myDatabase.CloseConnection();
            }

            return account;
        }

        public List<Account> GetAllAccounts()
        {
            List<Account> accounts = new List<Account>();
            string sqlQuery = "SELECT * FROM dbo.Fn_GetAllAccount()";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();

                Account account;
                while (reader.Read())
                {
                    account = new Account();
                    account.IdAccount = reader.GetString("IdAccount");
                    account.Username = reader.GetString("Username");
                    account.Password = reader.GetString("PasswordUser");
                    account.Email = reader.GetString("Email");
                    account.Role = reader.GetString("RoleUser");

                    accounts.Add(account);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.myDatabase.CloseConnection();
            }

            return accounts;
        }

        public bool InsertAccount(Account account)
        {
            bool result = false;
            string sqlQuery = "SP_InsertAccount";

            try
            {
                this.myDatabase.OpenConnection();

                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdAccount", account.IdAccount);
                cmd.Parameters.AddWithValue("@Username", account.Username);
                cmd.Parameters.AddWithValue("@PasswordUser", account.Password);
                cmd.Parameters.AddWithValue("@Email", account.Email);
                cmd.Parameters.AddWithValue("@RoleUser", account.Role);

                SqlParameter outputParam = new SqlParameter("@Result", System.Data.SqlDbType.Int)
                {
                    Direction = System.Data.ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParam);
                cmd.ExecuteNonQuery();

                result = ((int)outputParam.Value == 1);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Notification",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.myDatabase.CloseConnection();
            }

            return result;
        }

        public bool Login(string username, string password)
        {
            bool result = false;
            string sqlQuery = "SELECT dbo.Fn_LoginAccount(@Username, @Password) AS 'Result'";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = (reader.GetInt32("Result") > 0);
                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.myDatabase.CloseConnection();
            }

            return result;
        
        }

        public bool UpdateAccount(Account account)
        {
            bool result = false;
            string sqlQuery = "SP_UpadateAccount";

            try
            {
                this.myDatabase.OpenConnection();

                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdAccount", account.IdAccount);
                cmd.Parameters.AddWithValue("@Username", account.Username);
                cmd.Parameters.AddWithValue("@PasswordUser", account.Password);
                cmd.Parameters.AddWithValue("@Email", account.Email);
                cmd.Parameters.AddWithValue("@RoleUser", account.Role);

                SqlParameter outputParam = new SqlParameter("@Result", System.Data.SqlDbType.Int)
                {
                    Direction = System.Data.ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParam);
                cmd.ExecuteNonQuery();

                result = ((int)outputParam.Value == 1);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Notification",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.myDatabase.CloseConnection();
            }

            return result;
        }
    }
}
