using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Residence
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(ApplicantType) + "," + nameof(MailingAddressIndicator) + "," + nameof(ResidencyType), SerializeWholeListWhenDirty = true)]
public sealed partial class Residence : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Residence AccountName [BRNN14], [CRNN14]
    /// </summary>
    public string? AccountName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence AddressCity [BRNN06], [CRNN06]
    /// </summary>
    public string? AddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Present County [FR0109]
    /// </summary>
    public string? AddressCounty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence AddressPostalCode [BRNN08], [CRNN08]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence AddressState [BRNN07], [CRNN07]
    /// </summary>
    public StringEnumValue<State> AddressState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Residence AddressStreetLine1 [BRNN04], [CRNN04]
    /// </summary>
    public string? AddressStreetLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence AddressUnitDesignatorType [BRNN25], [CRNN25]
    /// </summary>
    public StringEnumValue<UnitType> AddressUnitDesignatorType { get => GetValue<StringEnumValue<UnitType>>(); set => SetValue(value); }

    /// <summary>
    /// Residence AddressUnitIdentifier [BRNN27], [CRNN27]
    /// </summary>
    public string? AddressUnitIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence AltId [BRNN99], [CRNN99]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence ApplicantType [BRNN13], [CRNN13]
    /// </summary>
    public StringEnumValue<BorrowerOrCoBorrower> ApplicantType { get => GetValue<StringEnumValue<BorrowerOrCoBorrower>>(); set => SetValue(value); }

    /// <summary>
    /// Residence Contact
    /// </summary>
    public EntityReference? Contact { get => GetValue<EntityReference?>(); set => SetValue(value); }

    /// <summary>
    /// Residence Country [BRNN30], [CRNN30]
    /// </summary>
    public string? Country { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence CountryCode [BRNN28], [CRNN28]
    /// </summary>
    public string? CountryCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence County [BRNN22], [CRNN22]
    /// </summary>
    public string? County { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence DoesNotApplyIndicator [FR0301], [FR0401]
    /// </summary>
    public bool? DoesNotApplyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Residence DurationTermMonths [BRNN24], [CRNN24]
    /// </summary>
    public int? DurationTermMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Residence DurationTermYears [BRNN12], [CRNN12]
    /// </summary>
    public int? DurationTermYears { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Residence EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Residence ForeignAddressIndicator [BRNN29], [CRNN29]
    /// </summary>
    public bool? ForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Residence Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordAttention [BRNN03], [CRNN03]
    /// </summary>
    public string? LandlordAttention { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordCity [BRNN09], [CRNN09]
    /// </summary>
    public string? LandlordCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordComments [BRNN21], [CRNN21]
    /// </summary>
    public string? LandlordComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordCountry [BRNN40], [CRNN40]
    /// </summary>
    public string? LandlordCountry { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordEmail [BRNN20], [CRNN20]
    /// </summary>
    public string? LandlordEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordFax [BRNN19], [CRNN19]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? LandlordFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordForeignAddressIndicator [BRNN39], [CRNN39]
    /// </summary>
    public bool? LandlordForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordName [BRNN02], [CRNN02]
    /// </summary>
    public string? LandlordName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordPhone [BRNN18], [CRNN18]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? LandlordPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordPostalCode [BRNN11], [CRNN11]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? LandlordPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordState [BRNN10], [CRNN10]
    /// </summary>
    public StringEnumValue<State> LandlordState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Residence LandlordStreet [BRNN05], [CRNN05]
    /// </summary>
    public string? LandlordStreet { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence MailingAddressIndicator
    /// </summary>
    public bool? MailingAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Residence NoLinkToDocTrackIndicator [BRNN97], [CRNN97]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? NoLinkToDocTrackIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Residence PrintAttachmentIndicator [BRNN36], [CRNN36]
    /// </summary>
    public bool? PrintAttachmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Residence PrintUserJobTitleIndicator [BRNN64], [CRNN64]
    /// </summary>
    public bool? PrintUserJobTitleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Residence PrintUserNameIndicator [BRNN38], [CRNN38]
    /// </summary>
    public bool? PrintUserNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Residence Rent [BRNN16], [CRNN16]
    /// </summary>
    public int? Rent { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Residence RequestDate [BRNN98], [CRNN98]
    /// </summary>
    public DateTime? RequestDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Residence ResidencyBasisType [BRNN15], [CRNN15]
    /// </summary>
    public StringEnumValue<ResidencyBasisType> ResidencyBasisType { get => GetValue<StringEnumValue<ResidencyBasisType>>(); set => SetValue(value); }

    /// <summary>
    /// Residence ResidencyType [BRNN23], [CRNN23]
    /// </summary>
    public StringEnumValue<ResidencyType> ResidencyType { get => GetValue<StringEnumValue<ResidencyType>>(); set => SetValue(value); }

    /// <summary>
    /// Residence Title [BRNN37], [CRNN37]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence TitleFax [BRNN45], [CRNN45]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence TitlePhone [BRNN44], [CRNN44]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Residence URLA2020StreetAddress [BRNN26], [CRNN26]
    /// </summary>
    public string? URLA2020StreetAddress { get => GetValue<string?>(); set => SetValue(value); }
}