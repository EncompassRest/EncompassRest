using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LoanProgram : IClean
    {
        private Value<string> _acquisition;
        public string Acquisition { get { return _acquisition; } set { _acquisition = value; } }
        private Value<string> _additionalArmInformation;
        public string AdditionalArmInformation { get { return _additionalArmInformation; } set { _additionalArmInformation = value; } }
        private Value<string> _allDateAndNumericalDisclosures;
        public string AllDateAndNumericalDisclosures { get { return _allDateAndNumericalDisclosures; } set { _allDateAndNumericalDisclosures = value; } }
        private Value<decimal?> _annualFeeNeeded;
        public decimal? AnnualFeeNeeded { get { return _annualFeeNeeded; } set { _annualFeeNeeded = value; } }
        private Value<string> _armTypeDescription;
        public string ArmTypeDescription { get { return _armTypeDescription; } set { _armTypeDescription = value; } }
        private Value<string> _assumptionOnYourProperty;
        public string AssumptionOnYourProperty { get { return _assumptionOnYourProperty; } set { _assumptionOnYourProperty = value; } }
        private Value<int?> _balloonLoanMaturityTermMonths;
        public int? BalloonLoanMaturityTermMonths { get { return _balloonLoanMaturityTermMonths; } set { _balloonLoanMaturityTermMonths = value; } }
        private Value<int?> _buydownChangeFrequencyMonths1;
        public int? BuydownChangeFrequencyMonths1 { get { return _buydownChangeFrequencyMonths1; } set { _buydownChangeFrequencyMonths1 = value; } }
        private Value<int?> _buydownChangeFrequencyMonths2;
        public int? BuydownChangeFrequencyMonths2 { get { return _buydownChangeFrequencyMonths2; } set { _buydownChangeFrequencyMonths2 = value; } }
        private Value<int?> _buydownChangeFrequencyMonths3;
        public int? BuydownChangeFrequencyMonths3 { get { return _buydownChangeFrequencyMonths3; } set { _buydownChangeFrequencyMonths3 = value; } }
        private Value<int?> _buydownChangeFrequencyMonths4;
        public int? BuydownChangeFrequencyMonths4 { get { return _buydownChangeFrequencyMonths4; } set { _buydownChangeFrequencyMonths4 = value; } }
        private Value<int?> _buydownChangeFrequencyMonths5;
        public int? BuydownChangeFrequencyMonths5 { get { return _buydownChangeFrequencyMonths5; } set { _buydownChangeFrequencyMonths5 = value; } }
        private Value<int?> _buydownChangeFrequencyMonths6;
        public int? BuydownChangeFrequencyMonths6 { get { return _buydownChangeFrequencyMonths6; } set { _buydownChangeFrequencyMonths6 = value; } }
        private Value<decimal?> _buydownIncreaseRatePercent1;
        public decimal? BuydownIncreaseRatePercent1 { get { return _buydownIncreaseRatePercent1; } set { _buydownIncreaseRatePercent1 = value; } }
        private Value<decimal?> _buydownIncreaseRatePercent2;
        public decimal? BuydownIncreaseRatePercent2 { get { return _buydownIncreaseRatePercent2; } set { _buydownIncreaseRatePercent2 = value; } }
        private Value<decimal?> _buydownIncreaseRatePercent3;
        public decimal? BuydownIncreaseRatePercent3 { get { return _buydownIncreaseRatePercent3; } set { _buydownIncreaseRatePercent3 = value; } }
        private Value<decimal?> _buydownIncreaseRatePercent4;
        public decimal? BuydownIncreaseRatePercent4 { get { return _buydownIncreaseRatePercent4; } set { _buydownIncreaseRatePercent4 = value; } }
        private Value<decimal?> _buydownIncreaseRatePercent5;
        public decimal? BuydownIncreaseRatePercent5 { get { return _buydownIncreaseRatePercent5; } set { _buydownIncreaseRatePercent5 = value; } }
        private Value<decimal?> _buydownIncreaseRatePercent6;
        public decimal? BuydownIncreaseRatePercent6 { get { return _buydownIncreaseRatePercent6; } set { _buydownIncreaseRatePercent6 = value; } }
        private Value<string> _calculateBasedOnRemainingBalance;
        public string CalculateBasedOnRemainingBalance { get { return _calculateBasedOnRemainingBalance; } set { _calculateBasedOnRemainingBalance = value; } }
        private Value<string> _closingCostProgram;
        public string ClosingCostProgram { get { return _closingCostProgram; } set { _closingCostProgram = value; } }
        private Value<string> _constructionDescription;
        public string ConstructionDescription { get { return _constructionDescription; } set { _constructionDescription = value; } }
        private Value<decimal?> _constructionInterestReserveAmount;
        public decimal? ConstructionInterestReserveAmount { get { return _constructionInterestReserveAmount; } set { _constructionInterestReserveAmount = value; } }
        private Value<string> _constructionLoanMethod;
        public string ConstructionLoanMethod { get { return _constructionLoanMethod; } set { _constructionLoanMethod = value; } }
        private Value<int?> _constructionPeriodMonths;
        public int? ConstructionPeriodMonths { get { return _constructionPeriodMonths; } set { _constructionPeriodMonths = value; } }
        private Value<decimal?> _constructionRate;
        public decimal? ConstructionRate { get { return _constructionRate; } set { _constructionRate = value; } }
        private Value<string> _convertible;
        public string Convertible { get { return _convertible; } set { _convertible = value; } }
        private Value<string> _creditDisability;
        public string CreditDisability { get { return _creditDisability; } set { _creditDisability = value; } }
        private Value<string> _creditLifeInsurance;
        public string CreditLifeInsurance { get { return _creditLifeInsurance; } set { _creditLifeInsurance = value; } }
        private Value<string> _demandFeature;
        public string DemandFeature { get { return _demandFeature; } set { _demandFeature = value; } }
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private Value<string> _disclosureType;
        public string DisclosureType { get { return _disclosureType; } set { _disclosureType = value; } }
        private Value<string> _discounted;
        public string Discounted { get { return _discounted; } set { _discounted = value; } }
        private Value<decimal?> _discountedRate;
        public decimal? DiscountedRate { get { return _discountedRate; } set { _discountedRate = value; } }
        private Value<string> _drawRepayPeriodTableName;
        public string DrawRepayPeriodTableName { get { return _drawRepayPeriodTableName; } set { _drawRepayPeriodTableName = value; } }
        private Value<decimal?> _fhaUpfrontMiPremiumPercent;
        public decimal? FhaUpfrontMiPremiumPercent { get { return _fhaUpfrontMiPremiumPercent; } set { _fhaUpfrontMiPremiumPercent = value; } }
        private Value<string> _floodInsurance;
        public string FloodInsurance { get { return _floodInsurance; } set { _floodInsurance = value; } }
        private Value<decimal?> _floorPercent;
        public decimal? FloorPercent { get { return _floorPercent; } set { _floorPercent = value; } }
        private Value<decimal?> _fundingFeePaidInCash;
        public decimal? FundingFeePaidInCash { get { return _fundingFeePaidInCash; } set { _fundingFeePaidInCash = value; } }
        private Value<decimal?> _gpmExtraPaymentForEarlyPayOff;
        public decimal? GpmExtraPaymentForEarlyPayOff { get { return _gpmExtraPaymentForEarlyPayOff; } set { _gpmExtraPaymentForEarlyPayOff = value; } }
        private Value<decimal?> _gpmRate;
        public decimal? GpmRate { get { return _gpmRate; } set { _gpmRate = value; } }
        private Value<int?> _gpmYears;
        public int? GpmYears { get { return _gpmYears; } set { _gpmYears = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _ifYouPurchase;
        public string IfYouPurchase { get { return _ifYouPurchase; } set { _ifYouPurchase = value; } }
        private Value<string> _ifYouPurchaseType;
        public string IfYouPurchaseType { get { return _ifYouPurchaseType; } set { _ifYouPurchaseType = value; } }
        private Value<decimal?> _indexCurrentValuePercent;
        public decimal? IndexCurrentValuePercent { get { return _indexCurrentValuePercent; } set { _indexCurrentValuePercent = value; } }
        private Value<decimal?> _indexMarginPercent;
        public decimal? IndexMarginPercent { get { return _indexMarginPercent; } set { _indexMarginPercent = value; } }
        private Value<decimal?> _initialAdvanceAmount;
        public decimal? InitialAdvanceAmount { get { return _initialAdvanceAmount; } set { _initialAdvanceAmount = value; } }
        private Value<int?> _interestOnlyMonths;
        public int? InterestOnlyMonths { get { return _interestOnlyMonths; } set { _interestOnlyMonths = value; } }
        private Value<int?> _lateChargeDays;
        public int? LateChargeDays { get { return _lateChargeDays; } set { _lateChargeDays = value; } }
        private Value<decimal?> _lateChargePercent;
        public decimal? LateChargePercent { get { return _lateChargePercent; } set { _lateChargePercent = value; } }
        private Value<string> _lateChargeType;
        public string LateChargeType { get { return _lateChargeType; } set { _lateChargeType = value; } }
        private Value<string> _lenderInvestorCode;
        public string LenderInvestorCode { get { return _lenderInvestorCode; } set { _lenderInvestorCode = value; } }
        private Value<string> _lienPriorityType;
        public string LienPriorityType { get { return _lienPriorityType; } set { _lienPriorityType = value; } }
        private Value<int?> _loanAmortizationTermMonths;
        public int? LoanAmortizationTermMonths { get { return _loanAmortizationTermMonths; } set { _loanAmortizationTermMonths = value; } }
        private Value<string> _loanAmortizationType;
        public string LoanAmortizationType { get { return _loanAmortizationType; } set { _loanAmortizationType = value; } }
        private Value<string> _loanDocumentationType;
        public string LoanDocumentationType { get { return _loanDocumentationType; } set { _loanDocumentationType = value; } }
        private Value<string> _loanFeaturesPaymentFrequencyType;
        public string LoanFeaturesPaymentFrequencyType { get { return _loanFeaturesPaymentFrequencyType; } set { _loanFeaturesPaymentFrequencyType = value; } }
        private Value<string> _loanProgramName;
        public string LoanProgramName { get { return _loanProgramName; } set { _loanProgramName = value; } }
        private Value<string> _lockField;
        public string LockField { get { return _lockField; } set { _lockField = value; } }
        private Value<decimal?> _maxBackRatio;
        public decimal? MaxBackRatio { get { return _maxBackRatio; } set { _maxBackRatio = value; } }
        private Value<decimal?> _maxCltv;
        public decimal? MaxCltv { get { return _maxCltv; } set { _maxCltv = value; } }
        private Value<decimal?> _maxFrontRatio;
        public decimal? MaxFrontRatio { get { return _maxFrontRatio; } set { _maxFrontRatio = value; } }
        private Value<decimal?> _maximumBalance;
        public decimal? MaximumBalance { get { return _maximumBalance; } set { _maximumBalance = value; } }
        private Value<decimal?> _maxLoanAmount;
        public decimal? MaxLoanAmount { get { return _maxLoanAmount; } set { _maxLoanAmount = value; } }
        private Value<decimal?> _maxLtv;
        public decimal? MaxLtv { get { return _maxLtv; } set { _maxLtv = value; } }
        private Value<string> _meansAnEstimate;
        public string MeansAnEstimate { get { return _meansAnEstimate; } set { _meansAnEstimate = value; } }
        private Value<string> _miCalculationType;
        public string MiCalculationType { get { return _miCalculationType; } set { _miCalculationType = value; } }
        private Value<string> _midpointCancellation;
        public string MidpointCancellation { get { return _midpointCancellation; } set { _midpointCancellation = value; } }
        private Value<string> _minCreditScore;
        public string MinCreditScore { get { return _minCreditScore; } set { _minCreditScore = value; } }
        private Value<decimal?> _minimumAdvanceAmount;
        public decimal? MinimumAdvanceAmount { get { return _minimumAdvanceAmount; } set { _minimumAdvanceAmount = value; } }
        private Value<decimal?> _minimumAllowableApr;
        public decimal? MinimumAllowableApr { get { return _minimumAllowableApr; } set { _minimumAllowableApr = value; } }
        private Value<decimal?> _minimumPaymentAmount;
        public decimal? MinimumPaymentAmount { get { return _minimumPaymentAmount; } set { _minimumPaymentAmount = value; } }
        private Value<decimal?> _minimumPaymentPercent;
        public decimal? MinimumPaymentPercent { get { return _minimumPaymentPercent; } set { _minimumPaymentPercent = value; } }
        private Value<decimal?> _mipPaidInCash;
        public decimal? MipPaidInCash { get { return _mipPaidInCash; } set { _mipPaidInCash = value; } }
        private Value<string> _mmi;
        public string Mmi { get { return _mmi; } set { _mmi = value; } }
        private Value<decimal?> _mortgageInsuranceAdjustmentFactor1;
        public decimal? MortgageInsuranceAdjustmentFactor1 { get { return _mortgageInsuranceAdjustmentFactor1; } set { _mortgageInsuranceAdjustmentFactor1 = value; } }
        private Value<decimal?> _mortgageInsuranceAdjustmentFactor2;
        public decimal? MortgageInsuranceAdjustmentFactor2 { get { return _mortgageInsuranceAdjustmentFactor2; } set { _mortgageInsuranceAdjustmentFactor2 = value; } }
        private Value<decimal?> _mortgageInsuranceCancelPercent;
        public decimal? MortgageInsuranceCancelPercent { get { return _mortgageInsuranceCancelPercent; } set { _mortgageInsuranceCancelPercent = value; } }
        private Value<decimal?> _mortgageInsuranceMonthlyPayment1;
        public decimal? MortgageInsuranceMonthlyPayment1 { get { return _mortgageInsuranceMonthlyPayment1; } set { _mortgageInsuranceMonthlyPayment1 = value; } }
        private Value<decimal?> _mortgageInsuranceMonthlyPayment2;
        public decimal? MortgageInsuranceMonthlyPayment2 { get { return _mortgageInsuranceMonthlyPayment2; } set { _mortgageInsuranceMonthlyPayment2 = value; } }
        private Value<int?> _mortgageInsuranceMonthsOfAdjustment1;
        public int? MortgageInsuranceMonthsOfAdjustment1 { get { return _mortgageInsuranceMonthsOfAdjustment1; } set { _mortgageInsuranceMonthsOfAdjustment1 = value; } }
        private Value<int?> _mortgageInsuranceMonthsOfAdjustment2;
        public int? MortgageInsuranceMonthsOfAdjustment2 { get { return _mortgageInsuranceMonthsOfAdjustment2; } set { _mortgageInsuranceMonthsOfAdjustment2 = value; } }
        private Value<string> _mortgageType;
        public string MortgageType { get { return _mortgageType; } set { _mortgageType = value; } }
        private Value<string> _otherAmortizationTypeDescription;
        public string OtherAmortizationTypeDescription { get { return _otherAmortizationTypeDescription; } set { _otherAmortizationTypeDescription = value; } }
        private Value<string> _otherLoanPurposeDescription;
        public string OtherLoanPurposeDescription { get { return _otherLoanPurposeDescription; } set { _otherLoanPurposeDescription = value; } }
        private Value<string> _otherMortgageTypeDescription;
        public string OtherMortgageTypeDescription { get { return _otherMortgageTypeDescription; } set { _otherMortgageTypeDescription = value; } }
        private Value<int?> _paymentAdjustmentDurationMonths;
        public int? PaymentAdjustmentDurationMonths { get { return _paymentAdjustmentDurationMonths; } set { _paymentAdjustmentDurationMonths = value; } }
        private Value<decimal?> _paymentAdjustmentPeriodicCapPercent;
        public decimal? PaymentAdjustmentPeriodicCapPercent { get { return _paymentAdjustmentPeriodicCapPercent; } set { _paymentAdjustmentPeriodicCapPercent = value; } }
        private Value<decimal?> _paymentFactor;
        public decimal? PaymentFactor { get { return _paymentFactor; } set { _paymentFactor = value; } }
        private Value<decimal?> _percentageOfRental;
        public decimal? PercentageOfRental { get { return _percentageOfRental; } set { _percentageOfRental = value; } }
        private Value<string> _perDiemCalculationMethodType;
        public string PerDiemCalculationMethodType { get { return _perDiemCalculationMethodType; } set { _perDiemCalculationMethodType = value; } }
        private Value<string> _pmi;
        public string Pmi { get { return _pmi; } set { _pmi = value; } }
        private Value<string> _prepaymentPenaltyIndicator;
        public string PrepaymentPenaltyIndicator { get { return _prepaymentPenaltyIndicator; } set { _prepaymentPenaltyIndicator = value; } }
        private Value<string> _programCode;
        public string ProgramCode { get { return _programCode; } set { _programCode = value; } }
        private Value<string> _propertyInsurance;
        public string PropertyInsurance { get { return _propertyInsurance; } set { _propertyInsurance = value; } }
        private Value<string> _propertyUsageType;
        public string PropertyUsageType { get { return _propertyUsageType; } set { _propertyUsageType = value; } }
        private Value<decimal?> _qualifyingRatePercent;
        public decimal? QualifyingRatePercent { get { return _qualifyingRatePercent; } set { _qualifyingRatePercent = value; } }
        private Value<int?> _rateAdjustmentDurationMonths;
        public int? RateAdjustmentDurationMonths { get { return _rateAdjustmentDurationMonths; } set { _rateAdjustmentDurationMonths = value; } }
        private Value<decimal?> _rateAdjustmentLifetimeCapPercent;
        public decimal? RateAdjustmentLifetimeCapPercent { get { return _rateAdjustmentLifetimeCapPercent; } set { _rateAdjustmentLifetimeCapPercent = value; } }
        private Value<decimal?> _rateAdjustmentPercent;
        public decimal? RateAdjustmentPercent { get { return _rateAdjustmentPercent; } set { _rateAdjustmentPercent = value; } }
        private Value<decimal?> _rateAdjustmentSubsequentCapPercent;
        public decimal? RateAdjustmentSubsequentCapPercent { get { return _rateAdjustmentSubsequentCapPercent; } set { _rateAdjustmentSubsequentCapPercent = value; } }
        private Value<int?> _rateAdjustmentSubsequentRateAdjustmentMonths;
        public int? RateAdjustmentSubsequentRateAdjustmentMonths { get { return _rateAdjustmentSubsequentRateAdjustmentMonths; } set { _rateAdjustmentSubsequentRateAdjustmentMonths = value; } }
        private Value<int?> _recastPaidMonths;
        public int? RecastPaidMonths { get { return _recastPaidMonths; } set { _recastPaidMonths = value; } }
        private Value<int?> _recastStopMonths;
        public int? RecastStopMonths { get { return _recastStopMonths; } set { _recastStopMonths = value; } }
        private Value<string> _refundPaymentIndicator;
        public string RefundPaymentIndicator { get { return _refundPaymentIndicator; } set { _refundPaymentIndicator = value; } }
        private Value<decimal?> _requestedInterestRatePercent;
        public decimal? RequestedInterestRatePercent { get { return _requestedInterestRatePercent; } set { _requestedInterestRatePercent = value; } }
        private Value<string> _requiredDeposit;
        public string RequiredDeposit { get { return _requiredDeposit; } set { _requiredDeposit = value; } }
        private Value<decimal?> _roundPercent;
        public decimal? RoundPercent { get { return _roundPercent; } set { _roundPercent = value; } }
        private Value<string> _roundType;
        public string RoundType { get { return _roundType; } set { _roundType = value; } }
        private Value<string> _securityInterestInNameOf;
        public string SecurityInterestInNameOf { get { return _securityInterestInNameOf; } set { _securityInterestInNameOf = value; } }
        private Value<string> _securityType;
        public string SecurityType { get { return _securityType; } set { _securityType = value; } }
        private Value<decimal?> _subjectPropertyGrossRentalIncome;
        public decimal? SubjectPropertyGrossRentalIncome { get { return _subjectPropertyGrossRentalIncome; } set { _subjectPropertyGrossRentalIncome = value; } }
        private Value<decimal?> _teaserRate;
        public decimal? TeaserRate { get { return _teaserRate; } set { _teaserRate = value; } }
        private Value<decimal?> _terminationFeeAmount;
        public decimal? TerminationFeeAmount { get { return _terminationFeeAmount; } set { _terminationFeeAmount = value; } }
        private Value<int?> _terminationPeriodMonthsCount;
        public int? TerminationPeriodMonthsCount { get { return _terminationPeriodMonthsCount; } set { _terminationPeriodMonthsCount = value; } }
        private Value<decimal?> _thirdPartyFeeFrom;
        public decimal? ThirdPartyFeeFrom { get { return _thirdPartyFeeFrom; } set { _thirdPartyFeeFrom = value; } }
        private Value<decimal?> _thirdPartyFeeTo;
        public decimal? ThirdPartyFeeTo { get { return _thirdPartyFeeTo; } set { _thirdPartyFeeTo = value; } }
        private Value<string> _type;
        public string Type { get { return _type; } set { _type = value; } }
        private Value<string> _useDaysInYears;
        public string UseDaysInYears { get { return _useDaysInYears; } set { _useDaysInYears = value; } }
        private Value<string> _usePitiForRatio;
        public string UsePitiForRatio { get { return _usePitiForRatio; } set { _usePitiForRatio = value; } }
        private Value<string> _variableRateFeature;
        public string VariableRateFeature { get { return _variableRateFeature; } set { _variableRateFeature = value; } }
        private Value<decimal?> _yearlyTerm;
        public decimal? YearlyTerm { get { return _yearlyTerm; } set { _yearlyTerm = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _acquisition.Clean
                    && _additionalArmInformation.Clean
                    && _allDateAndNumericalDisclosures.Clean
                    && _annualFeeNeeded.Clean
                    && _armTypeDescription.Clean
                    && _assumptionOnYourProperty.Clean
                    && _balloonLoanMaturityTermMonths.Clean
                    && _buydownChangeFrequencyMonths1.Clean
                    && _buydownChangeFrequencyMonths2.Clean
                    && _buydownChangeFrequencyMonths3.Clean
                    && _buydownChangeFrequencyMonths4.Clean
                    && _buydownChangeFrequencyMonths5.Clean
                    && _buydownChangeFrequencyMonths6.Clean
                    && _buydownIncreaseRatePercent1.Clean
                    && _buydownIncreaseRatePercent2.Clean
                    && _buydownIncreaseRatePercent3.Clean
                    && _buydownIncreaseRatePercent4.Clean
                    && _buydownIncreaseRatePercent5.Clean
                    && _buydownIncreaseRatePercent6.Clean
                    && _calculateBasedOnRemainingBalance.Clean
                    && _closingCostProgram.Clean
                    && _constructionDescription.Clean
                    && _constructionInterestReserveAmount.Clean
                    && _constructionLoanMethod.Clean
                    && _constructionPeriodMonths.Clean
                    && _constructionRate.Clean
                    && _convertible.Clean
                    && _creditDisability.Clean
                    && _creditLifeInsurance.Clean
                    && _demandFeature.Clean
                    && _description.Clean
                    && _disclosureType.Clean
                    && _discounted.Clean
                    && _discountedRate.Clean
                    && _drawRepayPeriodTableName.Clean
                    && _fhaUpfrontMiPremiumPercent.Clean
                    && _floodInsurance.Clean
                    && _floorPercent.Clean
                    && _fundingFeePaidInCash.Clean
                    && _gpmExtraPaymentForEarlyPayOff.Clean
                    && _gpmRate.Clean
                    && _gpmYears.Clean
                    && _id.Clean
                    && _ifYouPurchase.Clean
                    && _ifYouPurchaseType.Clean
                    && _indexCurrentValuePercent.Clean
                    && _indexMarginPercent.Clean
                    && _initialAdvanceAmount.Clean
                    && _interestOnlyMonths.Clean
                    && _lateChargeDays.Clean
                    && _lateChargePercent.Clean
                    && _lateChargeType.Clean
                    && _lenderInvestorCode.Clean
                    && _lienPriorityType.Clean
                    && _loanAmortizationTermMonths.Clean
                    && _loanAmortizationType.Clean
                    && _loanDocumentationType.Clean
                    && _loanFeaturesPaymentFrequencyType.Clean
                    && _loanProgramName.Clean
                    && _lockField.Clean
                    && _maxBackRatio.Clean
                    && _maxCltv.Clean
                    && _maxFrontRatio.Clean
                    && _maximumBalance.Clean
                    && _maxLoanAmount.Clean
                    && _maxLtv.Clean
                    && _meansAnEstimate.Clean
                    && _miCalculationType.Clean
                    && _midpointCancellation.Clean
                    && _minCreditScore.Clean
                    && _minimumAdvanceAmount.Clean
                    && _minimumAllowableApr.Clean
                    && _minimumPaymentAmount.Clean
                    && _minimumPaymentPercent.Clean
                    && _mipPaidInCash.Clean
                    && _mmi.Clean
                    && _mortgageInsuranceAdjustmentFactor1.Clean
                    && _mortgageInsuranceAdjustmentFactor2.Clean
                    && _mortgageInsuranceCancelPercent.Clean
                    && _mortgageInsuranceMonthlyPayment1.Clean
                    && _mortgageInsuranceMonthlyPayment2.Clean
                    && _mortgageInsuranceMonthsOfAdjustment1.Clean
                    && _mortgageInsuranceMonthsOfAdjustment2.Clean
                    && _mortgageType.Clean
                    && _otherAmortizationTypeDescription.Clean
                    && _otherLoanPurposeDescription.Clean
                    && _otherMortgageTypeDescription.Clean
                    && _paymentAdjustmentDurationMonths.Clean
                    && _paymentAdjustmentPeriodicCapPercent.Clean
                    && _paymentFactor.Clean
                    && _percentageOfRental.Clean
                    && _perDiemCalculationMethodType.Clean
                    && _pmi.Clean
                    && _prepaymentPenaltyIndicator.Clean
                    && _programCode.Clean
                    && _propertyInsurance.Clean
                    && _propertyUsageType.Clean
                    && _qualifyingRatePercent.Clean
                    && _rateAdjustmentDurationMonths.Clean
                    && _rateAdjustmentLifetimeCapPercent.Clean
                    && _rateAdjustmentPercent.Clean
                    && _rateAdjustmentSubsequentCapPercent.Clean
                    && _rateAdjustmentSubsequentRateAdjustmentMonths.Clean
                    && _recastPaidMonths.Clean
                    && _recastStopMonths.Clean
                    && _refundPaymentIndicator.Clean
                    && _requestedInterestRatePercent.Clean
                    && _requiredDeposit.Clean
                    && _roundPercent.Clean
                    && _roundType.Clean
                    && _securityInterestInNameOf.Clean
                    && _securityType.Clean
                    && _subjectPropertyGrossRentalIncome.Clean
                    && _teaserRate.Clean
                    && _terminationFeeAmount.Clean
                    && _terminationPeriodMonthsCount.Clean
                    && _thirdPartyFeeFrom.Clean
                    && _thirdPartyFeeTo.Clean
                    && _type.Clean
                    && _useDaysInYears.Clean
                    && _usePitiForRatio.Clean
                    && _variableRateFeature.Clean
                    && _yearlyTerm.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var acquisition = _acquisition; acquisition.Clean = value; _acquisition = acquisition;
                var additionalArmInformation = _additionalArmInformation; additionalArmInformation.Clean = value; _additionalArmInformation = additionalArmInformation;
                var allDateAndNumericalDisclosures = _allDateAndNumericalDisclosures; allDateAndNumericalDisclosures.Clean = value; _allDateAndNumericalDisclosures = allDateAndNumericalDisclosures;
                var annualFeeNeeded = _annualFeeNeeded; annualFeeNeeded.Clean = value; _annualFeeNeeded = annualFeeNeeded;
                var armTypeDescription = _armTypeDescription; armTypeDescription.Clean = value; _armTypeDescription = armTypeDescription;
                var assumptionOnYourProperty = _assumptionOnYourProperty; assumptionOnYourProperty.Clean = value; _assumptionOnYourProperty = assumptionOnYourProperty;
                var balloonLoanMaturityTermMonths = _balloonLoanMaturityTermMonths; balloonLoanMaturityTermMonths.Clean = value; _balloonLoanMaturityTermMonths = balloonLoanMaturityTermMonths;
                var buydownChangeFrequencyMonths1 = _buydownChangeFrequencyMonths1; buydownChangeFrequencyMonths1.Clean = value; _buydownChangeFrequencyMonths1 = buydownChangeFrequencyMonths1;
                var buydownChangeFrequencyMonths2 = _buydownChangeFrequencyMonths2; buydownChangeFrequencyMonths2.Clean = value; _buydownChangeFrequencyMonths2 = buydownChangeFrequencyMonths2;
                var buydownChangeFrequencyMonths3 = _buydownChangeFrequencyMonths3; buydownChangeFrequencyMonths3.Clean = value; _buydownChangeFrequencyMonths3 = buydownChangeFrequencyMonths3;
                var buydownChangeFrequencyMonths4 = _buydownChangeFrequencyMonths4; buydownChangeFrequencyMonths4.Clean = value; _buydownChangeFrequencyMonths4 = buydownChangeFrequencyMonths4;
                var buydownChangeFrequencyMonths5 = _buydownChangeFrequencyMonths5; buydownChangeFrequencyMonths5.Clean = value; _buydownChangeFrequencyMonths5 = buydownChangeFrequencyMonths5;
                var buydownChangeFrequencyMonths6 = _buydownChangeFrequencyMonths6; buydownChangeFrequencyMonths6.Clean = value; _buydownChangeFrequencyMonths6 = buydownChangeFrequencyMonths6;
                var buydownIncreaseRatePercent1 = _buydownIncreaseRatePercent1; buydownIncreaseRatePercent1.Clean = value; _buydownIncreaseRatePercent1 = buydownIncreaseRatePercent1;
                var buydownIncreaseRatePercent2 = _buydownIncreaseRatePercent2; buydownIncreaseRatePercent2.Clean = value; _buydownIncreaseRatePercent2 = buydownIncreaseRatePercent2;
                var buydownIncreaseRatePercent3 = _buydownIncreaseRatePercent3; buydownIncreaseRatePercent3.Clean = value; _buydownIncreaseRatePercent3 = buydownIncreaseRatePercent3;
                var buydownIncreaseRatePercent4 = _buydownIncreaseRatePercent4; buydownIncreaseRatePercent4.Clean = value; _buydownIncreaseRatePercent4 = buydownIncreaseRatePercent4;
                var buydownIncreaseRatePercent5 = _buydownIncreaseRatePercent5; buydownIncreaseRatePercent5.Clean = value; _buydownIncreaseRatePercent5 = buydownIncreaseRatePercent5;
                var buydownIncreaseRatePercent6 = _buydownIncreaseRatePercent6; buydownIncreaseRatePercent6.Clean = value; _buydownIncreaseRatePercent6 = buydownIncreaseRatePercent6;
                var calculateBasedOnRemainingBalance = _calculateBasedOnRemainingBalance; calculateBasedOnRemainingBalance.Clean = value; _calculateBasedOnRemainingBalance = calculateBasedOnRemainingBalance;
                var closingCostProgram = _closingCostProgram; closingCostProgram.Clean = value; _closingCostProgram = closingCostProgram;
                var constructionDescription = _constructionDescription; constructionDescription.Clean = value; _constructionDescription = constructionDescription;
                var constructionInterestReserveAmount = _constructionInterestReserveAmount; constructionInterestReserveAmount.Clean = value; _constructionInterestReserveAmount = constructionInterestReserveAmount;
                var constructionLoanMethod = _constructionLoanMethod; constructionLoanMethod.Clean = value; _constructionLoanMethod = constructionLoanMethod;
                var constructionPeriodMonths = _constructionPeriodMonths; constructionPeriodMonths.Clean = value; _constructionPeriodMonths = constructionPeriodMonths;
                var constructionRate = _constructionRate; constructionRate.Clean = value; _constructionRate = constructionRate;
                var convertible = _convertible; convertible.Clean = value; _convertible = convertible;
                var creditDisability = _creditDisability; creditDisability.Clean = value; _creditDisability = creditDisability;
                var creditLifeInsurance = _creditLifeInsurance; creditLifeInsurance.Clean = value; _creditLifeInsurance = creditLifeInsurance;
                var demandFeature = _demandFeature; demandFeature.Clean = value; _demandFeature = demandFeature;
                var description = _description; description.Clean = value; _description = description;
                var disclosureType = _disclosureType; disclosureType.Clean = value; _disclosureType = disclosureType;
                var discounted = _discounted; discounted.Clean = value; _discounted = discounted;
                var discountedRate = _discountedRate; discountedRate.Clean = value; _discountedRate = discountedRate;
                var drawRepayPeriodTableName = _drawRepayPeriodTableName; drawRepayPeriodTableName.Clean = value; _drawRepayPeriodTableName = drawRepayPeriodTableName;
                var fhaUpfrontMiPremiumPercent = _fhaUpfrontMiPremiumPercent; fhaUpfrontMiPremiumPercent.Clean = value; _fhaUpfrontMiPremiumPercent = fhaUpfrontMiPremiumPercent;
                var floodInsurance = _floodInsurance; floodInsurance.Clean = value; _floodInsurance = floodInsurance;
                var floorPercent = _floorPercent; floorPercent.Clean = value; _floorPercent = floorPercent;
                var fundingFeePaidInCash = _fundingFeePaidInCash; fundingFeePaidInCash.Clean = value; _fundingFeePaidInCash = fundingFeePaidInCash;
                var gpmExtraPaymentForEarlyPayOff = _gpmExtraPaymentForEarlyPayOff; gpmExtraPaymentForEarlyPayOff.Clean = value; _gpmExtraPaymentForEarlyPayOff = gpmExtraPaymentForEarlyPayOff;
                var gpmRate = _gpmRate; gpmRate.Clean = value; _gpmRate = gpmRate;
                var gpmYears = _gpmYears; gpmYears.Clean = value; _gpmYears = gpmYears;
                var id = _id; id.Clean = value; _id = id;
                var ifYouPurchase = _ifYouPurchase; ifYouPurchase.Clean = value; _ifYouPurchase = ifYouPurchase;
                var ifYouPurchaseType = _ifYouPurchaseType; ifYouPurchaseType.Clean = value; _ifYouPurchaseType = ifYouPurchaseType;
                var indexCurrentValuePercent = _indexCurrentValuePercent; indexCurrentValuePercent.Clean = value; _indexCurrentValuePercent = indexCurrentValuePercent;
                var indexMarginPercent = _indexMarginPercent; indexMarginPercent.Clean = value; _indexMarginPercent = indexMarginPercent;
                var initialAdvanceAmount = _initialAdvanceAmount; initialAdvanceAmount.Clean = value; _initialAdvanceAmount = initialAdvanceAmount;
                var interestOnlyMonths = _interestOnlyMonths; interestOnlyMonths.Clean = value; _interestOnlyMonths = interestOnlyMonths;
                var lateChargeDays = _lateChargeDays; lateChargeDays.Clean = value; _lateChargeDays = lateChargeDays;
                var lateChargePercent = _lateChargePercent; lateChargePercent.Clean = value; _lateChargePercent = lateChargePercent;
                var lateChargeType = _lateChargeType; lateChargeType.Clean = value; _lateChargeType = lateChargeType;
                var lenderInvestorCode = _lenderInvestorCode; lenderInvestorCode.Clean = value; _lenderInvestorCode = lenderInvestorCode;
                var lienPriorityType = _lienPriorityType; lienPriorityType.Clean = value; _lienPriorityType = lienPriorityType;
                var loanAmortizationTermMonths = _loanAmortizationTermMonths; loanAmortizationTermMonths.Clean = value; _loanAmortizationTermMonths = loanAmortizationTermMonths;
                var loanAmortizationType = _loanAmortizationType; loanAmortizationType.Clean = value; _loanAmortizationType = loanAmortizationType;
                var loanDocumentationType = _loanDocumentationType; loanDocumentationType.Clean = value; _loanDocumentationType = loanDocumentationType;
                var loanFeaturesPaymentFrequencyType = _loanFeaturesPaymentFrequencyType; loanFeaturesPaymentFrequencyType.Clean = value; _loanFeaturesPaymentFrequencyType = loanFeaturesPaymentFrequencyType;
                var loanProgramName = _loanProgramName; loanProgramName.Clean = value; _loanProgramName = loanProgramName;
                var lockField = _lockField; lockField.Clean = value; _lockField = lockField;
                var maxBackRatio = _maxBackRatio; maxBackRatio.Clean = value; _maxBackRatio = maxBackRatio;
                var maxCltv = _maxCltv; maxCltv.Clean = value; _maxCltv = maxCltv;
                var maxFrontRatio = _maxFrontRatio; maxFrontRatio.Clean = value; _maxFrontRatio = maxFrontRatio;
                var maximumBalance = _maximumBalance; maximumBalance.Clean = value; _maximumBalance = maximumBalance;
                var maxLoanAmount = _maxLoanAmount; maxLoanAmount.Clean = value; _maxLoanAmount = maxLoanAmount;
                var maxLtv = _maxLtv; maxLtv.Clean = value; _maxLtv = maxLtv;
                var meansAnEstimate = _meansAnEstimate; meansAnEstimate.Clean = value; _meansAnEstimate = meansAnEstimate;
                var miCalculationType = _miCalculationType; miCalculationType.Clean = value; _miCalculationType = miCalculationType;
                var midpointCancellation = _midpointCancellation; midpointCancellation.Clean = value; _midpointCancellation = midpointCancellation;
                var minCreditScore = _minCreditScore; minCreditScore.Clean = value; _minCreditScore = minCreditScore;
                var minimumAdvanceAmount = _minimumAdvanceAmount; minimumAdvanceAmount.Clean = value; _minimumAdvanceAmount = minimumAdvanceAmount;
                var minimumAllowableApr = _minimumAllowableApr; minimumAllowableApr.Clean = value; _minimumAllowableApr = minimumAllowableApr;
                var minimumPaymentAmount = _minimumPaymentAmount; minimumPaymentAmount.Clean = value; _minimumPaymentAmount = minimumPaymentAmount;
                var minimumPaymentPercent = _minimumPaymentPercent; minimumPaymentPercent.Clean = value; _minimumPaymentPercent = minimumPaymentPercent;
                var mipPaidInCash = _mipPaidInCash; mipPaidInCash.Clean = value; _mipPaidInCash = mipPaidInCash;
                var mmi = _mmi; mmi.Clean = value; _mmi = mmi;
                var mortgageInsuranceAdjustmentFactor1 = _mortgageInsuranceAdjustmentFactor1; mortgageInsuranceAdjustmentFactor1.Clean = value; _mortgageInsuranceAdjustmentFactor1 = mortgageInsuranceAdjustmentFactor1;
                var mortgageInsuranceAdjustmentFactor2 = _mortgageInsuranceAdjustmentFactor2; mortgageInsuranceAdjustmentFactor2.Clean = value; _mortgageInsuranceAdjustmentFactor2 = mortgageInsuranceAdjustmentFactor2;
                var mortgageInsuranceCancelPercent = _mortgageInsuranceCancelPercent; mortgageInsuranceCancelPercent.Clean = value; _mortgageInsuranceCancelPercent = mortgageInsuranceCancelPercent;
                var mortgageInsuranceMonthlyPayment1 = _mortgageInsuranceMonthlyPayment1; mortgageInsuranceMonthlyPayment1.Clean = value; _mortgageInsuranceMonthlyPayment1 = mortgageInsuranceMonthlyPayment1;
                var mortgageInsuranceMonthlyPayment2 = _mortgageInsuranceMonthlyPayment2; mortgageInsuranceMonthlyPayment2.Clean = value; _mortgageInsuranceMonthlyPayment2 = mortgageInsuranceMonthlyPayment2;
                var mortgageInsuranceMonthsOfAdjustment1 = _mortgageInsuranceMonthsOfAdjustment1; mortgageInsuranceMonthsOfAdjustment1.Clean = value; _mortgageInsuranceMonthsOfAdjustment1 = mortgageInsuranceMonthsOfAdjustment1;
                var mortgageInsuranceMonthsOfAdjustment2 = _mortgageInsuranceMonthsOfAdjustment2; mortgageInsuranceMonthsOfAdjustment2.Clean = value; _mortgageInsuranceMonthsOfAdjustment2 = mortgageInsuranceMonthsOfAdjustment2;
                var mortgageType = _mortgageType; mortgageType.Clean = value; _mortgageType = mortgageType;
                var otherAmortizationTypeDescription = _otherAmortizationTypeDescription; otherAmortizationTypeDescription.Clean = value; _otherAmortizationTypeDescription = otherAmortizationTypeDescription;
                var otherLoanPurposeDescription = _otherLoanPurposeDescription; otherLoanPurposeDescription.Clean = value; _otherLoanPurposeDescription = otherLoanPurposeDescription;
                var otherMortgageTypeDescription = _otherMortgageTypeDescription; otherMortgageTypeDescription.Clean = value; _otherMortgageTypeDescription = otherMortgageTypeDescription;
                var paymentAdjustmentDurationMonths = _paymentAdjustmentDurationMonths; paymentAdjustmentDurationMonths.Clean = value; _paymentAdjustmentDurationMonths = paymentAdjustmentDurationMonths;
                var paymentAdjustmentPeriodicCapPercent = _paymentAdjustmentPeriodicCapPercent; paymentAdjustmentPeriodicCapPercent.Clean = value; _paymentAdjustmentPeriodicCapPercent = paymentAdjustmentPeriodicCapPercent;
                var paymentFactor = _paymentFactor; paymentFactor.Clean = value; _paymentFactor = paymentFactor;
                var percentageOfRental = _percentageOfRental; percentageOfRental.Clean = value; _percentageOfRental = percentageOfRental;
                var perDiemCalculationMethodType = _perDiemCalculationMethodType; perDiemCalculationMethodType.Clean = value; _perDiemCalculationMethodType = perDiemCalculationMethodType;
                var pmi = _pmi; pmi.Clean = value; _pmi = pmi;
                var prepaymentPenaltyIndicator = _prepaymentPenaltyIndicator; prepaymentPenaltyIndicator.Clean = value; _prepaymentPenaltyIndicator = prepaymentPenaltyIndicator;
                var programCode = _programCode; programCode.Clean = value; _programCode = programCode;
                var propertyInsurance = _propertyInsurance; propertyInsurance.Clean = value; _propertyInsurance = propertyInsurance;
                var propertyUsageType = _propertyUsageType; propertyUsageType.Clean = value; _propertyUsageType = propertyUsageType;
                var qualifyingRatePercent = _qualifyingRatePercent; qualifyingRatePercent.Clean = value; _qualifyingRatePercent = qualifyingRatePercent;
                var rateAdjustmentDurationMonths = _rateAdjustmentDurationMonths; rateAdjustmentDurationMonths.Clean = value; _rateAdjustmentDurationMonths = rateAdjustmentDurationMonths;
                var rateAdjustmentLifetimeCapPercent = _rateAdjustmentLifetimeCapPercent; rateAdjustmentLifetimeCapPercent.Clean = value; _rateAdjustmentLifetimeCapPercent = rateAdjustmentLifetimeCapPercent;
                var rateAdjustmentPercent = _rateAdjustmentPercent; rateAdjustmentPercent.Clean = value; _rateAdjustmentPercent = rateAdjustmentPercent;
                var rateAdjustmentSubsequentCapPercent = _rateAdjustmentSubsequentCapPercent; rateAdjustmentSubsequentCapPercent.Clean = value; _rateAdjustmentSubsequentCapPercent = rateAdjustmentSubsequentCapPercent;
                var rateAdjustmentSubsequentRateAdjustmentMonths = _rateAdjustmentSubsequentRateAdjustmentMonths; rateAdjustmentSubsequentRateAdjustmentMonths.Clean = value; _rateAdjustmentSubsequentRateAdjustmentMonths = rateAdjustmentSubsequentRateAdjustmentMonths;
                var recastPaidMonths = _recastPaidMonths; recastPaidMonths.Clean = value; _recastPaidMonths = recastPaidMonths;
                var recastStopMonths = _recastStopMonths; recastStopMonths.Clean = value; _recastStopMonths = recastStopMonths;
                var refundPaymentIndicator = _refundPaymentIndicator; refundPaymentIndicator.Clean = value; _refundPaymentIndicator = refundPaymentIndicator;
                var requestedInterestRatePercent = _requestedInterestRatePercent; requestedInterestRatePercent.Clean = value; _requestedInterestRatePercent = requestedInterestRatePercent;
                var requiredDeposit = _requiredDeposit; requiredDeposit.Clean = value; _requiredDeposit = requiredDeposit;
                var roundPercent = _roundPercent; roundPercent.Clean = value; _roundPercent = roundPercent;
                var roundType = _roundType; roundType.Clean = value; _roundType = roundType;
                var securityInterestInNameOf = _securityInterestInNameOf; securityInterestInNameOf.Clean = value; _securityInterestInNameOf = securityInterestInNameOf;
                var securityType = _securityType; securityType.Clean = value; _securityType = securityType;
                var subjectPropertyGrossRentalIncome = _subjectPropertyGrossRentalIncome; subjectPropertyGrossRentalIncome.Clean = value; _subjectPropertyGrossRentalIncome = subjectPropertyGrossRentalIncome;
                var teaserRate = _teaserRate; teaserRate.Clean = value; _teaserRate = teaserRate;
                var terminationFeeAmount = _terminationFeeAmount; terminationFeeAmount.Clean = value; _terminationFeeAmount = terminationFeeAmount;
                var terminationPeriodMonthsCount = _terminationPeriodMonthsCount; terminationPeriodMonthsCount.Clean = value; _terminationPeriodMonthsCount = terminationPeriodMonthsCount;
                var thirdPartyFeeFrom = _thirdPartyFeeFrom; thirdPartyFeeFrom.Clean = value; _thirdPartyFeeFrom = thirdPartyFeeFrom;
                var thirdPartyFeeTo = _thirdPartyFeeTo; thirdPartyFeeTo.Clean = value; _thirdPartyFeeTo = thirdPartyFeeTo;
                var type = _type; type.Clean = value; _type = type;
                var useDaysInYears = _useDaysInYears; useDaysInYears.Clean = value; _useDaysInYears = useDaysInYears;
                var usePitiForRatio = _usePitiForRatio; usePitiForRatio.Clean = value; _usePitiForRatio = usePitiForRatio;
                var variableRateFeature = _variableRateFeature; variableRateFeature.Clean = value; _variableRateFeature = variableRateFeature;
                var yearlyTerm = _yearlyTerm; yearlyTerm.Clean = value; _yearlyTerm = yearlyTerm;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public LoanProgram()
        {
            Clean = true;
        }
    }
}