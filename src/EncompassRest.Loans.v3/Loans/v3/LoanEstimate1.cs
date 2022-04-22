using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LoanEstimate1
/// </summary>
public sealed partial class LoanEstimate1 : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Loan Estimate - Interest Rate - Adjusts Every Months/Year/Years [LE1.X14]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Month\"]")]
    public StringEnumValue<TermType> AdjustsTermType { get => GetValue<StringEnumValue<TermType>>(); set => SetValue(value); }

    /// <summary>
    /// Balloon Payment Period [LE1.X98]
    /// </summary>
    public StringEnumValue<MonthOrYear> BalloonPaymentDueInTermLabel { get => GetValue<StringEnumValue<MonthOrYear>>(); set => SetValue(value); }

    /// <summary>
    /// Comments [LE1.X86]
    /// </summary>
    public string? ChangedCircumstanceComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Closing Costs Estimate Expiration Date [LE1.X28]
    /// </summary>
    public DateTime? ClosingCostEstimateExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Closing Costs Estimate Expiration Date UI Value [LE1.XD28]
    /// </summary>
    public string? ClosingCostEstimateExpirationDateUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Closing Costs Estimate Expiration Time [LE1.X8]
    /// </summary>
    public string? ClosingCostEstimateExpirationTime { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Closing Costs Estimate Expiration Time UI Value [LE1.XD8]
    /// </summary>
    public string? ClosingCostEstimateExpirationTimeUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Closing Costs Estimate Expiration Time Zone [LE1.X9]
    /// </summary>
    public StringEnumValue<SpecificTimeZone> ClosingCostEstimateExpirationTimeZone { get => GetValue<StringEnumValue<SpecificTimeZone>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Closing Costs Estimate Expiration Time Zone UI Value [LE1.XD9]
    /// </summary>
    public string? ClosingCostEstimateExpirationTimeZoneUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Conversion Begin Period [LE1.X96]
    /// </summary>
    public StringEnumValue<Conversion> ConversionBegin { get => GetValue<StringEnumValue<Conversion>>(); set => SetValue(value); }

    /// <summary>
    /// Conversion End Period [LE1.X97]
    /// </summary>
    public StringEnumValue<Conversion> ConversionEnd { get => GetValue<StringEnumValue<Conversion>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Disclosure By [LE1.X34]
    /// </summary>
    public string? DisclosureBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Disclosure Closing Cost Exp. Date [LE1.X36]
    /// </summary>
    public DateTime? DisclosureClosingCostExpDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Disclosure Expiration Time [LE1.X37]
    /// </summary>
    public string? DisclosureClosingCostExpTime { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Disclosure Expiration Time Zone [LE1.X38]
    /// </summary>
    public string? DisclosureClosingCostExpTimeZone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Disclosure Comments [LE1.X40]
    /// </summary>
    public string? DisclosureComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Disclosure Last Sent Date [LE1.X33]
    /// </summary>
    public DateTime? DisclosureLastSentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Disclosure Received Date [LE1.X39]
    /// </summary>
    public DateTime? DisclosureReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Disclosure Sent Method [LE1.X35]
    /// </summary>
    public string? DisclosureSentMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Estimated Taxes, Insurance and Assessments [LE1.X29]
    /// </summary>
    public decimal? EstimatedTaxesInsuranceAssessments { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Estimated Taxes, Insurance and Assessments UI Value [LE1.XD29]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? EstimatedTaxesInsuranceAssessmentsUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Closing Costs Estimate Expiration Generic Time Zone [LE1.XG9]
    /// </summary>
    public StringEnumValue<ExpirationGenericTimeZone> ExpirationGenericTimeZone { get => GetValue<StringEnumValue<ExpirationGenericTimeZone>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Monthly Principal and Interest Will be Adjusted in Year [LE1.X24]
    /// </summary>
    public decimal? HighestMonthlyPi { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - In Escrow Homeowner Insurance [LE1.X31]
    /// </summary>
    public string? InEscrowHomeownerInsurance { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - In Escrow Other [LE1.X32]
    /// </summary>
    public string? InEscrowOther { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - In Escrow Property Taxes [LE1.X30]
    /// </summary>
    public string? InEscrowPropertyTaxes { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// The calculated initial monthly payment for a $10,000 loan [LE1.X92]
    /// </summary>
    public decimal? InitialMonthlyPaymentFor10000Loan { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// The calculation initial monthly payment for a $60,000 loan [LE1.X95]
    /// </summary>
    public decimal? InitialMonthlyPaymentFor60000Loan { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Maximum Interest Period [LE1.X99]
    /// </summary>
    public StringEnumValue<MonthOrYear> InterestRateAdjTermLabel { get => GetValue<StringEnumValue<MonthOrYear>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Interest Rate will Adjusts Every [LE1.X13]
    /// </summary>
    public string? InterestRateAdjustsEveryYears { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Interest Rate Will be Adjusted in Year/Month [LE1.X18]
    /// </summary>
    public int? InterestRateAdjustsInYear { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Interest Rate - Adjusts Starting in [LE1.X15]
    /// </summary>
    public StringEnumValue<MonthOrYear> InterestRateAdjustsStartingInType { get => GetValue<StringEnumValue<MonthOrYear>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Interest Rate After Adjustment [LE1.X16]
    /// </summary>
    public int? InterestRateAfterAdjustment { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Interest Rate Can go or Goes [LE1.X17]
    /// </summary>
    public StringEnumValue<CanGoOrGoes> InterestRateCanGoGoes { get => GetValue<StringEnumValue<CanGoOrGoes>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - LE Date Issued [LE1.X1]
    /// </summary>
    public DateTime? LeDateIssued { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Loan Amount Can go or Goes [LE1.X10]
    /// </summary>
    public StringEnumValue<CanGoOrGoes> LoanAmountCanGoGoes { get => GetValue<StringEnumValue<CanGoOrGoes>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Loan Amount Can increase or Increases [LE1.X11]
    /// </summary>
    public StringEnumValue<CanIncreaseOrIncreases> LoanAmountCanIncreaseOrIncreases { get => GetValue<StringEnumValue<CanIncreaseOrIncreases>>(); set => SetValue(value); }

    /// <summary>
    /// Product Description [LE1.X5]
    /// </summary>
    public string? LoanProduct { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Loan Purpose [LE1.X4]
    /// </summary>
    public StringEnumValue<LoanEstimate1LoanPurpose> LoanPurpose { get => GetValue<StringEnumValue<LoanEstimate1LoanPurpose>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Loan Term Months [LE1.X3]
    /// </summary>
    public int? LoanTermMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Loan Term Years [LE1.X2]
    /// </summary>
    public int? LoanTermYears { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// The calculated maximum monthly payment for a $10,000 loan [LE1.X93]
    /// </summary>
    public decimal? MaximumMonthlyPaymentFor10000Loan { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// The calculated month in which the maximum monthly payment will go into effect [LE1.X94]
    /// </summary>
    public int? MaximumPaymentMonth { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Monthly Principal and Interest - Will be Adjusted in Year/Month [LE1.X88]
    /// </summary>
    public StringEnumValue<MonthOrYear> MonthlyPiAdjustedInDateType { get => GetValue<StringEnumValue<MonthOrYear>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Monthly Principal and Interest will Adjusts Every [LE1.X19]
    /// </summary>
    public string? MonthlyPiAdjustsEveryYears { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Monthly Principal and Interest Will be Adjusted in Year [LE1.X25]
    /// </summary>
    public int? MonthlyPiAdjustsInYear { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Monthly Principal and Interest - Adjusts Starting in [LE1.X21]
    /// </summary>
    public StringEnumValue<MonthOrYear> MonthlyPiAdjustsStartingInType { get => GetValue<StringEnumValue<MonthOrYear>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Monthly Principal and Interest - Adjusts Every Months/Year/Years [LE1.X20]
    /// </summary>
    public StringEnumValue<TermType> MonthlyPiAdjustsTermType { get => GetValue<StringEnumValue<TermType>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Monthly Principal and Interest - After Adjustment [LE1.X22]
    /// </summary>
    public int? MonthlyPiAfterAdjustment { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Monthly Principal and Interest Can go or Goes [LE1.X23]
    /// </summary>
    public StringEnumValue<CanGoOrGoes> MonthlyPiCanGoGoes { get => GetValue<StringEnumValue<CanGoOrGoes>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Monthly Principal and Interest - Interest Only in Year/Month [LE1.X89]
    /// </summary>
    public StringEnumValue<MonthOrYear> MonthlyPiInterestOnlyDateType { get => GetValue<StringEnumValue<MonthOrYear>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Monthly Principal and Interest - Includes only interest and no principal until year [LE1.X26]
    /// </summary>
    public int? MonthlyPiInterestOnlyUntilYear { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Estimated Escrow Amount [LE1.X46]
    /// </summary>
    public int? Ppc1EstimatedEscrowAmount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Estimated Escrow Amount UI Value [LE1.XD46]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1EstimatedEscrowAmountUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Interest Only [LE1.X44]
    /// </summary>
    public bool? Ppc1InterestOnly { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Maximum Monthly Payment [LE1.X48]
    /// </summary>
    public decimal? Ppc1MaximumMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Maximum Monthly Payment UI Value [LE1.XD48]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1MaximumMonthlyPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Maximum Principal and Interest Payment [LE1.X43]
    /// </summary>
    public decimal? Ppc1MaximumPiPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Maximum Principal and Interest Payment UI Value [LE1.XD43]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1MaximumPiPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Mortgage Insurance Amount [LE1.X45]
    /// </summary>
    public int? Ppc1MiAmount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Mortgage Insurance Amount UI Value [LE1.XD45]
    /// </summary>
    public string? Ppc1MiAmountUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Minimum Monthly Payment [LE1.X47]
    /// </summary>
    public int? Ppc1MinimumMonthlyPayment { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Minimum Monthly Payment UI Value [LE1.XD47]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1MinimumMonthlyPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Minimum Principal and Interest Payment [LE1.X42]
    /// </summary>
    public decimal? Ppc1MinimumPiPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Minimum Principal and Interest Payment UI Value [LE1.XD42]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1MinimumPiPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Year [LE1.X41]
    /// </summary>
    public int? Ppc1Year { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Estimated Escrow Amount [LE1.X55]
    /// </summary>
    public int? Ppc2EstimatedEscrowAmount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Estimated Escrow Amount UI Value [LE1.XD55]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2EstimatedEscrowAmountUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Interest Only [LE1.X53]
    /// </summary>
    public bool? Ppc2InterestOnly { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Maximum Monthly Payment [LE1.X57]
    /// </summary>
    public decimal? Ppc2MaximumMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Maximum Monthly Payment UI Value [LE1.XD57]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2MaximumMonthlyPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Maximum Principal and Interest Payment [LE1.X52]
    /// </summary>
    public decimal? Ppc2MaximumPiPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Maximum Principal and Interest Payment UI Value [LE1.XD52]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2MaximumPiPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Mortgage Insurance Amount [LE1.X54]
    /// </summary>
    public int? Ppc2MiAmount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Mortgage Insurance Amount UI Value [LE1.XD54]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2MiAmountUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Minimum Monthly Payment [LE1.X56]
    /// </summary>
    public int? Ppc2MinimumMonthlyPayment { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Minimum Monthly Payment UI Value [LE1.XD56]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2MinimumMonthlyPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Minimum Principal and Interest Payment [LE1.X51]
    /// </summary>
    public decimal? Ppc2MinimumPiPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Minimum Principal and Interest Payment UI Value [LE1.XD51]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2MinimumPiPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Year From [LE1.X49]
    /// </summary>
    public int? Ppc2YearFrom { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Year To [LE1.X50]
    /// </summary>
    public int? Ppc2YearTo { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Estimated Escrow Amount [LE1.X64]
    /// </summary>
    public int? Ppc3EstimatedEscrowAmount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Estimated Escrow Amount UI Value [LE1.XD64]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3EstimatedEscrowAmountUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Interest Only [LE1.X62]
    /// </summary>
    public bool? Ppc3InterestOnly { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Maximum Monthly Payment [LE1.X66]
    /// </summary>
    public decimal? Ppc3MaximumMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Maximum Monthly Payment UI Value [LE1.XD66]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3MaximumMonthlyPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Maximum Principal and Interest Payment [LE1.X61]
    /// </summary>
    public decimal? Ppc3MaximumPiPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Maximum Principal and Interest Payment UI Value [LE1.XD61]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3MaximumPiPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Mortgage Insurance Amount [LE1.X63]
    /// </summary>
    public int? Ppc3MiAmount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Mortgage Insurance Amount UI Value [LE1.XD63]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3MiAmountUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Minimum Monthly Payment [LE1.X65]
    /// </summary>
    public int? Ppc3MinimumMonthlyPayment { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Minimum Monthly Payment UI Value [LE1.XD65]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3MinimumMonthlyPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Minimum Principal and Interest Payment [LE1.X60]
    /// </summary>
    public decimal? Ppc3MinimumPiPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Minimum Principal and Interest Payment UI Value [LE1.XD60]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3MinimumPiPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Year From [LE1.X58]
    /// </summary>
    public int? Ppc3YearFrom { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Year To [LE1.X59]
    /// </summary>
    public int? Ppc3YearTo { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Estimated Escrow Amount [LE1.X73]
    /// </summary>
    public int? Ppc4EstimatedEscrowAmount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Estimated Escrow Amount UI Value [LE1.XD73]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4EstimatedEscrowAmountUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Interest Only [LE1.X71]
    /// </summary>
    public bool? Ppc4InterestOnly { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Maximum Monthly Payment [LE1.X75]
    /// </summary>
    public decimal? Ppc4MaximumMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Maximum Monthly Payment UI Value [LE1.XD75]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4MaximumMonthlyPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Maximum Principal and Interest Payment [LE1.X70]
    /// </summary>
    public decimal? Ppc4MaximumPiPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Maximum Principal and Interest Payment UI Value [LE1.XD70]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4MaximumPiPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Mortgage Insurance Amount [LE1.X72]
    /// </summary>
    public int? Ppc4MiAmount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Mortgage Insurance Amount UI Value [LE1.XD72]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4MiAmountUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Minimum Monthly Payment [LE1.X74]
    /// </summary>
    public int? Ppc4MinimumMonthlyPayment { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Minimum Monthly Payment UI Value [LE1.XD74]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4MinimumMonthlyPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Minimum Principal and Interest Payment [LE1.X69]
    /// </summary>
    public decimal? Ppc4MinimumPiPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Minimum Principal and Interest Payment UI Value [LE1.XD69]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4MinimumPiPaymentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Year From [LE1.X67]
    /// </summary>
    public int? Ppc4YearFrom { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Year To [LE1.X68]
    /// </summary>
    public int? Ppc4YearTo { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Estimated Escrow Indicator [LE1.X77]
    /// </summary>
    public bool? PpestimatedEscrowIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Prepayment Penalty - If you pay off the loan during the first [LE1.X27]
    /// </summary>
    public int? PrepaymentPenaltyPayOffDuringYear { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Prepayment Penalty - In Year/Month [LE1.X91]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Month\"]")]
    public StringEnumValue<TermType> PrepaymentPenaltyPayOffInDateType { get => GetValue<StringEnumValue<TermType>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Prepayment Penalty - In First Year [LE1.XD27]
    /// </summary>
    public string? PrepaymentPenaltyPayOffInFirstYear { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Range Payment Indicator [LE1.XD1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? RangePaymentIndicatorC1 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Range Payment Indicator [LE1.XD2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? RangePaymentIndicatorC2 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Range Payment Indicator [LE1.XD3]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? RangePaymentIndicatorC3 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Range Payment Indicator [LE1.XD4]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? RangePaymentIndicatorC4 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Rate Lock Expiration Time [LE1.X6]
    /// </summary>
    public string? RateLockExpirationTime { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Rate Lock Expiration Time Zone [LE1.X7]
    /// </summary>
    public string? RateLockExpirationTimeZone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Reason Changed Circumstance Flags [LE1.X90]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ReasonChangedCircumstanceFlags { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Delayed Settlement on Construction Loans [LE1.X83]
    /// </summary>
    public bool? ReasonDelayedSettlement { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Changed Circumstance - Eligibility [LE1.X79]
    /// </summary>
    public bool? ReasonEligibility { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Expiration (Intent to Proceed received after 10 business days) [LE1.X82]
    /// </summary>
    public bool? ReasonExpiration { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Interest Rate dependent charges (Rate Lock) [LE1.X81]
    /// </summary>
    public bool? ReasonInterestRate { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Other [LE1.X84]
    /// </summary>
    public bool? ReasonOther { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Other Description [LE1.X85]
    /// </summary>
    public string? ReasonOtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Revisions requested by the consumer [LE1.X80]
    /// </summary>
    public bool? ReasonRevisions { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Changed Circumstance - Settlement Charges [LE1.X78]
    /// </summary>
    public bool? ReasonSettlementCharges { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Total Estimated Cash to Close [LE1.X87]
    /// </summary>
    public decimal? TotalEstimatedCashClose { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate - Year Until [LE1.X12]
    /// </summary>
    public int? YearsToRecast { get => GetValue<int?>(); set => SetValue(value); }
}