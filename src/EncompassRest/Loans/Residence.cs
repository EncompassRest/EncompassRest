#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Residence : ExtensibleObject
    {
        private DirtyValue<string> _accountName;
        public string AccountName { get => _accountName; set => _accountName = value; }
        private DirtyValue<string> _addressCity;
        public string AddressCity { get => _addressCity; set => _addressCity = value; }
        private DirtyValue<string> _addressPostalCode;
        public string AddressPostalCode { get => _addressPostalCode; set => _addressPostalCode = value; }
        private DirtyValue<string> _addressState;
        public string AddressState { get => _addressState; set => _addressState = value; }
        private DirtyValue<string> _addressStreetLine1;
        public string AddressStreetLine1 { get => _addressStreetLine1; set => _addressStreetLine1 = value; }
        private DirtyValue<string> _altId;
        public string AltId { get => _altId; set => _altId = value; }
        private DirtyValue<string> _applicantType;
        public string ApplicantType { get => _applicantType; set => _applicantType = value; }
        private DirtyValue<string> _county;
        public string County { get => _county; set => _county = value; }
        private DirtyValue<int?> _durationTermMonths;
        public int? DurationTermMonths { get => _durationTermMonths; set => _durationTermMonths = value; }
        private DirtyValue<int?> _durationTermYears;
        public int? DurationTermYears { get => _durationTermYears; set => _durationTermYears = value; }
        private DirtyValue<bool?> _entityDeleted;
        public bool? EntityDeleted { get => _entityDeleted; set => _entityDeleted = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _landlordAttention;
        public string LandlordAttention { get => _landlordAttention; set => _landlordAttention = value; }
        private DirtyValue<string> _landlordCity;
        public string LandlordCity { get => _landlordCity; set => _landlordCity = value; }
        private DirtyValue<string> _landlordComments;
        public string LandlordComments { get => _landlordComments; set => _landlordComments = value; }
        private DirtyValue<string> _landlordEmail;
        public string LandlordEmail { get => _landlordEmail; set => _landlordEmail = value; }
        private DirtyValue<string> _landlordFax;
        public string LandlordFax { get => _landlordFax; set => _landlordFax = value; }
        private DirtyValue<string> _landlordName;
        public string LandlordName { get => _landlordName; set => _landlordName = value; }
        private DirtyValue<string> _landlordPhone;
        public string LandlordPhone { get => _landlordPhone; set => _landlordPhone = value; }
        private DirtyValue<string> _landlordPostalCode;
        public string LandlordPostalCode { get => _landlordPostalCode; set => _landlordPostalCode = value; }
        private DirtyValue<string> _landlordState;
        public string LandlordState { get => _landlordState; set => _landlordState = value; }
        private DirtyValue<string> _landlordStreet;
        public string LandlordStreet { get => _landlordStreet; set => _landlordStreet = value; }
        private DirtyValue<bool?> _mailingAddressIndicator;
        public bool? MailingAddressIndicator { get => _mailingAddressIndicator; set => _mailingAddressIndicator = value; }
        private DirtyValue<bool?> _noLinkToDocTrackIndicator;
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => _noLinkToDocTrackIndicator = value; }
        private DirtyValue<bool?> _printAttachmentIndicator;
        public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => _printAttachmentIndicator = value; }
        private DirtyValue<bool?> _printUserNameIndicator;
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => _printUserNameIndicator = value; }
        private DirtyValue<int?> _rent;
        public int? Rent { get => _rent; set => _rent = value; }
        private DirtyValue<DateTime?> _requestDate;
        public DateTime? RequestDate { get => _requestDate; set => _requestDate = value; }
        private DirtyValue<string> _residencyBasisType;
        public string ResidencyBasisType { get => _residencyBasisType; set => _residencyBasisType = value; }
        private DirtyValue<string> _residencyType;
        public string ResidencyType { get => _residencyType; set => _residencyType = value; }
        private DirtyValue<string> _title;
        public string Title { get => _title; set => _title = value; }
        private DirtyValue<string> _titleFax;
        public string TitleFax { get => _titleFax; set => _titleFax = value; }
        private DirtyValue<string> _titlePhone;
        public string TitlePhone { get => _titlePhone; set => _titlePhone = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _accountName.Dirty
                    || _addressCity.Dirty
                    || _addressPostalCode.Dirty
                    || _addressState.Dirty
                    || _addressStreetLine1.Dirty
                    || _altId.Dirty
                    || _applicantType.Dirty
                    || _county.Dirty
                    || _durationTermMonths.Dirty
                    || _durationTermYears.Dirty
                    || _entityDeleted.Dirty
                    || _id.Dirty
                    || _landlordAttention.Dirty
                    || _landlordCity.Dirty
                    || _landlordComments.Dirty
                    || _landlordEmail.Dirty
                    || _landlordFax.Dirty
                    || _landlordName.Dirty
                    || _landlordPhone.Dirty
                    || _landlordPostalCode.Dirty
                    || _landlordState.Dirty
                    || _landlordStreet.Dirty
                    || _mailingAddressIndicator.Dirty
                    || _noLinkToDocTrackIndicator.Dirty
                    || _printAttachmentIndicator.Dirty
                    || _printUserNameIndicator.Dirty
                    || _rent.Dirty
                    || _requestDate.Dirty
                    || _residencyBasisType.Dirty
                    || _residencyType.Dirty
                    || _title.Dirty
                    || _titleFax.Dirty
                    || _titlePhone.Dirty;
            }
            set
            {
                _accountName.Dirty = value;
                _addressCity.Dirty = value;
                _addressPostalCode.Dirty = value;
                _addressState.Dirty = value;
                _addressStreetLine1.Dirty = value;
                _altId.Dirty = value;
                _applicantType.Dirty = value;
                _county.Dirty = value;
                _durationTermMonths.Dirty = value;
                _durationTermYears.Dirty = value;
                _entityDeleted.Dirty = value;
                _id.Dirty = value;
                _landlordAttention.Dirty = value;
                _landlordCity.Dirty = value;
                _landlordComments.Dirty = value;
                _landlordEmail.Dirty = value;
                _landlordFax.Dirty = value;
                _landlordName.Dirty = value;
                _landlordPhone.Dirty = value;
                _landlordPostalCode.Dirty = value;
                _landlordState.Dirty = value;
                _landlordStreet.Dirty = value;
                _mailingAddressIndicator.Dirty = value;
                _noLinkToDocTrackIndicator.Dirty = value;
                _printAttachmentIndicator.Dirty = value;
                _printUserNameIndicator.Dirty = value;
                _rent.Dirty = value;
                _requestDate.Dirty = value;
                _residencyBasisType.Dirty = value;
                _residencyType.Dirty = value;
                _title.Dirty = value;
                _titleFax.Dirty = value;
                _titlePhone.Dirty = value;
            }
        }
    }
}