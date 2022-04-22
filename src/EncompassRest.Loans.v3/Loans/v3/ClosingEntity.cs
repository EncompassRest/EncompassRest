using System;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ClosingEntity
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class ClosingEntity : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Vesting Party - Alias [TR0002]
    /// </summary>
    public string? Alias { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingEntity Application
    /// </summary>
    [AllowNull]
    public EntityReference Application { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// Closing Docs Loss Payee Assignee [1953]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Assignee { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Authorized to Sign [TR0009]
    /// </summary>
    public bool? AuthorizedToSignIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - POA Date of Birth [TR0012]
    /// </summary>
    public DateTime? BirthDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingEntity City
    /// </summary>
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
    /// Closing Docs Lender Fax [1922]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true)]
    public string? Fax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingEntity NonBorrowingOwner
    /// </summary>
    [AllowNull]
    public EntityReference NonBorrowingOwner { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// Vesting Party - POA Occupancy Intent [TR0014]
    /// </summary>
    public StringEnumValue<OccupancyIntent> OccupancyIntent { get => GetValue<StringEnumValue<OccupancyIntent>>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - POA Occupancy Status [TR0013]
    /// </summary>
    public StringEnumValue<PropertyUsageType> OccupancyStatus { get => GetValue<StringEnumValue<PropertyUsageType>>(); set => SetValue(value); }

    /// <summary>
    /// ClosingEntity OrganizationType
    /// </summary>
    public string? OrganizationType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingEntity OrganizedUnderTheLawsOfJurisdictionName
    /// </summary>
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
    /// Vesting Party - POA Signature Text [TR0011]
    /// </summary>
    public string? PoaSignatureText { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingEntity PostalCode
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Power of Attroney [TR0007]
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
    /// Vesting Party - Social Security Number [TR0003]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.SSN)]
    public string? Ssn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingEntity State
    /// </summary>
    public string? State { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingEntity StreetAddress
    /// </summary>
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
    /// ClosingEntity UnparsedName
    /// </summary>
    public string? UnparsedName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Vesting [TR0008]
    /// </summary>
    public string? Vesting { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Unique ID [TR0010]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? VestingGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Trustee Of [TR0006]
    /// </summary>
    public StringEnumValue<VestingTrusteeOfType> VestingTrusteeOfType { get => GetValue<StringEnumValue<VestingTrusteeOfType>>(); set => SetValue(value); }

    /// <summary>
    /// Vesting Party - Vesting Type [TR0004]
    /// </summary>
    public StringEnumValue<BorrowerType> VestingType { get => GetValue<StringEnumValue<BorrowerType>>(); set => SetValue(value); }
}