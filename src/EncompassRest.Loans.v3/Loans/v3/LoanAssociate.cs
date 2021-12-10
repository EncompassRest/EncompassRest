using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LoanAssociate
/// </summary>
public sealed partial class LoanAssociate : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _apiClientId;
    private DirtyValue<string?>? _cellPhone;
    private DirtyValue<string?>? _email;
    private DirtyValue<string?>? _fax;
    private DirtyValue<StringEnumValue<LoanAssociateType>>? _loanAssociateType;
    private DirtyValue<string?>? _phone;
    private EntityReference? _role;
    private DirtyValue<string?>? _title;
    private EntityReference? _user;
    private DirtyValue<bool?>? _writeAccess;

    /// <summary>
    /// LoanAssociateContract ApiClientId
    /// </summary>
    public string? ApiClientId { get => _apiClientId; set => SetField(ref _apiClientId, value); }

    /// <summary>
    /// LoanAssociateContract CellPhone
    /// </summary>
    public string? CellPhone { get => _cellPhone; set => SetField(ref _cellPhone, value); }

    /// <summary>
    /// LoanAssociateContract Email
    /// </summary>
    public string? Email { get => _email; set => SetField(ref _email, value); }

    /// <summary>
    /// LoanAssociateContract Fax
    /// </summary>
    public string? Fax { get => _fax; set => SetField(ref _fax, value); }

    /// <summary>
    /// LoanAssociateContract LoanAssociateType
    /// </summary>
    public StringEnumValue<LoanAssociateType> LoanAssociateType { get => _loanAssociateType; set => SetField(ref _loanAssociateType, value); }

    /// <summary>
    /// LoanAssociateContract Phone
    /// </summary>
    public string? Phone { get => _phone; set => SetField(ref _phone, value); }

    /// <summary>
    /// LoanAssociateContract Role
    /// </summary>
    [AllowNull]
    public EntityReference Role { get => GetField(ref _role); set => SetField(ref _role, value); }

    /// <summary>
    /// LoanAssociateContract Title
    /// </summary>
    public string? Title { get => _title; set => SetField(ref _title, value); }

    /// <summary>
    /// LoanAssociateContract User
    /// </summary>
    [AllowNull]
    public EntityReference User { get => GetField(ref _user); set => SetField(ref _user, value); }

    /// <summary>
    /// LoanAssociateContract WriteAccess
    /// </summary>
    public bool? WriteAccess { get => _writeAccess; set => SetField(ref _writeAccess, value); }
}