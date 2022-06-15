using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// GiftsGrants
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class GiftsGrants : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Gift or Grant ID [URLARGG0001]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Amount [URLARGG0021]
    /// </summary>
    public decimal? Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant Asset Type [URLARGG0018]
    /// </summary>
    public StringEnumValue<GiftGrantAssetType> AssetType { get => GetValue<StringEnumValue<GiftGrantAssetType>>(); set => SetValue(value); }

    /// <summary>
    /// Attention Contact [URLARGG0006]
    /// </summary>
    public string? Attention { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Deposited [URLARGG0020]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Deposited\"}")]
    public bool? DepositedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant Date [URLARGG0003]
    /// </summary>
    public DateTime? GiftorGrantDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Attention City [URLARGG0008]
    /// </summary>
    public string? HolderAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Attention Zipcode [URLARGG0010]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Attention State [URLARGG0009]
    /// </summary>
    public string? HolderAddressState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Address [URLARGG0007]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Email [URLARGG0013]
    /// </summary>
    public string? HolderEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fax [URLARGG0012]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Name [URLARGG0005]
    /// </summary>
    public string? HolderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Phone [URLARGG0011]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GiftsGrants Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Source Description [URLARGG0022]
    /// </summary>
    public string? OtherSourceDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant is For [URLARGG0002]
    /// </summary>
    public StringEnumValue<Owner> Owner { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant Print - See Attached Authorization [URLARGG0004]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
    public bool? PrintAttachmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant Print user's job title [URLARGG0064]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's job title\"}")]
    public bool? PrintUserJobTitleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant Print User Name [URLARGG0015]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's name\"}")]
    public bool? PrintUserNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant Source [URLARGG0019]
    /// </summary>
    public StringEnumValue<GiftGrantSource> Source { get => GetValue<StringEnumValue<GiftGrantSource>>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant From Title [URLARGG0014]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant From Fax [URLARGG0017]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant From Phone [URLARGG0016]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => GetValue<string?>(); set => SetValue(value); }
}