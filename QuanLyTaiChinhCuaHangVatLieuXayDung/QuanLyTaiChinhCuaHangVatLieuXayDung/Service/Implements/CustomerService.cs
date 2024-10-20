using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Service.Implements
{
    internal class CustomerService : ICustomerService
    {
        private MyDatabase myDatabase = new MyDatabase();
        public CustomerService() { }

        public bool DeleteCustomer(string idCustomer)
        {
            bool result = false;
            string sqlQuery = "SP_DeleteCustomer";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCustomer", idCustomer);

                SqlParameter outputParam = new SqlParameter("@Result", System.Data.SqlDbType.Int)
                {
                    Direction = System.Data.ParameterDirection.Output
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

        public List<Customer> GetAllCustomer()
        {
            List<Customer> customers = new List<Customer>();
            string sqlQuery = "SELECT * FROM Fn_GetAllCustomer()";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                Customer customer;

                while (reader.Read())
                {
                    customer = new Customer();
                    customer.IdCustomer = reader["IdCustomer"].ToString();
                    customer.NameCustomer = reader["NameCustomer"].ToString();
                    customer.PhoneNumber = reader["PhoneNumber"].ToString();
                    customer.AddressCustomer = reader["AddressCustomer"].ToString();

                    //Thêm customer vào list customers
                    customers.Add(customer);
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

            return customers;
        }

        public Customer GetCustomerById(string idCustomer)
        {
            Customer customer = new Customer();
            string sqlQuery = "SELECT * FROM Fn_GetCustomerById(@IdCustomer)";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("IdCustomer", idCustomer);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customer.IdCustomer = reader["IdCustomer"].ToString();
                    customer.NameCustomer = reader["NameCustomer"].ToString();
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

            return customer;
        }

        public string GetIdCustomerByPhoneNumber(string phoneNumber)
        {
            string idCustomer = "";
            string sqlQuery = "SELECT dbo.Fn_GetIdCustomerByPhoneNumber(@PhoneNumber)";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    idCustomer = result.ToString();
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

            return idCustomer;
        }

        public bool InsertCustomer(Customer customer)
        {
            bool result = false;
            string sqlQuery = "SP_InsertCustomer";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCustomer", customer.IdCustomer);
                cmd.Parameters.AddWithValue("@NameCustomer", customer.NameCustomer);
                cmd.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                cmd.Parameters.AddWithValue("@AddressCustomer", customer.AddressCustomer);


                SqlParameter outputParam = new SqlParameter("@Result", System.Data.SqlDbType.Int)
                {
                    Direction = System.Data.ParameterDirection.Output
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

        public List<Customer> SearchCustomer(string searchTerm)
        {
            List<Customer> customers = new List<Customer>();
            string sqlQuery = "SELECT * FROM Fn_SearchCustomer(@SearchTerm)";

            try
            {
                this.myDatabase.OpenConnection();

                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.Parameters.AddWithValue("@SearchTerm", searchTerm);
                SqlDataReader reader = cmd.ExecuteReader();
                Customer customer;
                while (reader.Read())
                {
                    customer = new Customer();
                    customer.IdCustomer = reader["IdCustomer"].ToString();
                    customer.NameCustomer = reader["NameCustomer"].ToString();
                    customer.PhoneNumber = reader["PhoneNumber"].ToString();
                    customer.AddressCustomer = reader["AddressCustomer"].ToString();

                    customers.Add(customer);
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

            return customers;
        }

        public bool UpdateCustomer(Customer customer)
        {
            bool result = false;
            string sqlQuery = "SP_UpdateCustomer";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCustomer", customer.IdCustomer);
                cmd.Parameters.AddWithValue("@NameCustomer", customer.NameCustomer);
                cmd.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                cmd.Parameters.AddWithValue("@AddressCustomer", customer.AddressCustomer);


                SqlParameter outputParam = new SqlParameter("@Result", System.Data.SqlDbType.Int)
                {
                    Direction = System.Data.ParameterDirection.Output
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
