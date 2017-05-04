
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class GfePayment
    {
        public int? gfePaymentIndex { get; set; }
        public decimal? monthlyPaymentYear1 { get; set; }
        public decimal? monthlyPaymentYear6 { get; set; }
        public decimal? monthlyPaymentYear6Change { get; set; }
        public decimal? minimumMonthlyPayment { get; set; }
        public decimal? minimumDifference { get; set; }
        public decimal? monthlyPaymentYear6MaxChange { get; set; }
        public decimal? maximumDifference { get; set; }
        public decimal? owedAfter5Years { get; set; }
        public decimal? fixedRate { get; set; }
        public decimal? maximumRate { get; set; }
        public decimal? rateInMonth2 { get; set; }
        public string loanTypeExplanation { get; set; }
        public decimal? reducedLoanBalance { get; set; }
        public string isBalanceReduced { get; set; }
        public string reducedStatus { get; set; }
        public decimal? indexRate { get; set; }
        public decimal? marginRate { get; set; }
        public bool? notOfferedIndicator { get; set; }
        public string id { get; set; }

    }
}