using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// VodItem
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class VodItem : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _accountIdentifier;
    private DirtyValue<decimal?>? _cashOrMarketValueAmount;
    private DirtyValue<string?>? _country;
    private DirtyValue<string?>? _depositoryAccountName;
    private DirtyValue<bool?>? _foreignAddressIndicator;
    private DirtyValue<int?>? _itemNumber;
    private DirtyValue<StringEnumValue<AssetType>>? _type;
    private DirtyValue<decimal?>? _urla2020CashOrMarketValueAmount;

    /// <summary>
    /// VodItemContract AccountIdentifier
    /// </summary>
    public string? AccountIdentifier { get => _accountIdentifier; set => SetField(ref _accountIdentifier, value); }

    /// <summary>
    /// VodItemContract CashOrMarketValueAmount
    /// </summary>
    public decimal? CashOrMarketValueAmount { get => _cashOrMarketValueAmount; set => SetField(ref _cashOrMarketValueAmount, value); }

    /// <summary>
    /// VodItemContract Country
    /// </summary>
    public string? Country { get => _country; set => SetField(ref _country, value); }

    /// <summary>
    /// VodItemContract DepositoryAccountName
    /// </summary>
    public string? DepositoryAccountName { get => _depositoryAccountName; set => SetField(ref _depositoryAccountName, value); }

    /// <summary>
    /// VodItemContract ForeignAddressIndicator
    /// </summary>
    public bool? ForeignAddressIndicator { get => _foreignAddressIndicator; set => SetField(ref _foreignAddressIndicator, value); }

    /// <summary>
    /// VodItemContract ItemNumber
    /// </summary>
    public int? ItemNumber { get => _itemNumber; set => SetField(ref _itemNumber, value); }

    /// <summary>
    /// VodItemContract Type
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Automobile\"]")]
    public StringEnumValue<AssetType> Type { get => _type; set => SetField(ref _type, value); }

    /// <summary>
    /// VodItemContract Urla2020CashOrMarketValueAmount
    /// </summary>
    public decimal? Urla2020CashOrMarketValueAmount { get => _urla2020CashOrMarketValueAmount; set => SetField(ref _urla2020CashOrMarketValueAmount, value); }
}