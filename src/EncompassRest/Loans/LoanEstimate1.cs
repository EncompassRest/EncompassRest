using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LoanEstimate1
    {
        private Value<string> _adjustsTermType;
        public string AdjustsTermType { get { return _adjustsTermType; } set { _adjustsTermType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustsTermType() => !_adjustsTermType.Clean;
        private Value<string> _changedCircumstanceComments;
        public string ChangedCircumstanceComments { get { return _changedCircumstanceComments; } set { _changedCircumstanceComments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChangedCircumstanceComments() => !_changedCircumstanceComments.Clean;
        private Value<DateTime?> _closingCostEstimateExpirationDate;
        public DateTime? ClosingCostEstimateExpirationDate { get { return _closingCostEstimateExpirationDate; } set { _closingCostEstimateExpirationDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostEstimateExpirationDate() => !_closingCostEstimateExpirationDate.Clean;
        private Value<string> _closingCostEstimateExpirationTime;
        public string ClosingCostEstimateExpirationTime { get { return _closingCostEstimateExpirationTime; } set { _closingCostEstimateExpirationTime = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostEstimateExpirationTime() => !_closingCostEstimateExpirationTime.Clean;
        private Value<string> _closingCostEstimateExpirationTimeZone;
        public string ClosingCostEstimateExpirationTimeZone { get { return _closingCostEstimateExpirationTimeZone; } set { _closingCostEstimateExpirationTimeZone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostEstimateExpirationTimeZone() => !_closingCostEstimateExpirationTimeZone.Clean;
        private Value<string> _disclosureBy;
        public string DisclosureBy { get { return _disclosureBy; } set { _disclosureBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureBy() => !_disclosureBy.Clean;
        private Value<DateTime?> _disclosureClosingCostExpDate;
        public DateTime? DisclosureClosingCostExpDate { get { return _disclosureClosingCostExpDate; } set { _disclosureClosingCostExpDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureClosingCostExpDate() => !_disclosureClosingCostExpDate.Clean;
        private Value<string> _disclosureClosingCostExpTime;
        public string DisclosureClosingCostExpTime { get { return _disclosureClosingCostExpTime; } set { _disclosureClosingCostExpTime = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureClosingCostExpTime() => !_disclosureClosingCostExpTime.Clean;
        private Value<string> _disclosureClosingCostExpTimeZone;
        public string DisclosureClosingCostExpTimeZone { get { return _disclosureClosingCostExpTimeZone; } set { _disclosureClosingCostExpTimeZone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureClosingCostExpTimeZone() => !_disclosureClosingCostExpTimeZone.Clean;
        private Value<string> _disclosureComments;
        public string DisclosureComments { get { return _disclosureComments; } set { _disclosureComments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureComments() => !_disclosureComments.Clean;
        private Value<DateTime?> _disclosureLastSentDate;
        public DateTime? DisclosureLastSentDate { get { return _disclosureLastSentDate; } set { _disclosureLastSentDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureLastSentDate() => !_disclosureLastSentDate.Clean;
        private Value<DateTime?> _disclosureReceivedDate;
        public DateTime? DisclosureReceivedDate { get { return _disclosureReceivedDate; } set { _disclosureReceivedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureReceivedDate() => !_disclosureReceivedDate.Clean;
        private Value<string> _disclosureSentMethod;
        public string DisclosureSentMethod { get { return _disclosureSentMethod; } set { _disclosureSentMethod = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureSentMethod() => !_disclosureSentMethod.Clean;
        private Value<decimal?> _estimatedTaxesInsuranceAssessments;
        public decimal? EstimatedTaxesInsuranceAssessments { get { return _estimatedTaxesInsuranceAssessments; } set { _estimatedTaxesInsuranceAssessments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedTaxesInsuranceAssessments() => !_estimatedTaxesInsuranceAssessments.Clean;
        private Value<string> _estimatedTaxesInsuranceAssessmentsUI;
        public string EstimatedTaxesInsuranceAssessmentsUI { get { return _estimatedTaxesInsuranceAssessmentsUI; } set { _estimatedTaxesInsuranceAssessmentsUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedTaxesInsuranceAssessmentsUI() => !_estimatedTaxesInsuranceAssessmentsUI.Clean;
        private Value<decimal?> _highestMonthlyPI;
        public decimal? HighestMonthlyPI { get { return _highestMonthlyPI; } set { _highestMonthlyPI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHighestMonthlyPI() => !_highestMonthlyPI.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _inEscrowHomeownerInsurance;
        public string InEscrowHomeownerInsurance { get { return _inEscrowHomeownerInsurance; } set { _inEscrowHomeownerInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInEscrowHomeownerInsurance() => !_inEscrowHomeownerInsurance.Clean;
        private Value<string> _inEscrowOther;
        public string InEscrowOther { get { return _inEscrowOther; } set { _inEscrowOther = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInEscrowOther() => !_inEscrowOther.Clean;
        private Value<string> _inEscrowPropertyTaxes;
        public string InEscrowPropertyTaxes { get { return _inEscrowPropertyTaxes; } set { _inEscrowPropertyTaxes = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInEscrowPropertyTaxes() => !_inEscrowPropertyTaxes.Clean;
        private Value<string> _interestRateAdjustsEveryYears;
        public string InterestRateAdjustsEveryYears { get { return _interestRateAdjustsEveryYears; } set { _interestRateAdjustsEveryYears = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRateAdjustsEveryYears() => !_interestRateAdjustsEveryYears.Clean;
        private Value<int?> _interestRateAdjustsInYear;
        public int? InterestRateAdjustsInYear { get { return _interestRateAdjustsInYear; } set { _interestRateAdjustsInYear = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRateAdjustsInYear() => !_interestRateAdjustsInYear.Clean;
        private Value<string> _interestRateAdjustsStartingInType;
        public string InterestRateAdjustsStartingInType { get { return _interestRateAdjustsStartingInType; } set { _interestRateAdjustsStartingInType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRateAdjustsStartingInType() => !_interestRateAdjustsStartingInType.Clean;
        private Value<int?> _interestRateAfterAdjustment;
        public int? InterestRateAfterAdjustment { get { return _interestRateAfterAdjustment; } set { _interestRateAfterAdjustment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRateAfterAdjustment() => !_interestRateAfterAdjustment.Clean;
        private Value<string> _interestRateCanGoGoes;
        public string InterestRateCanGoGoes { get { return _interestRateCanGoGoes; } set { _interestRateCanGoGoes = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRateCanGoGoes() => !_interestRateCanGoGoes.Clean;
        private Value<DateTime?> _lEDateIssued;
        public DateTime? LEDateIssued { get { return _lEDateIssued; } set { _lEDateIssued = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEDateIssued() => !_lEDateIssued.Clean;
        private Value<string> _loanAmountCanGoGoes;
        public string LoanAmountCanGoGoes { get { return _loanAmountCanGoGoes; } set { _loanAmountCanGoGoes = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmountCanGoGoes() => !_loanAmountCanGoGoes.Clean;
        private Value<string> _loanAmountCanIncreaseOrIncreases;
        public string LoanAmountCanIncreaseOrIncreases { get { return _loanAmountCanIncreaseOrIncreases; } set { _loanAmountCanIncreaseOrIncreases = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmountCanIncreaseOrIncreases() => !_loanAmountCanIncreaseOrIncreases.Clean;
        private Value<string> _loanProduct;
        public string LoanProduct { get { return _loanProduct; } set { _loanProduct = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanProduct() => !_loanProduct.Clean;
        private Value<string> _loanPurpose;
        public string LoanPurpose { get { return _loanPurpose; } set { _loanPurpose = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurpose() => !_loanPurpose.Clean;
        private Value<int?> _loanTermMonths;
        public int? LoanTermMonths { get { return _loanTermMonths; } set { _loanTermMonths = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanTermMonths() => !_loanTermMonths.Clean;
        private Value<int?> _loanTermYears;
        public int? LoanTermYears { get { return _loanTermYears; } set { _loanTermYears = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanTermYears() => !_loanTermYears.Clean;
        private Value<string> _monthlyPIAdjustedInDateType;
        public string MonthlyPIAdjustedInDateType { get { return _monthlyPIAdjustedInDateType; } set { _monthlyPIAdjustedInDateType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPIAdjustedInDateType() => !_monthlyPIAdjustedInDateType.Clean;
        private Value<string> _monthlyPIAdjustsEveryYears;
        public string MonthlyPIAdjustsEveryYears { get { return _monthlyPIAdjustsEveryYears; } set { _monthlyPIAdjustsEveryYears = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPIAdjustsEveryYears() => !_monthlyPIAdjustsEveryYears.Clean;
        private Value<int?> _monthlyPIAdjustsInYear;
        public int? MonthlyPIAdjustsInYear { get { return _monthlyPIAdjustsInYear; } set { _monthlyPIAdjustsInYear = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPIAdjustsInYear() => !_monthlyPIAdjustsInYear.Clean;
        private Value<string> _monthlyPIAdjustsStartingInType;
        public string MonthlyPIAdjustsStartingInType { get { return _monthlyPIAdjustsStartingInType; } set { _monthlyPIAdjustsStartingInType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPIAdjustsStartingInType() => !_monthlyPIAdjustsStartingInType.Clean;
        private Value<string> _monthlyPIAdjustsTermType;
        public string MonthlyPIAdjustsTermType { get { return _monthlyPIAdjustsTermType; } set { _monthlyPIAdjustsTermType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPIAdjustsTermType() => !_monthlyPIAdjustsTermType.Clean;
        private Value<int?> _monthlyPIAfterAdjustment;
        public int? MonthlyPIAfterAdjustment { get { return _monthlyPIAfterAdjustment; } set { _monthlyPIAfterAdjustment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPIAfterAdjustment() => !_monthlyPIAfterAdjustment.Clean;
        private Value<string> _monthlyPICanGoGoes;
        public string MonthlyPICanGoGoes { get { return _monthlyPICanGoGoes; } set { _monthlyPICanGoGoes = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPICanGoGoes() => !_monthlyPICanGoGoes.Clean;
        private Value<string> _monthlyPIInterestOnlyDateType;
        public string MonthlyPIInterestOnlyDateType { get { return _monthlyPIInterestOnlyDateType; } set { _monthlyPIInterestOnlyDateType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPIInterestOnlyDateType() => !_monthlyPIInterestOnlyDateType.Clean;
        private Value<int?> _monthlyPIInterestOnlyUntilYear;
        public int? MonthlyPIInterestOnlyUntilYear { get { return _monthlyPIInterestOnlyUntilYear; } set { _monthlyPIInterestOnlyUntilYear = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPIInterestOnlyUntilYear() => !_monthlyPIInterestOnlyUntilYear.Clean;
        private Value<int?> _pPC1EstimatedEscrowAmount;
        public int? PPC1EstimatedEscrowAmount { get { return _pPC1EstimatedEscrowAmount; } set { _pPC1EstimatedEscrowAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1EstimatedEscrowAmount() => !_pPC1EstimatedEscrowAmount.Clean;
        private Value<string> _pPC1EstimatedEscrowAmountUI;
        public string PPC1EstimatedEscrowAmountUI { get { return _pPC1EstimatedEscrowAmountUI; } set { _pPC1EstimatedEscrowAmountUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1EstimatedEscrowAmountUI() => !_pPC1EstimatedEscrowAmountUI.Clean;
        private Value<bool?> _pPC1InterestOnly;
        public bool? PPC1InterestOnly { get { return _pPC1InterestOnly; } set { _pPC1InterestOnly = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1InterestOnly() => !_pPC1InterestOnly.Clean;
        private Value<decimal?> _pPC1MaximumMonthlyPayment;
        public decimal? PPC1MaximumMonthlyPayment { get { return _pPC1MaximumMonthlyPayment; } set { _pPC1MaximumMonthlyPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MaximumMonthlyPayment() => !_pPC1MaximumMonthlyPayment.Clean;
        private Value<string> _pPC1MaximumMonthlyPaymentUI;
        public string PPC1MaximumMonthlyPaymentUI { get { return _pPC1MaximumMonthlyPaymentUI; } set { _pPC1MaximumMonthlyPaymentUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MaximumMonthlyPaymentUI() => !_pPC1MaximumMonthlyPaymentUI.Clean;
        private Value<decimal?> _pPC1MaximumPIPayment;
        public decimal? PPC1MaximumPIPayment { get { return _pPC1MaximumPIPayment; } set { _pPC1MaximumPIPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MaximumPIPayment() => !_pPC1MaximumPIPayment.Clean;
        private Value<string> _pPC1MaximumPIPaymentUI;
        public string PPC1MaximumPIPaymentUI { get { return _pPC1MaximumPIPaymentUI; } set { _pPC1MaximumPIPaymentUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MaximumPIPaymentUI() => !_pPC1MaximumPIPaymentUI.Clean;
        private Value<int?> _pPC1MIAmount;
        public int? PPC1MIAmount { get { return _pPC1MIAmount; } set { _pPC1MIAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MIAmount() => !_pPC1MIAmount.Clean;
        private Value<string> _pPC1MIAmountUI;
        public string PPC1MIAmountUI { get { return _pPC1MIAmountUI; } set { _pPC1MIAmountUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MIAmountUI() => !_pPC1MIAmountUI.Clean;
        private Value<int?> _pPC1MinimumMonthlyPayment;
        public int? PPC1MinimumMonthlyPayment { get { return _pPC1MinimumMonthlyPayment; } set { _pPC1MinimumMonthlyPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MinimumMonthlyPayment() => !_pPC1MinimumMonthlyPayment.Clean;
        private Value<string> _pPC1MinimumMonthlyPaymentUI;
        public string PPC1MinimumMonthlyPaymentUI { get { return _pPC1MinimumMonthlyPaymentUI; } set { _pPC1MinimumMonthlyPaymentUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MinimumMonthlyPaymentUI() => !_pPC1MinimumMonthlyPaymentUI.Clean;
        private Value<decimal?> _pPC1MinimumPIPayment;
        public decimal? PPC1MinimumPIPayment { get { return _pPC1MinimumPIPayment; } set { _pPC1MinimumPIPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MinimumPIPayment() => !_pPC1MinimumPIPayment.Clean;
        private Value<string> _pPC1MinimumPIPaymentUI;
        public string PPC1MinimumPIPaymentUI { get { return _pPC1MinimumPIPaymentUI; } set { _pPC1MinimumPIPaymentUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1MinimumPIPaymentUI() => !_pPC1MinimumPIPaymentUI.Clean;
        private Value<int?> _pPC1Year;
        public int? PPC1Year { get { return _pPC1Year; } set { _pPC1Year = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC1Year() => !_pPC1Year.Clean;
        private Value<int?> _pPC2EstimatedEscrowAmount;
        public int? PPC2EstimatedEscrowAmount { get { return _pPC2EstimatedEscrowAmount; } set { _pPC2EstimatedEscrowAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2EstimatedEscrowAmount() => !_pPC2EstimatedEscrowAmount.Clean;
        private Value<string> _pPC2EstimatedEscrowAmountUI;
        public string PPC2EstimatedEscrowAmountUI { get { return _pPC2EstimatedEscrowAmountUI; } set { _pPC2EstimatedEscrowAmountUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2EstimatedEscrowAmountUI() => !_pPC2EstimatedEscrowAmountUI.Clean;
        private Value<bool?> _pPC2InterestOnly;
        public bool? PPC2InterestOnly { get { return _pPC2InterestOnly; } set { _pPC2InterestOnly = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2InterestOnly() => !_pPC2InterestOnly.Clean;
        private Value<decimal?> _pPC2MaximumMonthlyPayment;
        public decimal? PPC2MaximumMonthlyPayment { get { return _pPC2MaximumMonthlyPayment; } set { _pPC2MaximumMonthlyPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MaximumMonthlyPayment() => !_pPC2MaximumMonthlyPayment.Clean;
        private Value<string> _pPC2MaximumMonthlyPaymentUI;
        public string PPC2MaximumMonthlyPaymentUI { get { return _pPC2MaximumMonthlyPaymentUI; } set { _pPC2MaximumMonthlyPaymentUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MaximumMonthlyPaymentUI() => !_pPC2MaximumMonthlyPaymentUI.Clean;
        private Value<decimal?> _pPC2MaximumPIPayment;
        public decimal? PPC2MaximumPIPayment { get { return _pPC2MaximumPIPayment; } set { _pPC2MaximumPIPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MaximumPIPayment() => !_pPC2MaximumPIPayment.Clean;
        private Value<string> _pPC2MaximumPIPaymentUI;
        public string PPC2MaximumPIPaymentUI { get { return _pPC2MaximumPIPaymentUI; } set { _pPC2MaximumPIPaymentUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MaximumPIPaymentUI() => !_pPC2MaximumPIPaymentUI.Clean;
        private Value<int?> _pPC2MIAmount;
        public int? PPC2MIAmount { get { return _pPC2MIAmount; } set { _pPC2MIAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MIAmount() => !_pPC2MIAmount.Clean;
        private Value<string> _pPC2MIAmountUI;
        public string PPC2MIAmountUI { get { return _pPC2MIAmountUI; } set { _pPC2MIAmountUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MIAmountUI() => !_pPC2MIAmountUI.Clean;
        private Value<int?> _pPC2MinimumMonthlyPayment;
        public int? PPC2MinimumMonthlyPayment { get { return _pPC2MinimumMonthlyPayment; } set { _pPC2MinimumMonthlyPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MinimumMonthlyPayment() => !_pPC2MinimumMonthlyPayment.Clean;
        private Value<string> _pPC2MinimumMonthlyPaymentUI;
        public string PPC2MinimumMonthlyPaymentUI { get { return _pPC2MinimumMonthlyPaymentUI; } set { _pPC2MinimumMonthlyPaymentUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MinimumMonthlyPaymentUI() => !_pPC2MinimumMonthlyPaymentUI.Clean;
        private Value<decimal?> _pPC2MinimumPIPayment;
        public decimal? PPC2MinimumPIPayment { get { return _pPC2MinimumPIPayment; } set { _pPC2MinimumPIPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MinimumPIPayment() => !_pPC2MinimumPIPayment.Clean;
        private Value<string> _pPC2MinimumPIPaymentUI;
        public string PPC2MinimumPIPaymentUI { get { return _pPC2MinimumPIPaymentUI; } set { _pPC2MinimumPIPaymentUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2MinimumPIPaymentUI() => !_pPC2MinimumPIPaymentUI.Clean;
        private Value<int?> _pPC2YearFrom;
        public int? PPC2YearFrom { get { return _pPC2YearFrom; } set { _pPC2YearFrom = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2YearFrom() => !_pPC2YearFrom.Clean;
        private Value<int?> _pPC2YearTo;
        public int? PPC2YearTo { get { return _pPC2YearTo; } set { _pPC2YearTo = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC2YearTo() => !_pPC2YearTo.Clean;
        private Value<int?> _pPC3EstimatedEscrowAmount;
        public int? PPC3EstimatedEscrowAmount { get { return _pPC3EstimatedEscrowAmount; } set { _pPC3EstimatedEscrowAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3EstimatedEscrowAmount() => !_pPC3EstimatedEscrowAmount.Clean;
        private Value<string> _pPC3EstimatedEscrowAmountUI;
        public string PPC3EstimatedEscrowAmountUI { get { return _pPC3EstimatedEscrowAmountUI; } set { _pPC3EstimatedEscrowAmountUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3EstimatedEscrowAmountUI() => !_pPC3EstimatedEscrowAmountUI.Clean;
        private Value<bool?> _pPC3InterestOnly;
        public bool? PPC3InterestOnly { get { return _pPC3InterestOnly; } set { _pPC3InterestOnly = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3InterestOnly() => !_pPC3InterestOnly.Clean;
        private Value<decimal?> _pPC3MaximumMonthlyPayment;
        public decimal? PPC3MaximumMonthlyPayment { get { return _pPC3MaximumMonthlyPayment; } set { _pPC3MaximumMonthlyPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MaximumMonthlyPayment() => !_pPC3MaximumMonthlyPayment.Clean;
        private Value<string> _pPC3MaximumMonthlyPaymentUI;
        public string PPC3MaximumMonthlyPaymentUI { get { return _pPC3MaximumMonthlyPaymentUI; } set { _pPC3MaximumMonthlyPaymentUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MaximumMonthlyPaymentUI() => !_pPC3MaximumMonthlyPaymentUI.Clean;
        private Value<decimal?> _pPC3MaximumPIPayment;
        public decimal? PPC3MaximumPIPayment { get { return _pPC3MaximumPIPayment; } set { _pPC3MaximumPIPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MaximumPIPayment() => !_pPC3MaximumPIPayment.Clean;
        private Value<string> _pPC3MaximumPIPaymentUI;
        public string PPC3MaximumPIPaymentUI { get { return _pPC3MaximumPIPaymentUI; } set { _pPC3MaximumPIPaymentUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MaximumPIPaymentUI() => !_pPC3MaximumPIPaymentUI.Clean;
        private Value<int?> _pPC3MIAmount;
        public int? PPC3MIAmount { get { return _pPC3MIAmount; } set { _pPC3MIAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MIAmount() => !_pPC3MIAmount.Clean;
        private Value<string> _pPC3MIAmountUI;
        public string PPC3MIAmountUI { get { return _pPC3MIAmountUI; } set { _pPC3MIAmountUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MIAmountUI() => !_pPC3MIAmountUI.Clean;
        private Value<int?> _pPC3MinimumMonthlyPayment;
        public int? PPC3MinimumMonthlyPayment { get { return _pPC3MinimumMonthlyPayment; } set { _pPC3MinimumMonthlyPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MinimumMonthlyPayment() => !_pPC3MinimumMonthlyPayment.Clean;
        private Value<string> _pPC3MinimumMonthlyPaymentUI;
        public string PPC3MinimumMonthlyPaymentUI { get { return _pPC3MinimumMonthlyPaymentUI; } set { _pPC3MinimumMonthlyPaymentUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MinimumMonthlyPaymentUI() => !_pPC3MinimumMonthlyPaymentUI.Clean;
        private Value<decimal?> _pPC3MinimumPIPayment;
        public decimal? PPC3MinimumPIPayment { get { return _pPC3MinimumPIPayment; } set { _pPC3MinimumPIPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MinimumPIPayment() => !_pPC3MinimumPIPayment.Clean;
        private Value<string> _pPC3MinimumPIPaymentUI;
        public string PPC3MinimumPIPaymentUI { get { return _pPC3MinimumPIPaymentUI; } set { _pPC3MinimumPIPaymentUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3MinimumPIPaymentUI() => !_pPC3MinimumPIPaymentUI.Clean;
        private Value<int?> _pPC3YearFrom;
        public int? PPC3YearFrom { get { return _pPC3YearFrom; } set { _pPC3YearFrom = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3YearFrom() => !_pPC3YearFrom.Clean;
        private Value<int?> _pPC3YearTo;
        public int? PPC3YearTo { get { return _pPC3YearTo; } set { _pPC3YearTo = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC3YearTo() => !_pPC3YearTo.Clean;
        private Value<int?> _pPC4EstimatedEscrowAmount;
        public int? PPC4EstimatedEscrowAmount { get { return _pPC4EstimatedEscrowAmount; } set { _pPC4EstimatedEscrowAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4EstimatedEscrowAmount() => !_pPC4EstimatedEscrowAmount.Clean;
        private Value<string> _pPC4EstimatedEscrowAmountUI;
        public string PPC4EstimatedEscrowAmountUI { get { return _pPC4EstimatedEscrowAmountUI; } set { _pPC4EstimatedEscrowAmountUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4EstimatedEscrowAmountUI() => !_pPC4EstimatedEscrowAmountUI.Clean;
        private Value<bool?> _pPC4InterestOnly;
        public bool? PPC4InterestOnly { get { return _pPC4InterestOnly; } set { _pPC4InterestOnly = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4InterestOnly() => !_pPC4InterestOnly.Clean;
        private Value<decimal?> _pPC4MaximumMonthlyPayment;
        public decimal? PPC4MaximumMonthlyPayment { get { return _pPC4MaximumMonthlyPayment; } set { _pPC4MaximumMonthlyPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MaximumMonthlyPayment() => !_pPC4MaximumMonthlyPayment.Clean;
        private Value<string> _pPC4MaximumMonthlyPaymentUI;
        public string PPC4MaximumMonthlyPaymentUI { get { return _pPC4MaximumMonthlyPaymentUI; } set { _pPC4MaximumMonthlyPaymentUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MaximumMonthlyPaymentUI() => !_pPC4MaximumMonthlyPaymentUI.Clean;
        private Value<decimal?> _pPC4MaximumPIPayment;
        public decimal? PPC4MaximumPIPayment { get { return _pPC4MaximumPIPayment; } set { _pPC4MaximumPIPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MaximumPIPayment() => !_pPC4MaximumPIPayment.Clean;
        private Value<string> _pPC4MaximumPIPaymentUI;
        public string PPC4MaximumPIPaymentUI { get { return _pPC4MaximumPIPaymentUI; } set { _pPC4MaximumPIPaymentUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MaximumPIPaymentUI() => !_pPC4MaximumPIPaymentUI.Clean;
        private Value<int?> _pPC4MIAmount;
        public int? PPC4MIAmount { get { return _pPC4MIAmount; } set { _pPC4MIAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MIAmount() => !_pPC4MIAmount.Clean;
        private Value<string> _pPC4MIAmountUI;
        public string PPC4MIAmountUI { get { return _pPC4MIAmountUI; } set { _pPC4MIAmountUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MIAmountUI() => !_pPC4MIAmountUI.Clean;
        private Value<int?> _pPC4MinimumMonthlyPayment;
        public int? PPC4MinimumMonthlyPayment { get { return _pPC4MinimumMonthlyPayment; } set { _pPC4MinimumMonthlyPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MinimumMonthlyPayment() => !_pPC4MinimumMonthlyPayment.Clean;
        private Value<string> _pPC4MinimumMonthlyPaymentUI;
        public string PPC4MinimumMonthlyPaymentUI { get { return _pPC4MinimumMonthlyPaymentUI; } set { _pPC4MinimumMonthlyPaymentUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MinimumMonthlyPaymentUI() => !_pPC4MinimumMonthlyPaymentUI.Clean;
        private Value<decimal?> _pPC4MinimumPIPayment;
        public decimal? PPC4MinimumPIPayment { get { return _pPC4MinimumPIPayment; } set { _pPC4MinimumPIPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MinimumPIPayment() => !_pPC4MinimumPIPayment.Clean;
        private Value<string> _pPC4MinimumPIPaymentUI;
        public string PPC4MinimumPIPaymentUI { get { return _pPC4MinimumPIPaymentUI; } set { _pPC4MinimumPIPaymentUI = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4MinimumPIPaymentUI() => !_pPC4MinimumPIPaymentUI.Clean;
        private Value<int?> _pPC4YearFrom;
        public int? PPC4YearFrom { get { return _pPC4YearFrom; } set { _pPC4YearFrom = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4YearFrom() => !_pPC4YearFrom.Clean;
        private Value<int?> _pPC4YearTo;
        public int? PPC4YearTo { get { return _pPC4YearTo; } set { _pPC4YearTo = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPC4YearTo() => !_pPC4YearTo.Clean;
        private Value<bool?> _pPEstimatedEscrowIndicator;
        public bool? PPEstimatedEscrowIndicator { get { return _pPEstimatedEscrowIndicator; } set { _pPEstimatedEscrowIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePPEstimatedEscrowIndicator() => !_pPEstimatedEscrowIndicator.Clean;
        private Value<int?> _prepaymentPenaltyPayOffDuringYear;
        public int? PrepaymentPenaltyPayOffDuringYear { get { return _prepaymentPenaltyPayOffDuringYear; } set { _prepaymentPenaltyPayOffDuringYear = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyPayOffDuringYear() => !_prepaymentPenaltyPayOffDuringYear.Clean;
        private Value<string> _prepaymentPenaltyPayOffInDateType;
        public string PrepaymentPenaltyPayOffInDateType { get { return _prepaymentPenaltyPayOffInDateType; } set { _prepaymentPenaltyPayOffInDateType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyPayOffInDateType() => !_prepaymentPenaltyPayOffInDateType.Clean;
        private Value<string> _prepaymentPenaltyPayOffInFirstYear;
        public string PrepaymentPenaltyPayOffInFirstYear { get { return _prepaymentPenaltyPayOffInFirstYear; } set { _prepaymentPenaltyPayOffInFirstYear = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyPayOffInFirstYear() => !_prepaymentPenaltyPayOffInFirstYear.Clean;
        private Value<bool?> _rangePaymentIndicatorC1;
        public bool? RangePaymentIndicatorC1 { get { return _rangePaymentIndicatorC1; } set { _rangePaymentIndicatorC1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRangePaymentIndicatorC1() => !_rangePaymentIndicatorC1.Clean;
        private Value<bool?> _rangePaymentIndicatorC2;
        public bool? RangePaymentIndicatorC2 { get { return _rangePaymentIndicatorC2; } set { _rangePaymentIndicatorC2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRangePaymentIndicatorC2() => !_rangePaymentIndicatorC2.Clean;
        private Value<bool?> _rangePaymentIndicatorC3;
        public bool? RangePaymentIndicatorC3 { get { return _rangePaymentIndicatorC3; } set { _rangePaymentIndicatorC3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRangePaymentIndicatorC3() => !_rangePaymentIndicatorC3.Clean;
        private Value<bool?> _rangePaymentIndicatorC4;
        public bool? RangePaymentIndicatorC4 { get { return _rangePaymentIndicatorC4; } set { _rangePaymentIndicatorC4 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRangePaymentIndicatorC4() => !_rangePaymentIndicatorC4.Clean;
        private Value<string> _rateLockExpirationTime;
        public string RateLockExpirationTime { get { return _rateLockExpirationTime; } set { _rateLockExpirationTime = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateLockExpirationTime() => !_rateLockExpirationTime.Clean;
        private Value<string> _rateLockExpirationTimeZone;
        public string RateLockExpirationTimeZone { get { return _rateLockExpirationTimeZone; } set { _rateLockExpirationTimeZone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateLockExpirationTimeZone() => !_rateLockExpirationTimeZone.Clean;
        private Value<string> _reasonChangedCircumstanceFlags;
        public string ReasonChangedCircumstanceFlags { get { return _reasonChangedCircumstanceFlags; } set { _reasonChangedCircumstanceFlags = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonChangedCircumstanceFlags() => !_reasonChangedCircumstanceFlags.Clean;
        private Value<bool?> _reasonDelayedSettlement;
        public bool? ReasonDelayedSettlement { get { return _reasonDelayedSettlement; } set { _reasonDelayedSettlement = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonDelayedSettlement() => !_reasonDelayedSettlement.Clean;
        private Value<bool?> _reasonEligibility;
        public bool? ReasonEligibility { get { return _reasonEligibility; } set { _reasonEligibility = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonEligibility() => !_reasonEligibility.Clean;
        private Value<bool?> _reasonExpiration;
        public bool? ReasonExpiration { get { return _reasonExpiration; } set { _reasonExpiration = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonExpiration() => !_reasonExpiration.Clean;
        private Value<bool?> _reasonInterestRate;
        public bool? ReasonInterestRate { get { return _reasonInterestRate; } set { _reasonInterestRate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonInterestRate() => !_reasonInterestRate.Clean;
        private Value<bool?> _reasonOther;
        public bool? ReasonOther { get { return _reasonOther; } set { _reasonOther = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonOther() => !_reasonOther.Clean;
        private Value<string> _reasonOtherDescription;
        public string ReasonOtherDescription { get { return _reasonOtherDescription; } set { _reasonOtherDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonOtherDescription() => !_reasonOtherDescription.Clean;
        private Value<bool?> _reasonRevisions;
        public bool? ReasonRevisions { get { return _reasonRevisions; } set { _reasonRevisions = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonRevisions() => !_reasonRevisions.Clean;
        private Value<bool?> _reasonSettlementCharges;
        public bool? ReasonSettlementCharges { get { return _reasonSettlementCharges; } set { _reasonSettlementCharges = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonSettlementCharges() => !_reasonSettlementCharges.Clean;
        private Value<decimal?> _totalEstimatedCashClose;
        public decimal? TotalEstimatedCashClose { get { return _totalEstimatedCashClose; } set { _totalEstimatedCashClose = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalEstimatedCashClose() => !_totalEstimatedCashClose.Clean;
        private Value<int?> _yearsToRecast;
        public int? YearsToRecast { get { return _yearsToRecast; } set { _yearsToRecast = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearsToRecast() => !_yearsToRecast.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _adjustsTermType.Clean
                    && _changedCircumstanceComments.Clean
                    && _closingCostEstimateExpirationDate.Clean
                    && _closingCostEstimateExpirationTime.Clean
                    && _closingCostEstimateExpirationTimeZone.Clean
                    && _disclosureBy.Clean
                    && _disclosureClosingCostExpDate.Clean
                    && _disclosureClosingCostExpTime.Clean
                    && _disclosureClosingCostExpTimeZone.Clean
                    && _disclosureComments.Clean
                    && _disclosureLastSentDate.Clean
                    && _disclosureReceivedDate.Clean
                    && _disclosureSentMethod.Clean
                    && _estimatedTaxesInsuranceAssessments.Clean
                    && _estimatedTaxesInsuranceAssessmentsUI.Clean
                    && _highestMonthlyPI.Clean
                    && _id.Clean
                    && _inEscrowHomeownerInsurance.Clean
                    && _inEscrowOther.Clean
                    && _inEscrowPropertyTaxes.Clean
                    && _interestRateAdjustsEveryYears.Clean
                    && _interestRateAdjustsInYear.Clean
                    && _interestRateAdjustsStartingInType.Clean
                    && _interestRateAfterAdjustment.Clean
                    && _interestRateCanGoGoes.Clean
                    && _lEDateIssued.Clean
                    && _loanAmountCanGoGoes.Clean
                    && _loanAmountCanIncreaseOrIncreases.Clean
                    && _loanProduct.Clean
                    && _loanPurpose.Clean
                    && _loanTermMonths.Clean
                    && _loanTermYears.Clean
                    && _monthlyPIAdjustedInDateType.Clean
                    && _monthlyPIAdjustsEveryYears.Clean
                    && _monthlyPIAdjustsInYear.Clean
                    && _monthlyPIAdjustsStartingInType.Clean
                    && _monthlyPIAdjustsTermType.Clean
                    && _monthlyPIAfterAdjustment.Clean
                    && _monthlyPICanGoGoes.Clean
                    && _monthlyPIInterestOnlyDateType.Clean
                    && _monthlyPIInterestOnlyUntilYear.Clean
                    && _pPC1EstimatedEscrowAmount.Clean
                    && _pPC1EstimatedEscrowAmountUI.Clean
                    && _pPC1InterestOnly.Clean
                    && _pPC1MaximumMonthlyPayment.Clean
                    && _pPC1MaximumMonthlyPaymentUI.Clean
                    && _pPC1MaximumPIPayment.Clean
                    && _pPC1MaximumPIPaymentUI.Clean
                    && _pPC1MIAmount.Clean
                    && _pPC1MIAmountUI.Clean
                    && _pPC1MinimumMonthlyPayment.Clean
                    && _pPC1MinimumMonthlyPaymentUI.Clean
                    && _pPC1MinimumPIPayment.Clean
                    && _pPC1MinimumPIPaymentUI.Clean
                    && _pPC1Year.Clean
                    && _pPC2EstimatedEscrowAmount.Clean
                    && _pPC2EstimatedEscrowAmountUI.Clean
                    && _pPC2InterestOnly.Clean
                    && _pPC2MaximumMonthlyPayment.Clean
                    && _pPC2MaximumMonthlyPaymentUI.Clean
                    && _pPC2MaximumPIPayment.Clean
                    && _pPC2MaximumPIPaymentUI.Clean
                    && _pPC2MIAmount.Clean
                    && _pPC2MIAmountUI.Clean
                    && _pPC2MinimumMonthlyPayment.Clean
                    && _pPC2MinimumMonthlyPaymentUI.Clean
                    && _pPC2MinimumPIPayment.Clean
                    && _pPC2MinimumPIPaymentUI.Clean
                    && _pPC2YearFrom.Clean
                    && _pPC2YearTo.Clean
                    && _pPC3EstimatedEscrowAmount.Clean
                    && _pPC3EstimatedEscrowAmountUI.Clean
                    && _pPC3InterestOnly.Clean
                    && _pPC3MaximumMonthlyPayment.Clean
                    && _pPC3MaximumMonthlyPaymentUI.Clean
                    && _pPC3MaximumPIPayment.Clean
                    && _pPC3MaximumPIPaymentUI.Clean
                    && _pPC3MIAmount.Clean
                    && _pPC3MIAmountUI.Clean
                    && _pPC3MinimumMonthlyPayment.Clean
                    && _pPC3MinimumMonthlyPaymentUI.Clean
                    && _pPC3MinimumPIPayment.Clean
                    && _pPC3MinimumPIPaymentUI.Clean
                    && _pPC3YearFrom.Clean
                    && _pPC3YearTo.Clean
                    && _pPC4EstimatedEscrowAmount.Clean
                    && _pPC4EstimatedEscrowAmountUI.Clean
                    && _pPC4InterestOnly.Clean
                    && _pPC4MaximumMonthlyPayment.Clean
                    && _pPC4MaximumMonthlyPaymentUI.Clean
                    && _pPC4MaximumPIPayment.Clean
                    && _pPC4MaximumPIPaymentUI.Clean
                    && _pPC4MIAmount.Clean
                    && _pPC4MIAmountUI.Clean
                    && _pPC4MinimumMonthlyPayment.Clean
                    && _pPC4MinimumMonthlyPaymentUI.Clean
                    && _pPC4MinimumPIPayment.Clean
                    && _pPC4MinimumPIPaymentUI.Clean
                    && _pPC4YearFrom.Clean
                    && _pPC4YearTo.Clean
                    && _pPEstimatedEscrowIndicator.Clean
                    && _prepaymentPenaltyPayOffDuringYear.Clean
                    && _prepaymentPenaltyPayOffInDateType.Clean
                    && _prepaymentPenaltyPayOffInFirstYear.Clean
                    && _rangePaymentIndicatorC1.Clean
                    && _rangePaymentIndicatorC2.Clean
                    && _rangePaymentIndicatorC3.Clean
                    && _rangePaymentIndicatorC4.Clean
                    && _rateLockExpirationTime.Clean
                    && _rateLockExpirationTimeZone.Clean
                    && _reasonChangedCircumstanceFlags.Clean
                    && _reasonDelayedSettlement.Clean
                    && _reasonEligibility.Clean
                    && _reasonExpiration.Clean
                    && _reasonInterestRate.Clean
                    && _reasonOther.Clean
                    && _reasonOtherDescription.Clean
                    && _reasonRevisions.Clean
                    && _reasonSettlementCharges.Clean
                    && _totalEstimatedCashClose.Clean
                    && _yearsToRecast.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _adjustsTermType; v0.Clean = value; _adjustsTermType = v0;
                var v1 = _changedCircumstanceComments; v1.Clean = value; _changedCircumstanceComments = v1;
                var v2 = _closingCostEstimateExpirationDate; v2.Clean = value; _closingCostEstimateExpirationDate = v2;
                var v3 = _closingCostEstimateExpirationTime; v3.Clean = value; _closingCostEstimateExpirationTime = v3;
                var v4 = _closingCostEstimateExpirationTimeZone; v4.Clean = value; _closingCostEstimateExpirationTimeZone = v4;
                var v5 = _disclosureBy; v5.Clean = value; _disclosureBy = v5;
                var v6 = _disclosureClosingCostExpDate; v6.Clean = value; _disclosureClosingCostExpDate = v6;
                var v7 = _disclosureClosingCostExpTime; v7.Clean = value; _disclosureClosingCostExpTime = v7;
                var v8 = _disclosureClosingCostExpTimeZone; v8.Clean = value; _disclosureClosingCostExpTimeZone = v8;
                var v9 = _disclosureComments; v9.Clean = value; _disclosureComments = v9;
                var v10 = _disclosureLastSentDate; v10.Clean = value; _disclosureLastSentDate = v10;
                var v11 = _disclosureReceivedDate; v11.Clean = value; _disclosureReceivedDate = v11;
                var v12 = _disclosureSentMethod; v12.Clean = value; _disclosureSentMethod = v12;
                var v13 = _estimatedTaxesInsuranceAssessments; v13.Clean = value; _estimatedTaxesInsuranceAssessments = v13;
                var v14 = _estimatedTaxesInsuranceAssessmentsUI; v14.Clean = value; _estimatedTaxesInsuranceAssessmentsUI = v14;
                var v15 = _highestMonthlyPI; v15.Clean = value; _highestMonthlyPI = v15;
                var v16 = _id; v16.Clean = value; _id = v16;
                var v17 = _inEscrowHomeownerInsurance; v17.Clean = value; _inEscrowHomeownerInsurance = v17;
                var v18 = _inEscrowOther; v18.Clean = value; _inEscrowOther = v18;
                var v19 = _inEscrowPropertyTaxes; v19.Clean = value; _inEscrowPropertyTaxes = v19;
                var v20 = _interestRateAdjustsEveryYears; v20.Clean = value; _interestRateAdjustsEveryYears = v20;
                var v21 = _interestRateAdjustsInYear; v21.Clean = value; _interestRateAdjustsInYear = v21;
                var v22 = _interestRateAdjustsStartingInType; v22.Clean = value; _interestRateAdjustsStartingInType = v22;
                var v23 = _interestRateAfterAdjustment; v23.Clean = value; _interestRateAfterAdjustment = v23;
                var v24 = _interestRateCanGoGoes; v24.Clean = value; _interestRateCanGoGoes = v24;
                var v25 = _lEDateIssued; v25.Clean = value; _lEDateIssued = v25;
                var v26 = _loanAmountCanGoGoes; v26.Clean = value; _loanAmountCanGoGoes = v26;
                var v27 = _loanAmountCanIncreaseOrIncreases; v27.Clean = value; _loanAmountCanIncreaseOrIncreases = v27;
                var v28 = _loanProduct; v28.Clean = value; _loanProduct = v28;
                var v29 = _loanPurpose; v29.Clean = value; _loanPurpose = v29;
                var v30 = _loanTermMonths; v30.Clean = value; _loanTermMonths = v30;
                var v31 = _loanTermYears; v31.Clean = value; _loanTermYears = v31;
                var v32 = _monthlyPIAdjustedInDateType; v32.Clean = value; _monthlyPIAdjustedInDateType = v32;
                var v33 = _monthlyPIAdjustsEveryYears; v33.Clean = value; _monthlyPIAdjustsEveryYears = v33;
                var v34 = _monthlyPIAdjustsInYear; v34.Clean = value; _monthlyPIAdjustsInYear = v34;
                var v35 = _monthlyPIAdjustsStartingInType; v35.Clean = value; _monthlyPIAdjustsStartingInType = v35;
                var v36 = _monthlyPIAdjustsTermType; v36.Clean = value; _monthlyPIAdjustsTermType = v36;
                var v37 = _monthlyPIAfterAdjustment; v37.Clean = value; _monthlyPIAfterAdjustment = v37;
                var v38 = _monthlyPICanGoGoes; v38.Clean = value; _monthlyPICanGoGoes = v38;
                var v39 = _monthlyPIInterestOnlyDateType; v39.Clean = value; _monthlyPIInterestOnlyDateType = v39;
                var v40 = _monthlyPIInterestOnlyUntilYear; v40.Clean = value; _monthlyPIInterestOnlyUntilYear = v40;
                var v41 = _pPC1EstimatedEscrowAmount; v41.Clean = value; _pPC1EstimatedEscrowAmount = v41;
                var v42 = _pPC1EstimatedEscrowAmountUI; v42.Clean = value; _pPC1EstimatedEscrowAmountUI = v42;
                var v43 = _pPC1InterestOnly; v43.Clean = value; _pPC1InterestOnly = v43;
                var v44 = _pPC1MaximumMonthlyPayment; v44.Clean = value; _pPC1MaximumMonthlyPayment = v44;
                var v45 = _pPC1MaximumMonthlyPaymentUI; v45.Clean = value; _pPC1MaximumMonthlyPaymentUI = v45;
                var v46 = _pPC1MaximumPIPayment; v46.Clean = value; _pPC1MaximumPIPayment = v46;
                var v47 = _pPC1MaximumPIPaymentUI; v47.Clean = value; _pPC1MaximumPIPaymentUI = v47;
                var v48 = _pPC1MIAmount; v48.Clean = value; _pPC1MIAmount = v48;
                var v49 = _pPC1MIAmountUI; v49.Clean = value; _pPC1MIAmountUI = v49;
                var v50 = _pPC1MinimumMonthlyPayment; v50.Clean = value; _pPC1MinimumMonthlyPayment = v50;
                var v51 = _pPC1MinimumMonthlyPaymentUI; v51.Clean = value; _pPC1MinimumMonthlyPaymentUI = v51;
                var v52 = _pPC1MinimumPIPayment; v52.Clean = value; _pPC1MinimumPIPayment = v52;
                var v53 = _pPC1MinimumPIPaymentUI; v53.Clean = value; _pPC1MinimumPIPaymentUI = v53;
                var v54 = _pPC1Year; v54.Clean = value; _pPC1Year = v54;
                var v55 = _pPC2EstimatedEscrowAmount; v55.Clean = value; _pPC2EstimatedEscrowAmount = v55;
                var v56 = _pPC2EstimatedEscrowAmountUI; v56.Clean = value; _pPC2EstimatedEscrowAmountUI = v56;
                var v57 = _pPC2InterestOnly; v57.Clean = value; _pPC2InterestOnly = v57;
                var v58 = _pPC2MaximumMonthlyPayment; v58.Clean = value; _pPC2MaximumMonthlyPayment = v58;
                var v59 = _pPC2MaximumMonthlyPaymentUI; v59.Clean = value; _pPC2MaximumMonthlyPaymentUI = v59;
                var v60 = _pPC2MaximumPIPayment; v60.Clean = value; _pPC2MaximumPIPayment = v60;
                var v61 = _pPC2MaximumPIPaymentUI; v61.Clean = value; _pPC2MaximumPIPaymentUI = v61;
                var v62 = _pPC2MIAmount; v62.Clean = value; _pPC2MIAmount = v62;
                var v63 = _pPC2MIAmountUI; v63.Clean = value; _pPC2MIAmountUI = v63;
                var v64 = _pPC2MinimumMonthlyPayment; v64.Clean = value; _pPC2MinimumMonthlyPayment = v64;
                var v65 = _pPC2MinimumMonthlyPaymentUI; v65.Clean = value; _pPC2MinimumMonthlyPaymentUI = v65;
                var v66 = _pPC2MinimumPIPayment; v66.Clean = value; _pPC2MinimumPIPayment = v66;
                var v67 = _pPC2MinimumPIPaymentUI; v67.Clean = value; _pPC2MinimumPIPaymentUI = v67;
                var v68 = _pPC2YearFrom; v68.Clean = value; _pPC2YearFrom = v68;
                var v69 = _pPC2YearTo; v69.Clean = value; _pPC2YearTo = v69;
                var v70 = _pPC3EstimatedEscrowAmount; v70.Clean = value; _pPC3EstimatedEscrowAmount = v70;
                var v71 = _pPC3EstimatedEscrowAmountUI; v71.Clean = value; _pPC3EstimatedEscrowAmountUI = v71;
                var v72 = _pPC3InterestOnly; v72.Clean = value; _pPC3InterestOnly = v72;
                var v73 = _pPC3MaximumMonthlyPayment; v73.Clean = value; _pPC3MaximumMonthlyPayment = v73;
                var v74 = _pPC3MaximumMonthlyPaymentUI; v74.Clean = value; _pPC3MaximumMonthlyPaymentUI = v74;
                var v75 = _pPC3MaximumPIPayment; v75.Clean = value; _pPC3MaximumPIPayment = v75;
                var v76 = _pPC3MaximumPIPaymentUI; v76.Clean = value; _pPC3MaximumPIPaymentUI = v76;
                var v77 = _pPC3MIAmount; v77.Clean = value; _pPC3MIAmount = v77;
                var v78 = _pPC3MIAmountUI; v78.Clean = value; _pPC3MIAmountUI = v78;
                var v79 = _pPC3MinimumMonthlyPayment; v79.Clean = value; _pPC3MinimumMonthlyPayment = v79;
                var v80 = _pPC3MinimumMonthlyPaymentUI; v80.Clean = value; _pPC3MinimumMonthlyPaymentUI = v80;
                var v81 = _pPC3MinimumPIPayment; v81.Clean = value; _pPC3MinimumPIPayment = v81;
                var v82 = _pPC3MinimumPIPaymentUI; v82.Clean = value; _pPC3MinimumPIPaymentUI = v82;
                var v83 = _pPC3YearFrom; v83.Clean = value; _pPC3YearFrom = v83;
                var v84 = _pPC3YearTo; v84.Clean = value; _pPC3YearTo = v84;
                var v85 = _pPC4EstimatedEscrowAmount; v85.Clean = value; _pPC4EstimatedEscrowAmount = v85;
                var v86 = _pPC4EstimatedEscrowAmountUI; v86.Clean = value; _pPC4EstimatedEscrowAmountUI = v86;
                var v87 = _pPC4InterestOnly; v87.Clean = value; _pPC4InterestOnly = v87;
                var v88 = _pPC4MaximumMonthlyPayment; v88.Clean = value; _pPC4MaximumMonthlyPayment = v88;
                var v89 = _pPC4MaximumMonthlyPaymentUI; v89.Clean = value; _pPC4MaximumMonthlyPaymentUI = v89;
                var v90 = _pPC4MaximumPIPayment; v90.Clean = value; _pPC4MaximumPIPayment = v90;
                var v91 = _pPC4MaximumPIPaymentUI; v91.Clean = value; _pPC4MaximumPIPaymentUI = v91;
                var v92 = _pPC4MIAmount; v92.Clean = value; _pPC4MIAmount = v92;
                var v93 = _pPC4MIAmountUI; v93.Clean = value; _pPC4MIAmountUI = v93;
                var v94 = _pPC4MinimumMonthlyPayment; v94.Clean = value; _pPC4MinimumMonthlyPayment = v94;
                var v95 = _pPC4MinimumMonthlyPaymentUI; v95.Clean = value; _pPC4MinimumMonthlyPaymentUI = v95;
                var v96 = _pPC4MinimumPIPayment; v96.Clean = value; _pPC4MinimumPIPayment = v96;
                var v97 = _pPC4MinimumPIPaymentUI; v97.Clean = value; _pPC4MinimumPIPaymentUI = v97;
                var v98 = _pPC4YearFrom; v98.Clean = value; _pPC4YearFrom = v98;
                var v99 = _pPC4YearTo; v99.Clean = value; _pPC4YearTo = v99;
                var v100 = _pPEstimatedEscrowIndicator; v100.Clean = value; _pPEstimatedEscrowIndicator = v100;
                var v101 = _prepaymentPenaltyPayOffDuringYear; v101.Clean = value; _prepaymentPenaltyPayOffDuringYear = v101;
                var v102 = _prepaymentPenaltyPayOffInDateType; v102.Clean = value; _prepaymentPenaltyPayOffInDateType = v102;
                var v103 = _prepaymentPenaltyPayOffInFirstYear; v103.Clean = value; _prepaymentPenaltyPayOffInFirstYear = v103;
                var v104 = _rangePaymentIndicatorC1; v104.Clean = value; _rangePaymentIndicatorC1 = v104;
                var v105 = _rangePaymentIndicatorC2; v105.Clean = value; _rangePaymentIndicatorC2 = v105;
                var v106 = _rangePaymentIndicatorC3; v106.Clean = value; _rangePaymentIndicatorC3 = v106;
                var v107 = _rangePaymentIndicatorC4; v107.Clean = value; _rangePaymentIndicatorC4 = v107;
                var v108 = _rateLockExpirationTime; v108.Clean = value; _rateLockExpirationTime = v108;
                var v109 = _rateLockExpirationTimeZone; v109.Clean = value; _rateLockExpirationTimeZone = v109;
                var v110 = _reasonChangedCircumstanceFlags; v110.Clean = value; _reasonChangedCircumstanceFlags = v110;
                var v111 = _reasonDelayedSettlement; v111.Clean = value; _reasonDelayedSettlement = v111;
                var v112 = _reasonEligibility; v112.Clean = value; _reasonEligibility = v112;
                var v113 = _reasonExpiration; v113.Clean = value; _reasonExpiration = v113;
                var v114 = _reasonInterestRate; v114.Clean = value; _reasonInterestRate = v114;
                var v115 = _reasonOther; v115.Clean = value; _reasonOther = v115;
                var v116 = _reasonOtherDescription; v116.Clean = value; _reasonOtherDescription = v116;
                var v117 = _reasonRevisions; v117.Clean = value; _reasonRevisions = v117;
                var v118 = _reasonSettlementCharges; v118.Clean = value; _reasonSettlementCharges = v118;
                var v119 = _totalEstimatedCashClose; v119.Clean = value; _totalEstimatedCashClose = v119;
                var v120 = _yearsToRecast; v120.Clean = value; _yearsToRecast = v120;
                _settingClean = 0;
            }
        }
    }
}