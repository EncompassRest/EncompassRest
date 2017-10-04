using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ProfitManagement : IDirty
    {
        private DirtyValue<decimal?> _commissionableGrossProfit;
        public decimal? CommissionableGrossProfit { get { return _commissionableGrossProfit; } set { _commissionableGrossProfit = value; } }
        private DirtyValue<decimal?> _expenseAmount1;
        public decimal? ExpenseAmount1 { get { return _expenseAmount1; } set { _expenseAmount1 = value; } }
        private DirtyValue<decimal?> _expenseAmount2;
        public decimal? ExpenseAmount2 { get { return _expenseAmount2; } set { _expenseAmount2 = value; } }
        private DirtyValue<decimal?> _expenseAmount3;
        public decimal? ExpenseAmount3 { get { return _expenseAmount3; } set { _expenseAmount3 = value; } }
        private DirtyValue<decimal?> _expenseAmount4;
        public decimal? ExpenseAmount4 { get { return _expenseAmount4; } set { _expenseAmount4 = value; } }
        private DirtyValue<string> _expenseDescription1;
        public string ExpenseDescription1 { get { return _expenseDescription1; } set { _expenseDescription1 = value; } }
        private DirtyValue<string> _expenseDescription2;
        public string ExpenseDescription2 { get { return _expenseDescription2; } set { _expenseDescription2 = value; } }
        private DirtyValue<string> _expenseDescription3;
        public string ExpenseDescription3 { get { return _expenseDescription3; } set { _expenseDescription3 = value; } }
        private DirtyValue<string> _expenseDescription4;
        public string ExpenseDescription4 { get { return _expenseDescription4; } set { _expenseDescription4 = value; } }
        private DirtyValue<decimal?> _grossCheckAmount;
        public decimal? GrossCheckAmount { get { return _grossCheckAmount; } set { _grossCheckAmount = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _netProfit;
        public decimal? NetProfit { get { return _netProfit; } set { _netProfit = value; } }
        private DirtyList<ProfitManagementItem> _profitManagementItems;
        public IList<ProfitManagementItem> ProfitManagementItems { get { var v = _profitManagementItems; return v ?? Interlocked.CompareExchange(ref _profitManagementItems, (v = new DirtyList<ProfitManagementItem>()), null) ?? v; } set { _profitManagementItems = new DirtyList<ProfitManagementItem>(value); } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _commissionableGrossProfit.Dirty
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
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}