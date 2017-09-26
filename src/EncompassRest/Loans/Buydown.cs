using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Buydown : IDirty
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _buydownIndex.Dirty
                    || _buydownRatePercent.Dirty
                    || _changeFrequencyMonthsCount.Dirty
                    || _durationMonthsCount.Dirty
                    || _fundBalanceAmount.Dirty
                    || _fundTotalAmount.Dirty
                    || _id.Dirty
                    || _increaseRatePercent.Dirty
                    || _remainingMonthsCount.Dirty
                    || _subsidyAmount.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}