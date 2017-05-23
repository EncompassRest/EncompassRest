using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class HelocRepaymentDrawPeriod
    {
        public JsonNullable<decimal?> Apr { get; set; }
        public bool? DrawIndicator { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> IndexRatePercent { get; set; }
        public JsonNullable<decimal?> MarginRatePercent { get; set; }
        public JsonNullable<decimal?> MinimumMonthlyPaymentAmount { get; set; }
        public JsonNullable<int?> Year { get; set; }
    }
}