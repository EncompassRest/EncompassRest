using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// OtherIncomeSource
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class OtherIncomeSource : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _altId;
    private DirtyValue<string?>? _attention;
    private DirtyValue<StringEnumValue<OtherIncomeSourceDescription>>? _description;
    private DirtyValue<bool?>? _foreignIncomeIndicator;
    private DirtyValue<string?>? _holderAddressCity;
    private DirtyValue<string?>? _holderAddressPostalCode;
    private DirtyValue<string?>? _holderAddressState;
    private DirtyValue<string?>? _holderAddressStreetLine1;
    private DirtyValue<string?>? _holderEmail;
    private DirtyValue<string?>? _holderFax;
    private DirtyValue<string?>? _holderName;
    private DirtyValue<string?>? _holderPhone;
    private DirtyValue<string?>? _id;
    private DirtyValue<decimal?>? _monthlyAmount;
    private DirtyValue<string?>? _otherDescription;
    private DirtyValue<DateTime?>? _otherIncomeSourceDate;
    private DirtyValue<StringEnumValue<BorrowerOrCoBorrower>>? _owner;
    private DirtyValue<bool?>? _printAttachmentIndicator;
    private DirtyValue<bool?>? _printUserJobTitleIndicator;
    private DirtyValue<bool?>? _printUserNameIndicator;
    private DirtyValue<bool?>? _seasonalIncomeIndicator;
    private DirtyValue<string?>? _title;
    private DirtyValue<string?>? _titleFax;
    private DirtyValue<string?>? _titlePhone;

    /// <summary>
    /// Other Income Source ID [URLAROIS0001]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// Attention Contact [URLAROIS0006]
    /// </summary>
    public string? Attention { get => _attention; set => SetField(ref _attention, value); }

    /// <summary>
    /// Other Income Source Description [URLAROIS0018]
    /// </summary>
    public StringEnumValue<OtherIncomeSourceDescription> Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// Foreign Income [URLAROIS0020]
    /// </summary>
    public bool? ForeignIncomeIndicator { get => _foreignIncomeIndicator; set => SetField(ref _foreignIncomeIndicator, value); }

    /// <summary>
    /// Attention City [URLAROIS0008]
    /// </summary>
    public string? HolderAddressCity { get => _holderAddressCity; set => SetField(ref _holderAddressCity, value); }

    /// <summary>
    /// Attention Zipcode [URLAROIS0010]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => _holderAddressPostalCode; set => SetField(ref _holderAddressPostalCode, value); }

    /// <summary>
    /// Attention State [URLAROIS0009]
    /// </summary>
    public string? HolderAddressState { get => _holderAddressState; set => SetField(ref _holderAddressState, value); }

    /// <summary>
    /// Address [URLAROIS0007]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => _holderAddressStreetLine1; set => SetField(ref _holderAddressStreetLine1, value); }

    /// <summary>
    /// Email [URLAROIS0013]
    /// </summary>
    public string? HolderEmail { get => _holderEmail; set => SetField(ref _holderEmail, value); }

    /// <summary>
    /// Fax [URLAROIS0012]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => _holderFax; set => SetField(ref _holderFax, value); }

    /// <summary>
    /// Name [URLAROIS0005]
    /// </summary>
    public string? HolderName { get => _holderName; set => SetField(ref _holderName, value); }

    /// <summary>
    /// Phone [URLAROIS0011]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => _holderPhone; set => SetField(ref _holderPhone, value); }

    /// <summary>
    /// OtherIncomeSourceContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Monthly Amount [URLAROIS0022]
    /// </summary>
    public decimal? MonthlyAmount { get => _monthlyAmount; set => SetField(ref _monthlyAmount, value); }

    /// <summary>
    /// Other Description [URLAROIS0019]
    /// </summary>
    public string? OtherDescription { get => _otherDescription; set => SetField(ref _otherDescription, value); }

    /// <summary>
    /// Other Income Source Date [URLAROIS0003]
    /// </summary>
    public DateTime? OtherIncomeSourceDate { get => _otherIncomeSourceDate; set => SetField(ref _otherIncomeSourceDate, value); }

    /// <summary>
    /// Other Income Source is For [URLAROIS0002]
    /// </summary>
    public StringEnumValue<BorrowerOrCoBorrower> Owner { get => _owner; set => SetField(ref _owner, value); }

    /// <summary>
    /// Other Income Source Print - See Attached Authorization [URLAROIS0004]
    /// </summary>
    public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }

    /// <summary>
    /// Other Income Source Print User Job Title [URLAROIS0064]
    /// </summary>
    public bool? PrintUserJobTitleIndicator { get => _printUserJobTitleIndicator; set => SetField(ref _printUserJobTitleIndicator, value); }

    /// <summary>
    /// Other Income Source Print User Name [URLAROIS0015]
    /// </summary>
    public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

    /// <summary>
    /// Seasonal Income [URLAROIS0021]
    /// </summary>
    public bool? SeasonalIncomeIndicator { get => _seasonalIncomeIndicator; set => SetField(ref _seasonalIncomeIndicator, value); }

    /// <summary>
    /// Other Income Source From Title [URLAROIS0014]
    /// </summary>
    public string? Title { get => _title; set => SetField(ref _title, value); }

    /// <summary>
    /// Other Income Source From Fax [URLAROIS0017]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

    /// <summary>
    /// Other Income Source From Phone [URLAROIS0016]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }
}