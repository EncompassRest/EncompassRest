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
        private DirtyValue<string> _accountName;
        private DirtyValue<string> _addressCity;
        private DirtyValue<string> _addressCounty;
        private DirtyValue<string> _addressPostalCode;
        private DirtyValue<StringEnumValue<State>> _addressState;
        private DirtyValue<string> _addressStreetLine1;
        private DirtyValue<string> _altId;
        private DirtyValue<StringEnumValue<BorrowerOrCoBorrower>> _applicantType;
        private DirtyValue<EntityReference> _contact;
        private DirtyValue<string> _county;
        private DirtyValue<int?> _durationTermMonths;
        private DirtyValue<int?> _durationTermYears;
        private DirtyValue<bool?> _entityDeleted;
        private DirtyValue<string> _id;
        private DirtyValue<string> _landlordAttention;
        private DirtyValue<string> _landlordCity;
        private DirtyValue<string> _landlordComments;
        private DirtyValue<string> _landlordEmail;
        private DirtyValue<string> _landlordFax;
        private DirtyValue<string> _landlordName;
        private DirtyValue<string> _landlordPhone;
        private DirtyValue<string> _landlordPostalCode;
        private DirtyValue<StringEnumValue<State>> _landlordState;
        private DirtyValue<string> _landlordStreet;
        private DirtyValue<bool?> _mailingAddressIndicator;
        private DirtyValue<bool?> _noLinkToDocTrackIndicator;
        private DirtyValue<bool?> _printAttachmentIndicator;
        private DirtyValue<bool?> _printUserNameIndicator;
        private DirtyValue<int?> _rent;
        private DirtyValue<DateTime?> _requestDate;
        private DirtyValue<string> _residencyBasisType;
        private DirtyValue<StringEnumValue<ResidencyType>> _residencyType;
        private DirtyValue<string> _title;
        private DirtyValue<string> _titleFax;
        private DirtyValue<string> _titlePhone;

        /// <summary>
        /// Residence AccountName
        /// </summary>
        public string AccountName { get => _accountName; set => SetField(ref _accountName, value); }

        /// <summary>
        /// Residence AddressCity
        /// </summary>
        public string AddressCity { get => _addressCity; set => SetField(ref _addressCity, value); }

        /// <summary>
        /// Borr Present County [FR0109]
        /// </summary>
        public string AddressCounty { get => _addressCounty; set => SetField(ref _addressCounty, value); }

        /// <summary>
        /// Residence AddressPostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string AddressPostalCode { get => _addressPostalCode; set => SetField(ref _addressPostalCode, value); }

        /// <summary>
        /// Residence AddressState
        /// </summary>
        public StringEnumValue<State> AddressState { get => _addressState; set => SetField(ref _addressState, value); }

        /// <summary>
        /// Residence AddressStreetLine1
        /// </summary>
        public string AddressStreetLine1 { get => _addressStreetLine1; set => SetField(ref _addressStreetLine1, value); }

        /// <summary>
        /// Residence AltId
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AltId { get => _altId; set => SetField(ref _altId, value); }

        /// <summary>
        /// Residence ApplicantType
        /// </summary>
        public StringEnumValue<BorrowerOrCoBorrower> ApplicantType { get => _applicantType; set => SetField(ref _applicantType, value); }

        /// <summary>
        /// Residence Contact (Nullable)
        /// </summary>
        public EntityReference Contact { get => _contact; set => SetField(ref _contact, value); }

        /// <summary>
        /// Residence County
        /// </summary>
        public string County { get => _county; set => SetField(ref _county, value); }

        /// <summary>
        /// Residence DurationTermMonths
        /// </summary>
        public int? DurationTermMonths { get => _durationTermMonths; set => SetField(ref _durationTermMonths, value); }

        /// <summary>
        /// Residence DurationTermYears
        /// </summary>
        public int? DurationTermYears { get => _durationTermYears; set => SetField(ref _durationTermYears, value); }

        /// <summary>
        /// Residence EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// Residence Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Residence LandlordAttention
        /// </summary>
        public string LandlordAttention { get => _landlordAttention; set => SetField(ref _landlordAttention, value); }

        /// <summary>
        /// Residence LandlordCity
        /// </summary>
        public string LandlordCity { get => _landlordCity; set => SetField(ref _landlordCity, value); }

        /// <summary>
        /// Residence LandlordComments
        /// </summary>
        public string LandlordComments { get => _landlordComments; set => SetField(ref _landlordComments, value); }

        /// <summary>
        /// Residence LandlordEmail
        /// </summary>
        public string LandlordEmail { get => _landlordEmail; set => SetField(ref _landlordEmail, value); }

        /// <summary>
        /// Residence LandlordFax
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string LandlordFax { get => _landlordFax; set => SetField(ref _landlordFax, value); }

        /// <summary>
        /// Residence LandlordName
        /// </summary>
        public string LandlordName { get => _landlordName; set => SetField(ref _landlordName, value); }

        /// <summary>
        /// Residence LandlordPhone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string LandlordPhone { get => _landlordPhone; set => SetField(ref _landlordPhone, value); }

        /// <summary>
        /// Residence LandlordPostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string LandlordPostalCode { get => _landlordPostalCode; set => SetField(ref _landlordPostalCode, value); }

        /// <summary>
        /// Residence LandlordState
        /// </summary>
        public StringEnumValue<State> LandlordState { get => _landlordState; set => SetField(ref _landlordState, value); }

        /// <summary>
        /// Residence LandlordStreet
        /// </summary>
        public string LandlordStreet { get => _landlordStreet; set => SetField(ref _landlordStreet, value); }

        /// <summary>
        /// Residence MailingAddressIndicator
        /// </summary>
        public bool? MailingAddressIndicator { get => _mailingAddressIndicator; set => SetField(ref _mailingAddressIndicator, value); }

        /// <summary>
        /// Residence NoLinkToDocTrackIndicator
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => SetField(ref _noLinkToDocTrackIndicator, value); }

        /// <summary>
        /// Residence PrintAttachmentIndicator
        /// </summary>
        public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }

        /// <summary>
        /// Residence PrintUserNameIndicator
        /// </summary>
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

        /// <summary>
        /// Residence Rent
        /// </summary>
        public int? Rent { get => _rent; set => SetField(ref _rent, value); }

        /// <summary>
        /// Residence RequestDate
        /// </summary>
        public DateTime? RequestDate { get => _requestDate; set => SetField(ref _requestDate, value); }

        /// <summary>
        /// Residence ResidencyBasisType
        /// </summary>
        public string ResidencyBasisType { get => _residencyBasisType; set => SetField(ref _residencyBasisType, value); }

        /// <summary>
        /// Residence ResidencyType
        /// </summary>
        public StringEnumValue<ResidencyType> ResidencyType { get => _residencyType; set => SetField(ref _residencyType, value); }

        /// <summary>
        /// Residence Title
        /// </summary>
        public string Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// Residence TitleFax
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

        /// <summary>
        /// Residence TitlePhone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }
    }
}