using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Service.Implements
{
    internal class BillService : IBillService
    {
        private MyDatabase myDatabase = new MyDatabase();

        public bool CheckExistBillInD(string idBill)
        {
            bool result = false;
            string sqlQuery = "Fn_CheckExistBillInDetaBill(@IdBill)";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdBill", idBill);

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

        public bool DeleteBill(string idBill)
        {
            bool result = false;
            string sqlQuery = "SP_DeleteBill";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdBill", idBill);

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

        public List<Bill> GetAllExportBill()
        {
            List<Bill> bills = new List<Bill>();
            string sqlQuery = "SELECT * FROM Fn_GetAllExportBill()";
            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                Bill bill;

                while (reader.Read())
                {
                    bill = new Bill();
                    bill.IdBill = reader["IdBill"].ToString();
                    bill.IdCustomer = reader["IdCustomer"].ToString();
                    bill.DateCreate = (DateTime)reader["DateCreate"];
                    bill.TypeBill = reader["TypeBill"].ToString();
                    bill.Total = (decimal)reader["Total"];

                    //Thêm bill vào list bills
                    bills.Add(bill);
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

            return bills;
        }

        public List<Bill> GetAllImportBill()
        {
            List<Bill> bills = new List<Bill>();
            string sqlQuery = "SELECT * FROM Fn_GetAllImportBill()";
            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                Bill bill;

                while (reader.Read())
                {
                    bill = new Bill();
                    bill.IdBill = reader["IdBill"].ToString();
                    bill.IdSupplier = reader["IdSupplier"].ToString();
                    bill.DateCreate = (DateTime)reader["DateCreate"];
                    bill.TypeBill = reader["TypeBill"].ToString();
                    bill.Total = (decimal)reader["Total"];

                    //Thêm bill vào list bills
                    bills.Add(bill);
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

            return bills;
        }

        public List<Product> GetListProductExportBill(string idBill)
        {
            List<Product> products = new List<Product>();
            string sqlQuery = "SELECT * FROM Fn_GetListProductExportBill(@IdBill)";
            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdBill", idBill);
                SqlDataReader reader = cmd.ExecuteReader();
                Product product;

                while (reader.Read())
                {
                    product = new Product();
                    product.IdProduct = reader["IdProduct"].ToString();
                    product.NameProduct = reader["NameProduct"].ToString();
                    product.Unit = reader["Unit"].ToString();
                    product.UnitPriceExport = (Decimal)reader["UnitPriceExport"];
                    product.QuantityProduct = (Decimal)reader["QuantityProduct"];
                    product.ImageProduct = reader["ImageProduct"] as byte[];

                    //Thêm bill vào list bills
                    products.Add(product);
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

            return products;
        }

        public List<Product> GetListProductImportBill(string idBill)
        {
            List<Product> products = new List<Product>();
            string sqlQuery = "SELECT * FROM Fn_GetListProductImportBill(@IdBill)";
            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdBill", idBill);
                SqlDataReader reader = cmd.ExecuteReader();
                Product product;

                while (reader.Read())
                {
                    product = new Product();
                    product.IdProduct = reader["IdProduct"].ToString();
                    product.NameProduct = reader["NameProduct"].ToString();
                    product.Unit = reader["Unit"].ToString();
                    product.UnitPriceImport = (Decimal)reader["UnitPriceImport"];
                    product.QuantityProduct = (Decimal)reader["QuantityProduct"];
                    product.ImageProduct = reader["ImageProduct"] as byte[];

                    //Thêm bill vào list bills
                    products.Add(product);
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

            return products;
        }

        public bool InsertExportBill(Bill bill)
        {
            bool result = false;
            string sqlQuery = "SP_InsertExportBill";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdBill", bill.IdBill);
                cmd.Parameters.AddWithValue("@IdCustomer", bill.IdCustomer);
                cmd.Parameters.AddWithValue("@DateCreate", bill.DateCreate);
                cmd.Parameters.AddWithValue("@TypeBill", bill.TypeBill);

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

        public bool InsertImportBill(Bill bill)
        {
            bool result = false;
            string sqlQuery = "SP_InsertImportBill";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdBill", bill.IdBill);
                cmd.Parameters.AddWithValue("@IdSupplier", bill.IdCustomer);
                cmd.Parameters.AddWithValue("@DateCreate", bill.DateCreate);
                cmd.Parameters.AddWithValue("@TypeBill", bill.TypeBill);

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

        public List<Bill> SearchExportBill(string searchTerm)
        {
            List<Bill> bills = new List<Bill>();
            string sqlQuery = "SELECT * FROM Fn_SearchExportBill(@SearchTerm)";

            try
            {
                this.myDatabase.OpenConnection();

                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.Parameters.AddWithValue("@SearchTerm", searchTerm);
                SqlDataReader reader = cmd.ExecuteReader();
                Bill bill;

                while (reader.Read())
                {
                    bill = new Bill();
                    bill.IdBill = reader["IdBill"].ToString();
                    bill.IdCustomer = reader["IdCustomer"].ToString();
                    bill.DateCreate = (DateTime)reader["DateCreate"];
                    bill.TypeBill = reader["TypeBill"].ToString();
                    bill.Total = (decimal)reader["Total"];

                    //Thêm bill vào list bills
                    bills.Add(bill);
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

            return bills;
        }

        public List<Bill> SearchImportBill(string searchTerm)
        {
            List<Bill> bills = new List<Bill>();
            string sqlQuery = "SELECT * FROM Fn_SearchImportBill(@SearchTerm)";

            try
            {
                this.myDatabase.OpenConnection();

                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.Parameters.AddWithValue("@SearchTerm", searchTerm);
                SqlDataReader reader = cmd.ExecuteReader();
                Bill bill;

                while (reader.Read())
                {
                    bill = new Bill();
                    bill.IdBill = reader["IdBill"].ToString();
                    bill.IdCustomer = reader["IdCustomer"].ToString();
                    bill.DateCreate = (DateTime)reader["DateCreate"];
                    bill.TypeBill = reader["TypeBill"].ToString();
                    bill.Total = (decimal)reader["Total"];

                    //Thêm bill vào list bills
                    bills.Add(bill);
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

            return bills;
        }

        public decimal TotalExportBillById(string idBill)
        {
            throw new NotImplementedException();
        }

        public decimal TotalImportBillById(string idBill)
        {
            throw new NotImplementedException();
        }

        public bool UpdateBill(Bill bill)
        {
            bool result = false;
            string sqlQuery = "SP_UpdateBill";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdBill", bill.IdBill);
                cmd.Parameters.AddWithValue("@IdCustomer", bill.IdCustomer);
                cmd.Parameters.AddWithValue("@IdSupplier", bill.IdSupplier);
                cmd.Parameters.AddWithValue("@DateCreate", bill.DateCreate);
                cmd.Parameters.AddWithValue("@TypeBill", bill.TypeBill);
                cmd.Parameters.AddWithValue("@Total", bill.Total);


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
