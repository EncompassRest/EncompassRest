using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// RateLockBuydown
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(RateLockBuydownIndex))]
public sealed partial class RateLockBuydown : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// RateLockBuydown ChangeFrequencyMonths
    /// </summary>
    public int? ChangeFrequencyMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// RateLockBuydown IncreaseRatePercent
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? IncreaseRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RateLockBuydown RateLockBuydownIndex
    /// </summary>
    public int? RateLockBuydownIndex { get => GetValue<int?>(); set => SetValue(value); }
}