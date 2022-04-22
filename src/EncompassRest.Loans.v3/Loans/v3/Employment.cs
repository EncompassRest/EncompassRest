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
    /// <summary>
    /// Employment AddressCity
    /// </summary>
    public string? AddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment AddressPostalCode
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment AddressState
    /// </summary>
    public string? AddressState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment AddressStreetLine1
    /// </summary>
    public string? AddressStreetLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment AltId
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment Attention
    /// </summary>
    public string? Attention { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment BadgeOrEmployeeId [BE0039], [CE0039]
    /// </summary>
    public string? BadgeOrEmployeeId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment BaseIncome
    /// </summary>
    public decimal? BaseIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment BasePayAmount
    /// </summary>
    public decimal? BasePayAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment Bonus
    /// </summary>
    public decimal? Bonus { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment BonusAmount
    /// </summary>
    public decimal? BonusAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment BusinessName [BE0032], [CE0032]
    /// </summary>
    public string? BusinessName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment BusinessOwnedPercent [BE0027], [CE0027]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BusinessOwnedPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment BusinessPhone [BE0028], [CE0028]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? BusinessPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment ClothingAllowance
    /// </summary>
    public decimal? ClothingAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment Commission
    /// </summary>
    public decimal? Commission { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment CommissionsAmount
    /// </summary>
    public decimal? CommissionsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment Country
    /// </summary>
    public string? Country { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment CountryCode
    /// </summary>
    public string? CountryCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment CurrentEmploymentIndicator
    /// </summary>
    public bool? CurrentEmploymentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment DoesNotApply
    /// </summary>
    public bool? DoesNotApply { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment Email [BE0030], [CE0030]
    /// </summary>
    public string? Email { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment EmployerComments [BE0031], [CE0031]
    /// </summary>
    public string? EmployerComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment EmployerName
    /// </summary>
    public string? EmployerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment EmploymentMonthlyIncomeAmount
    /// </summary>
    public decimal? EmploymentMonthlyIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment EmploymentStartDate
    /// </summary>
    public DateTime? EmploymentStartDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Employment EndDate
    /// </summary>
    public DateTime? EndDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Employment Fax [BE0029], [CE0029]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Fax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment ForeignAddressIndicator
    /// </summary>
    public bool? ForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment ForeignIncome
    /// </summary>
    public bool? ForeignIncome { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment IndividualEmployer
    /// </summary>
    public bool? IndividualEmployer { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment JobTermMonths
    /// </summary>
    public int? JobTermMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Employment MilitaryCombatPay
    /// </summary>
    public decimal? MilitaryCombatPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment MilitaryEmployer
    /// </summary>
    public bool? MilitaryEmployer { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment MilitaryEntitlement
    /// </summary>
    public decimal? MilitaryEntitlement { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment MilitaryFlightPay
    /// </summary>
    public decimal? MilitaryFlightPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment MilitaryHazardPay
    /// </summary>
    public decimal? MilitaryHazardPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment MilitaryOverseasPay
    /// </summary>
    public decimal? MilitaryOverseasPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment MilitaryPropPay
    /// </summary>
    public decimal? MilitaryPropPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment MonthlyIncomeAmount
    /// </summary>
    public int? MonthlyIncomeAmount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Employment NoLinkToDocTrackIndicator [BE0097], [CE0097]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? NoLinkToDocTrackIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment OtherAllowanceDescription
    /// </summary>
    public string? OtherAllowanceDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment OtherAmount
    /// </summary>
    public decimal? OtherAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment OtherIncome
    /// </summary>
    public decimal? OtherIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment OverTime
    /// </summary>
    public decimal? OverTime { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment OvertimeAmount
    /// </summary>
    public decimal? OvertimeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment Owner [BE0008], [CE0008]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<BorrowerOrCoBorrower> Owner { get => GetValue<StringEnumValue<BorrowerOrCoBorrower>>(); set => SetValue(value); }

    /// <summary>
    /// Employment OwnershipInterestType
    /// </summary>
    public StringEnumValue<OwnershipInterestType> OwnershipInterestType { get => GetValue<StringEnumValue<OwnershipInterestType>>(); set => SetValue(value); }

    /// <summary>
    /// Employment PhoneNumber
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? PhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment PositionDescription
    /// </summary>
    public string? PositionDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment PrintAttachmentIndicator [BE0036], [CE0036]
    /// </summary>
    public bool? PrintAttachmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment PrintUserJobTitleIndicator [BE0064], [CE0064]
    /// </summary>
    public bool? PrintUserJobTitleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment PrintUserNameIndicator [BE0038], [CE0038]
    /// </summary>
    public bool? PrintUserNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment QuartersAllowance
    /// </summary>
    public decimal? QuartersAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment RationsAllowance
    /// </summary>
    public decimal? RationsAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment SeasonalIncome
    /// </summary>
    public bool? SeasonalIncome { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment SelfEmployedIndicator
    /// </summary>
    public bool? SelfEmployedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment SpecialEmployerRelationshipIndicator
    /// </summary>
    public bool? SpecialEmployerRelationshipIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment StartDate
    /// </summary>
    public DateTime? StartDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Employment TimeInLineOfWorkMonths
    /// </summary>
    public int? TimeInLineOfWorkMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Employment TimeInLineOfWorkYears
    /// </summary>
    public int? TimeInLineOfWorkYears { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Employment TimeOnJobTermMonths
    /// </summary>
    public int? TimeOnJobTermMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Employment TimeOnJobTermYears
    /// </summary>
    public int? TimeOnJobTermYears { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Employment Title [BE0037], [CE0037]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment TitleFax [BE0045], [CE0045]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment TitlePhone [BE0044], [CE0044]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment Total
    /// </summary>
    public decimal? Total { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment UnitNumber
    /// </summary>
    public string? UnitNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment UnitType
    /// </summary>
    public StringEnumValue<UnitType> UnitType { get => GetValue<StringEnumValue<UnitType>>(); set => SetValue(value); }

    /// <summary>
    /// Employment Urla2020StreetAddress
    /// </summary>
    public string? Urla2020StreetAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment VariableHousingAllowance
    /// </summary>
    public decimal? VariableHousingAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment VerificationDate [BE0078], [CE0078]
    /// </summary>
    public DateTime? VerificationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Employment VerificationRequestDate
    /// </summary>
    public DateTime? VerificationRequestDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}