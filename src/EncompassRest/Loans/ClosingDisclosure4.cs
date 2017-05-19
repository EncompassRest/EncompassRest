using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class ClosingDisclosure4
    {
        public string DemandFeature { get; set; }
        public string NegativeAmortization { get; set; }
        public string PartialPayment { get; set; }
        public bool? Other1 { get; set; }
        public bool? Other2 { get; set; }
        public bool? Other3 { get; set; }
        public bool? Lender { get; set; }
        public decimal? EstimatedPropertyCosts { get; set; }
        public bool? EscrowIndicator { get; set; }
        public decimal? MonthlyEscrowPayment { get; set; }
        public bool? InterestOnlyPayments { get; set; }
        public bool? StepPayments { get; set; }
        public int? StepPayment { get; set; }
        public bool? SeasonalPayments { get; set; }
        public string SeasonalPaymentFromYr { get; set; }
        public string FirstChangeAmt { get; set; }
        public bool? IgnoreARMAdj { get; set; }
        public string SubsequentChanges { get; set; }
        public string MaximumPaymentAmt { get; set; }
        public decimal? FirstChangeMinAmt { get; set; }
        public decimal? FirstChangeMaxAmt { get; set; }
        public string FirstChangePayment { get; set; }
        public decimal? MaxPaymentAmt { get; set; }
        public string MaxPayment { get; set; }
        public decimal? TotalDisbursed1YearConsummation { get; set; }
        public decimal? NonEscrowedPropertyCosts1YearConsummation { get; set; }
        public string PartialPaymentHoldUntilComplete { get; set; }
        public string PartialPaymentNone { get; set; }
        public decimal? InitialEscrowPayment { get; set; }
        public bool? HOADuesIsEscrow { get; set; }
        public int? InterestOnlyPaymentMonths { get; set; }
        public int? InterestRateAdjustments { get; set; }
        public decimal? StepRateFirstChange { get; set; }
        public string Id { get; set; }
    }
}