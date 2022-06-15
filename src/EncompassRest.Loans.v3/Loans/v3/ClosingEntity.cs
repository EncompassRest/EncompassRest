using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ClosingEntity
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(ClosingEntityType))]
public sealed partial class ClosingEntity : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Closing Docs Loss Payee Assignee [1953]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Assignee { get => GetValue<string?>(); set => SetValue(value); }

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
    /// ClosingEntity PostalCode
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => GetValue<string?>(); set => SetValue(value); }

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
}