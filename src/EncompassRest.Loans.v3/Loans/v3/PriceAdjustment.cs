using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// PriceAdjustment
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(AdjustmentType) + "," + nameof(PriceAdjustmentType) + "," + nameof(PriceAdjustmentTypeIndex))]
public sealed partial class PriceAdjustment : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PriceAdjustment AdjustmentType
    /// </summary>
    public StringEnumValue<AdjustmentType> AdjustmentType { get => GetValue<StringEnumValue<AdjustmentType>>(); set => SetValue(value); }

    /// <summary>
    /// PriceAdjustment Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PriceAdjustment PriceAdjustmentType
    /// </summary>
    public StringEnumValue<PriceAdjustmentType> PriceAdjustmentType { get => GetValue<StringEnumValue<PriceAdjustmentType>>(); set => SetValue(value); }

    /// <summary>
    /// PriceAdjustment PriceAdjustmentTypeIndex
    /// </summary>
    public int? PriceAdjustmentTypeIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// PriceAdjustment Rate
    /// </summary>
    public decimal? Rate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PriceAdjustment RateLockAdjustmentType
    /// </summary>
    public StringEnumValue<RateLockAdjustmentType> RateLockAdjustmentType { get => GetValue<StringEnumValue<RateLockAdjustmentType>>(); set => SetValue(value); }
}