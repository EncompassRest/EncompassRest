using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class HelocRepaymentDrawPeriod
    {
        public int? Year { get; set; }
        public decimal? IndexRatePercent { get; set; }
        public decimal? MarginRatePercent { get; set; }
        public decimal? Apr { get; set; }
        public decimal? MinimumMonthlyPaymentAmount { get; set; }
        public string Id { get; set; }
        public bool? DrawIndicator { get; set; }
    }
}