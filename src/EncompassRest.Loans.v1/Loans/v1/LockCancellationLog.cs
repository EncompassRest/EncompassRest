using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LockCancellationLog
/// </summary>
public sealed partial class LockCancellationLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LockCancellationLog AlertIndicator
    /// </summary>
    public bool? AlertIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockCancellationLog AlertsXml
    /// </summary>
    public string? AlertsXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockCancellationLog CancelledBy
    /// </summary>
    public string? CancelledBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockCancellationLog CancelledById
    /// </summary>
    public string? CancelledById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockCancellationLog CommentListXml
    /// </summary>
    public string? CommentListXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockCancellationLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockCancellationLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockCancellationLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockCancellationLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockCancellationLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockCancellationLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockCancellationLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LockCancellationLog RequestGuid
    /// </summary>
    public string? RequestGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockCancellationLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockCancellationLog TimeCancelled
    /// </summary>
    public string? TimeCancelled { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockCancellationLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}