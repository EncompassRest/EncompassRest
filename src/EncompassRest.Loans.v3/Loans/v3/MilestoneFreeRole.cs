using System.Diagnostics.CodeAnalysis;
namespace EncompassRest.Loans.v3;

/// <summary>
/// MilestoneFreeRole
/// </summary>
public sealed partial class MilestoneFreeRole : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _id;
    private LoanAssociate? _loanAssociate;

    /// <summary>
    /// MilestoneFreeRoleContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// MilestoneFreeRoleContract LoanAssociate
    /// </summary>
    [AllowNull]
    public LoanAssociate LoanAssociate { get => GetField(ref _loanAssociate); set => SetField(ref _loanAssociate, value); }
}