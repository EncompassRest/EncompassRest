using System;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Milestone
/// </summary>
public sealed partial class Milestone : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Milestone Days
    /// </summary>
    public int? Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Milestone DoneIndicator
    /// </summary>
    public bool? DoneIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Milestone Duration
    /// </summary>
    public int? Duration { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Milestone Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Milestone LoanAssociate
    /// </summary>
    [AllowNull]
    public LoanAssociate LoanAssociate { get => GetEntity<LoanAssociate>(); set => SetEntity(value); }

    /// <summary>
    /// Milestone MilestoneSetting
    /// </summary>
    [AllowNull]
    public EntityReference MilestoneSetting { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// Milestone Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Milestone ReviewedIndicator
    /// </summary>
    public bool? ReviewedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Milestone RoleRequired
    /// </summary>
    public string? RoleRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Milestone StartDate
    /// </summary>
    public DateTime? StartDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}