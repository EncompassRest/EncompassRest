using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// MilestoneTask
/// </summary>
public sealed partial class MilestoneTask : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _addDate;
    private DirtyValue<string?>? _addedBy;
    private DirtyValue<string?>? _addedByUserId;
    private DirtyList<LogAlert>? _alerts;
    private DirtyValue<string?>? _comments;
    private DirtyValue<bool?>? _completed;
    private DirtyValue<string?>? _completedBy;
    private DirtyValue<string?>? _completedByUserId;
    private DirtyValue<DateTime?>? _completedDate;
    private DirtyValue<int?>? _contactCount;
    private DirtyList<MilestoneTaskContact>? _contacts;
    private DirtyValue<int?>? _daysToComplete;
    private DirtyValue<int?>? _daysToCompleteFromSetting;
    private DirtyValue<DateTime?>? _expectedDate;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _isRequiredIndicator;
    private EntityReference? _milestoneRef;
    private DirtyValue<DateTime?>? _milestoneTaskLogDate;
    private DirtyValue<string?>? _priority;
    private DirtyValue<string?>? _taskDescription;
    private DirtyValue<string?>? _taskGuid;
    private DirtyValue<string?>? _taskName;

    /// <summary>
    /// MilestoneTaskContract AddDate
    /// </summary>
    public DateTime? AddDate { get => _addDate; set => SetField(ref _addDate, value); }

    /// <summary>
    /// MilestoneTaskContract AddedBy
    /// </summary>
    public string? AddedBy { get => _addedBy; set => SetField(ref _addedBy, value); }

    /// <summary>
    /// MilestoneTaskContract AddedByUserId
    /// </summary>
    public string? AddedByUserId { get => _addedByUserId; set => SetField(ref _addedByUserId, value); }

    /// <summary>
    /// MilestoneTaskContract Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

    /// <summary>
    /// MilestoneTaskContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// MilestoneTaskContract Completed
    /// </summary>
    public bool? Completed { get => _completed; set => SetField(ref _completed, value); }

    /// <summary>
    /// MilestoneTaskContract CompletedBy
    /// </summary>
    public string? CompletedBy { get => _completedBy; set => SetField(ref _completedBy, value); }

    /// <summary>
    /// MilestoneTaskContract CompletedByUserId
    /// </summary>
    public string? CompletedByUserId { get => _completedByUserId; set => SetField(ref _completedByUserId, value); }

    /// <summary>
    /// MilestoneTaskContract CompletedDate
    /// </summary>
    public DateTime? CompletedDate { get => _completedDate; set => SetField(ref _completedDate, value); }

    /// <summary>
    /// MilestoneTaskContract ContactCount
    /// </summary>
    public int? ContactCount { get => _contactCount; set => SetField(ref _contactCount, value); }

    /// <summary>
    /// MilestoneTaskContract Contacts
    /// </summary>
    [AllowNull]
    public IList<MilestoneTaskContact> Contacts { get => GetField(ref _contacts); set => SetField(ref _contacts, value); }

    /// <summary>
    /// MilestoneTaskContract DaysToComplete
    /// </summary>
    public int? DaysToComplete { get => _daysToComplete; set => SetField(ref _daysToComplete, value); }

    /// <summary>
    /// MilestoneTaskContract DaysToCompleteFromSetting
    /// </summary>
    public int? DaysToCompleteFromSetting { get => _daysToCompleteFromSetting; set => SetField(ref _daysToCompleteFromSetting, value); }

    /// <summary>
    /// MilestoneTaskContract ExpectedDate
    /// </summary>
    public DateTime? ExpectedDate { get => _expectedDate; set => SetField(ref _expectedDate, value); }

    /// <summary>
    /// MilestoneTaskContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// MilestoneTaskContract IsRequiredIndicator
    /// </summary>
    public bool? IsRequiredIndicator { get => _isRequiredIndicator; set => SetField(ref _isRequiredIndicator, value); }

    /// <summary>
    /// MilestoneTaskContract MilestoneRef
    /// </summary>
    [AllowNull]
    public EntityReference MilestoneRef { get => GetField(ref _milestoneRef); set => SetField(ref _milestoneRef, value); }

    /// <summary>
    /// MilestoneTaskContract MilestoneTaskLogDate
    /// </summary>
    public DateTime? MilestoneTaskLogDate { get => _milestoneTaskLogDate; set => SetField(ref _milestoneTaskLogDate, value); }

    /// <summary>
    /// MilestoneTaskContract Priority
    /// </summary>
    public string? Priority { get => _priority; set => SetField(ref _priority, value); }

    /// <summary>
    /// MilestoneTaskContract TaskDescription
    /// </summary>
    public string? TaskDescription { get => _taskDescription; set => SetField(ref _taskDescription, value); }

    /// <summary>
    /// MilestoneTaskContract TaskGuid
    /// </summary>
    public string? TaskGuid { get => _taskGuid; set => SetField(ref _taskGuid, value); }

    /// <summary>
    /// MilestoneTaskContract TaskName
    /// </summary>
    public string? TaskName { get => _taskName; set => SetField(ref _taskName, value); }
}