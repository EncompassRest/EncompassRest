using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010Fee
    {
        public JsonNullable<decimal?> AdditionalAmount { get; set; }
        public JsonNullable<decimal?> Amount { get; set; }
        public JsonNullable<bool?> AprIndicator { get; set; }
        public JsonNullable<decimal?> BorPaidAmount { get; set; }
        public JsonNullable<decimal?> BorrowerAmountPaid2015 { get; set; }
        public JsonNullable<bool?> BorrowerCanShopForIndicator2015 { get; set; }
        public JsonNullable<bool?> BorrowerDidShopForIndicator2015 { get; set; }
        public JsonNullable<decimal?> BorrowerFinanced2015 { get; set; }
        public JsonNullable<decimal?> BorrowerPAC2015 { get; set; }
        public JsonNullable<decimal?> BorrowerPOC2015 { get; set; }
        public JsonNullable<decimal?> BorrowerPTC2015 { get; set; }
        public JsonNullable<bool?> BorrowerSelectIndicator { get; set; }
        public JsonNullable<decimal?> BrokerAmountPaid2015 { get; set; }
        public JsonNullable<decimal?> BrokerPAC2015 { get; set; }
        public JsonNullable<decimal?> BrokerPOC2015 { get; set; }
        public string Description { get; set; }
        public JsonNullable<bool?> EscrowedIndicator2015 { get; set; }
        public JsonNullable<bool?> FinancedIndicator { get; set; }
        public int? Gfe2010FeeIndex { get; set; }
        public string Gfe2010FeeParentType { get; set; }
        public string Gfe2010FeeType { get; set; }
        public JsonNullable<decimal?> GfeAmount { get; set; }
        public string Id { get; set; }
        public JsonNullable<bool?> InsuranceIndicator2015 { get; set; }
        public JsonNullable<decimal?> LastDisclosedClosingDisclosure2015 { get; set; }
        public JsonNullable<int?> LastDisclosedLoanEstimate2015 { get; set; }
        public JsonNullable<decimal?> LenderAmountPaid2015 { get; set; }
        public JsonNullable<decimal?> LenderPAC2015 { get; set; }
        public JsonNullable<decimal?> LenderPOC2015 { get; set; }
        public JsonNullable<decimal?> MonthlyPayment { get; set; }
        public JsonNullable<int?> NumberOfMonths { get; set; }
        public JsonNullable<bool?> OptionalIndicator2015 { get; set; }
        public JsonNullable<decimal?> OtherAmountPaid2015 { get; set; }
        public JsonNullable<decimal?> OtherPAC2015 { get; set; }
        public JsonNullable<decimal?> OtherPOC2015 { get; set; }
        public string PaidByType { get; set; }
        public string PaidToName { get; set; }
        public JsonNullable<bool?> PocPtcIndicator { get; set; }
        public JsonNullable<bool?> PropertyIndicator2015 { get; set; }
        public string PtbType { get; set; }
        public JsonNullable<decimal?> Rate { get; set; }
        public JsonNullable<decimal?> RetainedAmount2015 { get; set; }
        public JsonNullable<decimal?> Sec32PointsAndFees2015 { get; set; }
        public JsonNullable<decimal?> SellerAmountPaid2015 { get; set; }
        public JsonNullable<bool?> SellerCreditIndicator2015 { get; set; }
        public JsonNullable<decimal?> SellerObligatedAmount2015 { get; set; }
        public JsonNullable<bool?> SellerObligatedIndicator2015 { get; set; }
        public JsonNullable<decimal?> SellerPAC2015 { get; set; }
        public JsonNullable<decimal?> SellerPOC2015 { get; set; }
        public JsonNullable<decimal?> SelPaidAmount { get; set; }
        public JsonNullable<bool?> SimultaneousIssuanceIndicator2015 { get; set; }
        public JsonNullable<bool?> TaxesIndicator2015 { get; set; }
        public JsonNullable<bool?> TitleServiceSelectIndicator { get; set; }
        public JsonNullable<decimal?> TotalFeeAmount2015 { get; set; }
        public JsonNullable<decimal?> TotalFeePercentage2015 { get; set; }
        public JsonNullable<decimal?> TotalPaidByBLO2015 { get; set; }
        public JsonNullable<decimal?> UndiscountedInsurance2015 { get; set; }
        public JsonNullable<decimal?> WholePoc { get; set; }
        public string WholePocPaidByType { get; set; }
    }
}