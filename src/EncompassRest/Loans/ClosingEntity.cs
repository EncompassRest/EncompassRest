#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingEntity : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _alias;
        public string Alias { get => _alias; set => _alias = value; }
        private DirtyValue<string> _assignee;
        public string Assignee { get => _assignee; set => _assignee = value; }
        private DirtyValue<bool?> _authorizedToSignIndicator;
        public bool? AuthorizedToSignIndicator { get => _authorizedToSignIndicator; set => _authorizedToSignIndicator = value; }
        private DirtyValue<string> _borrowerPair;
        public string BorrowerPair { get => _borrowerPair; set => _borrowerPair = value; }
        private DirtyValue<string> _city;
        public string City { get => _city; set => _city = value; }
        private DirtyValue<StringEnumValue<ClosingEntityType>> _closingEntityType;
        public StringEnumValue<ClosingEntityType> ClosingEntityType { get => _closingEntityType; set => _closingEntityType = value; }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _county;
        public string County { get => _county; set => _county = value; }
        private DirtyValue<DateTime?> _dateOfBirth;
        public DateTime? DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        private DirtyValue<string> _fax;
        public string Fax { get => _fax; set => _fax = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<StringEnumValue<OccupancyIntent>> _occupancyIntent;
        public StringEnumValue<OccupancyIntent> OccupancyIntent { get => _occupancyIntent; set => _occupancyIntent = value; }
        private DirtyValue<StringEnumValue<PropertyUsageType>> _occupancyStatus;
        public StringEnumValue<PropertyUsageType> OccupancyStatus { get => _occupancyStatus; set => _occupancyStatus = value; }
        private DirtyValue<string> _organizationType;
        public string OrganizationType { get => _organizationType; set => _organizationType = value; }
        private DirtyValue<string> _organizedUnderTheLawsOfJurisdictionName;
        public string OrganizedUnderTheLawsOfJurisdictionName { get => _organizedUnderTheLawsOfJurisdictionName; set => _organizedUnderTheLawsOfJurisdictionName = value; }
        private DirtyValue<string> _phone;
        public string Phone { get => _phone; set => _phone = value; }
        private DirtyValue<string> _phone1;
        public string Phone1 { get => _phone1; set => _phone1 = value; }
        private DirtyValue<string> _phone2;
        public string Phone2 { get => _phone2; set => _phone2 = value; }
        private DirtyValue<string> _poaSignatureText;
        public string PoaSignatureText { get => _poaSignatureText; set => _poaSignatureText = value; }
        private DirtyValue<string> _postalCode;
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        private DirtyValue<string> _powerOfAttorney;
        public string PowerOfAttorney { get => _powerOfAttorney; set => _powerOfAttorney = value; }
        private DirtyValue<DateTime?> _recordableDocumentTrustDate;
        public DateTime? RecordableDocumentTrustDate { get => _recordableDocumentTrustDate; set => _recordableDocumentTrustDate = value; }
        private DirtyValue<string> _recordCity;
        public string RecordCity { get => _recordCity; set => _recordCity = value; }
        private DirtyValue<string> _ssn;
        public string Ssn { get => _ssn; set => _ssn = value; }
        private DirtyValue<string> _state;
        public string State { get => _state; set => _state = value; }
        private DirtyValue<string> _streetAddress;
        public string StreetAddress { get => _streetAddress; set => _streetAddress = value; }
        private DirtyValue<string> _taxIdentificationNumberIdentifier;
        public string TaxIdentificationNumberIdentifier { get => _taxIdentificationNumberIdentifier; set => _taxIdentificationNumberIdentifier = value; }
        private DirtyValue<string> _trustOfficerName1;
        public string TrustOfficerName1 { get => _trustOfficerName1; set => _trustOfficerName1 = value; }
        private DirtyValue<string> _trustOfficerName2;
        public string TrustOfficerName2 { get => _trustOfficerName2; set => _trustOfficerName2 = value; }
        private DirtyValue<string> _trustOfficerTitle1;
        public string TrustOfficerTitle1 { get => _trustOfficerTitle1; set => _trustOfficerTitle1 = value; }
        private DirtyValue<string> _trustOfficerTitle2;
        public string TrustOfficerTitle2 { get => _trustOfficerTitle2; set => _trustOfficerTitle2 = value; }
        private DirtyValue<string> _unparsedName;
        public string UnparsedName { get => _unparsedName; set => _unparsedName = value; }
        private DirtyValue<string> _vesting;
        public string Vesting { get => _vesting; set => _vesting = value; }
        private DirtyValue<string> _vestingGuid;
        public string VestingGuid { get => _vestingGuid; set => _vestingGuid = value; }
        private DirtyValue<StringEnumValue<VestingTrusteeOfType>> _vestingTrusteeOfType;
        public StringEnumValue<VestingTrusteeOfType> VestingTrusteeOfType { get => _vestingTrusteeOfType; set => _vestingTrusteeOfType = value; }
        private DirtyValue<StringEnumValue<BorrowerType>> _vestingType;
        public StringEnumValue<BorrowerType> VestingType { get => _vestingType; set => _vestingType = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _alias.Dirty
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
            }
            set
            {
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
            }
        }
    }
}