using System;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Milestone
/// </summary>
public sealed partial class Milestone : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<int?>? _days;
    private DirtyValue<bool?>? _doneIndicator;
    private DirtyValue<int?>? _duration;
    private DirtyValue<string?>? _id;
    private LoanAssociate? _loanAssociate;
    private EntityReference? _milestoneSetting;
    private DirtyValue<string?>? _name;
    private DirtyValue<bool?>? _reviewedIndicator;
    private DirtyValue<string?>? _roleRequired;
    private DirtyValue<DateTime?>? _startDate;

    /// <summary>
    /// MilestoneContract Days
    /// </summary>
    public int? Days { get => _days; set => SetField(ref _days, value); }

    /// <summary>
    /// MilestoneContract DoneIndicator
    /// </summary>
    public bool? DoneIndicator { get => _doneIndicator; set => SetField(ref _doneIndicator, value); }

    /// <summary>
    /// MilestoneContract Duration
    /// </summary>
    public int? Duration { get => _duration; set => SetField(ref _duration, value); }

    /// <summary>
    /// MilestoneContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// MilestoneContract LoanAssociate
    /// </summary>
    [AllowNull]
    public LoanAssociate LoanAssociate { get => GetField(ref _loanAssociate); set => SetField(ref _loanAssociate, value); }

    /// <summary>
    /// MilestoneContract MilestoneSetting
    /// </summary>
    [AllowNull]
    public EntityReference MilestoneSetting { get => GetField(ref _milestoneSetting); set => SetField(ref _milestoneSetting, value); }

    /// <summary>
    /// MilestoneContract Name
    /// </summary>
    public string? Name { get => _name; set => SetField(ref _name, value); }

    /// <summary>
    /// MilestoneContract ReviewedIndicator
    /// </summary>
    public bool? ReviewedIndicator { get => _reviewedIndicator; set => SetField(ref _reviewedIndicator, value); }

    /// <summary>
    /// MilestoneContract RoleRequired
    /// </summary>
    public string? RoleRequired { get => _roleRequired; set => SetField(ref _roleRequired, value); }

    /// <summary>
    /// MilestoneContract StartDate
    /// </summary>
    public DateTime? StartDate { get => _startDate; set => SetField(ref _startDate, value); }
}