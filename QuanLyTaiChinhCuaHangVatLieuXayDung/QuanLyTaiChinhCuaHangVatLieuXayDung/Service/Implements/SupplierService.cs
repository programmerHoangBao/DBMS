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

        public List<Suppliers> GetAllSupplier()
        {
            throw new NotImplementedException();
        }

        public Suppliers GetSupplierById(string idSupplier)
        {
            Suppliers supplier = new Suppliers();
            string sqlQuery = "SELECT * FROM Fn_GetSupplierById(@IdSupplier)";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = System.Data.CommandType.Text;
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

        public bool InsertSupplier(Suppliers supplier)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSupplier(Suppliers supplier)
        {
            throw new NotImplementedException();
        }

        Suppliers SearchSupplier(string searchTerm)
        {
            throw new NotImplementedException();
        }
    }
}
