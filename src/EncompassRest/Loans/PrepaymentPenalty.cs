using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class PrepaymentPenalty
    {
        public string FullPrepaymentPenaltyOptionType { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> PrepaymentPenaltyPercent { get; set; }
        public JsonNullable<int?> TermMonthsCount { get; set; }
    }
}