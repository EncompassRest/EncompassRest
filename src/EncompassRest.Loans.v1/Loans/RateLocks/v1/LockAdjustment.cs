namespace EncompassRest.Loans.RateLocks.v1
{
    /// <summary>
    /// LockAdjustment
    /// </summary>
    public sealed partial class LockAdjustment : DirtyExtensibleObject
    {
        /// <summary>
        /// Type of rate lock adjustment.
        /// </summary>
        public StringEnumValue<LockAdjustmentType> AdjustmentType { get => GetValue<StringEnumValue<LockAdjustmentType>>(); set => SetValue(value); }

        /// <summary>
        /// Description of the rate lock profit margin adjustment.
        /// </summary>
        public string? Description { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Price adjustment type
        /// </summary>
        public StringEnumValue<PriceAdjustmentType> PriceAdjustmentType { get => GetValue<StringEnumValue<PriceAdjustmentType>>(); set => SetValue(value); }

        /// <summary>
        /// The value of the price adjustment.
        /// </summary>
        public decimal? Adjustment { get => GetValue<decimal?>(); set => SetValue(value); }
    }
}