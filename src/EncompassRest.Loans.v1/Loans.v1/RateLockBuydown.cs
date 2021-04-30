using EncompassRest.Schema;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// RateLockBuydown
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class RateLockBuydown : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?>? _changeFrequencyMonths;
        private DirtyValue<string?>? _id;
        private DirtyValue<decimal?>? _increaseRatePercent;
        private DirtyValue<int?>? _rateLockBuydownIndex;

        /// <summary>
        /// RateLockBuydown ChangeFrequencyMonths
        /// </summary>
        public int? ChangeFrequencyMonths { get => _changeFrequencyMonths; set => SetField(ref _changeFrequencyMonths, value); }

        /// <summary>
        /// RateLockBuydown Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// RateLockBuydown IncreaseRatePercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? IncreaseRatePercent { get => _increaseRatePercent; set => SetField(ref _increaseRatePercent, value); }

        /// <summary>
        /// RateLockBuydown RateLockBuydownIndex
        /// </summary>
        public int? RateLockBuydownIndex { get => _rateLockBuydownIndex; set => SetField(ref _rateLockBuydownIndex, value); }
    }
}