using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// VodItem
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(ItemNumber), SerializeWholeListWhenDirty = true)]
public sealed partial class VodItem : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// VodItem AccountIdentifier
    /// </summary>
    public string? AccountIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VodItem CashOrMarketValueAmount
    /// </summary>
    public decimal? CashOrMarketValueAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VodItem Country
    /// </summary>
    public string? Country { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VodItem DepositoryAccountName
    /// </summary>
    public string? DepositoryAccountName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VodItem ForeignAddressIndicator
    /// </summary>
    public bool? ForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VodItem ItemNumber
    /// </summary>
    public int? ItemNumber { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// VodItem Type
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Automobile\"]")]
    public StringEnumValue<AssetType> Type { get => GetValue<StringEnumValue<AssetType>>(); set => SetValue(value); }

    /// <summary>
    /// VodItem Urla2020CashOrMarketValueAmount
    /// </summary>
    public decimal? Urla2020CashOrMarketValueAmount { get => GetValue<decimal?>(); set => SetValue(value); }
}