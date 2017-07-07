using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
        private Value<bool?> _itemizeServiceSectionCType;
        public bool? ItemizeServiceSectionCType { get { return _itemizeServiceSectionCType; } set { _itemizeServiceSectionCType = value; } }
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
                    && _itemizeServiceSectionCType.Clean
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
                var actualLenderCredits = _actualLenderCredits; actualLenderCredits.Clean = value; _actualLenderCredits = actualLenderCredits;
                var actualSTDLESellerCredits = _actualSTDLESellerCredits; actualSTDLESellerCredits.Clean = value; _actualSTDLESellerCredits = actualSTDLESellerCredits;
                var actualSTDLETotalClosingCostJ = _actualSTDLETotalClosingCostJ; actualSTDLETotalClosingCostJ.Clean = value; _actualSTDLETotalClosingCostJ = actualSTDLETotalClosingCostJ;
                var adjustmentsOtherCredits = _adjustmentsOtherCredits; adjustmentsOtherCredits.Clean = value; _adjustmentsOtherCredits = adjustmentsOtherCredits;
                var adjustmentsOtherCreditsAmt1 = _adjustmentsOtherCreditsAmt1; adjustmentsOtherCreditsAmt1.Clean = value; _adjustmentsOtherCreditsAmt1 = adjustmentsOtherCreditsAmt1;
                var adjustmentsOtherCreditsAmt10 = _adjustmentsOtherCreditsAmt10; adjustmentsOtherCreditsAmt10.Clean = value; _adjustmentsOtherCreditsAmt10 = adjustmentsOtherCreditsAmt10;
                var adjustmentsOtherCreditsAmt2 = _adjustmentsOtherCreditsAmt2; adjustmentsOtherCreditsAmt2.Clean = value; _adjustmentsOtherCreditsAmt2 = adjustmentsOtherCreditsAmt2;
                var adjustmentsOtherCreditsAmt3 = _adjustmentsOtherCreditsAmt3; adjustmentsOtherCreditsAmt3.Clean = value; _adjustmentsOtherCreditsAmt3 = adjustmentsOtherCreditsAmt3;
                var adjustmentsOtherCreditsAmt4 = _adjustmentsOtherCreditsAmt4; adjustmentsOtherCreditsAmt4.Clean = value; _adjustmentsOtherCreditsAmt4 = adjustmentsOtherCreditsAmt4;
                var adjustmentsOtherCreditsAmt5 = _adjustmentsOtherCreditsAmt5; adjustmentsOtherCreditsAmt5.Clean = value; _adjustmentsOtherCreditsAmt5 = adjustmentsOtherCreditsAmt5;
                var adjustmentsOtherCreditsAmt6 = _adjustmentsOtherCreditsAmt6; adjustmentsOtherCreditsAmt6.Clean = value; _adjustmentsOtherCreditsAmt6 = adjustmentsOtherCreditsAmt6;
                var adjustmentsOtherCreditsAmt7 = _adjustmentsOtherCreditsAmt7; adjustmentsOtherCreditsAmt7.Clean = value; _adjustmentsOtherCreditsAmt7 = adjustmentsOtherCreditsAmt7;
                var adjustmentsOtherCreditsAmt8 = _adjustmentsOtherCreditsAmt8; adjustmentsOtherCreditsAmt8.Clean = value; _adjustmentsOtherCreditsAmt8 = adjustmentsOtherCreditsAmt8;
                var adjustmentsOtherCreditsAmt9 = _adjustmentsOtherCreditsAmt9; adjustmentsOtherCreditsAmt9.Clean = value; _adjustmentsOtherCreditsAmt9 = adjustmentsOtherCreditsAmt9;
                var adjustmentsOtherCreditsDesc1 = _adjustmentsOtherCreditsDesc1; adjustmentsOtherCreditsDesc1.Clean = value; _adjustmentsOtherCreditsDesc1 = adjustmentsOtherCreditsDesc1;
                var adjustmentsOtherCreditsDesc10 = _adjustmentsOtherCreditsDesc10; adjustmentsOtherCreditsDesc10.Clean = value; _adjustmentsOtherCreditsDesc10 = adjustmentsOtherCreditsDesc10;
                var adjustmentsOtherCreditsDesc2 = _adjustmentsOtherCreditsDesc2; adjustmentsOtherCreditsDesc2.Clean = value; _adjustmentsOtherCreditsDesc2 = adjustmentsOtherCreditsDesc2;
                var adjustmentsOtherCreditsDesc3 = _adjustmentsOtherCreditsDesc3; adjustmentsOtherCreditsDesc3.Clean = value; _adjustmentsOtherCreditsDesc3 = adjustmentsOtherCreditsDesc3;
                var adjustmentsOtherCreditsDesc4 = _adjustmentsOtherCreditsDesc4; adjustmentsOtherCreditsDesc4.Clean = value; _adjustmentsOtherCreditsDesc4 = adjustmentsOtherCreditsDesc4;
                var adjustmentsOtherCreditsDesc5 = _adjustmentsOtherCreditsDesc5; adjustmentsOtherCreditsDesc5.Clean = value; _adjustmentsOtherCreditsDesc5 = adjustmentsOtherCreditsDesc5;
                var adjustmentsOtherCreditsDesc6 = _adjustmentsOtherCreditsDesc6; adjustmentsOtherCreditsDesc6.Clean = value; _adjustmentsOtherCreditsDesc6 = adjustmentsOtherCreditsDesc6;
                var adjustmentsOtherCreditsDesc7 = _adjustmentsOtherCreditsDesc7; adjustmentsOtherCreditsDesc7.Clean = value; _adjustmentsOtherCreditsDesc7 = adjustmentsOtherCreditsDesc7;
                var adjustmentsOtherCreditsDesc8 = _adjustmentsOtherCreditsDesc8; adjustmentsOtherCreditsDesc8.Clean = value; _adjustmentsOtherCreditsDesc8 = adjustmentsOtherCreditsDesc8;
                var adjustmentsOtherCreditsDesc9 = _adjustmentsOtherCreditsDesc9; adjustmentsOtherCreditsDesc9.Clean = value; _adjustmentsOtherCreditsDesc9 = adjustmentsOtherCreditsDesc9;
                var closingCostsFinanced = _closingCostsFinanced; closingCostsFinanced.Clean = value; _closingCostsFinanced = closingCostsFinanced;
                var downPayment = _downPayment; downPayment.Clean = value; _downPayment = downPayment;
                var estimatedCashToCloseAV = _estimatedCashToCloseAV; estimatedCashToCloseAV.Clean = value; _estimatedCashToCloseAV = estimatedCashToCloseAV;
                var estimatedCashToCloseSV = _estimatedCashToCloseSV; estimatedCashToCloseSV.Clean = value; _estimatedCashToCloseSV = estimatedCashToCloseSV;
                var estimatedTotalPayoffsAndPaymentsAmount = _estimatedTotalPayoffsAndPaymentsAmount; estimatedTotalPayoffsAndPaymentsAmount.Clean = value; _estimatedTotalPayoffsAndPaymentsAmount = estimatedTotalPayoffsAndPaymentsAmount;
                var firstChangeFrequencyMonth = _firstChangeFrequencyMonth; firstChangeFrequencyMonth.Clean = value; _firstChangeFrequencyMonth = firstChangeFrequencyMonth;
                var firstChangeMonthSuffix = _firstChangeMonthSuffix; firstChangeMonthSuffix.Clean = value; _firstChangeMonthSuffix = firstChangeMonthSuffix;
                var fromOrToBorrower = _fromOrToBorrower; fromOrToBorrower.Clean = value; _fromOrToBorrower = fromOrToBorrower;
                var fundsForBorrower = _fundsForBorrower; fundsForBorrower.Clean = value; _fundsForBorrower = fundsForBorrower;
                var id = _id; id.Clean = value; _id = id;
                var indexMargin = _indexMargin; indexMargin.Clean = value; _indexMargin = indexMargin;
                var initialEscrowPaymentClosingSubTotal = _initialEscrowPaymentClosingSubTotal; initialEscrowPaymentClosingSubTotal.Clean = value; _initialEscrowPaymentClosingSubTotal = initialEscrowPaymentClosingSubTotal;
                var itemizeServiceSectionCType = _itemizeServiceSectionCType; itemizeServiceSectionCType.Clean = value; _itemizeServiceSectionCType = itemizeServiceSectionCType;
                var lenderCredits = _lenderCredits; lenderCredits.Clean = value; _lenderCredits = lenderCredits;
                var originationChargesSubTotal = _originationChargesSubTotal; originationChargesSubTotal.Clean = value; _originationChargesSubTotal = originationChargesSubTotal;
                var otherSubTotal = _otherSubTotal; otherSubTotal.Clean = value; _otherSubTotal = otherSubTotal;
                var prepaidsSubTotal = _prepaidsSubTotal; prepaidsSubTotal.Clean = value; _prepaidsSubTotal = prepaidsSubTotal;
                var sellerCreditAmount = _sellerCreditAmount; sellerCreditAmount.Clean = value; _sellerCreditAmount = sellerCreditAmount;
                var servicesYouNotShopSubTotal = _servicesYouNotShopSubTotal; servicesYouNotShopSubTotal.Clean = value; _servicesYouNotShopSubTotal = servicesYouNotShopSubTotal;
                var servicesYouShopSubTotal = _servicesYouShopSubTotal; servicesYouShopSubTotal.Clean = value; _servicesYouShopSubTotal = servicesYouShopSubTotal;
                var subseqChangeMonthSuffix = _subseqChangeMonthSuffix; subseqChangeMonthSuffix.Clean = value; _subseqChangeMonthSuffix = subseqChangeMonthSuffix;
                var taxesGovFeesSubTotal = _taxesGovFeesSubTotal; taxesGovFeesSubTotal.Clean = value; _taxesGovFeesSubTotal = taxesGovFeesSubTotal;
                var thirdPartyPaymentsNotOtherwiseDisclosed = _thirdPartyPaymentsNotOtherwiseDisclosed; thirdPartyPaymentsNotOtherwiseDisclosed.Clean = value; _thirdPartyPaymentsNotOtherwiseDisclosed = thirdPartyPaymentsNotOtherwiseDisclosed;
                var totalClosingCosts = _totalClosingCosts; totalClosingCosts.Clean = value; _totalClosingCosts = totalClosingCosts;
                var totalLoanAndOtherCosts = _totalLoanAndOtherCosts; totalLoanAndOtherCosts.Clean = value; _totalLoanAndOtherCosts = totalLoanAndOtherCosts;
                var totalLoanCosts = _totalLoanCosts; totalLoanCosts.Clean = value; _totalLoanCosts = totalLoanCosts;
                var totalOtherCosts = _totalOtherCosts; totalOtherCosts.Clean = value; _totalOtherCosts = totalOtherCosts;
                var unroundedTotalLoanCosts = _unroundedTotalLoanCosts; unroundedTotalLoanCosts.Clean = value; _unroundedTotalLoanCosts = unroundedTotalLoanCosts;
                var unroundedTotalOtherCosts = _unroundedTotalOtherCosts; unroundedTotalOtherCosts.Clean = value; _unroundedTotalOtherCosts = unroundedTotalOtherCosts;
                var useActualDownPaymentAndClosingCostsFinancedIndicator = _useActualDownPaymentAndClosingCostsFinancedIndicator; useActualDownPaymentAndClosingCostsFinancedIndicator.Clean = value; _useActualDownPaymentAndClosingCostsFinancedIndicator = useActualDownPaymentAndClosingCostsFinancedIndicator;
                var useAlternate = _useAlternate; useAlternate.Clean = value; _useAlternate = useAlternate;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public LoanEstimate2()
        {
            Clean = true;
        }
    }
}