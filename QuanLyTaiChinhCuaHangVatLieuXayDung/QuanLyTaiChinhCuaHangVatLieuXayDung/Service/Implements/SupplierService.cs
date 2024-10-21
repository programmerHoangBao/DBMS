using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Service.Implements
{
    internal class SupplierService : ISupplierService
    {
        private MyDatabase myDatabase = new MyDatabase();

        public SupplierService()
        {
        }

        public bool DeleteSupplier(string idSupplier)
        {
            bool result = false;
            string sqlQuery = "SP_DeleteSupplier";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdSupplier", idSupplier);

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


        public string GetIdSupplierByPhoneNumber(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> GetAllSupplier()
        {
            List<Supplier> suppliers = new List<Supplier>();
            string sqlQuery = "SELECT * FROM Fn_GetAllSupplier()";

            try
            {
                this.myDatabase.OpenConnection();

                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                Supplier supplier;
                while (reader.Read())
                {
                    supplier = new Supplier();
                    supplier.IdSupplier = reader["IdSupplier"].ToString();
                    supplier.NameSupplier = reader["NameSupplier"].ToString();
                    supplier.PhoneSupplier = reader["PhoneNumber"].ToString();
                    supplier.AddressSupplier = reader["AddressSupplier"].ToString();

                    suppliers.Add(supplier);
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

            return suppliers;
        }

        public Supplier GetSupplierById(string idSupplier)
        {
            Supplier supplier = new Supplier();
            string sqlQuery = "SELECT * FROM Fn_GetSupplierById(@IdSupplier)";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdSupplier", idSupplier);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    supplier.IdSupplier = reader["IdSupplier"].ToString();
                    supplier.NameSupplier = reader["NameSupplier"].ToString();
                    supplier.PhoneSupplier = reader["PhoneNumber"].ToString();
                    supplier.AddressSupplier = reader["AddressSupplier"].ToString();
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

            return supplier;
        }

        public bool InsertSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public Supplier SearchSupplier(string searchTerm)
        {
            throw new NotImplementedException();
        }
    }
}
