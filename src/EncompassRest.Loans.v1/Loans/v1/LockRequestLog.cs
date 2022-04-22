using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LockRequestLog
/// </summary>
public sealed partial class LockRequestLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LockRequestLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// LockRequestLog AlertsXml
    /// </summary>
    public string? AlertsXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog BuySideExpirationDate
    /// </summary>
    public DateTime? BuySideExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog BuySideNewLockExtensionDate
    /// </summary>
    public DateTime? BuySideNewLockExtensionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog BuySideNumDayExtended
    /// </summary>
    public int? BuySideNumDayExtended { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog BuySideNumDayLocked
    /// </summary>
    public int? BuySideNumDayLocked { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// LockRequestLog CommentListXml
    /// </summary>
    public string? CommentListXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog CumulatedDaystoExtend
    /// </summary>
    public int? CumulatedDaystoExtend { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog HideLogIndicator
    /// </summary>
    public bool? HideLogIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog InvestorCommitment
    /// </summary>
    public string? InvestorCommitment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog InvestorName
    /// </summary>
    public string? InvestorName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog IsFakeRequestIndicator
    /// </summary>
    public bool? IsFakeRequestIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog IsLockCancellationIndicator
    /// </summary>
    public bool? IsLockCancellationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog IsLockExtensionIndicator
    /// </summary>
    public bool? IsLockExtensionIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog IsReLockIndicator
    /// </summary>
    public bool? IsReLockIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog NumDayLocked
    /// </summary>
    public int? NumDayLocked { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog ParentLockGuid
    /// </summary>
    public string? ParentLockGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog RateLockAction
    /// </summary>
    public string? RateLockAction { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog ReLockSequenceNumberForInactiveLock
    /// </summary>
    public int? ReLockSequenceNumberForInactiveLock { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog RequestedBy
    /// </summary>
    public string? RequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog RequestedName
    /// </summary>
    public string? RequestedName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog RequestedOldStatus
    /// </summary>
    public string? RequestedOldStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog RequestedStatus
    /// </summary>
    public string? RequestedStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog ReviseAction
    /// </summary>
    public string? ReviseAction { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog SellSideDeliveredBy
    /// </summary>
    public string? SellSideDeliveredBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog SellSideDeliveryDate
    /// </summary>
    public DateTime? SellSideDeliveryDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog SellSideExpirationDate
    /// </summary>
    public DateTime? SellSideExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog SellSideNewLockExtensionDate
    /// </summary>
    public DateTime? SellSideNewLockExtensionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog SellSideNumDayExtended
    /// </summary>
    public int? SellSideNumDayExtended { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog SnapshotXml
    /// </summary>
    public string? SnapshotXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog TimeRequested
    /// </summary>
    public string? TimeRequested { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestLog Voided
    /// </summary>
    public bool? Voided { get => GetValue<bool?>(); set => SetValue(value); }
}