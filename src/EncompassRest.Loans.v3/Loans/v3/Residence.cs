using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Residence
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(ResidencyType), SerializeWholeListWhenDirty = true)]
public sealed partial class Residence : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _accountName;
    private DirtyValue<string?>? _addressCity;
    private DirtyValue<string?>? _addressCounty;
    private DirtyValue<string?>? _addressPostalCode;
    private DirtyValue<string?>? _addressState;
    private DirtyValue<string?>? _addressStreetLine1;
    private DirtyValue<StringEnumValue<UnitType>>? _addressUnitDesignatorType;
    private DirtyValue<string?>? _addressUnitIdentifier;
    private DirtyValue<string?>? _altId;
    private DirtyValue<StringEnumValue<BorrowerOrCoBorrower>>? _applicantType;
    private DirtyValue<string?>? _country;
    private DirtyValue<string?>? _countryCode;
    private DirtyValue<string?>? _county;
    private DirtyValue<bool?>? _doesNotApplyIndicator;
    private DirtyValue<int?>? _durationTermMonths;
    private DirtyValue<int?>? _durationTermYears;
    private DirtyValue<bool?>? _foreignAddressIndicator;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _landlordAttention;
    private DirtyValue<string?>? _landlordCity;
    private DirtyValue<string?>? _landlordComments;
    private DirtyValue<string?>? _landlordCountry;
    private DirtyValue<string?>? _landlordEmail;
    private DirtyValue<string?>? _landlordFax;
    private DirtyValue<bool?>? _landlordForeignAddressIndicator;
    private DirtyValue<string?>? _landlordName;
    private DirtyValue<string?>? _landlordPhone;
    private DirtyValue<string?>? _landlordPostalCode;
    private DirtyValue<string?>? _landlordState;
    private DirtyValue<string?>? _landlordStreet;
    private DirtyValue<bool?>? _noLinkToDocTrackIndicator;
    private DirtyValue<bool?>? _printAttachmentIndicator;
    private DirtyValue<bool?>? _printUserJobTitleIndicator;
    private DirtyValue<bool?>? _printUserNameIndicator;
    private DirtyValue<int?>? _rent;
    private DirtyValue<DateTime?>? _requestDate;
    private DirtyValue<StringEnumValue<ResidencyBasisType>>? _residencyBasisType;
    private DirtyValue<StringEnumValue<ResidencyType>>? _residencyType;
    private DirtyValue<string?>? _title;
    private DirtyValue<string?>? _titleFax;
    private DirtyValue<string?>? _titlePhone;
    private DirtyValue<string?>? _urla2020StreetAddress;

    /// <summary>
    /// ResidenceContract AccountName [BR0014], [CR0014]
    /// </summary>
    public string? AccountName { get => _accountName; set => SetField(ref _accountName, value); }

    /// <summary>
    /// ResidenceContract AddressCity
    /// </summary>
    public string? AddressCity { get => _addressCity; set => SetField(ref _addressCity, value); }

    /// <summary>
    /// Borr Present County [FR0109]
    /// </summary>
    public string? AddressCounty { get => _addressCounty; set => SetField(ref _addressCounty, value); }

    /// <summary>
    /// ResidenceContract AddressPostalCode
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AddressPostalCode { get => _addressPostalCode; set => SetField(ref _addressPostalCode, value); }

    /// <summary>
    /// ResidenceContract AddressState
    /// </summary>
    public string? AddressState { get => _addressState; set => SetField(ref _addressState, value); }

    /// <summary>
    /// ResidenceContract AddressStreetLine1
    /// </summary>
    public string? AddressStreetLine1 { get => _addressStreetLine1; set => SetField(ref _addressStreetLine1, value); }

    /// <summary>
    /// ResidenceContract AddressUnitDesignatorType
    /// </summary>
    public StringEnumValue<UnitType> AddressUnitDesignatorType { get => _addressUnitDesignatorType; set => SetField(ref _addressUnitDesignatorType, value); }

    /// <summary>
    /// ResidenceContract AddressUnitIdentifier
    /// </summary>
    public string? AddressUnitIdentifier { get => _addressUnitIdentifier; set => SetField(ref _addressUnitIdentifier, value); }

    /// <summary>
    /// ResidenceContract AltId
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// ResidenceContract ApplicantType [BR0013], [CR0013]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<BorrowerOrCoBorrower> ApplicantType { get => _applicantType; set => SetField(ref _applicantType, value); }

    /// <summary>
    /// ResidenceContract Country
    /// </summary>
    public string? Country { get => _country; set => SetField(ref _country, value); }

    /// <summary>
    /// ResidenceContract CountryCode
    /// </summary>
    public string? CountryCode { get => _countryCode; set => SetField(ref _countryCode, value); }

    /// <summary>
    /// ResidenceContract County [BR0022], [CR0022]
    /// </summary>
    public string? County { get => _county; set => SetField(ref _county, value); }

    /// <summary>
    /// ResidenceContract DoesNotApplyIndicator [FR0301], [FR0401]
    /// </summary>
    public bool? DoesNotApplyIndicator { get => _doesNotApplyIndicator; set => SetField(ref _doesNotApplyIndicator, value); }

    /// <summary>
    /// ResidenceContract DurationTermMonths
    /// </summary>
    public int? DurationTermMonths { get => _durationTermMonths; set => SetField(ref _durationTermMonths, value); }

    /// <summary>
    /// ResidenceContract DurationTermYears
    /// </summary>
    public int? DurationTermYears { get => _durationTermYears; set => SetField(ref _durationTermYears, value); }

    /// <summary>
    /// ResidenceContract ForeignAddressIndicator
    /// </summary>
    public bool? ForeignAddressIndicator { get => _foreignAddressIndicator; set => SetField(ref _foreignAddressIndicator, value); }

    /// <summary>
    /// ResidenceContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// ResidenceContract LandlordAttention [BR0003], [CR0003]
    /// </summary>
    public string? LandlordAttention { get => _landlordAttention; set => SetField(ref _landlordAttention, value); }

    /// <summary>
    /// ResidenceContract LandlordCity [BR0009], [CR0009]
    /// </summary>
    public string? LandlordCity { get => _landlordCity; set => SetField(ref _landlordCity, value); }

    /// <summary>
    /// ResidenceContract LandlordComments [BR0021], [CR0021]
    /// </summary>
    public string? LandlordComments { get => _landlordComments; set => SetField(ref _landlordComments, value); }

    /// <summary>
    /// ResidenceContract LandlordCountry [BR0040], [CR0040]
    /// </summary>
    public string? LandlordCountry { get => _landlordCountry; set => SetField(ref _landlordCountry, value); }

    /// <summary>
    /// ResidenceContract LandlordEmail [BR0020], [CR0020]
    /// </summary>
    public string? LandlordEmail { get => _landlordEmail; set => SetField(ref _landlordEmail, value); }

    /// <summary>
    /// ResidenceContract LandlordFax [BR0019], [CR0019]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? LandlordFax { get => _landlordFax; set => SetField(ref _landlordFax, value); }

    /// <summary>
    /// ResidenceContract LandlordForeignAddressIndicator [BR0039], [CR0039]
    /// </summary>
    public bool? LandlordForeignAddressIndicator { get => _landlordForeignAddressIndicator; set => SetField(ref _landlordForeignAddressIndicator, value); }

    /// <summary>
    /// ResidenceContract LandlordName [BR0002], [CR0002]
    /// </summary>
    public string? LandlordName { get => _landlordName; set => SetField(ref _landlordName, value); }

    /// <summary>
    /// ResidenceContract LandlordPhone [BR0018], [CR0018]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? LandlordPhone { get => _landlordPhone; set => SetField(ref _landlordPhone, value); }

    /// <summary>
    /// ResidenceContract LandlordPostalCode [BR0011], [CR0011]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? LandlordPostalCode { get => _landlordPostalCode; set => SetField(ref _landlordPostalCode, value); }

    /// <summary>
    /// ResidenceContract LandlordState [BR0010], [CR0010]
    /// </summary>
    public string? LandlordState { get => _landlordState; set => SetField(ref _landlordState, value); }

    /// <summary>
    /// ResidenceContract LandlordStreet [BR0005], [CR0005]
    /// </summary>
    public string? LandlordStreet { get => _landlordStreet; set => SetField(ref _landlordStreet, value); }

    /// <summary>
    /// ResidenceContract NoLinkToDocTrackIndicator [BR0097], [CR0097]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => SetField(ref _noLinkToDocTrackIndicator, value); }

    /// <summary>
    /// ResidenceContract PrintAttachmentIndicator [BR0036], [CR0036]
    /// </summary>
    public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }

    /// <summary>
    /// ResidenceContract PrintUserJobTitleIndicator [BR0064], [CR0064]
    /// </summary>
    public bool? PrintUserJobTitleIndicator { get => _printUserJobTitleIndicator; set => SetField(ref _printUserJobTitleIndicator, value); }

    /// <summary>
    /// ResidenceContract PrintUserNameIndicator [BR0038], [CR0038]
    /// </summary>
    public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

    /// <summary>
    /// ResidenceContract Rent
    /// </summary>
    public int? Rent { get => _rent; set => SetField(ref _rent, value); }

    /// <summary>
    /// ResidenceContract RequestDate
    /// </summary>
    public DateTime? RequestDate { get => _requestDate; set => SetField(ref _requestDate, value); }

    /// <summary>
    /// ResidenceContract ResidencyBasisType
    /// </summary>
    public StringEnumValue<ResidencyBasisType> ResidencyBasisType { get => _residencyBasisType; set => SetField(ref _residencyBasisType, value); }

    /// <summary>
    /// ResidenceContract ResidencyType [BR0023], [CR0023]
    /// </summary>
    public StringEnumValue<ResidencyType> ResidencyType { get => _residencyType; set => SetField(ref _residencyType, value); }

    /// <summary>
    /// ResidenceContract Title [BR0037], [CR0037]
    /// </summary>
    public string? Title { get => _title; set => SetField(ref _title, value); }

    /// <summary>
    /// ResidenceContract TitleFax [BR0045], [CR0045]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

    /// <summary>
    /// ResidenceContract TitlePhone [BR0044], [CR0044]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }

    /// <summary>
    /// ResidenceContract Urla2020StreetAddress
    /// </summary>
    public string? Urla2020StreetAddress { get => _urla2020StreetAddress; set => SetField(ref _urla2020StreetAddress, value); }
}