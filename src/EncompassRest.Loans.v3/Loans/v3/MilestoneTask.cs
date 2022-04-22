using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// MilestoneTask
/// </summary>
public sealed partial class MilestoneTask : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// MilestoneTask AddDate
    /// </summary>
    public DateTime? AddDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTask AddedBy
    /// </summary>
    public string? AddedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTask AddedByUserId
    /// </summary>
    public string? AddedByUserId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTask Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// MilestoneTask Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTask Completed
    /// </summary>
    public bool? Completed { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTask CompletedBy
    /// </summary>
    public string? CompletedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTask CompletedByUserId
    /// </summary>
    public string? CompletedByUserId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTask CompletedDate
    /// </summary>
    public DateTime? CompletedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTask ContactCount
    /// </summary>
    public int? ContactCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTask Contacts
    /// </summary>
    [AllowNull]
    public IList<MilestoneTaskContact> Contacts { get => GetList<MilestoneTaskContact>(); set => SetList(value); }

    /// <summary>
    /// MilestoneTask DaysToComplete
    /// </summary>
    public int? DaysToComplete { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTask DaysToCompleteFromSetting
    /// </summary>
    public int? DaysToCompleteFromSetting { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTask ExpectedDate
    /// </summary>
    public DateTime? ExpectedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTask Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTask IsRequiredIndicator
    /// </summary>
    public bool? IsRequiredIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTask MilestoneRef
    /// </summary>
    [AllowNull]
    public EntityReference MilestoneRef { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// MilestoneTask MilestoneTaskLogDate
    /// </summary>
    public DateTime? MilestoneTaskLogDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTask Priority
    /// </summary>
    public string? Priority { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTask TaskDescription
    /// </summary>
    public string? TaskDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTask TaskGuid
    /// </summary>
    public string? TaskGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTask TaskName
    /// </summary>
    public string? TaskName { get => GetValue<string?>(); set => SetValue(value); }
}