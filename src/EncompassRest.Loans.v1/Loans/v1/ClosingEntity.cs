using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ClosingEntity
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(ClosingEntityType), SerializeWholeListWhenDirty = true)]
public sealed partial class ClosingEntity : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Vesting Party - Alias [TRNN02]
    /// </summary>
    public string? Alias { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Loss Payee Assignee [1953]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Assignee { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Authorized to Sign [TRNN09]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Authorized to Sign\"}")]
    public bool? AuthorizedToSignIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Borrower Pair ID [TRNN05]
    /// </summary>
    public string? BorrowerPair { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingEntity City
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingEntity ClosingEntityType
    /// </summary>
    public StringEnumValue<ClosingEntityType> ClosingEntityType { get => GetValue<StringEnumValue<ClosingEntityType>>(); set => SetValue(value); }

    /// <summary>
    /// Closing docs Recordable Doc Comments [2980]
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Recordable Doc Trustee County [3901]
    /// </summary>
    public string? County { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - POA Date of Birth [TRNN12]
    /// </summary>
    public DateTime? DateOfBirth { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Lender Fax [1922]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true)]
    public string? Fax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingEntity Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Non-Borrowing Owner Record ID [TRNN99]
    /// </summary>
    public string? NBORecordID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - POA Occupancy Intent [TRNN14]
    /// </summary>
    public StringEnumValue<OccupancyIntent> OccupancyIntent { get => GetValue<StringEnumValue<OccupancyIntent>>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - POA Occupancy Status [TRNN13]
    /// </summary>
    public StringEnumValue<PropertyUsageType> OccupancyStatus { get => GetValue<StringEnumValue<PropertyUsageType>>(); set => SetValue(value); }

    /// <summary>
    /// ClosingEntity OrganizationType
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? OrganizationType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingEntity OrganizedUnderTheLawsOfJurisdictionName
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? OrganizedUnderTheLawsOfJurisdictionName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Recordable Doc Trustee Phone Number [3552]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Phone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Lender Phone 1 [1920]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true)]
    public string? Phone1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Lender Phone 2 [1921]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true)]
    public string? Phone2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - POA Signature Text [TRNN11]
    /// </summary>
    public string? PoaSignatureText { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingEntity PostalCode
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, ReadOnly = true)]
    public string? PostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Power of Attroney [TRNN07]
    /// </summary>
    public string? PowerOfAttorney { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing docs Recordable Doc Trust Date [2979]
    /// </summary>
    public DateTime? RecordableDocumentTrustDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Lender Record City [1923]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RecordCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Social Security Number [TRNN03]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.SSN)]
    public string? Ssn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingEntity State
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<State> State { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// ClosingEntity StreetAddress
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? StreetAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vesting Seller Org Tax ID [1866]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? TaxIdentificationNumberIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingEntity TrusteeIndex
    /// </summary>
    public int? TrusteeIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Seller Corp/Trust Officer 1 Name [Vesting.SelOfcr1Nm]
    /// </summary>
    public string? TrustOfficerName1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Seller Corp/Trust Officer 2 Name [Vesting.SelOfcr2Nm]
    /// </summary>
    public string? TrustOfficerName2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Seller Corp/Trust Officer 1 Title [Vesting.SelOfcr1Titl]
    /// </summary>
    public string? TrustOfficerTitle1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Seller Corp/Trust Officer 2 Title [Vesting.SelOfcr2Titl]
    /// </summary>
    public string? TrustOfficerTitle2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingEntity UnparsedName [TRNN01]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? UnparsedName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Vesting [TRNN08]
    /// </summary>
    public string? Vesting { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Unique ID [TRNN10]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? VestingGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Trustee Of [TRNN06]
    /// </summary>
    public StringEnumValue<VestingTrusteeOfType> VestingTrusteeOfType { get => GetValue<StringEnumValue<VestingTrusteeOfType>>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Vesting Type [TRNN04]
    /// </summary>
    public StringEnumValue<BorrowerType> VestingType { get => GetValue<StringEnumValue<BorrowerType>>(); set => SetValue(value); }
}