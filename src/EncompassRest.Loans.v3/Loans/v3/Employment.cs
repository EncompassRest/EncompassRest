using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Employment
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Employment : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _addressCity;
    private DirtyValue<string?>? _addressPostalCode;
    private DirtyValue<string?>? _addressState;
    private DirtyValue<string?>? _addressStreetLine1;
    private DirtyValue<string?>? _altId;
    private DirtyValue<string?>? _attention;
    private DirtyValue<string?>? _badgeOrEmployeeId;
    private DirtyValue<decimal?>? _baseIncome;
    private DirtyValue<decimal?>? _basePayAmount;
    private DirtyValue<decimal?>? _bonus;
    private DirtyValue<decimal?>? _bonusAmount;
    private DirtyValue<string?>? _businessName;
    private DirtyValue<decimal?>? _businessOwnedPercent;
    private DirtyValue<string?>? _businessPhone;
    private DirtyValue<decimal?>? _clothingAllowance;
    private DirtyValue<decimal?>? _commission;
    private DirtyValue<decimal?>? _commissionsAmount;
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
    private DirtyValue<decimal?>? _otherIncome;
    private DirtyValue<decimal?>? _overTime;
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
    private DirtyValue<decimal?>? _total;
    private DirtyValue<string?>? _unitNumber;
    private DirtyValue<StringEnumValue<UnitType>>? _unitType;
    private DirtyValue<string?>? _urla2020StreetAddress;
    private DirtyValue<decimal?>? _variableHousingAllowance;
    private DirtyValue<DateTime?>? _verificationDate;
    private DirtyValue<DateTime?>? _verificationRequestDate;

    /// <summary>
    /// EmploymentContract AddressCity
    /// </summary>
    public string? AddressCity { get => _addressCity; set => SetField(ref _addressCity, value); }

    /// <summary>
    /// EmploymentContract AddressPostalCode
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AddressPostalCode { get => _addressPostalCode; set => SetField(ref _addressPostalCode, value); }

    /// <summary>
    /// EmploymentContract AddressState
    /// </summary>
    public string? AddressState { get => _addressState; set => SetField(ref _addressState, value); }

    /// <summary>
    /// EmploymentContract AddressStreetLine1
    /// </summary>
    public string? AddressStreetLine1 { get => _addressStreetLine1; set => SetField(ref _addressStreetLine1, value); }

    /// <summary>
    /// EmploymentContract AltId
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// EmploymentContract Attention
    /// </summary>
    public string? Attention { get => _attention; set => SetField(ref _attention, value); }

    /// <summary>
    /// EmploymentContract BadgeOrEmployeeId [BE0039], [CE0039]
    /// </summary>
    public string? BadgeOrEmployeeId { get => _badgeOrEmployeeId; set => SetField(ref _badgeOrEmployeeId, value); }

    /// <summary>
    /// EmploymentContract BaseIncome
    /// </summary>
    public decimal? BaseIncome { get => _baseIncome; set => SetField(ref _baseIncome, value); }

    /// <summary>
    /// EmploymentContract BasePayAmount
    /// </summary>
    public decimal? BasePayAmount { get => _basePayAmount; set => SetField(ref _basePayAmount, value); }

    /// <summary>
    /// EmploymentContract Bonus
    /// </summary>
    public decimal? Bonus { get => _bonus; set => SetField(ref _bonus, value); }

    /// <summary>
    /// EmploymentContract BonusAmount
    /// </summary>
    public decimal? BonusAmount { get => _bonusAmount; set => SetField(ref _bonusAmount, value); }

    /// <summary>
    /// EmploymentContract BusinessName [BE0032], [CE0032]
    /// </summary>
    public string? BusinessName { get => _businessName; set => SetField(ref _businessName, value); }

    /// <summary>
    /// EmploymentContract BusinessOwnedPercent [BE0027], [CE0027]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BusinessOwnedPercent { get => _businessOwnedPercent; set => SetField(ref _businessOwnedPercent, value); }

    /// <summary>
    /// EmploymentContract BusinessPhone [BE0028], [CE0028]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? BusinessPhone { get => _businessPhone; set => SetField(ref _businessPhone, value); }

    /// <summary>
    /// EmploymentContract ClothingAllowance
    /// </summary>
    public decimal? ClothingAllowance { get => _clothingAllowance; set => SetField(ref _clothingAllowance, value); }

    /// <summary>
    /// EmploymentContract Commission
    /// </summary>
    public decimal? Commission { get => _commission; set => SetField(ref _commission, value); }

    /// <summary>
    /// EmploymentContract CommissionsAmount
    /// </summary>
    public decimal? CommissionsAmount { get => _commissionsAmount; set => SetField(ref _commissionsAmount, value); }

    /// <summary>
    /// EmploymentContract Country
    /// </summary>
    public string? Country { get => _country; set => SetField(ref _country, value); }

    /// <summary>
    /// EmploymentContract CountryCode
    /// </summary>
    public string? CountryCode { get => _countryCode; set => SetField(ref _countryCode, value); }

    /// <summary>
    /// EmploymentContract CurrentEmploymentIndicator
    /// </summary>
    public bool? CurrentEmploymentIndicator { get => _currentEmploymentIndicator; set => SetField(ref _currentEmploymentIndicator, value); }

    /// <summary>
    /// EmploymentContract DoesNotApply
    /// </summary>
    public bool? DoesNotApply { get => _doesNotApply; set => SetField(ref _doesNotApply, value); }

    /// <summary>
    /// EmploymentContract Email [BE0030], [CE0030]
    /// </summary>
    public string? Email { get => _email; set => SetField(ref _email, value); }

    /// <summary>
    /// EmploymentContract EmployerComments [BE0031], [CE0031]
    /// </summary>
    public string? EmployerComments { get => _employerComments; set => SetField(ref _employerComments, value); }

    /// <summary>
    /// EmploymentContract EmployerName
    /// </summary>
    public string? EmployerName { get => _employerName; set => SetField(ref _employerName, value); }

    /// <summary>
    /// EmploymentContract EmploymentMonthlyIncomeAmount
    /// </summary>
    public decimal? EmploymentMonthlyIncomeAmount { get => _employmentMonthlyIncomeAmount; set => SetField(ref _employmentMonthlyIncomeAmount, value); }

    /// <summary>
    /// EmploymentContract EmploymentStartDate
    /// </summary>
    public DateTime? EmploymentStartDate { get => _employmentStartDate; set => SetField(ref _employmentStartDate, value); }

    /// <summary>
    /// EmploymentContract EndDate
    /// </summary>
    public DateTime? EndDate { get => _endDate; set => SetField(ref _endDate, value); }

    /// <summary>
    /// EmploymentContract Fax [BE0029], [CE0029]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Fax { get => _fax; set => SetField(ref _fax, value); }

    /// <summary>
    /// EmploymentContract ForeignAddressIndicator
    /// </summary>
    public bool? ForeignAddressIndicator { get => _foreignAddressIndicator; set => SetField(ref _foreignAddressIndicator, value); }

    /// <summary>
    /// EmploymentContract ForeignIncome
    /// </summary>
    public bool? ForeignIncome { get => _foreignIncome; set => SetField(ref _foreignIncome, value); }

    /// <summary>
    /// EmploymentContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// EmploymentContract IndividualEmployer
    /// </summary>
    public bool? IndividualEmployer { get => _individualEmployer; set => SetField(ref _individualEmployer, value); }

    /// <summary>
    /// EmploymentContract JobTermMonths
    /// </summary>
    public int? JobTermMonths { get => _jobTermMonths; set => SetField(ref _jobTermMonths, value); }

    /// <summary>
    /// EmploymentContract MilitaryCombatPay
    /// </summary>
    public decimal? MilitaryCombatPay { get => _militaryCombatPay; set => SetField(ref _militaryCombatPay, value); }

    /// <summary>
    /// EmploymentContract MilitaryEmployer
    /// </summary>
    public bool? MilitaryEmployer { get => _militaryEmployer; set => SetField(ref _militaryEmployer, value); }

    /// <summary>
    /// EmploymentContract MilitaryEntitlement
    /// </summary>
    public decimal? MilitaryEntitlement { get => _militaryEntitlement; set => SetField(ref _militaryEntitlement, value); }

    /// <summary>
    /// EmploymentContract MilitaryFlightPay
    /// </summary>
    public decimal? MilitaryFlightPay { get => _militaryFlightPay; set => SetField(ref _militaryFlightPay, value); }

    /// <summary>
    /// EmploymentContract MilitaryHazardPay
    /// </summary>
    public decimal? MilitaryHazardPay { get => _militaryHazardPay; set => SetField(ref _militaryHazardPay, value); }

    /// <summary>
    /// EmploymentContract MilitaryOverseasPay
    /// </summary>
    public decimal? MilitaryOverseasPay { get => _militaryOverseasPay; set => SetField(ref _militaryOverseasPay, value); }

    /// <summary>
    /// EmploymentContract MilitaryPropPay
    /// </summary>
    public decimal? MilitaryPropPay { get => _militaryPropPay; set => SetField(ref _militaryPropPay, value); }

    /// <summary>
    /// EmploymentContract MonthlyIncomeAmount
    /// </summary>
    public int? MonthlyIncomeAmount { get => _monthlyIncomeAmount; set => SetField(ref _monthlyIncomeAmount, value); }

    /// <summary>
    /// EmploymentContract NoLinkToDocTrackIndicator [BE0097], [CE0097]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? NoLinkToDocTrackIndicator { get => _noLinkToDocTrackIndicator; set => SetField(ref _noLinkToDocTrackIndicator, value); }

    /// <summary>
    /// EmploymentContract OtherAllowanceDescription
    /// </summary>
    public string? OtherAllowanceDescription { get => _otherAllowanceDescription; set => SetField(ref _otherAllowanceDescription, value); }

    /// <summary>
    /// EmploymentContract OtherAmount
    /// </summary>
    public decimal? OtherAmount { get => _otherAmount; set => SetField(ref _otherAmount, value); }

    /// <summary>
    /// EmploymentContract OtherIncome
    /// </summary>
    public decimal? OtherIncome { get => _otherIncome; set => SetField(ref _otherIncome, value); }

    /// <summary>
    /// EmploymentContract OverTime
    /// </summary>
    public decimal? OverTime { get => _overTime; set => SetField(ref _overTime, value); }

    /// <summary>
    /// EmploymentContract OvertimeAmount
    /// </summary>
    public decimal? OvertimeAmount { get => _overtimeAmount; set => SetField(ref _overtimeAmount, value); }

    /// <summary>
    /// EmploymentContract Owner [BE0008], [CE0008]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<BorrowerOrCoBorrower> Owner { get => _owner; set => SetField(ref _owner, value); }

    /// <summary>
    /// EmploymentContract OwnershipInterestType
    /// </summary>
    public StringEnumValue<OwnershipInterestType> OwnershipInterestType { get => _ownershipInterestType; set => SetField(ref _ownershipInterestType, value); }

    /// <summary>
    /// EmploymentContract PhoneNumber
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? PhoneNumber { get => _phoneNumber; set => SetField(ref _phoneNumber, value); }

    /// <summary>
    /// EmploymentContract PositionDescription
    /// </summary>
    public string? PositionDescription { get => _positionDescription; set => SetField(ref _positionDescription, value); }

    /// <summary>
    /// EmploymentContract PrintAttachmentIndicator [BE0036], [CE0036]
    /// </summary>
    public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }

    /// <summary>
    /// EmploymentContract PrintUserJobTitleIndicator [BE0064], [CE0064]
    /// </summary>
    public bool? PrintUserJobTitleIndicator { get => _printUserJobTitleIndicator; set => SetField(ref _printUserJobTitleIndicator, value); }

    /// <summary>
    /// EmploymentContract PrintUserNameIndicator [BE0038], [CE0038]
    /// </summary>
    public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

    /// <summary>
    /// EmploymentContract QuartersAllowance
    /// </summary>
    public decimal? QuartersAllowance { get => _quartersAllowance; set => SetField(ref _quartersAllowance, value); }

    /// <summary>
    /// EmploymentContract RationsAllowance
    /// </summary>
    public decimal? RationsAllowance { get => _rationsAllowance; set => SetField(ref _rationsAllowance, value); }

    /// <summary>
    /// EmploymentContract SeasonalIncome
    /// </summary>
    public bool? SeasonalIncome { get => _seasonalIncome; set => SetField(ref _seasonalIncome, value); }

    /// <summary>
    /// EmploymentContract SelfEmployedIndicator
    /// </summary>
    public bool? SelfEmployedIndicator { get => _selfEmployedIndicator; set => SetField(ref _selfEmployedIndicator, value); }

    /// <summary>
    /// EmploymentContract SpecialEmployerRelationshipIndicator
    /// </summary>
    public bool? SpecialEmployerRelationshipIndicator { get => _specialEmployerRelationshipIndicator; set => SetField(ref _specialEmployerRelationshipIndicator, value); }

    /// <summary>
    /// EmploymentContract StartDate
    /// </summary>
    public DateTime? StartDate { get => _startDate; set => SetField(ref _startDate, value); }

    /// <summary>
    /// EmploymentContract TimeInLineOfWorkMonths
    /// </summary>
    public int? TimeInLineOfWorkMonths { get => _timeInLineOfWorkMonths; set => SetField(ref _timeInLineOfWorkMonths, value); }

    /// <summary>
    /// EmploymentContract TimeInLineOfWorkYears
    /// </summary>
    public int? TimeInLineOfWorkYears { get => _timeInLineOfWorkYears; set => SetField(ref _timeInLineOfWorkYears, value); }

    /// <summary>
    /// EmploymentContract TimeOnJobTermMonths
    /// </summary>
    public int? TimeOnJobTermMonths { get => _timeOnJobTermMonths; set => SetField(ref _timeOnJobTermMonths, value); }

    /// <summary>
    /// EmploymentContract TimeOnJobTermYears
    /// </summary>
    public int? TimeOnJobTermYears { get => _timeOnJobTermYears; set => SetField(ref _timeOnJobTermYears, value); }

    /// <summary>
    /// EmploymentContract Title [BE0037], [CE0037]
    /// </summary>
    public string? Title { get => _title; set => SetField(ref _title, value); }

    /// <summary>
    /// EmploymentContract TitleFax [BE0045], [CE0045]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

    /// <summary>
    /// EmploymentContract TitlePhone [BE0044], [CE0044]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }

    /// <summary>
    /// EmploymentContract Total
    /// </summary>
    public decimal? Total { get => _total; set => SetField(ref _total, value); }

    /// <summary>
    /// EmploymentContract UnitNumber
    /// </summary>
    public string? UnitNumber { get => _unitNumber; set => SetField(ref _unitNumber, value); }

    /// <summary>
    /// EmploymentContract UnitType
    /// </summary>
    public StringEnumValue<UnitType> UnitType { get => _unitType; set => SetField(ref _unitType, value); }

    /// <summary>
    /// EmploymentContract Urla2020StreetAddress
    /// </summary>
    public string? Urla2020StreetAddress { get => _urla2020StreetAddress; set => SetField(ref _urla2020StreetAddress, value); }

    /// <summary>
    /// EmploymentContract VariableHousingAllowance
    /// </summary>
    public decimal? VariableHousingAllowance { get => _variableHousingAllowance; set => SetField(ref _variableHousingAllowance, value); }

    /// <summary>
    /// EmploymentContract VerificationDate [BE0078], [CE0078]
    /// </summary>
    public DateTime? VerificationDate { get => _verificationDate; set => SetField(ref _verificationDate, value); }

    /// <summary>
    /// EmploymentContract VerificationRequestDate
    /// </summary>
    public DateTime? VerificationRequestDate { get => _verificationRequestDate; set => SetField(ref _verificationRequestDate, value); }
}