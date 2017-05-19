using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Buydown
    {
        public decimal? IncreaseRatePercent { get; set; }
        public int? DurationMonthsCount { get; set; }
        public int? ChangeFrequencyMonthsCount { get; set; }
        public decimal? BuydownRatePercent { get; set; }
        public decimal? SubsidyAmount { get; set; }
        public decimal? FundTotalAmount { get; set; }
        public decimal? FundBalanceAmount { get; set; }
        public int? RemainingMonthsCount { get; set; }
        public string Id { get; set; }
        public int? BuydownIndex { get; set; }
    }
}