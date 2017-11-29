using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Buydown : ExtensibleObject
    {
        private DirtyValue<int?> _buydownIndex;
        public int? BuydownIndex { get => _buydownIndex; set => _buydownIndex = value; }
        private DirtyValue<decimal?> _buydownRatePercent;
        public decimal? BuydownRatePercent { get => _buydownRatePercent; set => _buydownRatePercent = value; }
        private DirtyValue<int?> _changeFrequencyMonthsCount;
        public int? ChangeFrequencyMonthsCount { get => _changeFrequencyMonthsCount; set => _changeFrequencyMonthsCount = value; }
        private DirtyValue<int?> _durationMonthsCount;
        public int? DurationMonthsCount { get => _durationMonthsCount; set => _durationMonthsCount = value; }
        private DirtyValue<decimal?> _fundBalanceAmount;
        public decimal? FundBalanceAmount { get => _fundBalanceAmount; set => _fundBalanceAmount = value; }
        private DirtyValue<decimal?> _fundTotalAmount;
        public decimal? FundTotalAmount { get => _fundTotalAmount; set => _fundTotalAmount = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _increaseRatePercent;
        public decimal? IncreaseRatePercent { get => _increaseRatePercent; set => _increaseRatePercent = value; }
        private DirtyValue<int?> _remainingMonthsCount;
        public int? RemainingMonthsCount { get => _remainingMonthsCount; set => _remainingMonthsCount = value; }
        private DirtyValue<decimal?> _subsidyAmount;
        public decimal? SubsidyAmount { get => _subsidyAmount; set => _subsidyAmount = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _buydownIndex.Dirty
                    || _buydownRatePercent.Dirty
                    || _changeFrequencyMonthsCount.Dirty
                    || _durationMonthsCount.Dirty
                    || _fundBalanceAmount.Dirty
                    || _fundTotalAmount.Dirty
                    || _id.Dirty
                    || _increaseRatePercent.Dirty
                    || _remainingMonthsCount.Dirty
                    || _subsidyAmount.Dirty;
            }
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