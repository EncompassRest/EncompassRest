using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ProfitManagement
    /// </summary>
    public sealed partial class ProfitManagement : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _commissionableGrossProfit;
        /// <summary>
        /// Profit Mgt Commissionable Gross Profit [PM10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Profit Mgt Commissionable Gross Profit")]
        public decimal? CommissionableGrossProfit { get => _commissionableGrossProfit; set => SetField(ref _commissionableGrossProfit, value); }
        private DirtyValue<decimal?> _expenseAmount1;
        /// <summary>
        /// Profit Mgt Expenses 1 Amt [PM03]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Profit Mgt Expenses 1 Amt")]
        public decimal? ExpenseAmount1 { get => _expenseAmount1; set => SetField(ref _expenseAmount1, value); }
        private DirtyValue<decimal?> _expenseAmount2;
        /// <summary>
        /// Profit Mgt Expenses 2 Amt [PM05]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Profit Mgt Expenses 2 Amt")]
        public decimal? ExpenseAmount2 { get => _expenseAmount2; set => SetField(ref _expenseAmount2, value); }
        private DirtyValue<decimal?> _expenseAmount3;
        /// <summary>
        /// Profit Mgt Expenses 3 Amt [PM07]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Profit Mgt Expenses 3 Amt")]
        public decimal? ExpenseAmount3 { get => _expenseAmount3; set => SetField(ref _expenseAmount3, value); }
        private DirtyValue<decimal?> _expenseAmount4;
        /// <summary>
        /// Profit Mgt Expenses 4 Amt [PM09]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Profit Mgt Expenses 4 Amt")]
        public decimal? ExpenseAmount4 { get => _expenseAmount4; set => SetField(ref _expenseAmount4, value); }
        private DirtyValue<string> _expenseDescription1;
        /// <summary>
        /// Profit Mgt Expenses 1 [PM02]
        /// </summary>
        [LoanFieldProperty(Description = "Profit Mgt Expenses 1")]
        public string ExpenseDescription1 { get => _expenseDescription1; set => SetField(ref _expenseDescription1, value); }
        private DirtyValue<string> _expenseDescription2;
        /// <summary>
        /// Profit Mgt Expenses 2 [PM04]
        /// </summary>
        [LoanFieldProperty(Description = "Profit Mgt Expenses 2")]
        public string ExpenseDescription2 { get => _expenseDescription2; set => SetField(ref _expenseDescription2, value); }
        private DirtyValue<string> _expenseDescription3;
        /// <summary>
        /// Profit Mgt Expenses 3 [PM06]
        /// </summary>
        [LoanFieldProperty(Description = "Profit Mgt Expenses 3")]
        public string ExpenseDescription3 { get => _expenseDescription3; set => SetField(ref _expenseDescription3, value); }
        private DirtyValue<string> _expenseDescription4;
        /// <summary>
        /// Profit Mgt Expenses 4 [PM08]
        /// </summary>
        [LoanFieldProperty(Description = "Profit Mgt Expenses 4")]
        public string ExpenseDescription4 { get => _expenseDescription4; set => SetField(ref _expenseDescription4, value); }
        private DirtyValue<decimal?> _grossCheckAmount;
        /// <summary>
        /// Profit Mgt Gross Check Amt [PM01]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Profit Mgt Gross Check Amt")]
        public decimal? GrossCheckAmount { get => _grossCheckAmount; set => SetField(ref _grossCheckAmount, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// ProfitManagement Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<decimal?> _netProfit;
        /// <summary>
        /// Profit Mgt Net Profit [PM28]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Profit Mgt Net Profit")]
        public decimal? NetProfit { get => _netProfit; set => SetField(ref _netProfit, value); }
        private DirtyList<ProfitManagementItem> _profitManagementItems;
        /// <summary>
        /// ProfitManagement ProfitManagementItems
        /// </summary>
        public IList<ProfitManagementItem> ProfitManagementItems { get => GetField(ref _profitManagementItems); set => SetField(ref _profitManagementItems, value); }
    }
}