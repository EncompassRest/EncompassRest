using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LoanAssociate
/// </summary>
public sealed partial class LoanAssociate : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LoanAssociate APIClientID
    /// </summary>
    public string? APIClientID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanAssociate CellPhone
    /// </summary>
    public string? CellPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanAssociate Email
    /// </summary>
    public string? Email { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanAssociate EnableWriteAccess
    /// </summary>
    public StringEnumValue<YOrN> EnableWriteAccess { get => GetValue<StringEnumValue<YOrN>>(); set => SetValue(value); }

    /// <summary>
    /// LoanAssociate Fax
    /// </summary>
    public string? Fax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanAssociate Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanAssociate IdString
    /// </summary>
    public string? IdString { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanAssociate LoanAssociateType
    /// </summary>
    public StringEnumValue<LoanAssociateType> LoanAssociateType { get => GetValue<StringEnumValue<LoanAssociateType>>(); set => SetValue(value); }

    /// <summary>
    /// LoanAssociate Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanAssociate Phone
    /// </summary>
    public string? Phone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanAssociate RoleId
    /// </summary>
    public int? RoleId { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanAssociate RoleName
    /// </summary>
    public string? RoleName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanAssociate Title
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanAssociate WriteAccess
    /// </summary>
    public string? WriteAccess { get => GetValue<string?>(); set => SetValue(value); }
}