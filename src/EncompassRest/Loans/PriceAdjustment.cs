using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class PriceAdjustment
    {
        public Value<string> AdjustmentType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentType() => !AdjustmentType.Clean;
        public Value<string> Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !Description.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> PriceAdjustmentType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriceAdjustmentType() => !PriceAdjustmentType.Clean;
        public Value<decimal?> Rate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRate() => !Rate.Clean;
        public Value<string> RateLockAdjustmentType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateLockAdjustmentType() => !RateLockAdjustmentType.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AdjustmentType.Clean
                    && Description.Clean
                    && Id.Clean
                    && PriceAdjustmentType.Clean
                    && Rate.Clean
                    && RateLockAdjustmentType.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AdjustmentType; v0.Clean = value; AdjustmentType = v0;
                var v1 = Description; v1.Clean = value; Description = v1;
                var v2 = Id; v2.Clean = value; Id = v2;
                var v3 = PriceAdjustmentType; v3.Clean = value; PriceAdjustmentType = v3;
                var v4 = Rate; v4.Clean = value; Rate = v4;
                var v5 = RateLockAdjustmentType; v5.Clean = value; RateLockAdjustmentType = v5;
                _settingClean = 0;
            }
        }
    }
}