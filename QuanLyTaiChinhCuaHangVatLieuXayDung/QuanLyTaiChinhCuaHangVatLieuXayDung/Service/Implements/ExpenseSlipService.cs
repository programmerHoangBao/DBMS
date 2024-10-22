using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Service.Implements
{
    internal class ExpenseSlipService : IExpenseSlipService
    {
        private MyDatabase myDatabase = new MyDatabase(); 
        public decimal CalculateTotalMoneyExpenseSlipReceive()
        {
            decimal totalMoney = 0;

            string sqlQuery = "SELECT dbo.Fn_CalculateTotalMoneyExpenseSlipReceive()";

            try
            {
                this.myDatabase.OpenConnection();

                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.Text;

                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    totalMoney = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                this.myDatabase.CloseConnection();
            }

            return totalMoney;
        }

        public decimal CalculateTotalMoneyExpenseSlipSpend()
        {
            decimal totalMoney = 0;

            string sqlQuery = "SELECT dbo.Fn_CalculateTotalMoneyExpenseSlipSpend()";

            try
            {
                this.myDatabase.OpenConnection();

                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.Text;

                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    totalMoney = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                this.myDatabase.CloseConnection();
            }

            return totalMoney;
        }

        public bool DeleteExpenseSlip(string idExpenseSlip)
        {
            bool isDeleted = false;
            string sqlQuery = "SP_DeleteExpenseSlip";

            try
            {
                this.myDatabase.OpenConnection();

                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdExpenseSlip", idExpenseSlip);

                SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                isDeleted = (int)resultParam.Value == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                this.myDatabase.CloseConnection();
            }

            return isDeleted;
        }

        public List<ExpenseSlip> GetAllExpenseSlip()
        {
            List<ExpenseSlip> expenseslips = new List<ExpenseSlip>();
            string sqlQuery = "SELECT * FROM Fn_GetAllExpenseSlip()";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                ExpenseSlip expenseSlip = new ExpenseSlip();

                while (reader.Read())
                {
                    expenseSlip = new ExpenseSlip();
                    expenseSlip.IdExpenseSlip = reader["IdExpenseSlip"].ToString();
                    expenseSlip.DateCreate = Convert.ToDateTime(reader["DateCreate"]);
                    expenseSlip.Content = reader["Content"].ToString();
                    expenseSlip.TypeExpenseSlip = reader["TypeExpenseSlip"].ToString();
                    expenseSlip.TotalMoney = (decimal)reader["TotalMoney"];

                    expenseslips.Add(expenseSlip);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Notification",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.myDatabase.CloseConnection();
            }

            return expenseslips;
        }

        public ExpenseSlip GetExpenseSlipByID(string idExpenseSlip)
        {
            ExpenseSlip expenseSlip = new ExpenseSlip();
            string sqlQuery = "SELECT * From Fn_GetExpenseSlipById (@IdExpenseSlip)";
            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    expenseSlip = new ExpenseSlip
                    {
                        IdExpenseSlip = reader["IdExpenseSlip"].ToString(),
                        DateCreate = Convert.ToDateTime(reader["DateCreate"]),
                        Content = reader["Content"].ToString(),
                        TypeExpenseSlip = reader["TypeExpenseSlip"].ToString(),
                        TotalMoney = Convert.ToDecimal(reader["TotalMoney"])
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Notification",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return expenseSlip;
        }

        public List<ExpenseSlip> GetExpenseSlipReceive()
        {
            List<ExpenseSlip> expenseSlips = new List<ExpenseSlip>();

            string sqlQuery = "SELECT * FROM Fn_GetExpenseSlipReceive()";

            try
            {
                this.myDatabase.OpenConnection();

                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ExpenseSlip expenseSlip = new ExpenseSlip
                    {
                        IdExpenseSlip = reader["IdExpenseSlip"].ToString(),
                        Content = reader["Content"].ToString(),
                        TypeExpenseSlip = reader["TypeExpenseSlip"].ToString(),
                        TotalMoney = Convert.ToDecimal(reader["TotalMoney"])
                    };

                        expenseSlips.Add(expenseSlip);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                this.myDatabase.CloseConnection();
            }

            return expenseSlips;
        }

        public List<ExpenseSlip> GetExpenseSlipSpend()
        {
            List<ExpenseSlip> expenseSlips = new List<ExpenseSlip>();

            string sqlQuery = "SELECT * FROM Fn_GetExpenseSlipSpend()";

            try
            {
                this.myDatabase.OpenConnection();

                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ExpenseSlip expenseSlip = new ExpenseSlip
                    {
                        IdExpenseSlip = reader["IdExpenseSlip"].ToString(),
                        Content = reader["Content"].ToString(),
                        TypeExpenseSlip = reader["TypeExpenseSlip"].ToString(),
                        TotalMoney = Convert.ToDecimal(reader["TotalMoney"])
                    };

                    expenseSlips.Add(expenseSlip);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                this.myDatabase.CloseConnection();
            }

            return expenseSlips;
        }

        public bool InsertExpenseSlip(ExpenseSlip expenseSlip)
        {
            bool isInserted = false;
            string sqlQuery = "SP_InsertExpenseSlip";

            try
            {
                this.myDatabase.OpenConnection();

                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdExpenseSlip", expenseSlip.IdExpenseSlip);
                cmd.Parameters.AddWithValue("@DateCreate", expenseSlip.DateCreate);
                cmd.Parameters.AddWithValue("@Content", expenseSlip.Content);
                cmd.Parameters.AddWithValue("@TypeExpenseSlip", expenseSlip.TypeExpenseSlip);
                cmd.Parameters.AddWithValue("@TotalMoney", expenseSlip.TotalMoney);

                SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                isInserted = (int)resultParam.Value == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.myDatabase.CloseConnection();
            }

            return isInserted;
        }

        public List<ExpenseSlip> SearchExpenseSlip(string searchTerm)
        {
            List<ExpenseSlip> expenseSlips = new List<ExpenseSlip>();
            string sqlQuery = "SELECT * FROM Fn_SearchExpenseSlip (@SearchTerm)";

            try
            {
                this.myDatabase.OpenConnection();

                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@SearchTerm", searchTerm);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ExpenseSlip expenseslip = new ExpenseSlip
                    {
                        IdExpenseSlip = reader["IdExpenseSlip"].ToString(),
                        DateCreate = Convert.ToDateTime(reader["DateCreate"]),
                        Content = reader["Content"].ToString(),
                        TypeExpenseSlip = reader["TypeExpenseSlip"].ToString(),
                        TotalMoney = Convert.ToDecimal(reader["TotalMoney"])
                    };

                    expenseSlips.Add(expenseslip);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.myDatabase.CloseConnection();
            }

            return expenseSlips;
        }

        public bool UpdateExpenseSlip(ExpenseSlip expenseSlip)
        {
            bool isUpdated = false;
            string sqlQuery = "SP_UpdateExpenseSlip";

            try
            {
                this.myDatabase.OpenConnection();

                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdExpenseSlip", expenseSlip.IdExpenseSlip);
                cmd.Parameters.AddWithValue("@DateCreate", expenseSlip.DateCreate);
                cmd.Parameters.AddWithValue("@Content", expenseSlip.Content);
                cmd.Parameters.AddWithValue("@TypeExpenseSlip", expenseSlip.TypeExpenseSlip);
                cmd.Parameters.AddWithValue("@TotalMoney", expenseSlip.TotalMoney);
                SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.Int);
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                isUpdated = (int)resultParam.Value == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.myDatabase.CloseConnection();
            }

            return isUpdated;
        }
    }
}
