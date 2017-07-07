using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
                var alias = _alias; alias.Clean = value; _alias = alias;
                var assignee = _assignee; assignee.Clean = value; _assignee = assignee;
                var authorizedToSignIndicator = _authorizedToSignIndicator; authorizedToSignIndicator.Clean = value; _authorizedToSignIndicator = authorizedToSignIndicator;
                var borrowerPair = _borrowerPair; borrowerPair.Clean = value; _borrowerPair = borrowerPair;
                var city = _city; city.Clean = value; _city = city;
                var closingEntityType = _closingEntityType; closingEntityType.Clean = value; _closingEntityType = closingEntityType;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var county = _county; county.Clean = value; _county = county;
                var dateOfBirth = _dateOfBirth; dateOfBirth.Clean = value; _dateOfBirth = dateOfBirth;
                var fax = _fax; fax.Clean = value; _fax = fax;
                var id = _id; id.Clean = value; _id = id;
                var occupancyIntent = _occupancyIntent; occupancyIntent.Clean = value; _occupancyIntent = occupancyIntent;
                var occupancyStatus = _occupancyStatus; occupancyStatus.Clean = value; _occupancyStatus = occupancyStatus;
                var organizationType = _organizationType; organizationType.Clean = value; _organizationType = organizationType;
                var organizedUnderTheLawsOfJurisdictionName = _organizedUnderTheLawsOfJurisdictionName; organizedUnderTheLawsOfJurisdictionName.Clean = value; _organizedUnderTheLawsOfJurisdictionName = organizedUnderTheLawsOfJurisdictionName;
                var phone = _phone; phone.Clean = value; _phone = phone;
                var phone1 = _phone1; phone1.Clean = value; _phone1 = phone1;
                var phone2 = _phone2; phone2.Clean = value; _phone2 = phone2;
                var poaSignatureText = _poaSignatureText; poaSignatureText.Clean = value; _poaSignatureText = poaSignatureText;
                var postalCode = _postalCode; postalCode.Clean = value; _postalCode = postalCode;
                var powerOfAttorney = _powerOfAttorney; powerOfAttorney.Clean = value; _powerOfAttorney = powerOfAttorney;
                var recordableDocumentTrustDate = _recordableDocumentTrustDate; recordableDocumentTrustDate.Clean = value; _recordableDocumentTrustDate = recordableDocumentTrustDate;
                var recordCity = _recordCity; recordCity.Clean = value; _recordCity = recordCity;
                var ssn = _ssn; ssn.Clean = value; _ssn = ssn;
                var state = _state; state.Clean = value; _state = state;
                var streetAddress = _streetAddress; streetAddress.Clean = value; _streetAddress = streetAddress;
                var taxIdentificationNumberIdentifier = _taxIdentificationNumberIdentifier; taxIdentificationNumberIdentifier.Clean = value; _taxIdentificationNumberIdentifier = taxIdentificationNumberIdentifier;
                var trustOfficerName1 = _trustOfficerName1; trustOfficerName1.Clean = value; _trustOfficerName1 = trustOfficerName1;
                var trustOfficerName2 = _trustOfficerName2; trustOfficerName2.Clean = value; _trustOfficerName2 = trustOfficerName2;
                var trustOfficerTitle1 = _trustOfficerTitle1; trustOfficerTitle1.Clean = value; _trustOfficerTitle1 = trustOfficerTitle1;
                var trustOfficerTitle2 = _trustOfficerTitle2; trustOfficerTitle2.Clean = value; _trustOfficerTitle2 = trustOfficerTitle2;
                var unparsedName = _unparsedName; unparsedName.Clean = value; _unparsedName = unparsedName;
                var vesting = _vesting; vesting.Clean = value; _vesting = vesting;
                var vestingGuid = _vestingGuid; vestingGuid.Clean = value; _vestingGuid = vestingGuid;
                var vestingTrusteeOfType = _vestingTrusteeOfType; vestingTrusteeOfType.Clean = value; _vestingTrusteeOfType = vestingTrusteeOfType;
                var vestingType = _vestingType; vestingType.Clean = value; _vestingType = vestingType;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public ClosingEntity()
        {
            Clean = true;
        }
    }
}