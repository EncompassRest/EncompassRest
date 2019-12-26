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
        private DirtyValue<EntityReference>? _contact;
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
        /// Employment AltId
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? AltId { get => _altId; set => SetField(ref _altId, value); }

        /// <summary>
        /// Employment Attention
        /// </summary>
        public string? Attention { get => _attention; set => SetField(ref _attention, value); }

        /// <summary>
        /// Employment BadgeOrEmployeeID
        /// </summary>
        public string? BadgeOrEmployeeID { get => _badgeOrEmployeeID; set => SetField(ref _badgeOrEmployeeID, value); }

        /// <summary>
        /// Employment BasePayAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BasePayAmount { get => _basePayAmount; set => SetField(ref _basePayAmount, value); }

        /// <summary>
        /// Employment BonusAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BonusAmount { get => _bonusAmount; set => SetField(ref _bonusAmount, value); }

        /// <summary>
        /// Employment BusinessName
        /// </summary>
        public string? BusinessName { get => _businessName; set => SetField(ref _businessName, value); }

        /// <summary>
        /// Employment BusinessOwnedPercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BusinessOwnedPercent { get => _businessOwnedPercent; set => SetField(ref _businessOwnedPercent, value); }

        /// <summary>
        /// Employment BusinessPhone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? BusinessPhone { get => _businessPhone; set => SetField(ref _businessPhone, value); }

        /// <summary>
        /// Employment ClothingAllowance
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ClothingAllowance { get => _clothingAllowance; set => SetField(ref _clothingAllowance, value); }

        /// <summary>
        /// Employment CommissionsAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CommissionsAmount { get => _commissionsAmount; set => SetField(ref _commissionsAmount, value); }

        /// <summary>
        /// Employment Contact (Nullable)
        /// </summary>
        public EntityReference Contact { get => _contact; set => SetField(ref _contact, value); }

        /// <summary>
        /// Employment CountryCode
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
        /// Employment Email
        /// </summary>
        public string? Email { get => _email; set => SetField(ref _email, value); }

        /// <summary>
        /// Employment EmployerComments
        /// </summary>
        public string? EmployerComments { get => _employerComments; set => SetField(ref _employerComments, value); }

        /// <summary>
        /// Employment EmployerName
        /// </summary>
        public string? EmployerName { get => _employerName; set => SetField(ref _employerName, value); }

        /// <summary>
        /// Employment EmploymentMonthlyIncomeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? EmploymentMonthlyIncomeAmount { get => _employmentMonthlyIncomeAmount; set => SetField(ref _employmentMonthlyIncomeAmount, value); }

        /// <summary>
        /// Employment EmploymentStartDate
        /// </summary>
        public DateTime? EmploymentStartDate { get => _employmentStartDate; set => SetField(ref _employmentStartDate, value); }

        /// <summary>
        /// Employment EndDate
        /// </summary>
        public DateTime? EndDate { get => _endDate; set => SetField(ref _endDate, value); }

        /// <summary>
        /// Employment EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// Employment Fax
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? Fax { get => _fax; set => SetField(ref _fax, value); }

        /// <summary>
        /// Employment ForeignIncome
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Foreign Income\"}")]
        public bool? ForeignIncome { get => _foreignIncome; set => SetField(ref _foreignIncome, value); }

        /// <summary>
        /// Employment Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Employment IndividualEmployer
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Employer is an Individual\"}")]
        public bool? IndividualEmployer { get => _individualEmployer; set => SetField(ref _individualEmployer, value); }

        /// <summary>
        /// Employment JobTermMonths
        /// </summary>
        public int? JobTermMonths { get => _jobTermMonths; set => SetField(ref _jobTermMonths, value); }

        /// <summary>
        /// Employment MilitaryCombatPay
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MilitaryCombatPay { get => _militaryCombatPay; set => SetField(ref _militaryCombatPay, value); }

        /// <summary>
        /// Employment MilitaryEmployer
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Employer is Military\"}")]
        public bool? MilitaryEmployer { get => _militaryEmployer; set => SetField(ref _militaryEmployer, value); }

        /// <summary>
        /// Employment MilitaryEntitlement
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MilitaryEntitlement { get => _militaryEntitlement; set => SetField(ref _militaryEntitlement, value); }

        /// <summary>
        /// Employment MilitaryFlightPay
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MilitaryFlightPay { get => _militaryFlightPay; set => SetField(ref _militaryFlightPay, value); }

        /// <summary>
        /// Employment MilitaryHazardPay
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MilitaryHazardPay { get => _militaryHazardPay; set => SetField(ref _militaryHazardPay, value); }

        /// <summary>
        /// Employment MilitaryOverseasPay
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MilitaryOverseasPay { get => _militaryOverseasPay; set => SetField(ref _militaryOverseasPay, value); }

        /// <summary>
        /// Employment MilitaryPropPay
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MilitaryPropPay { get => _militaryPropPay; set => SetField(ref _militaryPropPay, value); }

        /// <summary>
        /// Employment MonthlyIncomeAmount
        /// </summary>
        public int? MonthlyIncomeAmount { get => _monthlyIncomeAmount; set => SetField(ref _monthlyIncomeAmount, value); }

        /// <summary>
        /// Employment NoLinkToDocTrackIndicator
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => SetField(ref _noLinkToDocTrackIndicator, value); }

        /// <summary>
        /// Employment OtherAllowanceDescription
        /// </summary>
        public string? OtherAllowanceDescription { get => _otherAllowanceDescription; set => SetField(ref _otherAllowanceDescription, value); }

        /// <summary>
        /// Employment OtherAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OtherAmount { get => _otherAmount; set => SetField(ref _otherAmount, value); }

        /// <summary>
        /// Employment OvertimeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OvertimeAmount { get => _overtimeAmount; set => SetField(ref _overtimeAmount, value); }

        /// <summary>
        /// Employment Owner
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<BorrowerOrCoBorrower> Owner { get => _owner; set => SetField(ref _owner, value); }

        /// <summary>
        /// Employment OwnershipInterestType
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
        /// Employment PrintAttachmentIndicator
        /// </summary>
        public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }

        /// <summary>
        /// Employment PrintUserJobTitleIndicator
        /// </summary>
        public bool? PrintUserJobTitleIndicator { get => _printUserJobTitleIndicator; set => SetField(ref _printUserJobTitleIndicator, value); }

        /// <summary>
        /// Employment PrintUserNameIndicator
        /// </summary>
        public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

        /// <summary>
        /// Employment QuartersAllowance
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? QuartersAllowance { get => _quartersAllowance; set => SetField(ref _quartersAllowance, value); }

        /// <summary>
        /// Employment RationsAllowance
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? RationsAllowance { get => _rationsAllowance; set => SetField(ref _rationsAllowance, value); }

        /// <summary>
        /// Employment SeasonalIncome
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Seasonal Income\"}")]
        public bool? SeasonalIncome { get => _seasonalIncome; set => SetField(ref _seasonalIncome, value); }

        /// <summary>
        /// Employment SelfEmployedIndicator
        /// </summary>
        public bool? SelfEmployedIndicator { get => _selfEmployedIndicator; set => SetField(ref _selfEmployedIndicator, value); }

        /// <summary>
        /// Employment SpecialEmployerRelationshipIndicator
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
        /// Employment TimeInLineOfWorkYears
        /// </summary>
        public int? TimeInLineOfWorkYears { get => _timeInLineOfWorkYears; set => SetField(ref _timeInLineOfWorkYears, value); }

        /// <summary>
        /// Employment TimeOnJobTermMonths
        /// </summary>
        public int? TimeOnJobTermMonths { get => _timeOnJobTermMonths; set => SetField(ref _timeOnJobTermMonths, value); }

        /// <summary>
        /// Employment TimeOnJobTermYears
        /// </summary>
        public int? TimeOnJobTermYears { get => _timeOnJobTermYears; set => SetField(ref _timeOnJobTermYears, value); }

        /// <summary>
        /// Employment Title
        /// </summary>
        public string? Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// Employment TitleFax
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

        /// <summary>
        /// Employment TitlePhone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }

        /// <summary>
        /// Employment UnitNumber
        /// </summary>
        public string? UnitNumber { get => _unitNumber; set => SetField(ref _unitNumber, value); }

        /// <summary>
        /// Employment UnitType
        /// </summary>
        public StringEnumValue<UnitType> UnitType { get => _unitType; set => SetField(ref _unitType, value); }

        /// <summary>
        /// Employment URLA2020StreetAddress
        /// </summary>
        public string? URLA2020StreetAddress { get => _uRLA2020StreetAddress; set => SetField(ref _uRLA2020StreetAddress, value); }

        /// <summary>
        /// Employment VariableHousingAllowance
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? VariableHousingAllowance { get => _variableHousingAllowance; set => SetField(ref _variableHousingAllowance, value); }

        /// <summary>
        /// Employment VerificationRequestDate
        /// </summary>
        public DateTime? VerificationRequestDate { get => _verificationRequestDate; set => SetField(ref _verificationRequestDate, value); }
    }
}