using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Residence
    {
        private Value<string> _accountName;
        public string AccountName { get { return _accountName; } set { _accountName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAccountName() => !_accountName.Clean;
        private Value<string> _addressCity;
        public string AddressCity { get { return _addressCity; } set { _addressCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddressCity() => !_addressCity.Clean;
        private Value<string> _addressPostalCode;
        public string AddressPostalCode { get { return _addressPostalCode; } set { _addressPostalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddressPostalCode() => !_addressPostalCode.Clean;
        private Value<string> _addressState;
        public string AddressState { get { return _addressState; } set { _addressState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddressState() => !_addressState.Clean;
        private Value<string> _addressStreetLine1;
        public string AddressStreetLine1 { get { return _addressStreetLine1; } set { _addressStreetLine1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddressStreetLine1() => !_addressStreetLine1.Clean;
        private Value<string> _altId;
        public string AltId { get { return _altId; } set { _altId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAltId() => !_altId.Clean;
        private Value<string> _applicantType;
        public string ApplicantType { get { return _applicantType; } set { _applicantType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantType() => !_applicantType.Clean;
        private Value<string> _county;
        public string County { get { return _county; } set { _county = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCounty() => !_county.Clean;
        private Value<int?> _durationTermMonths;
        public int? DurationTermMonths { get { return _durationTermMonths; } set { _durationTermMonths = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDurationTermMonths() => !_durationTermMonths.Clean;
        private Value<int?> _durationTermYears;
        public int? DurationTermYears { get { return _durationTermYears; } set { _durationTermYears = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDurationTermYears() => !_durationTermYears.Clean;
        private Value<bool?> _entityDeleted;
        public bool? EntityDeleted { get { return _entityDeleted; } set { _entityDeleted = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEntityDeleted() => !_entityDeleted.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _landlordAttention;
        public string LandlordAttention { get { return _landlordAttention; } set { _landlordAttention = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandlordAttention() => !_landlordAttention.Clean;
        private Value<string> _landlordCity;
        public string LandlordCity { get { return _landlordCity; } set { _landlordCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandlordCity() => !_landlordCity.Clean;
        private Value<string> _landlordComments;
        public string LandlordComments { get { return _landlordComments; } set { _landlordComments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandlordComments() => !_landlordComments.Clean;
        private Value<string> _landlordEmail;
        public string LandlordEmail { get { return _landlordEmail; } set { _landlordEmail = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandlordEmail() => !_landlordEmail.Clean;
        private Value<string> _landlordFax;
        public string LandlordFax { get { return _landlordFax; } set { _landlordFax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandlordFax() => !_landlordFax.Clean;
        private Value<string> _landlordName;
        public string LandlordName { get { return _landlordName; } set { _landlordName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandlordName() => !_landlordName.Clean;
        private Value<string> _landlordPhone;
        public string LandlordPhone { get { return _landlordPhone; } set { _landlordPhone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandlordPhone() => !_landlordPhone.Clean;
        private Value<string> _landlordPostalCode;
        public string LandlordPostalCode { get { return _landlordPostalCode; } set { _landlordPostalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandlordPostalCode() => !_landlordPostalCode.Clean;
        private Value<string> _landlordState;
        public string LandlordState { get { return _landlordState; } set { _landlordState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandlordState() => !_landlordState.Clean;
        private Value<string> _landlordStreet;
        public string LandlordStreet { get { return _landlordStreet; } set { _landlordStreet = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandlordStreet() => !_landlordStreet.Clean;
        private Value<bool?> _mailingAddressIndicator;
        public bool? MailingAddressIndicator { get { return _mailingAddressIndicator; } set { _mailingAddressIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMailingAddressIndicator() => !_mailingAddressIndicator.Clean;
        private Value<bool?> _noLinkToDocTrackIndicator;
        public bool? NoLinkToDocTrackIndicator { get { return _noLinkToDocTrackIndicator; } set { _noLinkToDocTrackIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNoLinkToDocTrackIndicator() => !_noLinkToDocTrackIndicator.Clean;
        private Value<bool?> _printAttachmentIndicator;
        public bool? PrintAttachmentIndicator { get { return _printAttachmentIndicator; } set { _printAttachmentIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintAttachmentIndicator() => !_printAttachmentIndicator.Clean;
        private Value<bool?> _printUserNameIndicator;
        public bool? PrintUserNameIndicator { get { return _printUserNameIndicator; } set { _printUserNameIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintUserNameIndicator() => !_printUserNameIndicator.Clean;
        private Value<int?> _rent;
        public int? Rent { get { return _rent; } set { _rent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRent() => !_rent.Clean;
        private Value<DateTime?> _requestDate;
        public DateTime? RequestDate { get { return _requestDate; } set { _requestDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestDate() => !_requestDate.Clean;
        private Value<string> _residencyBasisType;
        public string ResidencyBasisType { get { return _residencyBasisType; } set { _residencyBasisType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeResidencyBasisType() => !_residencyBasisType.Clean;
        private Value<string> _residencyType;
        public string ResidencyType { get { return _residencyType; } set { _residencyType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeResidencyType() => !_residencyType.Clean;
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle() => !_title.Clean;
        private Value<string> _titleFax;
        public string TitleFax { get { return _titleFax; } set { _titleFax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleFax() => !_titleFax.Clean;
        private Value<string> _titlePhone;
        public string TitlePhone { get { return _titlePhone; } set { _titlePhone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitlePhone() => !_titlePhone.Clean;
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
                var v0 = _accountName; v0.Clean = value; _accountName = v0;
                var v1 = _addressCity; v1.Clean = value; _addressCity = v1;
                var v2 = _addressPostalCode; v2.Clean = value; _addressPostalCode = v2;
                var v3 = _addressState; v3.Clean = value; _addressState = v3;
                var v4 = _addressStreetLine1; v4.Clean = value; _addressStreetLine1 = v4;
                var v5 = _altId; v5.Clean = value; _altId = v5;
                var v6 = _applicantType; v6.Clean = value; _applicantType = v6;
                var v7 = _county; v7.Clean = value; _county = v7;
                var v8 = _durationTermMonths; v8.Clean = value; _durationTermMonths = v8;
                var v9 = _durationTermYears; v9.Clean = value; _durationTermYears = v9;
                var v10 = _entityDeleted; v10.Clean = value; _entityDeleted = v10;
                var v11 = _id; v11.Clean = value; _id = v11;
                var v12 = _landlordAttention; v12.Clean = value; _landlordAttention = v12;
                var v13 = _landlordCity; v13.Clean = value; _landlordCity = v13;
                var v14 = _landlordComments; v14.Clean = value; _landlordComments = v14;
                var v15 = _landlordEmail; v15.Clean = value; _landlordEmail = v15;
                var v16 = _landlordFax; v16.Clean = value; _landlordFax = v16;
                var v17 = _landlordName; v17.Clean = value; _landlordName = v17;
                var v18 = _landlordPhone; v18.Clean = value; _landlordPhone = v18;
                var v19 = _landlordPostalCode; v19.Clean = value; _landlordPostalCode = v19;
                var v20 = _landlordState; v20.Clean = value; _landlordState = v20;
                var v21 = _landlordStreet; v21.Clean = value; _landlordStreet = v21;
                var v22 = _mailingAddressIndicator; v22.Clean = value; _mailingAddressIndicator = v22;
                var v23 = _noLinkToDocTrackIndicator; v23.Clean = value; _noLinkToDocTrackIndicator = v23;
                var v24 = _printAttachmentIndicator; v24.Clean = value; _printAttachmentIndicator = v24;
                var v25 = _printUserNameIndicator; v25.Clean = value; _printUserNameIndicator = v25;
                var v26 = _rent; v26.Clean = value; _rent = v26;
                var v27 = _requestDate; v27.Clean = value; _requestDate = v27;
                var v28 = _residencyBasisType; v28.Clean = value; _residencyBasisType = v28;
                var v29 = _residencyType; v29.Clean = value; _residencyType = v29;
                var v30 = _title; v30.Clean = value; _title = v30;
                var v31 = _titleFax; v31.Clean = value; _titleFax = v31;
                var v32 = _titlePhone; v32.Clean = value; _titlePhone = v32;
                _settingClean = 0;
            }
        }
    }
}