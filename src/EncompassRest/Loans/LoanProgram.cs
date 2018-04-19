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
        public StringEnumValue<YOrN> Acquisition { get => _acquisition; set => _acquisition = value; }
        private DirtyValue<string> _additionalArmInformation;
        /// <summary>
        /// LoanProgram AdditionalArmInformation [LPNN67]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AdditionalArmInformation { get => _additionalArmInformation; set => _additionalArmInformation = value; }
        private DirtyValue<string> _allDateAndNumericalDisclosures;
        /// <summary>
        /// LoanProgram AllDateAndNumericalDisclosures [LPNN82]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AllDateAndNumericalDisclosures { get => _allDateAndNumericalDisclosures; set => _allDateAndNumericalDisclosures = value; }
        private DirtyValue<decimal?> _annualFeeNeeded;
        /// <summary>
        /// LoanProgram AnnualFeeNeeded [LPNN115]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? AnnualFeeNeeded { get => _annualFeeNeeded; set => _annualFeeNeeded = value; }
        private DirtyValue<string> _armTypeDescription;
        /// <summary>
        /// LoanProgram ArmTypeDescription [LPNN86]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ArmTypeDescription { get => _armTypeDescription; set => _armTypeDescription = value; }
        private DirtyValue<string> _assumptionOnYourProperty;
        /// <summary>
        /// LoanProgram AssumptionOnYourProperty [LPNN75]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AssumptionOnYourProperty { get => _assumptionOnYourProperty; set => _assumptionOnYourProperty = value; }
        private DirtyValue<int?> _balloonLoanMaturityTermMonths;
        /// <summary>
        /// LoanProgram BalloonLoanMaturityTermMonths [LPNN11]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BalloonLoanMaturityTermMonths { get => _balloonLoanMaturityTermMonths; set => _balloonLoanMaturityTermMonths = value; }
        private DirtyValue<int?> _buydownChangeFrequencyMonths1;
        /// <summary>
        /// LoanProgram BuydownChangeFrequencyMonths1 [LPNN13]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BuydownChangeFrequencyMonths1 { get => _buydownChangeFrequencyMonths1; set => _buydownChangeFrequencyMonths1 = value; }
        private DirtyValue<int?> _buydownChangeFrequencyMonths2;
        /// <summary>
        /// LoanProgram BuydownChangeFrequencyMonths2 [LPNN15]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BuydownChangeFrequencyMonths2 { get => _buydownChangeFrequencyMonths2; set => _buydownChangeFrequencyMonths2 = value; }
        private DirtyValue<int?> _buydownChangeFrequencyMonths3;
        /// <summary>
        /// LoanProgram BuydownChangeFrequencyMonths3 [LPNN17]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BuydownChangeFrequencyMonths3 { get => _buydownChangeFrequencyMonths3; set => _buydownChangeFrequencyMonths3 = value; }
        private DirtyValue<int?> _buydownChangeFrequencyMonths4;
        /// <summary>
        /// LoanProgram BuydownChangeFrequencyMonths4 [LPNN19]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BuydownChangeFrequencyMonths4 { get => _buydownChangeFrequencyMonths4; set => _buydownChangeFrequencyMonths4 = value; }
        private DirtyValue<int?> _buydownChangeFrequencyMonths5;
        /// <summary>
        /// LoanProgram BuydownChangeFrequencyMonths5 [LPNN21]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BuydownChangeFrequencyMonths5 { get => _buydownChangeFrequencyMonths5; set => _buydownChangeFrequencyMonths5 = value; }
        private DirtyValue<int?> _buydownChangeFrequencyMonths6;
        /// <summary>
        /// LoanProgram BuydownChangeFrequencyMonths6 [LPNN23]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BuydownChangeFrequencyMonths6 { get => _buydownChangeFrequencyMonths6; set => _buydownChangeFrequencyMonths6 = value; }
        private DirtyValue<decimal?> _buydownIncreaseRatePercent1;
        /// <summary>
        /// LoanProgram BuydownIncreaseRatePercent1 [LPNN12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? BuydownIncreaseRatePercent1 { get => _buydownIncreaseRatePercent1; set => _buydownIncreaseRatePercent1 = value; }
        private DirtyValue<decimal?> _buydownIncreaseRatePercent2;
        /// <summary>
        /// LoanProgram BuydownIncreaseRatePercent2 [LPNN14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? BuydownIncreaseRatePercent2 { get => _buydownIncreaseRatePercent2; set => _buydownIncreaseRatePercent2 = value; }
        private DirtyValue<decimal?> _buydownIncreaseRatePercent3;
        /// <summary>
        /// LoanProgram BuydownIncreaseRatePercent3 [LPNN16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? BuydownIncreaseRatePercent3 { get => _buydownIncreaseRatePercent3; set => _buydownIncreaseRatePercent3 = value; }
        private DirtyValue<decimal?> _buydownIncreaseRatePercent4;
        /// <summary>
        /// LoanProgram BuydownIncreaseRatePercent4 [LPNN18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? BuydownIncreaseRatePercent4 { get => _buydownIncreaseRatePercent4; set => _buydownIncreaseRatePercent4 = value; }
        private DirtyValue<decimal?> _buydownIncreaseRatePercent5;
        /// <summary>
        /// LoanProgram BuydownIncreaseRatePercent5 [LPNN20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? BuydownIncreaseRatePercent5 { get => _buydownIncreaseRatePercent5; set => _buydownIncreaseRatePercent5 = value; }
        private DirtyValue<decimal?> _buydownIncreaseRatePercent6;
        /// <summary>
        /// LoanProgram BuydownIncreaseRatePercent6 [LPNN22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? BuydownIncreaseRatePercent6 { get => _buydownIncreaseRatePercent6; set => _buydownIncreaseRatePercent6 = value; }
        private DirtyValue<string> _calculateBasedOnRemainingBalance;
        /// <summary>
        /// LoanProgram CalculateBasedOnRemainingBalance [LPNN99]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CalculateBasedOnRemainingBalance { get => _calculateBasedOnRemainingBalance; set => _calculateBasedOnRemainingBalance = value; }
        private DirtyValue<string> _closingCostProgram;
        /// <summary>
        /// LoanProgram ClosingCostProgram [LPNN97]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ClosingCostProgram { get => _closingCostProgram; set => _closingCostProgram = value; }
        private DirtyValue<string> _constructionDescription;
        /// <summary>
        /// LoanProgram ConstructionDescription [LPNN56]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ConstructionDescription { get => _constructionDescription; set => _constructionDescription = value; }
        private DirtyValue<decimal?> _constructionInterestReserveAmount;
        /// <summary>
        /// LoanProgram ConstructionInterestReserveAmount [LPNN55]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? ConstructionInterestReserveAmount { get => _constructionInterestReserveAmount; set => _constructionInterestReserveAmount = value; }
        private DirtyValue<string> _constructionLoanMethod;
        /// <summary>
        /// LoanProgram ConstructionLoanMethod [LPNN112]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ConstructionLoanMethod { get => _constructionLoanMethod; set => _constructionLoanMethod = value; }
        private DirtyValue<int?> _constructionPeriodMonths;
        /// <summary>
        /// LoanProgram ConstructionPeriodMonths [LPNN53]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? ConstructionPeriodMonths { get => _constructionPeriodMonths; set => _constructionPeriodMonths = value; }
        private DirtyValue<decimal?> _constructionRate;
        /// <summary>
        /// LoanProgram ConstructionRate [LPNN54]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? ConstructionRate { get => _constructionRate; set => _constructionRate = value; }
        private DirtyValue<string> _convertible;
        /// <summary>
        /// LoanProgram Convertible [LPNN79]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string Convertible { get => _convertible; set => _convertible = value; }
        private DirtyValue<string> _creditDisability;
        /// <summary>
        /// LoanProgram CreditDisability [LPNN90]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CreditDisability { get => _creditDisability; set => _creditDisability = value; }
        private DirtyValue<string> _creditLifeInsurance;
        /// <summary>
        /// LoanProgram CreditLifeInsurance [LPNN89]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CreditLifeInsurance { get => _creditLifeInsurance; set => _creditLifeInsurance = value; }
        private DirtyValue<string> _demandFeature;
        /// <summary>
        /// LoanProgram DemandFeature [LPNN65]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string DemandFeature { get => _demandFeature; set => _demandFeature = value; }
        private DirtyValue<string> _description;
        /// <summary>
        /// LoanProgram Description [LPNN88]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<string> _disclosureType;
        /// <summary>
        /// LoanProgram DisclosureType [LPNN110]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string DisclosureType { get => _disclosureType; set => _disclosureType = value; }
        private DirtyValue<string> _discounted;
        /// <summary>
        /// LoanProgram Discounted [LPNN123]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string Discounted { get => _discounted; set => _discounted = value; }
        private DirtyValue<decimal?> _discountedRate;
        /// <summary>
        /// LoanProgram DiscountedRate [LPNN124]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? DiscountedRate { get => _discountedRate; set => _discountedRate = value; }
        private DirtyValue<string> _drawRepayPeriodTableName;
        /// <summary>
        /// LoanProgram DrawRepayPeriodTableName [LPNN125]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string DrawRepayPeriodTableName { get => _drawRepayPeriodTableName; set => _drawRepayPeriodTableName = value; }
        private DirtyValue<decimal?> _fhaUpfrontMiPremiumPercent;
        /// <summary>
        /// LoanProgram FhaUpfrontMiPremiumPercent [LPNN101]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? FhaUpfrontMiPremiumPercent { get => _fhaUpfrontMiPremiumPercent; set => _fhaUpfrontMiPremiumPercent = value; }
        private DirtyValue<string> _floodInsurance;
        /// <summary>
        /// LoanProgram FloodInsurance [LPNN92]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string FloodInsurance { get => _floodInsurance; set => _floodInsurance = value; }
        private DirtyValue<decimal?> _floorPercent;
        /// <summary>
        /// LoanProgram FloorPercent [LPNN33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? FloorPercent { get => _floorPercent; set => _floorPercent = value; }
        private DirtyValue<decimal?> _fundingFeePaidInCash;
        /// <summary>
        /// LoanProgram FundingFeePaidInCash [LPNN104]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? FundingFeePaidInCash { get => _fundingFeePaidInCash; set => _fundingFeePaidInCash = value; }
        private DirtyValue<decimal?> _gpmExtraPaymentForEarlyPayOff;
        /// <summary>
        /// LoanProgram GpmExtraPaymentForEarlyPayOff [LPNN43]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? GpmExtraPaymentForEarlyPayOff { get => _gpmExtraPaymentForEarlyPayOff; set => _gpmExtraPaymentForEarlyPayOff = value; }
        private DirtyValue<decimal?> _gpmRate;
        /// <summary>
        /// LoanProgram GpmRate [LPNN41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? GpmRate { get => _gpmRate; set => _gpmRate = value; }
        private DirtyValue<int?> _gpmYears;
        /// <summary>
        /// LoanProgram GpmYears [LPNN42]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? GpmYears { get => _gpmYears; set => _gpmYears = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// LoanProgram Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _ifYouPurchase;
        /// <summary>
        /// LoanProgram IfYouPurchase [LPNN93]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string IfYouPurchase { get => _ifYouPurchase; set => _ifYouPurchase = value; }
        private DirtyValue<string> _ifYouPurchaseType;
        /// <summary>
        /// LoanProgram IfYouPurchaseType [LPNN94]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string IfYouPurchaseType { get => _ifYouPurchaseType; set => _ifYouPurchaseType = value; }
        private DirtyValue<decimal?> _indexCurrentValuePercent;
        /// <summary>
        /// LoanProgram IndexCurrentValuePercent [LPNN32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? IndexCurrentValuePercent { get => _indexCurrentValuePercent; set => _indexCurrentValuePercent = value; }
        private DirtyValue<decimal?> _indexMarginPercent;
        /// <summary>
        /// LoanProgram IndexMarginPercent [LPNN31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? IndexMarginPercent { get => _indexMarginPercent; set => _indexMarginPercent = value; }
        private DirtyValue<decimal?> _initialAdvanceAmount;
        /// <summary>
        /// LoanProgram InitialAdvanceAmount [LPNN114]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? InitialAdvanceAmount { get => _initialAdvanceAmount; set => _initialAdvanceAmount = value; }
        private DirtyValue<int?> _interestOnlyMonths;
        /// <summary>
        /// LoanProgram InterestOnlyMonths [LPNN25]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? InterestOnlyMonths { get => _interestOnlyMonths; set => _interestOnlyMonths = value; }
        private DirtyValue<int?> _lateChargeDays;
        /// <summary>
        /// LoanProgram LateChargeDays [LPNN72]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? LateChargeDays { get => _lateChargeDays; set => _lateChargeDays = value; }
        private DirtyValue<decimal?> _lateChargePercent;
        /// <summary>
        /// LoanProgram LateChargePercent [LPNN73]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? LateChargePercent { get => _lateChargePercent; set => _lateChargePercent = value; }
        private DirtyValue<string> _lateChargeType;
        /// <summary>
        /// LoanProgram LateChargeType [LPNN74]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LateChargeType { get => _lateChargeType; set => _lateChargeType = value; }
        private DirtyValue<string> _lenderInvestorCode;
        /// <summary>
        /// LoanProgram LenderInvestorCode [LPNN51]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LenderInvestorCode { get => _lenderInvestorCode; set => _lenderInvestorCode = value; }
        private DirtyValue<string> _lienPriorityType;
        /// <summary>
        /// LoanProgram LienPriorityType [LPNN03]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LienPriorityType { get => _lienPriorityType; set => _lienPriorityType = value; }
        private DirtyValue<int?> _loanAmortizationTermMonths;
        /// <summary>
        /// LoanProgram LoanAmortizationTermMonths [LPNN10]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? LoanAmortizationTermMonths { get => _loanAmortizationTermMonths; set => _loanAmortizationTermMonths = value; }
        private DirtyValue<string> _loanAmortizationType;
        /// <summary>
        /// LoanProgram LoanAmortizationType [LPNN07]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LoanAmortizationType { get => _loanAmortizationType; set => _loanAmortizationType = value; }
        private DirtyValue<string> _loanDocumentationType;
        /// <summary>
        /// LoanProgram LoanDocumentationType [LPNN107]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LoanDocumentationType { get => _loanDocumentationType; set => _loanDocumentationType = value; }
        private DirtyValue<string> _loanFeaturesPaymentFrequencyType;
        /// <summary>
        /// LoanProgram LoanFeaturesPaymentFrequencyType [LPNN24]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LoanFeaturesPaymentFrequencyType { get => _loanFeaturesPaymentFrequencyType; set => _loanFeaturesPaymentFrequencyType = value; }
        private DirtyValue<string> _loanProgramName;
        /// <summary>
        /// LoanProgram LoanProgramName [LPNN44]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LoanProgramName { get => _loanProgramName; set => _loanProgramName = value; }
        private DirtyValue<StringEnumValue<YOrN>> _lockField;
        /// <summary>
        /// LoanProgram LockField [LPNN102]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<YOrN> LockField { get => _lockField; set => _lockField = value; }
        private DirtyValue<decimal?> _maxBackRatio;
        /// <summary>
        /// LoanProgram MaxBackRatio [LPNN50]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MaxBackRatio { get => _maxBackRatio; set => _maxBackRatio = value; }
        private DirtyValue<decimal?> _maxCltv;
        /// <summary>
        /// LoanProgram MaxCltv [LPNN47]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MaxCltv { get => _maxCltv; set => _maxCltv = value; }
        private DirtyValue<decimal?> _maxFrontRatio;
        /// <summary>
        /// LoanProgram MaxFrontRatio [LPNN49]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MaxFrontRatio { get => _maxFrontRatio; set => _maxFrontRatio = value; }
        private DirtyValue<decimal?> _maximumBalance;
        /// <summary>
        /// LoanProgram MaximumBalance [LPNN40]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MaximumBalance { get => _maximumBalance; set => _maximumBalance = value; }
        private DirtyValue<decimal?> _maxLoanAmount;
        /// <summary>
        /// LoanProgram MaxLoanAmount [LPNN45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MaxLoanAmount { get => _maxLoanAmount; set => _maxLoanAmount = value; }
        private DirtyValue<decimal?> _maxLtv;
        /// <summary>
        /// LoanProgram MaxLtv [LPNN46]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MaxLtv { get => _maxLtv; set => _maxLtv = value; }
        private DirtyValue<string> _meansAnEstimate;
        /// <summary>
        /// LoanProgram MeansAnEstimate [LPNN81]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MeansAnEstimate { get => _meansAnEstimate; set => _meansAnEstimate = value; }
        private DirtyValue<string> _miCalculationType;
        /// <summary>
        /// LoanProgram MiCalculationType [LPNN100]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MiCalculationType { get => _miCalculationType; set => _miCalculationType = value; }
        private DirtyValue<string> _midpointCancellation;
        /// <summary>
        /// LoanProgram MidpointCancellation [LPNN98]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MidpointCancellation { get => _midpointCancellation; set => _midpointCancellation = value; }
        private DirtyValue<string> _minCreditScore;
        /// <summary>
        /// LoanProgram MinCreditScore [LPNN48]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MinCreditScore { get => _minCreditScore; set => _minCreditScore = value; }
        private DirtyValue<decimal?> _minimumAdvanceAmount;
        /// <summary>
        /// LoanProgram MinimumAdvanceAmount [LPNN119]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MinimumAdvanceAmount { get => _minimumAdvanceAmount; set => _minimumAdvanceAmount = value; }
        private DirtyValue<decimal?> _minimumAllowableApr;
        /// <summary>
        /// LoanProgram MinimumAllowableApr [LPNN120]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MinimumAllowableApr { get => _minimumAllowableApr; set => _minimumAllowableApr = value; }
        private DirtyValue<decimal?> _minimumPaymentAmount;
        /// <summary>
        /// LoanProgram MinimumPaymentAmount [LPNN122]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MinimumPaymentAmount { get => _minimumPaymentAmount; set => _minimumPaymentAmount = value; }
        private DirtyValue<decimal?> _minimumPaymentPercent;
        /// <summary>
        /// LoanProgram MinimumPaymentPercent [LPNN121]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MinimumPaymentPercent { get => _minimumPaymentPercent; set => _minimumPaymentPercent = value; }
        private DirtyValue<decimal?> _mipPaidInCash;
        /// <summary>
        /// LoanProgram MipPaidInCash [LPNN103]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MipPaidInCash { get => _mipPaidInCash; set => _mipPaidInCash = value; }
        private DirtyValue<StringEnumValue<YOrN>> _mmi;
        /// <summary>
        /// LoanProgram Mmi [LPNN108]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<YOrN> Mmi { get => _mmi; set => _mmi = value; }
        private DirtyValue<decimal?> _mortgageInsuranceAdjustmentFactor1;
        /// <summary>
        /// LoanProgram MortgageInsuranceAdjustmentFactor1 [LPNN57]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MortgageInsuranceAdjustmentFactor1 { get => _mortgageInsuranceAdjustmentFactor1; set => _mortgageInsuranceAdjustmentFactor1 = value; }
        private DirtyValue<decimal?> _mortgageInsuranceAdjustmentFactor2;
        /// <summary>
        /// LoanProgram MortgageInsuranceAdjustmentFactor2 [LPNN60]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MortgageInsuranceAdjustmentFactor2 { get => _mortgageInsuranceAdjustmentFactor2; set => _mortgageInsuranceAdjustmentFactor2 = value; }
        private DirtyValue<decimal?> _mortgageInsuranceCancelPercent;
        /// <summary>
        /// LoanProgram MortgageInsuranceCancelPercent [LPNN63]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MortgageInsuranceCancelPercent { get => _mortgageInsuranceCancelPercent; set => _mortgageInsuranceCancelPercent = value; }
        private DirtyValue<decimal?> _mortgageInsuranceMonthlyPayment1;
        /// <summary>
        /// LoanProgram MortgageInsuranceMonthlyPayment1 [LPNN59]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MortgageInsuranceMonthlyPayment1 { get => _mortgageInsuranceMonthlyPayment1; set => _mortgageInsuranceMonthlyPayment1 = value; }
        private DirtyValue<decimal?> _mortgageInsuranceMonthlyPayment2;
        /// <summary>
        /// LoanProgram MortgageInsuranceMonthlyPayment2 [LPNN62]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MortgageInsuranceMonthlyPayment2 { get => _mortgageInsuranceMonthlyPayment2; set => _mortgageInsuranceMonthlyPayment2 = value; }
        private DirtyValue<int?> _mortgageInsuranceMonthsOfAdjustment1;
        /// <summary>
        /// LoanProgram MortgageInsuranceMonthsOfAdjustment1 [LPNN58]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? MortgageInsuranceMonthsOfAdjustment1 { get => _mortgageInsuranceMonthsOfAdjustment1; set => _mortgageInsuranceMonthsOfAdjustment1 = value; }
        private DirtyValue<int?> _mortgageInsuranceMonthsOfAdjustment2;
        /// <summary>
        /// LoanProgram MortgageInsuranceMonthsOfAdjustment2 [LPNN61]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? MortgageInsuranceMonthsOfAdjustment2 { get => _mortgageInsuranceMonthsOfAdjustment2; set => _mortgageInsuranceMonthsOfAdjustment2 = value; }
        private DirtyValue<string> _mortgageType;
        /// <summary>
        /// LoanProgram MortgageType [LPNN01]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MortgageType { get => _mortgageType; set => _mortgageType = value; }
        private DirtyValue<string> _otherAmortizationTypeDescription;
        /// <summary>
        /// LoanProgram OtherAmortizationTypeDescription [LPNN87]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string OtherAmortizationTypeDescription { get => _otherAmortizationTypeDescription; set => _otherAmortizationTypeDescription = value; }
        private DirtyValue<string> _otherLoanPurposeDescription;
        /// <summary>
        /// LoanProgram OtherLoanPurposeDescription [LPNN96]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string OtherLoanPurposeDescription { get => _otherLoanPurposeDescription; set => _otherLoanPurposeDescription = value; }
        private DirtyValue<string> _otherMortgageTypeDescription;
        /// <summary>
        /// LoanProgram OtherMortgageTypeDescription [LPNN85]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string OtherMortgageTypeDescription { get => _otherMortgageTypeDescription; set => _otherMortgageTypeDescription = value; }
        private DirtyValue<int?> _paymentAdjustmentDurationMonths;
        /// <summary>
        /// LoanProgram PaymentAdjustmentDurationMonths [LPNN37]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? PaymentAdjustmentDurationMonths { get => _paymentAdjustmentDurationMonths; set => _paymentAdjustmentDurationMonths = value; }
        private DirtyValue<decimal?> _paymentAdjustmentPeriodicCapPercent;
        /// <summary>
        /// LoanProgram PaymentAdjustmentPeriodicCapPercent [LPNN36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? PaymentAdjustmentPeriodicCapPercent { get => _paymentAdjustmentPeriodicCapPercent; set => _paymentAdjustmentPeriodicCapPercent = value; }
        private DirtyValue<decimal?> _paymentFactor;
        /// <summary>
        /// LoanProgram PaymentFactor [LPNN52]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? PaymentFactor { get => _paymentFactor; set => _paymentFactor = value; }
        private DirtyValue<decimal?> _percentageOfRental;
        /// <summary>
        /// LoanProgram PercentageOfRental [LPNN84]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? PercentageOfRental { get => _percentageOfRental; set => _percentageOfRental = value; }
        private DirtyValue<string> _perDiemCalculationMethodType;
        /// <summary>
        /// LoanProgram PerDiemCalculationMethodType [LPNN111]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PerDiemCalculationMethodType { get => _perDiemCalculationMethodType; set => _perDiemCalculationMethodType = value; }
        private DirtyValue<StringEnumValue<YOrN>> _pmi;
        /// <summary>
        /// LoanProgram Pmi [LPNN109]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<YOrN> Pmi { get => _pmi; set => _pmi = value; }
        private DirtyValue<string> _prepaymentPenaltyIndicator;
        /// <summary>
        /// LoanProgram PrepaymentPenaltyIndicator [LPNN70]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PrepaymentPenaltyIndicator { get => _prepaymentPenaltyIndicator; set => _prepaymentPenaltyIndicator = value; }
        private DirtyValue<string> _programCode;
        /// <summary>
        /// LoanProgram ProgramCode [LPNN80]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ProgramCode { get => _programCode; set => _programCode = value; }
        private DirtyValue<string> _propertyInsurance;
        /// <summary>
        /// LoanProgram PropertyInsurance [LPNN91]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PropertyInsurance { get => _propertyInsurance; set => _propertyInsurance = value; }
        private DirtyValue<string> _propertyUsageType;
        /// <summary>
        /// LoanProgram PropertyUsageType [LPNN02]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PropertyUsageType { get => _propertyUsageType; set => _propertyUsageType = value; }
        private DirtyValue<decimal?> _qualifyingRatePercent;
        /// <summary>
        /// LoanProgram QualifyingRatePercent [LPNN09]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? QualifyingRatePercent { get => _qualifyingRatePercent; set => _qualifyingRatePercent = value; }
        private DirtyValue<int?> _rateAdjustmentDurationMonths;
        /// <summary>
        /// LoanProgram RateAdjustmentDurationMonths [LPNN29]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? RateAdjustmentDurationMonths { get => _rateAdjustmentDurationMonths; set => _rateAdjustmentDurationMonths = value; }
        private DirtyValue<decimal?> _rateAdjustmentLifetimeCapPercent;
        /// <summary>
        /// LoanProgram RateAdjustmentLifetimeCapPercent [LPNN30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? RateAdjustmentLifetimeCapPercent { get => _rateAdjustmentLifetimeCapPercent; set => _rateAdjustmentLifetimeCapPercent = value; }
        private DirtyValue<decimal?> _rateAdjustmentPercent;
        /// <summary>
        /// LoanProgram RateAdjustmentPercent [LPNN26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? RateAdjustmentPercent { get => _rateAdjustmentPercent; set => _rateAdjustmentPercent = value; }
        private DirtyValue<decimal?> _rateAdjustmentSubsequentCapPercent;
        /// <summary>
        /// LoanProgram RateAdjustmentSubsequentCapPercent [LPNN28]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? RateAdjustmentSubsequentCapPercent { get => _rateAdjustmentSubsequentCapPercent; set => _rateAdjustmentSubsequentCapPercent = value; }
        private DirtyValue<int?> _rateAdjustmentSubsequentRateAdjustmentMonths;
        /// <summary>
        /// LoanProgram RateAdjustmentSubsequentRateAdjustmentMonths [LPNN27]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? RateAdjustmentSubsequentRateAdjustmentMonths { get => _rateAdjustmentSubsequentRateAdjustmentMonths; set => _rateAdjustmentSubsequentRateAdjustmentMonths = value; }
        private DirtyValue<int?> _recastPaidMonths;
        /// <summary>
        /// LoanProgram RecastPaidMonths [LPNN38]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? RecastPaidMonths { get => _recastPaidMonths; set => _recastPaidMonths = value; }
        private DirtyValue<int?> _recastStopMonths;
        /// <summary>
        /// LoanProgram RecastStopMonths [LPNN39]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? RecastStopMonths { get => _recastStopMonths; set => _recastStopMonths = value; }
        private DirtyValue<string> _refundPaymentIndicator;
        /// <summary>
        /// LoanProgram RefundPaymentIndicator [LPNN71]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string RefundPaymentIndicator { get => _refundPaymentIndicator; set => _refundPaymentIndicator = value; }
        private DirtyValue<decimal?> _requestedInterestRatePercent;
        /// <summary>
        /// LoanProgram RequestedInterestRatePercent [LPNN08]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? RequestedInterestRatePercent { get => _requestedInterestRatePercent; set => _requestedInterestRatePercent = value; }
        private DirtyValue<string> _requiredDeposit;
        /// <summary>
        /// LoanProgram RequiredDeposit [LPNN64]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string RequiredDeposit { get => _requiredDeposit; set => _requiredDeposit = value; }
        private DirtyValue<decimal?> _roundPercent;
        /// <summary>
        /// LoanProgram RoundPercent [LPNN34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? RoundPercent { get => _roundPercent; set => _roundPercent = value; }
        private DirtyValue<string> _roundType;
        /// <summary>
        /// LoanProgram RoundType [LPNN35]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string RoundType { get => _roundType; set => _roundType = value; }
        private DirtyValue<string> _securityInterestInNameOf;
        /// <summary>
        /// LoanProgram SecurityInterestInNameOf [LPNN68]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string SecurityInterestInNameOf { get => _securityInterestInNameOf; set => _securityInterestInNameOf = value; }
        private DirtyValue<string> _securityType;
        /// <summary>
        /// LoanProgram SecurityType [LPNN69]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string SecurityType { get => _securityType; set => _securityType = value; }
        private DirtyValue<decimal?> _subjectPropertyGrossRentalIncome;
        /// <summary>
        /// LoanProgram SubjectPropertyGrossRentalIncome [LPNN83]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? SubjectPropertyGrossRentalIncome { get => _subjectPropertyGrossRentalIncome; set => _subjectPropertyGrossRentalIncome = value; }
        private DirtyValue<decimal?> _teaserRate;
        /// <summary>
        /// LoanProgram TeaserRate [LPNN116]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? TeaserRate { get => _teaserRate; set => _teaserRate = value; }
        private DirtyValue<decimal?> _terminationFeeAmount;
        /// <summary>
        /// LoanProgram TerminationFeeAmount [LPNN126]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TerminationFeeAmount { get => _terminationFeeAmount; set => _terminationFeeAmount = value; }
        private DirtyValue<int?> _terminationPeriodMonthsCount;
        /// <summary>
        /// LoanProgram TerminationPeriodMonthsCount [LPNN127]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? TerminationPeriodMonthsCount { get => _terminationPeriodMonthsCount; set => _terminationPeriodMonthsCount = value; }
        private DirtyValue<decimal?> _thirdPartyFeeFrom;
        /// <summary>
        /// LoanProgram ThirdPartyFeeFrom [LPNN117]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? ThirdPartyFeeFrom { get => _thirdPartyFeeFrom; set => _thirdPartyFeeFrom = value; }
        private DirtyValue<decimal?> _thirdPartyFeeTo;
        /// <summary>
        /// LoanProgram ThirdPartyFeeTo [LPNN118]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? ThirdPartyFeeTo { get => _thirdPartyFeeTo; set => _thirdPartyFeeTo = value; }
        private DirtyValue<string> _type;
        /// <summary>
        /// LoanProgram Type [LPNN05]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string Type { get => _type; set => _type = value; }
        private DirtyValue<string> _useDaysInYears;
        /// <summary>
        /// LoanProgram UseDaysInYears [LPNN105]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string UseDaysInYears { get => _useDaysInYears; set => _useDaysInYears = value; }
        private DirtyValue<StringEnumValue<YOrN>> _usePitiForRatio;
        /// <summary>
        /// LoanProgram UsePitiForRatio [LPNN106]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<YOrN> UsePitiForRatio { get => _usePitiForRatio; set => _usePitiForRatio = value; }
        private DirtyValue<string> _variableRateFeature;
        /// <summary>
        /// LoanProgram VariableRateFeature [LPNN66]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string VariableRateFeature { get => _variableRateFeature; set => _variableRateFeature = value; }
        private DirtyValue<decimal?> _yearlyTerm;
        /// <summary>
        /// LoanProgram YearlyTerm [LPNN95]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? YearlyTerm { get => _yearlyTerm; set => _yearlyTerm = value; }
        internal override bool DirtyInternal
        {
            get => _acquisition.Dirty
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
                || _yearlyTerm.Dirty;
            set
            {
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
            }
        }
    }
}