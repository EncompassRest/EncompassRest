using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Asset
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(AssetType) + "," + nameof(AssetTypeIndex))]
public sealed partial class Asset : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Asset AccountIdentifier [182], [1715]
    /// </summary>
    public string? AccountIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Asset AssetType
    /// </summary>
    public StringEnumValue<AssetType> AssetType { get => GetValue<StringEnumValue<AssetType>>(); set => SetValue(value); }

    /// <summary>
    /// Asset AssetTypeIndex
    /// </summary>
    public int? AssetTypeIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Asset CashOrMarketValueAmount
    /// </summary>
    public decimal? CashOrMarketValueAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Asset Country
    /// </summary>
    public string? Country { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Asset Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Asset ForeignAddressIndicator
    /// </summary>
    public bool? ForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Asset HolderName
    /// </summary>
    public string? HolderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Assets Life Ins Face Amt [303]
    /// </summary>
    public decimal? LifeInsuranceFaceValueAmount { get => GetValue<decimal?>(); set => SetValue(value); }
}