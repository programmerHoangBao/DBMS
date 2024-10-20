using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Service
{
    internal interface ITypeProductService
    {

        //Store Procedure thực hiện việc thêm dữ liệu vào TypeProducts
        bool InsertTypeProduct(TypeProduct typeProduct);

        //Store Procedure thực hiện việc cập nhật liệu vào TypeProducts
        bool UpdateTypeProduct(TypeProduct typeProduct);

        //Store Procedure thực hiện việc xóa dữ liệu vào TypeProducts
        bool DeleteTypeProduct(string idTypeProduct);

        //Function thực hiện việt lất ra tất cả các TypeProduct
        List<TypeProduct> GetAllTypeProdcut();

        //Function Lấy ra thông tin TypeProduct khi biết IdTypeProduct
        TypeProduct GetTypeProductById(string idTypeProduct);
    }
}
