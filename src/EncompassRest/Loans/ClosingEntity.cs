using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingEntity : IDirty
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _alias.Dirty
                    || _assignee.Dirty
                    || _authorizedToSignIndicator.Dirty
                    || _borrowerPair.Dirty
                    || _city.Dirty
                    || _closingEntityType.Dirty
                    || _comments.Dirty
                    || _county.Dirty
                    || _dateOfBirth.Dirty
                    || _fax.Dirty
                    || _id.Dirty
                    || _occupancyIntent.Dirty
                    || _occupancyStatus.Dirty
                    || _organizationType.Dirty
                    || _organizedUnderTheLawsOfJurisdictionName.Dirty
                    || _phone.Dirty
                    || _phone1.Dirty
                    || _phone2.Dirty
                    || _poaSignatureText.Dirty
                    || _postalCode.Dirty
                    || _powerOfAttorney.Dirty
                    || _recordableDocumentTrustDate.Dirty
                    || _recordCity.Dirty
                    || _ssn.Dirty
                    || _state.Dirty
                    || _streetAddress.Dirty
                    || _taxIdentificationNumberIdentifier.Dirty
                    || _trustOfficerName1.Dirty
                    || _trustOfficerName2.Dirty
                    || _trustOfficerTitle1.Dirty
                    || _trustOfficerTitle2.Dirty
                    || _unparsedName.Dirty
                    || _vesting.Dirty
                    || _vestingGuid.Dirty
                    || _vestingTrusteeOfType.Dirty
                    || _vestingType.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _alias.Dirty = value;
                _assignee.Dirty = value;
                _authorizedToSignIndicator.Dirty = value;
                _borrowerPair.Dirty = value;
                _city.Dirty = value;
                _closingEntityType.Dirty = value;
                _comments.Dirty = value;
                _county.Dirty = value;
                _dateOfBirth.Dirty = value;
                _fax.Dirty = value;
                _id.Dirty = value;
                _occupancyIntent.Dirty = value;
                _occupancyStatus.Dirty = value;
                _organizationType.Dirty = value;
                _organizedUnderTheLawsOfJurisdictionName.Dirty = value;
                _phone.Dirty = value;
                _phone1.Dirty = value;
                _phone2.Dirty = value;
                _poaSignatureText.Dirty = value;
                _postalCode.Dirty = value;
                _powerOfAttorney.Dirty = value;
                _recordableDocumentTrustDate.Dirty = value;
                _recordCity.Dirty = value;
                _ssn.Dirty = value;
                _state.Dirty = value;
                _streetAddress.Dirty = value;
                _taxIdentificationNumberIdentifier.Dirty = value;
                _trustOfficerName1.Dirty = value;
                _trustOfficerName2.Dirty = value;
                _trustOfficerTitle1.Dirty = value;
                _trustOfficerTitle2.Dirty = value;
                _unparsedName.Dirty = value;
                _vesting.Dirty = value;
                _vestingGuid.Dirty = value;
                _vestingTrusteeOfType.Dirty = value;
                _vestingType.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}