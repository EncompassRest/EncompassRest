using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Buydown
    {
        public int? BuydownIndex { get; set; }
        public JsonNullable<decimal?> BuydownRatePercent { get; set; }
        public JsonNullable<int?> ChangeFrequencyMonthsCount { get; set; }
        public JsonNullable<int?> DurationMonthsCount { get; set; }
        public JsonNullable<decimal?> FundBalanceAmount { get; set; }
        public JsonNullable<decimal?> FundTotalAmount { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> IncreaseRatePercent { get; set; }
        public JsonNullable<int?> RemainingMonthsCount { get; set; }
        public JsonNullable<decimal?> SubsidyAmount { get; set; }
    }
}