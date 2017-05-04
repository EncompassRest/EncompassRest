using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class LoanSubmissionFee
    {
        public string loanSubmissionFeeType { get; set; }
        public string description { get; set; }
        public decimal? dueLender { get; set; }
        public decimal? dueBroker { get; set; }
        public decimal? total { get; set; }
        public string id { get; set; }

    }
}
