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
    /// <summary>
    /// Residence AccountName [BR0014], [CR0014]
    /// </summary>
    public string? AccountName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence AddressCity
    /// </summary>
    public string? AddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Present County [FR0109]
    /// </summary>
    public string? AddressCounty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence AddressPostalCode
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence AddressState
    /// </summary>
    public string? AddressState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence AddressStreetLine1
    /// </summary>
    public string? AddressStreetLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence AddressUnitDesignatorType
    /// </summary>
    public StringEnumValue<UnitType> AddressUnitDesignatorType { get => GetValue<StringEnumValue<UnitType>>(); set => SetValue(value); }

    /// <summary>
    /// Residence AddressUnitIdentifier
    /// </summary>
    public string? AddressUnitIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence AltId
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence ApplicantType [BR0013], [CR0013]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<BorrowerOrCoBorrower> ApplicantType { get => GetValue<StringEnumValue<BorrowerOrCoBorrower>>(); set => SetValue(value); }

    /// <summary>
    /// Residence Country
    /// </summary>
    public string? Country { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence CountryCode
    /// </summary>
    public string? CountryCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence County [BR0022], [CR0022]
    /// </summary>
    public string? County { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence DoesNotApplyIndicator [FR0301], [FR0401]
    /// </summary>
    public bool? DoesNotApplyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Residence DurationTermMonths
    /// </summary>
    public int? DurationTermMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Residence DurationTermYears
    /// </summary>
    public int? DurationTermYears { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Residence ForeignAddressIndicator
    /// </summary>
    public bool? ForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Residence Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordAttention [BR0003], [CR0003]
    /// </summary>
    public string? LandlordAttention { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordCity [BR0009], [CR0009]
    /// </summary>
    public string? LandlordCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordComments [BR0021], [CR0021]
    /// </summary>
    public string? LandlordComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordCountry [BR0040], [CR0040]
    /// </summary>
    public string? LandlordCountry { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordEmail [BR0020], [CR0020]
    /// </summary>
    public string? LandlordEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordFax [BR0019], [CR0019]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? LandlordFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordForeignAddressIndicator [BR0039], [CR0039]
    /// </summary>
    public bool? LandlordForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordName [BR0002], [CR0002]
    /// </summary>
    public string? LandlordName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordPhone [BR0018], [CR0018]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? LandlordPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordPostalCode [BR0011], [CR0011]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? LandlordPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordState [BR0010], [CR0010]
    /// </summary>
    public string? LandlordState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordStreet [BR0005], [CR0005]
    /// </summary>
    public string? LandlordStreet { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence NoLinkToDocTrackIndicator [BR0097], [CR0097]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? NoLinkToDocTrackIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Residence PrintAttachmentIndicator [BR0036], [CR0036]
    /// </summary>
    public bool? PrintAttachmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Residence PrintUserJobTitleIndicator [BR0064], [CR0064]
    /// </summary>
    public bool? PrintUserJobTitleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Residence PrintUserNameIndicator [BR0038], [CR0038]
    /// </summary>
    public bool? PrintUserNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Residence Rent
    /// </summary>
    public int? Rent { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Residence RequestDate
    /// </summary>
    public DateTime? RequestDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Residence ResidencyBasisType
    /// </summary>
    public StringEnumValue<ResidencyBasisType> ResidencyBasisType { get => GetValue<StringEnumValue<ResidencyBasisType>>(); set => SetValue(value); }

    /// <summary>
    /// Residence ResidencyType [BR0023], [CR0023]
    /// </summary>
    public StringEnumValue<ResidencyType> ResidencyType { get => GetValue<StringEnumValue<ResidencyType>>(); set => SetValue(value); }

    /// <summary>
    /// Residence Title [BR0037], [CR0037]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence TitleFax [BR0045], [CR0045]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence TitlePhone [BR0044], [CR0044]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence Urla2020StreetAddress
    /// </summary>
    public string? Urla2020StreetAddress { get => GetValue<string?>(); set => SetValue(value); }
}