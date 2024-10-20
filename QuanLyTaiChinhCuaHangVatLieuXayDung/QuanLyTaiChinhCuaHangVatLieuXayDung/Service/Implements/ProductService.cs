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
            throw new NotImplementedException();
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

                    //Thêm product vào list products
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
            throw new NotImplementedException();
        }

        public bool InsertProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
