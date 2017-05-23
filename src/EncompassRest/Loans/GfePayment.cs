using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class GfePayment
    {
        public JsonNullable<decimal?> FixedRate { get; set; }
        public int? GfePaymentIndex { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> IndexRate { get; set; }
        public string IsBalanceReduced { get; set; }
        public string LoanTypeExplanation { get; set; }
        public JsonNullable<decimal?> MarginRate { get; set; }
        public JsonNullable<decimal?> MaximumDifference { get; set; }
        public JsonNullable<decimal?> MaximumRate { get; set; }
        public JsonNullable<decimal?> MinimumDifference { get; set; }
        public JsonNullable<decimal?> MinimumMonthlyPayment { get; set; }
        public JsonNullable<decimal?> MonthlyPaymentYear1 { get; set; }
        public JsonNullable<decimal?> MonthlyPaymentYear6 { get; set; }
        public JsonNullable<decimal?> MonthlyPaymentYear6Change { get; set; }
        public JsonNullable<decimal?> MonthlyPaymentYear6MaxChange { get; set; }
        public JsonNullable<bool?> NotOfferedIndicator { get; set; }
        public JsonNullable<decimal?> OwedAfter5Years { get; set; }
        public JsonNullable<decimal?> RateInMonth2 { get; set; }
        public JsonNullable<decimal?> ReducedLoanBalance { get; set; }
        public string ReducedStatus { get; set; }
    }
}