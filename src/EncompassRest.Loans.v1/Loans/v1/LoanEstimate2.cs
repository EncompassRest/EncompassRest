using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LoanEstimate2
/// </summary>
public sealed partial class LoanEstimate2 : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Decimal Value of Lender Credit Amount [LE2.XLCDV]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualLenderCredits { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Decimal Value of STD LE Seller Credits [LE2.X100DV]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualSTDLESellerCredits { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Decimal Value of STD LE Total Closing Cost J [LE2.XSTJDV]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualSTDLETotalClosingCostJ { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits [LE2.X4]
    /// </summary>
    public decimal? AdjustmentsOtherCredits { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Amount 1 [LE2.X6]
    /// </summary>
    public decimal? AdjustmentsOtherCreditsAmt1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Amount 10 [LE2.X24]
    /// </summary>
    public decimal? AdjustmentsOtherCreditsAmt10 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Amount 2 [LE2.X8]
    /// </summary>
    public decimal? AdjustmentsOtherCreditsAmt2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Amount 3 [LE2.X10]
    /// </summary>
    public decimal? AdjustmentsOtherCreditsAmt3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Amount 4 [LE2.X12]
    /// </summary>
    public decimal? AdjustmentsOtherCreditsAmt4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Amount 5 [LE2.X14]
    /// </summary>
    public decimal? AdjustmentsOtherCreditsAmt5 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Amount 6 [LE2.X16]
    /// </summary>
    public decimal? AdjustmentsOtherCreditsAmt6 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Amount 7 [LE2.X18]
    /// </summary>
    public decimal? AdjustmentsOtherCreditsAmt7 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Amount 8 [LE2.X20]
    /// </summary>
    public decimal? AdjustmentsOtherCreditsAmt8 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Amount 9 [LE2.X22]
    /// </summary>
    public decimal? AdjustmentsOtherCreditsAmt9 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Description 1 [LE2.X5]
    /// </summary>
    public string? AdjustmentsOtherCreditsDesc1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Description 10 [LE2.X23]
    /// </summary>
    public string? AdjustmentsOtherCreditsDesc10 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Description 2 [LE2.X7]
    /// </summary>
    public string? AdjustmentsOtherCreditsDesc2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Description 3 [LE2.X9]
    /// </summary>
    public string? AdjustmentsOtherCreditsDesc3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Description 4 [LE2.X11]
    /// </summary>
    public string? AdjustmentsOtherCreditsDesc4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Description 5 [LE2.X13]
    /// </summary>
    public string? AdjustmentsOtherCreditsDesc5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Description 6 [LE2.X15]
    /// </summary>
    public string? AdjustmentsOtherCreditsDesc6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Description 7 [LE2.X17]
    /// </summary>
    public string? AdjustmentsOtherCreditsDesc7 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Description 8 [LE2.X19]
    /// </summary>
    public string? AdjustmentsOtherCreditsDesc8 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Adjustments and Other Credits Description 9 [LE2.X21]
    /// </summary>
    public string? AdjustmentsOtherCreditsDesc9 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Closing Costs Financed [LE2.X1]
    /// </summary>
    public decimal? ClosingCostsFinanced { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Down Payment/Funds from Borrower [LE2.X2]
    /// </summary>
    public decimal? DownPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Estimated Cash To Close Alternate Version [LE2.X26]
    /// </summary>
    public decimal? EstimatedCashToCloseAV { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Estimated Cash To Close Standard Version [LE2.X25]
    /// </summary>
    public decimal? EstimatedCashToCloseSV { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Estimated Total Payoffs and Payments [LE2.X31]
    /// </summary>
    public int? EstimatedTotalPayoffsAndPaymentsAmount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - First Change Frequency Month [LE2.X99]
    /// </summary>
    public int? firstChangeFrequencyMonth { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - First Change Frequency Month Suffix [LE2.X97]
    /// </summary>
    public string? firstChangeMonthSuffix { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - From Or To Borrower [LE2.X27]
    /// </summary>
    public string? FromOrToBorrower { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Funds for Borrower [LE2.X3]
    /// </summary>
    public decimal? FundsForBorrower { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanEstimate2 Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Include Payoffs in Adjustments and Credits (Purchase Only) [LE2.X101]
    /// </summary>
    public bool? IncludePayoffs { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Index [LE2.X96]
    /// </summary>
    public StringEnumValue<IndexMargin> IndexMargin { get => GetValue<StringEnumValue<IndexMargin>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - G.Initial Escrow Payment Closing Sub Total [LE2.XSTG]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? InitialEscrowPaymentClosingSubTotal { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Itemize Services Section C (Services You Can Shop For) that Exceed Line 14 [LE2.X32]
    /// </summary>
    public bool? ItemizeServiceSectionCType { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Lender Credits [LE2.XLC]
    /// </summary>
    public int? LenderCredits { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - A.Origination Charges Sub Total [LE2.XSTA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? OriginationChargesSubTotal { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - H.Other Sub Total [LE2.XSTH]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? OtherSubTotal { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - F.Prepaids Sub Total [LE2.XSTF]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? PrepaidsSubTotal { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Seller Credit Amount [LE2.X100]
    /// </summary>
    public int? SellerCreditAmount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - B.Services You Cannot Shop For Sub Total [LE2.XSTB]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? ServicesYouNotShopSubTotal { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - C.Services You Can Shop For Sub Total [LE2.XSTC]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? ServicesYouShopSubTotal { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Subsequent Change Frequency Month Suffix [LE2.X98]
    /// </summary>
    public string? subseqChangeMonthSuffix { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - E.Taxes and Government Fees Sub Total [LE2.XSTE]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TaxesGovFeesSubTotal { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Third Party Payments Not Otherwise Disclosed [LE2.X29]
    /// </summary>
    public decimal? ThirdPartyPaymentsNotOtherwiseDisclosed { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - J.Total Closing Costs [LE2.XSTJ]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TotalClosingCosts { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Total Loan and Other Costs (D + I) [LE2.XDI]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TotalLoanAndOtherCosts { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - D.Total Loan Costs [LE2.XSTD]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TotalLoanCosts { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate -I.Total Other Costs [LE2.XSTI]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TotalOtherCosts { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - D.Total Loan Costs (Unrounded) [LE2.XSTD_DV]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? UnroundedTotalLoanCosts { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate -I.Total Other Costs (Unrounded) [LE2.XSTI_DV]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? UnroundedTotalOtherCosts { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Use Actual Down Payment &amp; Closing Costs Financed Indicator [LE2.X30]
    /// </summary>
    public bool? UseActualDownPaymentAndClosingCostsFinancedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Use Alternate [LE2.X28]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Use Alternate\"}")]
    public bool? UseAlternate { get => GetValue<bool?>(); set => SetValue(value); }
}