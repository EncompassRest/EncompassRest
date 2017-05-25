using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LoanEstimate2 : IClean
    {
        private Value<decimal?> _actualLenderCredits;
        public decimal? ActualLenderCredits { get { return _actualLenderCredits; } set { _actualLenderCredits = value; } }
        private Value<decimal?> _actualSTDLESellerCredits;
        public decimal? ActualSTDLESellerCredits { get { return _actualSTDLESellerCredits; } set { _actualSTDLESellerCredits = value; } }
        private Value<decimal?> _actualSTDLETotalClosingCostJ;
        public decimal? ActualSTDLETotalClosingCostJ { get { return _actualSTDLETotalClosingCostJ; } set { _actualSTDLETotalClosingCostJ = value; } }
        private Value<decimal?> _adjustmentsOtherCredits;
        public decimal? AdjustmentsOtherCredits { get { return _adjustmentsOtherCredits; } set { _adjustmentsOtherCredits = value; } }
        private Value<decimal?> _adjustmentsOtherCreditsAmt1;
        public decimal? AdjustmentsOtherCreditsAmt1 { get { return _adjustmentsOtherCreditsAmt1; } set { _adjustmentsOtherCreditsAmt1 = value; } }
        private Value<decimal?> _adjustmentsOtherCreditsAmt10;
        public decimal? AdjustmentsOtherCreditsAmt10 { get { return _adjustmentsOtherCreditsAmt10; } set { _adjustmentsOtherCreditsAmt10 = value; } }
        private Value<decimal?> _adjustmentsOtherCreditsAmt2;
        public decimal? AdjustmentsOtherCreditsAmt2 { get { return _adjustmentsOtherCreditsAmt2; } set { _adjustmentsOtherCreditsAmt2 = value; } }
        private Value<decimal?> _adjustmentsOtherCreditsAmt3;
        public decimal? AdjustmentsOtherCreditsAmt3 { get { return _adjustmentsOtherCreditsAmt3; } set { _adjustmentsOtherCreditsAmt3 = value; } }
        private Value<decimal?> _adjustmentsOtherCreditsAmt4;
        public decimal? AdjustmentsOtherCreditsAmt4 { get { return _adjustmentsOtherCreditsAmt4; } set { _adjustmentsOtherCreditsAmt4 = value; } }
        private Value<decimal?> _adjustmentsOtherCreditsAmt5;
        public decimal? AdjustmentsOtherCreditsAmt5 { get { return _adjustmentsOtherCreditsAmt5; } set { _adjustmentsOtherCreditsAmt5 = value; } }
        private Value<decimal?> _adjustmentsOtherCreditsAmt6;
        public decimal? AdjustmentsOtherCreditsAmt6 { get { return _adjustmentsOtherCreditsAmt6; } set { _adjustmentsOtherCreditsAmt6 = value; } }
        private Value<decimal?> _adjustmentsOtherCreditsAmt7;
        public decimal? AdjustmentsOtherCreditsAmt7 { get { return _adjustmentsOtherCreditsAmt7; } set { _adjustmentsOtherCreditsAmt7 = value; } }
        private Value<decimal?> _adjustmentsOtherCreditsAmt8;
        public decimal? AdjustmentsOtherCreditsAmt8 { get { return _adjustmentsOtherCreditsAmt8; } set { _adjustmentsOtherCreditsAmt8 = value; } }
        private Value<decimal?> _adjustmentsOtherCreditsAmt9;
        public decimal? AdjustmentsOtherCreditsAmt9 { get { return _adjustmentsOtherCreditsAmt9; } set { _adjustmentsOtherCreditsAmt9 = value; } }
        private Value<string> _adjustmentsOtherCreditsDesc1;
        public string AdjustmentsOtherCreditsDesc1 { get { return _adjustmentsOtherCreditsDesc1; } set { _adjustmentsOtherCreditsDesc1 = value; } }
        private Value<string> _adjustmentsOtherCreditsDesc10;
        public string AdjustmentsOtherCreditsDesc10 { get { return _adjustmentsOtherCreditsDesc10; } set { _adjustmentsOtherCreditsDesc10 = value; } }
        private Value<string> _adjustmentsOtherCreditsDesc2;
        public string AdjustmentsOtherCreditsDesc2 { get { return _adjustmentsOtherCreditsDesc2; } set { _adjustmentsOtherCreditsDesc2 = value; } }
        private Value<string> _adjustmentsOtherCreditsDesc3;
        public string AdjustmentsOtherCreditsDesc3 { get { return _adjustmentsOtherCreditsDesc3; } set { _adjustmentsOtherCreditsDesc3 = value; } }
        private Value<string> _adjustmentsOtherCreditsDesc4;
        public string AdjustmentsOtherCreditsDesc4 { get { return _adjustmentsOtherCreditsDesc4; } set { _adjustmentsOtherCreditsDesc4 = value; } }
        private Value<string> _adjustmentsOtherCreditsDesc5;
        public string AdjustmentsOtherCreditsDesc5 { get { return _adjustmentsOtherCreditsDesc5; } set { _adjustmentsOtherCreditsDesc5 = value; } }
        private Value<string> _adjustmentsOtherCreditsDesc6;
        public string AdjustmentsOtherCreditsDesc6 { get { return _adjustmentsOtherCreditsDesc6; } set { _adjustmentsOtherCreditsDesc6 = value; } }
        private Value<string> _adjustmentsOtherCreditsDesc7;
        public string AdjustmentsOtherCreditsDesc7 { get { return _adjustmentsOtherCreditsDesc7; } set { _adjustmentsOtherCreditsDesc7 = value; } }
        private Value<string> _adjustmentsOtherCreditsDesc8;
        public string AdjustmentsOtherCreditsDesc8 { get { return _adjustmentsOtherCreditsDesc8; } set { _adjustmentsOtherCreditsDesc8 = value; } }
        private Value<string> _adjustmentsOtherCreditsDesc9;
        public string AdjustmentsOtherCreditsDesc9 { get { return _adjustmentsOtherCreditsDesc9; } set { _adjustmentsOtherCreditsDesc9 = value; } }
        private Value<decimal?> _closingCostsFinanced;
        public decimal? ClosingCostsFinanced { get { return _closingCostsFinanced; } set { _closingCostsFinanced = value; } }
        private Value<decimal?> _downPayment;
        public decimal? DownPayment { get { return _downPayment; } set { _downPayment = value; } }
        private Value<decimal?> _estimatedCashToCloseAV;
        public decimal? EstimatedCashToCloseAV { get { return _estimatedCashToCloseAV; } set { _estimatedCashToCloseAV = value; } }
        private Value<decimal?> _estimatedCashToCloseSV;
        public decimal? EstimatedCashToCloseSV { get { return _estimatedCashToCloseSV; } set { _estimatedCashToCloseSV = value; } }
        private Value<int?> _estimatedTotalPayoffsAndPaymentsAmount;
        public int? EstimatedTotalPayoffsAndPaymentsAmount { get { return _estimatedTotalPayoffsAndPaymentsAmount; } set { _estimatedTotalPayoffsAndPaymentsAmount = value; } }
        private Value<int?> _firstChangeFrequencyMonth;
        public int? firstChangeFrequencyMonth { get { return _firstChangeFrequencyMonth; } set { _firstChangeFrequencyMonth = value; } }
        private Value<string> _firstChangeMonthSuffix;
        public string firstChangeMonthSuffix { get { return _firstChangeMonthSuffix; } set { _firstChangeMonthSuffix = value; } }
        private Value<string> _fromOrToBorrower;
        public string FromOrToBorrower { get { return _fromOrToBorrower; } set { _fromOrToBorrower = value; } }
        private Value<decimal?> _fundsForBorrower;
        public decimal? FundsForBorrower { get { return _fundsForBorrower; } set { _fundsForBorrower = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _indexMargin;
        public string IndexMargin { get { return _indexMargin; } set { _indexMargin = value; } }
        private Value<int?> _initialEscrowPaymentClosingSubTotal;
        public int? InitialEscrowPaymentClosingSubTotal { get { return _initialEscrowPaymentClosingSubTotal; } set { _initialEscrowPaymentClosingSubTotal = value; } }
        private Value<int?> _lenderCredits;
        public int? LenderCredits { get { return _lenderCredits; } set { _lenderCredits = value; } }
        private Value<int?> _originationChargesSubTotal;
        public int? OriginationChargesSubTotal { get { return _originationChargesSubTotal; } set { _originationChargesSubTotal = value; } }
        private Value<int?> _otherSubTotal;
        public int? OtherSubTotal { get { return _otherSubTotal; } set { _otherSubTotal = value; } }
        private Value<int?> _prepaidsSubTotal;
        public int? PrepaidsSubTotal { get { return _prepaidsSubTotal; } set { _prepaidsSubTotal = value; } }
        private Value<int?> _sellerCreditAmount;
        public int? SellerCreditAmount { get { return _sellerCreditAmount; } set { _sellerCreditAmount = value; } }
        private Value<int?> _servicesYouNotShopSubTotal;
        public int? ServicesYouNotShopSubTotal { get { return _servicesYouNotShopSubTotal; } set { _servicesYouNotShopSubTotal = value; } }
        private Value<int?> _servicesYouShopSubTotal;
        public int? ServicesYouShopSubTotal { get { return _servicesYouShopSubTotal; } set { _servicesYouShopSubTotal = value; } }
        private Value<string> _subseqChangeMonthSuffix;
        public string subseqChangeMonthSuffix { get { return _subseqChangeMonthSuffix; } set { _subseqChangeMonthSuffix = value; } }
        private Value<int?> _taxesGovFeesSubTotal;
        public int? TaxesGovFeesSubTotal { get { return _taxesGovFeesSubTotal; } set { _taxesGovFeesSubTotal = value; } }
        private Value<decimal?> _thirdPartyPaymentsNotOtherwiseDisclosed;
        public decimal? ThirdPartyPaymentsNotOtherwiseDisclosed { get { return _thirdPartyPaymentsNotOtherwiseDisclosed; } set { _thirdPartyPaymentsNotOtherwiseDisclosed = value; } }
        private Value<int?> _totalClosingCosts;
        public int? TotalClosingCosts { get { return _totalClosingCosts; } set { _totalClosingCosts = value; } }
        private Value<int?> _totalLoanAndOtherCosts;
        public int? TotalLoanAndOtherCosts { get { return _totalLoanAndOtherCosts; } set { _totalLoanAndOtherCosts = value; } }
        private Value<int?> _totalLoanCosts;
        public int? TotalLoanCosts { get { return _totalLoanCosts; } set { _totalLoanCosts = value; } }
        private Value<int?> _totalOtherCosts;
        public int? TotalOtherCosts { get { return _totalOtherCosts; } set { _totalOtherCosts = value; } }
        private Value<decimal?> _unroundedTotalLoanCosts;
        public decimal? UnroundedTotalLoanCosts { get { return _unroundedTotalLoanCosts; } set { _unroundedTotalLoanCosts = value; } }
        private Value<decimal?> _unroundedTotalOtherCosts;
        public decimal? UnroundedTotalOtherCosts { get { return _unroundedTotalOtherCosts; } set { _unroundedTotalOtherCosts = value; } }
        private Value<bool?> _useActualDownPaymentAndClosingCostsFinancedIndicator;
        public bool? UseActualDownPaymentAndClosingCostsFinancedIndicator { get { return _useActualDownPaymentAndClosingCostsFinancedIndicator; } set { _useActualDownPaymentAndClosingCostsFinancedIndicator = value; } }
        private Value<bool?> _useAlternate;
        public bool? UseAlternate { get { return _useAlternate; } set { _useAlternate = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _actualLenderCredits.Clean
                    && _actualSTDLESellerCredits.Clean
                    && _actualSTDLETotalClosingCostJ.Clean
                    && _adjustmentsOtherCredits.Clean
                    && _adjustmentsOtherCreditsAmt1.Clean
                    && _adjustmentsOtherCreditsAmt10.Clean
                    && _adjustmentsOtherCreditsAmt2.Clean
                    && _adjustmentsOtherCreditsAmt3.Clean
                    && _adjustmentsOtherCreditsAmt4.Clean
                    && _adjustmentsOtherCreditsAmt5.Clean
                    && _adjustmentsOtherCreditsAmt6.Clean
                    && _adjustmentsOtherCreditsAmt7.Clean
                    && _adjustmentsOtherCreditsAmt8.Clean
                    && _adjustmentsOtherCreditsAmt9.Clean
                    && _adjustmentsOtherCreditsDesc1.Clean
                    && _adjustmentsOtherCreditsDesc10.Clean
                    && _adjustmentsOtherCreditsDesc2.Clean
                    && _adjustmentsOtherCreditsDesc3.Clean
                    && _adjustmentsOtherCreditsDesc4.Clean
                    && _adjustmentsOtherCreditsDesc5.Clean
                    && _adjustmentsOtherCreditsDesc6.Clean
                    && _adjustmentsOtherCreditsDesc7.Clean
                    && _adjustmentsOtherCreditsDesc8.Clean
                    && _adjustmentsOtherCreditsDesc9.Clean
                    && _closingCostsFinanced.Clean
                    && _downPayment.Clean
                    && _estimatedCashToCloseAV.Clean
                    && _estimatedCashToCloseSV.Clean
                    && _estimatedTotalPayoffsAndPaymentsAmount.Clean
                    && _firstChangeFrequencyMonth.Clean
                    && _firstChangeMonthSuffix.Clean
                    && _fromOrToBorrower.Clean
                    && _fundsForBorrower.Clean
                    && _id.Clean
                    && _indexMargin.Clean
                    && _initialEscrowPaymentClosingSubTotal.Clean
                    && _lenderCredits.Clean
                    && _originationChargesSubTotal.Clean
                    && _otherSubTotal.Clean
                    && _prepaidsSubTotal.Clean
                    && _sellerCreditAmount.Clean
                    && _servicesYouNotShopSubTotal.Clean
                    && _servicesYouShopSubTotal.Clean
                    && _subseqChangeMonthSuffix.Clean
                    && _taxesGovFeesSubTotal.Clean
                    && _thirdPartyPaymentsNotOtherwiseDisclosed.Clean
                    && _totalClosingCosts.Clean
                    && _totalLoanAndOtherCosts.Clean
                    && _totalLoanCosts.Clean
                    && _totalOtherCosts.Clean
                    && _unroundedTotalLoanCosts.Clean
                    && _unroundedTotalOtherCosts.Clean
                    && _useActualDownPaymentAndClosingCostsFinancedIndicator.Clean
                    && _useAlternate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _actualLenderCredits; v0.Clean = value; _actualLenderCredits = v0;
                var v1 = _actualSTDLESellerCredits; v1.Clean = value; _actualSTDLESellerCredits = v1;
                var v2 = _actualSTDLETotalClosingCostJ; v2.Clean = value; _actualSTDLETotalClosingCostJ = v2;
                var v3 = _adjustmentsOtherCredits; v3.Clean = value; _adjustmentsOtherCredits = v3;
                var v4 = _adjustmentsOtherCreditsAmt1; v4.Clean = value; _adjustmentsOtherCreditsAmt1 = v4;
                var v5 = _adjustmentsOtherCreditsAmt10; v5.Clean = value; _adjustmentsOtherCreditsAmt10 = v5;
                var v6 = _adjustmentsOtherCreditsAmt2; v6.Clean = value; _adjustmentsOtherCreditsAmt2 = v6;
                var v7 = _adjustmentsOtherCreditsAmt3; v7.Clean = value; _adjustmentsOtherCreditsAmt3 = v7;
                var v8 = _adjustmentsOtherCreditsAmt4; v8.Clean = value; _adjustmentsOtherCreditsAmt4 = v8;
                var v9 = _adjustmentsOtherCreditsAmt5; v9.Clean = value; _adjustmentsOtherCreditsAmt5 = v9;
                var v10 = _adjustmentsOtherCreditsAmt6; v10.Clean = value; _adjustmentsOtherCreditsAmt6 = v10;
                var v11 = _adjustmentsOtherCreditsAmt7; v11.Clean = value; _adjustmentsOtherCreditsAmt7 = v11;
                var v12 = _adjustmentsOtherCreditsAmt8; v12.Clean = value; _adjustmentsOtherCreditsAmt8 = v12;
                var v13 = _adjustmentsOtherCreditsAmt9; v13.Clean = value; _adjustmentsOtherCreditsAmt9 = v13;
                var v14 = _adjustmentsOtherCreditsDesc1; v14.Clean = value; _adjustmentsOtherCreditsDesc1 = v14;
                var v15 = _adjustmentsOtherCreditsDesc10; v15.Clean = value; _adjustmentsOtherCreditsDesc10 = v15;
                var v16 = _adjustmentsOtherCreditsDesc2; v16.Clean = value; _adjustmentsOtherCreditsDesc2 = v16;
                var v17 = _adjustmentsOtherCreditsDesc3; v17.Clean = value; _adjustmentsOtherCreditsDesc3 = v17;
                var v18 = _adjustmentsOtherCreditsDesc4; v18.Clean = value; _adjustmentsOtherCreditsDesc4 = v18;
                var v19 = _adjustmentsOtherCreditsDesc5; v19.Clean = value; _adjustmentsOtherCreditsDesc5 = v19;
                var v20 = _adjustmentsOtherCreditsDesc6; v20.Clean = value; _adjustmentsOtherCreditsDesc6 = v20;
                var v21 = _adjustmentsOtherCreditsDesc7; v21.Clean = value; _adjustmentsOtherCreditsDesc7 = v21;
                var v22 = _adjustmentsOtherCreditsDesc8; v22.Clean = value; _adjustmentsOtherCreditsDesc8 = v22;
                var v23 = _adjustmentsOtherCreditsDesc9; v23.Clean = value; _adjustmentsOtherCreditsDesc9 = v23;
                var v24 = _closingCostsFinanced; v24.Clean = value; _closingCostsFinanced = v24;
                var v25 = _downPayment; v25.Clean = value; _downPayment = v25;
                var v26 = _estimatedCashToCloseAV; v26.Clean = value; _estimatedCashToCloseAV = v26;
                var v27 = _estimatedCashToCloseSV; v27.Clean = value; _estimatedCashToCloseSV = v27;
                var v28 = _estimatedTotalPayoffsAndPaymentsAmount; v28.Clean = value; _estimatedTotalPayoffsAndPaymentsAmount = v28;
                var v29 = _firstChangeFrequencyMonth; v29.Clean = value; _firstChangeFrequencyMonth = v29;
                var v30 = _firstChangeMonthSuffix; v30.Clean = value; _firstChangeMonthSuffix = v30;
                var v31 = _fromOrToBorrower; v31.Clean = value; _fromOrToBorrower = v31;
                var v32 = _fundsForBorrower; v32.Clean = value; _fundsForBorrower = v32;
                var v33 = _id; v33.Clean = value; _id = v33;
                var v34 = _indexMargin; v34.Clean = value; _indexMargin = v34;
                var v35 = _initialEscrowPaymentClosingSubTotal; v35.Clean = value; _initialEscrowPaymentClosingSubTotal = v35;
                var v36 = _lenderCredits; v36.Clean = value; _lenderCredits = v36;
                var v37 = _originationChargesSubTotal; v37.Clean = value; _originationChargesSubTotal = v37;
                var v38 = _otherSubTotal; v38.Clean = value; _otherSubTotal = v38;
                var v39 = _prepaidsSubTotal; v39.Clean = value; _prepaidsSubTotal = v39;
                var v40 = _sellerCreditAmount; v40.Clean = value; _sellerCreditAmount = v40;
                var v41 = _servicesYouNotShopSubTotal; v41.Clean = value; _servicesYouNotShopSubTotal = v41;
                var v42 = _servicesYouShopSubTotal; v42.Clean = value; _servicesYouShopSubTotal = v42;
                var v43 = _subseqChangeMonthSuffix; v43.Clean = value; _subseqChangeMonthSuffix = v43;
                var v44 = _taxesGovFeesSubTotal; v44.Clean = value; _taxesGovFeesSubTotal = v44;
                var v45 = _thirdPartyPaymentsNotOtherwiseDisclosed; v45.Clean = value; _thirdPartyPaymentsNotOtherwiseDisclosed = v45;
                var v46 = _totalClosingCosts; v46.Clean = value; _totalClosingCosts = v46;
                var v47 = _totalLoanAndOtherCosts; v47.Clean = value; _totalLoanAndOtherCosts = v47;
                var v48 = _totalLoanCosts; v48.Clean = value; _totalLoanCosts = v48;
                var v49 = _totalOtherCosts; v49.Clean = value; _totalOtherCosts = v49;
                var v50 = _unroundedTotalLoanCosts; v50.Clean = value; _unroundedTotalLoanCosts = v50;
                var v51 = _unroundedTotalOtherCosts; v51.Clean = value; _unroundedTotalOtherCosts = v51;
                var v52 = _useActualDownPaymentAndClosingCostsFinancedIndicator; v52.Clean = value; _useActualDownPaymentAndClosingCostsFinancedIndicator = v52;
                var v53 = _useAlternate; v53.Clean = value; _useAlternate = v53;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}