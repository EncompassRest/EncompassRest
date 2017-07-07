using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Buydown : IClean
    {
        private Value<int?> _buydownIndex;
        public int? BuydownIndex { get { return _buydownIndex; } set { _buydownIndex = value; } }
        private Value<decimal?> _buydownRatePercent;
        public decimal? BuydownRatePercent { get { return _buydownRatePercent; } set { _buydownRatePercent = value; } }
        private Value<int?> _changeFrequencyMonthsCount;
        public int? ChangeFrequencyMonthsCount { get { return _changeFrequencyMonthsCount; } set { _changeFrequencyMonthsCount = value; } }
        private Value<int?> _durationMonthsCount;
        public int? DurationMonthsCount { get { return _durationMonthsCount; } set { _durationMonthsCount = value; } }
        private Value<decimal?> _fundBalanceAmount;
        public decimal? FundBalanceAmount { get { return _fundBalanceAmount; } set { _fundBalanceAmount = value; } }
        private Value<decimal?> _fundTotalAmount;
        public decimal? FundTotalAmount { get { return _fundTotalAmount; } set { _fundTotalAmount = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _increaseRatePercent;
        public decimal? IncreaseRatePercent { get { return _increaseRatePercent; } set { _increaseRatePercent = value; } }
        private Value<int?> _remainingMonthsCount;
        public int? RemainingMonthsCount { get { return _remainingMonthsCount; } set { _remainingMonthsCount = value; } }
        private Value<decimal?> _subsidyAmount;
        public decimal? SubsidyAmount { get { return _subsidyAmount; } set { _subsidyAmount = value; } }
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
                var buydownIndex = _buydownIndex; buydownIndex.Clean = value; _buydownIndex = buydownIndex;
                var buydownRatePercent = _buydownRatePercent; buydownRatePercent.Clean = value; _buydownRatePercent = buydownRatePercent;
                var changeFrequencyMonthsCount = _changeFrequencyMonthsCount; changeFrequencyMonthsCount.Clean = value; _changeFrequencyMonthsCount = changeFrequencyMonthsCount;
                var durationMonthsCount = _durationMonthsCount; durationMonthsCount.Clean = value; _durationMonthsCount = durationMonthsCount;
                var fundBalanceAmount = _fundBalanceAmount; fundBalanceAmount.Clean = value; _fundBalanceAmount = fundBalanceAmount;
                var fundTotalAmount = _fundTotalAmount; fundTotalAmount.Clean = value; _fundTotalAmount = fundTotalAmount;
                var id = _id; id.Clean = value; _id = id;
                var increaseRatePercent = _increaseRatePercent; increaseRatePercent.Clean = value; _increaseRatePercent = increaseRatePercent;
                var remainingMonthsCount = _remainingMonthsCount; remainingMonthsCount.Clean = value; _remainingMonthsCount = remainingMonthsCount;
                var subsidyAmount = _subsidyAmount; subsidyAmount.Clean = value; _subsidyAmount = subsidyAmount;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Buydown()
        {
            Clean = true;
        }
    }
}