using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class GfePayment
    {
        public int? GfePaymentIndex { get; set; }
        public decimal? MonthlyPaymentYear1 { get; set; }
        public decimal? MonthlyPaymentYear6 { get; set; }
        public decimal? MonthlyPaymentYear6Change { get; set; }
        public decimal? MinimumMonthlyPayment { get; set; }
        public decimal? MinimumDifference { get; set; }
        public decimal? MonthlyPaymentYear6MaxChange { get; set; }
        public decimal? MaximumDifference { get; set; }
        public decimal? OwedAfter5Years { get; set; }
        public decimal? FixedRate { get; set; }
        public decimal? MaximumRate { get; set; }
        public decimal? RateInMonth2 { get; set; }
        public string LoanTypeExplanation { get; set; }
        public decimal? ReducedLoanBalance { get; set; }
        public string IsBalanceReduced { get; set; }
        public string ReducedStatus { get; set; }
        public decimal? IndexRate { get; set; }
        public decimal? MarginRate { get; set; }
        public bool? NotOfferedIndicator { get; set; }
        public string Id { get; set; }
    }
}