using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class LoanSubmissionFee
    {
        public string Description { get; set; }
        public JsonNullable<decimal?> DueBroker { get; set; }
        public JsonNullable<decimal?> DueLender { get; set; }
        public string Id { get; set; }
        public string LoanSubmissionFeeType { get; set; }
        public JsonNullable<decimal?> Total { get; set; }
    }
}