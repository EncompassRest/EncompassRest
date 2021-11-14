using System;
using EncompassRest.Loans.v1.Enums;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// LoanEstimate1
    /// </summary>
    public sealed partial class LoanEstimate1 : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<TermType>>? _adjustsTermType;
        private DirtyValue<StringEnumValue<MonthOrYear>>? _balloonPaymentDueInTermLabel;
        private DirtyValue<string?>? _changedCircumstanceComments;
        private DirtyValue<DateTime?>? _closingCostEstimateExpirationDate;
        private DirtyValue<string?>? _closingCostEstimateExpirationDateUI;
        private DirtyValue<string?>? _closingCostEstimateExpirationTime;
        private DirtyValue<string?>? _closingCostEstimateExpirationTimeUI;
        private DirtyValue<string?>? _closingCostEstimateExpirationTimeZone;
        private DirtyValue<string?>? _closingCostEstimateExpirationTimeZoneUI;
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
        private DirtyValue<string?>? _estimatedTaxesInsuranceAssessmentsUI;
        private DirtyValue<StringEnumValue<ExpirationGenericTimeZone>>? _expirationGenericTimeZone;
        private DirtyValue<decimal?>? _highestMonthlyPI;
        private DirtyValue<string?>? _id;
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
        private DirtyValue<DateTime?>? _lEDateIssued;
        private DirtyValue<StringEnumValue<CanGoOrGoes>>? _loanAmountCanGoGoes;
        private DirtyValue<StringEnumValue<CanIncreaseOrIncreases>>? _loanAmountCanIncreaseOrIncreases;
        private DirtyValue<string?>? _loanProduct;
        private DirtyValue<StringEnumValue<LoanEstimate1LoanPurpose>>? _loanPurpose;
        private DirtyValue<int?>? _loanTermMonths;
        private DirtyValue<int?>? _loanTermYears;
        private DirtyValue<decimal?>? _maximumMonthlyPaymentFor10000Loan;
        private DirtyValue<int?>? _maximumPaymentMonth;
        private DirtyValue<StringEnumValue<MonthOrYear>>? _monthlyPIAdjustedInDateType;
        private DirtyValue<string?>? _monthlyPIAdjustsEveryYears;
        private DirtyValue<int?>? _monthlyPIAdjustsInYear;
        private DirtyValue<StringEnumValue<MonthOrYear>>? _monthlyPIAdjustsStartingInType;
        private DirtyValue<StringEnumValue<TermType>>? _monthlyPIAdjustsTermType;
        private DirtyValue<int?>? _monthlyPIAfterAdjustment;
        private DirtyValue<StringEnumValue<CanGoOrGoes>>? _monthlyPICanGoGoes;
        private DirtyValue<StringEnumValue<MonthOrYear>>? _monthlyPIInterestOnlyDateType;
        private DirtyValue<int?>? _monthlyPIInterestOnlyUntilYear;
        private DirtyValue<int?>? _pPC1EstimatedEscrowAmount;
        private DirtyValue<string?>? _pPC1EstimatedEscrowAmountUI;
        private DirtyValue<bool?>? _pPC1InterestOnly;
        private DirtyValue<decimal?>? _pPC1MaximumMonthlyPayment;
        private DirtyValue<string?>? _pPC1MaximumMonthlyPaymentUI;
        private DirtyValue<decimal?>? _pPC1MaximumPIPayment;
        private DirtyValue<string?>? _pPC1MaximumPIPaymentUI;
        private DirtyValue<int?>? _pPC1MIAmount;
        private DirtyValue<string?>? _pPC1MIAmountUI;
        private DirtyValue<int?>? _pPC1MinimumMonthlyPayment;
        private DirtyValue<string?>? _pPC1MinimumMonthlyPaymentUI;
        private DirtyValue<decimal?>? _pPC1MinimumPIPayment;
        private DirtyValue<string?>? _pPC1MinimumPIPaymentUI;
        private DirtyValue<int?>? _pPC1Year;
        private DirtyValue<int?>? _pPC2EstimatedEscrowAmount;
        private DirtyValue<string?>? _pPC2EstimatedEscrowAmountUI;
        private DirtyValue<bool?>? _pPC2InterestOnly;
        private DirtyValue<decimal?>? _pPC2MaximumMonthlyPayment;
        private DirtyValue<string?>? _pPC2MaximumMonthlyPaymentUI;
        private DirtyValue<decimal?>? _pPC2MaximumPIPayment;
        private DirtyValue<string?>? _pPC2MaximumPIPaymentUI;
        private DirtyValue<int?>? _pPC2MIAmount;
        private DirtyValue<string?>? _pPC2MIAmountUI;
        private DirtyValue<int?>? _pPC2MinimumMonthlyPayment;
        private DirtyValue<string?>? _pPC2MinimumMonthlyPaymentUI;
        private DirtyValue<decimal?>? _pPC2MinimumPIPayment;
        private DirtyValue<string?>? _pPC2MinimumPIPaymentUI;
        private DirtyValue<int?>? _pPC2YearFrom;
        private DirtyValue<int?>? _pPC2YearTo;
        private DirtyValue<int?>? _pPC3EstimatedEscrowAmount;
        private DirtyValue<string?>? _pPC3EstimatedEscrowAmountUI;
        private DirtyValue<bool?>? _pPC3InterestOnly;
        private DirtyValue<decimal?>? _pPC3MaximumMonthlyPayment;
        private DirtyValue<string?>? _pPC3MaximumMonthlyPaymentUI;
        private DirtyValue<decimal?>? _pPC3MaximumPIPayment;
        private DirtyValue<string?>? _pPC3MaximumPIPaymentUI;
        private DirtyValue<int?>? _pPC3MIAmount;
        private DirtyValue<string?>? _pPC3MIAmountUI;
        private DirtyValue<int?>? _pPC3MinimumMonthlyPayment;
        private DirtyValue<string?>? _pPC3MinimumMonthlyPaymentUI;
        private DirtyValue<decimal?>? _pPC3MinimumPIPayment;
        private DirtyValue<string?>? _pPC3MinimumPIPaymentUI;
        private DirtyValue<int?>? _pPC3YearFrom;
        private DirtyValue<int?>? _pPC3YearTo;
        private DirtyValue<int?>? _pPC4EstimatedEscrowAmount;
        private DirtyValue<string?>? _pPC4EstimatedEscrowAmountUI;
        private DirtyValue<bool?>? _pPC4InterestOnly;
        private DirtyValue<decimal?>? _pPC4MaximumMonthlyPayment;
        private DirtyValue<string?>? _pPC4MaximumMonthlyPaymentUI;
        private DirtyValue<decimal?>? _pPC4MaximumPIPayment;
        private DirtyValue<string?>? _pPC4MaximumPIPaymentUI;
        private DirtyValue<int?>? _pPC4MIAmount;
        private DirtyValue<string?>? _pPC4MIAmountUI;
        private DirtyValue<int?>? _pPC4MinimumMonthlyPayment;
        private DirtyValue<string?>? _pPC4MinimumMonthlyPaymentUI;
        private DirtyValue<decimal?>? _pPC4MinimumPIPayment;
        private DirtyValue<string?>? _pPC4MinimumPIPaymentUI;
        private DirtyValue<int?>? _pPC4YearFrom;
        private DirtyValue<int?>? _pPC4YearTo;
        private DirtyValue<bool?>? _pPEstimatedEscrowIndicator;
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
        public string? ClosingCostEstimateExpirationDateUI { get => _closingCostEstimateExpirationDateUI; set => SetField(ref _closingCostEstimateExpirationDateUI, value); }

        /// <summary>
        /// Loan Estimate - Closing Costs Estimate Expiration Time [LE1.X8]
        /// </summary>
        public string? ClosingCostEstimateExpirationTime { get => _closingCostEstimateExpirationTime; set => SetField(ref _closingCostEstimateExpirationTime, value); }

        /// <summary>
        /// Loan Estimate - Closing Costs Estimate Expiration Time UI Value [LE1.XD8]
        /// </summary>
        public string? ClosingCostEstimateExpirationTimeUI { get => _closingCostEstimateExpirationTimeUI; set => SetField(ref _closingCostEstimateExpirationTimeUI, value); }

        /// <summary>
        /// Loan Estimate - Closing Costs Estimate Expiration Time Zone [LE1.X9]
        /// </summary>
        public string? ClosingCostEstimateExpirationTimeZone { get => _closingCostEstimateExpirationTimeZone; set => SetField(ref _closingCostEstimateExpirationTimeZone, value); }

        /// <summary>
        /// Loan Estimate - Closing Costs Estimate Expiration Time Zone UI Value [LE1.XD9]
        /// </summary>
        public string? ClosingCostEstimateExpirationTimeZoneUI { get => _closingCostEstimateExpirationTimeZoneUI; set => SetField(ref _closingCostEstimateExpirationTimeZoneUI, value); }

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
        public string? EstimatedTaxesInsuranceAssessmentsUI { get => _estimatedTaxesInsuranceAssessmentsUI; set => SetField(ref _estimatedTaxesInsuranceAssessmentsUI, value); }

        /// <summary>
        /// Loan Estimate - Closing Costs Estimate Expiration Generic Time Zone [LE1.XG9]
        /// </summary>
        public StringEnumValue<ExpirationGenericTimeZone> ExpirationGenericTimeZone { get => _expirationGenericTimeZone; set => SetField(ref _expirationGenericTimeZone, value); }

        /// <summary>
        /// Loan Estimate - Monthly Principal and Interest Will be Adjusted in Year [LE1.X24]
        /// </summary>
        public decimal? HighestMonthlyPI { get => _highestMonthlyPI; set => SetField(ref _highestMonthlyPI, value); }

        /// <summary>
        /// LoanEstimate1 Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

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
        public DateTime? LEDateIssued { get => _lEDateIssued; set => SetField(ref _lEDateIssued, value); }

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
        public StringEnumValue<MonthOrYear> MonthlyPIAdjustedInDateType { get => _monthlyPIAdjustedInDateType; set => SetField(ref _monthlyPIAdjustedInDateType, value); }

        /// <summary>
        /// Loan Estimate - Monthly Principal and Interest will Adjusts Every [LE1.X19]
        /// </summary>
        public string? MonthlyPIAdjustsEveryYears { get => _monthlyPIAdjustsEveryYears; set => SetField(ref _monthlyPIAdjustsEveryYears, value); }

        /// <summary>
        /// Loan Estimate - Monthly Principal and Interest Will be Adjusted in Year [LE1.X25]
        /// </summary>
        public int? MonthlyPIAdjustsInYear { get => _monthlyPIAdjustsInYear; set => SetField(ref _monthlyPIAdjustsInYear, value); }

        /// <summary>
        /// Loan Estimate - Monthly Principal and Interest - Adjusts Starting in [LE1.X21]
        /// </summary>
        public StringEnumValue<MonthOrYear> MonthlyPIAdjustsStartingInType { get => _monthlyPIAdjustsStartingInType; set => SetField(ref _monthlyPIAdjustsStartingInType, value); }

        /// <summary>
        /// Loan Estimate - Monthly Principal and Interest - Adjusts Every Months/Year/Years [LE1.X20]
        /// </summary>
        public StringEnumValue<TermType> MonthlyPIAdjustsTermType { get => _monthlyPIAdjustsTermType; set => SetField(ref _monthlyPIAdjustsTermType, value); }

        /// <summary>
        /// Loan Estimate - Monthly Principal and Interest - After Adjustment [LE1.X22]
        /// </summary>
        public int? MonthlyPIAfterAdjustment { get => _monthlyPIAfterAdjustment; set => SetField(ref _monthlyPIAfterAdjustment, value); }

        /// <summary>
        /// Loan Estimate - Monthly Principal and Interest Can go or Goes [LE1.X23]
        /// </summary>
        public StringEnumValue<CanGoOrGoes> MonthlyPICanGoGoes { get => _monthlyPICanGoGoes; set => SetField(ref _monthlyPICanGoGoes, value); }

        /// <summary>
        /// Loan Estimate - Monthly Principal and Interest - Interest Only in Year/Month [LE1.X89]
        /// </summary>
        public StringEnumValue<MonthOrYear> MonthlyPIInterestOnlyDateType { get => _monthlyPIInterestOnlyDateType; set => SetField(ref _monthlyPIInterestOnlyDateType, value); }

        /// <summary>
        /// Loan Estimate - Monthly Principal and Interest - Includes only interest and no principal until year [LE1.X26]
        /// </summary>
        public int? MonthlyPIInterestOnlyUntilYear { get => _monthlyPIInterestOnlyUntilYear; set => SetField(ref _monthlyPIInterestOnlyUntilYear, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Estimated Escrow Amount [LE1.X46]
        /// </summary>
        public int? PPC1EstimatedEscrowAmount { get => _pPC1EstimatedEscrowAmount; set => SetField(ref _pPC1EstimatedEscrowAmount, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Estimated Escrow Amount UI Value [LE1.XD46]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC1EstimatedEscrowAmountUI { get => _pPC1EstimatedEscrowAmountUI; set => SetField(ref _pPC1EstimatedEscrowAmountUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Interest Only [LE1.X44]
        /// </summary>
        public bool? PPC1InterestOnly { get => _pPC1InterestOnly; set => SetField(ref _pPC1InterestOnly, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Maximum Monthly Payment [LE1.X48]
        /// </summary>
        public decimal? PPC1MaximumMonthlyPayment { get => _pPC1MaximumMonthlyPayment; set => SetField(ref _pPC1MaximumMonthlyPayment, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Maximum Monthly Payment UI Value [LE1.XD48]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC1MaximumMonthlyPaymentUI { get => _pPC1MaximumMonthlyPaymentUI; set => SetField(ref _pPC1MaximumMonthlyPaymentUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Maximum Principal and Interest Payment [LE1.X43]
        /// </summary>
        public decimal? PPC1MaximumPIPayment { get => _pPC1MaximumPIPayment; set => SetField(ref _pPC1MaximumPIPayment, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Maximum Principal and Interest Payment UI Value [LE1.XD43]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC1MaximumPIPaymentUI { get => _pPC1MaximumPIPaymentUI; set => SetField(ref _pPC1MaximumPIPaymentUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Mortgage Insurance Amount [LE1.X45]
        /// </summary>
        public int? PPC1MIAmount { get => _pPC1MIAmount; set => SetField(ref _pPC1MIAmount, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Mortgage Insurance Amount UI Value [LE1.XD45]
        /// </summary>
        public string? PPC1MIAmountUI { get => _pPC1MIAmountUI; set => SetField(ref _pPC1MIAmountUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Minimum Monthly Payment [LE1.X47]
        /// </summary>
        public int? PPC1MinimumMonthlyPayment { get => _pPC1MinimumMonthlyPayment; set => SetField(ref _pPC1MinimumMonthlyPayment, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Minimum Monthly Payment UI Value [LE1.XD47]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC1MinimumMonthlyPaymentUI { get => _pPC1MinimumMonthlyPaymentUI; set => SetField(ref _pPC1MinimumMonthlyPaymentUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Minimum Principal and Interest Payment [LE1.X42]
        /// </summary>
        public decimal? PPC1MinimumPIPayment { get => _pPC1MinimumPIPayment; set => SetField(ref _pPC1MinimumPIPayment, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Minimum Principal and Interest Payment UI Value [LE1.XD42]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC1MinimumPIPaymentUI { get => _pPC1MinimumPIPaymentUI; set => SetField(ref _pPC1MinimumPIPaymentUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Year [LE1.X41]
        /// </summary>
        public int? PPC1Year { get => _pPC1Year; set => SetField(ref _pPC1Year, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Estimated Escrow Amount [LE1.X55]
        /// </summary>
        public int? PPC2EstimatedEscrowAmount { get => _pPC2EstimatedEscrowAmount; set => SetField(ref _pPC2EstimatedEscrowAmount, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Estimated Escrow Amount UI Value [LE1.XD55]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC2EstimatedEscrowAmountUI { get => _pPC2EstimatedEscrowAmountUI; set => SetField(ref _pPC2EstimatedEscrowAmountUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Interest Only [LE1.X53]
        /// </summary>
        public bool? PPC2InterestOnly { get => _pPC2InterestOnly; set => SetField(ref _pPC2InterestOnly, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Maximum Monthly Payment [LE1.X57]
        /// </summary>
        public decimal? PPC2MaximumMonthlyPayment { get => _pPC2MaximumMonthlyPayment; set => SetField(ref _pPC2MaximumMonthlyPayment, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Maximum Monthly Payment UI Value [LE1.XD57]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC2MaximumMonthlyPaymentUI { get => _pPC2MaximumMonthlyPaymentUI; set => SetField(ref _pPC2MaximumMonthlyPaymentUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Maximum Principal and Interest Payment [LE1.X52]
        /// </summary>
        public decimal? PPC2MaximumPIPayment { get => _pPC2MaximumPIPayment; set => SetField(ref _pPC2MaximumPIPayment, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Maximum Principal and Interest Payment UI Value [LE1.XD52]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC2MaximumPIPaymentUI { get => _pPC2MaximumPIPaymentUI; set => SetField(ref _pPC2MaximumPIPaymentUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Mortgage Insurance Amount [LE1.X54]
        /// </summary>
        public int? PPC2MIAmount { get => _pPC2MIAmount; set => SetField(ref _pPC2MIAmount, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Mortgage Insurance Amount UI Value [LE1.XD54]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC2MIAmountUI { get => _pPC2MIAmountUI; set => SetField(ref _pPC2MIAmountUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Minimum Monthly Payment [LE1.X56]
        /// </summary>
        public int? PPC2MinimumMonthlyPayment { get => _pPC2MinimumMonthlyPayment; set => SetField(ref _pPC2MinimumMonthlyPayment, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Minimum Monthly Payment UI Value [LE1.XD56]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC2MinimumMonthlyPaymentUI { get => _pPC2MinimumMonthlyPaymentUI; set => SetField(ref _pPC2MinimumMonthlyPaymentUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Minimum Principal and Interest Payment [LE1.X51]
        /// </summary>
        public decimal? PPC2MinimumPIPayment { get => _pPC2MinimumPIPayment; set => SetField(ref _pPC2MinimumPIPayment, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Minimum Principal and Interest Payment UI Value [LE1.XD51]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC2MinimumPIPaymentUI { get => _pPC2MinimumPIPaymentUI; set => SetField(ref _pPC2MinimumPIPaymentUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Year From [LE1.X49]
        /// </summary>
        public int? PPC2YearFrom { get => _pPC2YearFrom; set => SetField(ref _pPC2YearFrom, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Year To [LE1.X50]
        /// </summary>
        public int? PPC2YearTo { get => _pPC2YearTo; set => SetField(ref _pPC2YearTo, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Estimated Escrow Amount [LE1.X64]
        /// </summary>
        public int? PPC3EstimatedEscrowAmount { get => _pPC3EstimatedEscrowAmount; set => SetField(ref _pPC3EstimatedEscrowAmount, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Estimated Escrow Amount UI Value [LE1.XD64]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC3EstimatedEscrowAmountUI { get => _pPC3EstimatedEscrowAmountUI; set => SetField(ref _pPC3EstimatedEscrowAmountUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Interest Only [LE1.X62]
        /// </summary>
        public bool? PPC3InterestOnly { get => _pPC3InterestOnly; set => SetField(ref _pPC3InterestOnly, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Maximum Monthly Payment [LE1.X66]
        /// </summary>
        public decimal? PPC3MaximumMonthlyPayment { get => _pPC3MaximumMonthlyPayment; set => SetField(ref _pPC3MaximumMonthlyPayment, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Maximum Monthly Payment UI Value [LE1.XD66]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC3MaximumMonthlyPaymentUI { get => _pPC3MaximumMonthlyPaymentUI; set => SetField(ref _pPC3MaximumMonthlyPaymentUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Maximum Principal and Interest Payment [LE1.X61]
        /// </summary>
        public decimal? PPC3MaximumPIPayment { get => _pPC3MaximumPIPayment; set => SetField(ref _pPC3MaximumPIPayment, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Maximum Principal and Interest Payment UI Value [LE1.XD61]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC3MaximumPIPaymentUI { get => _pPC3MaximumPIPaymentUI; set => SetField(ref _pPC3MaximumPIPaymentUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Mortgage Insurance Amount [LE1.X63]
        /// </summary>
        public int? PPC3MIAmount { get => _pPC3MIAmount; set => SetField(ref _pPC3MIAmount, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Mortgage Insurance Amount UI Value [LE1.XD63]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC3MIAmountUI { get => _pPC3MIAmountUI; set => SetField(ref _pPC3MIAmountUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Minimum Monthly Payment [LE1.X65]
        /// </summary>
        public int? PPC3MinimumMonthlyPayment { get => _pPC3MinimumMonthlyPayment; set => SetField(ref _pPC3MinimumMonthlyPayment, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Minimum Monthly Payment UI Value [LE1.XD65]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC3MinimumMonthlyPaymentUI { get => _pPC3MinimumMonthlyPaymentUI; set => SetField(ref _pPC3MinimumMonthlyPaymentUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Minimum Principal and Interest Payment [LE1.X60]
        /// </summary>
        public decimal? PPC3MinimumPIPayment { get => _pPC3MinimumPIPayment; set => SetField(ref _pPC3MinimumPIPayment, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Minimum Principal and Interest Payment UI Value [LE1.XD60]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC3MinimumPIPaymentUI { get => _pPC3MinimumPIPaymentUI; set => SetField(ref _pPC3MinimumPIPaymentUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Year From [LE1.X58]
        /// </summary>
        public int? PPC3YearFrom { get => _pPC3YearFrom; set => SetField(ref _pPC3YearFrom, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Year To [LE1.X59]
        /// </summary>
        public int? PPC3YearTo { get => _pPC3YearTo; set => SetField(ref _pPC3YearTo, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Estimated Escrow Amount [LE1.X73]
        /// </summary>
        public int? PPC4EstimatedEscrowAmount { get => _pPC4EstimatedEscrowAmount; set => SetField(ref _pPC4EstimatedEscrowAmount, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Estimated Escrow Amount UI Value [LE1.XD73]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC4EstimatedEscrowAmountUI { get => _pPC4EstimatedEscrowAmountUI; set => SetField(ref _pPC4EstimatedEscrowAmountUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Interest Only [LE1.X71]
        /// </summary>
        public bool? PPC4InterestOnly { get => _pPC4InterestOnly; set => SetField(ref _pPC4InterestOnly, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Maximum Monthly Payment [LE1.X75]
        /// </summary>
        public decimal? PPC4MaximumMonthlyPayment { get => _pPC4MaximumMonthlyPayment; set => SetField(ref _pPC4MaximumMonthlyPayment, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Maximum Monthly Payment UI Value [LE1.XD75]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC4MaximumMonthlyPaymentUI { get => _pPC4MaximumMonthlyPaymentUI; set => SetField(ref _pPC4MaximumMonthlyPaymentUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Maximum Principal and Interest Payment [LE1.X70]
        /// </summary>
        public decimal? PPC4MaximumPIPayment { get => _pPC4MaximumPIPayment; set => SetField(ref _pPC4MaximumPIPayment, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Maximum Principal and Interest Payment UI Value [LE1.XD70]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC4MaximumPIPaymentUI { get => _pPC4MaximumPIPaymentUI; set => SetField(ref _pPC4MaximumPIPaymentUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Mortgage Insurance Amount [LE1.X72]
        /// </summary>
        public int? PPC4MIAmount { get => _pPC4MIAmount; set => SetField(ref _pPC4MIAmount, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Mortgage Insurance Amount UI Value [LE1.XD72]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC4MIAmountUI { get => _pPC4MIAmountUI; set => SetField(ref _pPC4MIAmountUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Minimum Monthly Payment [LE1.X74]
        /// </summary>
        public int? PPC4MinimumMonthlyPayment { get => _pPC4MinimumMonthlyPayment; set => SetField(ref _pPC4MinimumMonthlyPayment, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Minimum Monthly Payment UI Value [LE1.XD74]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC4MinimumMonthlyPaymentUI { get => _pPC4MinimumMonthlyPaymentUI; set => SetField(ref _pPC4MinimumMonthlyPaymentUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Minimum Principal and Interest Payment [LE1.X69]
        /// </summary>
        public decimal? PPC4MinimumPIPayment { get => _pPC4MinimumPIPayment; set => SetField(ref _pPC4MinimumPIPayment, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Minimum Principal and Interest Payment UI Value [LE1.XD69]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PPC4MinimumPIPaymentUI { get => _pPC4MinimumPIPaymentUI; set => SetField(ref _pPC4MinimumPIPaymentUI, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Year From [LE1.X67]
        /// </summary>
        public int? PPC4YearFrom { get => _pPC4YearFrom; set => SetField(ref _pPC4YearFrom, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Year To [LE1.X68]
        /// </summary>
        public int? PPC4YearTo { get => _pPC4YearTo; set => SetField(ref _pPC4YearTo, value); }

        /// <summary>
        /// Loan Estimate - Projected Calculation - Estimated Escrow Indicator [LE1.X77]
        /// </summary>
        public bool? PPEstimatedEscrowIndicator { get => _pPEstimatedEscrowIndicator; set => SetField(ref _pPEstimatedEscrowIndicator, value); }

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
}