using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// PrequalificationScenario
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class PrequalificationScenario : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PrequalificationScenario AppraisedValue [PREQUAL.X254], [PREQUAL.X255]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? AppraisedValue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario Apr [PREQUAL.X48], [PREQUAL.X88]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? Apr { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario CashToClose [PREQUAL.X44], [PREQUAL.X84]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CashToClose { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario ClosingCost [PREQUAL.X43], [PREQUAL.X83]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ClosingCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario Cltv
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Cltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario Comments
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario CreditScore [PREQUAL.X305], [PREQUAL.X306]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CreditScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario CurrentStatus [PREQUAL.X303], [PREQUAL.X304]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CurrentStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario DownPaymentAmount [PREQUAL.X234], [PREQUAL.X240]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? DownPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario DownPaymentPercent [PREQUAL.X233], [PREQUAL.X239]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? DownPaymentPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario FhaUpfrontMIPremiumPercent [PREQUAL.X295], [PREQUAL.X296]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? FhaUpfrontMIPremiumPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario GrossNegativeCashFlow [PREQUAL.X301], [PREQUAL.X302]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? GrossNegativeCashFlow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario LoanAmount [PREQUAL.X34], [PREQUAL.X74]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario Ltv
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Ltv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario MaximumDebt
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MaximumDebt { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario MaximumLoanAmount
    /// </summary>
    public decimal? MaximumLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario MiAndFundingFeeFinancedAmount [PREQUAL.X297], [PREQUAL.X298]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MiAndFundingFeeFinancedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario MinimumIncome
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MinimumIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario MonthlyPayment [PREQUAL.X256], [PREQUAL.X257]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario PrepaidItemsEstimatedAmount [PREQUAL.X282], [PREQUAL.X283]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PrepaidItemsEstimatedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario PrequalificationScenarioIndex
    /// </summary>
    public int? PrequalificationScenarioIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario QualBottomRatioPercent [PREQUAL.X238], [PREQUAL.X244]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? QualBottomRatioPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario QualTopRatioPercent [PREQUAL.X237], [PREQUAL.X243]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? QualTopRatioPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario SalesPrice [PREQUAL.X33], [PREQUAL.X73]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? SalesPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario SubordinateFin [PREQUAL.X236], [PREQUAL.X242]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? SubordinateFin { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario TotalBaseCost
    /// </summary>
    public decimal? TotalBaseCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario TotalCashAvailable [PREQUAL.X290], [PREQUAL.X291]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalCashAvailable { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario TotalCashLeft
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalCashLeft { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario TotalCosts [PREQUAL.X284], [PREQUAL.X285]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalCosts { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario TotalFinancing [PREQUAL.X288], [PREQUAL.X289]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalFinancing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario TotalHe [PREQUAL.X235], [PREQUAL.X241]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalHe { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario TotalIncome [PREQUAL.X266], [PREQUAL.X267]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario TotalLoanAmount [PREQUAL.X299], [PREQUAL.X300]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario TotalOtherExpense [PREQUAL.X268], [PREQUAL.X269]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalOtherExpense { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario TotalPaidOffMortgage
    /// </summary>
    public decimal? TotalPaidOffMortgage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario TotalPaidOffOthers
    /// </summary>
    public decimal? TotalPaidOffOthers { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrequalificationScenario TotalPayments [PREQUAL.X258], [PREQUAL.X259]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalPayments { get => GetValue<decimal?>(); set => SetValue(value); }
}