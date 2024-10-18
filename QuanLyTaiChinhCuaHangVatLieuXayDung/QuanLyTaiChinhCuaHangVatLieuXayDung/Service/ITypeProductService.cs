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
        bool InsertTypeProduct(TypeProducts typeProduct);
        bool UpdateTypeProduct(TypeProducts typeProduct);
        bool DeleteTypeProduct(string idTypeProduct);
        List<TypeProducts> GetAllTypeProdcut();
        TypeProducts GetTypeProductById(string idTypeProduct);
    }
}
