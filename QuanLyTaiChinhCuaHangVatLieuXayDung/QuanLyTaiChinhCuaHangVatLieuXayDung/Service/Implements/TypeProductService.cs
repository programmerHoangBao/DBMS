using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Service.Implements
{
    internal class TypeProductService : ITypeProductService
    {
        private MyDatabase myDatabase = new MyDatabase();

        public TypeProductService() { }

        public bool DeleteTypeProduct(string idTypeProduct)
        {
            bool result = false;
            string sqlQuery = "SP_DeleteTypeProduct";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTypeProduct", idTypeProduct);

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

        public List<TypeProduct> GetAllTypeProdcut()
        {
            List<TypeProduct> typeProducts = new List<TypeProduct>();
            string sqlQuery = "SELECT * FROM Fn_GetAllTypeProduct()";

            try
            {
                this.myDatabase.OpenConnection();

                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                TypeProduct typeProduct;
                while (reader.Read())
                {
                    typeProduct = new TypeProduct();
                    typeProduct.IdTypeProduct = reader["IdTypeProduct"].ToString();
                    typeProduct.NameTypeProduct = reader["NameTypeProduct"].ToString();

                    typeProducts.Add(typeProduct);
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

            return typeProducts;
        }

        public TypeProduct GetTypeProductById(string idTypeProduct)
        {
            TypeProduct typeProduct = new TypeProduct();
            string sqlQuery = "SELECT * FROM Fn_GetTypeProductById(@IdTypeProduct)";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdTypeProduct", idTypeProduct);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    typeProduct.IdTypeProduct = reader["IdTypeProduct"].ToString();
                    typeProduct.NameTypeProduct = reader["NameTypeProduct"].ToString();
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

            return typeProduct;
        }

        public bool InsertTypeProduct(TypeProduct typeProduct)
        {
            bool result = false;
            string sqlQuery = "SP_InsertTypeProduct";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTypeProduct", typeProduct.IdTypeProduct);
                cmd.Parameters.AddWithValue("@NameTypeProduct", typeProduct.NameTypeProduct);

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

        public bool UpdateTypeProduct(TypeProduct typeProduct)
        {
            bool result = false;
            string sqlQuery = "SP_UpdateTypeProduct";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTypeProduct", typeProduct.IdTypeProduct);
                cmd.Parameters.AddWithValue("@NameTypeProduct", typeProduct.NameTypeProduct);

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