using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Gfe2010Fee
    {
        public string Gfe2010FeeParentType { get; set; }
        public string Gfe2010FeeType { get; set; }
        public int? Gfe2010FeeIndex { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public decimal? BorPaidAmount { get; set; }
        public decimal? SelPaidAmount { get; set; }
        public string PaidByType { get; set; }
        public bool? AprIndicator { get; set; }
        public string PtbType { get; set; }
        public decimal? GfeAmount { get; set; }
        public decimal? Rate { get; set; }
        public decimal? AdditionalAmount { get; set; }
        public bool? PocPtcIndicator { get; set; }
        public decimal? WholePoc { get; set; }
        public string WholePocPaidByType { get; set; }
        public bool? TitleServiceSelectIndicator { get; set; }
        public bool? BorrowerSelectIndicator { get; set; }
        public string PaidToName { get; set; }
        public bool? PropertyIndicator2015 { get; set; }
        public bool? InsuranceIndicator2015 { get; set; }
        public bool? TaxesIndicator2015 { get; set; }
        public bool? EscrowedIndicator2015 { get; set; }
        public decimal? TotalFeeAmount2015 { get; set; }
        public decimal? TotalFeePercentage2015 { get; set; }
        public int? LastDisclosedLoanEstimate2015 { get; set; }
        public decimal? LastDisclosedClosingDisclosure2015 { get; set; }
        public decimal? BorrowerFinanced2015 { get; set; }
        public decimal? BorrowerPTC2015 { get; set; }
        public decimal? BorrowerPAC2015 { get; set; }
        public decimal? BorrowerPOC2015 { get; set; }
        public decimal? BorrowerAmountPaid2015 { get; set; }
        public decimal? SellerPAC2015 { get; set; }
        public decimal? SellerPOC2015 { get; set; }
        public decimal? SellerAmountPaid2015 { get; set; }
        public decimal? BrokerPAC2015 { get; set; }
        public decimal? BrokerPOC2015 { get; set; }
        public decimal? BrokerAmountPaid2015 { get; set; }
        public decimal? LenderPAC2015 { get; set; }
        public decimal? LenderPOC2015 { get; set; }
        public decimal? LenderAmountPaid2015 { get; set; }
        public decimal? OtherPAC2015 { get; set; }
        public decimal? OtherPOC2015 { get; set; }
        public decimal? OtherAmountPaid2015 { get; set; }
        public decimal? TotalPaidByBLO2015 { get; set; }
        public bool? BorrowerCanShopForIndicator2015 { get; set; }
        public bool? BorrowerDidShopForIndicator2015 { get; set; }
        public bool? SellerCreditIndicator2015 { get; set; }
        public bool? SellerObligatedIndicator2015 { get; set; }
        public decimal? SellerObligatedAmount2015 { get; set; }
        public decimal? Sec32PointsAndFees2015 { get; set; }
        public decimal? RetainedAmount2015 { get; set; }
        public bool? OptionalIndicator2015 { get; set; }
        public int? NumberOfMonths { get; set; }
        public decimal? MonthlyPayment { get; set; }
        public bool? SimultaneousIssuanceIndicator2015 { get; set; }
        public decimal? UndiscountedInsurance2015 { get; set; }
        public bool? FinancedIndicator { get; set; }
        public string Id { get; set; }
    }
}