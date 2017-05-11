using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class ProfitManagement
    {
        public decimal? GrossCheckAmount { get; set; }
        public string ExpenseDescription1 { get; set; }
        public decimal? ExpenseAmount1 { get; set; }
        public string ExpenseDescription2 { get; set; }
        public decimal? ExpenseAmount2 { get; set; }
        public string ExpenseDescription3 { get; set; }
        public decimal? ExpenseAmount3 { get; set; }
        public string ExpenseDescription4 { get; set; }
        public decimal? ExpenseAmount4 { get; set; }
        public decimal? CommissionableGrossProfit { get; set; }
        public List<ProfitManagementItem> ProfitManagementItems { get; set; }
        public decimal? NetProfit { get; set; }
        public string Id { get; set; }
    }
}