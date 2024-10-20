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

        //Store Procedure thực hiện việc thêm dữ liệu vào bảng Products 
        bool InsertProduct(Product product);

        //Store Procedure thực hiện việc cập nhật dữ liệu vào bảng Products 
        bool UpdateProduct(Product product);

        //Store Procedure thực hiện việc xóa dữ liệu vào bảng Products 
        bool DeleteProduct(string idProduct);

        //Function thưc hiện việc lấy tất cả dữ liệu trong bảng Products
        List<Product> GetAllProduct();

        //Function thực hiện việc lất ra thông tin của Product bằng IdProduct
        Product GetProductById(string idProduct);

        //Function tìm kiếm gần đúng sản phẩm bằng thông tin bất kì của sản phẩm trừ ImageProduct
        List<Product> SearchProducts(string searchTerm);
    }
}
