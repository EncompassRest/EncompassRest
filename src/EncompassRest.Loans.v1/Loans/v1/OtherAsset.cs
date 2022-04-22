using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// OtherAsset
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class OtherAsset : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Other Assets Other Asset Id [URLAROANN99]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Asset Type [URLAROANN02]
    /// </summary>
    public StringEnumValue<OtherAssetType> AssetType { get => GetValue<StringEnumValue<OtherAssetType>>(); set => SetValue(value); }

    /// <summary>
    /// Other Asset Attention [URLAROANN06]
    /// </summary>
    public string? Attention { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Borrower Type [URLAROANN01]
    /// </summary>
    public StringEnumValue<Owner> BorrowerType { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Cash Or Market Value [URLAROANN03]
    /// </summary>
    public decimal? CashOrMarketValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// OtherAsset Contact
    /// </summary>
    public EntityReference? Contact { get => GetValue<EntityReference?>(); set => SetValue(value); }

    /// <summary>
    /// OtherAsset EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Holder Address City [URLAROANN08]
    /// </summary>
    public string? HolderAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Holder Address Postal Code [URLAROANN10]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Holder Address State [URLAROANN09]
    /// </summary>
    public StringEnumValue<State> HolderAddressState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Holder Address Street Line 1 [URLAROANN07]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Email [URLAROANN13]
    /// </summary>
    public string? HolderEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Holder Fax [URLAROANN12]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Asset Creditor Name [URLAROANN05]
    /// </summary>
    public string? HolderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Holder Phone [URLAROANN11]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherAsset Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Asset Date [URLAROANN19]
    /// </summary>
    public DateTime? OtherAssetDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Other Description [URLAROANN04]
    /// </summary>
    public StringEnumValue<OtherDescription> OtherDescription { get => GetValue<StringEnumValue<OtherDescription>>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Print - See Attached Authorization [URLAROANN18]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
    public bool? PrintAttachmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Print User Job Title [URLAROANN20]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's job title\"}")]
    public bool? PrintUserJobTitleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Print User Name as Title [URLAROANN15]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's name as title\"}")]
    public bool? PrintUserNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant From Title [URLAROANN14]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets From Fax [URLAROANN17]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets From Phone [URLAROANN16]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => GetValue<string?>(); set => SetValue(value); }
}