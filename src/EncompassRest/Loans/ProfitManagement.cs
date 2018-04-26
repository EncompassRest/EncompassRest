using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ProfitManagement
    /// </summary>
    public sealed partial class ProfitManagement : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _commissionableGrossProfit;
        /// <summary>
        /// Profit Mgt Commissionable Gross Profit [PM10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Profit Mgt Commissionable Gross Profit")]
        public decimal? CommissionableGrossProfit { get => _commissionableGrossProfit; set => _commissionableGrossProfit = value; }
        private DirtyValue<decimal?> _expenseAmount1;
        /// <summary>
        /// Profit Mgt Expenses 1 Amt [PM03]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Profit Mgt Expenses 1 Amt")]
        public decimal? ExpenseAmount1 { get => _expenseAmount1; set => _expenseAmount1 = value; }
        private DirtyValue<decimal?> _expenseAmount2;
        /// <summary>
        /// Profit Mgt Expenses 2 Amt [PM05]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Profit Mgt Expenses 2 Amt")]
        public decimal? ExpenseAmount2 { get => _expenseAmount2; set => _expenseAmount2 = value; }
        private DirtyValue<decimal?> _expenseAmount3;
        /// <summary>
        /// Profit Mgt Expenses 3 Amt [PM07]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Profit Mgt Expenses 3 Amt")]
        public decimal? ExpenseAmount3 { get => _expenseAmount3; set => _expenseAmount3 = value; }
        private DirtyValue<decimal?> _expenseAmount4;
        /// <summary>
        /// Profit Mgt Expenses 4 Amt [PM09]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Profit Mgt Expenses 4 Amt")]
        public decimal? ExpenseAmount4 { get => _expenseAmount4; set => _expenseAmount4 = value; }
        private DirtyValue<string> _expenseDescription1;
        /// <summary>
        /// Profit Mgt Expenses 1 [PM02]
        /// </summary>
        [LoanFieldProperty(Description = "Profit Mgt Expenses 1")]
        public string ExpenseDescription1 { get => _expenseDescription1; set => _expenseDescription1 = value; }
        private DirtyValue<string> _expenseDescription2;
        /// <summary>
        /// Profit Mgt Expenses 2 [PM04]
        /// </summary>
        [LoanFieldProperty(Description = "Profit Mgt Expenses 2")]
        public string ExpenseDescription2 { get => _expenseDescription2; set => _expenseDescription2 = value; }
        private DirtyValue<string> _expenseDescription3;
        /// <summary>
        /// Profit Mgt Expenses 3 [PM06]
        /// </summary>
        [LoanFieldProperty(Description = "Profit Mgt Expenses 3")]
        public string ExpenseDescription3 { get => _expenseDescription3; set => _expenseDescription3 = value; }
        private DirtyValue<string> _expenseDescription4;
        /// <summary>
        /// Profit Mgt Expenses 4 [PM08]
        /// </summary>
        [LoanFieldProperty(Description = "Profit Mgt Expenses 4")]
        public string ExpenseDescription4 { get => _expenseDescription4; set => _expenseDescription4 = value; }
        private DirtyValue<decimal?> _grossCheckAmount;
        /// <summary>
        /// Profit Mgt Gross Check Amt [PM01]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Profit Mgt Gross Check Amt")]
        public decimal? GrossCheckAmount { get => _grossCheckAmount; set => _grossCheckAmount = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// ProfitManagement Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _netProfit;
        /// <summary>
        /// Profit Mgt Net Profit [PM28]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Profit Mgt Net Profit")]
        public decimal? NetProfit { get => _netProfit; set => _netProfit = value; }
        private DirtyList<ProfitManagementItem> _profitManagementItems;
        /// <summary>
        /// ProfitManagement ProfitManagementItems
        /// </summary>
        public IList<ProfitManagementItem> ProfitManagementItems { get => _profitManagementItems ?? (_profitManagementItems = new DirtyList<ProfitManagementItem>()); set => _profitManagementItems = new DirtyList<ProfitManagementItem>(value); }
        internal override bool DirtyInternal
        {
            get => _commissionableGrossProfit.Dirty
                || _expenseAmount1.Dirty
                || _expenseAmount2.Dirty
                || _expenseAmount3.Dirty
                || _expenseAmount4.Dirty
                || _expenseDescription1.Dirty
                || _expenseDescription2.Dirty
                || _expenseDescription3.Dirty
                || _expenseDescription4.Dirty
                || _grossCheckAmount.Dirty
                || _id.Dirty
                || _netProfit.Dirty
                || _profitManagementItems?.Dirty == true;
            set
            {
                _commissionableGrossProfit.Dirty = value;
                _expenseAmount1.Dirty = value;
                _expenseAmount2.Dirty = value;
                _expenseAmount3.Dirty = value;
                _expenseAmount4.Dirty = value;
                _expenseDescription1.Dirty = value;
                _expenseDescription2.Dirty = value;
                _expenseDescription3.Dirty = value;
                _expenseDescription4.Dirty = value;
                _grossCheckAmount.Dirty = value;
                _id.Dirty = value;
                _netProfit.Dirty = value;
                if (_profitManagementItems != null) _profitManagementItems.Dirty = value;
            }
        }
    }
}