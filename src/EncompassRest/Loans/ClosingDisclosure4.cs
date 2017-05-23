using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDisclosure4
    {
        public string DemandFeature { get; set; }
        public JsonNullable<bool?> EscrowIndicator { get; set; }
        public JsonNullable<decimal?> EstimatedPropertyCosts { get; set; }
        public string FirstChangeAmt { get; set; }
        public JsonNullable<decimal?> FirstChangeMaxAmt { get; set; }
        public JsonNullable<decimal?> FirstChangeMinAmt { get; set; }
        public string FirstChangePayment { get; set; }
        public JsonNullable<bool?> HOADuesIsEscrow { get; set; }
        public string Id { get; set; }
        public JsonNullable<bool?> IgnoreARMAdj { get; set; }
        public JsonNullable<decimal?> InitialEscrowPayment { get; set; }
        public JsonNullable<int?> InterestOnlyPaymentMonths { get; set; }
        public JsonNullable<bool?> InterestOnlyPayments { get; set; }
        public JsonNullable<int?> InterestRateAdjustments { get; set; }
        public JsonNullable<bool?> Lender { get; set; }
        public string MaximumPaymentAmt { get; set; }
        public string MaxPayment { get; set; }
        public JsonNullable<decimal?> MaxPaymentAmt { get; set; }
        public JsonNullable<decimal?> MonthlyEscrowPayment { get; set; }
        public string NegativeAmortization { get; set; }
        public JsonNullable<decimal?> NonEscrowedPropertyCosts1YearConsummation { get; set; }
        public JsonNullable<bool?> Other1 { get; set; }
        public JsonNullable<bool?> Other2 { get; set; }
        public JsonNullable<bool?> Other3 { get; set; }
        public string PartialPayment { get; set; }
        public string PartialPaymentHoldUntilComplete { get; set; }
        public string PartialPaymentNone { get; set; }
        public string SeasonalPaymentFromYr { get; set; }
        public JsonNullable<bool?> SeasonalPayments { get; set; }
        public JsonNullable<int?> StepPayment { get; set; }
        public JsonNullable<bool?> StepPayments { get; set; }
        public JsonNullable<decimal?> StepRateFirstChange { get; set; }
        public string SubsequentChanges { get; set; }
        public JsonNullable<decimal?> TotalDisbursed1YearConsummation { get; set; }
    }
}