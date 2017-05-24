using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class PriceAdjustment
    {
        private Value<string> _adjustmentType;
        public string AdjustmentType { get { return _adjustmentType; } set { _adjustmentType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentType() => !_adjustmentType.Clean;
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !_description.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _priceAdjustmentType;
        public string PriceAdjustmentType { get { return _priceAdjustmentType; } set { _priceAdjustmentType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriceAdjustmentType() => !_priceAdjustmentType.Clean;
        private Value<decimal?> _rate;
        public decimal? Rate { get { return _rate; } set { _rate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRate() => !_rate.Clean;
        private Value<string> _rateLockAdjustmentType;
        public string RateLockAdjustmentType { get { return _rateLockAdjustmentType; } set { _rateLockAdjustmentType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateLockAdjustmentType() => !_rateLockAdjustmentType.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _adjustmentType.Clean
                    && _description.Clean
                    && _id.Clean
                    && _priceAdjustmentType.Clean
                    && _rate.Clean
                    && _rateLockAdjustmentType.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _adjustmentType; v0.Clean = value; _adjustmentType = v0;
                var v1 = _description; v1.Clean = value; _description = v1;
                var v2 = _id; v2.Clean = value; _id = v2;
                var v3 = _priceAdjustmentType; v3.Clean = value; _priceAdjustmentType = v3;
                var v4 = _rate; v4.Clean = value; _rate = v4;
                var v5 = _rateLockAdjustmentType; v5.Clean = value; _rateLockAdjustmentType = v5;
                _settingClean = 0;
            }
        }
    }
}