using QuanLyTaiChinhCuaHangVatLieuXayDung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Service
{
    internal interface IExpenseSlipService
    {
        bool InsertExpenseSlip(ExpenseSlip expenseSlip);
        bool UpdateExpenseSlip(ExpenseSlip expenseSlip);
        bool DeleteExpenseSlip(string idExpenseSlip);
        List<ExpenseSlip> GetAllExpenseSlip();
        ExpenseSlip GetExpenseSlipByID(string idExpenseSlip);
        List<ExpenseSlip> GetExpenseSlipReceive();
        List<ExpenseSlip> GetExpenseSlipSpend();
        decimal CalculateTotalMoneyExpenseSlipReceive();
        decimal CalculateTotalMoneyExpenseSlipSpend();
        List<ExpenseSlip> SearchExpenseSlip(string searchTerm);
    }
}
