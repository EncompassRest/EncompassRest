using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Buydown
    {
        private Value<int?> _buydownIndex;
        public int? BuydownIndex { get { return _buydownIndex; } set { _buydownIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownIndex() => !_buydownIndex.Clean;
        private Value<decimal?> _buydownRatePercent;
        public decimal? BuydownRatePercent { get { return _buydownRatePercent; } set { _buydownRatePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownRatePercent() => !_buydownRatePercent.Clean;
        private Value<int?> _changeFrequencyMonthsCount;
        public int? ChangeFrequencyMonthsCount { get { return _changeFrequencyMonthsCount; } set { _changeFrequencyMonthsCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChangeFrequencyMonthsCount() => !_changeFrequencyMonthsCount.Clean;
        private Value<int?> _durationMonthsCount;
        public int? DurationMonthsCount { get { return _durationMonthsCount; } set { _durationMonthsCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDurationMonthsCount() => !_durationMonthsCount.Clean;
        private Value<decimal?> _fundBalanceAmount;
        public decimal? FundBalanceAmount { get { return _fundBalanceAmount; } set { _fundBalanceAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundBalanceAmount() => !_fundBalanceAmount.Clean;
        private Value<decimal?> _fundTotalAmount;
        public decimal? FundTotalAmount { get { return _fundTotalAmount; } set { _fundTotalAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundTotalAmount() => !_fundTotalAmount.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<decimal?> _increaseRatePercent;
        public decimal? IncreaseRatePercent { get { return _increaseRatePercent; } set { _increaseRatePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIncreaseRatePercent() => !_increaseRatePercent.Clean;
        private Value<int?> _remainingMonthsCount;
        public int? RemainingMonthsCount { get { return _remainingMonthsCount; } set { _remainingMonthsCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRemainingMonthsCount() => !_remainingMonthsCount.Clean;
        private Value<decimal?> _subsidyAmount;
        public decimal? SubsidyAmount { get { return _subsidyAmount; } set { _subsidyAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubsidyAmount() => !_subsidyAmount.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _buydownIndex.Clean
                    && _buydownRatePercent.Clean
                    && _changeFrequencyMonthsCount.Clean
                    && _durationMonthsCount.Clean
                    && _fundBalanceAmount.Clean
                    && _fundTotalAmount.Clean
                    && _id.Clean
                    && _increaseRatePercent.Clean
                    && _remainingMonthsCount.Clean
                    && _subsidyAmount.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _buydownIndex; v0.Clean = value; _buydownIndex = v0;
                var v1 = _buydownRatePercent; v1.Clean = value; _buydownRatePercent = v1;
                var v2 = _changeFrequencyMonthsCount; v2.Clean = value; _changeFrequencyMonthsCount = v2;
                var v3 = _durationMonthsCount; v3.Clean = value; _durationMonthsCount = v3;
                var v4 = _fundBalanceAmount; v4.Clean = value; _fundBalanceAmount = v4;
                var v5 = _fundTotalAmount; v5.Clean = value; _fundTotalAmount = v5;
                var v6 = _id; v6.Clean = value; _id = v6;
                var v7 = _increaseRatePercent; v7.Clean = value; _increaseRatePercent = v7;
                var v8 = _remainingMonthsCount; v8.Clean = value; _remainingMonthsCount = v8;
                var v9 = _subsidyAmount; v9.Clean = value; _subsidyAmount = v9;
                _settingClean = 0;
            }
        }
    }
}