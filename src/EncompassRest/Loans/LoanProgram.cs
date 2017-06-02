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
                var v0 = _acquisition; v0.Clean = value; _acquisition = v0;
                var v1 = _additionalArmInformation; v1.Clean = value; _additionalArmInformation = v1;
                var v2 = _allDateAndNumericalDisclosures; v2.Clean = value; _allDateAndNumericalDisclosures = v2;
                var v3 = _annualFeeNeeded; v3.Clean = value; _annualFeeNeeded = v3;
                var v4 = _armTypeDescription; v4.Clean = value; _armTypeDescription = v4;
                var v5 = _assumptionOnYourProperty; v5.Clean = value; _assumptionOnYourProperty = v5;
                var v6 = _balloonLoanMaturityTermMonths; v6.Clean = value; _balloonLoanMaturityTermMonths = v6;
                var v7 = _buydownChangeFrequencyMonths1; v7.Clean = value; _buydownChangeFrequencyMonths1 = v7;
                var v8 = _buydownChangeFrequencyMonths2; v8.Clean = value; _buydownChangeFrequencyMonths2 = v8;
                var v9 = _buydownChangeFrequencyMonths3; v9.Clean = value; _buydownChangeFrequencyMonths3 = v9;
                var v10 = _buydownChangeFrequencyMonths4; v10.Clean = value; _buydownChangeFrequencyMonths4 = v10;
                var v11 = _buydownChangeFrequencyMonths5; v11.Clean = value; _buydownChangeFrequencyMonths5 = v11;
                var v12 = _buydownChangeFrequencyMonths6; v12.Clean = value; _buydownChangeFrequencyMonths6 = v12;
                var v13 = _buydownIncreaseRatePercent1; v13.Clean = value; _buydownIncreaseRatePercent1 = v13;
                var v14 = _buydownIncreaseRatePercent2; v14.Clean = value; _buydownIncreaseRatePercent2 = v14;
                var v15 = _buydownIncreaseRatePercent3; v15.Clean = value; _buydownIncreaseRatePercent3 = v15;
                var v16 = _buydownIncreaseRatePercent4; v16.Clean = value; _buydownIncreaseRatePercent4 = v16;
                var v17 = _buydownIncreaseRatePercent5; v17.Clean = value; _buydownIncreaseRatePercent5 = v17;
                var v18 = _buydownIncreaseRatePercent6; v18.Clean = value; _buydownIncreaseRatePercent6 = v18;
                var v19 = _calculateBasedOnRemainingBalance; v19.Clean = value; _calculateBasedOnRemainingBalance = v19;
                var v20 = _closingCostProgram; v20.Clean = value; _closingCostProgram = v20;
                var v21 = _constructionDescription; v21.Clean = value; _constructionDescription = v21;
                var v22 = _constructionInterestReserveAmount; v22.Clean = value; _constructionInterestReserveAmount = v22;
                var v23 = _constructionLoanMethod; v23.Clean = value; _constructionLoanMethod = v23;
                var v24 = _constructionPeriodMonths; v24.Clean = value; _constructionPeriodMonths = v24;
                var v25 = _constructionRate; v25.Clean = value; _constructionRate = v25;
                var v26 = _convertible; v26.Clean = value; _convertible = v26;
                var v27 = _creditDisability; v27.Clean = value; _creditDisability = v27;
                var v28 = _creditLifeInsurance; v28.Clean = value; _creditLifeInsurance = v28;
                var v29 = _demandFeature; v29.Clean = value; _demandFeature = v29;
                var v30 = _description; v30.Clean = value; _description = v30;
                var v31 = _disclosureType; v31.Clean = value; _disclosureType = v31;
                var v32 = _discounted; v32.Clean = value; _discounted = v32;
                var v33 = _discountedRate; v33.Clean = value; _discountedRate = v33;
                var v34 = _drawRepayPeriodTableName; v34.Clean = value; _drawRepayPeriodTableName = v34;
                var v35 = _fhaUpfrontMiPremiumPercent; v35.Clean = value; _fhaUpfrontMiPremiumPercent = v35;
                var v36 = _floodInsurance; v36.Clean = value; _floodInsurance = v36;
                var v37 = _floorPercent; v37.Clean = value; _floorPercent = v37;
                var v38 = _fundingFeePaidInCash; v38.Clean = value; _fundingFeePaidInCash = v38;
                var v39 = _gpmExtraPaymentForEarlyPayOff; v39.Clean = value; _gpmExtraPaymentForEarlyPayOff = v39;
                var v40 = _gpmRate; v40.Clean = value; _gpmRate = v40;
                var v41 = _gpmYears; v41.Clean = value; _gpmYears = v41;
                var v42 = _id; v42.Clean = value; _id = v42;
                var v43 = _ifYouPurchase; v43.Clean = value; _ifYouPurchase = v43;
                var v44 = _ifYouPurchaseType; v44.Clean = value; _ifYouPurchaseType = v44;
                var v45 = _indexCurrentValuePercent; v45.Clean = value; _indexCurrentValuePercent = v45;
                var v46 = _indexMarginPercent; v46.Clean = value; _indexMarginPercent = v46;
                var v47 = _initialAdvanceAmount; v47.Clean = value; _initialAdvanceAmount = v47;
                var v48 = _interestOnlyMonths; v48.Clean = value; _interestOnlyMonths = v48;
                var v49 = _lateChargeDays; v49.Clean = value; _lateChargeDays = v49;
                var v50 = _lateChargePercent; v50.Clean = value; _lateChargePercent = v50;
                var v51 = _lateChargeType; v51.Clean = value; _lateChargeType = v51;
                var v52 = _lenderInvestorCode; v52.Clean = value; _lenderInvestorCode = v52;
                var v53 = _lienPriorityType; v53.Clean = value; _lienPriorityType = v53;
                var v54 = _loanAmortizationTermMonths; v54.Clean = value; _loanAmortizationTermMonths = v54;
                var v55 = _loanAmortizationType; v55.Clean = value; _loanAmortizationType = v55;
                var v56 = _loanDocumentationType; v56.Clean = value; _loanDocumentationType = v56;
                var v57 = _loanFeaturesPaymentFrequencyType; v57.Clean = value; _loanFeaturesPaymentFrequencyType = v57;
                var v58 = _loanProgramName; v58.Clean = value; _loanProgramName = v58;
                var v59 = _lockField; v59.Clean = value; _lockField = v59;
                var v60 = _maxBackRatio; v60.Clean = value; _maxBackRatio = v60;
                var v61 = _maxCltv; v61.Clean = value; _maxCltv = v61;
                var v62 = _maxFrontRatio; v62.Clean = value; _maxFrontRatio = v62;
                var v63 = _maximumBalance; v63.Clean = value; _maximumBalance = v63;
                var v64 = _maxLoanAmount; v64.Clean = value; _maxLoanAmount = v64;
                var v65 = _maxLtv; v65.Clean = value; _maxLtv = v65;
                var v66 = _meansAnEstimate; v66.Clean = value; _meansAnEstimate = v66;
                var v67 = _miCalculationType; v67.Clean = value; _miCalculationType = v67;
                var v68 = _midpointCancellation; v68.Clean = value; _midpointCancellation = v68;
                var v69 = _minCreditScore; v69.Clean = value; _minCreditScore = v69;
                var v70 = _minimumAdvanceAmount; v70.Clean = value; _minimumAdvanceAmount = v70;
                var v71 = _minimumAllowableApr; v71.Clean = value; _minimumAllowableApr = v71;
                var v72 = _minimumPaymentAmount; v72.Clean = value; _minimumPaymentAmount = v72;
                var v73 = _minimumPaymentPercent; v73.Clean = value; _minimumPaymentPercent = v73;
                var v74 = _mipPaidInCash; v74.Clean = value; _mipPaidInCash = v74;
                var v75 = _mmi; v75.Clean = value; _mmi = v75;
                var v76 = _mortgageInsuranceAdjustmentFactor1; v76.Clean = value; _mortgageInsuranceAdjustmentFactor1 = v76;
                var v77 = _mortgageInsuranceAdjustmentFactor2; v77.Clean = value; _mortgageInsuranceAdjustmentFactor2 = v77;
                var v78 = _mortgageInsuranceCancelPercent; v78.Clean = value; _mortgageInsuranceCancelPercent = v78;
                var v79 = _mortgageInsuranceMonthlyPayment1; v79.Clean = value; _mortgageInsuranceMonthlyPayment1 = v79;
                var v80 = _mortgageInsuranceMonthlyPayment2; v80.Clean = value; _mortgageInsuranceMonthlyPayment2 = v80;
                var v81 = _mortgageInsuranceMonthsOfAdjustment1; v81.Clean = value; _mortgageInsuranceMonthsOfAdjustment1 = v81;
                var v82 = _mortgageInsuranceMonthsOfAdjustment2; v82.Clean = value; _mortgageInsuranceMonthsOfAdjustment2 = v82;
                var v83 = _mortgageType; v83.Clean = value; _mortgageType = v83;
                var v84 = _otherAmortizationTypeDescription; v84.Clean = value; _otherAmortizationTypeDescription = v84;
                var v85 = _otherLoanPurposeDescription; v85.Clean = value; _otherLoanPurposeDescription = v85;
                var v86 = _otherMortgageTypeDescription; v86.Clean = value; _otherMortgageTypeDescription = v86;
                var v87 = _paymentAdjustmentDurationMonths; v87.Clean = value; _paymentAdjustmentDurationMonths = v87;
                var v88 = _paymentAdjustmentPeriodicCapPercent; v88.Clean = value; _paymentAdjustmentPeriodicCapPercent = v88;
                var v89 = _paymentFactor; v89.Clean = value; _paymentFactor = v89;
                var v90 = _percentageOfRental; v90.Clean = value; _percentageOfRental = v90;
                var v91 = _perDiemCalculationMethodType; v91.Clean = value; _perDiemCalculationMethodType = v91;
                var v92 = _pmi; v92.Clean = value; _pmi = v92;
                var v93 = _prepaymentPenaltyIndicator; v93.Clean = value; _prepaymentPenaltyIndicator = v93;
                var v94 = _programCode; v94.Clean = value; _programCode = v94;
                var v95 = _propertyInsurance; v95.Clean = value; _propertyInsurance = v95;
                var v96 = _propertyUsageType; v96.Clean = value; _propertyUsageType = v96;
                var v97 = _qualifyingRatePercent; v97.Clean = value; _qualifyingRatePercent = v97;
                var v98 = _rateAdjustmentDurationMonths; v98.Clean = value; _rateAdjustmentDurationMonths = v98;
                var v99 = _rateAdjustmentLifetimeCapPercent; v99.Clean = value; _rateAdjustmentLifetimeCapPercent = v99;
                var v100 = _rateAdjustmentPercent; v100.Clean = value; _rateAdjustmentPercent = v100;
                var v101 = _rateAdjustmentSubsequentCapPercent; v101.Clean = value; _rateAdjustmentSubsequentCapPercent = v101;
                var v102 = _rateAdjustmentSubsequentRateAdjustmentMonths; v102.Clean = value; _rateAdjustmentSubsequentRateAdjustmentMonths = v102;
                var v103 = _recastPaidMonths; v103.Clean = value; _recastPaidMonths = v103;
                var v104 = _recastStopMonths; v104.Clean = value; _recastStopMonths = v104;
                var v105 = _refundPaymentIndicator; v105.Clean = value; _refundPaymentIndicator = v105;
                var v106 = _requestedInterestRatePercent; v106.Clean = value; _requestedInterestRatePercent = v106;
                var v107 = _requiredDeposit; v107.Clean = value; _requiredDeposit = v107;
                var v108 = _roundPercent; v108.Clean = value; _roundPercent = v108;
                var v109 = _roundType; v109.Clean = value; _roundType = v109;
                var v110 = _securityInterestInNameOf; v110.Clean = value; _securityInterestInNameOf = v110;
                var v111 = _securityType; v111.Clean = value; _securityType = v111;
                var v112 = _subjectPropertyGrossRentalIncome; v112.Clean = value; _subjectPropertyGrossRentalIncome = v112;
                var v113 = _teaserRate; v113.Clean = value; _teaserRate = v113;
                var v114 = _terminationFeeAmount; v114.Clean = value; _terminationFeeAmount = v114;
                var v115 = _terminationPeriodMonthsCount; v115.Clean = value; _terminationPeriodMonthsCount = v115;
                var v116 = _thirdPartyFeeFrom; v116.Clean = value; _thirdPartyFeeFrom = v116;
                var v117 = _thirdPartyFeeTo; v117.Clean = value; _thirdPartyFeeTo = v117;
                var v118 = _type; v118.Clean = value; _type = v118;
                var v119 = _useDaysInYears; v119.Clean = value; _useDaysInYears = v119;
                var v120 = _usePitiForRatio; v120.Clean = value; _usePitiForRatio = v120;
                var v121 = _variableRateFeature; v121.Clean = value; _variableRateFeature = v121;
                var v122 = _yearlyTerm; v122.Clean = value; _yearlyTerm = v122;
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