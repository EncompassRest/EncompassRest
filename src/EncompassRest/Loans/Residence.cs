using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Residence
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(ApplicantType) + "," + nameof(MailingAddressIndicator) + "," + nameof(ResidencyType), SerializeWholeListWhenDirty = true)]
    public sealed partial class Residence : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _accountName;
        private DirtyValue<string?>? _addressCity;
        private DirtyValue<string?>? _addressCounty;
        private DirtyValue<string?>? _addressPostalCode;
        private DirtyValue<StringEnumValue<State>>? _addressState;
        private DirtyValue<string?>? _addressStreetLine1;
        private DirtyValue<StringEnumValue<UnitType>>? _addressUnitDesignatorType;
        private DirtyValue<string?>? _addressUnitIdentifier;
        private DirtyValue<string?>? _altId;
        private DirtyValue<StringEnumValue<BorrowerOrCoBorrower>>? _applicantType;
        private DirtyValue<EntityReference?>? _contact;
        private DirtyValue<string?>? _country;
        private DirtyValue<string?>? _countryCode;
        private DirtyValue<string?>? _county;
        private DirtyValue<bool?>? _doesNotApplyIndicator;
        private DirtyValue<int?>? _durationTermMonths;
        private DirtyValue<int?>? _durationTermYears;
        private DirtyValue<bool?>? _entityDeleted;
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
        private DirtyValue<StringEnumValue<State>>? _landlordState;
        private DirtyValue<string?>? _landlordStreet;
        private DirtyValue<bool?>? _mailingAddressIndicator;
        private DirtyValue<bool?>? _noLinkToDocTrackIndicator;
        private DirtyValue<bool?>? _printAttachmentIndicator;
        private DirtyValue<bool?>? _printUserJobTitleIndicator;
        private DirtyValue<bool?>? _printUserNameIndicator;
        private DirtyValue<decimal?>? _rent;
        private DirtyValue<DateTime?>? _requestDate;
        private DirtyValue<string?>? _residencyBasisType;
        private DirtyValue<StringEnumValue<ResidencyType>>? _residencyType;
        private DirtyValue<string?>? _title;
        private DirtyValue<string?>? _titleFax;
        private DirtyValue<string?>? _titlePhone;
        private DirtyValue<string?>? _uRLA2020StreetAddress;

        /// <summary>
        /// Residence AccountName [BRNN14], [CRNN14]
        /// </summary>
        public string? AccountName { get => _accountName; set => SetField(ref _accountName, value); }

        /// <summary>
        /// Residence AddressCity [BRNN06], [CRNN06]
        /// </summary>
        public string? AddressCity { get => _addressCity; set => SetField(ref _addressCity, value); }

        /// <summary>
        /// Borr Present County [FR0109]
        /// </summary>
        public string? AddressCounty { get => _addressCounty; set => SetField(ref _addressCounty, value); }

        /// <summary>
        /// Residence AddressPostalCode [BRNN08], [CRNN08]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? AddressPostalCode { get => _addressPostalCode; set => SetField(ref _addressPostalCode, value); }

        /// <summary>
        /// Residence AddressState [BRNN07], [CRNN07]
        /// </summary>
        public StringEnumValue<State> AddressState { get => _addressState; set => SetField(ref _addressState, value); }

        /// <summary>
        /// Residence AddressStreetLine1 [BRNN04], [CRNN04]
        /// </summary>
        public string? AddressStreetLine1 { get => _addressStreetLine1; set => SetField(ref _addressStreetLine1, value); }

        /// <summary>
        /// Residence AddressUnitDesignatorType [BRNN25], [CRNN25]
        /// </summary>
        public StringEnumValue<UnitType> AddressUnitDesignatorType { get => _addressUnitDesignatorType; set => SetField(ref _addressUnitDesignatorType, value); }

        /// <summary>
        /// Residence AddressUnitIdentifier [BRNN27], [CRNN27]
        /// </summary>
        public string? AddressUnitIdentifier { get => _addressUnitIdentifier; set => SetField(ref _addressUnitIdentifier, value); }

        /// <summary>
        /// Residence AltId [BRNN99], [CRNN99]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? AltId { get => _altId; set => SetField(ref _altId, value); }

        /// <summary>
        /// Residence ApplicantType [BRNN13], [CRNN13]
        /// </summary>
        public StringEnumValue<BorrowerOrCoBorrower> ApplicantType { get => _applicantType; set => SetField(ref _applicantType, value); }

        /// <summary>
        /// Residence Contact
        /// </summary>
        public EntityReference? Contact { get => _contact; set => SetField(ref _contact, value); }

        /// <summary>
        /// Residence Country [BRNN30], [CRNN30]
        /// </summary>
        public string? Country { get => _country; set => SetField(ref _country, value); }

        /// <summary>
        /// Residence CountryCode [BRNN28], [CRNN28]
        /// </summary>
        public string? CountryCode { get => _countryCode; set => SetField(ref _countryCode, value); }

        /// <summary>
        /// Residence County [BRNN22], [CRNN22]
        /// </summary>
        public string? County { get => _county; set => SetField(ref _county, value); }

        /// <summary>
        /// Residence DoesNotApplyIndicator [FR0301], [FR0401]
        /// </summary>
        public bool? DoesNotApplyIndicator { get => _doesNotApplyIndicator; set => SetField(ref _doesNotApplyIndicator, value); }

        /// <summary>
        /// Residence DurationTermMonths [BRNN24], [CRNN24]
        /// </summary>
        public int? DurationTermMonths { get => _durationTermMonths; set => SetField(ref _durationTermMonths, value); }

        /// <summary>
        /// Residence DurationTermYears [BRNN12], [CRNN12]
        /// </summary>
        public int? DurationTermYears { get => _durationTermYears; set => SetField(ref _durationTermYears, value); }

        /// <summary>
        /// Residence EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// Residence ForeignAddressIndicator [BRNN29], [CRNN29]
        /// </summary>
        public bool? ForeignAddressIndicator { get => _foreignAddressIndicator; set => SetField(ref _foreignAddressIndicator, value); }

        /// <summary>
        /// Residence Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Residence LandlordAttention [BRNN03], [CRNN03]
        /// </summary>
        public string? LandlordAttention { get => _landlordAttention; set => SetField(ref _landlordAttention, value); }

        /// <summary>
        /// Residence LandlordCity [BRNN09], [CRNN09]
        /// </summary>
        public string? LandlordCity { get => _landlordCity; set => SetField(ref _landlordCity, value); }

        /// <summary>
        /// Residence LandlordComments [BRNN21], [CRNN21]
        /// </summary>
        public string? LandlordComments { get => _landlordComments; set => SetField(ref _landlordComments, value); }

        /// <summary>
        /// Residence LandlordCountry [BRNN40], [CRNN40]
        /// </summary>
        public string? LandlordCountry { get => _landlordCountry; set => SetField(ref _landlordCountry, value); }

        /// <summary>
        /// Residence LandlordEmail [BRNN20], [CRNN20]
        /// </summary>
        public string? LandlordEmail { get => _landlordEmail; set => SetField(ref _landlordEmail, value); }

        /// <summary>
        /// Residence LandlordFax [BRNN19], [CRNN19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? LandlordFax { get => _landlordFax; set => SetField(ref _landlordFax, value); }

        /// <summary>
        /// Residence LandlordForeignAddressIndicator [BRNN39], [CRNN39]
        /// </summary>
        public bool? LandlordForeignAddressIndicator { get => _landlordForeignAddressIndicator; set => SetField(ref _landlordForeignAddressIndicator, value); }

        /// <summary>
        /// Residence LandlordName [BRNN02], [CRNN02]
        /// </summary>
        public string? LandlordName { get => _landlordName; set => SetField(ref _landlordName, value); }

        /// <summary>
        /// Residence LandlordPhone [BRNN18], [CRNN18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? LandlordPhone { get => _landlordPhone; set => SetField(ref _landlordPhone, value); }

        /// <summary>
        /// Residence LandlordPostalCode [BRNN11], [CRNN11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? LandlordPostalCode { get => _landlordPostalCode; set => SetField(ref _landlordPostalCode, value); }

        /// <summary>
        /// Residence LandlordState [BRNN10], [CRNN10]
        /// </summary>
        public StringEnumValue<State> LandlordState { get => _landlordState; set => SetField(ref _landlordState, value); }

        /// <summary>
        /// Residence LandlordStreet [BRNN05], [CRNN05]
        /// </summary>
        public string? LandlordStreet { get => _landlordStreet; set => SetField(ref _landlordStreet, value); }

        /// <summary>
        /// Residence MailingAddressIndicator
        /// </summary>
        public bool? MailingAddressIndicator { get => _mailingAddressIndicator; set => SetField(ref _mailingAddressIndicator, value); }

        /// <summary>
        /// Residence NoLinkToDocTrackIndicator [BRNN97], [CRNN97]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => SetField(ref _noLinkToDocTrackIndicator, value); }

        /// <summary>
        /// Residence PrintAttachmentIndicator [BRNN36], [CRNN36]
        /// </summary>
        public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }

        /// <summary>
        /// Residence PrintUserJobTitleIndicator [BRNN64], [CRNN64]
        /// </summary>
        public bool? PrintUserJobTitleIndicator { get => _printUserJobTitleIndicator; set => SetField(ref _printUserJobTitleIndicator, value); }

        /// <summary>
        /// Residence PrintUserNameIndicator [BRNN38], [CRNN38]
        /// </summary>
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

        /// <summary>
        /// Residence Rent [BRNN16], [CRNN16]
        /// </summary>
        public decimal? Rent { get => _rent; set => SetField(ref _rent, value); }

        /// <summary>
        /// Residence RequestDate [BRNN98], [CRNN98]
        /// </summary>
        public DateTime? RequestDate { get => _requestDate; set => SetField(ref _requestDate, value); }

        /// <summary>
        /// Residence ResidencyBasisType [BRNN15], [CRNN15]
        /// </summary>
        public string? ResidencyBasisType { get => _residencyBasisType; set => SetField(ref _residencyBasisType, value); }

        /// <summary>
        /// Residence ResidencyType [BRNN23], [CRNN23]
        /// </summary>
        public StringEnumValue<ResidencyType> ResidencyType { get => _residencyType; set => SetField(ref _residencyType, value); }

        /// <summary>
        /// Residence Title [BRNN37], [CRNN37]
        /// </summary>
        public string? Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// Residence TitleFax [BRNN45], [CRNN45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

        /// <summary>
        /// Residence TitlePhone [BRNN44], [CRNN44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }

        /// <summary>
        /// Residence URLA2020StreetAddress [BRNN26], [CRNN26]
        /// </summary>
        public string? URLA2020StreetAddress { get => _uRLA2020StreetAddress; set => SetField(ref _uRLA2020StreetAddress, value); }
    }
}