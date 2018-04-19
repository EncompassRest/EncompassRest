using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LoanEstimate1
    /// </summary>
    public sealed partial class LoanEstimate1 : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<TermType>> _adjustsTermType;
        /// <summary>
        /// Loan Estimate - Interest Rate - Adjusts Every Months/Year/Years [LE1.X14]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Interest Rate - Adjusts Every Months/Year/Years")]
        public StringEnumValue<TermType> AdjustsTermType { get => _adjustsTermType; set => _adjustsTermType = value; }
        private DirtyValue<string> _changedCircumstanceComments;
        /// <summary>
        /// Comments [LE1.X86]
        /// </summary>
        [LoanFieldProperty(Description = "Comments")]
        public string ChangedCircumstanceComments { get => _changedCircumstanceComments; set => _changedCircumstanceComments = value; }
        private DirtyValue<DateTime?> _closingCostEstimateExpirationDate;
        /// <summary>
        /// Loan Estimate - Closing Costs Estimate Expiration Date [LE1.X28]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Closing Costs Estimate Expiration Date")]
        public DateTime? ClosingCostEstimateExpirationDate { get => _closingCostEstimateExpirationDate; set => _closingCostEstimateExpirationDate = value; }
        private DirtyValue<string> _closingCostEstimateExpirationDateUI;
        /// <summary>
        /// Loan Estimate - Closing Costs Estimate Expiration Date UI Value [LE1.XD28]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Closing Costs Estimate Expiration Date UI Value")]
        public string ClosingCostEstimateExpirationDateUI { get => _closingCostEstimateExpirationDateUI; set => _closingCostEstimateExpirationDateUI = value; }
        private DirtyValue<string> _closingCostEstimateExpirationTime;
        /// <summary>
        /// Loan Estimate - Closing Costs Estimate Expiration Time [LE1.X8]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Closing Costs Estimate Expiration Time")]
        public string ClosingCostEstimateExpirationTime { get => _closingCostEstimateExpirationTime; set => _closingCostEstimateExpirationTime = value; }
        private DirtyValue<string> _closingCostEstimateExpirationTimeUI;
        /// <summary>
        /// Loan Estimate - Closing Costs Estimate Expiration Time UI Value [LE1.XD8]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Closing Costs Estimate Expiration Time UI Value")]
        public string ClosingCostEstimateExpirationTimeUI { get => _closingCostEstimateExpirationTimeUI; set => _closingCostEstimateExpirationTimeUI = value; }
        private DirtyValue<string> _closingCostEstimateExpirationTimeZone;
        /// <summary>
        /// Loan Estimate - Closing Costs Estimate Expiration Time Zone [LE1.X9]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Closing Costs Estimate Expiration Time Zone")]
        public string ClosingCostEstimateExpirationTimeZone { get => _closingCostEstimateExpirationTimeZone; set => _closingCostEstimateExpirationTimeZone = value; }
        private DirtyValue<string> _closingCostEstimateExpirationTimeZoneUI;
        /// <summary>
        /// Loan Estimate - Closing Costs Estimate Expiration Time Zone UI Value [LE1.XD9]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Closing Costs Estimate Expiration Time Zone UI Value")]
        public string ClosingCostEstimateExpirationTimeZoneUI { get => _closingCostEstimateExpirationTimeZoneUI; set => _closingCostEstimateExpirationTimeZoneUI = value; }
        private DirtyValue<StringEnumValue<Conversion>> _conversionBegin;
        /// <summary>
        /// Conversion Begin Period [LE1.X96]
        /// </summary>
        [LoanFieldProperty(Description = "Conversion Begin Period")]
        public StringEnumValue<Conversion> ConversionBegin { get => _conversionBegin; set => _conversionBegin = value; }
        private DirtyValue<StringEnumValue<Conversion>> _conversionEnd;
        /// <summary>
        /// Conversion End Period [LE1.X97]
        /// </summary>
        [LoanFieldProperty(Description = "Conversion End Period")]
        public StringEnumValue<Conversion> ConversionEnd { get => _conversionEnd; set => _conversionEnd = value; }
        private DirtyValue<string> _disclosureBy;
        /// <summary>
        /// Loan Estimate - Disclosure By [LE1.X34]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Disclosure By")]
        public string DisclosureBy { get => _disclosureBy; set => _disclosureBy = value; }
        private DirtyValue<DateTime?> _disclosureClosingCostExpDate;
        /// <summary>
        /// Loan Estimate - Disclosure Closing Cost Exp. Date [LE1.X36]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Disclosure Closing Cost Exp. Date")]
        public DateTime? DisclosureClosingCostExpDate { get => _disclosureClosingCostExpDate; set => _disclosureClosingCostExpDate = value; }
        private DirtyValue<string> _disclosureClosingCostExpTime;
        /// <summary>
        /// Loan Estimate - Disclosure Expiration Time [LE1.X37]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Disclosure Expiration Time")]
        public string DisclosureClosingCostExpTime { get => _disclosureClosingCostExpTime; set => _disclosureClosingCostExpTime = value; }
        private DirtyValue<string> _disclosureClosingCostExpTimeZone;
        /// <summary>
        /// Loan Estimate - Disclosure Expiration Time Zone [LE1.X38]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Disclosure Expiration Time Zone")]
        public string DisclosureClosingCostExpTimeZone { get => _disclosureClosingCostExpTimeZone; set => _disclosureClosingCostExpTimeZone = value; }
        private DirtyValue<string> _disclosureComments;
        /// <summary>
        /// Loan Estimate - Disclosure Comments [LE1.X40]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Disclosure Comments")]
        public string DisclosureComments { get => _disclosureComments; set => _disclosureComments = value; }
        private DirtyValue<DateTime?> _disclosureLastSentDate;
        /// <summary>
        /// Loan Estimate - Disclosure Last Sent Date [LE1.X33]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Disclosure Last Sent Date")]
        public DateTime? DisclosureLastSentDate { get => _disclosureLastSentDate; set => _disclosureLastSentDate = value; }
        private DirtyValue<DateTime?> _disclosureReceivedDate;
        /// <summary>
        /// Loan Estimate - Disclosure Received Date [LE1.X39]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Disclosure Received Date")]
        public DateTime? DisclosureReceivedDate { get => _disclosureReceivedDate; set => _disclosureReceivedDate = value; }
        private DirtyValue<string> _disclosureSentMethod;
        /// <summary>
        /// Loan Estimate - Disclosure Sent Method [LE1.X35]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Disclosure Sent Method")]
        public string DisclosureSentMethod { get => _disclosureSentMethod; set => _disclosureSentMethod = value; }
        private DirtyValue<decimal?> _estimatedTaxesInsuranceAssessments;
        /// <summary>
        /// Loan Estimate - Estimated Taxes, Insurance and Assessments [LE1.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Estimated Taxes, Insurance and Assessments")]
        public decimal? EstimatedTaxesInsuranceAssessments { get => _estimatedTaxesInsuranceAssessments; set => _estimatedTaxesInsuranceAssessments = value; }
        private DirtyValue<string> _estimatedTaxesInsuranceAssessmentsUI;
        /// <summary>
        /// Loan Estimate - Estimated Taxes, Insurance and Assessments UI Value [LE1.XD29]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Estimated Taxes, Insurance and Assessments UI Value")]
        public string EstimatedTaxesInsuranceAssessmentsUI { get => _estimatedTaxesInsuranceAssessmentsUI; set => _estimatedTaxesInsuranceAssessmentsUI = value; }
        private DirtyValue<decimal?> _highestMonthlyPI;
        /// <summary>
        /// Loan Estimate - Monthly Principal and Interest Will be Adjusted in Year [LE1.X24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Monthly Principal and Interest Will be Adjusted in Year")]
        public decimal? HighestMonthlyPI { get => _highestMonthlyPI; set => _highestMonthlyPI = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// LoanEstimate1 Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _inEscrowHomeownerInsurance;
        /// <summary>
        /// Loan Estimate - In Escrow Homeowner Insurance [LE1.X31]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - In Escrow Homeowner Insurance")]
        public string InEscrowHomeownerInsurance { get => _inEscrowHomeownerInsurance; set => _inEscrowHomeownerInsurance = value; }
        private DirtyValue<string> _inEscrowOther;
        /// <summary>
        /// Loan Estimate - In Escrow Other [LE1.X32]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - In Escrow Other")]
        public string InEscrowOther { get => _inEscrowOther; set => _inEscrowOther = value; }
        private DirtyValue<string> _inEscrowPropertyTaxes;
        /// <summary>
        /// Loan Estimate - In Escrow Property Taxes [LE1.X30]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - In Escrow Property Taxes")]
        public string InEscrowPropertyTaxes { get => _inEscrowPropertyTaxes; set => _inEscrowPropertyTaxes = value; }
        private DirtyValue<decimal?> _initialMonthlyPaymentFor10000Loan;
        /// <summary>
        /// The calculated initial monthly payment for a $10,000 loan [LE1.X92]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "The calculated initial monthly payment for a $10,000 loan")]
        public decimal? InitialMonthlyPaymentFor10000Loan { get => _initialMonthlyPaymentFor10000Loan; set => _initialMonthlyPaymentFor10000Loan = value; }
        private DirtyValue<decimal?> _initialMonthlyPaymentFor60000Loan;
        /// <summary>
        /// The calculation initial monthly payment for a $60,000 loan [LE1.X95]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "The calculation initial monthly payment for a $60,000 loan")]
        public decimal? InitialMonthlyPaymentFor60000Loan { get => _initialMonthlyPaymentFor60000Loan; set => _initialMonthlyPaymentFor60000Loan = value; }
        private DirtyValue<string> _interestRateAdjustsEveryYears;
        /// <summary>
        /// Loan Estimate - Interest Rate will Adjusts Every [LE1.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Interest Rate will Adjusts Every")]
        public string InterestRateAdjustsEveryYears { get => _interestRateAdjustsEveryYears; set => _interestRateAdjustsEveryYears = value; }
        private DirtyValue<int?> _interestRateAdjustsInYear;
        /// <summary>
        /// Loan Estimate - Interest Rate Will be Adjusted in Year [LE1.X18]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Interest Rate Will be Adjusted in Year")]
        public int? InterestRateAdjustsInYear { get => _interestRateAdjustsInYear; set => _interestRateAdjustsInYear = value; }
        private DirtyValue<StringEnumValue<MonthOrYear>> _interestRateAdjustsStartingInType;
        /// <summary>
        /// Loan Estimate - Interest Rate - Adjusts Starting in [LE1.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Interest Rate - Adjusts Starting in")]
        public StringEnumValue<MonthOrYear> InterestRateAdjustsStartingInType { get => _interestRateAdjustsStartingInType; set => _interestRateAdjustsStartingInType = value; }
        private DirtyValue<int?> _interestRateAfterAdjustment;
        /// <summary>
        /// Loan Estimate - Interest Rate After Adjustment [LE1.X16]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Interest Rate After Adjustment")]
        public int? InterestRateAfterAdjustment { get => _interestRateAfterAdjustment; set => _interestRateAfterAdjustment = value; }
        private DirtyValue<StringEnumValue<CanGoOrGoes>> _interestRateCanGoGoes;
        /// <summary>
        /// Loan Estimate - Interest Rate Can go or Goes [LE1.X17]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Interest Rate Can go or Goes")]
        public StringEnumValue<CanGoOrGoes> InterestRateCanGoGoes { get => _interestRateCanGoGoes; set => _interestRateCanGoGoes = value; }
        private DirtyValue<DateTime?> _lEDateIssued;
        /// <summary>
        /// Loan Estimate - LE Date Issued [LE1.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - LE Date Issued")]
        public DateTime? LEDateIssued { get => _lEDateIssued; set => _lEDateIssued = value; }
        private DirtyValue<StringEnumValue<CanGoOrGoes>> _loanAmountCanGoGoes;
        /// <summary>
        /// Loan Estimate - Loan Amount Can go or Goes [LE1.X10]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Loan Amount Can go or Goes")]
        public StringEnumValue<CanGoOrGoes> LoanAmountCanGoGoes { get => _loanAmountCanGoGoes; set => _loanAmountCanGoGoes = value; }
        private DirtyValue<StringEnumValue<CanIncreaseOrIncreases>> _loanAmountCanIncreaseOrIncreases;
        /// <summary>
        /// Loan Estimate - Loan Amount Can increase or Increases [LE1.X11]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Loan Amount Can increase or Increases")]
        public StringEnumValue<CanIncreaseOrIncreases> LoanAmountCanIncreaseOrIncreases { get => _loanAmountCanIncreaseOrIncreases; set => _loanAmountCanIncreaseOrIncreases = value; }
        private DirtyValue<string> _loanProduct;
        /// <summary>
        /// Product Description [LE1.X5]
        /// </summary>
        [LoanFieldProperty(Description = "Product Description")]
        public string LoanProduct { get => _loanProduct; set => _loanProduct = value; }
        private DirtyValue<StringEnumValue<LoanEstimate1LoanPurpose>> _loanPurpose;
        /// <summary>
        /// Loan Estimate - Loan Purpose [LE1.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Loan Purpose")]
        public StringEnumValue<LoanEstimate1LoanPurpose> LoanPurpose { get => _loanPurpose; set => _loanPurpose = value; }
        private DirtyValue<int?> _loanTermMonths;
        /// <summary>
        /// Loan Estimate - Loan Term Months [LE1.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Loan Term Months")]
        public int? LoanTermMonths { get => _loanTermMonths; set => _loanTermMonths = value; }
        private DirtyValue<int?> _loanTermYears;
        /// <summary>
        /// Loan Estimate - Loan Term Years [LE1.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Loan Term Years")]
        public int? LoanTermYears { get => _loanTermYears; set => _loanTermYears = value; }
        private DirtyValue<decimal?> _maximumMonthlyPaymentFor10000Loan;
        /// <summary>
        /// The calculated maximum monthly payment for a $10,000 loan [LE1.X93]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "The calculated maximum monthly payment for a $10,000 loan")]
        public decimal? MaximumMonthlyPaymentFor10000Loan { get => _maximumMonthlyPaymentFor10000Loan; set => _maximumMonthlyPaymentFor10000Loan = value; }
        private DirtyValue<int?> _maximumPaymentMonth;
        /// <summary>
        /// The calculated month in which the maximum monthly payment will go into effect [LE1.X94]
        /// </summary>
        [LoanFieldProperty(Description = "The calculated month in which the maximum monthly payment will go into effect")]
        public int? MaximumPaymentMonth { get => _maximumPaymentMonth; set => _maximumPaymentMonth = value; }
        private DirtyValue<StringEnumValue<MonthOrYear>> _monthlyPIAdjustedInDateType;
        /// <summary>
        /// Loan Estimate - Monthly Principal and Interest - Will be Adjusted in Year/Month [LE1.X88]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Monthly Principal and Interest - Will be Adjusted in Year/Month")]
        public StringEnumValue<MonthOrYear> MonthlyPIAdjustedInDateType { get => _monthlyPIAdjustedInDateType; set => _monthlyPIAdjustedInDateType = value; }
        private DirtyValue<string> _monthlyPIAdjustsEveryYears;
        /// <summary>
        /// Loan Estimate - Monthly Principal and Interest will Adjusts Every [LE1.X19]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Monthly Principal and Interest will Adjusts Every")]
        public string MonthlyPIAdjustsEveryYears { get => _monthlyPIAdjustsEveryYears; set => _monthlyPIAdjustsEveryYears = value; }
        private DirtyValue<int?> _monthlyPIAdjustsInYear;
        /// <summary>
        /// Loan Estimate - Monthly Principal and Interest Will be Adjusted in Year [LE1.X25]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Monthly Principal and Interest Will be Adjusted in Year")]
        public int? MonthlyPIAdjustsInYear { get => _monthlyPIAdjustsInYear; set => _monthlyPIAdjustsInYear = value; }
        private DirtyValue<StringEnumValue<MonthOrYear>> _monthlyPIAdjustsStartingInType;
        /// <summary>
        /// Loan Estimate - Monthly Principal and Interest - Adjusts Starting in [LE1.X21]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Monthly Principal and Interest - Adjusts Starting in")]
        public StringEnumValue<MonthOrYear> MonthlyPIAdjustsStartingInType { get => _monthlyPIAdjustsStartingInType; set => _monthlyPIAdjustsStartingInType = value; }
        private DirtyValue<StringEnumValue<TermType>> _monthlyPIAdjustsTermType;
        /// <summary>
        /// Loan Estimate - Monthly Principal and Interest - Adjusts Every Months/Year/Years [LE1.X20]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Monthly Principal and Interest - Adjusts Every Months/Year/Years")]
        public StringEnumValue<TermType> MonthlyPIAdjustsTermType { get => _monthlyPIAdjustsTermType; set => _monthlyPIAdjustsTermType = value; }
        private DirtyValue<int?> _monthlyPIAfterAdjustment;
        /// <summary>
        /// Loan Estimate - Monthly Principal and Interest - After Adjustment [LE1.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Monthly Principal and Interest - After Adjustment")]
        public int? MonthlyPIAfterAdjustment { get => _monthlyPIAfterAdjustment; set => _monthlyPIAfterAdjustment = value; }
        private DirtyValue<StringEnumValue<CanGoOrGoes>> _monthlyPICanGoGoes;
        /// <summary>
        /// Loan Estimate - Monthly Principal and Interest Can go or Goes [LE1.X23]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Monthly Principal and Interest Can go or Goes")]
        public StringEnumValue<CanGoOrGoes> MonthlyPICanGoGoes { get => _monthlyPICanGoGoes; set => _monthlyPICanGoGoes = value; }
        private DirtyValue<StringEnumValue<MonthOrYear>> _monthlyPIInterestOnlyDateType;
        /// <summary>
        /// Loan Estimate - Monthly Principal and Interest - Interest Only in Year/Month [LE1.X89]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Monthly Principal and Interest - Interest Only in Year/Month")]
        public StringEnumValue<MonthOrYear> MonthlyPIInterestOnlyDateType { get => _monthlyPIInterestOnlyDateType; set => _monthlyPIInterestOnlyDateType = value; }
        private DirtyValue<int?> _monthlyPIInterestOnlyUntilYear;
        /// <summary>
        /// Loan Estimate - Monthly Principal and Interest - Includes only interest and no principal until year [LE1.X26]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Monthly Principal and Interest - Includes only interest and no principal until year")]
        public int? MonthlyPIInterestOnlyUntilYear { get => _monthlyPIInterestOnlyUntilYear; set => _monthlyPIInterestOnlyUntilYear = value; }
        private DirtyValue<int?> _pPC1EstimatedEscrowAmount;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Estimated Escrow Amount [LE1.X46]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 1 - Estimated Escrow Amount")]
        public int? PPC1EstimatedEscrowAmount { get => _pPC1EstimatedEscrowAmount; set => _pPC1EstimatedEscrowAmount = value; }
        private DirtyValue<string> _pPC1EstimatedEscrowAmountUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Estimated Escrow Amount UI Value [LE1.XD46]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 1 - Estimated Escrow Amount UI Value")]
        public string PPC1EstimatedEscrowAmountUI { get => _pPC1EstimatedEscrowAmountUI; set => _pPC1EstimatedEscrowAmountUI = value; }
        private DirtyValue<bool?> _pPC1InterestOnly;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Interest Only [LE1.X44]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 1 - Interest Only")]
        public bool? PPC1InterestOnly { get => _pPC1InterestOnly; set => _pPC1InterestOnly = value; }
        private DirtyValue<decimal?> _pPC1MaximumMonthlyPayment;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Maximum Monthly Payment [LE1.X48]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Projected Calculation - Column 1 - Maximum Monthly Payment")]
        public decimal? PPC1MaximumMonthlyPayment { get => _pPC1MaximumMonthlyPayment; set => _pPC1MaximumMonthlyPayment = value; }
        private DirtyValue<string> _pPC1MaximumMonthlyPaymentUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Maximum Monthly Payment UI Value [LE1.XD48]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 1 - Maximum Monthly Payment UI Value")]
        public string PPC1MaximumMonthlyPaymentUI { get => _pPC1MaximumMonthlyPaymentUI; set => _pPC1MaximumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC1MaximumPIPayment;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Maximum Principal and Interest Payment [LE1.X43]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Projected Calculation - Column 1 - Maximum Principal and Interest Payment")]
        public decimal? PPC1MaximumPIPayment { get => _pPC1MaximumPIPayment; set => _pPC1MaximumPIPayment = value; }
        private DirtyValue<string> _pPC1MaximumPIPaymentUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Maximum Principal and Interest Payment UI Value [LE1.XD43]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 1 - Maximum Principal and Interest Payment UI Value")]
        public string PPC1MaximumPIPaymentUI { get => _pPC1MaximumPIPaymentUI; set => _pPC1MaximumPIPaymentUI = value; }
        private DirtyValue<int?> _pPC1MIAmount;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Mortgage Insurance Amount [LE1.X45]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 1 - Mortgage Insurance Amount")]
        public int? PPC1MIAmount { get => _pPC1MIAmount; set => _pPC1MIAmount = value; }
        private DirtyValue<string> _pPC1MIAmountUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Mortgage Insurance Amount UI Value [LE1.XD45]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 1 - Mortgage Insurance Amount UI Value")]
        public string PPC1MIAmountUI { get => _pPC1MIAmountUI; set => _pPC1MIAmountUI = value; }
        private DirtyValue<int?> _pPC1MinimumMonthlyPayment;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Minimum Monthly Payment [LE1.X47]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 1 - Minimum Monthly Payment")]
        public int? PPC1MinimumMonthlyPayment { get => _pPC1MinimumMonthlyPayment; set => _pPC1MinimumMonthlyPayment = value; }
        private DirtyValue<string> _pPC1MinimumMonthlyPaymentUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Minimum Monthly Payment UI Value [LE1.XD47]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 1 - Minimum Monthly Payment UI Value")]
        public string PPC1MinimumMonthlyPaymentUI { get => _pPC1MinimumMonthlyPaymentUI; set => _pPC1MinimumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC1MinimumPIPayment;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Minimum Principal and Interest Payment [LE1.X42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Projected Calculation - Column 1 - Minimum Principal and Interest Payment")]
        public decimal? PPC1MinimumPIPayment { get => _pPC1MinimumPIPayment; set => _pPC1MinimumPIPayment = value; }
        private DirtyValue<string> _pPC1MinimumPIPaymentUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Minimum Principal and Interest Payment UI Value [LE1.XD42]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 1 - Minimum Principal and Interest Payment UI Value")]
        public string PPC1MinimumPIPaymentUI { get => _pPC1MinimumPIPaymentUI; set => _pPC1MinimumPIPaymentUI = value; }
        private DirtyValue<int?> _pPC1Year;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Year [LE1.X41]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 1 - Year")]
        public int? PPC1Year { get => _pPC1Year; set => _pPC1Year = value; }
        private DirtyValue<int?> _pPC2EstimatedEscrowAmount;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Estimated Escrow Amount [LE1.X55]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 2 - Estimated Escrow Amount")]
        public int? PPC2EstimatedEscrowAmount { get => _pPC2EstimatedEscrowAmount; set => _pPC2EstimatedEscrowAmount = value; }
        private DirtyValue<string> _pPC2EstimatedEscrowAmountUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Estimated Escrow Amount UI Value [LE1.XD55]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 2 - Estimated Escrow Amount UI Value")]
        public string PPC2EstimatedEscrowAmountUI { get => _pPC2EstimatedEscrowAmountUI; set => _pPC2EstimatedEscrowAmountUI = value; }
        private DirtyValue<bool?> _pPC2InterestOnly;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Interest Only [LE1.X53]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 2 - Interest Only")]
        public bool? PPC2InterestOnly { get => _pPC2InterestOnly; set => _pPC2InterestOnly = value; }
        private DirtyValue<decimal?> _pPC2MaximumMonthlyPayment;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Maximum Monthly Payment [LE1.X57]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Projected Calculation - Column 2 - Maximum Monthly Payment")]
        public decimal? PPC2MaximumMonthlyPayment { get => _pPC2MaximumMonthlyPayment; set => _pPC2MaximumMonthlyPayment = value; }
        private DirtyValue<string> _pPC2MaximumMonthlyPaymentUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Maximum Monthly Payment UI Value [LE1.XD57]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 2 - Maximum Monthly Payment UI Value")]
        public string PPC2MaximumMonthlyPaymentUI { get => _pPC2MaximumMonthlyPaymentUI; set => _pPC2MaximumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC2MaximumPIPayment;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Maximum Principal and Interest Payment [LE1.X52]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Projected Calculation - Column 2 - Maximum Principal and Interest Payment")]
        public decimal? PPC2MaximumPIPayment { get => _pPC2MaximumPIPayment; set => _pPC2MaximumPIPayment = value; }
        private DirtyValue<string> _pPC2MaximumPIPaymentUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Maximum Principal and Interest Payment UI Value [LE1.XD52]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 2 - Maximum Principal and Interest Payment UI Value")]
        public string PPC2MaximumPIPaymentUI { get => _pPC2MaximumPIPaymentUI; set => _pPC2MaximumPIPaymentUI = value; }
        private DirtyValue<int?> _pPC2MIAmount;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Mortgage Insurance Amount [LE1.X54]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 2 - Mortgage Insurance Amount")]
        public int? PPC2MIAmount { get => _pPC2MIAmount; set => _pPC2MIAmount = value; }
        private DirtyValue<string> _pPC2MIAmountUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Mortgage Insurance Amount UI Value [LE1.XD54]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 2 - Mortgage Insurance Amount UI Value")]
        public string PPC2MIAmountUI { get => _pPC2MIAmountUI; set => _pPC2MIAmountUI = value; }
        private DirtyValue<int?> _pPC2MinimumMonthlyPayment;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Minimum Monthly Payment [LE1.X56]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 2 - Minimum Monthly Payment")]
        public int? PPC2MinimumMonthlyPayment { get => _pPC2MinimumMonthlyPayment; set => _pPC2MinimumMonthlyPayment = value; }
        private DirtyValue<string> _pPC2MinimumMonthlyPaymentUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Minimum Monthly Payment UI Value [LE1.XD56]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 2 - Minimum Monthly Payment UI Value")]
        public string PPC2MinimumMonthlyPaymentUI { get => _pPC2MinimumMonthlyPaymentUI; set => _pPC2MinimumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC2MinimumPIPayment;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Minimum Principal and Interest Payment [LE1.X51]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Projected Calculation - Column 2 - Minimum Principal and Interest Payment")]
        public decimal? PPC2MinimumPIPayment { get => _pPC2MinimumPIPayment; set => _pPC2MinimumPIPayment = value; }
        private DirtyValue<string> _pPC2MinimumPIPaymentUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Minimum Principal and Interest Payment UI Value [LE1.XD51]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 2 - Minimum Principal and Interest Payment UI Value")]
        public string PPC2MinimumPIPaymentUI { get => _pPC2MinimumPIPaymentUI; set => _pPC2MinimumPIPaymentUI = value; }
        private DirtyValue<int?> _pPC2YearFrom;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Year From [LE1.X49]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 2 - Year From")]
        public int? PPC2YearFrom { get => _pPC2YearFrom; set => _pPC2YearFrom = value; }
        private DirtyValue<int?> _pPC2YearTo;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Year To [LE1.X50]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 2 - Year To")]
        public int? PPC2YearTo { get => _pPC2YearTo; set => _pPC2YearTo = value; }
        private DirtyValue<int?> _pPC3EstimatedEscrowAmount;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Estimated Escrow Amount [LE1.X64]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 3 - Estimated Escrow Amount")]
        public int? PPC3EstimatedEscrowAmount { get => _pPC3EstimatedEscrowAmount; set => _pPC3EstimatedEscrowAmount = value; }
        private DirtyValue<string> _pPC3EstimatedEscrowAmountUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Estimated Escrow Amount UI Value [LE1.XD64]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 3 - Estimated Escrow Amount UI Value")]
        public string PPC3EstimatedEscrowAmountUI { get => _pPC3EstimatedEscrowAmountUI; set => _pPC3EstimatedEscrowAmountUI = value; }
        private DirtyValue<bool?> _pPC3InterestOnly;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Interest Only [LE1.X62]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 3 - Interest Only")]
        public bool? PPC3InterestOnly { get => _pPC3InterestOnly; set => _pPC3InterestOnly = value; }
        private DirtyValue<decimal?> _pPC3MaximumMonthlyPayment;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Maximum Monthly Payment [LE1.X66]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Projected Calculation - Column 3 - Maximum Monthly Payment")]
        public decimal? PPC3MaximumMonthlyPayment { get => _pPC3MaximumMonthlyPayment; set => _pPC3MaximumMonthlyPayment = value; }
        private DirtyValue<string> _pPC3MaximumMonthlyPaymentUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Maximum Monthly Payment UI Value [LE1.XD66]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 3 - Maximum Monthly Payment UI Value")]
        public string PPC3MaximumMonthlyPaymentUI { get => _pPC3MaximumMonthlyPaymentUI; set => _pPC3MaximumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC3MaximumPIPayment;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Maximum Principal and Interest Payment [LE1.X61]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Projected Calculation - Column 3 - Maximum Principal and Interest Payment")]
        public decimal? PPC3MaximumPIPayment { get => _pPC3MaximumPIPayment; set => _pPC3MaximumPIPayment = value; }
        private DirtyValue<string> _pPC3MaximumPIPaymentUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Maximum Principal and Interest Payment UI Value [LE1.XD61]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 3 - Maximum Principal and Interest Payment UI Value")]
        public string PPC3MaximumPIPaymentUI { get => _pPC3MaximumPIPaymentUI; set => _pPC3MaximumPIPaymentUI = value; }
        private DirtyValue<int?> _pPC3MIAmount;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Mortgage Insurance Amount [LE1.X63]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 3 - Mortgage Insurance Amount")]
        public int? PPC3MIAmount { get => _pPC3MIAmount; set => _pPC3MIAmount = value; }
        private DirtyValue<string> _pPC3MIAmountUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Mortgage Insurance Amount UI Value [LE1.XD63]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 3 - Mortgage Insurance Amount UI Value")]
        public string PPC3MIAmountUI { get => _pPC3MIAmountUI; set => _pPC3MIAmountUI = value; }
        private DirtyValue<int?> _pPC3MinimumMonthlyPayment;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Minimum Monthly Payment [LE1.X65]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 3 - Minimum Monthly Payment")]
        public int? PPC3MinimumMonthlyPayment { get => _pPC3MinimumMonthlyPayment; set => _pPC3MinimumMonthlyPayment = value; }
        private DirtyValue<string> _pPC3MinimumMonthlyPaymentUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Minimum Monthly Payment UI Value [LE1.XD65]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 3 - Minimum Monthly Payment UI Value")]
        public string PPC3MinimumMonthlyPaymentUI { get => _pPC3MinimumMonthlyPaymentUI; set => _pPC3MinimumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC3MinimumPIPayment;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Minimum Principal and Interest Payment [LE1.X60]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Projected Calculation - Column 3 - Minimum Principal and Interest Payment")]
        public decimal? PPC3MinimumPIPayment { get => _pPC3MinimumPIPayment; set => _pPC3MinimumPIPayment = value; }
        private DirtyValue<string> _pPC3MinimumPIPaymentUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Minimum Principal and Interest Payment UI Value [LE1.XD60]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 3 - Minimum Principal and Interest Payment UI Value")]
        public string PPC3MinimumPIPaymentUI { get => _pPC3MinimumPIPaymentUI; set => _pPC3MinimumPIPaymentUI = value; }
        private DirtyValue<int?> _pPC3YearFrom;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Year From [LE1.X58]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 3 - Year From")]
        public int? PPC3YearFrom { get => _pPC3YearFrom; set => _pPC3YearFrom = value; }
        private DirtyValue<int?> _pPC3YearTo;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Year To [LE1.X59]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 3 - Year To")]
        public int? PPC3YearTo { get => _pPC3YearTo; set => _pPC3YearTo = value; }
        private DirtyValue<int?> _pPC4EstimatedEscrowAmount;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Estimated Escrow Amount [LE1.X73]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 4 - Estimated Escrow Amount")]
        public int? PPC4EstimatedEscrowAmount { get => _pPC4EstimatedEscrowAmount; set => _pPC4EstimatedEscrowAmount = value; }
        private DirtyValue<string> _pPC4EstimatedEscrowAmountUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Estimated Escrow Amount UI Value [LE1.XD73]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 4 - Estimated Escrow Amount UI Value")]
        public string PPC4EstimatedEscrowAmountUI { get => _pPC4EstimatedEscrowAmountUI; set => _pPC4EstimatedEscrowAmountUI = value; }
        private DirtyValue<bool?> _pPC4InterestOnly;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Interest Only [LE1.X71]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 4 - Interest Only")]
        public bool? PPC4InterestOnly { get => _pPC4InterestOnly; set => _pPC4InterestOnly = value; }
        private DirtyValue<decimal?> _pPC4MaximumMonthlyPayment;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Maximum Monthly Payment [LE1.X75]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Projected Calculation - Column 4 - Maximum Monthly Payment")]
        public decimal? PPC4MaximumMonthlyPayment { get => _pPC4MaximumMonthlyPayment; set => _pPC4MaximumMonthlyPayment = value; }
        private DirtyValue<string> _pPC4MaximumMonthlyPaymentUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Maximum Monthly Payment UI Value [LE1.XD75]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 4 - Maximum Monthly Payment UI Value")]
        public string PPC4MaximumMonthlyPaymentUI { get => _pPC4MaximumMonthlyPaymentUI; set => _pPC4MaximumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC4MaximumPIPayment;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Maximum Principal and Interest Payment [LE1.X70]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Projected Calculation - Column 4 - Maximum Principal and Interest Payment")]
        public decimal? PPC4MaximumPIPayment { get => _pPC4MaximumPIPayment; set => _pPC4MaximumPIPayment = value; }
        private DirtyValue<string> _pPC4MaximumPIPaymentUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Maximum Principal and Interest Payment UI Value [LE1.XD70]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 4 - Maximum Principal and Interest Payment UI Value")]
        public string PPC4MaximumPIPaymentUI { get => _pPC4MaximumPIPaymentUI; set => _pPC4MaximumPIPaymentUI = value; }
        private DirtyValue<int?> _pPC4MIAmount;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Mortgage Insurance Amount [LE1.X72]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 4 - Mortgage Insurance Amount")]
        public int? PPC4MIAmount { get => _pPC4MIAmount; set => _pPC4MIAmount = value; }
        private DirtyValue<string> _pPC4MIAmountUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Mortgage Insurance Amount UI Value [LE1.XD72]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 4 - Mortgage Insurance Amount UI Value")]
        public string PPC4MIAmountUI { get => _pPC4MIAmountUI; set => _pPC4MIAmountUI = value; }
        private DirtyValue<int?> _pPC4MinimumMonthlyPayment;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Minimum Monthly Payment [LE1.X74]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 4 - Minimum Monthly Payment")]
        public int? PPC4MinimumMonthlyPayment { get => _pPC4MinimumMonthlyPayment; set => _pPC4MinimumMonthlyPayment = value; }
        private DirtyValue<string> _pPC4MinimumMonthlyPaymentUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Minimum Monthly Payment UI Value [LE1.XD74]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 4 - Minimum Monthly Payment UI Value")]
        public string PPC4MinimumMonthlyPaymentUI { get => _pPC4MinimumMonthlyPaymentUI; set => _pPC4MinimumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC4MinimumPIPayment;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Minimum Principal and Interest Payment [LE1.X69]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Estimate - Projected Calculation - Column 4 - Minimum Principal and Interest Payment")]
        public decimal? PPC4MinimumPIPayment { get => _pPC4MinimumPIPayment; set => _pPC4MinimumPIPayment = value; }
        private DirtyValue<string> _pPC4MinimumPIPaymentUI;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Minimum Principal and Interest Payment UI Value [LE1.XD69]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 4 - Minimum Principal and Interest Payment UI Value")]
        public string PPC4MinimumPIPaymentUI { get => _pPC4MinimumPIPaymentUI; set => _pPC4MinimumPIPaymentUI = value; }
        private DirtyValue<int?> _pPC4YearFrom;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Year From [LE1.X67]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 4 - Year From")]
        public int? PPC4YearFrom { get => _pPC4YearFrom; set => _pPC4YearFrom = value; }
        private DirtyValue<int?> _pPC4YearTo;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Year To [LE1.X68]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Column 4 - Year To")]
        public int? PPC4YearTo { get => _pPC4YearTo; set => _pPC4YearTo = value; }
        private DirtyValue<bool?> _pPEstimatedEscrowIndicator;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Estimated Escrow Indicator [LE1.X77]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Projected Calculation - Estimated Escrow Indicator")]
        public bool? PPEstimatedEscrowIndicator { get => _pPEstimatedEscrowIndicator; set => _pPEstimatedEscrowIndicator = value; }
        private DirtyValue<int?> _prepaymentPenaltyPayOffDuringYear;
        /// <summary>
        /// Loan Estimate - Prepayment Penalty - If you pay off the loan during the first [LE1.X27]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Prepayment Penalty - If you pay off the loan during the first")]
        public int? PrepaymentPenaltyPayOffDuringYear { get => _prepaymentPenaltyPayOffDuringYear; set => _prepaymentPenaltyPayOffDuringYear = value; }
        private DirtyValue<StringEnumValue<TermType>> _prepaymentPenaltyPayOffInDateType;
        /// <summary>
        /// Loan Estimate - Prepayment Penalty - In Year/Month [LE1.X91]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Prepayment Penalty - In Year/Month")]
        public StringEnumValue<TermType> PrepaymentPenaltyPayOffInDateType { get => _prepaymentPenaltyPayOffInDateType; set => _prepaymentPenaltyPayOffInDateType = value; }
        private DirtyValue<string> _prepaymentPenaltyPayOffInFirstYear;
        /// <summary>
        /// Loan Estimate - Prepayment Penalty - In First Year [LE1.XD27]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Prepayment Penalty - In First Year")]
        public string PrepaymentPenaltyPayOffInFirstYear { get => _prepaymentPenaltyPayOffInFirstYear; set => _prepaymentPenaltyPayOffInFirstYear = value; }
        private DirtyValue<bool?> _rangePaymentIndicatorC1;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 1 - Range Payment Indicator [LE1.XD1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 1 - Range Payment Indicator")]
        public bool? RangePaymentIndicatorC1 { get => _rangePaymentIndicatorC1; set => _rangePaymentIndicatorC1 = value; }
        private DirtyValue<bool?> _rangePaymentIndicatorC2;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 2 - Range Payment Indicator [LE1.XD2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 2 - Range Payment Indicator")]
        public bool? RangePaymentIndicatorC2 { get => _rangePaymentIndicatorC2; set => _rangePaymentIndicatorC2 = value; }
        private DirtyValue<bool?> _rangePaymentIndicatorC3;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 3 - Range Payment Indicator [LE1.XD3]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 3 - Range Payment Indicator")]
        public bool? RangePaymentIndicatorC3 { get => _rangePaymentIndicatorC3; set => _rangePaymentIndicatorC3 = value; }
        private DirtyValue<bool?> _rangePaymentIndicatorC4;
        /// <summary>
        /// Loan Estimate - Projected Calculation - Column 4 - Range Payment Indicator [LE1.XD4]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Projected Calculation - Column 4 - Range Payment Indicator")]
        public bool? RangePaymentIndicatorC4 { get => _rangePaymentIndicatorC4; set => _rangePaymentIndicatorC4 = value; }
        private DirtyValue<string> _rateLockExpirationTime;
        /// <summary>
        /// Loan Estimate - Rate Lock Expiration Time [LE1.X6]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Rate Lock Expiration Time")]
        public string RateLockExpirationTime { get => _rateLockExpirationTime; set => _rateLockExpirationTime = value; }
        private DirtyValue<string> _rateLockExpirationTimeZone;
        /// <summary>
        /// Loan Estimate - Rate Lock Expiration Time Zone [LE1.X7]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Rate Lock Expiration Time Zone")]
        public string RateLockExpirationTimeZone { get => _rateLockExpirationTimeZone; set => _rateLockExpirationTimeZone = value; }
        private DirtyValue<string> _reasonChangedCircumstanceFlags;
        /// <summary>
        /// Loan Estimate - Reason Changed Circumstance Flags [LE1.X90]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Estimate - Reason Changed Circumstance Flags")]
        public string ReasonChangedCircumstanceFlags { get => _reasonChangedCircumstanceFlags; set => _reasonChangedCircumstanceFlags = value; }
        private DirtyValue<bool?> _reasonDelayedSettlement;
        /// <summary>
        /// Delayed Settlement on Construction Loans [LE1.X83]
        /// </summary>
        [LoanFieldProperty(Description = "Delayed Settlement on Construction Loans")]
        public bool? ReasonDelayedSettlement { get => _reasonDelayedSettlement; set => _reasonDelayedSettlement = value; }
        private DirtyValue<bool?> _reasonEligibility;
        /// <summary>
        /// Changed Circumstance - Eligibility [LE1.X79]
        /// </summary>
        [LoanFieldProperty(Description = "Changed Circumstance - Eligibility")]
        public bool? ReasonEligibility { get => _reasonEligibility; set => _reasonEligibility = value; }
        private DirtyValue<bool?> _reasonExpiration;
        /// <summary>
        /// Expiration (Intent to Proceed received after 10 business days) [LE1.X82]
        /// </summary>
        [LoanFieldProperty(Description = "Expiration (Intent to Proceed received after 10 business days)")]
        public bool? ReasonExpiration { get => _reasonExpiration; set => _reasonExpiration = value; }
        private DirtyValue<bool?> _reasonInterestRate;
        /// <summary>
        /// Interest Rate dependent charges (Rate Lock) [LE1.X81]
        /// </summary>
        [LoanFieldProperty(Description = "Interest Rate dependent charges (Rate Lock)")]
        public bool? ReasonInterestRate { get => _reasonInterestRate; set => _reasonInterestRate = value; }
        private DirtyValue<bool?> _reasonOther;
        /// <summary>
        /// Other [LE1.X84]
        /// </summary>
        [LoanFieldProperty(Description = "Other")]
        public bool? ReasonOther { get => _reasonOther; set => _reasonOther = value; }
        private DirtyValue<string> _reasonOtherDescription;
        /// <summary>
        /// Other Description [LE1.X85]
        /// </summary>
        [LoanFieldProperty(Description = "Other Description")]
        public string ReasonOtherDescription { get => _reasonOtherDescription; set => _reasonOtherDescription = value; }
        private DirtyValue<bool?> _reasonRevisions;
        /// <summary>
        /// Revisions requested by the consumer [LE1.X80]
        /// </summary>
        [LoanFieldProperty(Description = "Revisions requested by the consumer")]
        public bool? ReasonRevisions { get => _reasonRevisions; set => _reasonRevisions = value; }
        private DirtyValue<bool?> _reasonSettlementCharges;
        /// <summary>
        /// Changed Circumstance - Settlement Charges [LE1.X78]
        /// </summary>
        [LoanFieldProperty(Description = "Changed Circumstance - Settlement Charges")]
        public bool? ReasonSettlementCharges { get => _reasonSettlementCharges; set => _reasonSettlementCharges = value; }
        private DirtyValue<decimal?> _totalEstimatedCashClose;
        /// <summary>
        /// Total Estimated Cash to Close [LE1.X87]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Total Estimated Cash to Close")]
        public decimal? TotalEstimatedCashClose { get => _totalEstimatedCashClose; set => _totalEstimatedCashClose = value; }
        private DirtyValue<int?> _yearsToRecast;
        /// <summary>
        /// Loan Estimate - Year Until [LE1.X12]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Estimate - Year Until")]
        public int? YearsToRecast { get => _yearsToRecast; set => _yearsToRecast = value; }
        internal override bool DirtyInternal
        {
            get => _adjustsTermType.Dirty
                || _changedCircumstanceComments.Dirty
                || _closingCostEstimateExpirationDate.Dirty
                || _closingCostEstimateExpirationDateUI.Dirty
                || _closingCostEstimateExpirationTime.Dirty
                || _closingCostEstimateExpirationTimeUI.Dirty
                || _closingCostEstimateExpirationTimeZone.Dirty
                || _closingCostEstimateExpirationTimeZoneUI.Dirty
                || _conversionBegin.Dirty
                || _conversionEnd.Dirty
                || _disclosureBy.Dirty
                || _disclosureClosingCostExpDate.Dirty
                || _disclosureClosingCostExpTime.Dirty
                || _disclosureClosingCostExpTimeZone.Dirty
                || _disclosureComments.Dirty
                || _disclosureLastSentDate.Dirty
                || _disclosureReceivedDate.Dirty
                || _disclosureSentMethod.Dirty
                || _estimatedTaxesInsuranceAssessments.Dirty
                || _estimatedTaxesInsuranceAssessmentsUI.Dirty
                || _highestMonthlyPI.Dirty
                || _id.Dirty
                || _inEscrowHomeownerInsurance.Dirty
                || _inEscrowOther.Dirty
                || _inEscrowPropertyTaxes.Dirty
                || _initialMonthlyPaymentFor10000Loan.Dirty
                || _initialMonthlyPaymentFor60000Loan.Dirty
                || _interestRateAdjustsEveryYears.Dirty
                || _interestRateAdjustsInYear.Dirty
                || _interestRateAdjustsStartingInType.Dirty
                || _interestRateAfterAdjustment.Dirty
                || _interestRateCanGoGoes.Dirty
                || _lEDateIssued.Dirty
                || _loanAmountCanGoGoes.Dirty
                || _loanAmountCanIncreaseOrIncreases.Dirty
                || _loanProduct.Dirty
                || _loanPurpose.Dirty
                || _loanTermMonths.Dirty
                || _loanTermYears.Dirty
                || _maximumMonthlyPaymentFor10000Loan.Dirty
                || _maximumPaymentMonth.Dirty
                || _monthlyPIAdjustedInDateType.Dirty
                || _monthlyPIAdjustsEveryYears.Dirty
                || _monthlyPIAdjustsInYear.Dirty
                || _monthlyPIAdjustsStartingInType.Dirty
                || _monthlyPIAdjustsTermType.Dirty
                || _monthlyPIAfterAdjustment.Dirty
                || _monthlyPICanGoGoes.Dirty
                || _monthlyPIInterestOnlyDateType.Dirty
                || _monthlyPIInterestOnlyUntilYear.Dirty
                || _pPC1EstimatedEscrowAmount.Dirty
                || _pPC1EstimatedEscrowAmountUI.Dirty
                || _pPC1InterestOnly.Dirty
                || _pPC1MaximumMonthlyPayment.Dirty
                || _pPC1MaximumMonthlyPaymentUI.Dirty
                || _pPC1MaximumPIPayment.Dirty
                || _pPC1MaximumPIPaymentUI.Dirty
                || _pPC1MIAmount.Dirty
                || _pPC1MIAmountUI.Dirty
                || _pPC1MinimumMonthlyPayment.Dirty
                || _pPC1MinimumMonthlyPaymentUI.Dirty
                || _pPC1MinimumPIPayment.Dirty
                || _pPC1MinimumPIPaymentUI.Dirty
                || _pPC1Year.Dirty
                || _pPC2EstimatedEscrowAmount.Dirty
                || _pPC2EstimatedEscrowAmountUI.Dirty
                || _pPC2InterestOnly.Dirty
                || _pPC2MaximumMonthlyPayment.Dirty
                || _pPC2MaximumMonthlyPaymentUI.Dirty
                || _pPC2MaximumPIPayment.Dirty
                || _pPC2MaximumPIPaymentUI.Dirty
                || _pPC2MIAmount.Dirty
                || _pPC2MIAmountUI.Dirty
                || _pPC2MinimumMonthlyPayment.Dirty
                || _pPC2MinimumMonthlyPaymentUI.Dirty
                || _pPC2MinimumPIPayment.Dirty
                || _pPC2MinimumPIPaymentUI.Dirty
                || _pPC2YearFrom.Dirty
                || _pPC2YearTo.Dirty
                || _pPC3EstimatedEscrowAmount.Dirty
                || _pPC3EstimatedEscrowAmountUI.Dirty
                || _pPC3InterestOnly.Dirty
                || _pPC3MaximumMonthlyPayment.Dirty
                || _pPC3MaximumMonthlyPaymentUI.Dirty
                || _pPC3MaximumPIPayment.Dirty
                || _pPC3MaximumPIPaymentUI.Dirty
                || _pPC3MIAmount.Dirty
                || _pPC3MIAmountUI.Dirty
                || _pPC3MinimumMonthlyPayment.Dirty
                || _pPC3MinimumMonthlyPaymentUI.Dirty
                || _pPC3MinimumPIPayment.Dirty
                || _pPC3MinimumPIPaymentUI.Dirty
                || _pPC3YearFrom.Dirty
                || _pPC3YearTo.Dirty
                || _pPC4EstimatedEscrowAmount.Dirty
                || _pPC4EstimatedEscrowAmountUI.Dirty
                || _pPC4InterestOnly.Dirty
                || _pPC4MaximumMonthlyPayment.Dirty
                || _pPC4MaximumMonthlyPaymentUI.Dirty
                || _pPC4MaximumPIPayment.Dirty
                || _pPC4MaximumPIPaymentUI.Dirty
                || _pPC4MIAmount.Dirty
                || _pPC4MIAmountUI.Dirty
                || _pPC4MinimumMonthlyPayment.Dirty
                || _pPC4MinimumMonthlyPaymentUI.Dirty
                || _pPC4MinimumPIPayment.Dirty
                || _pPC4MinimumPIPaymentUI.Dirty
                || _pPC4YearFrom.Dirty
                || _pPC4YearTo.Dirty
                || _pPEstimatedEscrowIndicator.Dirty
                || _prepaymentPenaltyPayOffDuringYear.Dirty
                || _prepaymentPenaltyPayOffInDateType.Dirty
                || _prepaymentPenaltyPayOffInFirstYear.Dirty
                || _rangePaymentIndicatorC1.Dirty
                || _rangePaymentIndicatorC2.Dirty
                || _rangePaymentIndicatorC3.Dirty
                || _rangePaymentIndicatorC4.Dirty
                || _rateLockExpirationTime.Dirty
                || _rateLockExpirationTimeZone.Dirty
                || _reasonChangedCircumstanceFlags.Dirty
                || _reasonDelayedSettlement.Dirty
                || _reasonEligibility.Dirty
                || _reasonExpiration.Dirty
                || _reasonInterestRate.Dirty
                || _reasonOther.Dirty
                || _reasonOtherDescription.Dirty
                || _reasonRevisions.Dirty
                || _reasonSettlementCharges.Dirty
                || _totalEstimatedCashClose.Dirty
                || _yearsToRecast.Dirty;
            set
            {
                _adjustsTermType.Dirty = value;
                _changedCircumstanceComments.Dirty = value;
                _closingCostEstimateExpirationDate.Dirty = value;
                _closingCostEstimateExpirationDateUI.Dirty = value;
                _closingCostEstimateExpirationTime.Dirty = value;
                _closingCostEstimateExpirationTimeUI.Dirty = value;
                _closingCostEstimateExpirationTimeZone.Dirty = value;
                _closingCostEstimateExpirationTimeZoneUI.Dirty = value;
                _conversionBegin.Dirty = value;
                _conversionEnd.Dirty = value;
                _disclosureBy.Dirty = value;
                _disclosureClosingCostExpDate.Dirty = value;
                _disclosureClosingCostExpTime.Dirty = value;
                _disclosureClosingCostExpTimeZone.Dirty = value;
                _disclosureComments.Dirty = value;
                _disclosureLastSentDate.Dirty = value;
                _disclosureReceivedDate.Dirty = value;
                _disclosureSentMethod.Dirty = value;
                _estimatedTaxesInsuranceAssessments.Dirty = value;
                _estimatedTaxesInsuranceAssessmentsUI.Dirty = value;
                _highestMonthlyPI.Dirty = value;
                _id.Dirty = value;
                _inEscrowHomeownerInsurance.Dirty = value;
                _inEscrowOther.Dirty = value;
                _inEscrowPropertyTaxes.Dirty = value;
                _initialMonthlyPaymentFor10000Loan.Dirty = value;
                _initialMonthlyPaymentFor60000Loan.Dirty = value;
                _interestRateAdjustsEveryYears.Dirty = value;
                _interestRateAdjustsInYear.Dirty = value;
                _interestRateAdjustsStartingInType.Dirty = value;
                _interestRateAfterAdjustment.Dirty = value;
                _interestRateCanGoGoes.Dirty = value;
                _lEDateIssued.Dirty = value;
                _loanAmountCanGoGoes.Dirty = value;
                _loanAmountCanIncreaseOrIncreases.Dirty = value;
                _loanProduct.Dirty = value;
                _loanPurpose.Dirty = value;
                _loanTermMonths.Dirty = value;
                _loanTermYears.Dirty = value;
                _maximumMonthlyPaymentFor10000Loan.Dirty = value;
                _maximumPaymentMonth.Dirty = value;
                _monthlyPIAdjustedInDateType.Dirty = value;
                _monthlyPIAdjustsEveryYears.Dirty = value;
                _monthlyPIAdjustsInYear.Dirty = value;
                _monthlyPIAdjustsStartingInType.Dirty = value;
                _monthlyPIAdjustsTermType.Dirty = value;
                _monthlyPIAfterAdjustment.Dirty = value;
                _monthlyPICanGoGoes.Dirty = value;
                _monthlyPIInterestOnlyDateType.Dirty = value;
                _monthlyPIInterestOnlyUntilYear.Dirty = value;
                _pPC1EstimatedEscrowAmount.Dirty = value;
                _pPC1EstimatedEscrowAmountUI.Dirty = value;
                _pPC1InterestOnly.Dirty = value;
                _pPC1MaximumMonthlyPayment.Dirty = value;
                _pPC1MaximumMonthlyPaymentUI.Dirty = value;
                _pPC1MaximumPIPayment.Dirty = value;
                _pPC1MaximumPIPaymentUI.Dirty = value;
                _pPC1MIAmount.Dirty = value;
                _pPC1MIAmountUI.Dirty = value;
                _pPC1MinimumMonthlyPayment.Dirty = value;
                _pPC1MinimumMonthlyPaymentUI.Dirty = value;
                _pPC1MinimumPIPayment.Dirty = value;
                _pPC1MinimumPIPaymentUI.Dirty = value;
                _pPC1Year.Dirty = value;
                _pPC2EstimatedEscrowAmount.Dirty = value;
                _pPC2EstimatedEscrowAmountUI.Dirty = value;
                _pPC2InterestOnly.Dirty = value;
                _pPC2MaximumMonthlyPayment.Dirty = value;
                _pPC2MaximumMonthlyPaymentUI.Dirty = value;
                _pPC2MaximumPIPayment.Dirty = value;
                _pPC2MaximumPIPaymentUI.Dirty = value;
                _pPC2MIAmount.Dirty = value;
                _pPC2MIAmountUI.Dirty = value;
                _pPC2MinimumMonthlyPayment.Dirty = value;
                _pPC2MinimumMonthlyPaymentUI.Dirty = value;
                _pPC2MinimumPIPayment.Dirty = value;
                _pPC2MinimumPIPaymentUI.Dirty = value;
                _pPC2YearFrom.Dirty = value;
                _pPC2YearTo.Dirty = value;
                _pPC3EstimatedEscrowAmount.Dirty = value;
                _pPC3EstimatedEscrowAmountUI.Dirty = value;
                _pPC3InterestOnly.Dirty = value;
                _pPC3MaximumMonthlyPayment.Dirty = value;
                _pPC3MaximumMonthlyPaymentUI.Dirty = value;
                _pPC3MaximumPIPayment.Dirty = value;
                _pPC3MaximumPIPaymentUI.Dirty = value;
                _pPC3MIAmount.Dirty = value;
                _pPC3MIAmountUI.Dirty = value;
                _pPC3MinimumMonthlyPayment.Dirty = value;
                _pPC3MinimumMonthlyPaymentUI.Dirty = value;
                _pPC3MinimumPIPayment.Dirty = value;
                _pPC3MinimumPIPaymentUI.Dirty = value;
                _pPC3YearFrom.Dirty = value;
                _pPC3YearTo.Dirty = value;
                _pPC4EstimatedEscrowAmount.Dirty = value;
                _pPC4EstimatedEscrowAmountUI.Dirty = value;
                _pPC4InterestOnly.Dirty = value;
                _pPC4MaximumMonthlyPayment.Dirty = value;
                _pPC4MaximumMonthlyPaymentUI.Dirty = value;
                _pPC4MaximumPIPayment.Dirty = value;
                _pPC4MaximumPIPaymentUI.Dirty = value;
                _pPC4MIAmount.Dirty = value;
                _pPC4MIAmountUI.Dirty = value;
                _pPC4MinimumMonthlyPayment.Dirty = value;
                _pPC4MinimumMonthlyPaymentUI.Dirty = value;
                _pPC4MinimumPIPayment.Dirty = value;
                _pPC4MinimumPIPaymentUI.Dirty = value;
                _pPC4YearFrom.Dirty = value;
                _pPC4YearTo.Dirty = value;
                _pPEstimatedEscrowIndicator.Dirty = value;
                _prepaymentPenaltyPayOffDuringYear.Dirty = value;
                _prepaymentPenaltyPayOffInDateType.Dirty = value;
                _prepaymentPenaltyPayOffInFirstYear.Dirty = value;
                _rangePaymentIndicatorC1.Dirty = value;
                _rangePaymentIndicatorC2.Dirty = value;
                _rangePaymentIndicatorC3.Dirty = value;
                _rangePaymentIndicatorC4.Dirty = value;
                _rateLockExpirationTime.Dirty = value;
                _rateLockExpirationTimeZone.Dirty = value;
                _reasonChangedCircumstanceFlags.Dirty = value;
                _reasonDelayedSettlement.Dirty = value;
                _reasonEligibility.Dirty = value;
                _reasonExpiration.Dirty = value;
                _reasonInterestRate.Dirty = value;
                _reasonOther.Dirty = value;
                _reasonOtherDescription.Dirty = value;
                _reasonRevisions.Dirty = value;
                _reasonSettlementCharges.Dirty = value;
                _totalEstimatedCashClose.Dirty = value;
                _yearsToRecast.Dirty = value;
            }
        }
    }
}