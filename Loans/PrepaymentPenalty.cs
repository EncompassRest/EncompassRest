using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class PrepaymentPenalty
    {
        public string FullPrepaymentPenaltyOptionType { get; set; }
        public int? TermMonthsCount { get; set; }
        public decimal? PrepaymentPenaltyPercent { get; set; }
        public string Id { get; set; }
    }
}