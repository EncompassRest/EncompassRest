using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Employment
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(CurrentEmploymentIndicator) + "," + nameof(Owner), SerializeWholeListWhenDirty = true)]
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
    public StringEnumValue<State> AddressState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Employment AddressStreetLine1
    /// </summary>
    public string? AddressStreetLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment AltId [BENN99], [CENN99]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment Attention [FE0103], [FE0203]
    /// </summary>
    public string? Attention { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment BadgeOrEmployeeID [BENN39], [CENN39]
    /// </summary>
    public string? BadgeOrEmployeeID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment BasePayAmount
    /// </summary>
    public decimal? BasePayAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment BonusAmount [BENN21], [CENN21]
    /// </summary>
    public decimal? BonusAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment BusinessName [BENN32], [CENN32]
    /// </summary>
    public string? BusinessName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment BusinessOwnedPercent [BENN27], [CENN27]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BusinessOwnedPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment BusinessPhone [BENN28], [CENN28]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? BusinessPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment ClothingAllowance [BENN69], [CENN69]
    /// </summary>
    public decimal? ClothingAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment CommissionsAmount [BENN22], [CENN22]
    /// </summary>
    public decimal? CommissionsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment Contact
    /// </summary>
    public EntityReference? Contact { get => GetValue<EntityReference?>(); set => SetValue(value); }

    /// <summary>
    /// Employment Country [BENN79], [CENN79]
    /// </summary>
    public string? Country { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment CountryCode [BENN61], [CENN61]
    /// </summary>
    public string? CountryCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment CurrentEmploymentIndicator
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Current\",\"N\":\"Prior\"}")]
    public bool? CurrentEmploymentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment DoesNotApply
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does Not Apply\"}")]
    public bool? DoesNotApply { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment Email [BENN30], [CENN30]
    /// </summary>
    public string? Email { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment EmployerComments [BENN31], [CENN31]
    /// </summary>
    public string? EmployerComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment EmployerName
    /// </summary>
    public string? EmployerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment EmploymentMonthlyIncomeAmount [BENN56], [CENN56]
    /// </summary>
    public decimal? EmploymentMonthlyIncomeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment EmploymentStartDate [BENN51], [CENN51]
    /// </summary>
    public DateTime? EmploymentStartDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Employment EndDate [FE0514], [FE0614]
    /// </summary>
    public DateTime? EndDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Employment EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment Fax [BENN29], [CENN29]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Fax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment ForeignAddressIndicator [BENN80], [CENN80]
    /// </summary>
    public bool? ForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment ForeignIncome [BENN75], [CENN75]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Foreign Income\"}")]
    public bool? ForeignIncome { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment IndividualEmployer [BENN62], [CENN62]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Employer is an Individual\"}")]
    public bool? IndividualEmployer { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment JobTermMonths [BENN52], [CENN52]
    /// </summary>
    public int? JobTermMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Employment MilitaryCombatPay [BENN77], [CENN77]
    /// </summary>
    public decimal? MilitaryCombatPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment MilitaryEmployer [BENN63], [CENN63]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Employer is Military\"}")]
    public bool? MilitaryEmployer { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment MilitaryEntitlement [BENN53], [CENN53]
    /// </summary>
    public decimal? MilitaryEntitlement { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment MilitaryFlightPay [BENN65], [CENN65]
    /// </summary>
    public decimal? MilitaryFlightPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment MilitaryHazardPay [BENN66], [CENN66]
    /// </summary>
    public decimal? MilitaryHazardPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment MilitaryOverseasPay [BENN67], [CENN67]
    /// </summary>
    public decimal? MilitaryOverseasPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment MilitaryPropPay [BENN68], [CENN68]
    /// </summary>
    public decimal? MilitaryPropPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment MonthlyIncomeAmount
    /// </summary>
    public int? MonthlyIncomeAmount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Employment NoLinkToDocTrackIndicator [BENN97], [CENN97]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? NoLinkToDocTrackIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment OtherAllowanceDescription [BENN74], [CENN74]
    /// </summary>
    public string? OtherAllowanceDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment OtherAmount [BENN23], [CENN23]
    /// </summary>
    public decimal? OtherAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment OvertimeAmount [BENN20], [CENN20]
    /// </summary>
    public decimal? OvertimeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment Owner [BENN08], [CENN08]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<BorrowerOrCoBorrower> Owner { get => GetValue<StringEnumValue<BorrowerOrCoBorrower>>(); set => SetValue(value); }

    /// <summary>
    /// Employment OwnershipInterestType [BENN55], [CENN55]
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
    /// Employment PrintAttachmentIndicator [BENN36], [CENN36]
    /// </summary>
    public bool? PrintAttachmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment PrintUserJobTitleIndicator [BENN64], [CENN64]
    /// </summary>
    public bool? PrintUserJobTitleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment PrintUserNameIndicator [BENN38], [CENN38]
    /// </summary>
    public bool? PrintUserNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment QuartersAllowance [BENN72], [CENN72]
    /// </summary>
    public decimal? QuartersAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment RationsAllowance [BENN70], [CENN70]
    /// </summary>
    public decimal? RationsAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment SeasonalIncome [BENN76], [CENN76]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Seasonal Income\"}")]
    public bool? SeasonalIncome { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment SelfEmployedIndicator
    /// </summary>
    public bool? SelfEmployedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Employment SpecialEmployerRelationshipIndicator [BENN54], [CENN54]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"I am employed by a family member, property seller, real estate agent, or other party to the transaction\"}")]
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
    /// Employment TimeInLineOfWorkYears [BENN16], [CENN16]
    /// </summary>
    public int? TimeInLineOfWorkYears { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Employment TimeOnJobTermMonths [FE0133], [FE0233]
    /// </summary>
    public int? TimeOnJobTermMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Employment TimeOnJobTermYears [FE0113], [FE0213]
    /// </summary>
    public int? TimeOnJobTermYears { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Employment Title [BENN37], [CENN37]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment TitleFax [BENN45], [CENN45]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment TitlePhone [BENN44], [CENN44]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment UnitNumber [BENN59], [CENN59]
    /// </summary>
    public string? UnitNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment UnitType [BENN58], [CENN58]
    /// </summary>
    public StringEnumValue<UnitType> UnitType { get => GetValue<StringEnumValue<UnitType>>(); set => SetValue(value); }

    /// <summary>
    /// Employment URLA2020StreetAddress [BENN60], [CENN60]
    /// </summary>
    public string? URLA2020StreetAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Employment VariableHousingAllowance [BENN71], [CENN71]
    /// </summary>
    public decimal? VariableHousingAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Employment VerificationDate [BENN78], [CENN78]
    /// </summary>
    public DateTime? VerificationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Employment VerificationRequestDate
    /// </summary>
    public DateTime? VerificationRequestDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}