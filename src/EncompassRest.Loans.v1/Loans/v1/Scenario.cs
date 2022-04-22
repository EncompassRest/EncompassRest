using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Scenario
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Scenario : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Scenario All Other Monthly Payments [SCENNN20]
    /// </summary>
    public decimal? AllOtherMonthlyPayments { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Base Income [SCENNN08]
    /// </summary>
    public decimal? BaseIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Base Loan Amount [SCENNN04]
    /// </summary>
    public decimal? BaseLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Comments [SCENNN28]
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Created By [SCENNN27]
    /// </summary>
    public string? CreatedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Effective Prop Value [SCENNN01]
    /// </summary>
    public decimal? EffectivePropValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario HOA Fees [SCENNN16]
    /// </summary>
    public decimal? HoaFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Interested Party Contribution percent [SCENNN25]
    /// </summary>
    public decimal? InterestedPartyContribution { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Lease or Ground Rent [SCENNN17]
    /// </summary>
    public decimal? LeaseOrGroundRent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Total of All Monthly Payments [SCENNN21]
    /// </summary>
    public decimal? MonthlyPaymentTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Mortgage Insurance [SCENNN15]
    /// </summary>
    public decimal? MortgageInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Negative Cash Flow [SCENNN19]
    /// </summary>
    public decimal? NegativeCashFlow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Other Housing Expenses [SCENNN18]
    /// </summary>
    public decimal? OtherHousingExpenses { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Other Income [SCENNN09]
    /// </summary>
    public decimal? OtherIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Positive Cash Flow [SCENNN10]
    /// </summary>
    public decimal? PositiveCashFlow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Qual FICO  [SCENNN03]
    /// </summary>
    public int? QualFico { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Qualifying Rate [SCENNN07]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? QualifyingRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Required Amount [SCENNN22]
    /// </summary>
    public decimal? Required { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Name [SCENNN26]
    /// </summary>
    public string? ScenarioName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Second Mortgage P and I  [SCENNN06]
    /// </summary>
    public decimal? SecondMortgagePandI { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Subordinate Financing Amount [SCENNN02]
    /// </summary>
    public decimal? SubordinateFinancingAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Total Insurance [SCENNN11]
    /// </summary>
    public decimal? TotalInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Total Insurance Scenario Data [SCENNN13]
    /// </summary>
    public decimal? TotalInsuranceScenarioData { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Total Loan Amount [SCENNN05]
    /// </summary>
    public decimal? TotalLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Total Taxes [SCENNN12]
    /// </summary>
    public decimal? TotalTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Total Taxes Scenario Data [SCENNN14]
    /// </summary>
    public decimal? TotalTaxesScenarioData { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Verified Assets [SCENNN23]
    /// </summary>
    public decimal? VerifiedAssets { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Verified Assets Scenario Data [SCENNN24]
    /// </summary>
    public decimal? VerifiedAssetsScenarioData { get => GetValue<decimal?>(); set => SetValue(value); }
}