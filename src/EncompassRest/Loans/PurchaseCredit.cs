using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class PurchaseCredit
    {
        public Value<decimal?> Amount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmount() => !Amount.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> PurchaseCreditType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchaseCreditType() => !PurchaseCreditType.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Amount.Clean
                    && Id.Clean
                    && PurchaseCreditType.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Amount; v0.Clean = value; Amount = v0;
                var v1 = Id; v1.Clean = value; Id = v1;
                var v2 = PurchaseCreditType; v2.Clean = value; PurchaseCreditType = v2;
                _settingClean = 0;
            }
        }
    }
}