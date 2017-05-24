using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class PurchaseCredit
    {
        private Value<decimal?> _amount;
        public decimal? Amount { get { return _amount; } set { _amount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmount() => !_amount.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _purchaseCreditType;
        public string PurchaseCreditType { get { return _purchaseCreditType; } set { _purchaseCreditType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchaseCreditType() => !_purchaseCreditType.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _amount.Clean
                    && _id.Clean
                    && _purchaseCreditType.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _amount; v0.Clean = value; _amount = v0;
                var v1 = _id; v1.Clean = value; _id = v1;
                var v2 = _purchaseCreditType; v2.Clean = value; _purchaseCreditType = v2;
                _settingClean = 0;
            }
        }
    }
}