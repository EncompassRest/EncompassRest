using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LoanProgram
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class LoanProgram : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<StringEnumValue<YOrN>>? _acquisition;
    private DirtyValue<string?>? _additionalArmInformation;
    private DirtyValue<string?>? _allDateAndNumericalDisclosures;
    private DirtyValue<decimal?>? _annualFeeNeeded;
    private DirtyValue<string?>? _armTypeDescription;
    private DirtyValue<string?>? _assumptionOnYourProperty;
    private DirtyValue<int?>? _balloonLoanMaturityTermMonths;
    private DirtyValue<int?>? _buydownChangeFrequencyMonths1;
    private DirtyValue<int?>? _buydownChangeFrequencyMonths2;
    private DirtyValue<int?>? _buydownChangeFrequencyMonths3;
    private DirtyValue<int?>? _buydownChangeFrequencyMonths4;
    private DirtyValue<int?>? _buydownChangeFrequencyMonths5;
    private DirtyValue<int?>? _buydownChangeFrequencyMonths6;
    private DirtyValue<decimal?>? _buydownIncreaseRatePercent1;
    private DirtyValue<decimal?>? _buydownIncreaseRatePercent2;
    private DirtyValue<decimal?>? _buydownIncreaseRatePercent3;
    private DirtyValue<decimal?>? _buydownIncreaseRatePercent4;
    private DirtyValue<decimal?>? _buydownIncreaseRatePercent5;
    private DirtyValue<decimal?>? _buydownIncreaseRatePercent6;
    private DirtyValue<string?>? _calculateBasedOnRemainingBalance;
    private DirtyValue<string?>? _closingCostProgram;
    private DirtyValue<string?>? _constructionDescription;
    private DirtyValue<decimal?>? _constructionInterestReserveAmount;
    private DirtyValue<string?>? _constructionLoanMethod;
    private DirtyValue<int?>? _constructionPeriodMonths;
    private DirtyValue<decimal?>? _constructionRate;
    private DirtyValue<string?>? _convertible;
    private DirtyValue<string?>? _creditDisability;
    private DirtyValue<string?>? _creditLifeInsurance;
    private DirtyValue<string?>? _demandFeature;
    private DirtyValue<string?>? _description;
    private DirtyValue<string?>? _disclosureType;
    private DirtyValue<string?>? _discounted;
    private DirtyValue<decimal?>? _discountedRate;
    private DirtyValue<string?>? _drawRepayPeriodTableName;
    private DirtyValue<decimal?>? _fhaUpfrontMiPremiumPercent;
    private DirtyValue<string?>? _floodInsurance;
    private DirtyValue<decimal?>? _floorPercent;
    private DirtyValue<decimal?>? _fundingFeePaidInCash;
    private DirtyValue<decimal?>? _gpmExtraPaymentForEarlyPayOff;
    private DirtyValue<decimal?>? _gpmRate;
    private DirtyValue<int?>? _gpmYears;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _ifYouPurchase;
    private DirtyValue<string?>? _ifYouPurchaseType;
    private DirtyValue<decimal?>? _indexCurrentValuePercent;
    private DirtyValue<decimal?>? _indexMarginPercent;
    private DirtyValue<decimal?>? _initialAdvanceAmount;
    private DirtyValue<int?>? _interestOnlyMonths;
    private DirtyValue<int?>? _lateChargeDays;
    private DirtyValue<decimal?>? _lateChargePercent;
    private DirtyValue<string?>? _lateChargeType;
    private DirtyValue<string?>? _lenderInvestorCode;
    private DirtyValue<string?>? _lienPriorityType;
    private DirtyValue<int?>? _loanAmortizationTermMonths;
    private DirtyValue<string?>? _loanAmortizationType;
    private DirtyValue<string?>? _loanDocumentationType;
    private DirtyValue<string?>? _loanFeaturesPaymentFrequencyType;
    private DirtyValue<string?>? _loanProgramName;
    private DirtyValue<StringEnumValue<YOrN>>? _lockField;
    private DirtyValue<decimal?>? _maxBackRatio;
    private DirtyValue<decimal?>? _maxCltv;
    private DirtyValue<decimal?>? _maxFrontRatio;
    private DirtyValue<decimal?>? _maximumBalance;
    private DirtyValue<decimal?>? _maxLoanAmount;
    private DirtyValue<decimal?>? _maxLtv;
    private DirtyValue<string?>? _meansAnEstimate;
    private DirtyValue<string?>? _miCalculationType;
    private DirtyValue<string?>? _midpointCancellation;
    private DirtyValue<string?>? _minCreditScore;
    private DirtyValue<decimal?>? _minimumAdvanceAmount;
    private DirtyValue<decimal?>? _minimumAllowableApr;
    private DirtyValue<decimal?>? _minimumPaymentAmount;
    private DirtyValue<decimal?>? _minimumPaymentPercent;
    private DirtyValue<decimal?>? _mipPaidInCash;
    private DirtyValue<StringEnumValue<YOrN>>? _mmi;
    private DirtyValue<decimal?>? _mortgageInsuranceAdjustmentFactor1;
    private DirtyValue<decimal?>? _mortgageInsuranceAdjustmentFactor2;
    private DirtyValue<decimal?>? _mortgageInsuranceCancelPercent;
    private DirtyValue<decimal?>? _mortgageInsuranceMonthlyPayment1;
    private DirtyValue<decimal?>? _mortgageInsuranceMonthlyPayment2;
    private DirtyValue<int?>? _mortgageInsuranceMonthsOfAdjustment1;
    private DirtyValue<int?>? _mortgageInsuranceMonthsOfAdjustment2;
    private DirtyValue<string?>? _mortgageType;
    private DirtyValue<string?>? _otherAmortizationTypeDescription;
    private DirtyValue<string?>? _otherLoanPurposeDescription;
    private DirtyValue<string?>? _otherMortgageTypeDescription;
    private DirtyValue<int?>? _paymentAdjustmentDurationMonths;
    private DirtyValue<decimal?>? _paymentAdjustmentPeriodicCapPercent;
    private DirtyValue<decimal?>? _paymentFactor;
    private DirtyValue<decimal?>? _percentageOfRental;
    private DirtyValue<string?>? _perDiemCalculationMethodType;
    private DirtyValue<StringEnumValue<YOrN>>? _pmi;
    private DirtyValue<string?>? _prepaymentPenaltyIndicator;
    private DirtyValue<string?>? _programCode;
    private DirtyValue<string?>? _propertyInsurance;
    private DirtyValue<string?>? _propertyUsageType;
    private DirtyValue<decimal?>? _qualifyingRatePercent;
    private DirtyValue<int?>? _rateAdjustmentDurationMonths;
    private DirtyValue<decimal?>? _rateAdjustmentLifetimeCapPercent;
    private DirtyValue<decimal?>? _rateAdjustmentPercent;
    private DirtyValue<decimal?>? _rateAdjustmentSubsequentCapPercent;
    private DirtyValue<int?>? _rateAdjustmentSubsequentRateAdjustmentMonths;
    private DirtyValue<int?>? _recastPaidMonths;
    private DirtyValue<int?>? _recastStopMonths;
    private DirtyValue<string?>? _refundPaymentIndicator;
    private DirtyValue<decimal?>? _requestedInterestRatePercent;
    private DirtyValue<string?>? _requiredDeposit;
    private DirtyValue<decimal?>? _roundPercent;
    private DirtyValue<string?>? _roundType;
    private DirtyValue<string?>? _securityInterestInNameOf;
    private DirtyValue<string?>? _securityType;
    private DirtyValue<decimal?>? _subjectPropertyGrossRentalIncome;
    private DirtyValue<decimal?>? _teaserRate;
    private DirtyValue<decimal?>? _terminationFeeAmount;
    private DirtyValue<int?>? _terminationPeriodMonthsCount;
    private DirtyValue<decimal?>? _thirdPartyFeeFrom;
    private DirtyValue<decimal?>? _thirdPartyFeeTo;
    private DirtyValue<string?>? _type;
    private DirtyValue<string?>? _useDaysInYears;
    private DirtyValue<StringEnumValue<YOrN>>? _usePitiForRatio;
    private DirtyValue<string?>? _variableRateFeature;
    private DirtyValue<decimal?>? _yearlyTerm;

    /// <summary>
    /// Field LP00113 [LP00113]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<YOrN> Acquisition { get => _acquisition; set => SetField(ref _acquisition, value); }

    /// <summary>
    /// Field LP0067 [LP0067]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AdditionalArmInformation { get => _additionalArmInformation; set => SetField(ref _additionalArmInformation, value); }

    /// <summary>
    /// Field LP0082 [LP0082]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AllDateAndNumericalDisclosures { get => _allDateAndNumericalDisclosures; set => SetField(ref _allDateAndNumericalDisclosures, value); }

    /// <summary>
    /// Field LP00115 [LP00115]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? AnnualFeeNeeded { get => _annualFeeNeeded; set => SetField(ref _annualFeeNeeded, value); }

    /// <summary>
    /// Field LP0086 [LP0086]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ArmTypeDescription { get => _armTypeDescription; set => SetField(ref _armTypeDescription, value); }

    /// <summary>
    /// Field LP0075 [LP0075]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AssumptionOnYourProperty { get => _assumptionOnYourProperty; set => SetField(ref _assumptionOnYourProperty, value); }

    /// <summary>
    /// Field LP0011 [LP0011]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BalloonLoanMaturityTermMonths { get => _balloonLoanMaturityTermMonths; set => SetField(ref _balloonLoanMaturityTermMonths, value); }

    /// <summary>
    /// Field LP0013 [LP0013]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BuydownChangeFrequencyMonths1 { get => _buydownChangeFrequencyMonths1; set => SetField(ref _buydownChangeFrequencyMonths1, value); }

    /// <summary>
    /// Field LP0015 [LP0015]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BuydownChangeFrequencyMonths2 { get => _buydownChangeFrequencyMonths2; set => SetField(ref _buydownChangeFrequencyMonths2, value); }

    /// <summary>
    /// Field LP0017 [LP0017]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BuydownChangeFrequencyMonths3 { get => _buydownChangeFrequencyMonths3; set => SetField(ref _buydownChangeFrequencyMonths3, value); }

    /// <summary>
    /// Field LP0019 [LP0019]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BuydownChangeFrequencyMonths4 { get => _buydownChangeFrequencyMonths4; set => SetField(ref _buydownChangeFrequencyMonths4, value); }

    /// <summary>
    /// Field LP0021 [LP0021]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BuydownChangeFrequencyMonths5 { get => _buydownChangeFrequencyMonths5; set => SetField(ref _buydownChangeFrequencyMonths5, value); }

    /// <summary>
    /// Field LP0023 [LP0023]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BuydownChangeFrequencyMonths6 { get => _buydownChangeFrequencyMonths6; set => SetField(ref _buydownChangeFrequencyMonths6, value); }

    /// <summary>
    /// Field LP0012 [LP0012]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BuydownIncreaseRatePercent1 { get => _buydownIncreaseRatePercent1; set => SetField(ref _buydownIncreaseRatePercent1, value); }

    /// <summary>
    /// Field LP0014 [LP0014]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BuydownIncreaseRatePercent2 { get => _buydownIncreaseRatePercent2; set => SetField(ref _buydownIncreaseRatePercent2, value); }

    /// <summary>
    /// Field LP0016 [LP0016]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BuydownIncreaseRatePercent3 { get => _buydownIncreaseRatePercent3; set => SetField(ref _buydownIncreaseRatePercent3, value); }

    /// <summary>
    /// Field LP0018 [LP0018]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BuydownIncreaseRatePercent4 { get => _buydownIncreaseRatePercent4; set => SetField(ref _buydownIncreaseRatePercent4, value); }

    /// <summary>
    /// Field LP0020 [LP0020]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BuydownIncreaseRatePercent5 { get => _buydownIncreaseRatePercent5; set => SetField(ref _buydownIncreaseRatePercent5, value); }

    /// <summary>
    /// Field LP0022 [LP0022]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BuydownIncreaseRatePercent6 { get => _buydownIncreaseRatePercent6; set => SetField(ref _buydownIncreaseRatePercent6, value); }

    /// <summary>
    /// Field LP0099 [LP0099]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CalculateBasedOnRemainingBalance { get => _calculateBasedOnRemainingBalance; set => SetField(ref _calculateBasedOnRemainingBalance, value); }

    /// <summary>
    /// Field LP0097 [LP0097]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ClosingCostProgram { get => _closingCostProgram; set => SetField(ref _closingCostProgram, value); }

    /// <summary>
    /// Field LP0056 [LP0056]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ConstructionDescription { get => _constructionDescription; set => SetField(ref _constructionDescription, value); }

    /// <summary>
    /// Field LP0055 [LP0055]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ConstructionInterestReserveAmount { get => _constructionInterestReserveAmount; set => SetField(ref _constructionInterestReserveAmount, value); }

    /// <summary>
    /// Field LP00112 [LP00112]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ConstructionLoanMethod { get => _constructionLoanMethod; set => SetField(ref _constructionLoanMethod, value); }

    /// <summary>
    /// Field LP0053 [LP0053]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? ConstructionPeriodMonths { get => _constructionPeriodMonths; set => SetField(ref _constructionPeriodMonths, value); }

    /// <summary>
    /// Field LP0054 [LP0054]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? ConstructionRate { get => _constructionRate; set => SetField(ref _constructionRate, value); }

    /// <summary>
    /// Field LP0079 [LP0079]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Convertible { get => _convertible; set => SetField(ref _convertible, value); }

    /// <summary>
    /// Field LP0090 [LP0090]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CreditDisability { get => _creditDisability; set => SetField(ref _creditDisability, value); }

    /// <summary>
    /// Field LP0089 [LP0089]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CreditLifeInsurance { get => _creditLifeInsurance; set => SetField(ref _creditLifeInsurance, value); }

    /// <summary>
    /// Field LP0065 [LP0065]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DemandFeature { get => _demandFeature; set => SetField(ref _demandFeature, value); }

    /// <summary>
    /// Field LP0088 [LP0088]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// Field LP00110 [LP00110]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DisclosureType { get => _disclosureType; set => SetField(ref _disclosureType, value); }

    /// <summary>
    /// Field LP00123 [LP00123]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Discounted { get => _discounted; set => SetField(ref _discounted, value); }

    /// <summary>
    /// Field LP00124 [LP00124]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? DiscountedRate { get => _discountedRate; set => SetField(ref _discountedRate, value); }

    /// <summary>
    /// Field LP00125 [LP00125]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DrawRepayPeriodTableName { get => _drawRepayPeriodTableName; set => SetField(ref _drawRepayPeriodTableName, value); }

    /// <summary>
    /// Field LP00101 [LP00101]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FhaUpfrontMiPremiumPercent { get => _fhaUpfrontMiPremiumPercent; set => SetField(ref _fhaUpfrontMiPremiumPercent, value); }

    /// <summary>
    /// Field LP0092 [LP0092]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? FloodInsurance { get => _floodInsurance; set => SetField(ref _floodInsurance, value); }

    /// <summary>
    /// Field LP0033 [LP0033]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? FloorPercent { get => _floorPercent; set => SetField(ref _floorPercent, value); }

    /// <summary>
    /// Field LP00104 [LP00104]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FundingFeePaidInCash { get => _fundingFeePaidInCash; set => SetField(ref _fundingFeePaidInCash, value); }

    /// <summary>
    /// Field LP0043 [LP0043]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? GpmExtraPaymentForEarlyPayOff { get => _gpmExtraPaymentForEarlyPayOff; set => SetField(ref _gpmExtraPaymentForEarlyPayOff, value); }

    /// <summary>
    /// Field LP0041 [LP0041]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? GpmRate { get => _gpmRate; set => SetField(ref _gpmRate, value); }

    /// <summary>
    /// Field LP0042 [LP0042]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? GpmYears { get => _gpmYears; set => SetField(ref _gpmYears, value); }

    /// <summary>
    /// LoanProgramContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Field LP0093 [LP0093]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? IfYouPurchase { get => _ifYouPurchase; set => SetField(ref _ifYouPurchase, value); }

    /// <summary>
    /// Field LP0094 [LP0094]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? IfYouPurchaseType { get => _ifYouPurchaseType; set => SetField(ref _ifYouPurchaseType, value); }

    /// <summary>
    /// Field LP0032 [LP0032]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? IndexCurrentValuePercent { get => _indexCurrentValuePercent; set => SetField(ref _indexCurrentValuePercent, value); }

    /// <summary>
    /// Field LP0031 [LP0031]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? IndexMarginPercent { get => _indexMarginPercent; set => SetField(ref _indexMarginPercent, value); }

    /// <summary>
    /// Field LP00114 [LP00114]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? InitialAdvanceAmount { get => _initialAdvanceAmount; set => SetField(ref _initialAdvanceAmount, value); }

    /// <summary>
    /// Field LP0025 [LP0025]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? InterestOnlyMonths { get => _interestOnlyMonths; set => SetField(ref _interestOnlyMonths, value); }

    /// <summary>
    /// Field LP0072 [LP0072]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? LateChargeDays { get => _lateChargeDays; set => SetField(ref _lateChargeDays, value); }

    /// <summary>
    /// Field LP0073 [LP0073]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? LateChargePercent { get => _lateChargePercent; set => SetField(ref _lateChargePercent, value); }

    /// <summary>
    /// Field LP0074 [LP0074]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LateChargeType { get => _lateChargeType; set => SetField(ref _lateChargeType, value); }

    /// <summary>
    /// Field LP0051 [LP0051]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LenderInvestorCode { get => _lenderInvestorCode; set => SetField(ref _lenderInvestorCode, value); }

    /// <summary>
    /// Field LP0003 [LP0003]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LienPriorityType { get => _lienPriorityType; set => SetField(ref _lienPriorityType, value); }

    /// <summary>
    /// Field LP0010 [LP0010]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? LoanAmortizationTermMonths { get => _loanAmortizationTermMonths; set => SetField(ref _loanAmortizationTermMonths, value); }

    /// <summary>
    /// Field LP0007 [LP0007]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LoanAmortizationType { get => _loanAmortizationType; set => SetField(ref _loanAmortizationType, value); }

    /// <summary>
    /// Field LP00107 [LP00107]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LoanDocumentationType { get => _loanDocumentationType; set => SetField(ref _loanDocumentationType, value); }

    /// <summary>
    /// Field LP0024 [LP0024]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LoanFeaturesPaymentFrequencyType { get => _loanFeaturesPaymentFrequencyType; set => SetField(ref _loanFeaturesPaymentFrequencyType, value); }

    /// <summary>
    /// Field LP0044 [LP0044]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LoanProgramName { get => _loanProgramName; set => SetField(ref _loanProgramName, value); }

    /// <summary>
    /// Field LP00102 [LP00102]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<YOrN> LockField { get => _lockField; set => SetField(ref _lockField, value); }

    /// <summary>
    /// Field LP0050 [LP0050]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MaxBackRatio { get => _maxBackRatio; set => SetField(ref _maxBackRatio, value); }

    /// <summary>
    /// Field LP0047 [LP0047]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MaxCltv { get => _maxCltv; set => SetField(ref _maxCltv, value); }

    /// <summary>
    /// Field LP0049 [LP0049]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MaxFrontRatio { get => _maxFrontRatio; set => SetField(ref _maxFrontRatio, value); }

    /// <summary>
    /// Field LP0040 [LP0040]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MaximumBalance { get => _maximumBalance; set => SetField(ref _maximumBalance, value); }

    /// <summary>
    /// Field LP0045 [LP0045]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MaxLoanAmount { get => _maxLoanAmount; set => SetField(ref _maxLoanAmount, value); }

    /// <summary>
    /// Field LP0046 [LP0046]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MaxLtv { get => _maxLtv; set => SetField(ref _maxLtv, value); }

    /// <summary>
    /// Field LP0081 [LP0081]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MeansAnEstimate { get => _meansAnEstimate; set => SetField(ref _meansAnEstimate, value); }

    /// <summary>
    /// Field LP00100 [LP00100]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MiCalculationType { get => _miCalculationType; set => SetField(ref _miCalculationType, value); }

    /// <summary>
    /// Field LP0098 [LP0098]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MidpointCancellation { get => _midpointCancellation; set => SetField(ref _midpointCancellation, value); }

    /// <summary>
    /// Field LP0048 [LP0048]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MinCreditScore { get => _minCreditScore; set => SetField(ref _minCreditScore, value); }

    /// <summary>
    /// Field LP00119 [LP00119]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MinimumAdvanceAmount { get => _minimumAdvanceAmount; set => SetField(ref _minimumAdvanceAmount, value); }

    /// <summary>
    /// Field LP00120 [LP00120]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MinimumAllowableApr { get => _minimumAllowableApr; set => SetField(ref _minimumAllowableApr, value); }

    /// <summary>
    /// Field LP00122 [LP00122]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MinimumPaymentAmount { get => _minimumPaymentAmount; set => SetField(ref _minimumPaymentAmount, value); }

    /// <summary>
    /// Field LP00121 [LP00121]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MinimumPaymentPercent { get => _minimumPaymentPercent; set => SetField(ref _minimumPaymentPercent, value); }

    /// <summary>
    /// Field LP00103 [LP00103]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MipPaidInCash { get => _mipPaidInCash; set => SetField(ref _mipPaidInCash, value); }

    /// <summary>
    /// Field LP00108 [LP00108]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<YOrN> Mmi { get => _mmi; set => SetField(ref _mmi, value); }

    /// <summary>
    /// Field LP0057 [LP0057]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MortgageInsuranceAdjustmentFactor1 { get => _mortgageInsuranceAdjustmentFactor1; set => SetField(ref _mortgageInsuranceAdjustmentFactor1, value); }

    /// <summary>
    /// Field LP0060 [LP0060]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MortgageInsuranceAdjustmentFactor2 { get => _mortgageInsuranceAdjustmentFactor2; set => SetField(ref _mortgageInsuranceAdjustmentFactor2, value); }

    /// <summary>
    /// Field LP0063 [LP0063]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MortgageInsuranceCancelPercent { get => _mortgageInsuranceCancelPercent; set => SetField(ref _mortgageInsuranceCancelPercent, value); }

    /// <summary>
    /// Field LP0059 [LP0059]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MortgageInsuranceMonthlyPayment1 { get => _mortgageInsuranceMonthlyPayment1; set => SetField(ref _mortgageInsuranceMonthlyPayment1, value); }

    /// <summary>
    /// Field LP0062 [LP0062]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MortgageInsuranceMonthlyPayment2 { get => _mortgageInsuranceMonthlyPayment2; set => SetField(ref _mortgageInsuranceMonthlyPayment2, value); }

    /// <summary>
    /// Field LP0058 [LP0058]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? MortgageInsuranceMonthsOfAdjustment1 { get => _mortgageInsuranceMonthsOfAdjustment1; set => SetField(ref _mortgageInsuranceMonthsOfAdjustment1, value); }

    /// <summary>
    /// Field LP0061 [LP0061]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? MortgageInsuranceMonthsOfAdjustment2 { get => _mortgageInsuranceMonthsOfAdjustment2; set => SetField(ref _mortgageInsuranceMonthsOfAdjustment2, value); }

    /// <summary>
    /// Field LP0001 [LP0001]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MortgageType { get => _mortgageType; set => SetField(ref _mortgageType, value); }

    /// <summary>
    /// Field LP0087 [LP0087]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? OtherAmortizationTypeDescription { get => _otherAmortizationTypeDescription; set => SetField(ref _otherAmortizationTypeDescription, value); }

    /// <summary>
    /// Field LP0096 [LP0096]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? OtherLoanPurposeDescription { get => _otherLoanPurposeDescription; set => SetField(ref _otherLoanPurposeDescription, value); }

    /// <summary>
    /// Field LP0085 [LP0085]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? OtherMortgageTypeDescription { get => _otherMortgageTypeDescription; set => SetField(ref _otherMortgageTypeDescription, value); }

    /// <summary>
    /// Field LP0037 [LP0037]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? PaymentAdjustmentDurationMonths { get => _paymentAdjustmentDurationMonths; set => SetField(ref _paymentAdjustmentDurationMonths, value); }

    /// <summary>
    /// Field LP0036 [LP0036]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? PaymentAdjustmentPeriodicCapPercent { get => _paymentAdjustmentPeriodicCapPercent; set => SetField(ref _paymentAdjustmentPeriodicCapPercent, value); }

    /// <summary>
    /// Field LP0052 [LP0052]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PaymentFactor { get => _paymentFactor; set => SetField(ref _paymentFactor, value); }

    /// <summary>
    /// Field LP0084 [LP0084]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PercentageOfRental { get => _percentageOfRental; set => SetField(ref _percentageOfRental, value); }

    /// <summary>
    /// Field LP00111 [LP00111]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PerDiemCalculationMethodType { get => _perDiemCalculationMethodType; set => SetField(ref _perDiemCalculationMethodType, value); }

    /// <summary>
    /// Field LP00109 [LP00109]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<YOrN> Pmi { get => _pmi; set => SetField(ref _pmi, value); }

    /// <summary>
    /// Field LP0070 [LP0070]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PrepaymentPenaltyIndicator { get => _prepaymentPenaltyIndicator; set => SetField(ref _prepaymentPenaltyIndicator, value); }

    /// <summary>
    /// Field LP0080 [LP0080]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ProgramCode { get => _programCode; set => SetField(ref _programCode, value); }

    /// <summary>
    /// Field LP0091 [LP0091]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PropertyInsurance { get => _propertyInsurance; set => SetField(ref _propertyInsurance, value); }

    /// <summary>
    /// Field LP0002 [LP0002]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PropertyUsageType { get => _propertyUsageType; set => SetField(ref _propertyUsageType, value); }

    /// <summary>
    /// Field LP0009 [LP0009]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? QualifyingRatePercent { get => _qualifyingRatePercent; set => SetField(ref _qualifyingRatePercent, value); }

    /// <summary>
    /// Field LP0029 [LP0029]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? RateAdjustmentDurationMonths { get => _rateAdjustmentDurationMonths; set => SetField(ref _rateAdjustmentDurationMonths, value); }

    /// <summary>
    /// Field LP0030 [LP0030]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? RateAdjustmentLifetimeCapPercent { get => _rateAdjustmentLifetimeCapPercent; set => SetField(ref _rateAdjustmentLifetimeCapPercent, value); }

    /// <summary>
    /// Field LP0026 [LP0026]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? RateAdjustmentPercent { get => _rateAdjustmentPercent; set => SetField(ref _rateAdjustmentPercent, value); }

    /// <summary>
    /// Field LP0028 [LP0028]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? RateAdjustmentSubsequentCapPercent { get => _rateAdjustmentSubsequentCapPercent; set => SetField(ref _rateAdjustmentSubsequentCapPercent, value); }

    /// <summary>
    /// Field LP0027 [LP0027]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? RateAdjustmentSubsequentRateAdjustmentMonths { get => _rateAdjustmentSubsequentRateAdjustmentMonths; set => SetField(ref _rateAdjustmentSubsequentRateAdjustmentMonths, value); }

    /// <summary>
    /// Field LP0038 [LP0038]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? RecastPaidMonths { get => _recastPaidMonths; set => SetField(ref _recastPaidMonths, value); }

    /// <summary>
    /// Field LP0039 [LP0039]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? RecastStopMonths { get => _recastStopMonths; set => SetField(ref _recastStopMonths, value); }

    /// <summary>
    /// Field LP0071 [LP0071]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RefundPaymentIndicator { get => _refundPaymentIndicator; set => SetField(ref _refundPaymentIndicator, value); }

    /// <summary>
    /// Field LP0008 [LP0008]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? RequestedInterestRatePercent { get => _requestedInterestRatePercent; set => SetField(ref _requestedInterestRatePercent, value); }

    /// <summary>
    /// Field LP0064 [LP0064]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RequiredDeposit { get => _requiredDeposit; set => SetField(ref _requiredDeposit, value); }

    /// <summary>
    /// Field LP0034 [LP0034]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? RoundPercent { get => _roundPercent; set => SetField(ref _roundPercent, value); }

    /// <summary>
    /// Field LP0035 [LP0035]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RoundType { get => _roundType; set => SetField(ref _roundType, value); }

    /// <summary>
    /// Field LP0068 [LP0068]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SecurityInterestInNameOf { get => _securityInterestInNameOf; set => SetField(ref _securityInterestInNameOf, value); }

    /// <summary>
    /// Field LP0069 [LP0069]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SecurityType { get => _securityType; set => SetField(ref _securityType, value); }

    /// <summary>
    /// Field LP0083 [LP0083]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? SubjectPropertyGrossRentalIncome { get => _subjectPropertyGrossRentalIncome; set => SetField(ref _subjectPropertyGrossRentalIncome, value); }

    /// <summary>
    /// Field LP00116 [LP00116]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? TeaserRate { get => _teaserRate; set => SetField(ref _teaserRate, value); }

    /// <summary>
    /// Field LP00126 [LP00126]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TerminationFeeAmount { get => _terminationFeeAmount; set => SetField(ref _terminationFeeAmount, value); }

    /// <summary>
    /// Field LP00127 [LP00127]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TerminationPeriodMonthsCount { get => _terminationPeriodMonthsCount; set => SetField(ref _terminationPeriodMonthsCount, value); }

    /// <summary>
    /// Field LP00117 [LP00117]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ThirdPartyFeeFrom { get => _thirdPartyFeeFrom; set => SetField(ref _thirdPartyFeeFrom, value); }

    /// <summary>
    /// Field LP00118 [LP00118]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ThirdPartyFeeTo { get => _thirdPartyFeeTo; set => SetField(ref _thirdPartyFeeTo, value); }

    /// <summary>
    /// Field LP0005 [LP0005]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Type { get => _type; set => SetField(ref _type, value); }

    /// <summary>
    /// Field LP00105 [LP00105]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? UseDaysInYears { get => _useDaysInYears; set => SetField(ref _useDaysInYears, value); }

    /// <summary>
    /// Field LP00106 [LP00106]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<YOrN> UsePitiForRatio { get => _usePitiForRatio; set => SetField(ref _usePitiForRatio, value); }

    /// <summary>
    /// Field LP0066 [LP0066]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? VariableRateFeature { get => _variableRateFeature; set => SetField(ref _variableRateFeature, value); }

    /// <summary>
    /// Field LP0095 [LP0095]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? YearlyTerm { get => _yearlyTerm; set => SetField(ref _yearlyTerm, value); }
}