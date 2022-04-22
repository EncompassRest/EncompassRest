using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LoanAssociate
/// </summary>
public sealed partial class LoanAssociate : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LoanAssociate ApiClientId
    /// </summary>
    public string? ApiClientId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanAssociate CellPhone
    /// </summary>
    public string? CellPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanAssociate Email
    /// </summary>
    public string? Email { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanAssociate Fax
    /// </summary>
    public string? Fax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanAssociate LoanAssociateType
    /// </summary>
    public StringEnumValue<LoanAssociateType> LoanAssociateType { get => GetValue<StringEnumValue<LoanAssociateType>>(); set => SetValue(value); }

    /// <summary>
    /// LoanAssociate Phone
    /// </summary>
    public string? Phone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanAssociate Role
    /// </summary>
    [AllowNull]
    public EntityReference Role { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// LoanAssociate Title
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanAssociate User
    /// </summary>
    [AllowNull]
    public EntityReference User { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// LoanAssociate WriteAccess
    /// </summary>
    public bool? WriteAccess { get => GetValue<bool?>(); set => SetValue(value); }
}