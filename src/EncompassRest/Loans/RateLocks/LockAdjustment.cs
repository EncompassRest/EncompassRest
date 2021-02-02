using System;
using System.Collections.Generic;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// LockAdjustment
    /// </summary>
    public sealed partial class LockAdjustment : DirtyExtensibleObject
    {
        private DirtyValue<StringEnumValue<LockAdjustmentType>>? _adjustmentType;
        private DirtyValue<string?>? _description;
        private DirtyValue<StringEnumValue<PriceAdjustmentType>>? _priceAdjustmentType;
        private DirtyValue<decimal?>? _adjustment;

        /// <summary>
        /// Type of rate lock adjustment.
        /// </summary>
        public StringEnumValue<LockAdjustmentType> AdjustmentType { get => _adjustmentType; set => SetField(ref _adjustmentType, value); }

        /// <summary>
        /// Description of the rate lock profit margin adjustment.
        /// </summary>
        public string? Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// Price adjustment type
        /// </summary>
        public StringEnumValue<PriceAdjustmentType> PriceAdjustmentType { get => _priceAdjustmentType; set => SetField(ref _priceAdjustmentType, value); }

        /// <summary>
        /// The value of the price adjustment.
        /// </summary>
        public decimal? Adjustment { get => _adjustment; set => SetField(ref _adjustment, value); }
        
    }
}