using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PriceAdjustment
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(AdjustmentType) + "," + nameof(PriceAdjustmentType), SerializeWholeListWhenDirty = true)]
    public sealed partial class PriceAdjustment : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<AdjustmentType>> _adjustmentType;
        /// <summary>
        /// PriceAdjustment AdjustmentType
        /// </summary>
        public StringEnumValue<AdjustmentType> AdjustmentType { get => _adjustmentType; set => SetField(ref _adjustmentType, value); }
        private DirtyValue<string> _description;
        /// <summary>
        /// PriceAdjustment Description
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string Description { get => _description; set => SetField(ref _description, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// PriceAdjustment Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<StringEnumValue<PriceAdjustmentType>> _priceAdjustmentType;
        /// <summary>
        /// PriceAdjustment PriceAdjustmentType
        /// </summary>
        public StringEnumValue<PriceAdjustmentType> PriceAdjustmentType { get => _priceAdjustmentType; set => SetField(ref _priceAdjustmentType, value); }
        private DirtyValue<decimal?> _rate;
        /// <summary>
        /// PriceAdjustment Rate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? Rate { get => _rate; set => SetField(ref _rate, value); }
        private DirtyValue<string> _rateLockAdjustmentType;
        /// <summary>
        /// PriceAdjustment RateLockAdjustmentType
        /// </summary>
        public string RateLockAdjustmentType { get => _rateLockAdjustmentType; set => SetField(ref _rateLockAdjustmentType, value); }
    }
}