using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// RateLockBuydown
/// </summary>
public sealed partial class RateLockBuydown : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<int?>? _changeFrequencyMonths;
    private DirtyValue<decimal?>? _increaseRatePercent;
    private DirtyValue<int?>? _rateLockBuydownIndex;

    /// <summary>
    /// RateLockBuydownContract ChangeFrequencyMonths
    /// </summary>
    public int? ChangeFrequencyMonths { get => _changeFrequencyMonths; set => SetField(ref _changeFrequencyMonths, value); }

    /// <summary>
    /// RateLockBuydownContract IncreaseRatePercent
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? IncreaseRatePercent { get => _increaseRatePercent; set => SetField(ref _increaseRatePercent, value); }

    /// <summary>
    /// RateLockBuydownContract RateLockBuydownIndex
    /// </summary>
    public int? RateLockBuydownIndex { get => _rateLockBuydownIndex; set => SetField(ref _rateLockBuydownIndex, value); }
}