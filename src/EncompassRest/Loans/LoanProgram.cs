using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class LoanProgram : IDirty
    {
        private DirtyValue<string> _acquisition;
        public string Acquisition { get { return _acquisition; } set { _acquisition = value; } }
        private DirtyValue<string> _additionalArmInformation;
        public string AdditionalArmInformation { get { return _additionalArmInformation; } set { _additionalArmInformation = value; } }
        private DirtyValue<string> _allDateAndNumericalDisclosures;
        public string AllDateAndNumericalDisclosures { get { return _allDateAndNumericalDisclosures; } set { _allDateAndNumericalDisclosures = value; } }
        private DirtyValue<decimal?> _annualFeeNeeded;
        public decimal? AnnualFeeNeeded { get { return _annualFeeNeeded; } set { _annualFeeNeeded = value; } }
        private DirtyValue<string> _armTypeDescription;
        public string ArmTypeDescription { get { return _armTypeDescription; } set { _armTypeDescription = value; } }
        private DirtyValue<string> _assumptionOnYourProperty;
        public string AssumptionOnYourProperty { get { return _assumptionOnYourProperty; } set { _assumptionOnYourProperty = value; } }
        private DirtyValue<int?> _balloonLoanMaturityTermMonths;
        public int? BalloonLoanMaturityTermMonths { get { return _balloonLoanMaturityTermMonths; } set { _balloonLoanMaturityTermMonths = value; } }
        private DirtyValue<int?> _buydownChangeFrequencyMonths1;
        public int? BuydownChangeFrequencyMonths1 { get { return _buydownChangeFrequencyMonths1; } set { _buydownChangeFrequencyMonths1 = value; } }
        private DirtyValue<int?> _buydownChangeFrequencyMonths2;
        public int? BuydownChangeFrequencyMonths2 { get { return _buydownChangeFrequencyMonths2; } set { _buydownChangeFrequencyMonths2 = value; } }
        private DirtyValue<int?> _buydownChangeFrequencyMonths3;
        public int? BuydownChangeFrequencyMonths3 { get { return _buydownChangeFrequencyMonths3; } set { _buydownChangeFrequencyMonths3 = value; } }
        private DirtyValue<int?> _buydownChangeFrequencyMonths4;
        public int? BuydownChangeFrequencyMonths4 { get { return _buydownChangeFrequencyMonths4; } set { _buydownChangeFrequencyMonths4 = value; } }
        private DirtyValue<int?> _buydownChangeFrequencyMonths5;
        public int? BuydownChangeFrequencyMonths5 { get { return _buydownChangeFrequencyMonths5; } set { _buydownChangeFrequencyMonths5 = value; } }
        private DirtyValue<int?> _buydownChangeFrequencyMonths6;
        public int? BuydownChangeFrequencyMonths6 { get { return _buydownChangeFrequencyMonths6; } set { _buydownChangeFrequencyMonths6 = value; } }
        private DirtyValue<decimal?> _buydownIncreaseRatePercent1;
        public decimal? BuydownIncreaseRatePercent1 { get { return _buydownIncreaseRatePercent1; } set { _buydownIncreaseRatePercent1 = value; } }
        private DirtyValue<decimal?> _buydownIncreaseRatePercent2;
        public decimal? BuydownIncreaseRatePercent2 { get { return _buydownIncreaseRatePercent2; } set { _buydownIncreaseRatePercent2 = value; } }
        private DirtyValue<decimal?> _buydownIncreaseRatePercent3;
        public decimal? BuydownIncreaseRatePercent3 { get { return _buydownIncreaseRatePercent3; } set { _buydownIncreaseRatePercent3 = value; } }
        private DirtyValue<decimal?> _buydownIncreaseRatePercent4;
        public decimal? BuydownIncreaseRatePercent4 { get { return _buydownIncreaseRatePercent4; } set { _buydownIncreaseRatePercent4 = value; } }
        private DirtyValue<decimal?> _buydownIncreaseRatePercent5;
        public decimal? BuydownIncreaseRatePercent5 { get { return _buydownIncreaseRatePercent5; } set { _buydownIncreaseRatePercent5 = value; } }
        private DirtyValue<decimal?> _buydownIncreaseRatePercent6;
        public decimal? BuydownIncreaseRatePercent6 { get { return _buydownIncreaseRatePercent6; } set { _buydownIncreaseRatePercent6 = value; } }
        private DirtyValue<string> _calculateBasedOnRemainingBalance;
        public string CalculateBasedOnRemainingBalance { get { return _calculateBasedOnRemainingBalance; } set { _calculateBasedOnRemainingBalance = value; } }
        private DirtyValue<string> _closingCostProgram;
        public string ClosingCostProgram { get { return _closingCostProgram; } set { _closingCostProgram = value; } }
        private DirtyValue<string> _constructionDescription;
        public string ConstructionDescription { get { return _constructionDescription; } set { _constructionDescription = value; } }
        private DirtyValue<decimal?> _constructionInterestReserveAmount;
        public decimal? ConstructionInterestReserveAmount { get { return _constructionInterestReserveAmount; } set { _constructionInterestReserveAmount = value; } }
        private DirtyValue<string> _constructionLoanMethod;
        public string ConstructionLoanMethod { get { return _constructionLoanMethod; } set { _constructionLoanMethod = value; } }
        private DirtyValue<int?> _constructionPeriodMonths;
        public int? ConstructionPeriodMonths { get { return _constructionPeriodMonths; } set { _constructionPeriodMonths = value; } }
        private DirtyValue<decimal?> _constructionRate;
        public decimal? ConstructionRate { get { return _constructionRate; } set { _constructionRate = value; } }
        private DirtyValue<string> _convertible;
        public string Convertible { get { return _convertible; } set { _convertible = value; } }
        private DirtyValue<string> _creditDisability;
        public string CreditDisability { get { return _creditDisability; } set { _creditDisability = value; } }
        private DirtyValue<string> _creditLifeInsurance;
        public string CreditLifeInsurance { get { return _creditLifeInsurance; } set { _creditLifeInsurance = value; } }
        private DirtyValue<string> _demandFeature;
        public string DemandFeature { get { return _demandFeature; } set { _demandFeature = value; } }
        private DirtyValue<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private DirtyValue<string> _disclosureType;
        public string DisclosureType { get { return _disclosureType; } set { _disclosureType = value; } }
        private DirtyValue<string> _discounted;
        public string Discounted { get { return _discounted; } set { _discounted = value; } }
        private DirtyValue<decimal?> _discountedRate;
        public decimal? DiscountedRate { get { return _discountedRate; } set { _discountedRate = value; } }
        private DirtyValue<string> _drawRepayPeriodTableName;
        public string DrawRepayPeriodTableName { get { return _drawRepayPeriodTableName; } set { _drawRepayPeriodTableName = value; } }
        private DirtyValue<decimal?> _fhaUpfrontMiPremiumPercent;
        public decimal? FhaUpfrontMiPremiumPercent { get { return _fhaUpfrontMiPremiumPercent; } set { _fhaUpfrontMiPremiumPercent = value; } }
        private DirtyValue<string> _floodInsurance;
        public string FloodInsurance { get { return _floodInsurance; } set { _floodInsurance = value; } }
        private DirtyValue<decimal?> _floorPercent;
        public decimal? FloorPercent { get { return _floorPercent; } set { _floorPercent = value; } }
        private DirtyValue<decimal?> _fundingFeePaidInCash;
        public decimal? FundingFeePaidInCash { get { return _fundingFeePaidInCash; } set { _fundingFeePaidInCash = value; } }
        private DirtyValue<decimal?> _gpmExtraPaymentForEarlyPayOff;
        public decimal? GpmExtraPaymentForEarlyPayOff { get { return _gpmExtraPaymentForEarlyPayOff; } set { _gpmExtraPaymentForEarlyPayOff = value; } }
        private DirtyValue<decimal?> _gpmRate;
        public decimal? GpmRate { get { return _gpmRate; } set { _gpmRate = value; } }
        private DirtyValue<int?> _gpmYears;
        public int? GpmYears { get { return _gpmYears; } set { _gpmYears = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _ifYouPurchase;
        public string IfYouPurchase { get { return _ifYouPurchase; } set { _ifYouPurchase = value; } }
        private DirtyValue<string> _ifYouPurchaseType;
        public string IfYouPurchaseType { get { return _ifYouPurchaseType; } set { _ifYouPurchaseType = value; } }
        private DirtyValue<decimal?> _indexCurrentValuePercent;
        public decimal? IndexCurrentValuePercent { get { return _indexCurrentValuePercent; } set { _indexCurrentValuePercent = value; } }
        private DirtyValue<decimal?> _indexMarginPercent;
        public decimal? IndexMarginPercent { get { return _indexMarginPercent; } set { _indexMarginPercent = value; } }
        private DirtyValue<decimal?> _initialAdvanceAmount;
        public decimal? InitialAdvanceAmount { get { return _initialAdvanceAmount; } set { _initialAdvanceAmount = value; } }
        private DirtyValue<int?> _interestOnlyMonths;
        public int? InterestOnlyMonths { get { return _interestOnlyMonths; } set { _interestOnlyMonths = value; } }
        private DirtyValue<int?> _lateChargeDays;
        public int? LateChargeDays { get { return _lateChargeDays; } set { _lateChargeDays = value; } }
        private DirtyValue<decimal?> _lateChargePercent;
        public decimal? LateChargePercent { get { return _lateChargePercent; } set { _lateChargePercent = value; } }
        private DirtyValue<string> _lateChargeType;
        public string LateChargeType { get { return _lateChargeType; } set { _lateChargeType = value; } }
        private DirtyValue<string> _lenderInvestorCode;
        public string LenderInvestorCode { get { return _lenderInvestorCode; } set { _lenderInvestorCode = value; } }
        private DirtyValue<string> _lienPriorityType;
        public string LienPriorityType { get { return _lienPriorityType; } set { _lienPriorityType = value; } }
        private DirtyValue<int?> _loanAmortizationTermMonths;
        public int? LoanAmortizationTermMonths { get { return _loanAmortizationTermMonths; } set { _loanAmortizationTermMonths = value; } }
        private DirtyValue<string> _loanAmortizationType;
        public string LoanAmortizationType { get { return _loanAmortizationType; } set { _loanAmortizationType = value; } }
        private DirtyValue<string> _loanDocumentationType;
        public string LoanDocumentationType { get { return _loanDocumentationType; } set { _loanDocumentationType = value; } }
        private DirtyValue<string> _loanFeaturesPaymentFrequencyType;
        public string LoanFeaturesPaymentFrequencyType { get { return _loanFeaturesPaymentFrequencyType; } set { _loanFeaturesPaymentFrequencyType = value; } }
        private DirtyValue<string> _loanProgramName;
        public string LoanProgramName { get { return _loanProgramName; } set { _loanProgramName = value; } }
        private DirtyValue<string> _lockField;
        public string LockField { get { return _lockField; } set { _lockField = value; } }
        private DirtyValue<decimal?> _maxBackRatio;
        public decimal? MaxBackRatio { get { return _maxBackRatio; } set { _maxBackRatio = value; } }
        private DirtyValue<decimal?> _maxCltv;
        public decimal? MaxCltv { get { return _maxCltv; } set { _maxCltv = value; } }
        private DirtyValue<decimal?> _maxFrontRatio;
        public decimal? MaxFrontRatio { get { return _maxFrontRatio; } set { _maxFrontRatio = value; } }
        private DirtyValue<decimal?> _maximumBalance;
        public decimal? MaximumBalance { get { return _maximumBalance; } set { _maximumBalance = value; } }
        private DirtyValue<decimal?> _maxLoanAmount;
        public decimal? MaxLoanAmount { get { return _maxLoanAmount; } set { _maxLoanAmount = value; } }
        private DirtyValue<decimal?> _maxLtv;
        public decimal? MaxLtv { get { return _maxLtv; } set { _maxLtv = value; } }
        private DirtyValue<string> _meansAnEstimate;
        public string MeansAnEstimate { get { return _meansAnEstimate; } set { _meansAnEstimate = value; } }
        private DirtyValue<string> _miCalculationType;
        public string MiCalculationType { get { return _miCalculationType; } set { _miCalculationType = value; } }
        private DirtyValue<string> _midpointCancellation;
        public string MidpointCancellation { get { return _midpointCancellation; } set { _midpointCancellation = value; } }
        private DirtyValue<string> _minCreditScore;
        public string MinCreditScore { get { return _minCreditScore; } set { _minCreditScore = value; } }
        private DirtyValue<decimal?> _minimumAdvanceAmount;
        public decimal? MinimumAdvanceAmount { get { return _minimumAdvanceAmount; } set { _minimumAdvanceAmount = value; } }
        private DirtyValue<decimal?> _minimumAllowableApr;
        public decimal? MinimumAllowableApr { get { return _minimumAllowableApr; } set { _minimumAllowableApr = value; } }
        private DirtyValue<decimal?> _minimumPaymentAmount;
        public decimal? MinimumPaymentAmount { get { return _minimumPaymentAmount; } set { _minimumPaymentAmount = value; } }
        private DirtyValue<decimal?> _minimumPaymentPercent;
        public decimal? MinimumPaymentPercent { get { return _minimumPaymentPercent; } set { _minimumPaymentPercent = value; } }
        private DirtyValue<decimal?> _mipPaidInCash;
        public decimal? MipPaidInCash { get { return _mipPaidInCash; } set { _mipPaidInCash = value; } }
        private DirtyValue<string> _mmi;
        public string Mmi { get { return _mmi; } set { _mmi = value; } }
        private DirtyValue<decimal?> _mortgageInsuranceAdjustmentFactor1;
        public decimal? MortgageInsuranceAdjustmentFactor1 { get { return _mortgageInsuranceAdjustmentFactor1; } set { _mortgageInsuranceAdjustmentFactor1 = value; } }
        private DirtyValue<decimal?> _mortgageInsuranceAdjustmentFactor2;
        public decimal? MortgageInsuranceAdjustmentFactor2 { get { return _mortgageInsuranceAdjustmentFactor2; } set { _mortgageInsuranceAdjustmentFactor2 = value; } }
        private DirtyValue<decimal?> _mortgageInsuranceCancelPercent;
        public decimal? MortgageInsuranceCancelPercent { get { return _mortgageInsuranceCancelPercent; } set { _mortgageInsuranceCancelPercent = value; } }
        private DirtyValue<decimal?> _mortgageInsuranceMonthlyPayment1;
        public decimal? MortgageInsuranceMonthlyPayment1 { get { return _mortgageInsuranceMonthlyPayment1; } set { _mortgageInsuranceMonthlyPayment1 = value; } }
        private DirtyValue<decimal?> _mortgageInsuranceMonthlyPayment2;
        public decimal? MortgageInsuranceMonthlyPayment2 { get { return _mortgageInsuranceMonthlyPayment2; } set { _mortgageInsuranceMonthlyPayment2 = value; } }
        private DirtyValue<int?> _mortgageInsuranceMonthsOfAdjustment1;
        public int? MortgageInsuranceMonthsOfAdjustment1 { get { return _mortgageInsuranceMonthsOfAdjustment1; } set { _mortgageInsuranceMonthsOfAdjustment1 = value; } }
        private DirtyValue<int?> _mortgageInsuranceMonthsOfAdjustment2;
        public int? MortgageInsuranceMonthsOfAdjustment2 { get { return _mortgageInsuranceMonthsOfAdjustment2; } set { _mortgageInsuranceMonthsOfAdjustment2 = value; } }
        private DirtyValue<string> _mortgageType;
        public string MortgageType { get { return _mortgageType; } set { _mortgageType = value; } }
        private DirtyValue<string> _otherAmortizationTypeDescription;
        public string OtherAmortizationTypeDescription { get { return _otherAmortizationTypeDescription; } set { _otherAmortizationTypeDescription = value; } }
        private DirtyValue<string> _otherLoanPurposeDescription;
        public string OtherLoanPurposeDescription { get { return _otherLoanPurposeDescription; } set { _otherLoanPurposeDescription = value; } }
        private DirtyValue<string> _otherMortgageTypeDescription;
        public string OtherMortgageTypeDescription { get { return _otherMortgageTypeDescription; } set { _otherMortgageTypeDescription = value; } }
        private DirtyValue<int?> _paymentAdjustmentDurationMonths;
        public int? PaymentAdjustmentDurationMonths { get { return _paymentAdjustmentDurationMonths; } set { _paymentAdjustmentDurationMonths = value; } }
        private DirtyValue<decimal?> _paymentAdjustmentPeriodicCapPercent;
        public decimal? PaymentAdjustmentPeriodicCapPercent { get { return _paymentAdjustmentPeriodicCapPercent; } set { _paymentAdjustmentPeriodicCapPercent = value; } }
        private DirtyValue<decimal?> _paymentFactor;
        public decimal? PaymentFactor { get { return _paymentFactor; } set { _paymentFactor = value; } }
        private DirtyValue<decimal?> _percentageOfRental;
        public decimal? PercentageOfRental { get { return _percentageOfRental; } set { _percentageOfRental = value; } }
        private DirtyValue<string> _perDiemCalculationMethodType;
        public string PerDiemCalculationMethodType { get { return _perDiemCalculationMethodType; } set { _perDiemCalculationMethodType = value; } }
        private DirtyValue<string> _pmi;
        public string Pmi { get { return _pmi; } set { _pmi = value; } }
        private DirtyValue<string> _prepaymentPenaltyIndicator;
        public string PrepaymentPenaltyIndicator { get { return _prepaymentPenaltyIndicator; } set { _prepaymentPenaltyIndicator = value; } }
        private DirtyValue<string> _programCode;
        public string ProgramCode { get { return _programCode; } set { _programCode = value; } }
        private DirtyValue<string> _propertyInsurance;
        public string PropertyInsurance { get { return _propertyInsurance; } set { _propertyInsurance = value; } }
        private DirtyValue<string> _propertyUsageType;
        public string PropertyUsageType { get { return _propertyUsageType; } set { _propertyUsageType = value; } }
        private DirtyValue<decimal?> _qualifyingRatePercent;
        public decimal? QualifyingRatePercent { get { return _qualifyingRatePercent; } set { _qualifyingRatePercent = value; } }
        private DirtyValue<int?> _rateAdjustmentDurationMonths;
        public int? RateAdjustmentDurationMonths { get { return _rateAdjustmentDurationMonths; } set { _rateAdjustmentDurationMonths = value; } }
        private DirtyValue<decimal?> _rateAdjustmentLifetimeCapPercent;
        public decimal? RateAdjustmentLifetimeCapPercent { get { return _rateAdjustmentLifetimeCapPercent; } set { _rateAdjustmentLifetimeCapPercent = value; } }
        private DirtyValue<decimal?> _rateAdjustmentPercent;
        public decimal? RateAdjustmentPercent { get { return _rateAdjustmentPercent; } set { _rateAdjustmentPercent = value; } }
        private DirtyValue<decimal?> _rateAdjustmentSubsequentCapPercent;
        public decimal? RateAdjustmentSubsequentCapPercent { get { return _rateAdjustmentSubsequentCapPercent; } set { _rateAdjustmentSubsequentCapPercent = value; } }
        private DirtyValue<int?> _rateAdjustmentSubsequentRateAdjustmentMonths;
        public int? RateAdjustmentSubsequentRateAdjustmentMonths { get { return _rateAdjustmentSubsequentRateAdjustmentMonths; } set { _rateAdjustmentSubsequentRateAdjustmentMonths = value; } }
        private DirtyValue<int?> _recastPaidMonths;
        public int? RecastPaidMonths { get { return _recastPaidMonths; } set { _recastPaidMonths = value; } }
        private DirtyValue<int?> _recastStopMonths;
        public int? RecastStopMonths { get { return _recastStopMonths; } set { _recastStopMonths = value; } }
        private DirtyValue<string> _refundPaymentIndicator;
        public string RefundPaymentIndicator { get { return _refundPaymentIndicator; } set { _refundPaymentIndicator = value; } }
        private DirtyValue<decimal?> _requestedInterestRatePercent;
        public decimal? RequestedInterestRatePercent { get { return _requestedInterestRatePercent; } set { _requestedInterestRatePercent = value; } }
        private DirtyValue<string> _requiredDeposit;
        public string RequiredDeposit { get { return _requiredDeposit; } set { _requiredDeposit = value; } }
        private DirtyValue<decimal?> _roundPercent;
        public decimal? RoundPercent { get { return _roundPercent; } set { _roundPercent = value; } }
        private DirtyValue<string> _roundType;
        public string RoundType { get { return _roundType; } set { _roundType = value; } }
        private DirtyValue<string> _securityInterestInNameOf;
        public string SecurityInterestInNameOf { get { return _securityInterestInNameOf; } set { _securityInterestInNameOf = value; } }
        private DirtyValue<string> _securityType;
        public string SecurityType { get { return _securityType; } set { _securityType = value; } }
        private DirtyValue<decimal?> _subjectPropertyGrossRentalIncome;
        public decimal? SubjectPropertyGrossRentalIncome { get { return _subjectPropertyGrossRentalIncome; } set { _subjectPropertyGrossRentalIncome = value; } }
        private DirtyValue<decimal?> _teaserRate;
        public decimal? TeaserRate { get { return _teaserRate; } set { _teaserRate = value; } }
        private DirtyValue<decimal?> _terminationFeeAmount;
        public decimal? TerminationFeeAmount { get { return _terminationFeeAmount; } set { _terminationFeeAmount = value; } }
        private DirtyValue<int?> _terminationPeriodMonthsCount;
        public int? TerminationPeriodMonthsCount { get { return _terminationPeriodMonthsCount; } set { _terminationPeriodMonthsCount = value; } }
        private DirtyValue<decimal?> _thirdPartyFeeFrom;
        public decimal? ThirdPartyFeeFrom { get { return _thirdPartyFeeFrom; } set { _thirdPartyFeeFrom = value; } }
        private DirtyValue<decimal?> _thirdPartyFeeTo;
        public decimal? ThirdPartyFeeTo { get { return _thirdPartyFeeTo; } set { _thirdPartyFeeTo = value; } }
        private DirtyValue<string> _type;
        public string Type { get { return _type; } set { _type = value; } }
        private DirtyValue<string> _useDaysInYears;
        public string UseDaysInYears { get { return _useDaysInYears; } set { _useDaysInYears = value; } }
        private DirtyValue<string> _usePitiForRatio;
        public string UsePitiForRatio { get { return _usePitiForRatio; } set { _usePitiForRatio = value; } }
        private DirtyValue<string> _variableRateFeature;
        public string VariableRateFeature { get { return _variableRateFeature; } set { _variableRateFeature = value; } }
        private DirtyValue<decimal?> _yearlyTerm;
        public decimal? YearlyTerm { get { return _yearlyTerm; } set { _yearlyTerm = value; } }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get { return _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); } set { _extensionData = new DirtyDictionary<string, object>(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _acquisition.Dirty
                    || _additionalArmInformation.Dirty
                    || _allDateAndNumericalDisclosures.Dirty
                    || _annualFeeNeeded.Dirty
                    || _armTypeDescription.Dirty
                    || _assumptionOnYourProperty.Dirty
                    || _balloonLoanMaturityTermMonths.Dirty
                    || _buydownChangeFrequencyMonths1.Dirty
                    || _buydownChangeFrequencyMonths2.Dirty
                    || _buydownChangeFrequencyMonths3.Dirty
                    || _buydownChangeFrequencyMonths4.Dirty
                    || _buydownChangeFrequencyMonths5.Dirty
                    || _buydownChangeFrequencyMonths6.Dirty
                    || _buydownIncreaseRatePercent1.Dirty
                    || _buydownIncreaseRatePercent2.Dirty
                    || _buydownIncreaseRatePercent3.Dirty
                    || _buydownIncreaseRatePercent4.Dirty
                    || _buydownIncreaseRatePercent5.Dirty
                    || _buydownIncreaseRatePercent6.Dirty
                    || _calculateBasedOnRemainingBalance.Dirty
                    || _closingCostProgram.Dirty
                    || _constructionDescription.Dirty
                    || _constructionInterestReserveAmount.Dirty
                    || _constructionLoanMethod.Dirty
                    || _constructionPeriodMonths.Dirty
                    || _constructionRate.Dirty
                    || _convertible.Dirty
                    || _creditDisability.Dirty
                    || _creditLifeInsurance.Dirty
                    || _demandFeature.Dirty
                    || _description.Dirty
                    || _disclosureType.Dirty
                    || _discounted.Dirty
                    || _discountedRate.Dirty
                    || _drawRepayPeriodTableName.Dirty
                    || _fhaUpfrontMiPremiumPercent.Dirty
                    || _floodInsurance.Dirty
                    || _floorPercent.Dirty
                    || _fundingFeePaidInCash.Dirty
                    || _gpmExtraPaymentForEarlyPayOff.Dirty
                    || _gpmRate.Dirty
                    || _gpmYears.Dirty
                    || _id.Dirty
                    || _ifYouPurchase.Dirty
                    || _ifYouPurchaseType.Dirty
                    || _indexCurrentValuePercent.Dirty
                    || _indexMarginPercent.Dirty
                    || _initialAdvanceAmount.Dirty
                    || _interestOnlyMonths.Dirty
                    || _lateChargeDays.Dirty
                    || _lateChargePercent.Dirty
                    || _lateChargeType.Dirty
                    || _lenderInvestorCode.Dirty
                    || _lienPriorityType.Dirty
                    || _loanAmortizationTermMonths.Dirty
                    || _loanAmortizationType.Dirty
                    || _loanDocumentationType.Dirty
                    || _loanFeaturesPaymentFrequencyType.Dirty
                    || _loanProgramName.Dirty
                    || _lockField.Dirty
                    || _maxBackRatio.Dirty
                    || _maxCltv.Dirty
                    || _maxFrontRatio.Dirty
                    || _maximumBalance.Dirty
                    || _maxLoanAmount.Dirty
                    || _maxLtv.Dirty
                    || _meansAnEstimate.Dirty
                    || _miCalculationType.Dirty
                    || _midpointCancellation.Dirty
                    || _minCreditScore.Dirty
                    || _minimumAdvanceAmount.Dirty
                    || _minimumAllowableApr.Dirty
                    || _minimumPaymentAmount.Dirty
                    || _minimumPaymentPercent.Dirty
                    || _mipPaidInCash.Dirty
                    || _mmi.Dirty
                    || _mortgageInsuranceAdjustmentFactor1.Dirty
                    || _mortgageInsuranceAdjustmentFactor2.Dirty
                    || _mortgageInsuranceCancelPercent.Dirty
                    || _mortgageInsuranceMonthlyPayment1.Dirty
                    || _mortgageInsuranceMonthlyPayment2.Dirty
                    || _mortgageInsuranceMonthsOfAdjustment1.Dirty
                    || _mortgageInsuranceMonthsOfAdjustment2.Dirty
                    || _mortgageType.Dirty
                    || _otherAmortizationTypeDescription.Dirty
                    || _otherLoanPurposeDescription.Dirty
                    || _otherMortgageTypeDescription.Dirty
                    || _paymentAdjustmentDurationMonths.Dirty
                    || _paymentAdjustmentPeriodicCapPercent.Dirty
                    || _paymentFactor.Dirty
                    || _percentageOfRental.Dirty
                    || _perDiemCalculationMethodType.Dirty
                    || _pmi.Dirty
                    || _prepaymentPenaltyIndicator.Dirty
                    || _programCode.Dirty
                    || _propertyInsurance.Dirty
                    || _propertyUsageType.Dirty
                    || _qualifyingRatePercent.Dirty
                    || _rateAdjustmentDurationMonths.Dirty
                    || _rateAdjustmentLifetimeCapPercent.Dirty
                    || _rateAdjustmentPercent.Dirty
                    || _rateAdjustmentSubsequentCapPercent.Dirty
                    || _rateAdjustmentSubsequentRateAdjustmentMonths.Dirty
                    || _recastPaidMonths.Dirty
                    || _recastStopMonths.Dirty
                    || _refundPaymentIndicator.Dirty
                    || _requestedInterestRatePercent.Dirty
                    || _requiredDeposit.Dirty
                    || _roundPercent.Dirty
                    || _roundType.Dirty
                    || _securityInterestInNameOf.Dirty
                    || _securityType.Dirty
                    || _subjectPropertyGrossRentalIncome.Dirty
                    || _teaserRate.Dirty
                    || _terminationFeeAmount.Dirty
                    || _terminationPeriodMonthsCount.Dirty
                    || _thirdPartyFeeFrom.Dirty
                    || _thirdPartyFeeTo.Dirty
                    || _type.Dirty
                    || _useDaysInYears.Dirty
                    || _usePitiForRatio.Dirty
                    || _variableRateFeature.Dirty
                    || _yearlyTerm.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _acquisition.Dirty = value;
                _additionalArmInformation.Dirty = value;
                _allDateAndNumericalDisclosures.Dirty = value;
                _annualFeeNeeded.Dirty = value;
                _armTypeDescription.Dirty = value;
                _assumptionOnYourProperty.Dirty = value;
                _balloonLoanMaturityTermMonths.Dirty = value;
                _buydownChangeFrequencyMonths1.Dirty = value;
                _buydownChangeFrequencyMonths2.Dirty = value;
                _buydownChangeFrequencyMonths3.Dirty = value;
                _buydownChangeFrequencyMonths4.Dirty = value;
                _buydownChangeFrequencyMonths5.Dirty = value;
                _buydownChangeFrequencyMonths6.Dirty = value;
                _buydownIncreaseRatePercent1.Dirty = value;
                _buydownIncreaseRatePercent2.Dirty = value;
                _buydownIncreaseRatePercent3.Dirty = value;
                _buydownIncreaseRatePercent4.Dirty = value;
                _buydownIncreaseRatePercent5.Dirty = value;
                _buydownIncreaseRatePercent6.Dirty = value;
                _calculateBasedOnRemainingBalance.Dirty = value;
                _closingCostProgram.Dirty = value;
                _constructionDescription.Dirty = value;
                _constructionInterestReserveAmount.Dirty = value;
                _constructionLoanMethod.Dirty = value;
                _constructionPeriodMonths.Dirty = value;
                _constructionRate.Dirty = value;
                _convertible.Dirty = value;
                _creditDisability.Dirty = value;
                _creditLifeInsurance.Dirty = value;
                _demandFeature.Dirty = value;
                _description.Dirty = value;
                _disclosureType.Dirty = value;
                _discounted.Dirty = value;
                _discountedRate.Dirty = value;
                _drawRepayPeriodTableName.Dirty = value;
                _fhaUpfrontMiPremiumPercent.Dirty = value;
                _floodInsurance.Dirty = value;
                _floorPercent.Dirty = value;
                _fundingFeePaidInCash.Dirty = value;
                _gpmExtraPaymentForEarlyPayOff.Dirty = value;
                _gpmRate.Dirty = value;
                _gpmYears.Dirty = value;
                _id.Dirty = value;
                _ifYouPurchase.Dirty = value;
                _ifYouPurchaseType.Dirty = value;
                _indexCurrentValuePercent.Dirty = value;
                _indexMarginPercent.Dirty = value;
                _initialAdvanceAmount.Dirty = value;
                _interestOnlyMonths.Dirty = value;
                _lateChargeDays.Dirty = value;
                _lateChargePercent.Dirty = value;
                _lateChargeType.Dirty = value;
                _lenderInvestorCode.Dirty = value;
                _lienPriorityType.Dirty = value;
                _loanAmortizationTermMonths.Dirty = value;
                _loanAmortizationType.Dirty = value;
                _loanDocumentationType.Dirty = value;
                _loanFeaturesPaymentFrequencyType.Dirty = value;
                _loanProgramName.Dirty = value;
                _lockField.Dirty = value;
                _maxBackRatio.Dirty = value;
                _maxCltv.Dirty = value;
                _maxFrontRatio.Dirty = value;
                _maximumBalance.Dirty = value;
                _maxLoanAmount.Dirty = value;
                _maxLtv.Dirty = value;
                _meansAnEstimate.Dirty = value;
                _miCalculationType.Dirty = value;
                _midpointCancellation.Dirty = value;
                _minCreditScore.Dirty = value;
                _minimumAdvanceAmount.Dirty = value;
                _minimumAllowableApr.Dirty = value;
                _minimumPaymentAmount.Dirty = value;
                _minimumPaymentPercent.Dirty = value;
                _mipPaidInCash.Dirty = value;
                _mmi.Dirty = value;
                _mortgageInsuranceAdjustmentFactor1.Dirty = value;
                _mortgageInsuranceAdjustmentFactor2.Dirty = value;
                _mortgageInsuranceCancelPercent.Dirty = value;
                _mortgageInsuranceMonthlyPayment1.Dirty = value;
                _mortgageInsuranceMonthlyPayment2.Dirty = value;
                _mortgageInsuranceMonthsOfAdjustment1.Dirty = value;
                _mortgageInsuranceMonthsOfAdjustment2.Dirty = value;
                _mortgageType.Dirty = value;
                _otherAmortizationTypeDescription.Dirty = value;
                _otherLoanPurposeDescription.Dirty = value;
                _otherMortgageTypeDescription.Dirty = value;
                _paymentAdjustmentDurationMonths.Dirty = value;
                _paymentAdjustmentPeriodicCapPercent.Dirty = value;
                _paymentFactor.Dirty = value;
                _percentageOfRental.Dirty = value;
                _perDiemCalculationMethodType.Dirty = value;
                _pmi.Dirty = value;
                _prepaymentPenaltyIndicator.Dirty = value;
                _programCode.Dirty = value;
                _propertyInsurance.Dirty = value;
                _propertyUsageType.Dirty = value;
                _qualifyingRatePercent.Dirty = value;
                _rateAdjustmentDurationMonths.Dirty = value;
                _rateAdjustmentLifetimeCapPercent.Dirty = value;
                _rateAdjustmentPercent.Dirty = value;
                _rateAdjustmentSubsequentCapPercent.Dirty = value;
                _rateAdjustmentSubsequentRateAdjustmentMonths.Dirty = value;
                _recastPaidMonths.Dirty = value;
                _recastStopMonths.Dirty = value;
                _refundPaymentIndicator.Dirty = value;
                _requestedInterestRatePercent.Dirty = value;
                _requiredDeposit.Dirty = value;
                _roundPercent.Dirty = value;
                _roundType.Dirty = value;
                _securityInterestInNameOf.Dirty = value;
                _securityType.Dirty = value;
                _subjectPropertyGrossRentalIncome.Dirty = value;
                _teaserRate.Dirty = value;
                _terminationFeeAmount.Dirty = value;
                _terminationPeriodMonthsCount.Dirty = value;
                _thirdPartyFeeFrom.Dirty = value;
                _thirdPartyFeeTo.Dirty = value;
                _type.Dirty = value;
                _useDaysInYears.Dirty = value;
                _usePitiForRatio.Dirty = value;
                _variableRateFeature.Dirty = value;
                _yearlyTerm.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}