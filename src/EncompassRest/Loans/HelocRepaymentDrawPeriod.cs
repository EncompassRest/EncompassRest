using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// HelocRepaymentDrawPeriod
    /// </summary>
    public sealed partial class HelocRepaymentDrawPeriod : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _apr;
        /// <summary>
        /// HelocRepaymentDrawPeriod Apr
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? Apr { get => _apr; set => SetField(ref _apr, value); }
        private DirtyValue<bool?> _drawIndicator;
        /// <summary>
        /// HelocRepaymentDrawPeriod DrawIndicator
        /// </summary>
        public bool? DrawIndicator { get => _drawIndicator; set => SetField(ref _drawIndicator, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// HelocRepaymentDrawPeriod Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<decimal?> _indexRatePercent;
        /// <summary>
        /// HelocRepaymentDrawPeriod IndexRatePercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? IndexRatePercent { get => _indexRatePercent; set => SetField(ref _indexRatePercent, value); }
        private DirtyValue<decimal?> _marginRatePercent;
        /// <summary>
        /// HelocRepaymentDrawPeriod MarginRatePercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MarginRatePercent { get => _marginRatePercent; set => SetField(ref _marginRatePercent, value); }
        private DirtyValue<decimal?> _minimumMonthlyPaymentAmount;
        /// <summary>
        /// HelocRepaymentDrawPeriod MinimumMonthlyPaymentAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MinimumMonthlyPaymentAmount { get => _minimumMonthlyPaymentAmount; set => SetField(ref _minimumMonthlyPaymentAmount, value); }
        private DirtyValue<int?> _year;
        /// <summary>
        /// HelocRepaymentDrawPeriod Year
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? Year { get => _year; set => SetField(ref _year, value); }
    }
}