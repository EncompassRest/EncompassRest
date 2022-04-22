using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LoanProgram
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class LoanProgram : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Field LP00113 [LP00113]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<YOrN> Acquisition { get => GetValue<StringEnumValue<YOrN>>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0067 [LP0067]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AdditionalArmInformation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0082 [LP0082]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AllDateAndNumericalDisclosures { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00115 [LP00115]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? AnnualFeeNeeded { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0086 [LP0086]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ArmTypeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0075 [LP0075]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AssumptionOnYourProperty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0011 [LP0011]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BalloonLoanMaturityTermMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0013 [LP0013]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BuydownChangeFrequencyMonths1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0015 [LP0015]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BuydownChangeFrequencyMonths2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0017 [LP0017]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BuydownChangeFrequencyMonths3 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0019 [LP0019]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BuydownChangeFrequencyMonths4 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0021 [LP0021]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BuydownChangeFrequencyMonths5 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0023 [LP0023]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BuydownChangeFrequencyMonths6 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0012 [LP0012]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BuydownIncreaseRatePercent1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0014 [LP0014]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BuydownIncreaseRatePercent2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0016 [LP0016]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BuydownIncreaseRatePercent3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0018 [LP0018]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BuydownIncreaseRatePercent4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0020 [LP0020]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BuydownIncreaseRatePercent5 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0022 [LP0022]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BuydownIncreaseRatePercent6 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0099 [LP0099]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CalculateBasedOnRemainingBalance { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0097 [LP0097]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ClosingCostProgram { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0056 [LP0056]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ConstructionDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0055 [LP0055]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ConstructionInterestReserveAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00112 [LP00112]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ConstructionLoanMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0053 [LP0053]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? ConstructionPeriodMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0054 [LP0054]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? ConstructionRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0079 [LP0079]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Convertible { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0090 [LP0090]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CreditDisability { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0089 [LP0089]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CreditLifeInsurance { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0065 [LP0065]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DemandFeature { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0088 [LP0088]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00110 [LP00110]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DisclosureType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00123 [LP00123]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Discounted { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00124 [LP00124]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? DiscountedRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00125 [LP00125]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DrawRepayPeriodTableName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00101 [LP00101]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FhaUpfrontMiPremiumPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0092 [LP0092]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? FloodInsurance { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0033 [LP0033]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? FloorPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00104 [LP00104]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FundingFeePaidInCash { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0043 [LP0043]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? GpmExtraPaymentForEarlyPayOff { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0041 [LP0041]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? GpmRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0042 [LP0042]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? GpmYears { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0093 [LP0093]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? IfYouPurchase { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0094 [LP0094]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? IfYouPurchaseType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0032 [LP0032]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? IndexCurrentValuePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0031 [LP0031]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? IndexMarginPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00114 [LP00114]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? InitialAdvanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0025 [LP0025]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? InterestOnlyMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0072 [LP0072]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? LateChargeDays { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0073 [LP0073]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? LateChargePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0074 [LP0074]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LateChargeType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0051 [LP0051]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LenderInvestorCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0003 [LP0003]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LienPriorityType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0010 [LP0010]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? LoanAmortizationTermMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0007 [LP0007]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LoanAmortizationType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00107 [LP00107]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LoanDocumentationType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0024 [LP0024]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LoanFeaturesPaymentFrequencyType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0044 [LP0044]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LoanProgramName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00102 [LP00102]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<YOrN> LockField { get => GetValue<StringEnumValue<YOrN>>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0050 [LP0050]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MaxBackRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0047 [LP0047]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MaxCltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0049 [LP0049]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MaxFrontRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0040 [LP0040]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MaximumBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0045 [LP0045]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MaxLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0046 [LP0046]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MaxLtv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0081 [LP0081]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MeansAnEstimate { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00100 [LP00100]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MiCalculationType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0098 [LP0098]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MidpointCancellation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0048 [LP0048]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MinCreditScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00119 [LP00119]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MinimumAdvanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00120 [LP00120]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MinimumAllowableApr { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00122 [LP00122]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MinimumPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00121 [LP00121]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MinimumPaymentPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00103 [LP00103]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MipPaidInCash { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00108 [LP00108]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<YOrN> Mmi { get => GetValue<StringEnumValue<YOrN>>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0057 [LP0057]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MortgageInsuranceAdjustmentFactor1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0060 [LP0060]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MortgageInsuranceAdjustmentFactor2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0063 [LP0063]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MortgageInsuranceCancelPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0059 [LP0059]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MortgageInsuranceMonthlyPayment1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0062 [LP0062]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MortgageInsuranceMonthlyPayment2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0058 [LP0058]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? MortgageInsuranceMonthsOfAdjustment1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0061 [LP0061]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? MortgageInsuranceMonthsOfAdjustment2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0001 [LP0001]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MortgageType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0087 [LP0087]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? OtherAmortizationTypeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0096 [LP0096]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? OtherLoanPurposeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0085 [LP0085]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? OtherMortgageTypeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0037 [LP0037]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? PaymentAdjustmentDurationMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0036 [LP0036]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? PaymentAdjustmentPeriodicCapPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0052 [LP0052]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PaymentFactor { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0084 [LP0084]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PercentageOfRental { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00111 [LP00111]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PerDiemCalculationMethodType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00109 [LP00109]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<YOrN> Pmi { get => GetValue<StringEnumValue<YOrN>>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0070 [LP0070]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PrepaymentPenaltyIndicator { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0080 [LP0080]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ProgramCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0091 [LP0091]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PropertyInsurance { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0002 [LP0002]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PropertyUsageType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0009 [LP0009]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? QualifyingRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0029 [LP0029]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? RateAdjustmentDurationMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0030 [LP0030]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? RateAdjustmentLifetimeCapPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0026 [LP0026]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? RateAdjustmentPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0028 [LP0028]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? RateAdjustmentSubsequentCapPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0027 [LP0027]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? RateAdjustmentSubsequentRateAdjustmentMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0038 [LP0038]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? RecastPaidMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0039 [LP0039]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? RecastStopMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0071 [LP0071]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RefundPaymentIndicator { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0008 [LP0008]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? RequestedInterestRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0064 [LP0064]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RequiredDeposit { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0034 [LP0034]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? RoundPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0035 [LP0035]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RoundType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0068 [LP0068]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SecurityInterestInNameOf { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0069 [LP0069]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SecurityType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0083 [LP0083]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? SubjectPropertyGrossRentalIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00116 [LP00116]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? TeaserRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00126 [LP00126]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TerminationFeeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00127 [LP00127]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TerminationPeriodMonthsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00117 [LP00117]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ThirdPartyFeeFrom { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00118 [LP00118]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ThirdPartyFeeTo { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0005 [LP0005]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Type { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00105 [LP00105]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? UseDaysInYears { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP00106 [LP00106]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<YOrN> UsePitiForRatio { get => GetValue<StringEnumValue<YOrN>>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0066 [LP0066]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? VariableRateFeature { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field LP0095 [LP0095]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? YearlyTerm { get => GetValue<decimal?>(); set => SetValue(value); }
}