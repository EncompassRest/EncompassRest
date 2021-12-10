using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// ClosingEntity
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(ClosingEntityType), SerializeWholeListWhenDirty = true)]
    public sealed partial class ClosingEntity : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _alias;
        private DirtyValue<string?>? _assignee;
        private DirtyValue<bool?>? _authorizedToSignIndicator;
        private DirtyValue<string?>? _borrowerPair;
        private DirtyValue<string?>? _city;
        private DirtyValue<StringEnumValue<ClosingEntityType>>? _closingEntityType;
        private DirtyValue<string?>? _comments;
        private DirtyValue<string?>? _county;
        private DirtyValue<DateTime?>? _dateOfBirth;
        private DirtyValue<string?>? _fax;
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _nBORecordID;
        private DirtyValue<StringEnumValue<OccupancyIntent>>? _occupancyIntent;
        private DirtyValue<StringEnumValue<PropertyUsageType>>? _occupancyStatus;
        private DirtyValue<string?>? _organizationType;
        private DirtyValue<string?>? _organizedUnderTheLawsOfJurisdictionName;
        private DirtyValue<string?>? _phone;
        private DirtyValue<string?>? _phone1;
        private DirtyValue<string?>? _phone2;
        private DirtyValue<string?>? _poaSignatureText;
        private DirtyValue<string?>? _postalCode;
        private DirtyValue<string?>? _powerOfAttorney;
        private DirtyValue<DateTime?>? _recordableDocumentTrustDate;
        private DirtyValue<string?>? _recordCity;
        private DirtyValue<string?>? _ssn;
        private DirtyValue<StringEnumValue<State>>? _state;
        private DirtyValue<string?>? _streetAddress;
        private DirtyValue<string?>? _taxIdentificationNumberIdentifier;
        private DirtyValue<int?>? _trusteeIndex;
        private DirtyValue<string?>? _trustOfficerName1;
        private DirtyValue<string?>? _trustOfficerName2;
        private DirtyValue<string?>? _trustOfficerTitle1;
        private DirtyValue<string?>? _trustOfficerTitle2;
        private DirtyValue<string?>? _unparsedName;
        private DirtyValue<string?>? _vesting;
        private DirtyValue<string?>? _vestingGuid;
        private DirtyValue<StringEnumValue<VestingTrusteeOfType>>? _vestingTrusteeOfType;
        private DirtyValue<StringEnumValue<BorrowerType>>? _vestingType;

        /// <summary>
        /// Vesting Party - Alias [TRNN02]
        /// </summary>
        public string? Alias { get => _alias; set => SetField(ref _alias, value); }

        /// <summary>
        /// Closing Docs Loss Payee Assignee [1953]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? Assignee { get => _assignee; set => SetField(ref _assignee, value); }

        /// <summary>
        /// Vesting Party - Authorized to Sign [TRNN09]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Authorized to Sign\"}")]
        public bool? AuthorizedToSignIndicator { get => _authorizedToSignIndicator; set => SetField(ref _authorizedToSignIndicator, value); }

        /// <summary>
        /// Vesting Party - Borrower Pair ID [TRNN05]
        /// </summary>
        public string? BorrowerPair { get => _borrowerPair; set => SetField(ref _borrowerPair, value); }

        /// <summary>
        /// ClosingEntity City
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? City { get => _city; set => SetField(ref _city, value); }

        /// <summary>
        /// ClosingEntity ClosingEntityType
        /// </summary>
        public StringEnumValue<ClosingEntityType> ClosingEntityType { get => _closingEntityType; set => SetField(ref _closingEntityType, value); }

        /// <summary>
        /// Closing docs Recordable Doc Comments [2980]
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// Closing Docs Recordable Doc Trustee County [3901]
        /// </summary>
        public string? County { get => _county; set => SetField(ref _county, value); }

        /// <summary>
        /// Vesting Party - POA Date of Birth [TRNN12]
        /// </summary>
        public DateTime? DateOfBirth { get => _dateOfBirth; set => SetField(ref _dateOfBirth, value); }

        /// <summary>
        /// Closing Docs Lender Fax [1922]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true)]
        public string? Fax { get => _fax; set => SetField(ref _fax, value); }

        /// <summary>
        /// ClosingEntity Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Vesting Party - Non-Borrowing Owner Record ID [TRNN99]
        /// </summary>
        public string? NBORecordID { get => _nBORecordID; set => SetField(ref _nBORecordID, value); }

        /// <summary>
        /// Vesting Party - POA Occupancy Intent [TRNN14]
        /// </summary>
        public StringEnumValue<OccupancyIntent> OccupancyIntent { get => _occupancyIntent; set => SetField(ref _occupancyIntent, value); }

        /// <summary>
        /// Vesting Party - POA Occupancy Status [TRNN13]
        /// </summary>
        public StringEnumValue<PropertyUsageType> OccupancyStatus { get => _occupancyStatus; set => SetField(ref _occupancyStatus, value); }

        /// <summary>
        /// ClosingEntity OrganizationType
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? OrganizationType { get => _organizationType; set => SetField(ref _organizationType, value); }

        /// <summary>
        /// ClosingEntity OrganizedUnderTheLawsOfJurisdictionName
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? OrganizedUnderTheLawsOfJurisdictionName { get => _organizedUnderTheLawsOfJurisdictionName; set => SetField(ref _organizedUnderTheLawsOfJurisdictionName, value); }

        /// <summary>
        /// Closing Docs Recordable Doc Trustee Phone Number [3552]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? Phone { get => _phone; set => SetField(ref _phone, value); }

        /// <summary>
        /// Closing Docs Lender Phone 1 [1920]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true)]
        public string? Phone1 { get => _phone1; set => SetField(ref _phone1, value); }

        /// <summary>
        /// Closing Docs Lender Phone 2 [1921]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true)]
        public string? Phone2 { get => _phone2; set => SetField(ref _phone2, value); }

        /// <summary>
        /// Vesting Party - POA Signature Text [TRNN11]
        /// </summary>
        public string? PoaSignatureText { get => _poaSignatureText; set => SetField(ref _poaSignatureText, value); }

        /// <summary>
        /// ClosingEntity PostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, ReadOnly = true)]
        public string? PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }

        /// <summary>
        /// Vesting Party - Power of Attroney [TRNN07]
        /// </summary>
        public string? PowerOfAttorney { get => _powerOfAttorney; set => SetField(ref _powerOfAttorney, value); }

        /// <summary>
        /// Closing docs Recordable Doc Trust Date [2979]
        /// </summary>
        public DateTime? RecordableDocumentTrustDate { get => _recordableDocumentTrustDate; set => SetField(ref _recordableDocumentTrustDate, value); }

        /// <summary>
        /// Closing Docs Lender Record City [1923]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? RecordCity { get => _recordCity; set => SetField(ref _recordCity, value); }

        /// <summary>
        /// Vesting Party - Social Security Number [TRNN03]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.SSN)]
        public string? Ssn { get => _ssn; set => SetField(ref _ssn, value); }

        /// <summary>
        /// ClosingEntity State
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }

        /// <summary>
        /// ClosingEntity StreetAddress
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? StreetAddress { get => _streetAddress; set => SetField(ref _streetAddress, value); }

        /// <summary>
        /// Borrower Vesting Seller Org Tax ID [1866]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? TaxIdentificationNumberIdentifier { get => _taxIdentificationNumberIdentifier; set => SetField(ref _taxIdentificationNumberIdentifier, value); }

        /// <summary>
        /// ClosingEntity TrusteeIndex
        /// </summary>
        public int? TrusteeIndex { get => _trusteeIndex; set => SetField(ref _trusteeIndex, value); }

        /// <summary>
        /// Vesting Seller Corp/Trust Officer 1 Name [Vesting.SelOfcr1Nm]
        /// </summary>
        public string? TrustOfficerName1 { get => _trustOfficerName1; set => SetField(ref _trustOfficerName1, value); }

        /// <summary>
        /// Vesting Seller Corp/Trust Officer 2 Name [Vesting.SelOfcr2Nm]
        /// </summary>
        public string? TrustOfficerName2 { get => _trustOfficerName2; set => SetField(ref _trustOfficerName2, value); }

        /// <summary>
        /// Vesting Seller Corp/Trust Officer 1 Title [Vesting.SelOfcr1Titl]
        /// </summary>
        public string? TrustOfficerTitle1 { get => _trustOfficerTitle1; set => SetField(ref _trustOfficerTitle1, value); }

        /// <summary>
        /// Vesting Seller Corp/Trust Officer 2 Title [Vesting.SelOfcr2Titl]
        /// </summary>
        public string? TrustOfficerTitle2 { get => _trustOfficerTitle2; set => SetField(ref _trustOfficerTitle2, value); }

        /// <summary>
        /// ClosingEntity UnparsedName [TRNN01]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? UnparsedName { get => _unparsedName; set => SetField(ref _unparsedName, value); }

        /// <summary>
        /// Vesting Party - Vesting [TRNN08]
        /// </summary>
        public string? Vesting { get => _vesting; set => SetField(ref _vesting, value); }

        /// <summary>
        /// Vesting Party - Unique ID [TRNN10]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? VestingGuid { get => _vestingGuid; set => SetField(ref _vestingGuid, value); }

        /// <summary>
        /// Vesting Party - Trustee Of [TRNN06]
        /// </summary>
        public StringEnumValue<VestingTrusteeOfType> VestingTrusteeOfType { get => _vestingTrusteeOfType; set => SetField(ref _vestingTrusteeOfType, value); }

        /// <summary>
        /// Vesting Party - Vesting Type [TRNN04]
        /// </summary>
        public StringEnumValue<BorrowerType> VestingType { get => _vestingType; set => SetField(ref _vestingType, value); }
    }
}