using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Buydown
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class Buydown : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _buydownIndex;
        private DirtyValue<decimal?> _buydownRatePercent;
        private DirtyValue<int?> _changeFrequencyMonthsCount;
        private DirtyValue<int?> _durationMonthsCount;
        private DirtyValue<decimal?> _fundBalanceAmount;
        private DirtyValue<decimal?> _fundTotalAmount;
        private DirtyValue<string> _id;
        private DirtyValue<decimal?> _increaseRatePercent;
        private DirtyValue<int?> _nonBorrowerChangeFrequencyMonthsCount;
        private DirtyValue<decimal?> _nonBorrowerIncreaseRatePercent;
        private DirtyValue<int?> _remainingMonthsCount;
        private DirtyValue<decimal?> _subsidyAmount;

        /// <summary>
        /// Buydown BuydownIndex
        /// </summary>
        public int? BuydownIndex { get => _buydownIndex; set => SetField(ref _buydownIndex, value); }

        /// <summary>
        /// Buydown BuydownRatePercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? BuydownRatePercent { get => _buydownRatePercent; set => SetField(ref _buydownRatePercent, value); }

        /// <summary>
        /// Buydown ChangeFrequencyMonthsCount
        /// </summary>
        public int? ChangeFrequencyMonthsCount { get => _changeFrequencyMonthsCount; set => SetField(ref _changeFrequencyMonthsCount, value); }

        /// <summary>
        /// Loan Info Buydown Terms [1557]
        /// </summary>
        public int? DurationMonthsCount { get => _durationMonthsCount; set => SetField(ref _durationMonthsCount, value); }

        /// <summary>
        /// Buydown FundBalanceAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? FundBalanceAmount { get => _fundBalanceAmount; set => SetField(ref _fundBalanceAmount, value); }

        /// <summary>
        /// Buydown FundTotalAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? FundTotalAmount { get => _fundTotalAmount; set => SetField(ref _fundTotalAmount, value); }

        /// <summary>
        /// Buydown Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Buydown IncreaseRatePercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? IncreaseRatePercent { get => _increaseRatePercent; set => SetField(ref _increaseRatePercent, value); }

        /// <summary>
        /// Buydown NonBorrowerChangeFrequencyMonthsCount
        /// </summary>
        public int? NonBorrowerChangeFrequencyMonthsCount { get => _nonBorrowerChangeFrequencyMonthsCount; set => SetField(ref _nonBorrowerChangeFrequencyMonthsCount, value); }

        /// <summary>
        /// Buydown NonBorrowerIncreaseRatePercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? NonBorrowerIncreaseRatePercent { get => _nonBorrowerIncreaseRatePercent; set => SetField(ref _nonBorrowerIncreaseRatePercent, value); }

        /// <summary>
        /// Buydown RemainingMonthsCount
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? RemainingMonthsCount { get => _remainingMonthsCount; set => SetField(ref _remainingMonthsCount, value); }

        /// <summary>
        /// Buydown SubsidyAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? SubsidyAmount { get => _subsidyAmount; set => SetField(ref _subsidyAmount, value); }
    }
}