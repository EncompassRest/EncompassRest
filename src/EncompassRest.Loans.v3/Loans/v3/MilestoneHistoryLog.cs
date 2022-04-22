using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// MilestoneHistoryLog
/// </summary>
public sealed partial class MilestoneHistoryLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// MilestoneHistoryLog AddedBy
    /// </summary>
    [AllowNull]
    public EntityReference AddedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// MilestoneHistoryLog AddedDate
    /// </summary>
    public DateTime? AddedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneHistoryLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// MilestoneHistoryLog ChangeReason
    /// </summary>
    public string? ChangeReason { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneHistoryLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// MilestoneHistoryLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneHistoryLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneHistoryLog MilestoneTemplate
    /// </summary>
    public string? MilestoneTemplate { get => GetValue<string?>(); set => SetValue(value); }
}