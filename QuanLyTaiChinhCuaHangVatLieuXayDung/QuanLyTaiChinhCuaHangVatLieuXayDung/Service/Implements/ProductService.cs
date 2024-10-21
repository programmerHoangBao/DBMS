using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using QuanLyTaiChinhCuaHangVatLieuXayDung.Service.Implements;
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
    internal class ProductService : IProductService
    {
        private MyDatabase myDatabase = new MyDatabase();
        ITypeProductService typeProductService = new TypeProductService();
        ISupplierService supplierService = new SupplierService();
        public ProductService()
        {

        }

        public bool DeleteProduct(string idProduct)
        {
            bool isDeleted = false;
            string sqlQuery = "SP_DeleteProduct";

            try
            {
                this.myDatabase.OpenConnection();

                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdProduct", idProduct);

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

        public List<Product> GetAllProduct()
        {
            List<Product> products = new List<Product>();
            string sqlQuery = "SELECT * FROM Fn_GetAllProduct()";

            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                Product product;

                while (reader.Read())
                {
                    product = new Product();
                    product.IdProduct = reader["IdProduct"].ToString();
                    product.NameProduct = reader["NameProduct"].ToString();
                    product.Unit = reader["Unit"].ToString();
                    product.UnitPriceImport = (decimal)reader["UnitPriceImport"];
                    product.UnitPriceExport = (decimal)reader["UnitPriceExport"];
                    product.QuantityProduct = (decimal)reader["QuantityProduct"];
                    product.TypeProduct = this.typeProductService.GetTypeProductById(reader["IdTypeProduct"].ToString());
                    product.Supplier = this.supplierService.GetSupplierById(reader["IdSupplier"].ToString());
                    product.ImageProduct = reader["ImageProduct"] as byte[];

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

        public Product GetProductById(string idProduct)
        {
            Product product = new Product();
            string sqlQuery = "SELECT * From Fn_GetProductById(@IdProduct)";
            try
            {
                this.myDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    product = new Product
                    {
                        IdProduct = reader["IdProduct"].ToString(),
                        NameProduct = reader["NameProduct"].ToString(),
                        Unit = reader["Unit"].ToString(),
                        UnitPriceImport = Convert.ToDecimal(reader["UnitPriceImport"]),
                        UnitPriceExport = Convert.ToDecimal(reader["UnitPriceExport"]),
                        QuantityProduct = Convert.ToInt32(reader["QuantityProduct"]),
                        TypeProduct = this.typeProductService.GetTypeProductById(reader["IdTypeProduct"].ToString()),
                        Supplier = this.supplierService.GetSupplierById(reader["IdSupplier"].ToString()),
                        ImageProduct = reader["ImageProduct"] as byte[] // assuming it's a binary data
                    };
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Notification",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }

        public bool InsertProduct(Product product)
        {
            bool isInserted = false;
            string sqlQuery = "SP_InsertProduct";

            try
            {
                this.myDatabase.OpenConnection();

                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdProduct", product.IdProduct);
                cmd.Parameters.AddWithValue("@NameProduct", product.NameProduct);
                cmd.Parameters.AddWithValue("@Unit", product.Unit);
                cmd.Parameters.AddWithValue("@UnitPriceImport", product.UnitPriceImport);
                cmd.Parameters.AddWithValue("@UnitPriceExport", product.UnitPriceExport);
                cmd.Parameters.AddWithValue("@QuantityProduct", product.QuantityProduct);
                cmd.Parameters.AddWithValue("@IdTypeProduct", product.TypeProduct.IdTypeProduct);
                cmd.Parameters.AddWithValue("@IdSupplier", product.Supplier.IdSupplier);
                cmd.Parameters.AddWithValue("@ImageProduct", product.ImageProduct);

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

        public bool UpdateProduct(Product product)
        {
            bool isUpdated = false;
            string sqlQuery = "SP_UpdateProduct";

            try
            {
                this.myDatabase.OpenConnection();

                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdProduct", product.IdProduct);
                cmd.Parameters.AddWithValue("@NameProduct", product.NameProduct);
                cmd.Parameters.AddWithValue("@Unit", product.Unit);
                cmd.Parameters.AddWithValue("@UnitPriceImport", product.UnitPriceImport);
                cmd.Parameters.AddWithValue("@UnitPriceExport", product.UnitPriceExport);
                cmd.Parameters.AddWithValue("@QuantityProduct", product.QuantityProduct);
                cmd.Parameters.AddWithValue("@IdTypeProduct", product.TypeProduct.IdTypeProduct);
                cmd.Parameters.AddWithValue("@IdSupplier", product.Supplier.IdSupplier);
                cmd.Parameters.AddWithValue("@ImageProduct", product.ImageProduct);

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

        public List<Product> SearchProducts(string searchTerm)
        {
            List<Product> products = new List<Product>();
            string sqlQuery = "SELECT * FROM Fn_SearchProducts(@SearchTerm)";

            try
            {
                this.myDatabase.OpenConnection();

                SqlCommand cmd = new SqlCommand(sqlQuery, this.myDatabase.GetConnection());
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@SearchTerm", searchTerm);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product
                    {
                        IdProduct = reader["IdProduct"].ToString(),
                        NameProduct = reader["NameProduct"].ToString(),
                        Unit = reader["Unit"].ToString(),
                        UnitPriceImport = Convert.ToDecimal(reader["UnitPriceImport"]),
                        UnitPriceExport = Convert.ToDecimal(reader["UnitPriceExport"]),
                        QuantityProduct = Convert.ToDecimal(reader["QuantityProduct"]),
                        TypeProduct = this.typeProductService.GetTypeProductById(reader["IdTypeProduct"].ToString()),
                        Supplier = this.supplierService.GetSupplierById(reader["IdSupplier"].ToString()),
                        ImageProduct = reader["ImageProduct"] as byte[] // assuming it's binary data
                    };

                    products.Add(product);
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

            return products;
        }
    }
}
