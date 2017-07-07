using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LoanEstimate1 : IClean
    {
        private Value<string> _adjustsTermType;
        public string AdjustsTermType { get { return _adjustsTermType; } set { _adjustsTermType = value; } }
        private Value<string> _changedCircumstanceComments;
        public string ChangedCircumstanceComments { get { return _changedCircumstanceComments; } set { _changedCircumstanceComments = value; } }
        private Value<DateTime?> _closingCostEstimateExpirationDate;
        public DateTime? ClosingCostEstimateExpirationDate { get { return _closingCostEstimateExpirationDate; } set { _closingCostEstimateExpirationDate = value; } }
        private Value<string> _closingCostEstimateExpirationTime;
        public string ClosingCostEstimateExpirationTime { get { return _closingCostEstimateExpirationTime; } set { _closingCostEstimateExpirationTime = value; } }
        private Value<string> _closingCostEstimateExpirationTimeZone;
        public string ClosingCostEstimateExpirationTimeZone { get { return _closingCostEstimateExpirationTimeZone; } set { _closingCostEstimateExpirationTimeZone = value; } }
        private Value<string> _disclosureBy;
        public string DisclosureBy { get { return _disclosureBy; } set { _disclosureBy = value; } }
        private Value<DateTime?> _disclosureClosingCostExpDate;
        public DateTime? DisclosureClosingCostExpDate { get { return _disclosureClosingCostExpDate; } set { _disclosureClosingCostExpDate = value; } }
        private Value<string> _disclosureClosingCostExpTime;
        public string DisclosureClosingCostExpTime { get { return _disclosureClosingCostExpTime; } set { _disclosureClosingCostExpTime = value; } }
        private Value<string> _disclosureClosingCostExpTimeZone;
        public string DisclosureClosingCostExpTimeZone { get { return _disclosureClosingCostExpTimeZone; } set { _disclosureClosingCostExpTimeZone = value; } }
        private Value<string> _disclosureComments;
        public string DisclosureComments { get { return _disclosureComments; } set { _disclosureComments = value; } }
        private Value<DateTime?> _disclosureLastSentDate;
        public DateTime? DisclosureLastSentDate { get { return _disclosureLastSentDate; } set { _disclosureLastSentDate = value; } }
        private Value<DateTime?> _disclosureReceivedDate;
        public DateTime? DisclosureReceivedDate { get { return _disclosureReceivedDate; } set { _disclosureReceivedDate = value; } }
        private Value<string> _disclosureSentMethod;
        public string DisclosureSentMethod { get { return _disclosureSentMethod; } set { _disclosureSentMethod = value; } }
        private Value<decimal?> _estimatedTaxesInsuranceAssessments;
        public decimal? EstimatedTaxesInsuranceAssessments { get { return _estimatedTaxesInsuranceAssessments; } set { _estimatedTaxesInsuranceAssessments = value; } }
        private Value<string> _estimatedTaxesInsuranceAssessmentsUI;
        public string EstimatedTaxesInsuranceAssessmentsUI { get { return _estimatedTaxesInsuranceAssessmentsUI; } set { _estimatedTaxesInsuranceAssessmentsUI = value; } }
        private Value<decimal?> _highestMonthlyPI;
        public decimal? HighestMonthlyPI { get { return _highestMonthlyPI; } set { _highestMonthlyPI = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _inEscrowHomeownerInsurance;
        public string InEscrowHomeownerInsurance { get { return _inEscrowHomeownerInsurance; } set { _inEscrowHomeownerInsurance = value; } }
        private Value<string> _inEscrowOther;
        public string InEscrowOther { get { return _inEscrowOther; } set { _inEscrowOther = value; } }
        private Value<string> _inEscrowPropertyTaxes;
        public string InEscrowPropertyTaxes { get { return _inEscrowPropertyTaxes; } set { _inEscrowPropertyTaxes = value; } }
        private Value<string> _interestRateAdjustsEveryYears;
        public string InterestRateAdjustsEveryYears { get { return _interestRateAdjustsEveryYears; } set { _interestRateAdjustsEveryYears = value; } }
        private Value<int?> _interestRateAdjustsInYear;
        public int? InterestRateAdjustsInYear { get { return _interestRateAdjustsInYear; } set { _interestRateAdjustsInYear = value; } }
        private Value<string> _interestRateAdjustsStartingInType;
        public string InterestRateAdjustsStartingInType { get { return _interestRateAdjustsStartingInType; } set { _interestRateAdjustsStartingInType = value; } }
        private Value<int?> _interestRateAfterAdjustment;
        public int? InterestRateAfterAdjustment { get { return _interestRateAfterAdjustment; } set { _interestRateAfterAdjustment = value; } }
        private Value<string> _interestRateCanGoGoes;
        public string InterestRateCanGoGoes { get { return _interestRateCanGoGoes; } set { _interestRateCanGoGoes = value; } }
        private Value<DateTime?> _lEDateIssued;
        public DateTime? LEDateIssued { get { return _lEDateIssued; } set { _lEDateIssued = value; } }
        private Value<string> _loanAmountCanGoGoes;
        public string LoanAmountCanGoGoes { get { return _loanAmountCanGoGoes; } set { _loanAmountCanGoGoes = value; } }
        private Value<string> _loanAmountCanIncreaseOrIncreases;
        public string LoanAmountCanIncreaseOrIncreases { get { return _loanAmountCanIncreaseOrIncreases; } set { _loanAmountCanIncreaseOrIncreases = value; } }
        private Value<string> _loanProduct;
        public string LoanProduct { get { return _loanProduct; } set { _loanProduct = value; } }
        private Value<string> _loanPurpose;
        public string LoanPurpose { get { return _loanPurpose; } set { _loanPurpose = value; } }
        private Value<int?> _loanTermMonths;
        public int? LoanTermMonths { get { return _loanTermMonths; } set { _loanTermMonths = value; } }
        private Value<int?> _loanTermYears;
        public int? LoanTermYears { get { return _loanTermYears; } set { _loanTermYears = value; } }
        private Value<string> _monthlyPIAdjustedInDateType;
        public string MonthlyPIAdjustedInDateType { get { return _monthlyPIAdjustedInDateType; } set { _monthlyPIAdjustedInDateType = value; } }
        private Value<string> _monthlyPIAdjustsEveryYears;
        public string MonthlyPIAdjustsEveryYears { get { return _monthlyPIAdjustsEveryYears; } set { _monthlyPIAdjustsEveryYears = value; } }
        private Value<int?> _monthlyPIAdjustsInYear;
        public int? MonthlyPIAdjustsInYear { get { return _monthlyPIAdjustsInYear; } set { _monthlyPIAdjustsInYear = value; } }
        private Value<string> _monthlyPIAdjustsStartingInType;
        public string MonthlyPIAdjustsStartingInType { get { return _monthlyPIAdjustsStartingInType; } set { _monthlyPIAdjustsStartingInType = value; } }
        private Value<string> _monthlyPIAdjustsTermType;
        public string MonthlyPIAdjustsTermType { get { return _monthlyPIAdjustsTermType; } set { _monthlyPIAdjustsTermType = value; } }
        private Value<int?> _monthlyPIAfterAdjustment;
        public int? MonthlyPIAfterAdjustment { get { return _monthlyPIAfterAdjustment; } set { _monthlyPIAfterAdjustment = value; } }
        private Value<string> _monthlyPICanGoGoes;
        public string MonthlyPICanGoGoes { get { return _monthlyPICanGoGoes; } set { _monthlyPICanGoGoes = value; } }
        private Value<string> _monthlyPIInterestOnlyDateType;
        public string MonthlyPIInterestOnlyDateType { get { return _monthlyPIInterestOnlyDateType; } set { _monthlyPIInterestOnlyDateType = value; } }
        private Value<int?> _monthlyPIInterestOnlyUntilYear;
        public int? MonthlyPIInterestOnlyUntilYear { get { return _monthlyPIInterestOnlyUntilYear; } set { _monthlyPIInterestOnlyUntilYear = value; } }
        private Value<int?> _pPC1EstimatedEscrowAmount;
        public int? PPC1EstimatedEscrowAmount { get { return _pPC1EstimatedEscrowAmount; } set { _pPC1EstimatedEscrowAmount = value; } }
        private Value<string> _pPC1EstimatedEscrowAmountUI;
        public string PPC1EstimatedEscrowAmountUI { get { return _pPC1EstimatedEscrowAmountUI; } set { _pPC1EstimatedEscrowAmountUI = value; } }
        private Value<bool?> _pPC1InterestOnly;
        public bool? PPC1InterestOnly { get { return _pPC1InterestOnly; } set { _pPC1InterestOnly = value; } }
        private Value<decimal?> _pPC1MaximumMonthlyPayment;
        public decimal? PPC1MaximumMonthlyPayment { get { return _pPC1MaximumMonthlyPayment; } set { _pPC1MaximumMonthlyPayment = value; } }
        private Value<string> _pPC1MaximumMonthlyPaymentUI;
        public string PPC1MaximumMonthlyPaymentUI { get { return _pPC1MaximumMonthlyPaymentUI; } set { _pPC1MaximumMonthlyPaymentUI = value; } }
        private Value<decimal?> _pPC1MaximumPIPayment;
        public decimal? PPC1MaximumPIPayment { get { return _pPC1MaximumPIPayment; } set { _pPC1MaximumPIPayment = value; } }
        private Value<string> _pPC1MaximumPIPaymentUI;
        public string PPC1MaximumPIPaymentUI { get { return _pPC1MaximumPIPaymentUI; } set { _pPC1MaximumPIPaymentUI = value; } }
        private Value<int?> _pPC1MIAmount;
        public int? PPC1MIAmount { get { return _pPC1MIAmount; } set { _pPC1MIAmount = value; } }
        private Value<string> _pPC1MIAmountUI;
        public string PPC1MIAmountUI { get { return _pPC1MIAmountUI; } set { _pPC1MIAmountUI = value; } }
        private Value<int?> _pPC1MinimumMonthlyPayment;
        public int? PPC1MinimumMonthlyPayment { get { return _pPC1MinimumMonthlyPayment; } set { _pPC1MinimumMonthlyPayment = value; } }
        private Value<string> _pPC1MinimumMonthlyPaymentUI;
        public string PPC1MinimumMonthlyPaymentUI { get { return _pPC1MinimumMonthlyPaymentUI; } set { _pPC1MinimumMonthlyPaymentUI = value; } }
        private Value<decimal?> _pPC1MinimumPIPayment;
        public decimal? PPC1MinimumPIPayment { get { return _pPC1MinimumPIPayment; } set { _pPC1MinimumPIPayment = value; } }
        private Value<string> _pPC1MinimumPIPaymentUI;
        public string PPC1MinimumPIPaymentUI { get { return _pPC1MinimumPIPaymentUI; } set { _pPC1MinimumPIPaymentUI = value; } }
        private Value<int?> _pPC1Year;
        public int? PPC1Year { get { return _pPC1Year; } set { _pPC1Year = value; } }
        private Value<int?> _pPC2EstimatedEscrowAmount;
        public int? PPC2EstimatedEscrowAmount { get { return _pPC2EstimatedEscrowAmount; } set { _pPC2EstimatedEscrowAmount = value; } }
        private Value<string> _pPC2EstimatedEscrowAmountUI;
        public string PPC2EstimatedEscrowAmountUI { get { return _pPC2EstimatedEscrowAmountUI; } set { _pPC2EstimatedEscrowAmountUI = value; } }
        private Value<bool?> _pPC2InterestOnly;
        public bool? PPC2InterestOnly { get { return _pPC2InterestOnly; } set { _pPC2InterestOnly = value; } }
        private Value<decimal?> _pPC2MaximumMonthlyPayment;
        public decimal? PPC2MaximumMonthlyPayment { get { return _pPC2MaximumMonthlyPayment; } set { _pPC2MaximumMonthlyPayment = value; } }
        private Value<string> _pPC2MaximumMonthlyPaymentUI;
        public string PPC2MaximumMonthlyPaymentUI { get { return _pPC2MaximumMonthlyPaymentUI; } set { _pPC2MaximumMonthlyPaymentUI = value; } }
        private Value<decimal?> _pPC2MaximumPIPayment;
        public decimal? PPC2MaximumPIPayment { get { return _pPC2MaximumPIPayment; } set { _pPC2MaximumPIPayment = value; } }
        private Value<string> _pPC2MaximumPIPaymentUI;
        public string PPC2MaximumPIPaymentUI { get { return _pPC2MaximumPIPaymentUI; } set { _pPC2MaximumPIPaymentUI = value; } }
        private Value<int?> _pPC2MIAmount;
        public int? PPC2MIAmount { get { return _pPC2MIAmount; } set { _pPC2MIAmount = value; } }
        private Value<string> _pPC2MIAmountUI;
        public string PPC2MIAmountUI { get { return _pPC2MIAmountUI; } set { _pPC2MIAmountUI = value; } }
        private Value<int?> _pPC2MinimumMonthlyPayment;
        public int? PPC2MinimumMonthlyPayment { get { return _pPC2MinimumMonthlyPayment; } set { _pPC2MinimumMonthlyPayment = value; } }
        private Value<string> _pPC2MinimumMonthlyPaymentUI;
        public string PPC2MinimumMonthlyPaymentUI { get { return _pPC2MinimumMonthlyPaymentUI; } set { _pPC2MinimumMonthlyPaymentUI = value; } }
        private Value<decimal?> _pPC2MinimumPIPayment;
        public decimal? PPC2MinimumPIPayment { get { return _pPC2MinimumPIPayment; } set { _pPC2MinimumPIPayment = value; } }
        private Value<string> _pPC2MinimumPIPaymentUI;
        public string PPC2MinimumPIPaymentUI { get { return _pPC2MinimumPIPaymentUI; } set { _pPC2MinimumPIPaymentUI = value; } }
        private Value<int?> _pPC2YearFrom;
        public int? PPC2YearFrom { get { return _pPC2YearFrom; } set { _pPC2YearFrom = value; } }
        private Value<int?> _pPC2YearTo;
        public int? PPC2YearTo { get { return _pPC2YearTo; } set { _pPC2YearTo = value; } }
        private Value<int?> _pPC3EstimatedEscrowAmount;
        public int? PPC3EstimatedEscrowAmount { get { return _pPC3EstimatedEscrowAmount; } set { _pPC3EstimatedEscrowAmount = value; } }
        private Value<string> _pPC3EstimatedEscrowAmountUI;
        public string PPC3EstimatedEscrowAmountUI { get { return _pPC3EstimatedEscrowAmountUI; } set { _pPC3EstimatedEscrowAmountUI = value; } }
        private Value<bool?> _pPC3InterestOnly;
        public bool? PPC3InterestOnly { get { return _pPC3InterestOnly; } set { _pPC3InterestOnly = value; } }
        private Value<decimal?> _pPC3MaximumMonthlyPayment;
        public decimal? PPC3MaximumMonthlyPayment { get { return _pPC3MaximumMonthlyPayment; } set { _pPC3MaximumMonthlyPayment = value; } }
        private Value<string> _pPC3MaximumMonthlyPaymentUI;
        public string PPC3MaximumMonthlyPaymentUI { get { return _pPC3MaximumMonthlyPaymentUI; } set { _pPC3MaximumMonthlyPaymentUI = value; } }
        private Value<decimal?> _pPC3MaximumPIPayment;
        public decimal? PPC3MaximumPIPayment { get { return _pPC3MaximumPIPayment; } set { _pPC3MaximumPIPayment = value; } }
        private Value<string> _pPC3MaximumPIPaymentUI;
        public string PPC3MaximumPIPaymentUI { get { return _pPC3MaximumPIPaymentUI; } set { _pPC3MaximumPIPaymentUI = value; } }
        private Value<int?> _pPC3MIAmount;
        public int? PPC3MIAmount { get { return _pPC3MIAmount; } set { _pPC3MIAmount = value; } }
        private Value<string> _pPC3MIAmountUI;
        public string PPC3MIAmountUI { get { return _pPC3MIAmountUI; } set { _pPC3MIAmountUI = value; } }
        private Value<int?> _pPC3MinimumMonthlyPayment;
        public int? PPC3MinimumMonthlyPayment { get { return _pPC3MinimumMonthlyPayment; } set { _pPC3MinimumMonthlyPayment = value; } }
        private Value<string> _pPC3MinimumMonthlyPaymentUI;
        public string PPC3MinimumMonthlyPaymentUI { get { return _pPC3MinimumMonthlyPaymentUI; } set { _pPC3MinimumMonthlyPaymentUI = value; } }
        private Value<decimal?> _pPC3MinimumPIPayment;
        public decimal? PPC3MinimumPIPayment { get { return _pPC3MinimumPIPayment; } set { _pPC3MinimumPIPayment = value; } }
        private Value<string> _pPC3MinimumPIPaymentUI;
        public string PPC3MinimumPIPaymentUI { get { return _pPC3MinimumPIPaymentUI; } set { _pPC3MinimumPIPaymentUI = value; } }
        private Value<int?> _pPC3YearFrom;
        public int? PPC3YearFrom { get { return _pPC3YearFrom; } set { _pPC3YearFrom = value; } }
        private Value<int?> _pPC3YearTo;
        public int? PPC3YearTo { get { return _pPC3YearTo; } set { _pPC3YearTo = value; } }
        private Value<int?> _pPC4EstimatedEscrowAmount;
        public int? PPC4EstimatedEscrowAmount { get { return _pPC4EstimatedEscrowAmount; } set { _pPC4EstimatedEscrowAmount = value; } }
        private Value<string> _pPC4EstimatedEscrowAmountUI;
        public string PPC4EstimatedEscrowAmountUI { get { return _pPC4EstimatedEscrowAmountUI; } set { _pPC4EstimatedEscrowAmountUI = value; } }
        private Value<bool?> _pPC4InterestOnly;
        public bool? PPC4InterestOnly { get { return _pPC4InterestOnly; } set { _pPC4InterestOnly = value; } }
        private Value<decimal?> _pPC4MaximumMonthlyPayment;
        public decimal? PPC4MaximumMonthlyPayment { get { return _pPC4MaximumMonthlyPayment; } set { _pPC4MaximumMonthlyPayment = value; } }
        private Value<string> _pPC4MaximumMonthlyPaymentUI;
        public string PPC4MaximumMonthlyPaymentUI { get { return _pPC4MaximumMonthlyPaymentUI; } set { _pPC4MaximumMonthlyPaymentUI = value; } }
        private Value<decimal?> _pPC4MaximumPIPayment;
        public decimal? PPC4MaximumPIPayment { get { return _pPC4MaximumPIPayment; } set { _pPC4MaximumPIPayment = value; } }
        private Value<string> _pPC4MaximumPIPaymentUI;
        public string PPC4MaximumPIPaymentUI { get { return _pPC4MaximumPIPaymentUI; } set { _pPC4MaximumPIPaymentUI = value; } }
        private Value<int?> _pPC4MIAmount;
        public int? PPC4MIAmount { get { return _pPC4MIAmount; } set { _pPC4MIAmount = value; } }
        private Value<string> _pPC4MIAmountUI;
        public string PPC4MIAmountUI { get { return _pPC4MIAmountUI; } set { _pPC4MIAmountUI = value; } }
        private Value<int?> _pPC4MinimumMonthlyPayment;
        public int? PPC4MinimumMonthlyPayment { get { return _pPC4MinimumMonthlyPayment; } set { _pPC4MinimumMonthlyPayment = value; } }
        private Value<string> _pPC4MinimumMonthlyPaymentUI;
        public string PPC4MinimumMonthlyPaymentUI { get { return _pPC4MinimumMonthlyPaymentUI; } set { _pPC4MinimumMonthlyPaymentUI = value; } }
        private Value<decimal?> _pPC4MinimumPIPayment;
        public decimal? PPC4MinimumPIPayment { get { return _pPC4MinimumPIPayment; } set { _pPC4MinimumPIPayment = value; } }
        private Value<string> _pPC4MinimumPIPaymentUI;
        public string PPC4MinimumPIPaymentUI { get { return _pPC4MinimumPIPaymentUI; } set { _pPC4MinimumPIPaymentUI = value; } }
        private Value<int?> _pPC4YearFrom;
        public int? PPC4YearFrom { get { return _pPC4YearFrom; } set { _pPC4YearFrom = value; } }
        private Value<int?> _pPC4YearTo;
        public int? PPC4YearTo { get { return _pPC4YearTo; } set { _pPC4YearTo = value; } }
        private Value<bool?> _pPEstimatedEscrowIndicator;
        public bool? PPEstimatedEscrowIndicator { get { return _pPEstimatedEscrowIndicator; } set { _pPEstimatedEscrowIndicator = value; } }
        private Value<int?> _prepaymentPenaltyPayOffDuringYear;
        public int? PrepaymentPenaltyPayOffDuringYear { get { return _prepaymentPenaltyPayOffDuringYear; } set { _prepaymentPenaltyPayOffDuringYear = value; } }
        private Value<string> _prepaymentPenaltyPayOffInDateType;
        public string PrepaymentPenaltyPayOffInDateType { get { return _prepaymentPenaltyPayOffInDateType; } set { _prepaymentPenaltyPayOffInDateType = value; } }
        private Value<string> _prepaymentPenaltyPayOffInFirstYear;
        public string PrepaymentPenaltyPayOffInFirstYear { get { return _prepaymentPenaltyPayOffInFirstYear; } set { _prepaymentPenaltyPayOffInFirstYear = value; } }
        private Value<bool?> _rangePaymentIndicatorC1;
        public bool? RangePaymentIndicatorC1 { get { return _rangePaymentIndicatorC1; } set { _rangePaymentIndicatorC1 = value; } }
        private Value<bool?> _rangePaymentIndicatorC2;
        public bool? RangePaymentIndicatorC2 { get { return _rangePaymentIndicatorC2; } set { _rangePaymentIndicatorC2 = value; } }
        private Value<bool?> _rangePaymentIndicatorC3;
        public bool? RangePaymentIndicatorC3 { get { return _rangePaymentIndicatorC3; } set { _rangePaymentIndicatorC3 = value; } }
        private Value<bool?> _rangePaymentIndicatorC4;
        public bool? RangePaymentIndicatorC4 { get { return _rangePaymentIndicatorC4; } set { _rangePaymentIndicatorC4 = value; } }
        private Value<string> _rateLockExpirationTime;
        public string RateLockExpirationTime { get { return _rateLockExpirationTime; } set { _rateLockExpirationTime = value; } }
        private Value<string> _rateLockExpirationTimeZone;
        public string RateLockExpirationTimeZone { get { return _rateLockExpirationTimeZone; } set { _rateLockExpirationTimeZone = value; } }
        private Value<string> _reasonChangedCircumstanceFlags;
        public string ReasonChangedCircumstanceFlags { get { return _reasonChangedCircumstanceFlags; } set { _reasonChangedCircumstanceFlags = value; } }
        private Value<bool?> _reasonDelayedSettlement;
        public bool? ReasonDelayedSettlement { get { return _reasonDelayedSettlement; } set { _reasonDelayedSettlement = value; } }
        private Value<bool?> _reasonEligibility;
        public bool? ReasonEligibility { get { return _reasonEligibility; } set { _reasonEligibility = value; } }
        private Value<bool?> _reasonExpiration;
        public bool? ReasonExpiration { get { return _reasonExpiration; } set { _reasonExpiration = value; } }
        private Value<bool?> _reasonInterestRate;
        public bool? ReasonInterestRate { get { return _reasonInterestRate; } set { _reasonInterestRate = value; } }
        private Value<bool?> _reasonOther;
        public bool? ReasonOther { get { return _reasonOther; } set { _reasonOther = value; } }
        private Value<string> _reasonOtherDescription;
        public string ReasonOtherDescription { get { return _reasonOtherDescription; } set { _reasonOtherDescription = value; } }
        private Value<bool?> _reasonRevisions;
        public bool? ReasonRevisions { get { return _reasonRevisions; } set { _reasonRevisions = value; } }
        private Value<bool?> _reasonSettlementCharges;
        public bool? ReasonSettlementCharges { get { return _reasonSettlementCharges; } set { _reasonSettlementCharges = value; } }
        private Value<decimal?> _totalEstimatedCashClose;
        public decimal? TotalEstimatedCashClose { get { return _totalEstimatedCashClose; } set { _totalEstimatedCashClose = value; } }
        private Value<int?> _yearsToRecast;
        public int? YearsToRecast { get { return _yearsToRecast; } set { _yearsToRecast = value; } }
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
                var adjustsTermType = _adjustsTermType; adjustsTermType.Clean = value; _adjustsTermType = adjustsTermType;
                var changedCircumstanceComments = _changedCircumstanceComments; changedCircumstanceComments.Clean = value; _changedCircumstanceComments = changedCircumstanceComments;
                var closingCostEstimateExpirationDate = _closingCostEstimateExpirationDate; closingCostEstimateExpirationDate.Clean = value; _closingCostEstimateExpirationDate = closingCostEstimateExpirationDate;
                var closingCostEstimateExpirationTime = _closingCostEstimateExpirationTime; closingCostEstimateExpirationTime.Clean = value; _closingCostEstimateExpirationTime = closingCostEstimateExpirationTime;
                var closingCostEstimateExpirationTimeZone = _closingCostEstimateExpirationTimeZone; closingCostEstimateExpirationTimeZone.Clean = value; _closingCostEstimateExpirationTimeZone = closingCostEstimateExpirationTimeZone;
                var disclosureBy = _disclosureBy; disclosureBy.Clean = value; _disclosureBy = disclosureBy;
                var disclosureClosingCostExpDate = _disclosureClosingCostExpDate; disclosureClosingCostExpDate.Clean = value; _disclosureClosingCostExpDate = disclosureClosingCostExpDate;
                var disclosureClosingCostExpTime = _disclosureClosingCostExpTime; disclosureClosingCostExpTime.Clean = value; _disclosureClosingCostExpTime = disclosureClosingCostExpTime;
                var disclosureClosingCostExpTimeZone = _disclosureClosingCostExpTimeZone; disclosureClosingCostExpTimeZone.Clean = value; _disclosureClosingCostExpTimeZone = disclosureClosingCostExpTimeZone;
                var disclosureComments = _disclosureComments; disclosureComments.Clean = value; _disclosureComments = disclosureComments;
                var disclosureLastSentDate = _disclosureLastSentDate; disclosureLastSentDate.Clean = value; _disclosureLastSentDate = disclosureLastSentDate;
                var disclosureReceivedDate = _disclosureReceivedDate; disclosureReceivedDate.Clean = value; _disclosureReceivedDate = disclosureReceivedDate;
                var disclosureSentMethod = _disclosureSentMethod; disclosureSentMethod.Clean = value; _disclosureSentMethod = disclosureSentMethod;
                var estimatedTaxesInsuranceAssessments = _estimatedTaxesInsuranceAssessments; estimatedTaxesInsuranceAssessments.Clean = value; _estimatedTaxesInsuranceAssessments = estimatedTaxesInsuranceAssessments;
                var estimatedTaxesInsuranceAssessmentsUI = _estimatedTaxesInsuranceAssessmentsUI; estimatedTaxesInsuranceAssessmentsUI.Clean = value; _estimatedTaxesInsuranceAssessmentsUI = estimatedTaxesInsuranceAssessmentsUI;
                var highestMonthlyPI = _highestMonthlyPI; highestMonthlyPI.Clean = value; _highestMonthlyPI = highestMonthlyPI;
                var id = _id; id.Clean = value; _id = id;
                var inEscrowHomeownerInsurance = _inEscrowHomeownerInsurance; inEscrowHomeownerInsurance.Clean = value; _inEscrowHomeownerInsurance = inEscrowHomeownerInsurance;
                var inEscrowOther = _inEscrowOther; inEscrowOther.Clean = value; _inEscrowOther = inEscrowOther;
                var inEscrowPropertyTaxes = _inEscrowPropertyTaxes; inEscrowPropertyTaxes.Clean = value; _inEscrowPropertyTaxes = inEscrowPropertyTaxes;
                var interestRateAdjustsEveryYears = _interestRateAdjustsEveryYears; interestRateAdjustsEveryYears.Clean = value; _interestRateAdjustsEveryYears = interestRateAdjustsEveryYears;
                var interestRateAdjustsInYear = _interestRateAdjustsInYear; interestRateAdjustsInYear.Clean = value; _interestRateAdjustsInYear = interestRateAdjustsInYear;
                var interestRateAdjustsStartingInType = _interestRateAdjustsStartingInType; interestRateAdjustsStartingInType.Clean = value; _interestRateAdjustsStartingInType = interestRateAdjustsStartingInType;
                var interestRateAfterAdjustment = _interestRateAfterAdjustment; interestRateAfterAdjustment.Clean = value; _interestRateAfterAdjustment = interestRateAfterAdjustment;
                var interestRateCanGoGoes = _interestRateCanGoGoes; interestRateCanGoGoes.Clean = value; _interestRateCanGoGoes = interestRateCanGoGoes;
                var lEDateIssued = _lEDateIssued; lEDateIssued.Clean = value; _lEDateIssued = lEDateIssued;
                var loanAmountCanGoGoes = _loanAmountCanGoGoes; loanAmountCanGoGoes.Clean = value; _loanAmountCanGoGoes = loanAmountCanGoGoes;
                var loanAmountCanIncreaseOrIncreases = _loanAmountCanIncreaseOrIncreases; loanAmountCanIncreaseOrIncreases.Clean = value; _loanAmountCanIncreaseOrIncreases = loanAmountCanIncreaseOrIncreases;
                var loanProduct = _loanProduct; loanProduct.Clean = value; _loanProduct = loanProduct;
                var loanPurpose = _loanPurpose; loanPurpose.Clean = value; _loanPurpose = loanPurpose;
                var loanTermMonths = _loanTermMonths; loanTermMonths.Clean = value; _loanTermMonths = loanTermMonths;
                var loanTermYears = _loanTermYears; loanTermYears.Clean = value; _loanTermYears = loanTermYears;
                var monthlyPIAdjustedInDateType = _monthlyPIAdjustedInDateType; monthlyPIAdjustedInDateType.Clean = value; _monthlyPIAdjustedInDateType = monthlyPIAdjustedInDateType;
                var monthlyPIAdjustsEveryYears = _monthlyPIAdjustsEveryYears; monthlyPIAdjustsEveryYears.Clean = value; _monthlyPIAdjustsEveryYears = monthlyPIAdjustsEveryYears;
                var monthlyPIAdjustsInYear = _monthlyPIAdjustsInYear; monthlyPIAdjustsInYear.Clean = value; _monthlyPIAdjustsInYear = monthlyPIAdjustsInYear;
                var monthlyPIAdjustsStartingInType = _monthlyPIAdjustsStartingInType; monthlyPIAdjustsStartingInType.Clean = value; _monthlyPIAdjustsStartingInType = monthlyPIAdjustsStartingInType;
                var monthlyPIAdjustsTermType = _monthlyPIAdjustsTermType; monthlyPIAdjustsTermType.Clean = value; _monthlyPIAdjustsTermType = monthlyPIAdjustsTermType;
                var monthlyPIAfterAdjustment = _monthlyPIAfterAdjustment; monthlyPIAfterAdjustment.Clean = value; _monthlyPIAfterAdjustment = monthlyPIAfterAdjustment;
                var monthlyPICanGoGoes = _monthlyPICanGoGoes; monthlyPICanGoGoes.Clean = value; _monthlyPICanGoGoes = monthlyPICanGoGoes;
                var monthlyPIInterestOnlyDateType = _monthlyPIInterestOnlyDateType; monthlyPIInterestOnlyDateType.Clean = value; _monthlyPIInterestOnlyDateType = monthlyPIInterestOnlyDateType;
                var monthlyPIInterestOnlyUntilYear = _monthlyPIInterestOnlyUntilYear; monthlyPIInterestOnlyUntilYear.Clean = value; _monthlyPIInterestOnlyUntilYear = monthlyPIInterestOnlyUntilYear;
                var pPC1EstimatedEscrowAmount = _pPC1EstimatedEscrowAmount; pPC1EstimatedEscrowAmount.Clean = value; _pPC1EstimatedEscrowAmount = pPC1EstimatedEscrowAmount;
                var pPC1EstimatedEscrowAmountUI = _pPC1EstimatedEscrowAmountUI; pPC1EstimatedEscrowAmountUI.Clean = value; _pPC1EstimatedEscrowAmountUI = pPC1EstimatedEscrowAmountUI;
                var pPC1InterestOnly = _pPC1InterestOnly; pPC1InterestOnly.Clean = value; _pPC1InterestOnly = pPC1InterestOnly;
                var pPC1MaximumMonthlyPayment = _pPC1MaximumMonthlyPayment; pPC1MaximumMonthlyPayment.Clean = value; _pPC1MaximumMonthlyPayment = pPC1MaximumMonthlyPayment;
                var pPC1MaximumMonthlyPaymentUI = _pPC1MaximumMonthlyPaymentUI; pPC1MaximumMonthlyPaymentUI.Clean = value; _pPC1MaximumMonthlyPaymentUI = pPC1MaximumMonthlyPaymentUI;
                var pPC1MaximumPIPayment = _pPC1MaximumPIPayment; pPC1MaximumPIPayment.Clean = value; _pPC1MaximumPIPayment = pPC1MaximumPIPayment;
                var pPC1MaximumPIPaymentUI = _pPC1MaximumPIPaymentUI; pPC1MaximumPIPaymentUI.Clean = value; _pPC1MaximumPIPaymentUI = pPC1MaximumPIPaymentUI;
                var pPC1MIAmount = _pPC1MIAmount; pPC1MIAmount.Clean = value; _pPC1MIAmount = pPC1MIAmount;
                var pPC1MIAmountUI = _pPC1MIAmountUI; pPC1MIAmountUI.Clean = value; _pPC1MIAmountUI = pPC1MIAmountUI;
                var pPC1MinimumMonthlyPayment = _pPC1MinimumMonthlyPayment; pPC1MinimumMonthlyPayment.Clean = value; _pPC1MinimumMonthlyPayment = pPC1MinimumMonthlyPayment;
                var pPC1MinimumMonthlyPaymentUI = _pPC1MinimumMonthlyPaymentUI; pPC1MinimumMonthlyPaymentUI.Clean = value; _pPC1MinimumMonthlyPaymentUI = pPC1MinimumMonthlyPaymentUI;
                var pPC1MinimumPIPayment = _pPC1MinimumPIPayment; pPC1MinimumPIPayment.Clean = value; _pPC1MinimumPIPayment = pPC1MinimumPIPayment;
                var pPC1MinimumPIPaymentUI = _pPC1MinimumPIPaymentUI; pPC1MinimumPIPaymentUI.Clean = value; _pPC1MinimumPIPaymentUI = pPC1MinimumPIPaymentUI;
                var pPC1Year = _pPC1Year; pPC1Year.Clean = value; _pPC1Year = pPC1Year;
                var pPC2EstimatedEscrowAmount = _pPC2EstimatedEscrowAmount; pPC2EstimatedEscrowAmount.Clean = value; _pPC2EstimatedEscrowAmount = pPC2EstimatedEscrowAmount;
                var pPC2EstimatedEscrowAmountUI = _pPC2EstimatedEscrowAmountUI; pPC2EstimatedEscrowAmountUI.Clean = value; _pPC2EstimatedEscrowAmountUI = pPC2EstimatedEscrowAmountUI;
                var pPC2InterestOnly = _pPC2InterestOnly; pPC2InterestOnly.Clean = value; _pPC2InterestOnly = pPC2InterestOnly;
                var pPC2MaximumMonthlyPayment = _pPC2MaximumMonthlyPayment; pPC2MaximumMonthlyPayment.Clean = value; _pPC2MaximumMonthlyPayment = pPC2MaximumMonthlyPayment;
                var pPC2MaximumMonthlyPaymentUI = _pPC2MaximumMonthlyPaymentUI; pPC2MaximumMonthlyPaymentUI.Clean = value; _pPC2MaximumMonthlyPaymentUI = pPC2MaximumMonthlyPaymentUI;
                var pPC2MaximumPIPayment = _pPC2MaximumPIPayment; pPC2MaximumPIPayment.Clean = value; _pPC2MaximumPIPayment = pPC2MaximumPIPayment;
                var pPC2MaximumPIPaymentUI = _pPC2MaximumPIPaymentUI; pPC2MaximumPIPaymentUI.Clean = value; _pPC2MaximumPIPaymentUI = pPC2MaximumPIPaymentUI;
                var pPC2MIAmount = _pPC2MIAmount; pPC2MIAmount.Clean = value; _pPC2MIAmount = pPC2MIAmount;
                var pPC2MIAmountUI = _pPC2MIAmountUI; pPC2MIAmountUI.Clean = value; _pPC2MIAmountUI = pPC2MIAmountUI;
                var pPC2MinimumMonthlyPayment = _pPC2MinimumMonthlyPayment; pPC2MinimumMonthlyPayment.Clean = value; _pPC2MinimumMonthlyPayment = pPC2MinimumMonthlyPayment;
                var pPC2MinimumMonthlyPaymentUI = _pPC2MinimumMonthlyPaymentUI; pPC2MinimumMonthlyPaymentUI.Clean = value; _pPC2MinimumMonthlyPaymentUI = pPC2MinimumMonthlyPaymentUI;
                var pPC2MinimumPIPayment = _pPC2MinimumPIPayment; pPC2MinimumPIPayment.Clean = value; _pPC2MinimumPIPayment = pPC2MinimumPIPayment;
                var pPC2MinimumPIPaymentUI = _pPC2MinimumPIPaymentUI; pPC2MinimumPIPaymentUI.Clean = value; _pPC2MinimumPIPaymentUI = pPC2MinimumPIPaymentUI;
                var pPC2YearFrom = _pPC2YearFrom; pPC2YearFrom.Clean = value; _pPC2YearFrom = pPC2YearFrom;
                var pPC2YearTo = _pPC2YearTo; pPC2YearTo.Clean = value; _pPC2YearTo = pPC2YearTo;
                var pPC3EstimatedEscrowAmount = _pPC3EstimatedEscrowAmount; pPC3EstimatedEscrowAmount.Clean = value; _pPC3EstimatedEscrowAmount = pPC3EstimatedEscrowAmount;
                var pPC3EstimatedEscrowAmountUI = _pPC3EstimatedEscrowAmountUI; pPC3EstimatedEscrowAmountUI.Clean = value; _pPC3EstimatedEscrowAmountUI = pPC3EstimatedEscrowAmountUI;
                var pPC3InterestOnly = _pPC3InterestOnly; pPC3InterestOnly.Clean = value; _pPC3InterestOnly = pPC3InterestOnly;
                var pPC3MaximumMonthlyPayment = _pPC3MaximumMonthlyPayment; pPC3MaximumMonthlyPayment.Clean = value; _pPC3MaximumMonthlyPayment = pPC3MaximumMonthlyPayment;
                var pPC3MaximumMonthlyPaymentUI = _pPC3MaximumMonthlyPaymentUI; pPC3MaximumMonthlyPaymentUI.Clean = value; _pPC3MaximumMonthlyPaymentUI = pPC3MaximumMonthlyPaymentUI;
                var pPC3MaximumPIPayment = _pPC3MaximumPIPayment; pPC3MaximumPIPayment.Clean = value; _pPC3MaximumPIPayment = pPC3MaximumPIPayment;
                var pPC3MaximumPIPaymentUI = _pPC3MaximumPIPaymentUI; pPC3MaximumPIPaymentUI.Clean = value; _pPC3MaximumPIPaymentUI = pPC3MaximumPIPaymentUI;
                var pPC3MIAmount = _pPC3MIAmount; pPC3MIAmount.Clean = value; _pPC3MIAmount = pPC3MIAmount;
                var pPC3MIAmountUI = _pPC3MIAmountUI; pPC3MIAmountUI.Clean = value; _pPC3MIAmountUI = pPC3MIAmountUI;
                var pPC3MinimumMonthlyPayment = _pPC3MinimumMonthlyPayment; pPC3MinimumMonthlyPayment.Clean = value; _pPC3MinimumMonthlyPayment = pPC3MinimumMonthlyPayment;
                var pPC3MinimumMonthlyPaymentUI = _pPC3MinimumMonthlyPaymentUI; pPC3MinimumMonthlyPaymentUI.Clean = value; _pPC3MinimumMonthlyPaymentUI = pPC3MinimumMonthlyPaymentUI;
                var pPC3MinimumPIPayment = _pPC3MinimumPIPayment; pPC3MinimumPIPayment.Clean = value; _pPC3MinimumPIPayment = pPC3MinimumPIPayment;
                var pPC3MinimumPIPaymentUI = _pPC3MinimumPIPaymentUI; pPC3MinimumPIPaymentUI.Clean = value; _pPC3MinimumPIPaymentUI = pPC3MinimumPIPaymentUI;
                var pPC3YearFrom = _pPC3YearFrom; pPC3YearFrom.Clean = value; _pPC3YearFrom = pPC3YearFrom;
                var pPC3YearTo = _pPC3YearTo; pPC3YearTo.Clean = value; _pPC3YearTo = pPC3YearTo;
                var pPC4EstimatedEscrowAmount = _pPC4EstimatedEscrowAmount; pPC4EstimatedEscrowAmount.Clean = value; _pPC4EstimatedEscrowAmount = pPC4EstimatedEscrowAmount;
                var pPC4EstimatedEscrowAmountUI = _pPC4EstimatedEscrowAmountUI; pPC4EstimatedEscrowAmountUI.Clean = value; _pPC4EstimatedEscrowAmountUI = pPC4EstimatedEscrowAmountUI;
                var pPC4InterestOnly = _pPC4InterestOnly; pPC4InterestOnly.Clean = value; _pPC4InterestOnly = pPC4InterestOnly;
                var pPC4MaximumMonthlyPayment = _pPC4MaximumMonthlyPayment; pPC4MaximumMonthlyPayment.Clean = value; _pPC4MaximumMonthlyPayment = pPC4MaximumMonthlyPayment;
                var pPC4MaximumMonthlyPaymentUI = _pPC4MaximumMonthlyPaymentUI; pPC4MaximumMonthlyPaymentUI.Clean = value; _pPC4MaximumMonthlyPaymentUI = pPC4MaximumMonthlyPaymentUI;
                var pPC4MaximumPIPayment = _pPC4MaximumPIPayment; pPC4MaximumPIPayment.Clean = value; _pPC4MaximumPIPayment = pPC4MaximumPIPayment;
                var pPC4MaximumPIPaymentUI = _pPC4MaximumPIPaymentUI; pPC4MaximumPIPaymentUI.Clean = value; _pPC4MaximumPIPaymentUI = pPC4MaximumPIPaymentUI;
                var pPC4MIAmount = _pPC4MIAmount; pPC4MIAmount.Clean = value; _pPC4MIAmount = pPC4MIAmount;
                var pPC4MIAmountUI = _pPC4MIAmountUI; pPC4MIAmountUI.Clean = value; _pPC4MIAmountUI = pPC4MIAmountUI;
                var pPC4MinimumMonthlyPayment = _pPC4MinimumMonthlyPayment; pPC4MinimumMonthlyPayment.Clean = value; _pPC4MinimumMonthlyPayment = pPC4MinimumMonthlyPayment;
                var pPC4MinimumMonthlyPaymentUI = _pPC4MinimumMonthlyPaymentUI; pPC4MinimumMonthlyPaymentUI.Clean = value; _pPC4MinimumMonthlyPaymentUI = pPC4MinimumMonthlyPaymentUI;
                var pPC4MinimumPIPayment = _pPC4MinimumPIPayment; pPC4MinimumPIPayment.Clean = value; _pPC4MinimumPIPayment = pPC4MinimumPIPayment;
                var pPC4MinimumPIPaymentUI = _pPC4MinimumPIPaymentUI; pPC4MinimumPIPaymentUI.Clean = value; _pPC4MinimumPIPaymentUI = pPC4MinimumPIPaymentUI;
                var pPC4YearFrom = _pPC4YearFrom; pPC4YearFrom.Clean = value; _pPC4YearFrom = pPC4YearFrom;
                var pPC4YearTo = _pPC4YearTo; pPC4YearTo.Clean = value; _pPC4YearTo = pPC4YearTo;
                var pPEstimatedEscrowIndicator = _pPEstimatedEscrowIndicator; pPEstimatedEscrowIndicator.Clean = value; _pPEstimatedEscrowIndicator = pPEstimatedEscrowIndicator;
                var prepaymentPenaltyPayOffDuringYear = _prepaymentPenaltyPayOffDuringYear; prepaymentPenaltyPayOffDuringYear.Clean = value; _prepaymentPenaltyPayOffDuringYear = prepaymentPenaltyPayOffDuringYear;
                var prepaymentPenaltyPayOffInDateType = _prepaymentPenaltyPayOffInDateType; prepaymentPenaltyPayOffInDateType.Clean = value; _prepaymentPenaltyPayOffInDateType = prepaymentPenaltyPayOffInDateType;
                var prepaymentPenaltyPayOffInFirstYear = _prepaymentPenaltyPayOffInFirstYear; prepaymentPenaltyPayOffInFirstYear.Clean = value; _prepaymentPenaltyPayOffInFirstYear = prepaymentPenaltyPayOffInFirstYear;
                var rangePaymentIndicatorC1 = _rangePaymentIndicatorC1; rangePaymentIndicatorC1.Clean = value; _rangePaymentIndicatorC1 = rangePaymentIndicatorC1;
                var rangePaymentIndicatorC2 = _rangePaymentIndicatorC2; rangePaymentIndicatorC2.Clean = value; _rangePaymentIndicatorC2 = rangePaymentIndicatorC2;
                var rangePaymentIndicatorC3 = _rangePaymentIndicatorC3; rangePaymentIndicatorC3.Clean = value; _rangePaymentIndicatorC3 = rangePaymentIndicatorC3;
                var rangePaymentIndicatorC4 = _rangePaymentIndicatorC4; rangePaymentIndicatorC4.Clean = value; _rangePaymentIndicatorC4 = rangePaymentIndicatorC4;
                var rateLockExpirationTime = _rateLockExpirationTime; rateLockExpirationTime.Clean = value; _rateLockExpirationTime = rateLockExpirationTime;
                var rateLockExpirationTimeZone = _rateLockExpirationTimeZone; rateLockExpirationTimeZone.Clean = value; _rateLockExpirationTimeZone = rateLockExpirationTimeZone;
                var reasonChangedCircumstanceFlags = _reasonChangedCircumstanceFlags; reasonChangedCircumstanceFlags.Clean = value; _reasonChangedCircumstanceFlags = reasonChangedCircumstanceFlags;
                var reasonDelayedSettlement = _reasonDelayedSettlement; reasonDelayedSettlement.Clean = value; _reasonDelayedSettlement = reasonDelayedSettlement;
                var reasonEligibility = _reasonEligibility; reasonEligibility.Clean = value; _reasonEligibility = reasonEligibility;
                var reasonExpiration = _reasonExpiration; reasonExpiration.Clean = value; _reasonExpiration = reasonExpiration;
                var reasonInterestRate = _reasonInterestRate; reasonInterestRate.Clean = value; _reasonInterestRate = reasonInterestRate;
                var reasonOther = _reasonOther; reasonOther.Clean = value; _reasonOther = reasonOther;
                var reasonOtherDescription = _reasonOtherDescription; reasonOtherDescription.Clean = value; _reasonOtherDescription = reasonOtherDescription;
                var reasonRevisions = _reasonRevisions; reasonRevisions.Clean = value; _reasonRevisions = reasonRevisions;
                var reasonSettlementCharges = _reasonSettlementCharges; reasonSettlementCharges.Clean = value; _reasonSettlementCharges = reasonSettlementCharges;
                var totalEstimatedCashClose = _totalEstimatedCashClose; totalEstimatedCashClose.Clean = value; _totalEstimatedCashClose = totalEstimatedCashClose;
                var yearsToRecast = _yearsToRecast; yearsToRecast.Clean = value; _yearsToRecast = yearsToRecast;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public LoanEstimate1()
        {
            Clean = true;
        }
    }
}