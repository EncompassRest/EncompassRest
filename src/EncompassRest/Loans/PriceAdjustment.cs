using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class PriceAdjustment : IClean
    {
        private Value<string> _adjustmentType;
        public string AdjustmentType { get { return _adjustmentType; } set { _adjustmentType = value; } }
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _priceAdjustmentType;
        public string PriceAdjustmentType { get { return _priceAdjustmentType; } set { _priceAdjustmentType = value; } }
        private Value<decimal?> _rate;
        public decimal? Rate { get { return _rate; } set { _rate = value; } }
        private Value<string> _rateLockAdjustmentType;
        public string RateLockAdjustmentType { get { return _rateLockAdjustmentType; } set { _rateLockAdjustmentType = value; } }
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
                var adjustmentType = _adjustmentType; adjustmentType.Clean = value; _adjustmentType = adjustmentType;
                var description = _description; description.Clean = value; _description = description;
                var id = _id; id.Clean = value; _id = id;
                var priceAdjustmentType = _priceAdjustmentType; priceAdjustmentType.Clean = value; _priceAdjustmentType = priceAdjustmentType;
                var rate = _rate; rate.Clean = value; _rate = rate;
                var rateLockAdjustmentType = _rateLockAdjustmentType; rateLockAdjustmentType.Clean = value; _rateLockAdjustmentType = rateLockAdjustmentType;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public PriceAdjustment()
        {
            Clean = true;
        }
    }
}