using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Service
{
    internal interface IProductService
    {
        bool InsertProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(string idProduct);
        List<Product> GetAllProduct();
        Product GetProductById(string idProduct);

        //Function tìm kiếm gần đúng sản phẩm bằng thông tin bất kì của sản phẩm trừ ImageProduct
        List<Product> SearchProducts(string searchTerm);
    }
}
