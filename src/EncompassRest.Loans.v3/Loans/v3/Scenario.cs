using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Scenario
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Scenario : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Scenario All Other Monthly Payments [SCEN0020]
    /// </summary>
    public decimal? AllOtherMonthlyPayments { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Base Income [SCEN0008]
    /// </summary>
    public decimal? BaseIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Base Loan Amount [SCEN0004]
    /// </summary>
    public decimal? BaseLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Comments [SCEN0028]
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Created By [SCEN0027]
    /// </summary>
    public string? CreatedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Effective Prop Value [SCEN0001]
    /// </summary>
    public decimal? EffectivePropValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario HOA Fees [SCEN0016]
    /// </summary>
    public decimal? HoaFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Interested Party Contribution percent [SCEN0025]
    /// </summary>
    public decimal? InterestedPartyContribution { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Lease or Ground Rent [SCEN0017]
    /// </summary>
    public decimal? LeaseOrGroundRent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Total of All Monthly Payments [SCEN0021]
    /// </summary>
    public decimal? MonthlyPaymentTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Mortgage Insurance [SCEN0015]
    /// </summary>
    public decimal? MortgageInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Negative Cash Flow [SCEN0019]
    /// </summary>
    public decimal? NegativeCashFlow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Other Housing Expenses [SCEN0018]
    /// </summary>
    public decimal? OtherHousingExpenses { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Other Income [SCEN0009]
    /// </summary>
    public decimal? OtherIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Positive Cash Flow [SCEN0010]
    /// </summary>
    public decimal? PositiveCashFlow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Qual FICO  [SCEN0003]
    /// </summary>
    public int? QualFico { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Qualifying Rate [SCEN0007]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? QualifyingRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Required Amount [SCEN0022]
    /// </summary>
    public decimal? Required { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Name [SCEN0026]
    /// </summary>
    public string? ScenarioName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Second Mortgage P and I  [SCEN0006]
    /// </summary>
    public decimal? SecondMortgagePandI { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Subordinate Financing Amount [SCEN0002]
    /// </summary>
    public decimal? SubordinateFinancingAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Total Insurance [SCEN0011]
    /// </summary>
    public decimal? TotalInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Total Insurance Scenario Data [SCEN0013]
    /// </summary>
    public decimal? TotalInsuranceScenarioData { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Total Loan Amount [SCEN0005]
    /// </summary>
    public decimal? TotalLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Total Taxes [SCEN0012]
    /// </summary>
    public decimal? TotalTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Total Taxes Scenario Data [SCEN0014]
    /// </summary>
    public decimal? TotalTaxesScenarioData { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Verified Assets [SCEN0023]
    /// </summary>
    public decimal? VerifiedAssets { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Scenario Verified Assets Scenario Data [SCEN0024]
    /// </summary>
    public decimal? VerifiedAssetsScenarioData { get => GetValue<decimal?>(); set => SetValue(value); }
}