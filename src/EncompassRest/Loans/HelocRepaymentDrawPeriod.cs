using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// HelocRepaymentDrawPeriod
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(DrawIndicator), SerializeWholeListWhenDirty = true)]
    public sealed partial class HelocRepaymentDrawPeriod : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _apr;
        private DirtyValue<bool?> _drawIndicator;
        private DirtyValue<string> _id;
        private DirtyValue<decimal?> _indexRatePercent;
        private DirtyValue<decimal?> _marginRatePercent;
        private DirtyValue<decimal?> _minimumMonthlyPaymentAmount;
        private DirtyValue<int?> _year;

        /// <summary>
        /// HelocRepaymentDrawPeriod Apr
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? Apr { get => _apr; set => SetField(ref _apr, value); }

        /// <summary>
        /// HelocRepaymentDrawPeriod DrawIndicator
        /// </summary>
        public bool? DrawIndicator { get => _drawIndicator; set => SetField(ref _drawIndicator, value); }

        /// <summary>
        /// HelocRepaymentDrawPeriod Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// HelocRepaymentDrawPeriod IndexRatePercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? IndexRatePercent { get => _indexRatePercent; set => SetField(ref _indexRatePercent, value); }

        /// <summary>
        /// HelocRepaymentDrawPeriod MarginRatePercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MarginRatePercent { get => _marginRatePercent; set => SetField(ref _marginRatePercent, value); }

        /// <summary>
        /// HelocRepaymentDrawPeriod MinimumMonthlyPaymentAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MinimumMonthlyPaymentAmount { get => _minimumMonthlyPaymentAmount; set => SetField(ref _minimumMonthlyPaymentAmount, value); }

        /// <summary>
        /// HelocRepaymentDrawPeriod Year
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? Year { get => _year; set => SetField(ref _year, value); }
    }
}