using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ProfitManagement
    {
        public Value<decimal?> CommissionableGrossProfit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommissionableGrossProfit() => !CommissionableGrossProfit.Clean;
        public Value<decimal?> ExpenseAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpenseAmount1() => !ExpenseAmount1.Clean;
        public Value<decimal?> ExpenseAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpenseAmount2() => !ExpenseAmount2.Clean;
        public Value<decimal?> ExpenseAmount3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpenseAmount3() => !ExpenseAmount3.Clean;
        public Value<decimal?> ExpenseAmount4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpenseAmount4() => !ExpenseAmount4.Clean;
        public Value<string> ExpenseDescription1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpenseDescription1() => !ExpenseDescription1.Clean;
        public Value<string> ExpenseDescription2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpenseDescription2() => !ExpenseDescription2.Clean;
        public Value<string> ExpenseDescription3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpenseDescription3() => !ExpenseDescription3.Clean;
        public Value<string> ExpenseDescription4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpenseDescription4() => !ExpenseDescription4.Clean;
        public Value<decimal?> GrossCheckAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGrossCheckAmount() => !GrossCheckAmount.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> NetProfit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNetProfit() => !NetProfit.Clean;
        public Value<List<ProfitManagementItem>> ProfitManagementItems { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProfitManagementItems() => !ProfitManagementItems.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = CommissionableGrossProfit.Clean
                    && ExpenseAmount1.Clean
                    && ExpenseAmount2.Clean
                    && ExpenseAmount3.Clean
                    && ExpenseAmount4.Clean
                    && ExpenseDescription1.Clean
                    && ExpenseDescription2.Clean
                    && ExpenseDescription3.Clean
                    && ExpenseDescription4.Clean
                    && GrossCheckAmount.Clean
                    && Id.Clean
                    && NetProfit.Clean
                    && ProfitManagementItems.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = CommissionableGrossProfit; v0.Clean = value; CommissionableGrossProfit = v0;
                var v1 = ExpenseAmount1; v1.Clean = value; ExpenseAmount1 = v1;
                var v2 = ExpenseAmount2; v2.Clean = value; ExpenseAmount2 = v2;
                var v3 = ExpenseAmount3; v3.Clean = value; ExpenseAmount3 = v3;
                var v4 = ExpenseAmount4; v4.Clean = value; ExpenseAmount4 = v4;
                var v5 = ExpenseDescription1; v5.Clean = value; ExpenseDescription1 = v5;
                var v6 = ExpenseDescription2; v6.Clean = value; ExpenseDescription2 = v6;
                var v7 = ExpenseDescription3; v7.Clean = value; ExpenseDescription3 = v7;
                var v8 = ExpenseDescription4; v8.Clean = value; ExpenseDescription4 = v8;
                var v9 = GrossCheckAmount; v9.Clean = value; GrossCheckAmount = v9;
                var v10 = Id; v10.Clean = value; Id = v10;
                var v11 = NetProfit; v11.Clean = value; NetProfit = v11;
                var v12 = ProfitManagementItems; v12.Clean = value; ProfitManagementItems = v12;
                _settingClean = 0;
            }
        }
    }
}