using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class ProfitManagement
    {
        public JsonNullable<decimal?> CommissionableGrossProfit { get; set; }
        public JsonNullable<decimal?> ExpenseAmount1 { get; set; }
        public JsonNullable<decimal?> ExpenseAmount2 { get; set; }
        public JsonNullable<decimal?> ExpenseAmount3 { get; set; }
        public JsonNullable<decimal?> ExpenseAmount4 { get; set; }
        public string ExpenseDescription1 { get; set; }
        public string ExpenseDescription2 { get; set; }
        public string ExpenseDescription3 { get; set; }
        public string ExpenseDescription4 { get; set; }
        public JsonNullable<decimal?> GrossCheckAmount { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> NetProfit { get; set; }
        public JsonNullable<List<ProfitManagementItem>> ProfitManagementItems { get; set; }
    }
}