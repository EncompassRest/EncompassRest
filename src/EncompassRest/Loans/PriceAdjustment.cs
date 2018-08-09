using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PriceAdjustment
    /// </summary>
    public sealed partial class PriceAdjustment : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<AdjustmentType>> _adjustmentType;
        /// <summary>
        /// PriceAdjustment AdjustmentType
        /// </summary>
        public StringEnumValue<AdjustmentType> AdjustmentType { get => _adjustmentType; set => _adjustmentType = value; }
        private DirtyValue<string> _description;
        /// <summary>
        /// PriceAdjustment Description
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// PriceAdjustment Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<StringEnumValue<PriceAdjustmentType>> _priceAdjustmentType;
        /// <summary>
        /// PriceAdjustment PriceAdjustmentType
        /// </summary>
        public StringEnumValue<PriceAdjustmentType> PriceAdjustmentType { get => _priceAdjustmentType; set => _priceAdjustmentType = value; }
        private DirtyValue<decimal?> _rate;
        /// <summary>
        /// PriceAdjustment Rate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? Rate { get => _rate; set => _rate = value; }
        private DirtyValue<string> _rateLockAdjustmentType;
        /// <summary>
        /// PriceAdjustment RateLockAdjustmentType
        /// </summary>
        public string RateLockAdjustmentType { get => _rateLockAdjustmentType; set => _rateLockAdjustmentType = value; }
    }
}