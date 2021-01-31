using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Employment
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(CurrentEmploymentIndicator) + "," + nameof(Owner), SerializeWholeListWhenDirty = true)]
    public sealed partial class Employment : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _addressCity;
        private DirtyValue<string?>? _addressPostalCode;
        private DirtyValue<StringEnumValue<State>>? _addressState;
        private DirtyValue<string?>? _addressStreetLine1;
        private DirtyValue<string?>? _altId;
        private DirtyValue<string?>? _attention;
        private DirtyValue<string?>? _badgeOrEmployeeID;
        private DirtyValue<decimal?>? _basePayAmount;
        private DirtyValue<decimal?>? _bonusAmount;
        private DirtyValue<string?>? _businessName;
        private DirtyValue<decimal?>? _businessOwnedPercent;
        private DirtyValue<string?>? _businessPhone;
        private DirtyValue<decimal?>? _clothingAllowance;
        private DirtyValue<decimal?>? _commissionsAmount;
        private DirtyValue<EntityReference?>? _contact;
        private DirtyValue<string?>? _country;
        private DirtyValue<string?>? _countryCode;
        private DirtyValue<bool?>? _currentEmploymentIndicator;
        private DirtyValue<bool?>? _doesNotApply;
        private DirtyValue<string?>? _email;
        private DirtyValue<string?>? _employerComments;
        private DirtyValue<string?>? _employerName;
        private DirtyValue<decimal?>? _employmentMonthlyIncomeAmount;
        private DirtyValue<DateTime?>? _employmentStartDate;
        private DirtyValue<DateTime?>? _endDate;
        private DirtyValue<bool?>? _entityDeleted;
        private DirtyValue<string?>? _fax;
        private DirtyValue<bool?>? _foreignAddressIndicator;
        private DirtyValue<bool?>? _foreignIncome;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _individualEmployer;
        private DirtyValue<int?>? _jobTermMonths;
        private DirtyValue<decimal?>? _militaryCombatPay;
        private DirtyValue<bool?>? _militaryEmployer;
        private DirtyValue<decimal?>? _militaryEntitlement;
        private DirtyValue<decimal?>? _militaryFlightPay;
        private DirtyValue<decimal?>? _militaryHazardPay;
        private DirtyValue<decimal?>? _militaryOverseasPay;
        private DirtyValue<decimal?>? _militaryPropPay;
        private DirtyValue<int?>? _monthlyIncomeAmount;
        private DirtyValue<bool?>? _noLinkToDocTrackIndicator;
        private DirtyValue<string?>? _otherAllowanceDescription;
        private DirtyValue<decimal?>? _otherAmount;
        private DirtyValue<decimal?>? _overtimeAmount;
        private DirtyValue<StringEnumValue<BorrowerOrCoBorrower>>? _owner;
        private DirtyValue<StringEnumValue<OwnershipInterestType>>? _ownershipInterestType;
        private DirtyValue<string?>? _phoneNumber;
        private DirtyValue<string?>? _positionDescription;
        private DirtyValue<bool?>? _printAttachmentIndicator;
        private DirtyValue<bool?>? _printUserJobTitleIndicator;
        private DirtyValue<bool?>? _printUserNameIndicator;
        private DirtyValue<decimal?>? _quartersAllowance;
        private DirtyValue<decimal?>? _rationsAllowance;
        private DirtyValue<bool?>? _seasonalIncome;
        private DirtyValue<bool?>? _selfEmployedIndicator;
        private DirtyValue<bool?>? _specialEmployerRelationshipIndicator;
        private DirtyValue<DateTime?>? _startDate;
        private DirtyValue<int?>? _timeInLineOfWorkMonths;
        private DirtyValue<int?>? _timeInLineOfWorkYears;
        private DirtyValue<int?>? _timeOnJobTermMonths;
        private DirtyValue<int?>? _timeOnJobTermYears;
        private DirtyValue<string?>? _title;
        private DirtyValue<string?>? _titleFax;
        private DirtyValue<string?>? _titlePhone;
        private DirtyValue<string?>? _unitNumber;
        private DirtyValue<StringEnumValue<UnitType>>? _unitType;
        private DirtyValue<string?>? _uRLA2020StreetAddress;
        private DirtyValue<decimal?>? _variableHousingAllowance;
        private DirtyValue<DateTime?>? _verificationDate;
        private DirtyValue<DateTime?>? _verificationRequestDate;

        /// <summary>
        /// Employment AddressCity
        /// </summary>
        public string? AddressCity { get => _addressCity; set => SetField(ref _addressCity, value); }

        /// <summary>
        /// Employment AddressPostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? AddressPostalCode { get => _addressPostalCode; set => SetField(ref _addressPostalCode, value); }

        /// <summary>
        /// Employment AddressState
        /// </summary>
        public StringEnumValue<State> AddressState { get => _addressState; set => SetField(ref _addressState, value); }

        /// <summary>
        /// Employment AddressStreetLine1
        /// </summary>
        public string? AddressStreetLine1 { get => _addressStreetLine1; set => SetField(ref _addressStreetLine1, value); }

        /// <summary>
        /// Employment AltId [BENN99], [CENN99]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? AltId { get => _altId; set => SetField(ref _altId, value); }

        /// <summary>
        /// Employment Attention [FE0103], [FE0203]
        /// </summary>
        public string? Attention { get => _attention; set => SetField(ref _attention, value); }

        /// <summary>
        /// Employment BadgeOrEmployeeID [BENN39], [CENN39]
        /// </summary>
        public string? BadgeOrEmployeeID { get => _badgeOrEmployeeID; set => SetField(ref _badgeOrEmployeeID, value); }

        /// <summary>
        /// Employment BasePayAmount
        /// </summary>
        public decimal? BasePayAmount { get => _basePayAmount; set => SetField(ref _basePayAmount, value); }

        /// <summary>
        /// Employment BonusAmount [BENN21], [CENN21]
        /// </summary>
        public decimal? BonusAmount { get => _bonusAmount; set => SetField(ref _bonusAmount, value); }

        /// <summary>
        /// Employment BusinessName [BENN32], [CENN32]
        /// </summary>
        public string? BusinessName { get => _businessName; set => SetField(ref _businessName, value); }

        /// <summary>
        /// Employment BusinessOwnedPercent [BENN27], [CENN27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BusinessOwnedPercent { get => _businessOwnedPercent; set => SetField(ref _businessOwnedPercent, value); }

        /// <summary>
        /// Employment BusinessPhone [BENN28], [CENN28]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? BusinessPhone { get => _businessPhone; set => SetField(ref _businessPhone, value); }

        /// <summary>
        /// Employment ClothingAllowance [BENN69], [CENN69]
        /// </summary>
        public decimal? ClothingAllowance { get => _clothingAllowance; set => SetField(ref _clothingAllowance, value); }

        /// <summary>
        /// Employment CommissionsAmount [BENN22], [CENN22]
        /// </summary>
        public decimal? CommissionsAmount { get => _commissionsAmount; set => SetField(ref _commissionsAmount, value); }

        /// <summary>
        /// Employment Contact
        /// </summary>
        public EntityReference? Contact { get => _contact; set => SetField(ref _contact, value); }

        /// <summary>
        /// Employment Country [BENN79], [CENN79]
        /// </summary>
        public string? Country { get => _country; set => SetField(ref _country, value); }

        /// <summary>
        /// Employment CountryCode [BENN61], [CENN61]
        /// </summary>
        public string? CountryCode { get => _countryCode; set => SetField(ref _countryCode, value); }

        /// <summary>
        /// Employment CurrentEmploymentIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Current\",\"N\":\"Prior\"}")]
        public bool? CurrentEmploymentIndicator { get => _currentEmploymentIndicator; set => SetField(ref _currentEmploymentIndicator, value); }

        /// <summary>
        /// Employment DoesNotApply
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does Not Apply\"}")]
        public bool? DoesNotApply { get => _doesNotApply; set => SetField(ref _doesNotApply, value); }

        /// <summary>
        /// Employment Email [BENN30], [CENN30]
        /// </summary>
        public string? Email { get => _email; set => SetField(ref _email, value); }

        /// <summary>
        /// Employment EmployerComments [BENN31], [CENN31]
        /// </summary>
        public string? EmployerComments { get => _employerComments; set => SetField(ref _employerComments, value); }

        /// <summary>
        /// Employment EmployerName
        /// </summary>
        public string? EmployerName { get => _employerName; set => SetField(ref _employerName, value); }

        /// <summary>
        /// Employment EmploymentMonthlyIncomeAmount [BENN56], [CENN56]
        /// </summary>
        public decimal? EmploymentMonthlyIncomeAmount { get => _employmentMonthlyIncomeAmount; set => SetField(ref _employmentMonthlyIncomeAmount, value); }

        /// <summary>
        /// Employment EmploymentStartDate [BENN51], [CENN51]
        /// </summary>
        public DateTime? EmploymentStartDate { get => _employmentStartDate; set => SetField(ref _employmentStartDate, value); }

        /// <summary>
        /// Employment EndDate [FE0514], [FE0614]
        /// </summary>
        public DateTime? EndDate { get => _endDate; set => SetField(ref _endDate, value); }

        /// <summary>
        /// Employment EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// Employment Fax [BENN29], [CENN29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? Fax { get => _fax; set => SetField(ref _fax, value); }

        /// <summary>
        /// Employment ForeignAddressIndicator [BENN80], [CENN80]
        /// </summary>
        public bool? ForeignAddressIndicator { get => _foreignAddressIndicator; set => SetField(ref _foreignAddressIndicator, value); }

        /// <summary>
        /// Employment ForeignIncome [BENN75], [CENN75]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Foreign Income\"}")]
        public bool? ForeignIncome { get => _foreignIncome; set => SetField(ref _foreignIncome, value); }

        /// <summary>
        /// Employment Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Employment IndividualEmployer [BENN62], [CENN62]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Employer is an Individual\"}")]
        public bool? IndividualEmployer { get => _individualEmployer; set => SetField(ref _individualEmployer, value); }

        /// <summary>
        /// Employment JobTermMonths [BENN52], [CENN52]
        /// </summary>
        public int? JobTermMonths { get => _jobTermMonths; set => SetField(ref _jobTermMonths, value); }

        /// <summary>
        /// Employment MilitaryCombatPay [BENN77], [CENN77]
        /// </summary>
        public decimal? MilitaryCombatPay { get => _militaryCombatPay; set => SetField(ref _militaryCombatPay, value); }

        /// <summary>
        /// Employment MilitaryEmployer [BENN63], [CENN63]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Employer is Military\"}")]
        public bool? MilitaryEmployer { get => _militaryEmployer; set => SetField(ref _militaryEmployer, value); }

        /// <summary>
        /// Employment MilitaryEntitlement [BENN53], [CENN53]
        /// </summary>
        public decimal? MilitaryEntitlement { get => _militaryEntitlement; set => SetField(ref _militaryEntitlement, value); }

        /// <summary>
        /// Employment MilitaryFlightPay [BENN65], [CENN65]
        /// </summary>
        public decimal? MilitaryFlightPay { get => _militaryFlightPay; set => SetField(ref _militaryFlightPay, value); }

        /// <summary>
        /// Employment MilitaryHazardPay [BENN66], [CENN66]
        /// </summary>
        public decimal? MilitaryHazardPay { get => _militaryHazardPay; set => SetField(ref _militaryHazardPay, value); }

        /// <summary>
        /// Employment MilitaryOverseasPay [BENN67], [CENN67]
        /// </summary>
        public decimal? MilitaryOverseasPay { get => _militaryOverseasPay; set => SetField(ref _militaryOverseasPay, value); }

        /// <summary>
        /// Employment MilitaryPropPay [BENN68], [CENN68]
        /// </summary>
        public decimal? MilitaryPropPay { get => _militaryPropPay; set => SetField(ref _militaryPropPay, value); }

        /// <summary>
        /// Employment MonthlyIncomeAmount
        /// </summary>
        public int? MonthlyIncomeAmount { get => _monthlyIncomeAmount; set => SetField(ref _monthlyIncomeAmount, value); }

        /// <summary>
        /// Employment NoLinkToDocTrackIndicator [BENN97], [CENN97]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => SetField(ref _noLinkToDocTrackIndicator, value); }

        /// <summary>
        /// Employment OtherAllowanceDescription [BENN74], [CENN74]
        /// </summary>
        public string? OtherAllowanceDescription { get => _otherAllowanceDescription; set => SetField(ref _otherAllowanceDescription, value); }

        /// <summary>
        /// Employment OtherAmount [BENN23], [CENN23]
        /// </summary>
        public decimal? OtherAmount { get => _otherAmount; set => SetField(ref _otherAmount, value); }

        /// <summary>
        /// Employment OvertimeAmount [BENN20], [CENN20]
        /// </summary>
        public decimal? OvertimeAmount { get => _overtimeAmount; set => SetField(ref _overtimeAmount, value); }

        /// <summary>
        /// Employment Owner [BENN08], [CENN08]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<BorrowerOrCoBorrower> Owner { get => _owner; set => SetField(ref _owner, value); }

        /// <summary>
        /// Employment OwnershipInterestType [BENN55], [CENN55]
        /// </summary>
        public StringEnumValue<OwnershipInterestType> OwnershipInterestType { get => _ownershipInterestType; set => SetField(ref _ownershipInterestType, value); }

        /// <summary>
        /// Employment PhoneNumber
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? PhoneNumber { get => _phoneNumber; set => SetField(ref _phoneNumber, value); }

        /// <summary>
        /// Employment PositionDescription
        /// </summary>
        public string? PositionDescription { get => _positionDescription; set => SetField(ref _positionDescription, value); }

        /// <summary>
        /// Employment PrintAttachmentIndicator [BENN36], [CENN36]
        /// </summary>
        public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }

        /// <summary>
        /// Employment PrintUserJobTitleIndicator [BENN64], [CENN64]
        /// </summary>
        public bool? PrintUserJobTitleIndicator { get => _printUserJobTitleIndicator; set => SetField(ref _printUserJobTitleIndicator, value); }

        /// <summary>
        /// Employment PrintUserNameIndicator [BENN38], [CENN38]
        /// </summary>
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

        /// <summary>
        /// Employment QuartersAllowance [BENN72], [CENN72]
        /// </summary>
        public decimal? QuartersAllowance { get => _quartersAllowance; set => SetField(ref _quartersAllowance, value); }

        /// <summary>
        /// Employment RationsAllowance [BENN70], [CENN70]
        /// </summary>
        public decimal? RationsAllowance { get => _rationsAllowance; set => SetField(ref _rationsAllowance, value); }

        /// <summary>
        /// Employment SeasonalIncome [BENN76], [CENN76]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Seasonal Income\"}")]
        public bool? SeasonalIncome { get => _seasonalIncome; set => SetField(ref _seasonalIncome, value); }

        /// <summary>
        /// Employment SelfEmployedIndicator
        /// </summary>
        public bool? SelfEmployedIndicator { get => _selfEmployedIndicator; set => SetField(ref _selfEmployedIndicator, value); }

        /// <summary>
        /// Employment SpecialEmployerRelationshipIndicator [BENN54], [CENN54]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"I am employed by a family member, property seller, real estate agent, or other party to the transaction\"}")]
        public bool? SpecialEmployerRelationshipIndicator { get => _specialEmployerRelationshipIndicator; set => SetField(ref _specialEmployerRelationshipIndicator, value); }

        /// <summary>
        /// Employment StartDate
        /// </summary>
        public DateTime? StartDate { get => _startDate; set => SetField(ref _startDate, value); }

        /// <summary>
        /// Employment TimeInLineOfWorkMonths
        /// </summary>
        public int? TimeInLineOfWorkMonths { get => _timeInLineOfWorkMonths; set => SetField(ref _timeInLineOfWorkMonths, value); }

        /// <summary>
        /// Employment TimeInLineOfWorkYears [BENN16], [CENN16]
        /// </summary>
        public int? TimeInLineOfWorkYears { get => _timeInLineOfWorkYears; set => SetField(ref _timeInLineOfWorkYears, value); }

        /// <summary>
        /// Employment TimeOnJobTermMonths [FE0133], [FE0233]
        /// </summary>
        public int? TimeOnJobTermMonths { get => _timeOnJobTermMonths; set => SetField(ref _timeOnJobTermMonths, value); }

        /// <summary>
        /// Employment TimeOnJobTermYears [FE0113], [FE0213]
        /// </summary>
        public int? TimeOnJobTermYears { get => _timeOnJobTermYears; set => SetField(ref _timeOnJobTermYears, value); }

        /// <summary>
        /// Employment Title [BENN37], [CENN37]
        /// </summary>
        public string? Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// Employment TitleFax [BENN45], [CENN45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

        /// <summary>
        /// Employment TitlePhone [BENN44], [CENN44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }

        /// <summary>
        /// Employment UnitNumber [BENN59], [CENN59]
        /// </summary>
        public string? UnitNumber { get => _unitNumber; set => SetField(ref _unitNumber, value); }

        /// <summary>
        /// Employment UnitType [BENN58], [CENN58]
        /// </summary>
        public StringEnumValue<UnitType> UnitType { get => _unitType; set => SetField(ref _unitType, value); }

        /// <summary>
        /// Employment URLA2020StreetAddress [BENN60], [CENN60]
        /// </summary>
        public string? URLA2020StreetAddress { get => _uRLA2020StreetAddress; set => SetField(ref _uRLA2020StreetAddress, value); }

        /// <summary>
        /// Employment VariableHousingAllowance [BENN71], [CENN71]
        /// </summary>
        public decimal? VariableHousingAllowance { get => _variableHousingAllowance; set => SetField(ref _variableHousingAllowance, value); }

        /// <summary>
        /// Employment VerificationDate [BENN78], [CENN78]
        /// </summary>
        public DateTime? VerificationDate { get => _verificationDate; set => SetField(ref _verificationDate, value); }

        /// <summary>
        /// Employment VerificationRequestDate
        /// </summary>
        public DateTime? VerificationRequestDate { get => _verificationRequestDate; set => SetField(ref _verificationRequestDate, value); }
    }
}