using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiChinhCuaHangVatLieuXayDung.Model
{
    internal class ExpenseSlip
    {
        private string idExpenseSlip;
        private DateTime dateCreate;
        private string content;
        private string typeExpenseSlip;
        private decimal totalMoney;

        public ExpenseSlip()
        {

        }

        public string IdExpenseSlip { get => idExpenseSlip; set => idExpenseSlip = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
        public string Content { get => content; set => content = value; }
        public string TypeExpenseSlip { get => typeExpenseSlip; set => typeExpenseSlip = value; }
        public decimal TotalMoney { get => totalMoney; set => totalMoney = value; }
    }
}
