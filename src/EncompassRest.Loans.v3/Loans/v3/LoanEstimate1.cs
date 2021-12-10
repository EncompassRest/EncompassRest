using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LoanEstimate1
/// </summary>
public sealed partial class LoanEstimate1 : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<StringEnumValue<TermType>>? _adjustsTermType;
    private DirtyValue<StringEnumValue<MonthOrYear>>? _balloonPaymentDueInTermLabel;
    private DirtyValue<string?>? _changedCircumstanceComments;
    private DirtyValue<DateTime?>? _closingCostEstimateExpirationDate;
    private DirtyValue<string?>? _closingCostEstimateExpirationDateUi;
    private DirtyValue<string?>? _closingCostEstimateExpirationTime;
    private DirtyValue<string?>? _closingCostEstimateExpirationTimeUi;
    private DirtyValue<StringEnumValue<SpecificTimeZone>>? _closingCostEstimateExpirationTimeZone;
    private DirtyValue<string?>? _closingCostEstimateExpirationTimeZoneUi;
    private DirtyValue<StringEnumValue<Conversion>>? _conversionBegin;
    private DirtyValue<StringEnumValue<Conversion>>? _conversionEnd;
    private DirtyValue<string?>? _disclosureBy;
    private DirtyValue<DateTime?>? _disclosureClosingCostExpDate;
    private DirtyValue<string?>? _disclosureClosingCostExpTime;
    private DirtyValue<string?>? _disclosureClosingCostExpTimeZone;
    private DirtyValue<string?>? _disclosureComments;
    private DirtyValue<DateTime?>? _disclosureLastSentDate;
    private DirtyValue<DateTime?>? _disclosureReceivedDate;
    private DirtyValue<string?>? _disclosureSentMethod;
    private DirtyValue<decimal?>? _estimatedTaxesInsuranceAssessments;
    private DirtyValue<string?>? _estimatedTaxesInsuranceAssessmentsUi;
    private DirtyValue<StringEnumValue<ExpirationGenericTimeZone>>? _expirationGenericTimeZone;
    private DirtyValue<decimal?>? _highestMonthlyPi;
    private DirtyValue<string?>? _inEscrowHomeownerInsurance;
    private DirtyValue<string?>? _inEscrowOther;
    private DirtyValue<string?>? _inEscrowPropertyTaxes;
    private DirtyValue<decimal?>? _initialMonthlyPaymentFor10000Loan;
    private DirtyValue<decimal?>? _initialMonthlyPaymentFor60000Loan;
    private DirtyValue<StringEnumValue<MonthOrYear>>? _interestRateAdjTermLabel;
    private DirtyValue<string?>? _interestRateAdjustsEveryYears;
    private DirtyValue<int?>? _interestRateAdjustsInYear;
    private DirtyValue<StringEnumValue<MonthOrYear>>? _interestRateAdjustsStartingInType;
    private DirtyValue<int?>? _interestRateAfterAdjustment;
    private DirtyValue<StringEnumValue<CanGoOrGoes>>? _interestRateCanGoGoes;
    private DirtyValue<DateTime?>? _leDateIssued;
    private DirtyValue<StringEnumValue<CanGoOrGoes>>? _loanAmountCanGoGoes;
    private DirtyValue<StringEnumValue<CanIncreaseOrIncreases>>? _loanAmountCanIncreaseOrIncreases;
    private DirtyValue<string?>? _loanProduct;
    private DirtyValue<StringEnumValue<LoanEstimate1LoanPurpose>>? _loanPurpose;
    private DirtyValue<int?>? _loanTermMonths;
    private DirtyValue<int?>? _loanTermYears;
    private DirtyValue<decimal?>? _maximumMonthlyPaymentFor10000Loan;
    private DirtyValue<int?>? _maximumPaymentMonth;
    private DirtyValue<StringEnumValue<MonthOrYear>>? _monthlyPiAdjustedInDateType;
    private DirtyValue<string?>? _monthlyPiAdjustsEveryYears;
    private DirtyValue<int?>? _monthlyPiAdjustsInYear;
    private DirtyValue<StringEnumValue<MonthOrYear>>? _monthlyPiAdjustsStartingInType;
    private DirtyValue<StringEnumValue<TermType>>? _monthlyPiAdjustsTermType;
    private DirtyValue<int?>? _monthlyPiAfterAdjustment;
    private DirtyValue<StringEnumValue<CanGoOrGoes>>? _monthlyPiCanGoGoes;
    private DirtyValue<StringEnumValue<MonthOrYear>>? _monthlyPiInterestOnlyDateType;
    private DirtyValue<int?>? _monthlyPiInterestOnlyUntilYear;
    private DirtyValue<int?>? _ppc1EstimatedEscrowAmount;
    private DirtyValue<string?>? _ppc1EstimatedEscrowAmountUi;
    private DirtyValue<bool?>? _ppc1InterestOnly;
    private DirtyValue<decimal?>? _ppc1MaximumMonthlyPayment;
    private DirtyValue<string?>? _ppc1MaximumMonthlyPaymentUi;
    private DirtyValue<decimal?>? _ppc1MaximumPiPayment;
    private DirtyValue<string?>? _ppc1MaximumPiPaymentUi;
    private DirtyValue<int?>? _ppc1MiAmount;
    private DirtyValue<string?>? _ppc1MiAmountUi;
    private DirtyValue<int?>? _ppc1MinimumMonthlyPayment;
    private DirtyValue<string?>? _ppc1MinimumMonthlyPaymentUi;
    private DirtyValue<decimal?>? _ppc1MinimumPiPayment;
    private DirtyValue<string?>? _ppc1MinimumPiPaymentUi;
    private DirtyValue<int?>? _ppc1Year;
    private DirtyValue<int?>? _ppc2EstimatedEscrowAmount;
    private DirtyValue<string?>? _ppc2EstimatedEscrowAmountUi;
    private DirtyValue<bool?>? _ppc2InterestOnly;
    private DirtyValue<decimal?>? _ppc2MaximumMonthlyPayment;
    private DirtyValue<string?>? _ppc2MaximumMonthlyPaymentUi;
    private DirtyValue<decimal?>? _ppc2MaximumPiPayment;
    private DirtyValue<string?>? _ppc2MaximumPiPaymentUi;
    private DirtyValue<int?>? _ppc2MiAmount;
    private DirtyValue<string?>? _ppc2MiAmountUi;
    private DirtyValue<int?>? _ppc2MinimumMonthlyPayment;
    private DirtyValue<string?>? _ppc2MinimumMonthlyPaymentUi;
    private DirtyValue<decimal?>? _ppc2MinimumPiPayment;
    private DirtyValue<string?>? _ppc2MinimumPiPaymentUi;
    private DirtyValue<int?>? _ppc2YearFrom;
    private DirtyValue<int?>? _ppc2YearTo;
    private DirtyValue<int?>? _ppc3EstimatedEscrowAmount;
    private DirtyValue<string?>? _ppc3EstimatedEscrowAmountUi;
    private DirtyValue<bool?>? _ppc3InterestOnly;
    private DirtyValue<decimal?>? _ppc3MaximumMonthlyPayment;
    private DirtyValue<string?>? _ppc3MaximumMonthlyPaymentUi;
    private DirtyValue<decimal?>? _ppc3MaximumPiPayment;
    private DirtyValue<string?>? _ppc3MaximumPiPaymentUi;
    private DirtyValue<int?>? _ppc3MiAmount;
    private DirtyValue<string?>? _ppc3MiAmountUi;
    private DirtyValue<int?>? _ppc3MinimumMonthlyPayment;
    private DirtyValue<string?>? _ppc3MinimumMonthlyPaymentUi;
    private DirtyValue<decimal?>? _ppc3MinimumPiPayment;
    private DirtyValue<string?>? _ppc3MinimumPiPaymentUi;
    private DirtyValue<int?>? _ppc3YearFrom;
    private DirtyValue<int?>? _ppc3YearTo;
    private DirtyValue<int?>? _ppc4EstimatedEscrowAmount;
    private DirtyValue<string?>? _ppc4EstimatedEscrowAmountUi;
    private DirtyValue<bool?>? _ppc4InterestOnly;
    private DirtyValue<decimal?>? _ppc4MaximumMonthlyPayment;
    private DirtyValue<string?>? _ppc4MaximumMonthlyPaymentUi;
    private DirtyValue<decimal?>? _ppc4MaximumPiPayment;
    private DirtyValue<string?>? _ppc4MaximumPiPaymentUi;
    private DirtyValue<int?>? _ppc4MiAmount;
    private DirtyValue<string?>? _ppc4MiAmountUi;
    private DirtyValue<int?>? _ppc4MinimumMonthlyPayment;
    private DirtyValue<string?>? _ppc4MinimumMonthlyPaymentUi;
    private DirtyValue<decimal?>? _ppc4MinimumPiPayment;
    private DirtyValue<string?>? _ppc4MinimumPiPaymentUi;
    private DirtyValue<int?>? _ppc4YearFrom;
    private DirtyValue<int?>? _ppc4YearTo;
    private DirtyValue<bool?>? _ppestimatedEscrowIndicator;
    private DirtyValue<int?>? _prepaymentPenaltyPayOffDuringYear;
    private DirtyValue<StringEnumValue<TermType>>? _prepaymentPenaltyPayOffInDateType;
    private DirtyValue<string?>? _prepaymentPenaltyPayOffInFirstYear;
    private DirtyValue<bool?>? _rangePaymentIndicatorC1;
    private DirtyValue<bool?>? _rangePaymentIndicatorC2;
    private DirtyValue<bool?>? _rangePaymentIndicatorC3;
    private DirtyValue<bool?>? _rangePaymentIndicatorC4;
    private DirtyValue<string?>? _rateLockExpirationTime;
    private DirtyValue<string?>? _rateLockExpirationTimeZone;
    private DirtyValue<string?>? _reasonChangedCircumstanceFlags;
    private DirtyValue<bool?>? _reasonDelayedSettlement;
    private DirtyValue<bool?>? _reasonEligibility;
    private DirtyValue<bool?>? _reasonExpiration;
    private DirtyValue<bool?>? _reasonInterestRate;
    private DirtyValue<bool?>? _reasonOther;
    private DirtyValue<string?>? _reasonOtherDescription;
    private DirtyValue<bool?>? _reasonRevisions;
    private DirtyValue<bool?>? _reasonSettlementCharges;
    private DirtyValue<decimal?>? _totalEstimatedCashClose;
    private DirtyValue<int?>? _yearsToRecast;

    /// <summary>
    /// Loan Estimate - Interest Rate - Adjusts Every Months/Year/Years [LE1.X14]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Month\"]")]
    public StringEnumValue<TermType> AdjustsTermType { get => _adjustsTermType; set => SetField(ref _adjustsTermType, value); }

    /// <summary>
    /// Balloon Payment Period [LE1.X98]
    /// </summary>
    public StringEnumValue<MonthOrYear> BalloonPaymentDueInTermLabel { get => _balloonPaymentDueInTermLabel; set => SetField(ref _balloonPaymentDueInTermLabel, value); }

    /// <summary>
    /// Comments [LE1.X86]
    /// </summary>
    public string? ChangedCircumstanceComments { get => _changedCircumstanceComments; set => SetField(ref _changedCircumstanceComments, value); }

    /// <summary>
    /// Loan Estimate - Closing Costs Estimate Expiration Date [LE1.X28]
    /// </summary>
    public DateTime? ClosingCostEstimateExpirationDate { get => _closingCostEstimateExpirationDate; set => SetField(ref _closingCostEstimateExpirationDate, value); }

    /// <summary>
    /// Loan Estimate - Closing Costs Estimate Expiration Date UI Value [LE1.XD28]
    /// </summary>
    public string? ClosingCostEstimateExpirationDateUi { get => _closingCostEstimateExpirationDateUi; set => SetField(ref _closingCostEstimateExpirationDateUi, value); }

    /// <summary>
    /// Loan Estimate - Closing Costs Estimate Expiration Time [LE1.X8]
    /// </summary>
    public string? ClosingCostEstimateExpirationTime { get => _closingCostEstimateExpirationTime; set => SetField(ref _closingCostEstimateExpirationTime, value); }

    /// <summary>
    /// Loan Estimate - Closing Costs Estimate Expiration Time UI Value [LE1.XD8]
    /// </summary>
    public string? ClosingCostEstimateExpirationTimeUi { get => _closingCostEstimateExpirationTimeUi; set => SetField(ref _closingCostEstimateExpirationTimeUi, value); }

    /// <summary>
    /// Loan Estimate - Closing Costs Estimate Expiration Time Zone [LE1.X9]
    /// </summary>
    public StringEnumValue<SpecificTimeZone> ClosingCostEstimateExpirationTimeZone { get => _closingCostEstimateExpirationTimeZone; set => SetField(ref _closingCostEstimateExpirationTimeZone, value); }

    /// <summary>
    /// Loan Estimate - Closing Costs Estimate Expiration Time Zone UI Value [LE1.XD9]
    /// </summary>
    public string? ClosingCostEstimateExpirationTimeZoneUi { get => _closingCostEstimateExpirationTimeZoneUi; set => SetField(ref _closingCostEstimateExpirationTimeZoneUi, value); }

    /// <summary>
    /// Conversion Begin Period [LE1.X96]
    /// </summary>
    public StringEnumValue<Conversion> ConversionBegin { get => _conversionBegin; set => SetField(ref _conversionBegin, value); }

    /// <summary>
    /// Conversion End Period [LE1.X97]
    /// </summary>
    public StringEnumValue<Conversion> ConversionEnd { get => _conversionEnd; set => SetField(ref _conversionEnd, value); }

    /// <summary>
    /// Loan Estimate - Disclosure By [LE1.X34]
    /// </summary>
    public string? DisclosureBy { get => _disclosureBy; set => SetField(ref _disclosureBy, value); }

    /// <summary>
    /// Loan Estimate - Disclosure Closing Cost Exp. Date [LE1.X36]
    /// </summary>
    public DateTime? DisclosureClosingCostExpDate { get => _disclosureClosingCostExpDate; set => SetField(ref _disclosureClosingCostExpDate, value); }

    /// <summary>
    /// Loan Estimate - Disclosure Expiration Time [LE1.X37]
    /// </summary>
    public string? DisclosureClosingCostExpTime { get => _disclosureClosingCostExpTime; set => SetField(ref _disclosureClosingCostExpTime, value); }

    /// <summary>
    /// Loan Estimate - Disclosure Expiration Time Zone [LE1.X38]
    /// </summary>
    public string? DisclosureClosingCostExpTimeZone { get => _disclosureClosingCostExpTimeZone; set => SetField(ref _disclosureClosingCostExpTimeZone, value); }

    /// <summary>
    /// Loan Estimate - Disclosure Comments [LE1.X40]
    /// </summary>
    public string? DisclosureComments { get => _disclosureComments; set => SetField(ref _disclosureComments, value); }

    /// <summary>
    /// Loan Estimate - Disclosure Last Sent Date [LE1.X33]
    /// </summary>
    public DateTime? DisclosureLastSentDate { get => _disclosureLastSentDate; set => SetField(ref _disclosureLastSentDate, value); }

    /// <summary>
    /// Loan Estimate - Disclosure Received Date [LE1.X39]
    /// </summary>
    public DateTime? DisclosureReceivedDate { get => _disclosureReceivedDate; set => SetField(ref _disclosureReceivedDate, value); }

    /// <summary>
    /// Loan Estimate - Disclosure Sent Method [LE1.X35]
    /// </summary>
    public string? DisclosureSentMethod { get => _disclosureSentMethod; set => SetField(ref _disclosureSentMethod, value); }

    /// <summary>
    /// Loan Estimate - Estimated Taxes, Insurance and Assessments [LE1.X29]
    /// </summary>
    public decimal? EstimatedTaxesInsuranceAssessments { get => _estimatedTaxesInsuranceAssessments; set => SetField(ref _estimatedTaxesInsuranceAssessments, value); }

    /// <summary>
    /// Loan Estimate - Estimated Taxes, Insurance and Assessments UI Value [LE1.XD29]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? EstimatedTaxesInsuranceAssessmentsUi { get => _estimatedTaxesInsuranceAssessmentsUi; set => SetField(ref _estimatedTaxesInsuranceAssessmentsUi, value); }

    /// <summary>
    /// Loan Estimate - Closing Costs Estimate Expiration Generic Time Zone [LE1.XG9]
    /// </summary>
    public StringEnumValue<ExpirationGenericTimeZone> ExpirationGenericTimeZone { get => _expirationGenericTimeZone; set => SetField(ref _expirationGenericTimeZone, value); }

    /// <summary>
    /// Loan Estimate - Monthly Principal and Interest Will be Adjusted in Year [LE1.X24]
    /// </summary>
    public decimal? HighestMonthlyPi { get => _highestMonthlyPi; set => SetField(ref _highestMonthlyPi, value); }

    /// <summary>
    /// Loan Estimate - In Escrow Homeowner Insurance [LE1.X31]
    /// </summary>
    public string? InEscrowHomeownerInsurance { get => _inEscrowHomeownerInsurance; set => SetField(ref _inEscrowHomeownerInsurance, value); }

    /// <summary>
    /// Loan Estimate - In Escrow Other [LE1.X32]
    /// </summary>
    public string? InEscrowOther { get => _inEscrowOther; set => SetField(ref _inEscrowOther, value); }

    /// <summary>
    /// Loan Estimate - In Escrow Property Taxes [LE1.X30]
    /// </summary>
    public string? InEscrowPropertyTaxes { get => _inEscrowPropertyTaxes; set => SetField(ref _inEscrowPropertyTaxes, value); }

    /// <summary>
    /// The calculated initial monthly payment for a $10,000 loan [LE1.X92]
    /// </summary>
    public decimal? InitialMonthlyPaymentFor10000Loan { get => _initialMonthlyPaymentFor10000Loan; set => SetField(ref _initialMonthlyPaymentFor10000Loan, value); }

    /// <summary>
    /// The calculation initial monthly payment for a $60,000 loan [LE1.X95]
    /// </summary>
    public decimal? InitialMonthlyPaymentFor60000Loan { get => _initialMonthlyPaymentFor60000Loan; set => SetField(ref _initialMonthlyPaymentFor60000Loan, value); }

    /// <summary>
    /// Maximum Interest Period [LE1.X99]
    /// </summary>
    public StringEnumValue<MonthOrYear> InterestRateAdjTermLabel { get => _interestRateAdjTermLabel; set => SetField(ref _interestRateAdjTermLabel, value); }

    /// <summary>
    /// Loan Estimate - Interest Rate will Adjusts Every [LE1.X13]
    /// </summary>
    public string? InterestRateAdjustsEveryYears { get => _interestRateAdjustsEveryYears; set => SetField(ref _interestRateAdjustsEveryYears, value); }

    /// <summary>
    /// Loan Estimate - Interest Rate Will be Adjusted in Year/Month [LE1.X18]
    /// </summary>
    public int? InterestRateAdjustsInYear { get => _interestRateAdjustsInYear; set => SetField(ref _interestRateAdjustsInYear, value); }

    /// <summary>
    /// Loan Estimate - Interest Rate - Adjusts Starting in [LE1.X15]
    /// </summary>
    public StringEnumValue<MonthOrYear> InterestRateAdjustsStartingInType { get => _interestRateAdjustsStartingInType; set => SetField(ref _interestRateAdjustsStartingInType, value); }

    /// <summary>
    /// Loan Estimate - Interest Rate After Adjustment [LE1.X16]
    /// </summary>
    public int? InterestRateAfterAdjustment { get => _interestRateAfterAdjustment; set => SetField(ref _interestRateAfterAdjustment, value); }

    /// <summary>
    /// Loan Estimate - Interest Rate Can go or Goes [LE1.X17]
    /// </summary>
    public StringEnumValue<CanGoOrGoes> InterestRateCanGoGoes { get => _interestRateCanGoGoes; set => SetField(ref _interestRateCanGoGoes, value); }

    /// <summary>
    /// Loan Estimate - LE Date Issued [LE1.X1]
    /// </summary>
    public DateTime? LeDateIssued { get => _leDateIssued; set => SetField(ref _leDateIssued, value); }

    /// <summary>
    /// Loan Estimate - Loan Amount Can go or Goes [LE1.X10]
    /// </summary>
    public StringEnumValue<CanGoOrGoes> LoanAmountCanGoGoes { get => _loanAmountCanGoGoes; set => SetField(ref _loanAmountCanGoGoes, value); }

    /// <summary>
    /// Loan Estimate - Loan Amount Can increase or Increases [LE1.X11]
    /// </summary>
    public StringEnumValue<CanIncreaseOrIncreases> LoanAmountCanIncreaseOrIncreases { get => _loanAmountCanIncreaseOrIncreases; set => SetField(ref _loanAmountCanIncreaseOrIncreases, value); }

    /// <summary>
    /// Product Description [LE1.X5]
    /// </summary>
    public string? LoanProduct { get => _loanProduct; set => SetField(ref _loanProduct, value); }

    /// <summary>
    /// Loan Estimate - Loan Purpose [LE1.X4]
    /// </summary>
    public StringEnumValue<LoanEstimate1LoanPurpose> LoanPurpose { get => _loanPurpose; set => SetField(ref _loanPurpose, value); }

    /// <summary>
    /// Loan Estimate - Loan Term Months [LE1.X3]
    /// </summary>
    public int? LoanTermMonths { get => _loanTermMonths; set => SetField(ref _loanTermMonths, value); }

    /// <summary>
    /// Loan Estimate - Loan Term Years [LE1.X2]
    /// </summary>
    public int? LoanTermYears { get => _loanTermYears; set => SetField(ref _loanTermYears, value); }

    /// <summary>
    /// The calculated maximum monthly payment for a $10,000 loan [LE1.X93]
    /// </summary>
    public decimal? MaximumMonthlyPaymentFor10000Loan { get => _maximumMonthlyPaymentFor10000Loan; set => SetField(ref _maximumMonthlyPaymentFor10000Loan, value); }

    /// <summary>
    /// The calculated month in which the maximum monthly payment will go into effect [LE1.X94]
    /// </summary>
    public int? MaximumPaymentMonth { get => _maximumPaymentMonth; set => SetField(ref _maximumPaymentMonth, value); }

    /// <summary>
    /// Loan Estimate - Monthly Principal and Interest - Will be Adjusted in Year/Month [LE1.X88]
    /// </summary>
    public StringEnumValue<MonthOrYear> MonthlyPiAdjustedInDateType { get => _monthlyPiAdjustedInDateType; set => SetField(ref _monthlyPiAdjustedInDateType, value); }

    /// <summary>
    /// Loan Estimate - Monthly Principal and Interest will Adjusts Every [LE1.X19]
    /// </summary>
    public string? MonthlyPiAdjustsEveryYears { get => _monthlyPiAdjustsEveryYears; set => SetField(ref _monthlyPiAdjustsEveryYears, value); }

    /// <summary>
    /// Loan Estimate - Monthly Principal and Interest Will be Adjusted in Year [LE1.X25]
    /// </summary>
    public int? MonthlyPiAdjustsInYear { get => _monthlyPiAdjustsInYear; set => SetField(ref _monthlyPiAdjustsInYear, value); }

    /// <summary>
    /// Loan Estimate - Monthly Principal and Interest - Adjusts Starting in [LE1.X21]
    /// </summary>
    public StringEnumValue<MonthOrYear> MonthlyPiAdjustsStartingInType { get => _monthlyPiAdjustsStartingInType; set => SetField(ref _monthlyPiAdjustsStartingInType, value); }

    /// <summary>
    /// Loan Estimate - Monthly Principal and Interest - Adjusts Every Months/Year/Years [LE1.X20]
    /// </summary>
    public StringEnumValue<TermType> MonthlyPiAdjustsTermType { get => _monthlyPiAdjustsTermType; set => SetField(ref _monthlyPiAdjustsTermType, value); }

    /// <summary>
    /// Loan Estimate - Monthly Principal and Interest - After Adjustment [LE1.X22]
    /// </summary>
    public int? MonthlyPiAfterAdjustment { get => _monthlyPiAfterAdjustment; set => SetField(ref _monthlyPiAfterAdjustment, value); }

    /// <summary>
    /// Loan Estimate - Monthly Principal and Interest Can go or Goes [LE1.X23]
    /// </summary>
    public StringEnumValue<CanGoOrGoes> MonthlyPiCanGoGoes { get => _monthlyPiCanGoGoes; set => SetField(ref _monthlyPiCanGoGoes, value); }

    /// <summary>
    /// Loan Estimate - Monthly Principal and Interest - Interest Only in Year/Month [LE1.X89]
    /// </summary>
    public StringEnumValue<MonthOrYear> MonthlyPiInterestOnlyDateType { get => _monthlyPiInterestOnlyDateType; set => SetField(ref _monthlyPiInterestOnlyDateType, value); }

    /// <summary>
    /// Loan Estimate - Monthly Principal and Interest - Includes only interest and no principal until year [LE1.X26]
    /// </summary>
    public int? MonthlyPiInterestOnlyUntilYear { get => _monthlyPiInterestOnlyUntilYear; set => SetField(ref _monthlyPiInterestOnlyUntilYear, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Estimated Escrow Amount [LE1.X46]
    /// </summary>
    public int? Ppc1EstimatedEscrowAmount { get => _ppc1EstimatedEscrowAmount; set => SetField(ref _ppc1EstimatedEscrowAmount, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Estimated Escrow Amount UI Value [LE1.XD46]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1EstimatedEscrowAmountUi { get => _ppc1EstimatedEscrowAmountUi; set => SetField(ref _ppc1EstimatedEscrowAmountUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Interest Only [LE1.X44]
    /// </summary>
    public bool? Ppc1InterestOnly { get => _ppc1InterestOnly; set => SetField(ref _ppc1InterestOnly, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Maximum Monthly Payment [LE1.X48]
    /// </summary>
    public decimal? Ppc1MaximumMonthlyPayment { get => _ppc1MaximumMonthlyPayment; set => SetField(ref _ppc1MaximumMonthlyPayment, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Maximum Monthly Payment UI Value [LE1.XD48]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1MaximumMonthlyPaymentUi { get => _ppc1MaximumMonthlyPaymentUi; set => SetField(ref _ppc1MaximumMonthlyPaymentUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Maximum Principal and Interest Payment [LE1.X43]
    /// </summary>
    public decimal? Ppc1MaximumPiPayment { get => _ppc1MaximumPiPayment; set => SetField(ref _ppc1MaximumPiPayment, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Maximum Principal and Interest Payment UI Value [LE1.XD43]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1MaximumPiPaymentUi { get => _ppc1MaximumPiPaymentUi; set => SetField(ref _ppc1MaximumPiPaymentUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Mortgage Insurance Amount [LE1.X45]
    /// </summary>
    public int? Ppc1MiAmount { get => _ppc1MiAmount; set => SetField(ref _ppc1MiAmount, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Mortgage Insurance Amount UI Value [LE1.XD45]
    /// </summary>
    public string? Ppc1MiAmountUi { get => _ppc1MiAmountUi; set => SetField(ref _ppc1MiAmountUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Minimum Monthly Payment [LE1.X47]
    /// </summary>
    public int? Ppc1MinimumMonthlyPayment { get => _ppc1MinimumMonthlyPayment; set => SetField(ref _ppc1MinimumMonthlyPayment, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Minimum Monthly Payment UI Value [LE1.XD47]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1MinimumMonthlyPaymentUi { get => _ppc1MinimumMonthlyPaymentUi; set => SetField(ref _ppc1MinimumMonthlyPaymentUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Minimum Principal and Interest Payment [LE1.X42]
    /// </summary>
    public decimal? Ppc1MinimumPiPayment { get => _ppc1MinimumPiPayment; set => SetField(ref _ppc1MinimumPiPayment, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Minimum Principal and Interest Payment UI Value [LE1.XD42]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1MinimumPiPaymentUi { get => _ppc1MinimumPiPaymentUi; set => SetField(ref _ppc1MinimumPiPaymentUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Year [LE1.X41]
    /// </summary>
    public int? Ppc1Year { get => _ppc1Year; set => SetField(ref _ppc1Year, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Estimated Escrow Amount [LE1.X55]
    /// </summary>
    public int? Ppc2EstimatedEscrowAmount { get => _ppc2EstimatedEscrowAmount; set => SetField(ref _ppc2EstimatedEscrowAmount, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Estimated Escrow Amount UI Value [LE1.XD55]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2EstimatedEscrowAmountUi { get => _ppc2EstimatedEscrowAmountUi; set => SetField(ref _ppc2EstimatedEscrowAmountUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Interest Only [LE1.X53]
    /// </summary>
    public bool? Ppc2InterestOnly { get => _ppc2InterestOnly; set => SetField(ref _ppc2InterestOnly, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Maximum Monthly Payment [LE1.X57]
    /// </summary>
    public decimal? Ppc2MaximumMonthlyPayment { get => _ppc2MaximumMonthlyPayment; set => SetField(ref _ppc2MaximumMonthlyPayment, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Maximum Monthly Payment UI Value [LE1.XD57]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2MaximumMonthlyPaymentUi { get => _ppc2MaximumMonthlyPaymentUi; set => SetField(ref _ppc2MaximumMonthlyPaymentUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Maximum Principal and Interest Payment [LE1.X52]
    /// </summary>
    public decimal? Ppc2MaximumPiPayment { get => _ppc2MaximumPiPayment; set => SetField(ref _ppc2MaximumPiPayment, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Maximum Principal and Interest Payment UI Value [LE1.XD52]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2MaximumPiPaymentUi { get => _ppc2MaximumPiPaymentUi; set => SetField(ref _ppc2MaximumPiPaymentUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Mortgage Insurance Amount [LE1.X54]
    /// </summary>
    public int? Ppc2MiAmount { get => _ppc2MiAmount; set => SetField(ref _ppc2MiAmount, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Mortgage Insurance Amount UI Value [LE1.XD54]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2MiAmountUi { get => _ppc2MiAmountUi; set => SetField(ref _ppc2MiAmountUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Minimum Monthly Payment [LE1.X56]
    /// </summary>
    public int? Ppc2MinimumMonthlyPayment { get => _ppc2MinimumMonthlyPayment; set => SetField(ref _ppc2MinimumMonthlyPayment, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Minimum Monthly Payment UI Value [LE1.XD56]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2MinimumMonthlyPaymentUi { get => _ppc2MinimumMonthlyPaymentUi; set => SetField(ref _ppc2MinimumMonthlyPaymentUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Minimum Principal and Interest Payment [LE1.X51]
    /// </summary>
    public decimal? Ppc2MinimumPiPayment { get => _ppc2MinimumPiPayment; set => SetField(ref _ppc2MinimumPiPayment, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Minimum Principal and Interest Payment UI Value [LE1.XD51]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2MinimumPiPaymentUi { get => _ppc2MinimumPiPaymentUi; set => SetField(ref _ppc2MinimumPiPaymentUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Year From [LE1.X49]
    /// </summary>
    public int? Ppc2YearFrom { get => _ppc2YearFrom; set => SetField(ref _ppc2YearFrom, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Year To [LE1.X50]
    /// </summary>
    public int? Ppc2YearTo { get => _ppc2YearTo; set => SetField(ref _ppc2YearTo, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Estimated Escrow Amount [LE1.X64]
    /// </summary>
    public int? Ppc3EstimatedEscrowAmount { get => _ppc3EstimatedEscrowAmount; set => SetField(ref _ppc3EstimatedEscrowAmount, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Estimated Escrow Amount UI Value [LE1.XD64]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3EstimatedEscrowAmountUi { get => _ppc3EstimatedEscrowAmountUi; set => SetField(ref _ppc3EstimatedEscrowAmountUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Interest Only [LE1.X62]
    /// </summary>
    public bool? Ppc3InterestOnly { get => _ppc3InterestOnly; set => SetField(ref _ppc3InterestOnly, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Maximum Monthly Payment [LE1.X66]
    /// </summary>
    public decimal? Ppc3MaximumMonthlyPayment { get => _ppc3MaximumMonthlyPayment; set => SetField(ref _ppc3MaximumMonthlyPayment, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Maximum Monthly Payment UI Value [LE1.XD66]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3MaximumMonthlyPaymentUi { get => _ppc3MaximumMonthlyPaymentUi; set => SetField(ref _ppc3MaximumMonthlyPaymentUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Maximum Principal and Interest Payment [LE1.X61]
    /// </summary>
    public decimal? Ppc3MaximumPiPayment { get => _ppc3MaximumPiPayment; set => SetField(ref _ppc3MaximumPiPayment, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Maximum Principal and Interest Payment UI Value [LE1.XD61]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3MaximumPiPaymentUi { get => _ppc3MaximumPiPaymentUi; set => SetField(ref _ppc3MaximumPiPaymentUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Mortgage Insurance Amount [LE1.X63]
    /// </summary>
    public int? Ppc3MiAmount { get => _ppc3MiAmount; set => SetField(ref _ppc3MiAmount, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Mortgage Insurance Amount UI Value [LE1.XD63]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3MiAmountUi { get => _ppc3MiAmountUi; set => SetField(ref _ppc3MiAmountUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Minimum Monthly Payment [LE1.X65]
    /// </summary>
    public int? Ppc3MinimumMonthlyPayment { get => _ppc3MinimumMonthlyPayment; set => SetField(ref _ppc3MinimumMonthlyPayment, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Minimum Monthly Payment UI Value [LE1.XD65]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3MinimumMonthlyPaymentUi { get => _ppc3MinimumMonthlyPaymentUi; set => SetField(ref _ppc3MinimumMonthlyPaymentUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Minimum Principal and Interest Payment [LE1.X60]
    /// </summary>
    public decimal? Ppc3MinimumPiPayment { get => _ppc3MinimumPiPayment; set => SetField(ref _ppc3MinimumPiPayment, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Minimum Principal and Interest Payment UI Value [LE1.XD60]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3MinimumPiPaymentUi { get => _ppc3MinimumPiPaymentUi; set => SetField(ref _ppc3MinimumPiPaymentUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Year From [LE1.X58]
    /// </summary>
    public int? Ppc3YearFrom { get => _ppc3YearFrom; set => SetField(ref _ppc3YearFrom, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Year To [LE1.X59]
    /// </summary>
    public int? Ppc3YearTo { get => _ppc3YearTo; set => SetField(ref _ppc3YearTo, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Estimated Escrow Amount [LE1.X73]
    /// </summary>
    public int? Ppc4EstimatedEscrowAmount { get => _ppc4EstimatedEscrowAmount; set => SetField(ref _ppc4EstimatedEscrowAmount, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Estimated Escrow Amount UI Value [LE1.XD73]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4EstimatedEscrowAmountUi { get => _ppc4EstimatedEscrowAmountUi; set => SetField(ref _ppc4EstimatedEscrowAmountUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Interest Only [LE1.X71]
    /// </summary>
    public bool? Ppc4InterestOnly { get => _ppc4InterestOnly; set => SetField(ref _ppc4InterestOnly, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Maximum Monthly Payment [LE1.X75]
    /// </summary>
    public decimal? Ppc4MaximumMonthlyPayment { get => _ppc4MaximumMonthlyPayment; set => SetField(ref _ppc4MaximumMonthlyPayment, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Maximum Monthly Payment UI Value [LE1.XD75]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4MaximumMonthlyPaymentUi { get => _ppc4MaximumMonthlyPaymentUi; set => SetField(ref _ppc4MaximumMonthlyPaymentUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Maximum Principal and Interest Payment [LE1.X70]
    /// </summary>
    public decimal? Ppc4MaximumPiPayment { get => _ppc4MaximumPiPayment; set => SetField(ref _ppc4MaximumPiPayment, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Maximum Principal and Interest Payment UI Value [LE1.XD70]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4MaximumPiPaymentUi { get => _ppc4MaximumPiPaymentUi; set => SetField(ref _ppc4MaximumPiPaymentUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Mortgage Insurance Amount [LE1.X72]
    /// </summary>
    public int? Ppc4MiAmount { get => _ppc4MiAmount; set => SetField(ref _ppc4MiAmount, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Mortgage Insurance Amount UI Value [LE1.XD72]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4MiAmountUi { get => _ppc4MiAmountUi; set => SetField(ref _ppc4MiAmountUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Minimum Monthly Payment [LE1.X74]
    /// </summary>
    public int? Ppc4MinimumMonthlyPayment { get => _ppc4MinimumMonthlyPayment; set => SetField(ref _ppc4MinimumMonthlyPayment, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Minimum Monthly Payment UI Value [LE1.XD74]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4MinimumMonthlyPaymentUi { get => _ppc4MinimumMonthlyPaymentUi; set => SetField(ref _ppc4MinimumMonthlyPaymentUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Minimum Principal and Interest Payment [LE1.X69]
    /// </summary>
    public decimal? Ppc4MinimumPiPayment { get => _ppc4MinimumPiPayment; set => SetField(ref _ppc4MinimumPiPayment, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Minimum Principal and Interest Payment UI Value [LE1.XD69]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4MinimumPiPaymentUi { get => _ppc4MinimumPiPaymentUi; set => SetField(ref _ppc4MinimumPiPaymentUi, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Year From [LE1.X67]
    /// </summary>
    public int? Ppc4YearFrom { get => _ppc4YearFrom; set => SetField(ref _ppc4YearFrom, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Year To [LE1.X68]
    /// </summary>
    public int? Ppc4YearTo { get => _ppc4YearTo; set => SetField(ref _ppc4YearTo, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Estimated Escrow Indicator [LE1.X77]
    /// </summary>
    public bool? PpestimatedEscrowIndicator { get => _ppestimatedEscrowIndicator; set => SetField(ref _ppestimatedEscrowIndicator, value); }

    /// <summary>
    /// Loan Estimate - Prepayment Penalty - If you pay off the loan during the first [LE1.X27]
    /// </summary>
    public int? PrepaymentPenaltyPayOffDuringYear { get => _prepaymentPenaltyPayOffDuringYear; set => SetField(ref _prepaymentPenaltyPayOffDuringYear, value); }

    /// <summary>
    /// Loan Estimate - Prepayment Penalty - In Year/Month [LE1.X91]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Month\"]")]
    public StringEnumValue<TermType> PrepaymentPenaltyPayOffInDateType { get => _prepaymentPenaltyPayOffInDateType; set => SetField(ref _prepaymentPenaltyPayOffInDateType, value); }

    /// <summary>
    /// Loan Estimate - Prepayment Penalty - In First Year [LE1.XD27]
    /// </summary>
    public string? PrepaymentPenaltyPayOffInFirstYear { get => _prepaymentPenaltyPayOffInFirstYear; set => SetField(ref _prepaymentPenaltyPayOffInFirstYear, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 1 - Range Payment Indicator [LE1.XD1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? RangePaymentIndicatorC1 { get => _rangePaymentIndicatorC1; set => SetField(ref _rangePaymentIndicatorC1, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 2 - Range Payment Indicator [LE1.XD2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? RangePaymentIndicatorC2 { get => _rangePaymentIndicatorC2; set => SetField(ref _rangePaymentIndicatorC2, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 3 - Range Payment Indicator [LE1.XD3]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? RangePaymentIndicatorC3 { get => _rangePaymentIndicatorC3; set => SetField(ref _rangePaymentIndicatorC3, value); }

    /// <summary>
    /// Loan Estimate - Projected Calculation - Column 4 - Range Payment Indicator [LE1.XD4]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? RangePaymentIndicatorC4 { get => _rangePaymentIndicatorC4; set => SetField(ref _rangePaymentIndicatorC4, value); }

    /// <summary>
    /// Loan Estimate - Rate Lock Expiration Time [LE1.X6]
    /// </summary>
    public string? RateLockExpirationTime { get => _rateLockExpirationTime; set => SetField(ref _rateLockExpirationTime, value); }

    /// <summary>
    /// Loan Estimate - Rate Lock Expiration Time Zone [LE1.X7]
    /// </summary>
    public string? RateLockExpirationTimeZone { get => _rateLockExpirationTimeZone; set => SetField(ref _rateLockExpirationTimeZone, value); }

    /// <summary>
    /// Loan Estimate - Reason Changed Circumstance Flags [LE1.X90]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ReasonChangedCircumstanceFlags { get => _reasonChangedCircumstanceFlags; set => SetField(ref _reasonChangedCircumstanceFlags, value); }

    /// <summary>
    /// Delayed Settlement on Construction Loans [LE1.X83]
    /// </summary>
    public bool? ReasonDelayedSettlement { get => _reasonDelayedSettlement; set => SetField(ref _reasonDelayedSettlement, value); }

    /// <summary>
    /// Changed Circumstance - Eligibility [LE1.X79]
    /// </summary>
    public bool? ReasonEligibility { get => _reasonEligibility; set => SetField(ref _reasonEligibility, value); }

    /// <summary>
    /// Expiration (Intent to Proceed received after 10 business days) [LE1.X82]
    /// </summary>
    public bool? ReasonExpiration { get => _reasonExpiration; set => SetField(ref _reasonExpiration, value); }

    /// <summary>
    /// Interest Rate dependent charges (Rate Lock) [LE1.X81]
    /// </summary>
    public bool? ReasonInterestRate { get => _reasonInterestRate; set => SetField(ref _reasonInterestRate, value); }

    /// <summary>
    /// Other [LE1.X84]
    /// </summary>
    public bool? ReasonOther { get => _reasonOther; set => SetField(ref _reasonOther, value); }

    /// <summary>
    /// Other Description [LE1.X85]
    /// </summary>
    public string? ReasonOtherDescription { get => _reasonOtherDescription; set => SetField(ref _reasonOtherDescription, value); }

    /// <summary>
    /// Revisions requested by the consumer [LE1.X80]
    /// </summary>
    public bool? ReasonRevisions { get => _reasonRevisions; set => SetField(ref _reasonRevisions, value); }

    /// <summary>
    /// Changed Circumstance - Settlement Charges [LE1.X78]
    /// </summary>
    public bool? ReasonSettlementCharges { get => _reasonSettlementCharges; set => SetField(ref _reasonSettlementCharges, value); }

    /// <summary>
    /// Total Estimated Cash to Close [LE1.X87]
    /// </summary>
    public decimal? TotalEstimatedCashClose { get => _totalEstimatedCashClose; set => SetField(ref _totalEstimatedCashClose, value); }

    /// <summary>
    /// Loan Estimate - Year Until [LE1.X12]
    /// </summary>
    public int? YearsToRecast { get => _yearsToRecast; set => SetField(ref _yearsToRecast, value); }
}