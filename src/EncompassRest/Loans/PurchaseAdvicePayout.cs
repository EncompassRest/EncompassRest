using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class PurchaseAdvicePayout
    {
        public Value<decimal?> Amount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmount() => !Amount.Clean;
        public Value<string> Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !Description.Clean;
        public Value<decimal?> DiffAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiffAmount() => !DiffAmount.Clean;
        public Value<decimal?> ExpectedAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpectedAmount() => !ExpectedAmount.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Amount.Clean
                    && Description.Clean
                    && DiffAmount.Clean
                    && ExpectedAmount.Clean
                    && Id.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Amount; v0.Clean = value; Amount = v0;
                var v1 = Description; v1.Clean = value; Description = v1;
                var v2 = DiffAmount; v2.Clean = value; DiffAmount = v2;
                var v3 = ExpectedAmount; v3.Clean = value; ExpectedAmount = v3;
                var v4 = Id; v4.Clean = value; Id = v4;
                _settingClean = 0;
            }
        }
    }
}