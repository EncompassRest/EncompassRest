using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// PriceAdjustment
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(AdjustmentType) + "," + nameof(PriceAdjustmentType), SerializeWholeListWhenDirty = true)]
public sealed partial class PriceAdjustment : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PriceAdjustment AdjustmentType
    /// </summary>
    public StringEnumValue<AdjustmentType> AdjustmentType { get => GetValue<StringEnumValue<AdjustmentType>>(); set => SetValue(value); }

    /// <summary>
    /// PriceAdjustment Description
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PriceAdjustment Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PriceAdjustment PriceAdjustmentType
    /// </summary>
    public StringEnumValue<PriceAdjustmentType> PriceAdjustmentType { get => GetValue<StringEnumValue<PriceAdjustmentType>>(); set => SetValue(value); }

    /// <summary>
    /// PriceAdjustment Rate
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? Rate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PriceAdjustment RateLockAdjustmentType
    /// </summary>
    public StringEnumValue<RateLockAdjustmentType> RateLockAdjustmentType { get => GetValue<StringEnumValue<RateLockAdjustmentType>>(); set => SetValue(value); }
}