using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Residence : IDirty
    {
        private Value<string> _accountName;
        public string AccountName { get { return _accountName; } set { _accountName = value; } }
        private Value<string> _addressCity;
        public string AddressCity { get { return _addressCity; } set { _addressCity = value; } }
        private Value<string> _addressPostalCode;
        public string AddressPostalCode { get { return _addressPostalCode; } set { _addressPostalCode = value; } }
        private Value<string> _addressState;
        public string AddressState { get { return _addressState; } set { _addressState = value; } }
        private Value<string> _addressStreetLine1;
        public string AddressStreetLine1 { get { return _addressStreetLine1; } set { _addressStreetLine1 = value; } }
        private Value<string> _altId;
        public string AltId { get { return _altId; } set { _altId = value; } }
        private Value<string> _applicantType;
        public string ApplicantType { get { return _applicantType; } set { _applicantType = value; } }
        private Value<string> _county;
        public string County { get { return _county; } set { _county = value; } }
        private Value<int?> _durationTermMonths;
        public int? DurationTermMonths { get { return _durationTermMonths; } set { _durationTermMonths = value; } }
        private Value<int?> _durationTermYears;
        public int? DurationTermYears { get { return _durationTermYears; } set { _durationTermYears = value; } }
        private Value<bool?> _entityDeleted;
        public bool? EntityDeleted { get { return _entityDeleted; } set { _entityDeleted = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _landlordAttention;
        public string LandlordAttention { get { return _landlordAttention; } set { _landlordAttention = value; } }
        private Value<string> _landlordCity;
        public string LandlordCity { get { return _landlordCity; } set { _landlordCity = value; } }
        private Value<string> _landlordComments;
        public string LandlordComments { get { return _landlordComments; } set { _landlordComments = value; } }
        private Value<string> _landlordEmail;
        public string LandlordEmail { get { return _landlordEmail; } set { _landlordEmail = value; } }
        private Value<string> _landlordFax;
        public string LandlordFax { get { return _landlordFax; } set { _landlordFax = value; } }
        private Value<string> _landlordName;
        public string LandlordName { get { return _landlordName; } set { _landlordName = value; } }
        private Value<string> _landlordPhone;
        public string LandlordPhone { get { return _landlordPhone; } set { _landlordPhone = value; } }
        private Value<string> _landlordPostalCode;
        public string LandlordPostalCode { get { return _landlordPostalCode; } set { _landlordPostalCode = value; } }
        private Value<string> _landlordState;
        public string LandlordState { get { return _landlordState; } set { _landlordState = value; } }
        private Value<string> _landlordStreet;
        public string LandlordStreet { get { return _landlordStreet; } set { _landlordStreet = value; } }
        private Value<bool?> _mailingAddressIndicator;
        public bool? MailingAddressIndicator { get { return _mailingAddressIndicator; } set { _mailingAddressIndicator = value; } }
        private Value<bool?> _noLinkToDocTrackIndicator;
        public bool? NoLinkToDocTrackIndicator { get { return _noLinkToDocTrackIndicator; } set { _noLinkToDocTrackIndicator = value; } }
        private Value<bool?> _printAttachmentIndicator;
        public bool? PrintAttachmentIndicator { get { return _printAttachmentIndicator; } set { _printAttachmentIndicator = value; } }
        private Value<bool?> _printUserNameIndicator;
        public bool? PrintUserNameIndicator { get { return _printUserNameIndicator; } set { _printUserNameIndicator = value; } }
        private Value<int?> _rent;
        public int? Rent { get { return _rent; } set { _rent = value; } }
        private Value<DateTime?> _requestDate;
        public DateTime? RequestDate { get { return _requestDate; } set { _requestDate = value; } }
        private Value<string> _residencyBasisType;
        public string ResidencyBasisType { get { return _residencyBasisType; } set { _residencyBasisType = value; } }
        private Value<string> _residencyType;
        public string ResidencyType { get { return _residencyType; } set { _residencyType = value; } }
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        private Value<string> _titleFax;
        public string TitleFax { get { return _titleFax; } set { _titleFax = value; } }
        private Value<string> _titlePhone;
        public string TitlePhone { get { return _titlePhone; } set { _titlePhone = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _accountName.Dirty
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
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}