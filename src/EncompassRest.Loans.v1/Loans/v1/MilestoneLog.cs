using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// MilestoneLog
/// </summary>
public sealed partial class MilestoneLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// MilestoneLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// MilestoneLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// MilestoneLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneLog Days
    /// </summary>
    public int? Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneLog DoneIndicator
    /// </summary>
    public bool? DoneIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneLog Duration
    /// </summary>
    public int? Duration { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneLog LoanAssociate
    /// </summary>
    public LoanAssociate? LoanAssociate { get => GetValue<LoanAssociate?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneLog MilestoneIdString
    /// </summary>
    public string? MilestoneIdString { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneLog ReviewedIndicator
    /// </summary>
    public bool? ReviewedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneLog RoleRequired
    /// </summary>
    public string? RoleRequired { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneLog Stage
    /// </summary>
    public string? Stage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneLog TPOConnectStatus
    /// </summary>
    public string? TPOConnectStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}