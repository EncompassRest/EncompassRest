using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Buydown
    /// </summary>
    public sealed partial class Buydown : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _buydownIndex;
        /// <summary>
        /// Buydown BuydownIndex
        /// </summary>
        public int? BuydownIndex { get => _buydownIndex; set => _buydownIndex = value; }
        private DirtyValue<decimal?> _buydownRatePercent;
        /// <summary>
        /// Buydown BuydownRatePercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? BuydownRatePercent { get => _buydownRatePercent; set => _buydownRatePercent = value; }
        private DirtyValue<int?> _changeFrequencyMonthsCount;
        /// <summary>
        /// Buydown ChangeFrequencyMonthsCount
        /// </summary>
        public int? ChangeFrequencyMonthsCount { get => _changeFrequencyMonthsCount; set => _changeFrequencyMonthsCount = value; }
        private DirtyValue<int?> _durationMonthsCount;
        /// <summary>
        /// Loan Info Buydown Terms [1557]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Buydown Terms")]
        public int? DurationMonthsCount { get => _durationMonthsCount; set => _durationMonthsCount = value; }
        private DirtyValue<decimal?> _fundBalanceAmount;
        /// <summary>
        /// Buydown FundBalanceAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? FundBalanceAmount { get => _fundBalanceAmount; set => _fundBalanceAmount = value; }
        private DirtyValue<decimal?> _fundTotalAmount;
        /// <summary>
        /// Buydown FundTotalAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? FundTotalAmount { get => _fundTotalAmount; set => _fundTotalAmount = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Buydown Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _increaseRatePercent;
        /// <summary>
        /// Buydown IncreaseRatePercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? IncreaseRatePercent { get => _increaseRatePercent; set => _increaseRatePercent = value; }
        private DirtyValue<int?> _remainingMonthsCount;
        /// <summary>
        /// Buydown RemainingMonthsCount
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? RemainingMonthsCount { get => _remainingMonthsCount; set => _remainingMonthsCount = value; }
        private DirtyValue<decimal?> _subsidyAmount;
        /// <summary>
        /// Buydown SubsidyAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? SubsidyAmount { get => _subsidyAmount; set => _subsidyAmount = value; }
        internal override bool DirtyInternal
        {
            get => _buydownIndex.Dirty
                || _buydownRatePercent.Dirty
                || _changeFrequencyMonthsCount.Dirty
                || _durationMonthsCount.Dirty
                || _fundBalanceAmount.Dirty
                || _fundTotalAmount.Dirty
                || _id.Dirty
                || _increaseRatePercent.Dirty
                || _remainingMonthsCount.Dirty
                || _subsidyAmount.Dirty;
            set
            {
                _buydownIndex.Dirty = value;
                _buydownRatePercent.Dirty = value;
                _changeFrequencyMonthsCount.Dirty = value;
                _durationMonthsCount.Dirty = value;
                _fundBalanceAmount.Dirty = value;
                _fundTotalAmount.Dirty = value;
                _id.Dirty = value;
                _increaseRatePercent.Dirty = value;
                _remainingMonthsCount.Dirty = value;
                _subsidyAmount.Dirty = value;
            }
        }
    }
}