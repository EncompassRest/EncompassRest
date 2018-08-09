using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LoanEstimate2
    /// </summary>
    public sealed partial class LoanEstimate2 : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _actualLenderCredits;
        /// <summary>
        /// Decimal Value of Lender Credit Amount [LE2.XLCDV]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Decimal Value of Lender Credit Amount")]
        public decimal? ActualLenderCredits { get => _actualLenderCredits; set => _actualLenderCredits = value; }
        private DirtyValue<decimal?> _actualSTDLESellerCredits;
        /// <summary>
        /// Decimal Value of STD LE Seller Credits [LE2.X100DV]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Decimal Value of STD LE Seller Credits")]
        public decimal? ActualSTDLESellerCredits { get => _actualSTDLESellerCredits; set => _actualSTDLESellerCredits = value; }
        private DirtyValue<decimal?> _actualSTDLETotalClosingCostJ;
        /// <summary>
        /// Decimal Value of STD LE Total Closing Cost J [LE2.XSTJDV]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Decimal Value of STD LE Total Closing Cost J")]
        public decimal? ActualSTDLETotalClosingCostJ { get => _actualSTDLETotalClosingCostJ; set => _actualSTDLETotalClosingCostJ = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCredits;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits [LE2.X4]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Adjustments and Other Credits")]
        public decimal? AdjustmentsOtherCredits { get => _adjustmentsOtherCredits; set => _adjustmentsOtherCredits = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCreditsAmt1;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits Amount 1 [LE2.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Adjustments and Other Credits Amount 1")]
        public decimal? AdjustmentsOtherCreditsAmt1 { get => _adjustmentsOtherCreditsAmt1; set => _adjustmentsOtherCreditsAmt1 = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCreditsAmt10;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits Amount 10 [LE2.X24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Adjustments and Other Credits Amount 10")]
        public decimal? AdjustmentsOtherCreditsAmt10 { get => _adjustmentsOtherCreditsAmt10; set => _adjustmentsOtherCreditsAmt10 = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCreditsAmt2;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits Amount 2 [LE2.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Adjustments and Other Credits Amount 2")]
        public decimal? AdjustmentsOtherCreditsAmt2 { get => _adjustmentsOtherCreditsAmt2; set => _adjustmentsOtherCreditsAmt2 = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCreditsAmt3;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits Amount 3 [LE2.X10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Adjustments and Other Credits Amount 3")]
        public decimal? AdjustmentsOtherCreditsAmt3 { get => _adjustmentsOtherCreditsAmt3; set => _adjustmentsOtherCreditsAmt3 = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCreditsAmt4;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits Amount 4 [LE2.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Adjustments and Other Credits Amount 4")]
        public decimal? AdjustmentsOtherCreditsAmt4 { get => _adjustmentsOtherCreditsAmt4; set => _adjustmentsOtherCreditsAmt4 = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCreditsAmt5;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits Amount 5 [LE2.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Adjustments and Other Credits Amount 5")]
        public decimal? AdjustmentsOtherCreditsAmt5 { get => _adjustmentsOtherCreditsAmt5; set => _adjustmentsOtherCreditsAmt5 = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCreditsAmt6;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits Amount 6 [LE2.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Adjustments and Other Credits Amount 6")]
        public decimal? AdjustmentsOtherCreditsAmt6 { get => _adjustmentsOtherCreditsAmt6; set => _adjustmentsOtherCreditsAmt6 = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCreditsAmt7;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits Amount 7 [LE2.X18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Adjustments and Other Credits Amount 7")]
        public decimal? AdjustmentsOtherCreditsAmt7 { get => _adjustmentsOtherCreditsAmt7; set => _adjustmentsOtherCreditsAmt7 = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCreditsAmt8;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits Amount 8 [LE2.X20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Adjustments and Other Credits Amount 8")]
        public decimal? AdjustmentsOtherCreditsAmt8 { get => _adjustmentsOtherCreditsAmt8; set => _adjustmentsOtherCreditsAmt8 = value; }
        private DirtyValue<decimal?> _adjustmentsOtherCreditsAmt9;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits Amount 9 [LE2.X22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Adjustments and Other Credits Amount 9")]
        public decimal? AdjustmentsOtherCreditsAmt9 { get => _adjustmentsOtherCreditsAmt9; set => _adjustmentsOtherCreditsAmt9 = value; }
        private DirtyValue<string> _adjustmentsOtherCreditsDesc1;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits Description 1 [LE2.X5]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Adjustments and Other Credits Description 1")]
        public string AdjustmentsOtherCreditsDesc1 { get => _adjustmentsOtherCreditsDesc1; set => _adjustmentsOtherCreditsDesc1 = value; }
        private DirtyValue<string> _adjustmentsOtherCreditsDesc10;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits Description 10 [LE2.X23]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Adjustments and Other Credits Description 10")]
        public string AdjustmentsOtherCreditsDesc10 { get => _adjustmentsOtherCreditsDesc10; set => _adjustmentsOtherCreditsDesc10 = value; }
        private DirtyValue<string> _adjustmentsOtherCreditsDesc2;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits Description 2 [LE2.X7]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Adjustments and Other Credits Description 2")]
        public string AdjustmentsOtherCreditsDesc2 { get => _adjustmentsOtherCreditsDesc2; set => _adjustmentsOtherCreditsDesc2 = value; }
        private DirtyValue<string> _adjustmentsOtherCreditsDesc3;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits Description 3 [LE2.X9]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Adjustments and Other Credits Description 3")]
        public string AdjustmentsOtherCreditsDesc3 { get => _adjustmentsOtherCreditsDesc3; set => _adjustmentsOtherCreditsDesc3 = value; }
        private DirtyValue<string> _adjustmentsOtherCreditsDesc4;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits Description 4 [LE2.X11]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Adjustments and Other Credits Description 4")]
        public string AdjustmentsOtherCreditsDesc4 { get => _adjustmentsOtherCreditsDesc4; set => _adjustmentsOtherCreditsDesc4 = value; }
        private DirtyValue<string> _adjustmentsOtherCreditsDesc5;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits Description 5 [LE2.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Adjustments and Other Credits Description 5")]
        public string AdjustmentsOtherCreditsDesc5 { get => _adjustmentsOtherCreditsDesc5; set => _adjustmentsOtherCreditsDesc5 = value; }
        private DirtyValue<string> _adjustmentsOtherCreditsDesc6;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits Description 6 [LE2.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Adjustments and Other Credits Description 6")]
        public string AdjustmentsOtherCreditsDesc6 { get => _adjustmentsOtherCreditsDesc6; set => _adjustmentsOtherCreditsDesc6 = value; }
        private DirtyValue<string> _adjustmentsOtherCreditsDesc7;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits Description 7 [LE2.X17]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Adjustments and Other Credits Description 7")]
        public string AdjustmentsOtherCreditsDesc7 { get => _adjustmentsOtherCreditsDesc7; set => _adjustmentsOtherCreditsDesc7 = value; }
        private DirtyValue<string> _adjustmentsOtherCreditsDesc8;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits Description 8 [LE2.X19]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Adjustments and Other Credits Description 8")]
        public string AdjustmentsOtherCreditsDesc8 { get => _adjustmentsOtherCreditsDesc8; set => _adjustmentsOtherCreditsDesc8 = value; }
        private DirtyValue<string> _adjustmentsOtherCreditsDesc9;
        /// <summary>
        /// Loan Estimate - Adjustments and Other Credits Description 9 [LE2.X21]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Adjustments and Other Credits Description 9")]
        public string AdjustmentsOtherCreditsDesc9 { get => _adjustmentsOtherCreditsDesc9; set => _adjustmentsOtherCreditsDesc9 = value; }
        private DirtyValue<decimal?> _closingCostsFinanced;
        /// <summary>
        /// Loan Estimate - Closing Costs Financed [LE2.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Closing Costs Financed")]
        public decimal? ClosingCostsFinanced { get => _closingCostsFinanced; set => _closingCostsFinanced = value; }
        private DirtyValue<decimal?> _downPayment;
        /// <summary>
        /// Loan Estimate - Down Payment/Funds from Borrower [LE2.X2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Down Payment/Funds from Borrower")]
        public decimal? DownPayment { get => _downPayment; set => _downPayment = value; }
        private DirtyValue<decimal?> _estimatedCashToCloseAV;
        /// <summary>
        /// Loan Estimate - Estimated Cash To Close Alternate Version [LE2.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Estimated Cash To Close Alternate Version")]
        public decimal? EstimatedCashToCloseAV { get => _estimatedCashToCloseAV; set => _estimatedCashToCloseAV = value; }
        private DirtyValue<decimal?> _estimatedCashToCloseSV;
        /// <summary>
        /// Loan Estimate - Estimated Cash To Close Standard Version [LE2.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Estimated Cash To Close Standard Version")]
        public decimal? EstimatedCashToCloseSV { get => _estimatedCashToCloseSV; set => _estimatedCashToCloseSV = value; }
        private DirtyValue<int?> _estimatedTotalPayoffsAndPaymentsAmount;
        /// <summary>
        /// Loan Estimate - Estimated Total Payoffs and Payments [LE2.X31]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Estimated Total Payoffs and Payments")]
        public int? EstimatedTotalPayoffsAndPaymentsAmount { get => _estimatedTotalPayoffsAndPaymentsAmount; set => _estimatedTotalPayoffsAndPaymentsAmount = value; }
        private DirtyValue<int?> _firstChangeFrequencyMonth;
        /// <summary>
        /// Loan Estimate - First Change Frequency Month [LE2.X99]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - First Change Frequency Month")]
        public int? firstChangeFrequencyMonth { get => _firstChangeFrequencyMonth; set => _firstChangeFrequencyMonth = value; }
        private DirtyValue<string> _firstChangeMonthSuffix;
        /// <summary>
        /// Loan Estimate - First Change Frequency Month Suffix [LE2.X97]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - First Change Frequency Month Suffix")]
        public string firstChangeMonthSuffix { get => _firstChangeMonthSuffix; set => _firstChangeMonthSuffix = value; }
        private DirtyValue<string> _fromOrToBorrower;
        /// <summary>
        /// Loan Estimate - From Or To Borrower [LE2.X27]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - From Or To Borrower")]
        public string FromOrToBorrower { get => _fromOrToBorrower; set => _fromOrToBorrower = value; }
        private DirtyValue<decimal?> _fundsForBorrower;
        /// <summary>
        /// Loan Estimate - Funds for Borrower [LE2.X3]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Funds for Borrower")]
        public decimal? FundsForBorrower { get => _fundsForBorrower; set => _fundsForBorrower = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// LoanEstimate2 Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<StringEnumValue<IndexMargin>> _indexMargin;
        /// <summary>
        /// Loan Estimate - Index [LE2.X96]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Index")]
        public StringEnumValue<IndexMargin> IndexMargin { get => _indexMargin; set => _indexMargin = value; }
        private DirtyValue<int?> _initialEscrowPaymentClosingSubTotal;
        /// <summary>
        /// Loan Estimate - G.Initial Escrow Payment Closing Sub Total [LE2.XSTG]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - G.Initial Escrow Payment Closing Sub Total")]
        public int? InitialEscrowPaymentClosingSubTotal { get => _initialEscrowPaymentClosingSubTotal; set => _initialEscrowPaymentClosingSubTotal = value; }
        private DirtyValue<bool?> _itemizeServiceSectionCType;
        /// <summary>
        /// Loan Estimate - Itemize Services Section C (Services You Can Shop For) that Exceed Line 14 [LE2.X32]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Itemize Services Section C (Services You Can Shop For) that Exceed Line 14")]
        public bool? ItemizeServiceSectionCType { get => _itemizeServiceSectionCType; set => _itemizeServiceSectionCType = value; }
        private DirtyValue<int?> _lenderCredits;
        /// <summary>
        /// Loan Estimate - Lender Credits [LE2.XLC]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Lender Credits")]
        public int? LenderCredits { get => _lenderCredits; set => _lenderCredits = value; }
        private DirtyValue<int?> _originationChargesSubTotal;
        /// <summary>
        /// Loan Estimate - A.Origination Charges Sub Total [LE2.XSTA]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - A.Origination Charges Sub Total")]
        public int? OriginationChargesSubTotal { get => _originationChargesSubTotal; set => _originationChargesSubTotal = value; }
        private DirtyValue<int?> _otherSubTotal;
        /// <summary>
        /// Loan Estimate - H.Other Sub Total [LE2.XSTH]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - H.Other Sub Total")]
        public int? OtherSubTotal { get => _otherSubTotal; set => _otherSubTotal = value; }
        private DirtyValue<int?> _prepaidsSubTotal;
        /// <summary>
        /// Loan Estimate - F.Prepaids Sub Total [LE2.XSTF]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - F.Prepaids Sub Total")]
        public int? PrepaidsSubTotal { get => _prepaidsSubTotal; set => _prepaidsSubTotal = value; }
        private DirtyValue<int?> _sellerCreditAmount;
        /// <summary>
        /// Loan Estimate - Seller Credit Amount [LE2.X100]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Seller Credit Amount")]
        public int? SellerCreditAmount { get => _sellerCreditAmount; set => _sellerCreditAmount = value; }
        private DirtyValue<int?> _servicesYouNotShopSubTotal;
        /// <summary>
        /// Loan Estimate - B.Services You Cannot Shop For Sub Total [LE2.XSTB]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - B.Services You Cannot Shop For Sub Total")]
        public int? ServicesYouNotShopSubTotal { get => _servicesYouNotShopSubTotal; set => _servicesYouNotShopSubTotal = value; }
        private DirtyValue<int?> _servicesYouShopSubTotal;
        /// <summary>
        /// Loan Estimate - C.Services You Can Shop For Sub Total [LE2.XSTC]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - C.Services You Can Shop For Sub Total")]
        public int? ServicesYouShopSubTotal { get => _servicesYouShopSubTotal; set => _servicesYouShopSubTotal = value; }
        private DirtyValue<string> _subseqChangeMonthSuffix;
        /// <summary>
        /// Loan Estimate - Subsequent Change Frequency Month Suffix [LE2.X98]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Subsequent Change Frequency Month Suffix")]
        public string subseqChangeMonthSuffix { get => _subseqChangeMonthSuffix; set => _subseqChangeMonthSuffix = value; }
        private DirtyValue<int?> _taxesGovFeesSubTotal;
        /// <summary>
        /// Loan Estimate - E.Taxes and Government Fees Sub Total [LE2.XSTE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - E.Taxes and Government Fees Sub Total")]
        public int? TaxesGovFeesSubTotal { get => _taxesGovFeesSubTotal; set => _taxesGovFeesSubTotal = value; }
        private DirtyValue<decimal?> _thirdPartyPaymentsNotOtherwiseDisclosed;
        /// <summary>
        /// Loan Estimate - Third Party Payments Not Otherwise Disclosed [LE2.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Third Party Payments Not Otherwise Disclosed")]
        public decimal? ThirdPartyPaymentsNotOtherwiseDisclosed { get => _thirdPartyPaymentsNotOtherwiseDisclosed; set => _thirdPartyPaymentsNotOtherwiseDisclosed = value; }
        private DirtyValue<int?> _totalClosingCosts;
        /// <summary>
        /// Loan Estimate - J.Total Closing Costs [LE2.XSTJ]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - J.Total Closing Costs")]
        public int? TotalClosingCosts { get => _totalClosingCosts; set => _totalClosingCosts = value; }
        private DirtyValue<int?> _totalLoanAndOtherCosts;
        /// <summary>
        /// Loan Estimate - Total Loan and Other Costs (D + I) [LE2.XDI]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Total Loan and Other Costs (D + I)")]
        public int? TotalLoanAndOtherCosts { get => _totalLoanAndOtherCosts; set => _totalLoanAndOtherCosts = value; }
        private DirtyValue<int?> _totalLoanCosts;
        /// <summary>
        /// Loan Estimate - D.Total Loan Costs [LE2.XSTD]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - D.Total Loan Costs")]
        public int? TotalLoanCosts { get => _totalLoanCosts; set => _totalLoanCosts = value; }
        private DirtyValue<int?> _totalOtherCosts;
        /// <summary>
        /// Loan Estimate -I.Total Other Costs [LE2.XSTI]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate -I.Total Other Costs")]
        public int? TotalOtherCosts { get => _totalOtherCosts; set => _totalOtherCosts = value; }
        private DirtyValue<decimal?> _unroundedTotalLoanCosts;
        /// <summary>
        /// Loan Estimate - D.Total Loan Costs (Unrounded) [LE2.XSTD_DV]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Loan Estimate - D.Total Loan Costs (Unrounded)")]
        public decimal? UnroundedTotalLoanCosts { get => _unroundedTotalLoanCosts; set => _unroundedTotalLoanCosts = value; }
        private DirtyValue<decimal?> _unroundedTotalOtherCosts;
        /// <summary>
        /// Loan Estimate -I.Total Other Costs (Unrounded) [LE2.XSTI_DV]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Loan Estimate -I.Total Other Costs (Unrounded)")]
        public decimal? UnroundedTotalOtherCosts { get => _unroundedTotalOtherCosts; set => _unroundedTotalOtherCosts = value; }
        private DirtyValue<bool?> _useActualDownPaymentAndClosingCostsFinancedIndicator;
        /// <summary>
        /// Loan Estimate - Use Actual Down Payment &amp; Closing Costs Financed Indicator [LE2.X30]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Use Actual Down Payment & Closing Costs Financed Indicator")]
        public bool? UseActualDownPaymentAndClosingCostsFinancedIndicator { get => _useActualDownPaymentAndClosingCostsFinancedIndicator; set => _useActualDownPaymentAndClosingCostsFinancedIndicator = value; }
        private DirtyValue<bool?> _useAlternate;
        /// <summary>
        /// Loan Estimate - Use Alternate [LE2.X28]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Use Alternate", OptionsJson = "{\"true\":\"Use Alternate\"}")]
        public bool? UseAlternate { get => _useAlternate; set => _useAlternate = value; }
    }
}