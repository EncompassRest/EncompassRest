using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Vod
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Vod : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _altId;
    private DirtyValue<string?>? _attention;
    private DirtyValue<string?>? _country;
    private DirtyValue<DateTime?>? _depositoryRequestDate;
    private DirtyValue<bool?>? _foreignAddressIndicator;
    private DirtyValue<string?>? _holderAddressCity;
    private DirtyValue<string?>? _holderAddressPostalCode;
    private DirtyValue<string?>? _holderAddressState;
    private DirtyValue<string?>? _holderAddressStreetLine1;
    private DirtyValue<string?>? _holderComments;
    private DirtyValue<string?>? _holderEmail;
    private DirtyValue<string?>? _holderFax;
    private DirtyValue<string?>? _holderName;
    private DirtyValue<string?>? _holderPhone;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _includeInAusExport;
    private DirtyList<VodItem>? _items;
    private DirtyValue<bool?>? _noLinkToDocTrackIndicator;
    private DirtyValue<StringEnumValue<Owner>>? _owner;
    private DirtyValue<bool?>? _printAttachmentIndicator;
    private DirtyValue<bool?>? _printUserJobTitleIndicator;
    private DirtyValue<bool?>? _printUserNameIndicator;
    private DirtyValue<string?>? _title;
    private DirtyValue<string?>? _titleFax;
    private DirtyValue<string?>? _titlePhone;
    private DirtyValue<decimal?>? _total;

    /// <summary>
    /// Depository Request ID [DD0035]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// Depository Attention Contact [DD0003]
    /// </summary>
    public string? Attention { get => _attention; set => SetField(ref _attention, value); }

    /// <summary>
    /// Depository Country [DD0040]
    /// </summary>
    public string? Country { get => _country; set => SetField(ref _country, value); }

    /// <summary>
    /// Depository Request Date [DD0098]
    /// </summary>
    public DateTime? DepositoryRequestDate { get => _depositoryRequestDate; set => SetField(ref _depositoryRequestDate, value); }

    /// <summary>
    /// Depository Foreign Address Indicator [DD0039]
    /// </summary>
    public bool? ForeignAddressIndicator { get => _foreignAddressIndicator; set => SetField(ref _foreignAddressIndicator, value); }

    /// <summary>
    /// Depository Attention City [DD0005]
    /// </summary>
    public string? HolderAddressCity { get => _holderAddressCity; set => SetField(ref _holderAddressCity, value); }

    /// <summary>
    /// Depository Attention Zipcode [DD0007]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => _holderAddressPostalCode; set => SetField(ref _holderAddressPostalCode, value); }

    /// <summary>
    /// Depository Attention State [DD0006]
    /// </summary>
    public string? HolderAddressState { get => _holderAddressState; set => SetField(ref _holderAddressState, value); }

    /// <summary>
    /// Depository Address [DD0004]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => _holderAddressStreetLine1; set => SetField(ref _holderAddressStreetLine1, value); }

    /// <summary>
    /// Depository Comments [DD0029]
    /// </summary>
    public string? HolderComments { get => _holderComments; set => SetField(ref _holderComments, value); }

    /// <summary>
    /// Depository Email [DD0028]
    /// </summary>
    public string? HolderEmail { get => _holderEmail; set => SetField(ref _holderEmail, value); }

    /// <summary>
    /// Depository Fax [DD0027]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => _holderFax; set => SetField(ref _holderFax, value); }

    /// <summary>
    /// Depository Name [DD0002]
    /// </summary>
    public string? HolderName { get => _holderName; set => SetField(ref _holderName, value); }

    /// <summary>
    /// Depository Phone [DD0026]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => _holderPhone; set => SetField(ref _holderPhone, value); }

    /// <summary>
    /// VodContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Include In AUS/Export [DD0052]
    /// </summary>
    public bool? IncludeInAusExport { get => _includeInAusExport; set => SetField(ref _includeInAusExport, value); }

    /// <summary>
    /// VodContract Items
    /// </summary>
    [AllowNull]
    public IList<VodItem> Items { get => GetField(ref _items); set => SetField(ref _items, value); }

    /// <summary>
    /// Depository No Link to Doc Tracking [DD0097]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => SetField(ref _noLinkToDocTrackIndicator, value); }

    /// <summary>
    /// Depository Request is For [DD0024]
    /// </summary>
    public StringEnumValue<Owner> Owner { get => _owner; set => SetField(ref _owner, value); }

    /// <summary>
    /// Depository Print - See Attached Authorization [DD0036]
    /// </summary>
    public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }

    /// <summary>
    /// Depository Print User Job Title [DD0064]
    /// </summary>
    public bool? PrintUserJobTitleIndicator { get => _printUserJobTitleIndicator; set => SetField(ref _printUserJobTitleIndicator, value); }

    /// <summary>
    /// Depository Print User Name as Title [DD0038]
    /// </summary>
    public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

    /// <summary>
    /// Depository From Title [DD0037]
    /// </summary>
    public string? Title { get => _title; set => SetField(ref _title, value); }

    /// <summary>
    /// Depository From Fax [DD0045]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

    /// <summary>
    /// Depository From Phone [DD0044]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }

    /// <summary>
    /// Depository Total Balance [DD0034]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Total { get => _total; set => SetField(ref _total, value); }
}