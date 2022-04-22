namespace EncompassRest.Loans.v1;

/// <summary>
/// PriceAdjustmentLogRecord
/// </summary>
public sealed partial class PriceAdjustmentLogRecord : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PriceAdjustmentLogRecord Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PriceAdjustmentLogRecord Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PriceAdjustmentLogRecord Rate
    /// </summary>
    public decimal? Rate { get => GetValue<decimal?>(); set => SetValue(value); }
}