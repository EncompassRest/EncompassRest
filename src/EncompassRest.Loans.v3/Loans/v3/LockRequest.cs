using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LockRequest
/// </summary>
public sealed partial class LockRequest : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LockRequest BuySideExpirationDate
    /// </summary>
    public DateTime? BuySideExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest BuySideNewLockExtensionDate
    /// </summary>
    public DateTime? BuySideNewLockExtensionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest BuySideNumDayExtended
    /// </summary>
    public int? BuySideNumDayExtended { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest BuySideNumDayLocked
    /// </summary>
    public int? BuySideNumDayLocked { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest CumulatedDaystoExtend
    /// </summary>
    public int? CumulatedDaystoExtend { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest HideLogIndicator
    /// </summary>
    public bool? HideLogIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest InvestorCommitment
    /// </summary>
    public string? InvestorCommitment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest InvestorName
    /// </summary>
    public string? InvestorName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest IsFakeRequestIndicator
    /// </summary>
    public bool? IsFakeRequestIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest IsLockCancellationIndicator
    /// </summary>
    public bool? IsLockCancellationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest IsLockExtensionIndicator
    /// </summary>
    public bool? IsLockExtensionIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest IsReLockIndicator
    /// </summary>
    public bool? IsReLockIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest LegacyId
    /// </summary>
    public string? LegacyId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest NumDayLocked
    /// </summary>
    public int? NumDayLocked { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest ParentLockGuid
    /// </summary>
    public string? ParentLockGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest RateLockAction
    /// </summary>
    public string? RateLockAction { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest ReLockSequenceNumberForInactiveLock
    /// </summary>
    public int? ReLockSequenceNumberForInactiveLock { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest RequestedBy
    /// </summary>
    public string? RequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest RequestedDate
    /// </summary>
    public DateTime? RequestedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest RequestedName
    /// </summary>
    public string? RequestedName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest RequestedOldStatus
    /// </summary>
    public string? RequestedOldStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest RequestedStatus
    /// </summary>
    public string? RequestedStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest ReviseAction
    /// </summary>
    public string? ReviseAction { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest SellSideDeliveredBy
    /// </summary>
    public string? SellSideDeliveredBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest SellSideDeliveryDate
    /// </summary>
    public DateTime? SellSideDeliveryDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest SellSideExpirationDate
    /// </summary>
    public DateTime? SellSideExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest SellSideNewLockExtensionDate
    /// </summary>
    public DateTime? SellSideNewLockExtensionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest SellSideNumDayExtended
    /// </summary>
    public int? SellSideNumDayExtended { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest SnapshotFields
    /// </summary>
    [AllowNull]
    public IList<LogSnapshotField> SnapshotFields { get => GetList<LogSnapshotField>(); set => SetList(value); }

    /// <summary>
    /// LockRequest TimeRequested
    /// </summary>
    public string? TimeRequested { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequest Voided
    /// </summary>
    public bool? Voided { get => GetValue<bool?>(); set => SetValue(value); }
}