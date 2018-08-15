using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LoanProgram
    /// </summary>
    public sealed partial class LoanProgram : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<YOrN>> _acquisition;
        /// <summary>
        /// LoanProgram Acquisition [LPNN113]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<YOrN> Acquisition { get => _acquisition; set => SetField(ref _acquisition, value); }
        private DirtyValue<string> _additionalArmInformation;
        /// <summary>
        /// LoanProgram AdditionalArmInformation [LPNN67]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AdditionalArmInformation { get => _additionalArmInformation; set => SetField(ref _additionalArmInformation, value); }
        private DirtyValue<string> _allDateAndNumericalDisclosures;
        /// <summary>
        /// LoanProgram AllDateAndNumericalDisclosures [LPNN82]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AllDateAndNumericalDisclosures { get => _allDateAndNumericalDisclosures; set => SetField(ref _allDateAndNumericalDisclosures, value); }
        private DirtyValue<decimal?> _annualFeeNeeded;
        /// <summary>
        /// LoanProgram AnnualFeeNeeded [LPNN115]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? AnnualFeeNeeded { get => _annualFeeNeeded; set => SetField(ref _annualFeeNeeded, value); }
        private DirtyValue<string> _armTypeDescription;
        /// <summary>
        /// LoanProgram ArmTypeDescription [LPNN86]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ArmTypeDescription { get => _armTypeDescription; set => SetField(ref _armTypeDescription, value); }
        private DirtyValue<string> _assumptionOnYourProperty;
        /// <summary>
        /// LoanProgram AssumptionOnYourProperty [LPNN75]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AssumptionOnYourProperty { get => _assumptionOnYourProperty; set => SetField(ref _assumptionOnYourProperty, value); }
        private DirtyValue<int?> _balloonLoanMaturityTermMonths;
        /// <summary>
        /// LoanProgram BalloonLoanMaturityTermMonths [LPNN11]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BalloonLoanMaturityTermMonths { get => _balloonLoanMaturityTermMonths; set => SetField(ref _balloonLoanMaturityTermMonths, value); }
        private DirtyValue<int?> _buydownChangeFrequencyMonths1;
        /// <summary>
        /// LoanProgram BuydownChangeFrequencyMonths1 [LPNN13]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BuydownChangeFrequencyMonths1 { get => _buydownChangeFrequencyMonths1; set => SetField(ref _buydownChangeFrequencyMonths1, value); }
        private DirtyValue<int?> _buydownChangeFrequencyMonths2;
        /// <summary>
        /// LoanProgram BuydownChangeFrequencyMonths2 [LPNN15]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BuydownChangeFrequencyMonths2 { get => _buydownChangeFrequencyMonths2; set => SetField(ref _buydownChangeFrequencyMonths2, value); }
        private DirtyValue<int?> _buydownChangeFrequencyMonths3;
        /// <summary>
        /// LoanProgram BuydownChangeFrequencyMonths3 [LPNN17]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BuydownChangeFrequencyMonths3 { get => _buydownChangeFrequencyMonths3; set => SetField(ref _buydownChangeFrequencyMonths3, value); }
        private DirtyValue<int?> _buydownChangeFrequencyMonths4;
        /// <summary>
        /// LoanProgram BuydownChangeFrequencyMonths4 [LPNN19]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BuydownChangeFrequencyMonths4 { get => _buydownChangeFrequencyMonths4; set => SetField(ref _buydownChangeFrequencyMonths4, value); }
        private DirtyValue<int?> _buydownChangeFrequencyMonths5;
        /// <summary>
        /// LoanProgram BuydownChangeFrequencyMonths5 [LPNN21]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BuydownChangeFrequencyMonths5 { get => _buydownChangeFrequencyMonths5; set => SetField(ref _buydownChangeFrequencyMonths5, value); }
        private DirtyValue<int?> _buydownChangeFrequencyMonths6;
        /// <summary>
        /// LoanProgram BuydownChangeFrequencyMonths6 [LPNN23]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BuydownChangeFrequencyMonths6 { get => _buydownChangeFrequencyMonths6; set => SetField(ref _buydownChangeFrequencyMonths6, value); }
        private DirtyValue<decimal?> _buydownIncreaseRatePercent1;
        /// <summary>
        /// LoanProgram BuydownIncreaseRatePercent1 [LPNN12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? BuydownIncreaseRatePercent1 { get => _buydownIncreaseRatePercent1; set => SetField(ref _buydownIncreaseRatePercent1, value); }
        private DirtyValue<decimal?> _buydownIncreaseRatePercent2;
        /// <summary>
        /// LoanProgram BuydownIncreaseRatePercent2 [LPNN14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? BuydownIncreaseRatePercent2 { get => _buydownIncreaseRatePercent2; set => SetField(ref _buydownIncreaseRatePercent2, value); }
        private DirtyValue<decimal?> _buydownIncreaseRatePercent3;
        /// <summary>
        /// LoanProgram BuydownIncreaseRatePercent3 [LPNN16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? BuydownIncreaseRatePercent3 { get => _buydownIncreaseRatePercent3; set => SetField(ref _buydownIncreaseRatePercent3, value); }
        private DirtyValue<decimal?> _buydownIncreaseRatePercent4;
        /// <summary>
        /// LoanProgram BuydownIncreaseRatePercent4 [LPNN18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? BuydownIncreaseRatePercent4 { get => _buydownIncreaseRatePercent4; set => SetField(ref _buydownIncreaseRatePercent4, value); }
        private DirtyValue<decimal?> _buydownIncreaseRatePercent5;
        /// <summary>
        /// LoanProgram BuydownIncreaseRatePercent5 [LPNN20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? BuydownIncreaseRatePercent5 { get => _buydownIncreaseRatePercent5; set => SetField(ref _buydownIncreaseRatePercent5, value); }
        private DirtyValue<decimal?> _buydownIncreaseRatePercent6;
        /// <summary>
        /// LoanProgram BuydownIncreaseRatePercent6 [LPNN22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? BuydownIncreaseRatePercent6 { get => _buydownIncreaseRatePercent6; set => SetField(ref _buydownIncreaseRatePercent6, value); }
        private DirtyValue<string> _calculateBasedOnRemainingBalance;
        /// <summary>
        /// LoanProgram CalculateBasedOnRemainingBalance [LPNN99]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CalculateBasedOnRemainingBalance { get => _calculateBasedOnRemainingBalance; set => SetField(ref _calculateBasedOnRemainingBalance, value); }
        private DirtyValue<string> _closingCostProgram;
        /// <summary>
        /// LoanProgram ClosingCostProgram [LPNN97]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ClosingCostProgram { get => _closingCostProgram; set => SetField(ref _closingCostProgram, value); }
        private DirtyValue<string> _constructionDescription;
        /// <summary>
        /// LoanProgram ConstructionDescription [LPNN56]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ConstructionDescription { get => _constructionDescription; set => SetField(ref _constructionDescription, value); }
        private DirtyValue<decimal?> _constructionInterestReserveAmount;
        /// <summary>
        /// LoanProgram ConstructionInterestReserveAmount [LPNN55]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? ConstructionInterestReserveAmount { get => _constructionInterestReserveAmount; set => SetField(ref _constructionInterestReserveAmount, value); }
        private DirtyValue<string> _constructionLoanMethod;
        /// <summary>
        /// LoanProgram ConstructionLoanMethod [LPNN112]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ConstructionLoanMethod { get => _constructionLoanMethod; set => SetField(ref _constructionLoanMethod, value); }
        private DirtyValue<int?> _constructionPeriodMonths;
        /// <summary>
        /// LoanProgram ConstructionPeriodMonths [LPNN53]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? ConstructionPeriodMonths { get => _constructionPeriodMonths; set => SetField(ref _constructionPeriodMonths, value); }
        private DirtyValue<decimal?> _constructionRate;
        /// <summary>
        /// LoanProgram ConstructionRate [LPNN54]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? ConstructionRate { get => _constructionRate; set => SetField(ref _constructionRate, value); }
        private DirtyValue<string> _convertible;
        /// <summary>
        /// LoanProgram Convertible [LPNN79]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string Convertible { get => _convertible; set => SetField(ref _convertible, value); }
        private DirtyValue<string> _creditDisability;
        /// <summary>
        /// LoanProgram CreditDisability [LPNN90]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CreditDisability { get => _creditDisability; set => SetField(ref _creditDisability, value); }
        private DirtyValue<string> _creditLifeInsurance;
        /// <summary>
        /// LoanProgram CreditLifeInsurance [LPNN89]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CreditLifeInsurance { get => _creditLifeInsurance; set => SetField(ref _creditLifeInsurance, value); }
        private DirtyValue<string> _demandFeature;
        /// <summary>
        /// LoanProgram DemandFeature [LPNN65]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string DemandFeature { get => _demandFeature; set => SetField(ref _demandFeature, value); }
        private DirtyValue<string> _description;
        /// <summary>
        /// LoanProgram Description [LPNN88]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string Description { get => _description; set => SetField(ref _description, value); }
        private DirtyValue<string> _disclosureType;
        /// <summary>
        /// LoanProgram DisclosureType [LPNN110]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string DisclosureType { get => _disclosureType; set => SetField(ref _disclosureType, value); }
        private DirtyValue<string> _discounted;
        /// <summary>
        /// LoanProgram Discounted [LPNN123]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string Discounted { get => _discounted; set => SetField(ref _discounted, value); }
        private DirtyValue<decimal?> _discountedRate;
        /// <summary>
        /// LoanProgram DiscountedRate [LPNN124]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? DiscountedRate { get => _discountedRate; set => SetField(ref _discountedRate, value); }
        private DirtyValue<string> _drawRepayPeriodTableName;
        /// <summary>
        /// LoanProgram DrawRepayPeriodTableName [LPNN125]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string DrawRepayPeriodTableName { get => _drawRepayPeriodTableName; set => SetField(ref _drawRepayPeriodTableName, value); }
        private DirtyValue<decimal?> _fhaUpfrontMiPremiumPercent;
        /// <summary>
        /// LoanProgram FhaUpfrontMiPremiumPercent [LPNN101]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? FhaUpfrontMiPremiumPercent { get => _fhaUpfrontMiPremiumPercent; set => SetField(ref _fhaUpfrontMiPremiumPercent, value); }
        private DirtyValue<string> _floodInsurance;
        /// <summary>
        /// LoanProgram FloodInsurance [LPNN92]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string FloodInsurance { get => _floodInsurance; set => SetField(ref _floodInsurance, value); }
        private DirtyValue<decimal?> _floorPercent;
        /// <summary>
        /// LoanProgram FloorPercent [LPNN33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? FloorPercent { get => _floorPercent; set => SetField(ref _floorPercent, value); }
        private DirtyValue<decimal?> _fundingFeePaidInCash;
        /// <summary>
        /// LoanProgram FundingFeePaidInCash [LPNN104]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? FundingFeePaidInCash { get => _fundingFeePaidInCash; set => SetField(ref _fundingFeePaidInCash, value); }
        private DirtyValue<decimal?> _gpmExtraPaymentForEarlyPayOff;
        /// <summary>
        /// LoanProgram GpmExtraPaymentForEarlyPayOff [LPNN43]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? GpmExtraPaymentForEarlyPayOff { get => _gpmExtraPaymentForEarlyPayOff; set => SetField(ref _gpmExtraPaymentForEarlyPayOff, value); }
        private DirtyValue<decimal?> _gpmRate;
        /// <summary>
        /// LoanProgram GpmRate [LPNN41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? GpmRate { get => _gpmRate; set => SetField(ref _gpmRate, value); }
        private DirtyValue<int?> _gpmYears;
        /// <summary>
        /// LoanProgram GpmYears [LPNN42]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? GpmYears { get => _gpmYears; set => SetField(ref _gpmYears, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// LoanProgram Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _ifYouPurchase;
        /// <summary>
        /// LoanProgram IfYouPurchase [LPNN93]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string IfYouPurchase { get => _ifYouPurchase; set => SetField(ref _ifYouPurchase, value); }
        private DirtyValue<string> _ifYouPurchaseType;
        /// <summary>
        /// LoanProgram IfYouPurchaseType [LPNN94]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string IfYouPurchaseType { get => _ifYouPurchaseType; set => SetField(ref _ifYouPurchaseType, value); }
        private DirtyValue<decimal?> _indexCurrentValuePercent;
        /// <summary>
        /// LoanProgram IndexCurrentValuePercent [LPNN32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? IndexCurrentValuePercent { get => _indexCurrentValuePercent; set => SetField(ref _indexCurrentValuePercent, value); }
        private DirtyValue<decimal?> _indexMarginPercent;
        /// <summary>
        /// LoanProgram IndexMarginPercent [LPNN31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? IndexMarginPercent { get => _indexMarginPercent; set => SetField(ref _indexMarginPercent, value); }
        private DirtyValue<decimal?> _initialAdvanceAmount;
        /// <summary>
        /// LoanProgram InitialAdvanceAmount [LPNN114]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? InitialAdvanceAmount { get => _initialAdvanceAmount; set => SetField(ref _initialAdvanceAmount, value); }
        private DirtyValue<int?> _interestOnlyMonths;
        /// <summary>
        /// LoanProgram InterestOnlyMonths [LPNN25]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? InterestOnlyMonths { get => _interestOnlyMonths; set => SetField(ref _interestOnlyMonths, value); }
        private DirtyValue<int?> _lateChargeDays;
        /// <summary>
        /// LoanProgram LateChargeDays [LPNN72]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? LateChargeDays { get => _lateChargeDays; set => SetField(ref _lateChargeDays, value); }
        private DirtyValue<decimal?> _lateChargePercent;
        /// <summary>
        /// LoanProgram LateChargePercent [LPNN73]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? LateChargePercent { get => _lateChargePercent; set => SetField(ref _lateChargePercent, value); }
        private DirtyValue<string> _lateChargeType;
        /// <summary>
        /// LoanProgram LateChargeType [LPNN74]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LateChargeType { get => _lateChargeType; set => SetField(ref _lateChargeType, value); }
        private DirtyValue<string> _lenderInvestorCode;
        /// <summary>
        /// LoanProgram LenderInvestorCode [LPNN51]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LenderInvestorCode { get => _lenderInvestorCode; set => SetField(ref _lenderInvestorCode, value); }
        private DirtyValue<string> _lienPriorityType;
        /// <summary>
        /// LoanProgram LienPriorityType [LPNN03]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LienPriorityType { get => _lienPriorityType; set => SetField(ref _lienPriorityType, value); }
        private DirtyValue<int?> _loanAmortizationTermMonths;
        /// <summary>
        /// LoanProgram LoanAmortizationTermMonths [LPNN10]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? LoanAmortizationTermMonths { get => _loanAmortizationTermMonths; set => SetField(ref _loanAmortizationTermMonths, value); }
        private DirtyValue<string> _loanAmortizationType;
        /// <summary>
        /// LoanProgram LoanAmortizationType [LPNN07]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LoanAmortizationType { get => _loanAmortizationType; set => SetField(ref _loanAmortizationType, value); }
        private DirtyValue<string> _loanDocumentationType;
        /// <summary>
        /// LoanProgram LoanDocumentationType [LPNN107]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LoanDocumentationType { get => _loanDocumentationType; set => SetField(ref _loanDocumentationType, value); }
        private DirtyValue<string> _loanFeaturesPaymentFrequencyType;
        /// <summary>
        /// LoanProgram LoanFeaturesPaymentFrequencyType [LPNN24]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LoanFeaturesPaymentFrequencyType { get => _loanFeaturesPaymentFrequencyType; set => SetField(ref _loanFeaturesPaymentFrequencyType, value); }
        private DirtyValue<string> _loanProgramName;
        /// <summary>
        /// LoanProgram LoanProgramName [LPNN44]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LoanProgramName { get => _loanProgramName; set => SetField(ref _loanProgramName, value); }
        private DirtyValue<StringEnumValue<YOrN>> _lockField;
        /// <summary>
        /// LoanProgram LockField [LPNN102]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<YOrN> LockField { get => _lockField; set => SetField(ref _lockField, value); }
        private DirtyValue<decimal?> _maxBackRatio;
        /// <summary>
        /// LoanProgram MaxBackRatio [LPNN50]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MaxBackRatio { get => _maxBackRatio; set => SetField(ref _maxBackRatio, value); }
        private DirtyValue<decimal?> _maxCltv;
        /// <summary>
        /// LoanProgram MaxCltv [LPNN47]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MaxCltv { get => _maxCltv; set => SetField(ref _maxCltv, value); }
        private DirtyValue<decimal?> _maxFrontRatio;
        /// <summary>
        /// LoanProgram MaxFrontRatio [LPNN49]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MaxFrontRatio { get => _maxFrontRatio; set => SetField(ref _maxFrontRatio, value); }
        private DirtyValue<decimal?> _maximumBalance;
        /// <summary>
        /// LoanProgram MaximumBalance [LPNN40]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MaximumBalance { get => _maximumBalance; set => SetField(ref _maximumBalance, value); }
        private DirtyValue<decimal?> _maxLoanAmount;
        /// <summary>
        /// LoanProgram MaxLoanAmount [LPNN45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MaxLoanAmount { get => _maxLoanAmount; set => SetField(ref _maxLoanAmount, value); }
        private DirtyValue<decimal?> _maxLtv;
        /// <summary>
        /// LoanProgram MaxLtv [LPNN46]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MaxLtv { get => _maxLtv; set => SetField(ref _maxLtv, value); }
        private DirtyValue<string> _meansAnEstimate;
        /// <summary>
        /// LoanProgram MeansAnEstimate [LPNN81]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MeansAnEstimate { get => _meansAnEstimate; set => SetField(ref _meansAnEstimate, value); }
        private DirtyValue<string> _miCalculationType;
        /// <summary>
        /// LoanProgram MiCalculationType [LPNN100]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MiCalculationType { get => _miCalculationType; set => SetField(ref _miCalculationType, value); }
        private DirtyValue<string> _midpointCancellation;
        /// <summary>
        /// LoanProgram MidpointCancellation [LPNN98]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MidpointCancellation { get => _midpointCancellation; set => SetField(ref _midpointCancellation, value); }
        private DirtyValue<string> _minCreditScore;
        /// <summary>
        /// LoanProgram MinCreditScore [LPNN48]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MinCreditScore { get => _minCreditScore; set => SetField(ref _minCreditScore, value); }
        private DirtyValue<decimal?> _minimumAdvanceAmount;
        /// <summary>
        /// LoanProgram MinimumAdvanceAmount [LPNN119]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MinimumAdvanceAmount { get => _minimumAdvanceAmount; set => SetField(ref _minimumAdvanceAmount, value); }
        private DirtyValue<decimal?> _minimumAllowableApr;
        /// <summary>
        /// LoanProgram MinimumAllowableApr [LPNN120]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MinimumAllowableApr { get => _minimumAllowableApr; set => SetField(ref _minimumAllowableApr, value); }
        private DirtyValue<decimal?> _minimumPaymentAmount;
        /// <summary>
        /// LoanProgram MinimumPaymentAmount [LPNN122]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MinimumPaymentAmount { get => _minimumPaymentAmount; set => SetField(ref _minimumPaymentAmount, value); }
        private DirtyValue<decimal?> _minimumPaymentPercent;
        /// <summary>
        /// LoanProgram MinimumPaymentPercent [LPNN121]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MinimumPaymentPercent { get => _minimumPaymentPercent; set => SetField(ref _minimumPaymentPercent, value); }
        private DirtyValue<decimal?> _mipPaidInCash;
        /// <summary>
        /// LoanProgram MipPaidInCash [LPNN103]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MipPaidInCash { get => _mipPaidInCash; set => SetField(ref _mipPaidInCash, value); }
        private DirtyValue<StringEnumValue<YOrN>> _mmi;
        /// <summary>
        /// LoanProgram Mmi [LPNN108]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<YOrN> Mmi { get => _mmi; set => SetField(ref _mmi, value); }
        private DirtyValue<decimal?> _mortgageInsuranceAdjustmentFactor1;
        /// <summary>
        /// LoanProgram MortgageInsuranceAdjustmentFactor1 [LPNN57]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MortgageInsuranceAdjustmentFactor1 { get => _mortgageInsuranceAdjustmentFactor1; set => SetField(ref _mortgageInsuranceAdjustmentFactor1, value); }
        private DirtyValue<decimal?> _mortgageInsuranceAdjustmentFactor2;
        /// <summary>
        /// LoanProgram MortgageInsuranceAdjustmentFactor2 [LPNN60]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MortgageInsuranceAdjustmentFactor2 { get => _mortgageInsuranceAdjustmentFactor2; set => SetField(ref _mortgageInsuranceAdjustmentFactor2, value); }
        private DirtyValue<decimal?> _mortgageInsuranceCancelPercent;
        /// <summary>
        /// LoanProgram MortgageInsuranceCancelPercent [LPNN63]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MortgageInsuranceCancelPercent { get => _mortgageInsuranceCancelPercent; set => SetField(ref _mortgageInsuranceCancelPercent, value); }
        private DirtyValue<decimal?> _mortgageInsuranceMonthlyPayment1;
        /// <summary>
        /// LoanProgram MortgageInsuranceMonthlyPayment1 [LPNN59]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MortgageInsuranceMonthlyPayment1 { get => _mortgageInsuranceMonthlyPayment1; set => SetField(ref _mortgageInsuranceMonthlyPayment1, value); }
        private DirtyValue<decimal?> _mortgageInsuranceMonthlyPayment2;
        /// <summary>
        /// LoanProgram MortgageInsuranceMonthlyPayment2 [LPNN62]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MortgageInsuranceMonthlyPayment2 { get => _mortgageInsuranceMonthlyPayment2; set => SetField(ref _mortgageInsuranceMonthlyPayment2, value); }
        private DirtyValue<int?> _mortgageInsuranceMonthsOfAdjustment1;
        /// <summary>
        /// LoanProgram MortgageInsuranceMonthsOfAdjustment1 [LPNN58]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? MortgageInsuranceMonthsOfAdjustment1 { get => _mortgageInsuranceMonthsOfAdjustment1; set => SetField(ref _mortgageInsuranceMonthsOfAdjustment1, value); }
        private DirtyValue<int?> _mortgageInsuranceMonthsOfAdjustment2;
        /// <summary>
        /// LoanProgram MortgageInsuranceMonthsOfAdjustment2 [LPNN61]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? MortgageInsuranceMonthsOfAdjustment2 { get => _mortgageInsuranceMonthsOfAdjustment2; set => SetField(ref _mortgageInsuranceMonthsOfAdjustment2, value); }
        private DirtyValue<string> _mortgageType;
        /// <summary>
        /// LoanProgram MortgageType [LPNN01]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MortgageType { get => _mortgageType; set => SetField(ref _mortgageType, value); }
        private DirtyValue<string> _otherAmortizationTypeDescription;
        /// <summary>
        /// LoanProgram OtherAmortizationTypeDescription [LPNN87]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string OtherAmortizationTypeDescription { get => _otherAmortizationTypeDescription; set => SetField(ref _otherAmortizationTypeDescription, value); }
        private DirtyValue<string> _otherLoanPurposeDescription;
        /// <summary>
        /// LoanProgram OtherLoanPurposeDescription [LPNN96]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string OtherLoanPurposeDescription { get => _otherLoanPurposeDescription; set => SetField(ref _otherLoanPurposeDescription, value); }
        private DirtyValue<string> _otherMortgageTypeDescription;
        /// <summary>
        /// LoanProgram OtherMortgageTypeDescription [LPNN85]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string OtherMortgageTypeDescription { get => _otherMortgageTypeDescription; set => SetField(ref _otherMortgageTypeDescription, value); }
        private DirtyValue<int?> _paymentAdjustmentDurationMonths;
        /// <summary>
        /// LoanProgram PaymentAdjustmentDurationMonths [LPNN37]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? PaymentAdjustmentDurationMonths { get => _paymentAdjustmentDurationMonths; set => SetField(ref _paymentAdjustmentDurationMonths, value); }
        private DirtyValue<decimal?> _paymentAdjustmentPeriodicCapPercent;
        /// <summary>
        /// LoanProgram PaymentAdjustmentPeriodicCapPercent [LPNN36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? PaymentAdjustmentPeriodicCapPercent { get => _paymentAdjustmentPeriodicCapPercent; set => SetField(ref _paymentAdjustmentPeriodicCapPercent, value); }
        private DirtyValue<decimal?> _paymentFactor;
        /// <summary>
        /// LoanProgram PaymentFactor [LPNN52]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? PaymentFactor { get => _paymentFactor; set => SetField(ref _paymentFactor, value); }
        private DirtyValue<decimal?> _percentageOfRental;
        /// <summary>
        /// LoanProgram PercentageOfRental [LPNN84]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? PercentageOfRental { get => _percentageOfRental; set => SetField(ref _percentageOfRental, value); }
        private DirtyValue<string> _perDiemCalculationMethodType;
        /// <summary>
        /// LoanProgram PerDiemCalculationMethodType [LPNN111]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PerDiemCalculationMethodType { get => _perDiemCalculationMethodType; set => SetField(ref _perDiemCalculationMethodType, value); }
        private DirtyValue<StringEnumValue<YOrN>> _pmi;
        /// <summary>
        /// LoanProgram Pmi [LPNN109]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<YOrN> Pmi { get => _pmi; set => SetField(ref _pmi, value); }
        private DirtyValue<string> _prepaymentPenaltyIndicator;
        /// <summary>
        /// LoanProgram PrepaymentPenaltyIndicator [LPNN70]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PrepaymentPenaltyIndicator { get => _prepaymentPenaltyIndicator; set => SetField(ref _prepaymentPenaltyIndicator, value); }
        private DirtyValue<string> _programCode;
        /// <summary>
        /// LoanProgram ProgramCode [LPNN80]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ProgramCode { get => _programCode; set => SetField(ref _programCode, value); }
        private DirtyValue<string> _propertyInsurance;
        /// <summary>
        /// LoanProgram PropertyInsurance [LPNN91]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PropertyInsurance { get => _propertyInsurance; set => SetField(ref _propertyInsurance, value); }
        private DirtyValue<string> _propertyUsageType;
        /// <summary>
        /// LoanProgram PropertyUsageType [LPNN02]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PropertyUsageType { get => _propertyUsageType; set => SetField(ref _propertyUsageType, value); }
        private DirtyValue<decimal?> _qualifyingRatePercent;
        /// <summary>
        /// LoanProgram QualifyingRatePercent [LPNN09]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? QualifyingRatePercent { get => _qualifyingRatePercent; set => SetField(ref _qualifyingRatePercent, value); }
        private DirtyValue<int?> _rateAdjustmentDurationMonths;
        /// <summary>
        /// LoanProgram RateAdjustmentDurationMonths [LPNN29]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? RateAdjustmentDurationMonths { get => _rateAdjustmentDurationMonths; set => SetField(ref _rateAdjustmentDurationMonths, value); }
        private DirtyValue<decimal?> _rateAdjustmentLifetimeCapPercent;
        /// <summary>
        /// LoanProgram RateAdjustmentLifetimeCapPercent [LPNN30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? RateAdjustmentLifetimeCapPercent { get => _rateAdjustmentLifetimeCapPercent; set => SetField(ref _rateAdjustmentLifetimeCapPercent, value); }
        private DirtyValue<decimal?> _rateAdjustmentPercent;
        /// <summary>
        /// LoanProgram RateAdjustmentPercent [LPNN26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? RateAdjustmentPercent { get => _rateAdjustmentPercent; set => SetField(ref _rateAdjustmentPercent, value); }
        private DirtyValue<decimal?> _rateAdjustmentSubsequentCapPercent;
        /// <summary>
        /// LoanProgram RateAdjustmentSubsequentCapPercent [LPNN28]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? RateAdjustmentSubsequentCapPercent { get => _rateAdjustmentSubsequentCapPercent; set => SetField(ref _rateAdjustmentSubsequentCapPercent, value); }
        private DirtyValue<int?> _rateAdjustmentSubsequentRateAdjustmentMonths;
        /// <summary>
        /// LoanProgram RateAdjustmentSubsequentRateAdjustmentMonths [LPNN27]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? RateAdjustmentSubsequentRateAdjustmentMonths { get => _rateAdjustmentSubsequentRateAdjustmentMonths; set => SetField(ref _rateAdjustmentSubsequentRateAdjustmentMonths, value); }
        private DirtyValue<int?> _recastPaidMonths;
        /// <summary>
        /// LoanProgram RecastPaidMonths [LPNN38]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? RecastPaidMonths { get => _recastPaidMonths; set => SetField(ref _recastPaidMonths, value); }
        private DirtyValue<int?> _recastStopMonths;
        /// <summary>
        /// LoanProgram RecastStopMonths [LPNN39]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? RecastStopMonths { get => _recastStopMonths; set => SetField(ref _recastStopMonths, value); }
        private DirtyValue<string> _refundPaymentIndicator;
        /// <summary>
        /// LoanProgram RefundPaymentIndicator [LPNN71]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string RefundPaymentIndicator { get => _refundPaymentIndicator; set => SetField(ref _refundPaymentIndicator, value); }
        private DirtyValue<decimal?> _requestedInterestRatePercent;
        /// <summary>
        /// LoanProgram RequestedInterestRatePercent [LPNN08]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? RequestedInterestRatePercent { get => _requestedInterestRatePercent; set => SetField(ref _requestedInterestRatePercent, value); }
        private DirtyValue<string> _requiredDeposit;
        /// <summary>
        /// LoanProgram RequiredDeposit [LPNN64]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string RequiredDeposit { get => _requiredDeposit; set => SetField(ref _requiredDeposit, value); }
        private DirtyValue<decimal?> _roundPercent;
        /// <summary>
        /// LoanProgram RoundPercent [LPNN34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? RoundPercent { get => _roundPercent; set => SetField(ref _roundPercent, value); }
        private DirtyValue<string> _roundType;
        /// <summary>
        /// LoanProgram RoundType [LPNN35]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string RoundType { get => _roundType; set => SetField(ref _roundType, value); }
        private DirtyValue<string> _securityInterestInNameOf;
        /// <summary>
        /// LoanProgram SecurityInterestInNameOf [LPNN68]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string SecurityInterestInNameOf { get => _securityInterestInNameOf; set => SetField(ref _securityInterestInNameOf, value); }
        private DirtyValue<string> _securityType;
        /// <summary>
        /// LoanProgram SecurityType [LPNN69]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string SecurityType { get => _securityType; set => SetField(ref _securityType, value); }
        private DirtyValue<decimal?> _subjectPropertyGrossRentalIncome;
        /// <summary>
        /// LoanProgram SubjectPropertyGrossRentalIncome [LPNN83]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? SubjectPropertyGrossRentalIncome { get => _subjectPropertyGrossRentalIncome; set => SetField(ref _subjectPropertyGrossRentalIncome, value); }
        private DirtyValue<decimal?> _teaserRate;
        /// <summary>
        /// LoanProgram TeaserRate [LPNN116]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? TeaserRate { get => _teaserRate; set => SetField(ref _teaserRate, value); }
        private DirtyValue<decimal?> _terminationFeeAmount;
        /// <summary>
        /// LoanProgram TerminationFeeAmount [LPNN126]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TerminationFeeAmount { get => _terminationFeeAmount; set => SetField(ref _terminationFeeAmount, value); }
        private DirtyValue<int?> _terminationPeriodMonthsCount;
        /// <summary>
        /// LoanProgram TerminationPeriodMonthsCount [LPNN127]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? TerminationPeriodMonthsCount { get => _terminationPeriodMonthsCount; set => SetField(ref _terminationPeriodMonthsCount, value); }
        private DirtyValue<decimal?> _thirdPartyFeeFrom;
        /// <summary>
        /// LoanProgram ThirdPartyFeeFrom [LPNN117]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? ThirdPartyFeeFrom { get => _thirdPartyFeeFrom; set => SetField(ref _thirdPartyFeeFrom, value); }
        private DirtyValue<decimal?> _thirdPartyFeeTo;
        /// <summary>
        /// LoanProgram ThirdPartyFeeTo [LPNN118]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? ThirdPartyFeeTo { get => _thirdPartyFeeTo; set => SetField(ref _thirdPartyFeeTo, value); }
        private DirtyValue<string> _type;
        /// <summary>
        /// LoanProgram Type [LPNN05]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string Type { get => _type; set => SetField(ref _type, value); }
        private DirtyValue<string> _useDaysInYears;
        /// <summary>
        /// LoanProgram UseDaysInYears [LPNN105]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string UseDaysInYears { get => _useDaysInYears; set => SetField(ref _useDaysInYears, value); }
        private DirtyValue<StringEnumValue<YOrN>> _usePitiForRatio;
        /// <summary>
        /// LoanProgram UsePitiForRatio [LPNN106]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<YOrN> UsePitiForRatio { get => _usePitiForRatio; set => SetField(ref _usePitiForRatio, value); }
        private DirtyValue<string> _variableRateFeature;
        /// <summary>
        /// LoanProgram VariableRateFeature [LPNN66]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string VariableRateFeature { get => _variableRateFeature; set => SetField(ref _variableRateFeature, value); }
        private DirtyValue<decimal?> _yearlyTerm;
        /// <summary>
        /// LoanProgram YearlyTerm [LPNN95]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? YearlyTerm { get => _yearlyTerm; set => SetField(ref _yearlyTerm, value); }
    }
}