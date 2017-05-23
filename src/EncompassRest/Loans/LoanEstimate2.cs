using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class LoanEstimate2
    {
        public JsonNullable<decimal?> ActualLenderCredits { get; set; }
        public JsonNullable<decimal?> ActualSTDLESellerCredits { get; set; }
        public JsonNullable<decimal?> ActualSTDLETotalClosingCostJ { get; set; }
        public JsonNullable<decimal?> AdjustmentsOtherCredits { get; set; }
        public JsonNullable<decimal?> AdjustmentsOtherCreditsAmt1 { get; set; }
        public JsonNullable<decimal?> AdjustmentsOtherCreditsAmt10 { get; set; }
        public JsonNullable<decimal?> AdjustmentsOtherCreditsAmt2 { get; set; }
        public JsonNullable<decimal?> AdjustmentsOtherCreditsAmt3 { get; set; }
        public JsonNullable<decimal?> AdjustmentsOtherCreditsAmt4 { get; set; }
        public JsonNullable<decimal?> AdjustmentsOtherCreditsAmt5 { get; set; }
        public JsonNullable<decimal?> AdjustmentsOtherCreditsAmt6 { get; set; }
        public JsonNullable<decimal?> AdjustmentsOtherCreditsAmt7 { get; set; }
        public JsonNullable<decimal?> AdjustmentsOtherCreditsAmt8 { get; set; }
        public JsonNullable<decimal?> AdjustmentsOtherCreditsAmt9 { get; set; }
        public string AdjustmentsOtherCreditsDesc1 { get; set; }
        public string AdjustmentsOtherCreditsDesc10 { get; set; }
        public string AdjustmentsOtherCreditsDesc2 { get; set; }
        public string AdjustmentsOtherCreditsDesc3 { get; set; }
        public string AdjustmentsOtherCreditsDesc4 { get; set; }
        public string AdjustmentsOtherCreditsDesc5 { get; set; }
        public string AdjustmentsOtherCreditsDesc6 { get; set; }
        public string AdjustmentsOtherCreditsDesc7 { get; set; }
        public string AdjustmentsOtherCreditsDesc8 { get; set; }
        public string AdjustmentsOtherCreditsDesc9 { get; set; }
        public JsonNullable<decimal?> ClosingCostsFinanced { get; set; }
        public JsonNullable<decimal?> DownPayment { get; set; }
        public JsonNullable<decimal?> EstimatedCashToCloseAV { get; set; }
        public JsonNullable<decimal?> EstimatedCashToCloseSV { get; set; }
        public JsonNullable<int?> EstimatedTotalPayoffsAndPaymentsAmount { get; set; }
        public JsonNullable<int?> firstChangeFrequencyMonth { get; set; }
        public string firstChangeMonthSuffix { get; set; }
        public string FromOrToBorrower { get; set; }
        public JsonNullable<decimal?> FundsForBorrower { get; set; }
        public string Id { get; set; }
        public string IndexMargin { get; set; }
        public JsonNullable<int?> InitialEscrowPaymentClosingSubTotal { get; set; }
        public JsonNullable<int?> LenderCredits { get; set; }
        public JsonNullable<int?> OriginationChargesSubTotal { get; set; }
        public JsonNullable<int?> OtherSubTotal { get; set; }
        public JsonNullable<int?> PrepaidsSubTotal { get; set; }
        public JsonNullable<int?> SellerCreditAmount { get; set; }
        public JsonNullable<int?> ServicesYouNotShopSubTotal { get; set; }
        public JsonNullable<int?> ServicesYouShopSubTotal { get; set; }
        public string subseqChangeMonthSuffix { get; set; }
        public JsonNullable<int?> TaxesGovFeesSubTotal { get; set; }
        public JsonNullable<decimal?> ThirdPartyPaymentsNotOtherwiseDisclosed { get; set; }
        public JsonNullable<int?> TotalClosingCosts { get; set; }
        public JsonNullable<int?> TotalLoanAndOtherCosts { get; set; }
        public JsonNullable<int?> TotalLoanCosts { get; set; }
        public JsonNullable<int?> TotalOtherCosts { get; set; }
        public JsonNullable<decimal?> UnroundedTotalLoanCosts { get; set; }
        public JsonNullable<decimal?> UnroundedTotalOtherCosts { get; set; }
        public JsonNullable<bool?> UseActualDownPaymentAndClosingCostsFinancedIndicator { get; set; }
        public JsonNullable<bool?> UseAlternate { get; set; }
    }
}