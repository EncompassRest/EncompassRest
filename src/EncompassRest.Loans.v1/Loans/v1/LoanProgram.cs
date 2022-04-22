using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LoanProgram
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class LoanProgram : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LoanProgram Acquisition [LPNN113]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<YOrN> Acquisition { get => GetValue<StringEnumValue<YOrN>>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram AdditionalArmInformation [LPNN67]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AdditionalArmInformation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram AllDateAndNumericalDisclosures [LPNN82]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AllDateAndNumericalDisclosures { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram AnnualFeeNeeded [LPNN115]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? AnnualFeeNeeded { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram ArmTypeDescription [LPNN86]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ArmTypeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram AssumptionOnYourProperty [LPNN75]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AssumptionOnYourProperty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram BalloonLoanMaturityTermMonths [LPNN11]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BalloonLoanMaturityTermMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram BuydownChangeFrequencyMonths1 [LPNN13]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BuydownChangeFrequencyMonths1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram BuydownChangeFrequencyMonths2 [LPNN15]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BuydownChangeFrequencyMonths2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram BuydownChangeFrequencyMonths3 [LPNN17]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BuydownChangeFrequencyMonths3 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram BuydownChangeFrequencyMonths4 [LPNN19]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BuydownChangeFrequencyMonths4 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram BuydownChangeFrequencyMonths5 [LPNN21]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BuydownChangeFrequencyMonths5 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram BuydownChangeFrequencyMonths6 [LPNN23]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BuydownChangeFrequencyMonths6 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram BuydownIncreaseRatePercent1 [LPNN12]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BuydownIncreaseRatePercent1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram BuydownIncreaseRatePercent2 [LPNN14]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BuydownIncreaseRatePercent2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram BuydownIncreaseRatePercent3 [LPNN16]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BuydownIncreaseRatePercent3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram BuydownIncreaseRatePercent4 [LPNN18]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BuydownIncreaseRatePercent4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram BuydownIncreaseRatePercent5 [LPNN20]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BuydownIncreaseRatePercent5 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram BuydownIncreaseRatePercent6 [LPNN22]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BuydownIncreaseRatePercent6 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram CalculateBasedOnRemainingBalance [LPNN99]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CalculateBasedOnRemainingBalance { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram ClosingCostProgram [LPNN97]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ClosingCostProgram { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram ConstructionDescription [LPNN56]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ConstructionDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram ConstructionInterestReserveAmount [LPNN55]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ConstructionInterestReserveAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram ConstructionLoanMethod [LPNN112]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ConstructionLoanMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram ConstructionPeriodMonths [LPNN53]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? ConstructionPeriodMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram ConstructionRate [LPNN54]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? ConstructionRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram Convertible [LPNN79]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Convertible { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram CreditDisability [LPNN90]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CreditDisability { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram CreditLifeInsurance [LPNN89]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CreditLifeInsurance { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram DemandFeature [LPNN65]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DemandFeature { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram Description [LPNN88]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram DisclosureType [LPNN110]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DisclosureType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram Discounted [LPNN123]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Discounted { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram DiscountedRate [LPNN124]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? DiscountedRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram DrawRepayPeriodTableName [LPNN125]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DrawRepayPeriodTableName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram FhaUpfrontMiPremiumPercent [LPNN101]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FhaUpfrontMiPremiumPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram FloodInsurance [LPNN92]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? FloodInsurance { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram FloorPercent [LPNN33]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? FloorPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram FundingFeePaidInCash [LPNN104]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FundingFeePaidInCash { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram GpmExtraPaymentForEarlyPayOff [LPNN43]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? GpmExtraPaymentForEarlyPayOff { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram GpmRate [LPNN41]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? GpmRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram GpmYears [LPNN42]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? GpmYears { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram IfYouPurchase [LPNN93]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? IfYouPurchase { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram IfYouPurchaseType [LPNN94]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? IfYouPurchaseType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram IndexCurrentValuePercent [LPNN32]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? IndexCurrentValuePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram IndexMarginPercent [LPNN31]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? IndexMarginPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram InitialAdvanceAmount [LPNN114]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? InitialAdvanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram InterestOnlyMonths [LPNN25]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? InterestOnlyMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram LateChargeDays [LPNN72]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? LateChargeDays { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram LateChargePercent [LPNN73]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? LateChargePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram LateChargeType [LPNN74]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LateChargeType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram LenderInvestorCode [LPNN51]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LenderInvestorCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram LienPriorityType [LPNN03]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LienPriorityType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram LoanAmortizationTermMonths [LPNN10]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? LoanAmortizationTermMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram LoanAmortizationType [LPNN07]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LoanAmortizationType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram LoanDocumentationType [LPNN107]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LoanDocumentationType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram LoanFeaturesPaymentFrequencyType [LPNN24]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LoanFeaturesPaymentFrequencyType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram LoanProgramName [LPNN44]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LoanProgramName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram LockField [LPNN102]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<YOrN> LockField { get => GetValue<StringEnumValue<YOrN>>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MaxBackRatio [LPNN50]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MaxBackRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MaxCltv [LPNN47]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MaxCltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MaxFrontRatio [LPNN49]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MaxFrontRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MaximumBalance [LPNN40]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MaximumBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MaxLoanAmount [LPNN45]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MaxLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MaxLtv [LPNN46]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MaxLtv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MeansAnEstimate [LPNN81]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MeansAnEstimate { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MiCalculationType [LPNN100]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MiCalculationType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MidpointCancellation [LPNN98]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MidpointCancellation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MinCreditScore [LPNN48]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MinCreditScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MinimumAdvanceAmount [LPNN119]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MinimumAdvanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MinimumAllowableApr [LPNN120]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MinimumAllowableApr { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MinimumPaymentAmount [LPNN122]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MinimumPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MinimumPaymentPercent [LPNN121]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MinimumPaymentPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MipPaidInCash [LPNN103]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MipPaidInCash { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram Mmi [LPNN108]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<YOrN> Mmi { get => GetValue<StringEnumValue<YOrN>>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MortgageInsuranceAdjustmentFactor1 [LPNN57]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MortgageInsuranceAdjustmentFactor1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MortgageInsuranceAdjustmentFactor2 [LPNN60]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MortgageInsuranceAdjustmentFactor2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MortgageInsuranceCancelPercent [LPNN63]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MortgageInsuranceCancelPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MortgageInsuranceMonthlyPayment1 [LPNN59]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MortgageInsuranceMonthlyPayment1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MortgageInsuranceMonthlyPayment2 [LPNN62]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MortgageInsuranceMonthlyPayment2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MortgageInsuranceMonthsOfAdjustment1 [LPNN58]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? MortgageInsuranceMonthsOfAdjustment1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MortgageInsuranceMonthsOfAdjustment2 [LPNN61]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? MortgageInsuranceMonthsOfAdjustment2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram MortgageType [LPNN01]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MortgageType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram OtherAmortizationTypeDescription [LPNN87]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? OtherAmortizationTypeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram OtherLoanPurposeDescription [LPNN96]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? OtherLoanPurposeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram OtherMortgageTypeDescription [LPNN85]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? OtherMortgageTypeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram PaymentAdjustmentDurationMonths [LPNN37]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? PaymentAdjustmentDurationMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram PaymentAdjustmentPeriodicCapPercent [LPNN36]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? PaymentAdjustmentPeriodicCapPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram PaymentFactor [LPNN52]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PaymentFactor { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram PercentageOfRental [LPNN84]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PercentageOfRental { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram PerDiemCalculationMethodType [LPNN111]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PerDiemCalculationMethodType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram Pmi [LPNN109]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<YOrN> Pmi { get => GetValue<StringEnumValue<YOrN>>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram PrepaymentPenaltyIndicator [LPNN70]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PrepaymentPenaltyIndicator { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram ProgramCode [LPNN80]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ProgramCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram PropertyInsurance [LPNN91]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PropertyInsurance { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram PropertyUsageType [LPNN02]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PropertyUsageType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram QualifyingRatePercent [LPNN09]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? QualifyingRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram RateAdjustmentDurationMonths [LPNN29]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? RateAdjustmentDurationMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram RateAdjustmentLifetimeCapPercent [LPNN30]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? RateAdjustmentLifetimeCapPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram RateAdjustmentPercent [LPNN26]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? RateAdjustmentPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram RateAdjustmentSubsequentCapPercent [LPNN28]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? RateAdjustmentSubsequentCapPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram RateAdjustmentSubsequentRateAdjustmentMonths [LPNN27]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? RateAdjustmentSubsequentRateAdjustmentMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram RecastPaidMonths [LPNN38]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? RecastPaidMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram RecastStopMonths [LPNN39]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? RecastStopMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram RefundPaymentIndicator [LPNN71]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RefundPaymentIndicator { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram RequestedInterestRatePercent [LPNN08]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? RequestedInterestRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram RequiredDeposit [LPNN64]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RequiredDeposit { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram RoundPercent [LPNN34]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? RoundPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram RoundType [LPNN35]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RoundType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram SecurityInterestInNameOf [LPNN68]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SecurityInterestInNameOf { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram SecurityType [LPNN69]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SecurityType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram SubjectPropertyGrossRentalIncome [LPNN83]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? SubjectPropertyGrossRentalIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram TeaserRate [LPNN116]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? TeaserRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram TerminationFeeAmount [LPNN126]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TerminationFeeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram TerminationPeriodMonthsCount [LPNN127]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TerminationPeriodMonthsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram ThirdPartyFeeFrom [LPNN117]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ThirdPartyFeeFrom { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram ThirdPartyFeeTo [LPNN118]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ThirdPartyFeeTo { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram Type [LPNN05]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Type { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram UseDaysInYears [LPNN105]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? UseDaysInYears { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram UsePitiForRatio [LPNN106]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<YOrN> UsePitiForRatio { get => GetValue<StringEnumValue<YOrN>>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram VariableRateFeature [LPNN66]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? VariableRateFeature { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanProgram YearlyTerm [LPNN95]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? YearlyTerm { get => GetValue<decimal?>(); set => SetValue(value); }
}