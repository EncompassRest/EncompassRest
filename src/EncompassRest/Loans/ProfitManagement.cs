using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
                var commissionableGrossProfit = _commissionableGrossProfit; commissionableGrossProfit.Clean = value; _commissionableGrossProfit = commissionableGrossProfit;
                var expenseAmount1 = _expenseAmount1; expenseAmount1.Clean = value; _expenseAmount1 = expenseAmount1;
                var expenseAmount2 = _expenseAmount2; expenseAmount2.Clean = value; _expenseAmount2 = expenseAmount2;
                var expenseAmount3 = _expenseAmount3; expenseAmount3.Clean = value; _expenseAmount3 = expenseAmount3;
                var expenseAmount4 = _expenseAmount4; expenseAmount4.Clean = value; _expenseAmount4 = expenseAmount4;
                var expenseDescription1 = _expenseDescription1; expenseDescription1.Clean = value; _expenseDescription1 = expenseDescription1;
                var expenseDescription2 = _expenseDescription2; expenseDescription2.Clean = value; _expenseDescription2 = expenseDescription2;
                var expenseDescription3 = _expenseDescription3; expenseDescription3.Clean = value; _expenseDescription3 = expenseDescription3;
                var expenseDescription4 = _expenseDescription4; expenseDescription4.Clean = value; _expenseDescription4 = expenseDescription4;
                var grossCheckAmount = _grossCheckAmount; grossCheckAmount.Clean = value; _grossCheckAmount = grossCheckAmount;
                var id = _id; id.Clean = value; _id = id;
                var netProfit = _netProfit; netProfit.Clean = value; _netProfit = netProfit;
                var profitManagementItems = _profitManagementItems; profitManagementItems.Clean = value; _profitManagementItems = profitManagementItems;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public ProfitManagement()
        {
            Clean = true;
        }
    }
}