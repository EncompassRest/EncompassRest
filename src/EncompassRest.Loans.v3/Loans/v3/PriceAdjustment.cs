using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// PriceAdjustment
/// </summary>
public sealed partial class PriceAdjustment : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<StringEnumValue<AdjustmentType>>? _adjustmentType;
    private DirtyValue<string?>? _description;
    private DirtyValue<StringEnumValue<PriceAdjustmentType>>? _priceAdjustmentType;
    private DirtyValue<int?>? _priceAdjustmentTypeIndex;
    private DirtyValue<decimal?>? _rate;
    private DirtyValue<StringEnumValue<RateLockAdjustmentType>>? _rateLockAdjustmentType;

    /// <summary>
    /// PriceAdjustmentContract AdjustmentType
    /// </summary>
    public StringEnumValue<AdjustmentType> AdjustmentType { get => _adjustmentType; set => SetField(ref _adjustmentType, value); }

    /// <summary>
    /// PriceAdjustmentContract Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// PriceAdjustmentContract PriceAdjustmentType
    /// </summary>
    public StringEnumValue<PriceAdjustmentType> PriceAdjustmentType { get => _priceAdjustmentType; set => SetField(ref _priceAdjustmentType, value); }

    /// <summary>
    /// PriceAdjustmentContract PriceAdjustmentTypeIndex
    /// </summary>
    public int? PriceAdjustmentTypeIndex { get => _priceAdjustmentTypeIndex; set => SetField(ref _priceAdjustmentTypeIndex, value); }

    /// <summary>
    /// PriceAdjustmentContract Rate
    /// </summary>
    public decimal? Rate { get => _rate; set => SetField(ref _rate, value); }

    /// <summary>
    /// PriceAdjustmentContract RateLockAdjustmentType
    /// </summary>
    public StringEnumValue<RateLockAdjustmentType> RateLockAdjustmentType { get => _rateLockAdjustmentType; set => SetField(ref _rateLockAdjustmentType, value); }
}