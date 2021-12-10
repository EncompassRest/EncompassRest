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
    private DirtyValue<string?>? _altId;
    private DirtyValue<decimal?>? _amount;
    private DirtyValue<StringEnumValue<GiftGrantAssetType>>? _assetType;
    private DirtyValue<string?>? _attention;
    private DirtyValue<bool?>? _depositedIndicator;
    private DirtyValue<DateTime?>? _giftorGrantDate;
    private DirtyValue<string?>? _holderAddressCity;
    private DirtyValue<string?>? _holderAddressPostalCode;
    private DirtyValue<string?>? _holderAddressState;
    private DirtyValue<string?>? _holderAddressStreetLine1;
    private DirtyValue<string?>? _holderEmail;
    private DirtyValue<string?>? _holderFax;
    private DirtyValue<string?>? _holderName;
    private DirtyValue<string?>? _holderPhone;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _otherSourceDescription;
    private DirtyValue<StringEnumValue<Owner>>? _owner;
    private DirtyValue<bool?>? _printAttachmentIndicator;
    private DirtyValue<bool?>? _printUserJobTitleIndicator;
    private DirtyValue<bool?>? _printUserNameIndicator;
    private DirtyValue<StringEnumValue<GiftGrantSource>>? _source;
    private DirtyValue<string?>? _title;
    private DirtyValue<string?>? _titleFax;
    private DirtyValue<string?>? _titlePhone;

    /// <summary>
    /// Gift or Grant ID [URLARGG0001]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// Amount [URLARGG0021]
    /// </summary>
    public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

    /// <summary>
    /// Gift or Grant Asset Type [URLARGG0018]
    /// </summary>
    public StringEnumValue<GiftGrantAssetType> AssetType { get => _assetType; set => SetField(ref _assetType, value); }

    /// <summary>
    /// Attention Contact [URLARGG0006]
    /// </summary>
    public string? Attention { get => _attention; set => SetField(ref _attention, value); }

    /// <summary>
    /// Deposited [URLARGG0020]
    /// </summary>
    public bool? DepositedIndicator { get => _depositedIndicator; set => SetField(ref _depositedIndicator, value); }

    /// <summary>
    /// Gift or Grant Date [URLARGG0003]
    /// </summary>
    public DateTime? GiftorGrantDate { get => _giftorGrantDate; set => SetField(ref _giftorGrantDate, value); }

    /// <summary>
    /// Attention City [URLARGG0008]
    /// </summary>
    public string? HolderAddressCity { get => _holderAddressCity; set => SetField(ref _holderAddressCity, value); }

    /// <summary>
    /// Attention Zipcode [URLARGG0010]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => _holderAddressPostalCode; set => SetField(ref _holderAddressPostalCode, value); }

    /// <summary>
    /// Attention State [URLARGG0009]
    /// </summary>
    public string? HolderAddressState { get => _holderAddressState; set => SetField(ref _holderAddressState, value); }

    /// <summary>
    /// Address [URLARGG0007]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => _holderAddressStreetLine1; set => SetField(ref _holderAddressStreetLine1, value); }

    /// <summary>
    /// Email [URLARGG0013]
    /// </summary>
    public string? HolderEmail { get => _holderEmail; set => SetField(ref _holderEmail, value); }

    /// <summary>
    /// Fax [URLARGG0012]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => _holderFax; set => SetField(ref _holderFax, value); }

    /// <summary>
    /// Name [URLARGG0005]
    /// </summary>
    public string? HolderName { get => _holderName; set => SetField(ref _holderName, value); }

    /// <summary>
    /// Phone [URLARGG0011]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => _holderPhone; set => SetField(ref _holderPhone, value); }

    /// <summary>
    /// GiftGrantContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Other Source Description [URLARGG0022]
    /// </summary>
    public string? OtherSourceDescription { get => _otherSourceDescription; set => SetField(ref _otherSourceDescription, value); }

    /// <summary>
    /// Gift or Grant is For [URLARGG0002]
    /// </summary>
    public StringEnumValue<Owner> Owner { get => _owner; set => SetField(ref _owner, value); }

    /// <summary>
    /// Gift or Grant Print - See Attached Authorization [URLARGG0004]
    /// </summary>
    public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }

    /// <summary>
    /// Gift or Grant Print user's job title [URLARGG0064]
    /// </summary>
    public bool? PrintUserJobTitleIndicator { get => _printUserJobTitleIndicator; set => SetField(ref _printUserJobTitleIndicator, value); }

    /// <summary>
    /// Gift or Grant Print User Name [URLARGG0015]
    /// </summary>
    public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

    /// <summary>
    /// Gift or Grant Source [URLARGG0019]
    /// </summary>
    public StringEnumValue<GiftGrantSource> Source { get => _source; set => SetField(ref _source, value); }

    /// <summary>
    /// Gift or Grant From Title [URLARGG0014]
    /// </summary>
    public string? Title { get => _title; set => SetField(ref _title, value); }

    /// <summary>
    /// Gift or Grant From Fax [URLARGG0017]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

    /// <summary>
    /// Gift or Grant From Phone [URLARGG0016]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }
}