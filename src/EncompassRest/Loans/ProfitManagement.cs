using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ProfitManagement : IClean
    {
        private Value<decimal?> _commissionableGrossProfit;
        public decimal? CommissionableGrossProfit { get { return _commissionableGrossProfit; } set { _commissionableGrossProfit = value; } }
        private Value<decimal?> _expenseAmount1;
        public decimal? ExpenseAmount1 { get { return _expenseAmount1; } set { _expenseAmount1 = value; } }
        private Value<decimal?> _expenseAmount2;
        public decimal? ExpenseAmount2 { get { return _expenseAmount2; } set { _expenseAmount2 = value; } }
        private Value<decimal?> _expenseAmount3;
        public decimal? ExpenseAmount3 { get { return _expenseAmount3; } set { _expenseAmount3 = value; } }
        private Value<decimal?> _expenseAmount4;
        public decimal? ExpenseAmount4 { get { return _expenseAmount4; } set { _expenseAmount4 = value; } }
        private Value<string> _expenseDescription1;
        public string ExpenseDescription1 { get { return _expenseDescription1; } set { _expenseDescription1 = value; } }
        private Value<string> _expenseDescription2;
        public string ExpenseDescription2 { get { return _expenseDescription2; } set { _expenseDescription2 = value; } }
        private Value<string> _expenseDescription3;
        public string ExpenseDescription3 { get { return _expenseDescription3; } set { _expenseDescription3 = value; } }
        private Value<string> _expenseDescription4;
        public string ExpenseDescription4 { get { return _expenseDescription4; } set { _expenseDescription4 = value; } }
        private Value<decimal?> _grossCheckAmount;
        public decimal? GrossCheckAmount { get { return _grossCheckAmount; } set { _grossCheckAmount = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _netProfit;
        public decimal? NetProfit { get { return _netProfit; } set { _netProfit = value; } }
        private Value<List<ProfitManagementItem>> _profitManagementItems;
        public List<ProfitManagementItem> ProfitManagementItems { get { return _profitManagementItems; } set { _profitManagementItems = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _commissionableGrossProfit.Clean
                    && _expenseAmount1.Clean
                    && _expenseAmount2.Clean
                    && _expenseAmount3.Clean
                    && _expenseAmount4.Clean
                    && _expenseDescription1.Clean
                    && _expenseDescription2.Clean
                    && _expenseDescription3.Clean
                    && _expenseDescription4.Clean
                    && _grossCheckAmount.Clean
                    && _id.Clean
                    && _netProfit.Clean
                    && _profitManagementItems.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _commissionableGrossProfit; v0.Clean = value; _commissionableGrossProfit = v0;
                var v1 = _expenseAmount1; v1.Clean = value; _expenseAmount1 = v1;
                var v2 = _expenseAmount2; v2.Clean = value; _expenseAmount2 = v2;
                var v3 = _expenseAmount3; v3.Clean = value; _expenseAmount3 = v3;
                var v4 = _expenseAmount4; v4.Clean = value; _expenseAmount4 = v4;
                var v5 = _expenseDescription1; v5.Clean = value; _expenseDescription1 = v5;
                var v6 = _expenseDescription2; v6.Clean = value; _expenseDescription2 = v6;
                var v7 = _expenseDescription3; v7.Clean = value; _expenseDescription3 = v7;
                var v8 = _expenseDescription4; v8.Clean = value; _expenseDescription4 = v8;
                var v9 = _grossCheckAmount; v9.Clean = value; _grossCheckAmount = v9;
                var v10 = _id; v10.Clean = value; _id = v10;
                var v11 = _netProfit; v11.Clean = value; _netProfit = v11;
                var v12 = _profitManagementItems; v12.Clean = value; _profitManagementItems = v12;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}