using System.Diagnostics.CodeAnalysis;
namespace EncompassRest.Loans.v3;

/// <summary>
/// MilestoneFreeRole
/// </summary>
public sealed partial class MilestoneFreeRole : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// MilestoneFreeRole Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneFreeRole LoanAssociate
    /// </summary>
    [AllowNull]
    public LoanAssociate LoanAssociate { get => GetEntity<LoanAssociate>(); set => SetEntity(value); }
}