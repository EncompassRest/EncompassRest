using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class LoanEstimate2
    {
        public decimal? ActualLenderCredits { get; set; }
        public decimal? ActualSTDLETotalClosingCostJ { get; set; }
        public decimal? ActualSTDLESellerCredits { get; set; }
        public int? OriginationChargesSubTotal { get; set; }
        public int? ServicesYouNotShopSubTotal { get; set; }
        public int? ServicesYouShopSubTotal { get; set; }
        public int? TotalLoanCosts { get; set; }
        public decimal? UnroundedTotalLoanCosts { get; set; }
        public int? TaxesGovFeesSubTotal { get; set; }
        public int? PrepaidsSubTotal { get; set; }
        public int? InitialEscrowPaymentClosingSubTotal { get; set; }
        public int? OtherSubTotal { get; set; }
        public int? TotalOtherCosts { get; set; }
        public decimal? UnroundedTotalOtherCosts { get; set; }
        public int? TotalClosingCosts { get; set; }
        public int? TotalLoanAndOtherCosts { get; set; }
        public int? LenderCredits { get; set; }
        public decimal? ClosingCostsFinanced { get; set; }
        public decimal? DownPayment { get; set; }
        public decimal? FundsForBorrower { get; set; }
        public decimal? AdjustmentsOtherCredits { get; set; }
        public string AdjustmentsOtherCreditsDesc1 { get; set; }
        public decimal? AdjustmentsOtherCreditsAmt1 { get; set; }
        public string AdjustmentsOtherCreditsDesc2 { get; set; }
        public decimal? AdjustmentsOtherCreditsAmt2 { get; set; }
        public string AdjustmentsOtherCreditsDesc3 { get; set; }
        public decimal? AdjustmentsOtherCreditsAmt3 { get; set; }
        public string AdjustmentsOtherCreditsDesc4 { get; set; }
        public decimal? AdjustmentsOtherCreditsAmt4 { get; set; }
        public string AdjustmentsOtherCreditsDesc5 { get; set; }
        public decimal? AdjustmentsOtherCreditsAmt5 { get; set; }
        public string AdjustmentsOtherCreditsDesc6 { get; set; }
        public decimal? AdjustmentsOtherCreditsAmt6 { get; set; }
        public string AdjustmentsOtherCreditsDesc7 { get; set; }
        public decimal? AdjustmentsOtherCreditsAmt7 { get; set; }
        public string AdjustmentsOtherCreditsDesc8 { get; set; }
        public decimal? AdjustmentsOtherCreditsAmt8 { get; set; }
        public string AdjustmentsOtherCreditsDesc9 { get; set; }
        public decimal? AdjustmentsOtherCreditsAmt9 { get; set; }
        public string AdjustmentsOtherCreditsDesc10 { get; set; }
        public decimal? AdjustmentsOtherCreditsAmt10 { get; set; }
        public decimal? EstimatedCashToCloseSV { get; set; }
        public decimal? EstimatedCashToCloseAV { get; set; }
        public string FromOrToBorrower { get; set; }
        public bool? UseAlternate { get; set; }
        public decimal? ThirdPartyPaymentsNotOtherwiseDisclosed { get; set; }
        public bool? UseActualDownPaymentAndClosingCostsFinancedIndicator { get; set; }
        public int? EstimatedTotalPayoffsAndPaymentsAmount { get; set; }
        public string IndexMargin { get; set; }
        public string FirstChangeMonthSuffix { get; set; }
        public string SubseqChangeMonthSuffix { get; set; }
        public int? FirstChangeFrequencyMonth { get; set; }
        public int? SellerCreditAmount { get; set; }
        public string Id { get; set; }
    }
}