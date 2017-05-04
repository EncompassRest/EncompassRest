
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class ProfitManagement
    {
        public decimal? grossCheckAmount { get; set; }
        public string expenseDescription1 { get; set; }
        public decimal? expenseAmount1 { get; set; }
        public string expenseDescription2 { get; set; }
        public decimal? expenseAmount2 { get; set; }
        public string expenseDescription3 { get; set; }
        public decimal? expenseAmount3 { get; set; }
        public string expenseDescription4 { get; set; }
        public decimal? expenseAmount4 { get; set; }
        public decimal? commissionableGrossProfit { get; set; }
        public List<ProfitManagementItem> profitManagementItems { get; set; }
        public decimal? netProfit { get; set; }
        public string id { get; set; }

    }
}