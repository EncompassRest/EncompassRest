using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LoanEstimate2
/// </summary>
public sealed partial class LoanEstimate2 : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _actualLenderCredits;
    private DirtyValue<decimal?>? _actualSTDLESellerCredits;
    private DirtyValue<decimal?>? _actualSTDLETotalClosingCostJ;
    private DirtyValue<decimal?>? _adjustmentsOtherCredits;
    private DirtyValue<decimal?>? _adjustmentsOtherCreditsAmt1;
    private DirtyValue<decimal?>? _adjustmentsOtherCreditsAmt10;
    private DirtyValue<decimal?>? _adjustmentsOtherCreditsAmt2;
    private DirtyValue<decimal?>? _adjustmentsOtherCreditsAmt3;
    private DirtyValue<decimal?>? _adjustmentsOtherCreditsAmt4;
    private DirtyValue<decimal?>? _adjustmentsOtherCreditsAmt5;
    private DirtyValue<decimal?>? _adjustmentsOtherCreditsAmt6;
    private DirtyValue<decimal?>? _adjustmentsOtherCreditsAmt7;
    private DirtyValue<decimal?>? _adjustmentsOtherCreditsAmt8;
    private DirtyValue<decimal?>? _adjustmentsOtherCreditsAmt9;
    private DirtyValue<string?>? _adjustmentsOtherCreditsDesc1;
    private DirtyValue<string?>? _adjustmentsOtherCreditsDesc10;
    private DirtyValue<string?>? _adjustmentsOtherCreditsDesc2;
    private DirtyValue<string?>? _adjustmentsOtherCreditsDesc3;
    private DirtyValue<string?>? _adjustmentsOtherCreditsDesc4;
    private DirtyValue<string?>? _adjustmentsOtherCreditsDesc5;
    private DirtyValue<string?>? _adjustmentsOtherCreditsDesc6;
    private DirtyValue<string?>? _adjustmentsOtherCreditsDesc7;
    private DirtyValue<string?>? _adjustmentsOtherCreditsDesc8;
    private DirtyValue<string?>? _adjustmentsOtherCreditsDesc9;
    private DirtyValue<decimal?>? _closingCostsFinanced;
    private DirtyValue<decimal?>? _downPayment;
    private DirtyValue<decimal?>? _estimatedCashToCloseAV;
    private DirtyValue<decimal?>? _estimatedCashToCloseSV;
    private DirtyValue<int?>? _estimatedTotalPayoffsAndPaymentsAmount;
    private DirtyValue<int?>? _firstChangeFrequencyMonth;
    private DirtyValue<string?>? _firstChangeMonthSuffix;
    private DirtyValue<string?>? _fromOrToBorrower;
    private DirtyValue<decimal?>? _fundsForBorrower;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _includePayoffs;
    private DirtyValue<StringEnumValue<IndexMargin>>? _indexMargin;
    private DirtyValue<int?>? _initialEscrowPaymentClosingSubTotal;
    private DirtyValue<bool?>? _itemizeServiceSectionCType;
    private DirtyValue<int?>? _lenderCredits;
    private DirtyValue<int?>? _originationChargesSubTotal;
    private DirtyValue<int?>? _otherSubTotal;
    private DirtyValue<int?>? _prepaidsSubTotal;
    private DirtyValue<int?>? _sellerCreditAmount;
    private DirtyValue<int?>? _servicesYouNotShopSubTotal;
    private DirtyValue<int?>? _servicesYouShopSubTotal;
    private DirtyValue<string?>? _subseqChangeMonthSuffix;
    private DirtyValue<int?>? _taxesGovFeesSubTotal;
    private DirtyValue<decimal?>? _thirdPartyPaymentsNotOtherwiseDisclosed;
    private DirtyValue<int?>? _totalClosingCosts;
    private DirtyValue<int?>? _totalLoanAndOtherCosts;
    private DirtyValue<int?>? _totalLoanCosts;
    private DirtyValue<int?>? _totalOtherCosts;
    private DirtyValue<decimal?>? _unroundedTotalLoanCosts;
    private DirtyValue<decimal?>? _unroundedTotalOtherCosts;
    private DirtyValue<bool?>? _useActualDownPaymentAndClosingCostsFinancedIndicator;
    private DirtyValue<bool?>? _useAlternate;

    /// <summary>
    /// Decimal Value of Lender Credit Amount [LE2.XLCDV]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualLenderCredits { get => _actualLenderCredits; set => SetField(ref _actualLenderCredits, value); }

    /// <summary>
    /// Decimal Value of STD LE Seller Credits [LE2.X100DV]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualSTDLESellerCredits { get => _actualSTDLESellerCredits; set => SetField(ref _actualSTDLESellerCredits, value); }

    /// <summary>
    /// Decimal Value of STD LE Total Closing Cost J [LE2.XSTJDV]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualSTDLETotalClosingCostJ { get => _actualSTDLETotalClosingCostJ; set => SetField(ref _actualSTDLETotalClosingCostJ, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits [LE2.X4]
    /// </summary>
    public decimal? AdjustmentsOtherCredits { get => _adjustmentsOtherCredits; set => SetField(ref _adjustmentsOtherCredits, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Amount 1 [LE2.X6]
    /// </summary>
    public decimal? AdjustmentsOtherCreditsAmt1 { get => _adjustmentsOtherCreditsAmt1; set => SetField(ref _adjustmentsOtherCreditsAmt1, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Amount 10 [LE2.X24]
    /// </summary>
    public decimal? AdjustmentsOtherCreditsAmt10 { get => _adjustmentsOtherCreditsAmt10; set => SetField(ref _adjustmentsOtherCreditsAmt10, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Amount 2 [LE2.X8]
    /// </summary>
    public decimal? AdjustmentsOtherCreditsAmt2 { get => _adjustmentsOtherCreditsAmt2; set => SetField(ref _adjustmentsOtherCreditsAmt2, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Amount 3 [LE2.X10]
    /// </summary>
    public decimal? AdjustmentsOtherCreditsAmt3 { get => _adjustmentsOtherCreditsAmt3; set => SetField(ref _adjustmentsOtherCreditsAmt3, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Amount 4 [LE2.X12]
    /// </summary>
    public decimal? AdjustmentsOtherCreditsAmt4 { get => _adjustmentsOtherCreditsAmt4; set => SetField(ref _adjustmentsOtherCreditsAmt4, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Amount 5 [LE2.X14]
    /// </summary>
    public decimal? AdjustmentsOtherCreditsAmt5 { get => _adjustmentsOtherCreditsAmt5; set => SetField(ref _adjustmentsOtherCreditsAmt5, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Amount 6 [LE2.X16]
    /// </summary>
    public decimal? AdjustmentsOtherCreditsAmt6 { get => _adjustmentsOtherCreditsAmt6; set => SetField(ref _adjustmentsOtherCreditsAmt6, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Amount 7 [LE2.X18]
    /// </summary>
    public decimal? AdjustmentsOtherCreditsAmt7 { get => _adjustmentsOtherCreditsAmt7; set => SetField(ref _adjustmentsOtherCreditsAmt7, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Amount 8 [LE2.X20]
    /// </summary>
    public decimal? AdjustmentsOtherCreditsAmt8 { get => _adjustmentsOtherCreditsAmt8; set => SetField(ref _adjustmentsOtherCreditsAmt8, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Amount 9 [LE2.X22]
    /// </summary>
    public decimal? AdjustmentsOtherCreditsAmt9 { get => _adjustmentsOtherCreditsAmt9; set => SetField(ref _adjustmentsOtherCreditsAmt9, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Description 1 [LE2.X5]
    /// </summary>
    public string? AdjustmentsOtherCreditsDesc1 { get => _adjustmentsOtherCreditsDesc1; set => SetField(ref _adjustmentsOtherCreditsDesc1, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Description 10 [LE2.X23]
    /// </summary>
    public string? AdjustmentsOtherCreditsDesc10 { get => _adjustmentsOtherCreditsDesc10; set => SetField(ref _adjustmentsOtherCreditsDesc10, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Description 2 [LE2.X7]
    /// </summary>
    public string? AdjustmentsOtherCreditsDesc2 { get => _adjustmentsOtherCreditsDesc2; set => SetField(ref _adjustmentsOtherCreditsDesc2, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Description 3 [LE2.X9]
    /// </summary>
    public string? AdjustmentsOtherCreditsDesc3 { get => _adjustmentsOtherCreditsDesc3; set => SetField(ref _adjustmentsOtherCreditsDesc3, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Description 4 [LE2.X11]
    /// </summary>
    public string? AdjustmentsOtherCreditsDesc4 { get => _adjustmentsOtherCreditsDesc4; set => SetField(ref _adjustmentsOtherCreditsDesc4, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Description 5 [LE2.X13]
    /// </summary>
    public string? AdjustmentsOtherCreditsDesc5 { get => _adjustmentsOtherCreditsDesc5; set => SetField(ref _adjustmentsOtherCreditsDesc5, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Description 6 [LE2.X15]
    /// </summary>
    public string? AdjustmentsOtherCreditsDesc6 { get => _adjustmentsOtherCreditsDesc6; set => SetField(ref _adjustmentsOtherCreditsDesc6, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Description 7 [LE2.X17]
    /// </summary>
    public string? AdjustmentsOtherCreditsDesc7 { get => _adjustmentsOtherCreditsDesc7; set => SetField(ref _adjustmentsOtherCreditsDesc7, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Description 8 [LE2.X19]
    /// </summary>
    public string? AdjustmentsOtherCreditsDesc8 { get => _adjustmentsOtherCreditsDesc8; set => SetField(ref _adjustmentsOtherCreditsDesc8, value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Description 9 [LE2.X21]
    /// </summary>
    public string? AdjustmentsOtherCreditsDesc9 { get => _adjustmentsOtherCreditsDesc9; set => SetField(ref _adjustmentsOtherCreditsDesc9, value); }

    /// <summary>
    /// Loan Estimate - Closing Costs Financed [LE2.X1]
    /// </summary>
    public decimal? ClosingCostsFinanced { get => _closingCostsFinanced; set => SetField(ref _closingCostsFinanced, value); }

    /// <summary>
    /// Loan Estimate - Down Payment/Funds from Borrower [LE2.X2]
    /// </summary>
    public decimal? DownPayment { get => _downPayment; set => SetField(ref _downPayment, value); }

    /// <summary>
    /// Loan Estimate - Estimated Cash To Close Alternate Version [LE2.X26]
    /// </summary>
    public decimal? EstimatedCashToCloseAV { get => _estimatedCashToCloseAV; set => SetField(ref _estimatedCashToCloseAV, value); }

    /// <summary>
    /// Loan Estimate - Estimated Cash To Close Standard Version [LE2.X25]
    /// </summary>
    public decimal? EstimatedCashToCloseSV { get => _estimatedCashToCloseSV; set => SetField(ref _estimatedCashToCloseSV, value); }

    /// <summary>
    /// Loan Estimate - Estimated Total Payoffs and Payments [LE2.X31]
    /// </summary>
    public int? EstimatedTotalPayoffsAndPaymentsAmount { get => _estimatedTotalPayoffsAndPaymentsAmount; set => SetField(ref _estimatedTotalPayoffsAndPaymentsAmount, value); }

    /// <summary>
    /// Loan Estimate - First Change Frequency Month [LE2.X99]
    /// </summary>
    public int? firstChangeFrequencyMonth { get => _firstChangeFrequencyMonth; set => SetField(ref _firstChangeFrequencyMonth, value); }

    /// <summary>
    /// Loan Estimate - First Change Frequency Month Suffix [LE2.X97]
    /// </summary>
    public string? firstChangeMonthSuffix { get => _firstChangeMonthSuffix; set => SetField(ref _firstChangeMonthSuffix, value); }

    /// <summary>
    /// Loan Estimate - From Or To Borrower [LE2.X27]
    /// </summary>
    public string? FromOrToBorrower { get => _fromOrToBorrower; set => SetField(ref _fromOrToBorrower, value); }

    /// <summary>
    /// Loan Estimate - Funds for Borrower [LE2.X3]
    /// </summary>
    public decimal? FundsForBorrower { get => _fundsForBorrower; set => SetField(ref _fundsForBorrower, value); }

    /// <summary>
    /// LoanEstimate2 Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Loan Estimate - Include Payoffs in Adjustments and Credits (Purchase Only) [LE2.X101]
    /// </summary>
    public bool? IncludePayoffs { get => _includePayoffs; set => SetField(ref _includePayoffs, value); }

    /// <summary>
    /// Loan Estimate - Index [LE2.X96]
    /// </summary>
    public StringEnumValue<IndexMargin> IndexMargin { get => _indexMargin; set => SetField(ref _indexMargin, value); }

    /// <summary>
    /// Loan Estimate - G.Initial Escrow Payment Closing Sub Total [LE2.XSTG]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? InitialEscrowPaymentClosingSubTotal { get => _initialEscrowPaymentClosingSubTotal; set => SetField(ref _initialEscrowPaymentClosingSubTotal, value); }

    /// <summary>
    /// Loan Estimate - Itemize Services Section C (Services You Can Shop For) that Exceed Line 14 [LE2.X32]
    /// </summary>
    public bool? ItemizeServiceSectionCType { get => _itemizeServiceSectionCType; set => SetField(ref _itemizeServiceSectionCType, value); }

    /// <summary>
    /// Loan Estimate - Lender Credits [LE2.XLC]
    /// </summary>
    public int? LenderCredits { get => _lenderCredits; set => SetField(ref _lenderCredits, value); }

    /// <summary>
    /// Loan Estimate - A.Origination Charges Sub Total [LE2.XSTA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? OriginationChargesSubTotal { get => _originationChargesSubTotal; set => SetField(ref _originationChargesSubTotal, value); }

    /// <summary>
    /// Loan Estimate - H.Other Sub Total [LE2.XSTH]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? OtherSubTotal { get => _otherSubTotal; set => SetField(ref _otherSubTotal, value); }

    /// <summary>
    /// Loan Estimate - F.Prepaids Sub Total [LE2.XSTF]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? PrepaidsSubTotal { get => _prepaidsSubTotal; set => SetField(ref _prepaidsSubTotal, value); }

    /// <summary>
    /// Loan Estimate - Seller Credit Amount [LE2.X100]
    /// </summary>
    public int? SellerCreditAmount { get => _sellerCreditAmount; set => SetField(ref _sellerCreditAmount, value); }

    /// <summary>
    /// Loan Estimate - B.Services You Cannot Shop For Sub Total [LE2.XSTB]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? ServicesYouNotShopSubTotal { get => _servicesYouNotShopSubTotal; set => SetField(ref _servicesYouNotShopSubTotal, value); }

    /// <summary>
    /// Loan Estimate - C.Services You Can Shop For Sub Total [LE2.XSTC]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? ServicesYouShopSubTotal { get => _servicesYouShopSubTotal; set => SetField(ref _servicesYouShopSubTotal, value); }

    /// <summary>
    /// Loan Estimate - Subsequent Change Frequency Month Suffix [LE2.X98]
    /// </summary>
    public string? subseqChangeMonthSuffix { get => _subseqChangeMonthSuffix; set => SetField(ref _subseqChangeMonthSuffix, value); }

    /// <summary>
    /// Loan Estimate - E.Taxes and Government Fees Sub Total [LE2.XSTE]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TaxesGovFeesSubTotal { get => _taxesGovFeesSubTotal; set => SetField(ref _taxesGovFeesSubTotal, value); }

    /// <summary>
    /// Loan Estimate - Third Party Payments Not Otherwise Disclosed [LE2.X29]
    /// </summary>
    public decimal? ThirdPartyPaymentsNotOtherwiseDisclosed { get => _thirdPartyPaymentsNotOtherwiseDisclosed; set => SetField(ref _thirdPartyPaymentsNotOtherwiseDisclosed, value); }

    /// <summary>
    /// Loan Estimate - J.Total Closing Costs [LE2.XSTJ]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TotalClosingCosts { get => _totalClosingCosts; set => SetField(ref _totalClosingCosts, value); }

    /// <summary>
    /// Loan Estimate - Total Loan and Other Costs (D + I) [LE2.XDI]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TotalLoanAndOtherCosts { get => _totalLoanAndOtherCosts; set => SetField(ref _totalLoanAndOtherCosts, value); }

    /// <summary>
    /// Loan Estimate - D.Total Loan Costs [LE2.XSTD]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TotalLoanCosts { get => _totalLoanCosts; set => SetField(ref _totalLoanCosts, value); }

    /// <summary>
    /// Loan Estimate -I.Total Other Costs [LE2.XSTI]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TotalOtherCosts { get => _totalOtherCosts; set => SetField(ref _totalOtherCosts, value); }

    /// <summary>
    /// Loan Estimate - D.Total Loan Costs (Unrounded) [LE2.XSTD_DV]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? UnroundedTotalLoanCosts { get => _unroundedTotalLoanCosts; set => SetField(ref _unroundedTotalLoanCosts, value); }

    /// <summary>
    /// Loan Estimate -I.Total Other Costs (Unrounded) [LE2.XSTI_DV]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? UnroundedTotalOtherCosts { get => _unroundedTotalOtherCosts; set => SetField(ref _unroundedTotalOtherCosts, value); }

    /// <summary>
    /// Loan Estimate - Use Actual Down Payment &amp; Closing Costs Financed Indicator [LE2.X30]
    /// </summary>
    public bool? UseActualDownPaymentAndClosingCostsFinancedIndicator { get => _useActualDownPaymentAndClosingCostsFinancedIndicator; set => SetField(ref _useActualDownPaymentAndClosingCostsFinancedIndicator, value); }

    /// <summary>
    /// Loan Estimate - Use Alternate [LE2.X28]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Use Alternate\"}")]
    public bool? UseAlternate { get => _useAlternate; set => SetField(ref _useAlternate, value); }
}