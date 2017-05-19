using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class LoanSubmissionFee
    {
        public string LoanSubmissionFeeType { get; set; }
        public string Description { get; set; }
        public decimal? DueLender { get; set; }
        public decimal? DueBroker { get; set; }
        public decimal? Total { get; set; }
        public string Id { get; set; }
    }
}