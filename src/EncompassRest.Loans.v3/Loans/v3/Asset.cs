using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Asset
/// </summary>
public sealed partial class Asset : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _accountIdentifier;
    private DirtyValue<StringEnumValue<AssetType>>? _assetType;
    private DirtyValue<int?>? _assetTypeIndex;
    private DirtyValue<decimal?>? _cashOrMarketValueAmount;
    private DirtyValue<string?>? _country;
    private DirtyValue<string?>? _description;
    private DirtyValue<bool?>? _foreignAddressIndicator;
    private DirtyValue<string?>? _holderName;
    private DirtyValue<decimal?>? _lifeInsuranceFaceValueAmount;

    /// <summary>
    /// AssetContract AccountIdentifier [182], [1715]
    /// </summary>
    public string? AccountIdentifier { get => _accountIdentifier; set => SetField(ref _accountIdentifier, value); }

    /// <summary>
    /// AssetContract AssetType
    /// </summary>
    public StringEnumValue<AssetType> AssetType { get => _assetType; set => SetField(ref _assetType, value); }

    /// <summary>
    /// AssetContract AssetTypeIndex
    /// </summary>
    public int? AssetTypeIndex { get => _assetTypeIndex; set => SetField(ref _assetTypeIndex, value); }

    /// <summary>
    /// AssetContract CashOrMarketValueAmount
    /// </summary>
    public decimal? CashOrMarketValueAmount { get => _cashOrMarketValueAmount; set => SetField(ref _cashOrMarketValueAmount, value); }

    /// <summary>
    /// AssetContract Country
    /// </summary>
    public string? Country { get => _country; set => SetField(ref _country, value); }

    /// <summary>
    /// AssetContract Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// AssetContract ForeignAddressIndicator
    /// </summary>
    public bool? ForeignAddressIndicator { get => _foreignAddressIndicator; set => SetField(ref _foreignAddressIndicator, value); }

    /// <summary>
    /// AssetContract HolderName
    /// </summary>
    public string? HolderName { get => _holderName; set => SetField(ref _holderName, value); }

    /// <summary>
    /// Assets Life Ins Face Amt [303]
    /// </summary>
    public decimal? LifeInsuranceFaceValueAmount { get => _lifeInsuranceFaceValueAmount; set => SetField(ref _lifeInsuranceFaceValueAmount, value); }
}