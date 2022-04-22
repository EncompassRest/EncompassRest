using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Buydown
/// </summary>
public sealed partial class Buydown : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Buydown BuydownIndex
    /// </summary>
    public int? BuydownIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Buydown BuydownRatePercent
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BuydownRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Buydown ChangeFrequencyMonthsCount
    /// </summary>
    public int? ChangeFrequencyMonthsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Buydown Terms [1557]
    /// </summary>
    public string? DurationMonthsCount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Buydown FundBalanceAmount
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FundBalanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Buydown FundTotalAmount
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FundTotalAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Buydown IncreaseRatePercent
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? IncreaseRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Buydown NonBorrowerChangeFrequencyMonthsCount
    /// </summary>
    public int? NonBorrowerChangeFrequencyMonthsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Buydown NonBorrowerIncreaseRatePercent
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? NonBorrowerIncreaseRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Buydown RemainingMonthsCount
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? RemainingMonthsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Buydown SubsidyAmount
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? SubsidyAmount { get => GetValue<decimal?>(); set => SetValue(value); }
}