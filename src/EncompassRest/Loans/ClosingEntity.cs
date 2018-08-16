using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ClosingEntity
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(ClosingEntityType), SerializeWholeListWhenDirty = true)]
    public sealed partial class ClosingEntity : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _alias;
        /// <summary>
        /// Vesting Party - Alias [TRNN02]
        /// </summary>
        [LoanFieldProperty(Description = "Vesting Party - Alias")]
        public string Alias { get => _alias; set => SetField(ref _alias, value); }
        private DirtyValue<string> _assignee;
        /// <summary>
        /// Closing Docs Loss Payee Assignee [1953]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Docs Loss Payee Assignee")]
        public string Assignee { get => _assignee; set => SetField(ref _assignee, value); }
        private DirtyValue<bool?> _authorizedToSignIndicator;
        /// <summary>
        /// Vesting Party - Authorized to Sign [TRNN09]
        /// </summary>
        [LoanFieldProperty(Description = "Vesting Party - Authorized to Sign", OptionsJson = "{\"true\":\"Authorized to Sign\"}")]
        public bool? AuthorizedToSignIndicator { get => _authorizedToSignIndicator; set => SetField(ref _authorizedToSignIndicator, value); }
        private DirtyValue<string> _borrowerPair;
        /// <summary>
        /// Vesting Party - Borrower Pair ID [TRNN05]
        /// </summary>
        [LoanFieldProperty(Description = "Vesting Party - Borrower Pair ID")]
        public string BorrowerPair { get => _borrowerPair; set => SetField(ref _borrowerPair, value); }
        private DirtyValue<string> _city;
        /// <summary>
        /// ClosingEntity City
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string City { get => _city; set => SetField(ref _city, value); }
        private DirtyValue<StringEnumValue<ClosingEntityType>> _closingEntityType;
        /// <summary>
        /// ClosingEntity ClosingEntityType
        /// </summary>
        public StringEnumValue<ClosingEntityType> ClosingEntityType { get => _closingEntityType; set => SetField(ref _closingEntityType, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// Closing docs Recordable Doc Comments [2980]
        /// </summary>
        [LoanFieldProperty(Description = "Closing docs Recordable Doc Comments")]
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<string> _county;
        /// <summary>
        /// Closing Docs Recordable Doc Trustee County [3901]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Recordable Doc Trustee County")]
        public string County { get => _county; set => SetField(ref _county, value); }
        private DirtyValue<DateTime?> _dateOfBirth;
        /// <summary>
        /// Vesting Party - POA Date of Birth [TRNN12]
        /// </summary>
        [LoanFieldProperty(Description = "Vesting Party - POA Date of Birth")]
        public DateTime? DateOfBirth { get => _dateOfBirth; set => SetField(ref _dateOfBirth, value); }
        private DirtyValue<string> _fax;
        /// <summary>
        /// Closing Docs Lender Fax [1922]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true, Description = "Closing Docs Lender Fax")]
        public string Fax { get => _fax; set => SetField(ref _fax, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// ClosingEntity Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<StringEnumValue<OccupancyIntent>> _occupancyIntent;
        /// <summary>
        /// Vesting Party - POA Occupancy Intent [TRNN14]
        /// </summary>
        [LoanFieldProperty(Description = "Vesting Party - POA Occupancy Intent")]
        public StringEnumValue<OccupancyIntent> OccupancyIntent { get => _occupancyIntent; set => SetField(ref _occupancyIntent, value); }
        private DirtyValue<StringEnumValue<PropertyUsageType>> _occupancyStatus;
        /// <summary>
        /// Vesting Party - POA Occupancy Status [TRNN13]
        /// </summary>
        [LoanFieldProperty(Description = "Vesting Party - POA Occupancy Status")]
        public StringEnumValue<PropertyUsageType> OccupancyStatus { get => _occupancyStatus; set => SetField(ref _occupancyStatus, value); }
        private DirtyValue<string> _organizationType;
        /// <summary>
        /// ClosingEntity OrganizationType
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string OrganizationType { get => _organizationType; set => SetField(ref _organizationType, value); }
        private DirtyValue<string> _organizedUnderTheLawsOfJurisdictionName;
        /// <summary>
        /// ClosingEntity OrganizedUnderTheLawsOfJurisdictionName
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string OrganizedUnderTheLawsOfJurisdictionName { get => _organizedUnderTheLawsOfJurisdictionName; set => SetField(ref _organizedUnderTheLawsOfJurisdictionName, value); }
        private DirtyValue<string> _phone;
        /// <summary>
        /// Closing Docs Recordable Doc Trustee Phone Number [3552]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Closing Docs Recordable Doc Trustee Phone Number")]
        public string Phone { get => _phone; set => SetField(ref _phone, value); }
        private DirtyValue<string> _phone1;
        /// <summary>
        /// Closing Docs Lender Phone 1 [1920]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true, Description = "Closing Docs Lender Phone 1")]
        public string Phone1 { get => _phone1; set => SetField(ref _phone1, value); }
        private DirtyValue<string> _phone2;
        /// <summary>
        /// Closing Docs Lender Phone 2 [1921]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true, Description = "Closing Docs Lender Phone 2")]
        public string Phone2 { get => _phone2; set => SetField(ref _phone2, value); }
        private DirtyValue<string> _poaSignatureText;
        /// <summary>
        /// Vesting Party - POA Signature Text [TRNN11]
        /// </summary>
        [LoanFieldProperty(Description = "Vesting Party - POA Signature Text")]
        public string PoaSignatureText { get => _poaSignatureText; set => SetField(ref _poaSignatureText, value); }
        private DirtyValue<string> _postalCode;
        /// <summary>
        /// ClosingEntity PostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, ReadOnly = true)]
        public string PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }
        private DirtyValue<string> _powerOfAttorney;
        /// <summary>
        /// Vesting Party - Power of Attroney [TRNN07]
        /// </summary>
        [LoanFieldProperty(Description = "Vesting Party - Power of Attroney")]
        public string PowerOfAttorney { get => _powerOfAttorney; set => SetField(ref _powerOfAttorney, value); }
        private DirtyValue<DateTime?> _recordableDocumentTrustDate;
        /// <summary>
        /// Closing docs Recordable Doc Trust Date [2979]
        /// </summary>
        [LoanFieldProperty(Description = "Closing docs Recordable Doc Trust Date")]
        public DateTime? RecordableDocumentTrustDate { get => _recordableDocumentTrustDate; set => SetField(ref _recordableDocumentTrustDate, value); }
        private DirtyValue<string> _recordCity;
        /// <summary>
        /// Closing Docs Lender Record City [1923]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Docs Lender Record City")]
        public string RecordCity { get => _recordCity; set => SetField(ref _recordCity, value); }
        private DirtyValue<string> _ssn;
        /// <summary>
        /// Vesting Party - Social Security Number [TRNN03]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.SSN, Description = "Vesting Party - Social Security Number")]
        public string Ssn { get => _ssn; set => SetField(ref _ssn, value); }
        private DirtyValue<StringEnumValue<State>> _state;
        /// <summary>
        /// ClosingEntity State
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }
        private DirtyValue<string> _streetAddress;
        /// <summary>
        /// ClosingEntity StreetAddress
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string StreetAddress { get => _streetAddress; set => SetField(ref _streetAddress, value); }
        private DirtyValue<string> _taxIdentificationNumberIdentifier;
        /// <summary>
        /// Borrower Vesting Seller Org Tax ID [1866]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Borrower Vesting Seller Org Tax ID")]
        public string TaxIdentificationNumberIdentifier { get => _taxIdentificationNumberIdentifier; set => SetField(ref _taxIdentificationNumberIdentifier, value); }
        private DirtyValue<string> _trustOfficerName1;
        /// <summary>
        /// Vesting Seller Corp/Trust Officer 1 Name [Vesting.SelOfcr1Nm]
        /// </summary>
        [LoanFieldProperty(Description = "Vesting Seller Corp/Trust Officer 1 Name")]
        public string TrustOfficerName1 { get => _trustOfficerName1; set => SetField(ref _trustOfficerName1, value); }
        private DirtyValue<string> _trustOfficerName2;
        /// <summary>
        /// Vesting Seller Corp/Trust Officer 2 Name [Vesting.SelOfcr2Nm]
        /// </summary>
        [LoanFieldProperty(Description = "Vesting Seller Corp/Trust Officer 2 Name")]
        public string TrustOfficerName2 { get => _trustOfficerName2; set => SetField(ref _trustOfficerName2, value); }
        private DirtyValue<string> _trustOfficerTitle1;
        /// <summary>
        /// Vesting Seller Corp/Trust Officer 1 Title [Vesting.SelOfcr1Titl]
        /// </summary>
        [LoanFieldProperty(Description = "Vesting Seller Corp/Trust Officer 1 Title")]
        public string TrustOfficerTitle1 { get => _trustOfficerTitle1; set => SetField(ref _trustOfficerTitle1, value); }
        private DirtyValue<string> _trustOfficerTitle2;
        /// <summary>
        /// Vesting Seller Corp/Trust Officer 2 Title [Vesting.SelOfcr2Titl]
        /// </summary>
        [LoanFieldProperty(Description = "Vesting Seller Corp/Trust Officer 2 Title")]
        public string TrustOfficerTitle2 { get => _trustOfficerTitle2; set => SetField(ref _trustOfficerTitle2, value); }
        private DirtyValue<string> _unparsedName;
        /// <summary>
        /// ClosingEntity UnparsedName [TRNN01]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string UnparsedName { get => _unparsedName; set => SetField(ref _unparsedName, value); }
        private DirtyValue<string> _vesting;
        /// <summary>
        /// Vesting Party - Vesting [TRNN08]
        /// </summary>
        [LoanFieldProperty(Description = "Vesting Party - Vesting")]
        public string Vesting { get => _vesting; set => SetField(ref _vesting, value); }
        private DirtyValue<string> _vestingGuid;
        /// <summary>
        /// Vesting Party - Unique ID [TRNN10]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Vesting Party - Unique ID")]
        public string VestingGuid { get => _vestingGuid; set => SetField(ref _vestingGuid, value); }
        private DirtyValue<StringEnumValue<VestingTrusteeOfType>> _vestingTrusteeOfType;
        /// <summary>
        /// Vesting Party - Trustee Of [TRNN06]
        /// </summary>
        [LoanFieldProperty(Description = "Vesting Party - Trustee Of")]
        public StringEnumValue<VestingTrusteeOfType> VestingTrusteeOfType { get => _vestingTrusteeOfType; set => SetField(ref _vestingTrusteeOfType, value); }
        private DirtyValue<StringEnumValue<BorrowerType>> _vestingType;
        /// <summary>
        /// Vesting Party - Vesting Type [TRNN04]
        /// </summary>
        [LoanFieldProperty(Description = "Vesting Party - Vesting Type")]
        public StringEnumValue<BorrowerType> VestingType { get => _vestingType; set => SetField(ref _vestingType, value); }
    }
}