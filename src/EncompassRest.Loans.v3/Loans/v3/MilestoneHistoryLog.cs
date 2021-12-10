using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// MilestoneHistoryLog
/// </summary>
public sealed partial class MilestoneHistoryLog : DirtyExtensibleObject, IIdentifiable
{
    private EntityReference? _addedBy;
    private DirtyValue<DateTime?>? _addedDate;
    private DirtyList<LogAlert>? _alerts;
    private DirtyValue<string?>? _changeReason;
    private DirtyList<LogComment>? _commentList;
    private DirtyValue<string?>? _comments;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _milestoneTemplate;

    /// <summary>
    /// MilestoneHistoryLogContract AddedBy
    /// </summary>
    [AllowNull]
    public EntityReference AddedBy { get => GetField(ref _addedBy); set => SetField(ref _addedBy, value); }

    /// <summary>
    /// MilestoneHistoryLogContract AddedDate
    /// </summary>
    public DateTime? AddedDate { get => _addedDate; set => SetField(ref _addedDate, value); }

    /// <summary>
    /// MilestoneHistoryLogContract Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

    /// <summary>
    /// MilestoneHistoryLogContract ChangeReason
    /// </summary>
    public string? ChangeReason { get => _changeReason; set => SetField(ref _changeReason, value); }

    /// <summary>
    /// MilestoneHistoryLogContract CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

    /// <summary>
    /// MilestoneHistoryLogContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// MilestoneHistoryLogContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// MilestoneHistoryLogContract MilestoneTemplate
    /// </summary>
    public string? MilestoneTemplate { get => _milestoneTemplate; set => SetField(ref _milestoneTemplate, value); }
}