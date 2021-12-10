using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Buydown
/// </summary>
public sealed partial class Buydown : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<int?>? _buydownIndex;
    private DirtyValue<decimal?>? _buydownRatePercent;
    private DirtyValue<int?>? _changeFrequencyMonthsCount;
    private DirtyValue<string?>? _durationMonthsCount;
    private DirtyValue<decimal?>? _fundBalanceAmount;
    private DirtyValue<decimal?>? _fundTotalAmount;
    private DirtyValue<decimal?>? _increaseRatePercent;
    private DirtyValue<int?>? _nonBorrowerChangeFrequencyMonthsCount;
    private DirtyValue<decimal?>? _nonBorrowerIncreaseRatePercent;
    private DirtyValue<int?>? _remainingMonthsCount;
    private DirtyValue<decimal?>? _subsidyAmount;

    /// <summary>
    /// BuydownContract BuydownIndex
    /// </summary>
    public int? BuydownIndex { get => _buydownIndex; set => SetField(ref _buydownIndex, value); }

    /// <summary>
    /// BuydownContract BuydownRatePercent
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BuydownRatePercent { get => _buydownRatePercent; set => SetField(ref _buydownRatePercent, value); }

    /// <summary>
    /// BuydownContract ChangeFrequencyMonthsCount
    /// </summary>
    public int? ChangeFrequencyMonthsCount { get => _changeFrequencyMonthsCount; set => SetField(ref _changeFrequencyMonthsCount, value); }

    /// <summary>
    /// Loan Info Buydown Terms [1557]
    /// </summary>
    public string? DurationMonthsCount { get => _durationMonthsCount; set => SetField(ref _durationMonthsCount, value); }

    /// <summary>
    /// BuydownContract FundBalanceAmount
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FundBalanceAmount { get => _fundBalanceAmount; set => SetField(ref _fundBalanceAmount, value); }

    /// <summary>
    /// BuydownContract FundTotalAmount
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FundTotalAmount { get => _fundTotalAmount; set => SetField(ref _fundTotalAmount, value); }

    /// <summary>
    /// BuydownContract IncreaseRatePercent
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? IncreaseRatePercent { get => _increaseRatePercent; set => SetField(ref _increaseRatePercent, value); }

    /// <summary>
    /// BuydownContract NonBorrowerChangeFrequencyMonthsCount
    /// </summary>
    public int? NonBorrowerChangeFrequencyMonthsCount { get => _nonBorrowerChangeFrequencyMonthsCount; set => SetField(ref _nonBorrowerChangeFrequencyMonthsCount, value); }

    /// <summary>
    /// BuydownContract NonBorrowerIncreaseRatePercent
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? NonBorrowerIncreaseRatePercent { get => _nonBorrowerIncreaseRatePercent; set => SetField(ref _nonBorrowerIncreaseRatePercent, value); }

    /// <summary>
    /// BuydownContract RemainingMonthsCount
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? RemainingMonthsCount { get => _remainingMonthsCount; set => SetField(ref _remainingMonthsCount, value); }

    /// <summary>
    /// BuydownContract SubsidyAmount
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? SubsidyAmount { get => _subsidyAmount; set => SetField(ref _subsidyAmount, value); }
}