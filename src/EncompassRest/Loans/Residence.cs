using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Residence : IClean
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
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _accountName.Clean
                    && _addressCity.Clean
                    && _addressPostalCode.Clean
                    && _addressState.Clean
                    && _addressStreetLine1.Clean
                    && _altId.Clean
                    && _applicantType.Clean
                    && _county.Clean
                    && _durationTermMonths.Clean
                    && _durationTermYears.Clean
                    && _entityDeleted.Clean
                    && _id.Clean
                    && _landlordAttention.Clean
                    && _landlordCity.Clean
                    && _landlordComments.Clean
                    && _landlordEmail.Clean
                    && _landlordFax.Clean
                    && _landlordName.Clean
                    && _landlordPhone.Clean
                    && _landlordPostalCode.Clean
                    && _landlordState.Clean
                    && _landlordStreet.Clean
                    && _mailingAddressIndicator.Clean
                    && _noLinkToDocTrackIndicator.Clean
                    && _printAttachmentIndicator.Clean
                    && _printUserNameIndicator.Clean
                    && _rent.Clean
                    && _requestDate.Clean
                    && _residencyBasisType.Clean
                    && _residencyType.Clean
                    && _title.Clean
                    && _titleFax.Clean
                    && _titlePhone.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var accountName = _accountName; accountName.Clean = value; _accountName = accountName;
                var addressCity = _addressCity; addressCity.Clean = value; _addressCity = addressCity;
                var addressPostalCode = _addressPostalCode; addressPostalCode.Clean = value; _addressPostalCode = addressPostalCode;
                var addressState = _addressState; addressState.Clean = value; _addressState = addressState;
                var addressStreetLine1 = _addressStreetLine1; addressStreetLine1.Clean = value; _addressStreetLine1 = addressStreetLine1;
                var altId = _altId; altId.Clean = value; _altId = altId;
                var applicantType = _applicantType; applicantType.Clean = value; _applicantType = applicantType;
                var county = _county; county.Clean = value; _county = county;
                var durationTermMonths = _durationTermMonths; durationTermMonths.Clean = value; _durationTermMonths = durationTermMonths;
                var durationTermYears = _durationTermYears; durationTermYears.Clean = value; _durationTermYears = durationTermYears;
                var entityDeleted = _entityDeleted; entityDeleted.Clean = value; _entityDeleted = entityDeleted;
                var id = _id; id.Clean = value; _id = id;
                var landlordAttention = _landlordAttention; landlordAttention.Clean = value; _landlordAttention = landlordAttention;
                var landlordCity = _landlordCity; landlordCity.Clean = value; _landlordCity = landlordCity;
                var landlordComments = _landlordComments; landlordComments.Clean = value; _landlordComments = landlordComments;
                var landlordEmail = _landlordEmail; landlordEmail.Clean = value; _landlordEmail = landlordEmail;
                var landlordFax = _landlordFax; landlordFax.Clean = value; _landlordFax = landlordFax;
                var landlordName = _landlordName; landlordName.Clean = value; _landlordName = landlordName;
                var landlordPhone = _landlordPhone; landlordPhone.Clean = value; _landlordPhone = landlordPhone;
                var landlordPostalCode = _landlordPostalCode; landlordPostalCode.Clean = value; _landlordPostalCode = landlordPostalCode;
                var landlordState = _landlordState; landlordState.Clean = value; _landlordState = landlordState;
                var landlordStreet = _landlordStreet; landlordStreet.Clean = value; _landlordStreet = landlordStreet;
                var mailingAddressIndicator = _mailingAddressIndicator; mailingAddressIndicator.Clean = value; _mailingAddressIndicator = mailingAddressIndicator;
                var noLinkToDocTrackIndicator = _noLinkToDocTrackIndicator; noLinkToDocTrackIndicator.Clean = value; _noLinkToDocTrackIndicator = noLinkToDocTrackIndicator;
                var printAttachmentIndicator = _printAttachmentIndicator; printAttachmentIndicator.Clean = value; _printAttachmentIndicator = printAttachmentIndicator;
                var printUserNameIndicator = _printUserNameIndicator; printUserNameIndicator.Clean = value; _printUserNameIndicator = printUserNameIndicator;
                var rent = _rent; rent.Clean = value; _rent = rent;
                var requestDate = _requestDate; requestDate.Clean = value; _requestDate = requestDate;
                var residencyBasisType = _residencyBasisType; residencyBasisType.Clean = value; _residencyBasisType = residencyBasisType;
                var residencyType = _residencyType; residencyType.Clean = value; _residencyType = residencyType;
                var title = _title; title.Clean = value; _title = title;
                var titleFax = _titleFax; titleFax.Clean = value; _titleFax = titleFax;
                var titlePhone = _titlePhone; titlePhone.Clean = value; _titlePhone = titlePhone;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Residence()
        {
            Clean = true;
        }
    }
}