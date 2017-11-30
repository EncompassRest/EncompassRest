using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class PriceAdjustment : ExtensibleObject
    {
        private DirtyValue<string> _adjustmentType;
        public string AdjustmentType { get => _adjustmentType; set => _adjustmentType = value; }
        private DirtyValue<string> _description;
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _priceAdjustmentType;
        public string PriceAdjustmentType { get => _priceAdjustmentType; set => _priceAdjustmentType = value; }
        private DirtyValue<decimal?> _rate;
        public decimal? Rate { get => _rate; set => _rate = value; }
        private DirtyValue<string> _rateLockAdjustmentType;
        public string RateLockAdjustmentType { get => _rateLockAdjustmentType; set => _rateLockAdjustmentType = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _adjustmentType.Dirty
                    || _description.Dirty
                    || _id.Dirty
                    || _priceAdjustmentType.Dirty
                    || _rate.Dirty
                    || _rateLockAdjustmentType.Dirty;
            }
            set
            {
                _adjustmentType.Dirty = value;
                _description.Dirty = value;
                _id.Dirty = value;
                _priceAdjustmentType.Dirty = value;
                _rate.Dirty = value;
                _rateLockAdjustmentType.Dirty = value;
            }
        }
    }
}