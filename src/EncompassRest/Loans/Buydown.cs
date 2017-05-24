using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Buydown
    {
        public Value<int?> BuydownIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownIndex() => !BuydownIndex.Clean;
        public Value<decimal?> BuydownRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownRatePercent() => !BuydownRatePercent.Clean;
        public Value<int?> ChangeFrequencyMonthsCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChangeFrequencyMonthsCount() => !ChangeFrequencyMonthsCount.Clean;
        public Value<int?> DurationMonthsCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDurationMonthsCount() => !DurationMonthsCount.Clean;
        public Value<decimal?> FundBalanceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundBalanceAmount() => !FundBalanceAmount.Clean;
        public Value<decimal?> FundTotalAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundTotalAmount() => !FundTotalAmount.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> IncreaseRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIncreaseRatePercent() => !IncreaseRatePercent.Clean;
        public Value<int?> RemainingMonthsCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRemainingMonthsCount() => !RemainingMonthsCount.Clean;
        public Value<decimal?> SubsidyAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubsidyAmount() => !SubsidyAmount.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = BuydownIndex.Clean
                    && BuydownRatePercent.Clean
                    && ChangeFrequencyMonthsCount.Clean
                    && DurationMonthsCount.Clean
                    && FundBalanceAmount.Clean
                    && FundTotalAmount.Clean
                    && Id.Clean
                    && IncreaseRatePercent.Clean
                    && RemainingMonthsCount.Clean
                    && SubsidyAmount.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = BuydownIndex; v0.Clean = value; BuydownIndex = v0;
                var v1 = BuydownRatePercent; v1.Clean = value; BuydownRatePercent = v1;
                var v2 = ChangeFrequencyMonthsCount; v2.Clean = value; ChangeFrequencyMonthsCount = v2;
                var v3 = DurationMonthsCount; v3.Clean = value; DurationMonthsCount = v3;
                var v4 = FundBalanceAmount; v4.Clean = value; FundBalanceAmount = v4;
                var v5 = FundTotalAmount; v5.Clean = value; FundTotalAmount = v5;
                var v6 = Id; v6.Clean = value; Id = v6;
                var v7 = IncreaseRatePercent; v7.Clean = value; IncreaseRatePercent = v7;
                var v8 = RemainingMonthsCount; v8.Clean = value; RemainingMonthsCount = v8;
                var v9 = SubsidyAmount; v9.Clean = value; SubsidyAmount = v9;
                _settingClean = 0;
            }
        }
    }
}