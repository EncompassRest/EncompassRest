using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingEntity : IClean
    {
        private Value<string> _alias;
        public string Alias { get { return _alias; } set { _alias = value; } }
        private Value<string> _assignee;
        public string Assignee { get { return _assignee; } set { _assignee = value; } }
        private Value<bool?> _authorizedToSignIndicator;
        public bool? AuthorizedToSignIndicator { get { return _authorizedToSignIndicator; } set { _authorizedToSignIndicator = value; } }
        private Value<string> _borrowerPair;
        public string BorrowerPair { get { return _borrowerPair; } set { _borrowerPair = value; } }
        private Value<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        private Value<string> _closingEntityType;
        public string ClosingEntityType { get { return _closingEntityType; } set { _closingEntityType = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<string> _county;
        public string County { get { return _county; } set { _county = value; } }
        private Value<DateTime?> _dateOfBirth;
        public DateTime? DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }
        private Value<string> _fax;
        public string Fax { get { return _fax; } set { _fax = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _occupancyIntent;
        public string OccupancyIntent { get { return _occupancyIntent; } set { _occupancyIntent = value; } }
        private Value<string> _occupancyStatus;
        public string OccupancyStatus { get { return _occupancyStatus; } set { _occupancyStatus = value; } }
        private Value<string> _organizationType;
        public string OrganizationType { get { return _organizationType; } set { _organizationType = value; } }
        private Value<string> _organizedUnderTheLawsOfJurisdictionName;
        public string OrganizedUnderTheLawsOfJurisdictionName { get { return _organizedUnderTheLawsOfJurisdictionName; } set { _organizedUnderTheLawsOfJurisdictionName = value; } }
        private Value<string> _phone;
        public string Phone { get { return _phone; } set { _phone = value; } }
        private Value<string> _phone1;
        public string Phone1 { get { return _phone1; } set { _phone1 = value; } }
        private Value<string> _phone2;
        public string Phone2 { get { return _phone2; } set { _phone2 = value; } }
        private Value<string> _poaSignatureText;
        public string PoaSignatureText { get { return _poaSignatureText; } set { _poaSignatureText = value; } }
        private Value<string> _postalCode;
        public string PostalCode { get { return _postalCode; } set { _postalCode = value; } }
        private Value<string> _powerOfAttorney;
        public string PowerOfAttorney { get { return _powerOfAttorney; } set { _powerOfAttorney = value; } }
        private Value<DateTime?> _recordableDocumentTrustDate;
        public DateTime? RecordableDocumentTrustDate { get { return _recordableDocumentTrustDate; } set { _recordableDocumentTrustDate = value; } }
        private Value<string> _recordCity;
        public string RecordCity { get { return _recordCity; } set { _recordCity = value; } }
        private Value<string> _ssn;
        public string Ssn { get { return _ssn; } set { _ssn = value; } }
        private Value<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        private Value<string> _streetAddress;
        public string StreetAddress { get { return _streetAddress; } set { _streetAddress = value; } }
        private Value<string> _taxIdentificationNumberIdentifier;
        public string TaxIdentificationNumberIdentifier { get { return _taxIdentificationNumberIdentifier; } set { _taxIdentificationNumberIdentifier = value; } }
        private Value<string> _trustOfficerName1;
        public string TrustOfficerName1 { get { return _trustOfficerName1; } set { _trustOfficerName1 = value; } }
        private Value<string> _trustOfficerName2;
        public string TrustOfficerName2 { get { return _trustOfficerName2; } set { _trustOfficerName2 = value; } }
        private Value<string> _trustOfficerTitle1;
        public string TrustOfficerTitle1 { get { return _trustOfficerTitle1; } set { _trustOfficerTitle1 = value; } }
        private Value<string> _trustOfficerTitle2;
        public string TrustOfficerTitle2 { get { return _trustOfficerTitle2; } set { _trustOfficerTitle2 = value; } }
        private Value<string> _unparsedName;
        public string UnparsedName { get { return _unparsedName; } set { _unparsedName = value; } }
        private Value<string> _vesting;
        public string Vesting { get { return _vesting; } set { _vesting = value; } }
        private Value<string> _vestingGuid;
        public string VestingGuid { get { return _vestingGuid; } set { _vestingGuid = value; } }
        private Value<string> _vestingTrusteeOfType;
        public string VestingTrusteeOfType { get { return _vestingTrusteeOfType; } set { _vestingTrusteeOfType = value; } }
        private Value<string> _vestingType;
        public string VestingType { get { return _vestingType; } set { _vestingType = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _alias.Clean
                    && _assignee.Clean
                    && _authorizedToSignIndicator.Clean
                    && _borrowerPair.Clean
                    && _city.Clean
                    && _closingEntityType.Clean
                    && _comments.Clean
                    && _county.Clean
                    && _dateOfBirth.Clean
                    && _fax.Clean
                    && _id.Clean
                    && _occupancyIntent.Clean
                    && _occupancyStatus.Clean
                    && _organizationType.Clean
                    && _organizedUnderTheLawsOfJurisdictionName.Clean
                    && _phone.Clean
                    && _phone1.Clean
                    && _phone2.Clean
                    && _poaSignatureText.Clean
                    && _postalCode.Clean
                    && _powerOfAttorney.Clean
                    && _recordableDocumentTrustDate.Clean
                    && _recordCity.Clean
                    && _ssn.Clean
                    && _state.Clean
                    && _streetAddress.Clean
                    && _taxIdentificationNumberIdentifier.Clean
                    && _trustOfficerName1.Clean
                    && _trustOfficerName2.Clean
                    && _trustOfficerTitle1.Clean
                    && _trustOfficerTitle2.Clean
                    && _unparsedName.Clean
                    && _vesting.Clean
                    && _vestingGuid.Clean
                    && _vestingTrusteeOfType.Clean
                    && _vestingType.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _alias; v0.Clean = value; _alias = v0;
                var v1 = _assignee; v1.Clean = value; _assignee = v1;
                var v2 = _authorizedToSignIndicator; v2.Clean = value; _authorizedToSignIndicator = v2;
                var v3 = _borrowerPair; v3.Clean = value; _borrowerPair = v3;
                var v4 = _city; v4.Clean = value; _city = v4;
                var v5 = _closingEntityType; v5.Clean = value; _closingEntityType = v5;
                var v6 = _comments; v6.Clean = value; _comments = v6;
                var v7 = _county; v7.Clean = value; _county = v7;
                var v8 = _dateOfBirth; v8.Clean = value; _dateOfBirth = v8;
                var v9 = _fax; v9.Clean = value; _fax = v9;
                var v10 = _id; v10.Clean = value; _id = v10;
                var v11 = _occupancyIntent; v11.Clean = value; _occupancyIntent = v11;
                var v12 = _occupancyStatus; v12.Clean = value; _occupancyStatus = v12;
                var v13 = _organizationType; v13.Clean = value; _organizationType = v13;
                var v14 = _organizedUnderTheLawsOfJurisdictionName; v14.Clean = value; _organizedUnderTheLawsOfJurisdictionName = v14;
                var v15 = _phone; v15.Clean = value; _phone = v15;
                var v16 = _phone1; v16.Clean = value; _phone1 = v16;
                var v17 = _phone2; v17.Clean = value; _phone2 = v17;
                var v18 = _poaSignatureText; v18.Clean = value; _poaSignatureText = v18;
                var v19 = _postalCode; v19.Clean = value; _postalCode = v19;
                var v20 = _powerOfAttorney; v20.Clean = value; _powerOfAttorney = v20;
                var v21 = _recordableDocumentTrustDate; v21.Clean = value; _recordableDocumentTrustDate = v21;
                var v22 = _recordCity; v22.Clean = value; _recordCity = v22;
                var v23 = _ssn; v23.Clean = value; _ssn = v23;
                var v24 = _state; v24.Clean = value; _state = v24;
                var v25 = _streetAddress; v25.Clean = value; _streetAddress = v25;
                var v26 = _taxIdentificationNumberIdentifier; v26.Clean = value; _taxIdentificationNumberIdentifier = v26;
                var v27 = _trustOfficerName1; v27.Clean = value; _trustOfficerName1 = v27;
                var v28 = _trustOfficerName2; v28.Clean = value; _trustOfficerName2 = v28;
                var v29 = _trustOfficerTitle1; v29.Clean = value; _trustOfficerTitle1 = v29;
                var v30 = _trustOfficerTitle2; v30.Clean = value; _trustOfficerTitle2 = v30;
                var v31 = _unparsedName; v31.Clean = value; _unparsedName = v31;
                var v32 = _vesting; v32.Clean = value; _vesting = v32;
                var v33 = _vestingGuid; v33.Clean = value; _vestingGuid = v33;
                var v34 = _vestingTrusteeOfType; v34.Clean = value; _vestingTrusteeOfType = v34;
                var v35 = _vestingType; v35.Clean = value; _vestingType = v35;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}