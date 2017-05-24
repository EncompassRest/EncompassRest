using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LoanEstimate2
    {
        public Value<decimal?> ActualLenderCredits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualLenderCredits() => !ActualLenderCredits.Clean;
        public Value<decimal?> ActualSTDLESellerCredits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualSTDLESellerCredits() => !ActualSTDLESellerCredits.Clean;
        public Value<decimal?> ActualSTDLETotalClosingCostJ { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualSTDLETotalClosingCostJ() => !ActualSTDLETotalClosingCostJ.Clean;
        public Value<decimal?> AdjustmentsOtherCredits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCredits() => !AdjustmentsOtherCredits.Clean;
        public Value<decimal?> AdjustmentsOtherCreditsAmt1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCreditsAmt1() => !AdjustmentsOtherCreditsAmt1.Clean;
        public Value<decimal?> AdjustmentsOtherCreditsAmt10 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCreditsAmt10() => !AdjustmentsOtherCreditsAmt10.Clean;
        public Value<decimal?> AdjustmentsOtherCreditsAmt2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCreditsAmt2() => !AdjustmentsOtherCreditsAmt2.Clean;
        public Value<decimal?> AdjustmentsOtherCreditsAmt3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCreditsAmt3() => !AdjustmentsOtherCreditsAmt3.Clean;
        public Value<decimal?> AdjustmentsOtherCreditsAmt4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCreditsAmt4() => !AdjustmentsOtherCreditsAmt4.Clean;
        public Value<decimal?> AdjustmentsOtherCreditsAmt5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCreditsAmt5() => !AdjustmentsOtherCreditsAmt5.Clean;
        public Value<decimal?> AdjustmentsOtherCreditsAmt6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCreditsAmt6() => !AdjustmentsOtherCreditsAmt6.Clean;
        public Value<decimal?> AdjustmentsOtherCreditsAmt7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCreditsAmt7() => !AdjustmentsOtherCreditsAmt7.Clean;
        public Value<decimal?> AdjustmentsOtherCreditsAmt8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCreditsAmt8() => !AdjustmentsOtherCreditsAmt8.Clean;
        public Value<decimal?> AdjustmentsOtherCreditsAmt9 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCreditsAmt9() => !AdjustmentsOtherCreditsAmt9.Clean;
        public Value<string> AdjustmentsOtherCreditsDesc1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCreditsDesc1() => !AdjustmentsOtherCreditsDesc1.Clean;
        public Value<string> AdjustmentsOtherCreditsDesc10 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCreditsDesc10() => !AdjustmentsOtherCreditsDesc10.Clean;
        public Value<string> AdjustmentsOtherCreditsDesc2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCreditsDesc2() => !AdjustmentsOtherCreditsDesc2.Clean;
        public Value<string> AdjustmentsOtherCreditsDesc3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCreditsDesc3() => !AdjustmentsOtherCreditsDesc3.Clean;
        public Value<string> AdjustmentsOtherCreditsDesc4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCreditsDesc4() => !AdjustmentsOtherCreditsDesc4.Clean;
        public Value<string> AdjustmentsOtherCreditsDesc5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCreditsDesc5() => !AdjustmentsOtherCreditsDesc5.Clean;
        public Value<string> AdjustmentsOtherCreditsDesc6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCreditsDesc6() => !AdjustmentsOtherCreditsDesc6.Clean;
        public Value<string> AdjustmentsOtherCreditsDesc7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCreditsDesc7() => !AdjustmentsOtherCreditsDesc7.Clean;
        public Value<string> AdjustmentsOtherCreditsDesc8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCreditsDesc8() => !AdjustmentsOtherCreditsDesc8.Clean;
        public Value<string> AdjustmentsOtherCreditsDesc9 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsOtherCreditsDesc9() => !AdjustmentsOtherCreditsDesc9.Clean;
        public Value<decimal?> ClosingCostsFinanced { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostsFinanced() => !ClosingCostsFinanced.Clean;
        public Value<decimal?> DownPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDownPayment() => !DownPayment.Clean;
        public Value<decimal?> EstimatedCashToCloseAV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedCashToCloseAV() => !EstimatedCashToCloseAV.Clean;
        public Value<decimal?> EstimatedCashToCloseSV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedCashToCloseSV() => !EstimatedCashToCloseSV.Clean;
        public Value<int?> EstimatedTotalPayoffsAndPaymentsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedTotalPayoffsAndPaymentsAmount() => !EstimatedTotalPayoffsAndPaymentsAmount.Clean;
        public Value<int?> firstChangeFrequencyMonth { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializefirstChangeFrequencyMonth() => !firstChangeFrequencyMonth.Clean;
        public Value<string> firstChangeMonthSuffix { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializefirstChangeMonthSuffix() => !firstChangeMonthSuffix.Clean;
        public Value<string> FromOrToBorrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFromOrToBorrower() => !FromOrToBorrower.Clean;
        public Value<decimal?> FundsForBorrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundsForBorrower() => !FundsForBorrower.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> IndexMargin { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIndexMargin() => !IndexMargin.Clean;
        public Value<int?> InitialEscrowPaymentClosingSubTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialEscrowPaymentClosingSubTotal() => !InitialEscrowPaymentClosingSubTotal.Clean;
        public Value<int?> LenderCredits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderCredits() => !LenderCredits.Clean;
        public Value<int?> OriginationChargesSubTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationChargesSubTotal() => !OriginationChargesSubTotal.Clean;
        public Value<int?> OtherSubTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherSubTotal() => !OtherSubTotal.Clean;
        public Value<int?> PrepaidsSubTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaidsSubTotal() => !PrepaidsSubTotal.Clean;
        public Value<int?> SellerCreditAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerCreditAmount() => !SellerCreditAmount.Clean;
        public Value<int?> ServicesYouNotShopSubTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicesYouNotShopSubTotal() => !ServicesYouNotShopSubTotal.Clean;
        public Value<int?> ServicesYouShopSubTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicesYouShopSubTotal() => !ServicesYouShopSubTotal.Clean;
        public Value<string> subseqChangeMonthSuffix { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializesubseqChangeMonthSuffix() => !subseqChangeMonthSuffix.Clean;
        public Value<int?> TaxesGovFeesSubTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxesGovFeesSubTotal() => !TaxesGovFeesSubTotal.Clean;
        public Value<decimal?> ThirdPartyPaymentsNotOtherwiseDisclosed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeThirdPartyPaymentsNotOtherwiseDisclosed() => !ThirdPartyPaymentsNotOtherwiseDisclosed.Clean;
        public Value<int?> TotalClosingCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalClosingCosts() => !TotalClosingCosts.Clean;
        public Value<int?> TotalLoanAndOtherCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalLoanAndOtherCosts() => !TotalLoanAndOtherCosts.Clean;
        public Value<int?> TotalLoanCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalLoanCosts() => !TotalLoanCosts.Clean;
        public Value<int?> TotalOtherCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOtherCosts() => !TotalOtherCosts.Clean;
        public Value<decimal?> UnroundedTotalLoanCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnroundedTotalLoanCosts() => !UnroundedTotalLoanCosts.Clean;
        public Value<decimal?> UnroundedTotalOtherCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnroundedTotalOtherCosts() => !UnroundedTotalOtherCosts.Clean;
        public Value<bool?> UseActualDownPaymentAndClosingCostsFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUseActualDownPaymentAndClosingCostsFinancedIndicator() => !UseActualDownPaymentAndClosingCostsFinancedIndicator.Clean;
        public Value<bool?> UseAlternate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUseAlternate() => !UseAlternate.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = ActualLenderCredits.Clean
                    && ActualSTDLESellerCredits.Clean
                    && ActualSTDLETotalClosingCostJ.Clean
                    && AdjustmentsOtherCredits.Clean
                    && AdjustmentsOtherCreditsAmt1.Clean
                    && AdjustmentsOtherCreditsAmt10.Clean
                    && AdjustmentsOtherCreditsAmt2.Clean
                    && AdjustmentsOtherCreditsAmt3.Clean
                    && AdjustmentsOtherCreditsAmt4.Clean
                    && AdjustmentsOtherCreditsAmt5.Clean
                    && AdjustmentsOtherCreditsAmt6.Clean
                    && AdjustmentsOtherCreditsAmt7.Clean
                    && AdjustmentsOtherCreditsAmt8.Clean
                    && AdjustmentsOtherCreditsAmt9.Clean
                    && AdjustmentsOtherCreditsDesc1.Clean
                    && AdjustmentsOtherCreditsDesc10.Clean
                    && AdjustmentsOtherCreditsDesc2.Clean
                    && AdjustmentsOtherCreditsDesc3.Clean
                    && AdjustmentsOtherCreditsDesc4.Clean
                    && AdjustmentsOtherCreditsDesc5.Clean
                    && AdjustmentsOtherCreditsDesc6.Clean
                    && AdjustmentsOtherCreditsDesc7.Clean
                    && AdjustmentsOtherCreditsDesc8.Clean
                    && AdjustmentsOtherCreditsDesc9.Clean
                    && ClosingCostsFinanced.Clean
                    && DownPayment.Clean
                    && EstimatedCashToCloseAV.Clean
                    && EstimatedCashToCloseSV.Clean
                    && EstimatedTotalPayoffsAndPaymentsAmount.Clean
                    && firstChangeFrequencyMonth.Clean
                    && firstChangeMonthSuffix.Clean
                    && FromOrToBorrower.Clean
                    && FundsForBorrower.Clean
                    && Id.Clean
                    && IndexMargin.Clean
                    && InitialEscrowPaymentClosingSubTotal.Clean
                    && LenderCredits.Clean
                    && OriginationChargesSubTotal.Clean
                    && OtherSubTotal.Clean
                    && PrepaidsSubTotal.Clean
                    && SellerCreditAmount.Clean
                    && ServicesYouNotShopSubTotal.Clean
                    && ServicesYouShopSubTotal.Clean
                    && subseqChangeMonthSuffix.Clean
                    && TaxesGovFeesSubTotal.Clean
                    && ThirdPartyPaymentsNotOtherwiseDisclosed.Clean
                    && TotalClosingCosts.Clean
                    && TotalLoanAndOtherCosts.Clean
                    && TotalLoanCosts.Clean
                    && TotalOtherCosts.Clean
                    && UnroundedTotalLoanCosts.Clean
                    && UnroundedTotalOtherCosts.Clean
                    && UseActualDownPaymentAndClosingCostsFinancedIndicator.Clean
                    && UseAlternate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = ActualLenderCredits; v0.Clean = value; ActualLenderCredits = v0;
                var v1 = ActualSTDLESellerCredits; v1.Clean = value; ActualSTDLESellerCredits = v1;
                var v2 = ActualSTDLETotalClosingCostJ; v2.Clean = value; ActualSTDLETotalClosingCostJ = v2;
                var v3 = AdjustmentsOtherCredits; v3.Clean = value; AdjustmentsOtherCredits = v3;
                var v4 = AdjustmentsOtherCreditsAmt1; v4.Clean = value; AdjustmentsOtherCreditsAmt1 = v4;
                var v5 = AdjustmentsOtherCreditsAmt10; v5.Clean = value; AdjustmentsOtherCreditsAmt10 = v5;
                var v6 = AdjustmentsOtherCreditsAmt2; v6.Clean = value; AdjustmentsOtherCreditsAmt2 = v6;
                var v7 = AdjustmentsOtherCreditsAmt3; v7.Clean = value; AdjustmentsOtherCreditsAmt3 = v7;
                var v8 = AdjustmentsOtherCreditsAmt4; v8.Clean = value; AdjustmentsOtherCreditsAmt4 = v8;
                var v9 = AdjustmentsOtherCreditsAmt5; v9.Clean = value; AdjustmentsOtherCreditsAmt5 = v9;
                var v10 = AdjustmentsOtherCreditsAmt6; v10.Clean = value; AdjustmentsOtherCreditsAmt6 = v10;
                var v11 = AdjustmentsOtherCreditsAmt7; v11.Clean = value; AdjustmentsOtherCreditsAmt7 = v11;
                var v12 = AdjustmentsOtherCreditsAmt8; v12.Clean = value; AdjustmentsOtherCreditsAmt8 = v12;
                var v13 = AdjustmentsOtherCreditsAmt9; v13.Clean = value; AdjustmentsOtherCreditsAmt9 = v13;
                var v14 = AdjustmentsOtherCreditsDesc1; v14.Clean = value; AdjustmentsOtherCreditsDesc1 = v14;
                var v15 = AdjustmentsOtherCreditsDesc10; v15.Clean = value; AdjustmentsOtherCreditsDesc10 = v15;
                var v16 = AdjustmentsOtherCreditsDesc2; v16.Clean = value; AdjustmentsOtherCreditsDesc2 = v16;
                var v17 = AdjustmentsOtherCreditsDesc3; v17.Clean = value; AdjustmentsOtherCreditsDesc3 = v17;
                var v18 = AdjustmentsOtherCreditsDesc4; v18.Clean = value; AdjustmentsOtherCreditsDesc4 = v18;
                var v19 = AdjustmentsOtherCreditsDesc5; v19.Clean = value; AdjustmentsOtherCreditsDesc5 = v19;
                var v20 = AdjustmentsOtherCreditsDesc6; v20.Clean = value; AdjustmentsOtherCreditsDesc6 = v20;
                var v21 = AdjustmentsOtherCreditsDesc7; v21.Clean = value; AdjustmentsOtherCreditsDesc7 = v21;
                var v22 = AdjustmentsOtherCreditsDesc8; v22.Clean = value; AdjustmentsOtherCreditsDesc8 = v22;
                var v23 = AdjustmentsOtherCreditsDesc9; v23.Clean = value; AdjustmentsOtherCreditsDesc9 = v23;
                var v24 = ClosingCostsFinanced; v24.Clean = value; ClosingCostsFinanced = v24;
                var v25 = DownPayment; v25.Clean = value; DownPayment = v25;
                var v26 = EstimatedCashToCloseAV; v26.Clean = value; EstimatedCashToCloseAV = v26;
                var v27 = EstimatedCashToCloseSV; v27.Clean = value; EstimatedCashToCloseSV = v27;
                var v28 = EstimatedTotalPayoffsAndPaymentsAmount; v28.Clean = value; EstimatedTotalPayoffsAndPaymentsAmount = v28;
                var v29 = firstChangeFrequencyMonth; v29.Clean = value; firstChangeFrequencyMonth = v29;
                var v30 = firstChangeMonthSuffix; v30.Clean = value; firstChangeMonthSuffix = v30;
                var v31 = FromOrToBorrower; v31.Clean = value; FromOrToBorrower = v31;
                var v32 = FundsForBorrower; v32.Clean = value; FundsForBorrower = v32;
                var v33 = Id; v33.Clean = value; Id = v33;
                var v34 = IndexMargin; v34.Clean = value; IndexMargin = v34;
                var v35 = InitialEscrowPaymentClosingSubTotal; v35.Clean = value; InitialEscrowPaymentClosingSubTotal = v35;
                var v36 = LenderCredits; v36.Clean = value; LenderCredits = v36;
                var v37 = OriginationChargesSubTotal; v37.Clean = value; OriginationChargesSubTotal = v37;
                var v38 = OtherSubTotal; v38.Clean = value; OtherSubTotal = v38;
                var v39 = PrepaidsSubTotal; v39.Clean = value; PrepaidsSubTotal = v39;
                var v40 = SellerCreditAmount; v40.Clean = value; SellerCreditAmount = v40;
                var v41 = ServicesYouNotShopSubTotal; v41.Clean = value; ServicesYouNotShopSubTotal = v41;
                var v42 = ServicesYouShopSubTotal; v42.Clean = value; ServicesYouShopSubTotal = v42;
                var v43 = subseqChangeMonthSuffix; v43.Clean = value; subseqChangeMonthSuffix = v43;
                var v44 = TaxesGovFeesSubTotal; v44.Clean = value; TaxesGovFeesSubTotal = v44;
                var v45 = ThirdPartyPaymentsNotOtherwiseDisclosed; v45.Clean = value; ThirdPartyPaymentsNotOtherwiseDisclosed = v45;
                var v46 = TotalClosingCosts; v46.Clean = value; TotalClosingCosts = v46;
                var v47 = TotalLoanAndOtherCosts; v47.Clean = value; TotalLoanAndOtherCosts = v47;
                var v48 = TotalLoanCosts; v48.Clean = value; TotalLoanCosts = v48;
                var v49 = TotalOtherCosts; v49.Clean = value; TotalOtherCosts = v49;
                var v50 = UnroundedTotalLoanCosts; v50.Clean = value; UnroundedTotalLoanCosts = v50;
                var v51 = UnroundedTotalOtherCosts; v51.Clean = value; UnroundedTotalOtherCosts = v51;
                var v52 = UseActualDownPaymentAndClosingCostsFinancedIndicator; v52.Clean = value; UseActualDownPaymentAndClosingCostsFinancedIndicator = v52;
                var v53 = UseAlternate; v53.Clean = value; UseAlternate = v53;
                _settingClean = 0;
            }
        }
    }
}