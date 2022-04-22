using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// GfeFee
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(GfeFeeIndex) + "," + nameof(GfeFeeType))]
public sealed partial class GfeFee : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// GfeFee AmountDescription [1663], [1665]
    /// </summary>
    public string? AmountDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GfeFee BrokerAmount
    /// </summary>
    public decimal? BrokerAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// GfeFee Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GfeFee GfeFeeIndex
    /// </summary>
    public int? GfeFeeIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// GfeFee GfeFeeType
    /// </summary>
    public StringEnumValue<GfeFeeType> GfeFeeType { get => GetValue<StringEnumValue<GfeFeeType>>(); set => SetValue(value); }

    /// <summary>
    /// GfeFee OtherAmount
    /// </summary>
    public decimal? OtherAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// GfeFee Rate [1847], [1848]
    /// </summary>
    public string? Rate { get => GetValue<string?>(); set => SetValue(value); }
}