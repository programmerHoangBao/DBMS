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
        bool InsertProduct(Products product);
        bool UpdateProduct(Products product);
        bool DeleteProduct(string idProduct);
        List<Products> GetAllProduct();
        Products GetProductById(string idProduct);

        //Function tìm kiếm gần đúng sản phẩm bằng thông tin bất kì của sản phẩm trừ ImageProduct
        Products SearchProducts(string searchTerm);
    }
}
