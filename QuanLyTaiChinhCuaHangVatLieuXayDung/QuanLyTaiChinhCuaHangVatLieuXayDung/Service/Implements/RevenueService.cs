using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Service
{
    internal class RevenueService : IRevenueService
    {
        private MyDatabase myDatabase = new MyDatabase();
        public DataTable CalculateAnnualRevenue()
        {
            DataTable dtAnnualRevenue = new DataTable();
            string sqlQuery = "SELECT * FROM Fn_CalculateAnnualRevenue()";

            try
            {
                this.myDatabase.OpenConnection();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, this.myDatabase.GetConnection());
                adapter.Fill(dtAnnualRevenue);
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

            return dtAnnualRevenue;
        }

        public DataTable CalculateDailyRevenue(int month, int year)
        {
            DataTable dtDailyRevenue = new DataTable();
            string sqlQuery = "SELECT * FROM Fn_CalculateDailyRevenue(@Month, @Year)";

            try
            {
                this.myDatabase.OpenConnection();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, this.myDatabase.GetConnection());
                adapter.SelectCommand.Parameters.AddWithValue("@Month", month);
                adapter.SelectCommand.Parameters.AddWithValue("@Year", year);
                adapter.Fill(dtDailyRevenue);
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

            return dtDailyRevenue;
        }

        public DataTable CalculateMonthlyRevenue(int year)
        {
            DataTable dtMonthlyRevenue = new DataTable();
            string sqlQuery = "SELECT * FROM Fn_CalculateMonthlyRevenue(@Year)";
            try
            {
                this.myDatabase.OpenConnection();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, this.myDatabase.GetConnection());
                adapter.SelectCommand.Parameters.AddWithValue("@Year", year);
                adapter.Fill(dtMonthlyRevenue);
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

            return dtMonthlyRevenue;
        }
    }
}
