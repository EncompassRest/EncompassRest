using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Residence
    /// </summary>
    public sealed partial class Residence : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _accountName;
        /// <summary>
        /// Residence AccountName
        /// </summary>
        public string AccountName { get => _accountName; set => _accountName = value; }
        private DirtyValue<string> _addressCity;
        /// <summary>
        /// Residence AddressCity
        /// </summary>
        public string AddressCity { get => _addressCity; set => _addressCity = value; }
        private DirtyValue<string> _addressCounty;
        /// <summary>
        /// Borr Present County [FR0109]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Present County")]
        public string AddressCounty { get => _addressCounty; set => _addressCounty = value; }
        private DirtyValue<string> _addressPostalCode;
        /// <summary>
        /// Residence AddressPostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string AddressPostalCode { get => _addressPostalCode; set => _addressPostalCode = value; }
        private DirtyValue<StringEnumValue<State>> _addressState;
        /// <summary>
        /// Residence AddressState
        /// </summary>
        public StringEnumValue<State> AddressState { get => _addressState; set => _addressState = value; }
        private DirtyValue<string> _addressStreetLine1;
        /// <summary>
        /// Residence AddressStreetLine1
        /// </summary>
        public string AddressStreetLine1 { get => _addressStreetLine1; set => _addressStreetLine1 = value; }
        private DirtyValue<string> _altId;
        /// <summary>
        /// Residence AltId
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AltId { get => _altId; set => _altId = value; }
        private DirtyValue<StringEnumValue<BorrowerOrCoBorrower>> _applicantType;
        /// <summary>
        /// Residence ApplicantType
        /// </summary>
        public StringEnumValue<BorrowerOrCoBorrower> ApplicantType { get => _applicantType; set => _applicantType = value; }
        private EntityReference _contact;
        /// <summary>
        /// Residence Contact
        /// </summary>
        public EntityReference Contact { get => _contact ?? (_contact = new EntityReference()); set => _contact = value; }
        private DirtyValue<string> _county;
        /// <summary>
        /// Residence County
        /// </summary>
        public string County { get => _county; set => _county = value; }
        private DirtyValue<int?> _durationTermMonths;
        /// <summary>
        /// Residence DurationTermMonths
        /// </summary>
        public int? DurationTermMonths { get => _durationTermMonths; set => _durationTermMonths = value; }
        private DirtyValue<int?> _durationTermYears;
        /// <summary>
        /// Residence DurationTermYears
        /// </summary>
        public int? DurationTermYears { get => _durationTermYears; set => _durationTermYears = value; }
        private DirtyValue<bool?> _entityDeleted;
        /// <summary>
        /// Residence EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => _entityDeleted = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Residence Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _landlordAttention;
        /// <summary>
        /// Residence LandlordAttention
        /// </summary>
        public string LandlordAttention { get => _landlordAttention; set => _landlordAttention = value; }
        private DirtyValue<string> _landlordCity;
        /// <summary>
        /// Residence LandlordCity
        /// </summary>
        public string LandlordCity { get => _landlordCity; set => _landlordCity = value; }
        private DirtyValue<string> _landlordComments;
        /// <summary>
        /// Residence LandlordComments
        /// </summary>
        public string LandlordComments { get => _landlordComments; set => _landlordComments = value; }
        private DirtyValue<string> _landlordEmail;
        /// <summary>
        /// Residence LandlordEmail
        /// </summary>
        public string LandlordEmail { get => _landlordEmail; set => _landlordEmail = value; }
        private DirtyValue<string> _landlordFax;
        /// <summary>
        /// Residence LandlordFax
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string LandlordFax { get => _landlordFax; set => _landlordFax = value; }
        private DirtyValue<string> _landlordName;
        /// <summary>
        /// Residence LandlordName
        /// </summary>
        public string LandlordName { get => _landlordName; set => _landlordName = value; }
        private DirtyValue<string> _landlordPhone;
        /// <summary>
        /// Residence LandlordPhone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string LandlordPhone { get => _landlordPhone; set => _landlordPhone = value; }
        private DirtyValue<string> _landlordPostalCode;
        /// <summary>
        /// Residence LandlordPostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string LandlordPostalCode { get => _landlordPostalCode; set => _landlordPostalCode = value; }
        private DirtyValue<StringEnumValue<State>> _landlordState;
        /// <summary>
        /// Residence LandlordState
        /// </summary>
        public StringEnumValue<State> LandlordState { get => _landlordState; set => _landlordState = value; }
        private DirtyValue<string> _landlordStreet;
        /// <summary>
        /// Residence LandlordStreet
        /// </summary>
        public string LandlordStreet { get => _landlordStreet; set => _landlordStreet = value; }
        private DirtyValue<bool?> _mailingAddressIndicator;
        /// <summary>
        /// Residence MailingAddressIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"false\":\"false\",\"true\":\"true\"}")]
        public bool? MailingAddressIndicator { get => _mailingAddressIndicator; set => _mailingAddressIndicator = value; }
        private DirtyValue<bool?> _noLinkToDocTrackIndicator;
        /// <summary>
        /// Residence NoLinkToDocTrackIndicator
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => _noLinkToDocTrackIndicator = value; }
        private DirtyValue<bool?> _printAttachmentIndicator;
        /// <summary>
        /// Residence PrintAttachmentIndicator
        /// </summary>
        public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => _printAttachmentIndicator = value; }
        private DirtyValue<bool?> _printUserNameIndicator;
        /// <summary>
        /// Residence PrintUserNameIndicator
        /// </summary>
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => _printUserNameIndicator = value; }
        private DirtyValue<int?> _rent;
        /// <summary>
        /// Residence Rent
        /// </summary>
        public int? Rent { get => _rent; set => _rent = value; }
        private DirtyValue<DateTime?> _requestDate;
        /// <summary>
        /// Residence RequestDate
        /// </summary>
        public DateTime? RequestDate { get => _requestDate; set => _requestDate = value; }
        private DirtyValue<string> _residencyBasisType;
        /// <summary>
        /// Residence ResidencyBasisType
        /// </summary>
        public string ResidencyBasisType { get => _residencyBasisType; set => _residencyBasisType = value; }
        private DirtyValue<StringEnumValue<ResidencyType>> _residencyType;
        /// <summary>
        /// Residence ResidencyType
        /// </summary>
        public StringEnumValue<ResidencyType> ResidencyType { get => _residencyType; set => _residencyType = value; }
        private DirtyValue<string> _title;
        /// <summary>
        /// Residence Title
        /// </summary>
        public string Title { get => _title; set => _title = value; }
        private DirtyValue<string> _titleFax;
        /// <summary>
        /// Residence TitleFax
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string TitleFax { get => _titleFax; set => _titleFax = value; }
        private DirtyValue<string> _titlePhone;
        /// <summary>
        /// Residence TitlePhone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string TitlePhone { get => _titlePhone; set => _titlePhone = value; }
    }
}