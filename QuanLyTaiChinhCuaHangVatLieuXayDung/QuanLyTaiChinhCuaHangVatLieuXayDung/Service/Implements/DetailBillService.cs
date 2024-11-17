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
    internal class DetailBillService : IDetailBillService
    {

        private MyDatabase myDatabase = new MyDatabase();

        public bool DeleteDetailBillByIdBill(string idDetailBill)
        {
            bool result = false;
            string sqlQuery = "SP_DeleteDetailBillByIdBill";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdBill", idDetailBill);

                SqlParameter outputParam = new SqlParameter("@Result", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParam);

                cmd.ExecuteNonQuery();
                result = (int)outputParam.Value == 1;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("An error occurred: " + ex.Message);
                MessageBox.Show("An error occurred: " + ex.Message, "Notification",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.myDatabase.CloseConnection();
            }

            return result;
        }

        public bool DeleteDetailBillByIdBillAndIdProduct(string idDetailBill, string idProduct)
        {
            bool result = false;
            string sqlQuery = "SP_DeleteDetailBillByIdBillAndIdProduct";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdBill", idDetailBill);
                cmd.Parameters.AddWithValue("@IdProduct", idProduct);

                SqlParameter outputParam = new SqlParameter("@Result", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParam);

                cmd.ExecuteNonQuery();
                result = (int)outputParam.Value == 1;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("An error occurred: " + ex.Message);
                MessageBox.Show("An error occurred: " + ex.Message, "Notification",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.myDatabase.CloseConnection();
            }

            return result;
        }

        public bool InsertDetailBill(DetailBill detailBill)
        {
            bool result = false;
            string sqlQuery = "SP_InsertDetailBill";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdBill", detailBill.IdBill);
                cmd.Parameters.AddWithValue("@IdProduct", detailBill.IdProduct);
                cmd.Parameters.AddWithValue("@QuantityProduct", detailBill.QuantityProduct);

                SqlParameter outputParam = new SqlParameter("@Result", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParam);

                cmd.ExecuteNonQuery();
                result = (int)outputParam.Value == 1;
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

            return result;
        }

        public bool UpdateDetailBill(DetailBill detailBill)
        {
            bool result = false;
            string sqlQuery = "SP_UpdateDetailBill";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdBill", detailBill.IdBill);
                cmd.Parameters.AddWithValue("@IdProduct", detailBill.IdProduct);
                cmd.Parameters.AddWithValue("@QuantityProduct", detailBill.QuantityProduct);

                SqlParameter outputParam = new SqlParameter("@Result", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParam);

                cmd.ExecuteNonQuery();
                result = (int)outputParam.Value == 1;
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

            return result;
        }
    }
}
