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
        bool InsertTypeProduct(TypeProduct typeProduct);
        bool UpdateTypeProduct(TypeProduct typeProduct);
        bool DeleteTypeProduct(string idTypeProduct);
        List<TypeProduct> GetAllTypeProdcut();
        TypeProduct GetTypeProductById(string idTypeProduct);
    }
}
