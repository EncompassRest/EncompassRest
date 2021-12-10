using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// OtherAsset
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class OtherAsset : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _altId;
    private DirtyValue<StringEnumValue<OtherAssetType>>? _assetType;
    private DirtyValue<string?>? _attention;
    private DirtyValue<StringEnumValue<Owner>>? _borrowerType;
    private DirtyValue<decimal?>? _cashOrMarketValue;
    private DirtyValue<string?>? _holderAddressCity;
    private DirtyValue<string?>? _holderAddressPostalCode;
    private DirtyValue<string?>? _holderAddressState;
    private DirtyValue<string?>? _holderAddressStreetLine1;
    private DirtyValue<string?>? _holderEmail;
    private DirtyValue<string?>? _holderFax;
    private DirtyValue<string?>? _holderName;
    private DirtyValue<string?>? _holderPhone;
    private DirtyValue<string?>? _id;
    private DirtyValue<DateTime?>? _otherAssetDate;
    private DirtyValue<StringEnumValue<OtherDescription>>? _otherDescription;
    private DirtyValue<bool?>? _printAttachmentIndicator;
    private DirtyValue<bool?>? _printUserJobTitleIndicator;
    private DirtyValue<bool?>? _printUserNameIndicator;
    private DirtyValue<string?>? _title;
    private DirtyValue<string?>? _titleFax;
    private DirtyValue<string?>? _titlePhone;

    /// <summary>
    /// Other Assets Other Asset Id [URLAROA0099]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// Other Assets Asset Type [URLAROA0002]
    /// </summary>
    public StringEnumValue<OtherAssetType> AssetType { get => _assetType; set => SetField(ref _assetType, value); }

    /// <summary>
    /// Other Asset Attention [URLAROA0006]
    /// </summary>
    public string? Attention { get => _attention; set => SetField(ref _attention, value); }

    /// <summary>
    /// Other Assets Borrower Type [URLAROA0001]
    /// </summary>
    public StringEnumValue<Owner> BorrowerType { get => _borrowerType; set => SetField(ref _borrowerType, value); }

    /// <summary>
    /// Other Assets Cash Or Market Value [URLAROA0003]
    /// </summary>
    public decimal? CashOrMarketValue { get => _cashOrMarketValue; set => SetField(ref _cashOrMarketValue, value); }

    /// <summary>
    /// Other Assets Holder Address City [URLAROA0008]
    /// </summary>
    public string? HolderAddressCity { get => _holderAddressCity; set => SetField(ref _holderAddressCity, value); }

    /// <summary>
    /// Other Assets Holder Address Postal Code [URLAROA0010]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => _holderAddressPostalCode; set => SetField(ref _holderAddressPostalCode, value); }

    /// <summary>
    /// Other Assets Holder Address State [URLAROA0009]
    /// </summary>
    public string? HolderAddressState { get => _holderAddressState; set => SetField(ref _holderAddressState, value); }

    /// <summary>
    /// Other Assets Holder Address Street Line 1 [URLAROA0007]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => _holderAddressStreetLine1; set => SetField(ref _holderAddressStreetLine1, value); }

    /// <summary>
    /// Other Assets Email [URLAROA0013]
    /// </summary>
    public string? HolderEmail { get => _holderEmail; set => SetField(ref _holderEmail, value); }

    /// <summary>
    /// Other Assets Holder Fax [URLAROA0012]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => _holderFax; set => SetField(ref _holderFax, value); }

    /// <summary>
    /// Other Asset Creditor Name [URLAROA0005]
    /// </summary>
    public string? HolderName { get => _holderName; set => SetField(ref _holderName, value); }

    /// <summary>
    /// Other Assets Holder Phone [URLAROA0011]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => _holderPhone; set => SetField(ref _holderPhone, value); }

    /// <summary>
    /// OtherAssetContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Other Asset Date [URLAROA0019]
    /// </summary>
    public DateTime? OtherAssetDate { get => _otherAssetDate; set => SetField(ref _otherAssetDate, value); }

    /// <summary>
    /// Other Assets Other Description [URLAROA0004]
    /// </summary>
    public StringEnumValue<OtherDescription> OtherDescription { get => _otherDescription; set => SetField(ref _otherDescription, value); }

    /// <summary>
    /// Other Assets Print - See Attached Authorization [URLAROA0018]
    /// </summary>
    public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }

    /// <summary>
    /// Other Assets Print User Job Title [URLAROA0020]
    /// </summary>
    public bool? PrintUserJobTitleIndicator { get => _printUserJobTitleIndicator; set => SetField(ref _printUserJobTitleIndicator, value); }

    /// <summary>
    /// Other Assets Print User Name as Title [URLAROA0015]
    /// </summary>
    public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

    /// <summary>
    /// Gift or Grant From Title [URLAROA0014]
    /// </summary>
    public string? Title { get => _title; set => SetField(ref _title, value); }

    /// <summary>
    /// Other Assets From Fax [URLAROA0017]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

    /// <summary>
    /// Other Assets From Phone [URLAROA0016]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }
}