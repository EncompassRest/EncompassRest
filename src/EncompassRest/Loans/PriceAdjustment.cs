using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class PriceAdjustment : IDirty
    {
        private DirtyValue<string> _adjustmentType;
        public string AdjustmentType { get { return _adjustmentType; } set { _adjustmentType = value; } }
        private DirtyValue<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _priceAdjustmentType;
        public string PriceAdjustmentType { get { return _priceAdjustmentType; } set { _priceAdjustmentType = value; } }
        private DirtyValue<decimal?> _rate;
        public decimal? Rate { get { return _rate; } set { _rate = value; } }
        private DirtyValue<string> _rateLockAdjustmentType;
        public string RateLockAdjustmentType { get { return _rateLockAdjustmentType; } set { _rateLockAdjustmentType = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _adjustmentType.Dirty
                    || _description.Dirty
                    || _id.Dirty
                    || _priceAdjustmentType.Dirty
                    || _rate.Dirty
                    || _rateLockAdjustmentType.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _adjustmentType.Dirty = value;
                _description.Dirty = value;
                _id.Dirty = value;
                _priceAdjustmentType.Dirty = value;
                _rate.Dirty = value;
                _rateLockAdjustmentType.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}