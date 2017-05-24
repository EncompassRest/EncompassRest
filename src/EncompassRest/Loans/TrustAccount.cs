using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class TrustAccount
    {
        public Value<decimal?> Balance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBalance() => !Balance.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> Total1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotal1() => !Total1.Clean;
        public Value<decimal?> Total2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotal2() => !Total2.Clean;
        public Value<List<TrustAccountItem>> TrustAccountItems { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrustAccountItems() => !TrustAccountItems.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Balance.Clean
                    && Id.Clean
                    && Total1.Clean
                    && Total2.Clean
                    && TrustAccountItems.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Balance; v0.Clean = value; Balance = v0;
                var v1 = Id; v1.Clean = value; Id = v1;
                var v2 = Total1; v2.Clean = value; Total1 = v2;
                var v3 = Total2; v3.Clean = value; Total2 = v3;
                var v4 = TrustAccountItems; v4.Clean = value; TrustAccountItems = v4;
                _settingClean = 0;
            }
        }
    }
}