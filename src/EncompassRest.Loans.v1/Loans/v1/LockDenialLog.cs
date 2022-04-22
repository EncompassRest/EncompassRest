using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LockDenialLog
/// </summary>
public sealed partial class LockDenialLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LockDenialLog AlertIndicator
    /// </summary>
    public bool? AlertIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockDenialLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// LockDenialLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// LockDenialLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockDenialLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockDenialLog DeniedBy
    /// </summary>
    public string? DeniedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockDenialLog DeniedById
    /// </summary>
    public string? DeniedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockDenialLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockDenialLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockDenialLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockDenialLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockDenialLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LockDenialLog RequestGuid
    /// </summary>
    public string? RequestGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockDenialLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockDenialLog TimeDenied
    /// </summary>
    public string? TimeDenied { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockDenialLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}