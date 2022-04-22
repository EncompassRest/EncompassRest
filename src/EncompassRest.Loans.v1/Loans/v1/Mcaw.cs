using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Mcaw
/// </summary>
public sealed partial class Mcaw : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// FHA MCAW Borr Rating Avail Assets [1167]
    /// </summary>
    public StringEnumValue<AcceptOrReject> AdequacyOfAvailableAssetsType { get => GetValue<StringEnumValue<AcceptOrReject>>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Borr Rating Effective Income [1165]
    /// </summary>
    public StringEnumValue<AcceptOrReject> AdequacyOfEffectiveIncomeType { get => GetValue<StringEnumValue<AcceptOrReject>>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Adjusted Purchase Price [MCAWPUR.X28]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? AdjustedPurchasePrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Mtg Basis Calc 1 [1154]
    /// </summary>
    public decimal? AppraisedValue1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Mtg Basis Calc 2 [1157]
    /// </summary>
    public decimal? AppraisedValue2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Mcaw BorrowerPaidClosingCost [SLREFI.X34]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BorrowerPaidClosingCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Max Mtg Amt [MCAWPUR.X25]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CalculatedMortgageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Cash Reserves [MCAWPUR.X11]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CashReserves { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Constr Loan Type [1067]
    /// </summary>
    public StringEnumValue<ConstructionType> ConstructionType { get => GetValue<StringEnumValue<ConstructionType>>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Contract Sales Price [MCAWPUR.X12]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ContractSalesPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Borr Rating Credit Characteristics [1164]
    /// </summary>
    public StringEnumValue<AcceptOrReject> CreditCharacteristicsType { get => GetValue<StringEnumValue<AcceptOrReject>>(); set => SetValue(value); }

    /// <summary>
    /// Mcaw EquityToExSpouse [SLREFI.X8]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? EquityToExSpouse { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Max County Loan Amount [MCAWPUR.X27]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FhaMaxLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Underwriter CHUMS ID [980]
    /// </summary>
    public string? FhaUnderwriterChumsId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Gift Funds Source [MCAWPUR.X9]
    /// </summary>
    public StringEnumValue<GiftFundsSource> GiftFundsSource { get => GetValue<StringEnumValue<GiftFundsSource>>(); set => SetValue(value); }

    /// <summary>
    /// Mcaw Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Lesser of Sales Price or Value [MCAWPUR.X13]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LesserSalesPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Loan-to-Value Ratio [MCAWPUR.X21]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? Ltv1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Ratio Loan-to-Value [GMCAW.X6]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? Ltv2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Maximum Seller Contribution (4%) [4180]
    /// </summary>
    public decimal? MaximumSellerContribution4Percent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Mtg Amt [MCAWPUR.X14]
    /// </summary>
    public decimal? MortgageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Max Mtg Calc LTV Factor [MCAWPUR.X5]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MortgageAmountPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Mtg Basis [1090]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MortgageBasisPurchase { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Mortgage Basis [GMCAW.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MortgageBasisRefinance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Amt Paid Type [943]
    /// </summary>
    public StringEnumValue<PaidType> PaidType1 { get => GetValue<StringEnumValue<PaidType>>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Amt to be Paid Type [945]
    /// </summary>
    public StringEnumValue<PaidType> PaidType2 { get => GetValue<StringEnumValue<PaidType>>(); set => SetValue(value); }

    /// <summary>
    /// Mcaw PrincipalBalance [SLREFI.X6]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PrincipalBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Refi Type [1669]
    /// </summary>
    public StringEnumValue<RefinanceType> RefinanceType { get => GetValue<StringEnumValue<RefinanceType>>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Remarks [1228]
    /// </summary>
    public string? Remarks { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Repairs/Improvements [MCAWPUR.X7]
    /// </summary>
    public decimal? RepairsAndImprovements { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Repairs/Improvements Descr [1670]
    /// </summary>
    public string? RepairsAndImprovementsDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Repairs or Improvement Amount [MCAWPUR.X29]
    /// </summary>
    public decimal? RepairsImprovementAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Mcaw RepairsRequiredByAppraiser [SLREFI.X33]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? RepairsRequiredByAppraiser { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Required Investment [1135]
    /// </summary>
    public decimal? RequiredInvestment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Required Adj [MCAWPUR.X3]
    /// </summary>
    public decimal? RequirementAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Process Management Solution Round To $50 [SYS.X11]
    /// </summary>
    public bool? RoundTo50Indicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Mcaw SeasonedSubordinateLiens [SLREFI.X9]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? SeasonedSubordinateLiens { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW 2nd Mtg Source [MCAWPUR.X10]
    /// </summary>
    public string? SecondMortgageSource { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Attach A Info A2:6% of Line A1 [1116]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? SixPercentOfLineA1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Borr Rating Effective Income Stability [1166]
    /// </summary>
    public StringEnumValue<AcceptOrReject> StabilityOfEffectiveIncomeType { get => GetValue<StringEnumValue<AcceptOrReject>>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Statutory Investment Requir [MCAWPUR.X2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? StatutoryInvestment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Amt to be paid in Cash /Other [1139]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ToBePaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Total Cash to Close [MCAWPUR.X8]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalCashToClose { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Total Requirements [1138]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalRequirements { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Total Seller Contribution [135]
    /// </summary>
    public decimal? TotalSellerContribution { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Unadj Acquisition [MCAWPUR.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? UnadjustedAcquisition { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Appraised Value - Mult by 85% Check Box [1983]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"multiplied by 85%\"}")]
    public bool? Use85PercentRuleIndicator { get => GetValue<bool?>(); set => SetValue(value); }
}