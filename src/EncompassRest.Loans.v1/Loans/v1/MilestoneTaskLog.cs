using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// MilestoneTaskLog
/// </summary>
public sealed partial class MilestoneTaskLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// MilestoneTaskLog AddDate
    /// </summary>
    public DateTime? AddDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog AddedBy
    /// </summary>
    public string? AddedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog AddedByUserId
    /// </summary>
    public string? AddedByUserId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// MilestoneTaskLog AlertsXml
    /// </summary>
    public string? AlertsXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// MilestoneTaskLog CommentListXml
    /// </summary>
    public string? CommentListXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog Completed
    /// </summary>
    public bool? Completed { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog CompletedBy
    /// </summary>
    public string? CompletedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog CompletedByUserId
    /// </summary>
    public string? CompletedByUserId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog CompletedDateUtc
    /// </summary>
    public DateTime? CompletedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog ContactCount
    /// </summary>
    public int? ContactCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog Contacts
    /// </summary>
    [AllowNull]
    public IList<MilestoneTaskContact> Contacts { get => GetList<MilestoneTaskContact>(); set => SetList(value); }

    /// <summary>
    /// MilestoneTaskLog ContactsXml
    /// </summary>
    public string? ContactsXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog DaysToComplete
    /// </summary>
    public int? DaysToComplete { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog DaysToCompleteFromSetting
    /// </summary>
    public int? DaysToCompleteFromSetting { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog ExpectedDate
    /// </summary>
    public DateTime? ExpectedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog IsRequiredIndicator
    /// </summary>
    public bool? IsRequiredIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog MilestoneTaskLogDateUtc
    /// </summary>
    public DateTime? MilestoneTaskLogDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog Priority
    /// </summary>
    public string? Priority { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog Stage
    /// </summary>
    public string? Stage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog TaskDescription
    /// </summary>
    public string? TaskDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog TaskGuid
    /// </summary>
    public string? TaskGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog TaskName
    /// </summary>
    public string? TaskName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}