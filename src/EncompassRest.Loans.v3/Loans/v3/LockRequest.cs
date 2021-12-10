using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LockRequest
/// </summary>
public sealed partial class LockRequest : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _buySideExpirationDate;
    private DirtyValue<DateTime?>? _buySideNewLockExtensionDate;
    private DirtyValue<int?>? _buySideNumDayExtended;
    private DirtyValue<int?>? _buySideNumDayLocked;
    private DirtyValue<int?>? _cumulatedDaystoExtend;
    private DirtyValue<bool?>? _hideLogIndicator;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _investorCommitment;
    private DirtyValue<string?>? _investorName;
    private DirtyValue<bool?>? _isFakeRequestIndicator;
    private DirtyValue<bool?>? _isLockCancellationIndicator;
    private DirtyValue<bool?>? _isLockExtensionIndicator;
    private DirtyValue<bool?>? _isReLockIndicator;
    private DirtyValue<string?>? _legacyId;
    private DirtyValue<int?>? _numDayLocked;
    private DirtyValue<string?>? _parentLockGuid;
    private DirtyValue<string?>? _rateLockAction;
    private DirtyValue<int?>? _reLockSequenceNumberForInactiveLock;
    private DirtyValue<string?>? _requestedBy;
    private DirtyValue<DateTime?>? _requestedDate;
    private DirtyValue<string?>? _requestedName;
    private DirtyValue<string?>? _requestedOldStatus;
    private DirtyValue<string?>? _requestedStatus;
    private DirtyValue<string?>? _reviseAction;
    private DirtyValue<string?>? _sellSideDeliveredBy;
    private DirtyValue<DateTime?>? _sellSideDeliveryDate;
    private DirtyValue<DateTime?>? _sellSideExpirationDate;
    private DirtyValue<DateTime?>? _sellSideNewLockExtensionDate;
    private DirtyValue<int?>? _sellSideNumDayExtended;
    private DirtyList<LogSnapshotField>? _snapshotFields;
    private DirtyValue<string?>? _timeRequested;
    private DirtyValue<bool?>? _voided;

    /// <summary>
    /// LockRequestContract BuySideExpirationDate
    /// </summary>
    public DateTime? BuySideExpirationDate { get => _buySideExpirationDate; set => SetField(ref _buySideExpirationDate, value); }

    /// <summary>
    /// LockRequestContract BuySideNewLockExtensionDate
    /// </summary>
    public DateTime? BuySideNewLockExtensionDate { get => _buySideNewLockExtensionDate; set => SetField(ref _buySideNewLockExtensionDate, value); }

    /// <summary>
    /// LockRequestContract BuySideNumDayExtended
    /// </summary>
    public int? BuySideNumDayExtended { get => _buySideNumDayExtended; set => SetField(ref _buySideNumDayExtended, value); }

    /// <summary>
    /// LockRequestContract BuySideNumDayLocked
    /// </summary>
    public int? BuySideNumDayLocked { get => _buySideNumDayLocked; set => SetField(ref _buySideNumDayLocked, value); }

    /// <summary>
    /// LockRequestContract CumulatedDaystoExtend
    /// </summary>
    public int? CumulatedDaystoExtend { get => _cumulatedDaystoExtend; set => SetField(ref _cumulatedDaystoExtend, value); }

    /// <summary>
    /// LockRequestContract HideLogIndicator
    /// </summary>
    public bool? HideLogIndicator { get => _hideLogIndicator; set => SetField(ref _hideLogIndicator, value); }

    /// <summary>
    /// LockRequestContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// LockRequestContract InvestorCommitment
    /// </summary>
    public string? InvestorCommitment { get => _investorCommitment; set => SetField(ref _investorCommitment, value); }

    /// <summary>
    /// LockRequestContract InvestorName
    /// </summary>
    public string? InvestorName { get => _investorName; set => SetField(ref _investorName, value); }

    /// <summary>
    /// LockRequestContract IsFakeRequestIndicator
    /// </summary>
    public bool? IsFakeRequestIndicator { get => _isFakeRequestIndicator; set => SetField(ref _isFakeRequestIndicator, value); }

    /// <summary>
    /// LockRequestContract IsLockCancellationIndicator
    /// </summary>
    public bool? IsLockCancellationIndicator { get => _isLockCancellationIndicator; set => SetField(ref _isLockCancellationIndicator, value); }

    /// <summary>
    /// LockRequestContract IsLockExtensionIndicator
    /// </summary>
    public bool? IsLockExtensionIndicator { get => _isLockExtensionIndicator; set => SetField(ref _isLockExtensionIndicator, value); }

    /// <summary>
    /// LockRequestContract IsReLockIndicator
    /// </summary>
    public bool? IsReLockIndicator { get => _isReLockIndicator; set => SetField(ref _isReLockIndicator, value); }

    /// <summary>
    /// LockRequestContract LegacyId
    /// </summary>
    public string? LegacyId { get => _legacyId; set => SetField(ref _legacyId, value); }

    /// <summary>
    /// LockRequestContract NumDayLocked
    /// </summary>
    public int? NumDayLocked { get => _numDayLocked; set => SetField(ref _numDayLocked, value); }

    /// <summary>
    /// LockRequestContract ParentLockGuid
    /// </summary>
    public string? ParentLockGuid { get => _parentLockGuid; set => SetField(ref _parentLockGuid, value); }

    /// <summary>
    /// LockRequestContract RateLockAction
    /// </summary>
    public string? RateLockAction { get => _rateLockAction; set => SetField(ref _rateLockAction, value); }

    /// <summary>
    /// LockRequestContract ReLockSequenceNumberForInactiveLock
    /// </summary>
    public int? ReLockSequenceNumberForInactiveLock { get => _reLockSequenceNumberForInactiveLock; set => SetField(ref _reLockSequenceNumberForInactiveLock, value); }

    /// <summary>
    /// LockRequestContract RequestedBy
    /// </summary>
    public string? RequestedBy { get => _requestedBy; set => SetField(ref _requestedBy, value); }

    /// <summary>
    /// LockRequestContract RequestedDate
    /// </summary>
    public DateTime? RequestedDate { get => _requestedDate; set => SetField(ref _requestedDate, value); }

    /// <summary>
    /// LockRequestContract RequestedName
    /// </summary>
    public string? RequestedName { get => _requestedName; set => SetField(ref _requestedName, value); }

    /// <summary>
    /// LockRequestContract RequestedOldStatus
    /// </summary>
    public string? RequestedOldStatus { get => _requestedOldStatus; set => SetField(ref _requestedOldStatus, value); }

    /// <summary>
    /// LockRequestContract RequestedStatus
    /// </summary>
    public string? RequestedStatus { get => _requestedStatus; set => SetField(ref _requestedStatus, value); }

    /// <summary>
    /// LockRequestContract ReviseAction
    /// </summary>
    public string? ReviseAction { get => _reviseAction; set => SetField(ref _reviseAction, value); }

    /// <summary>
    /// LockRequestContract SellSideDeliveredBy
    /// </summary>
    public string? SellSideDeliveredBy { get => _sellSideDeliveredBy; set => SetField(ref _sellSideDeliveredBy, value); }

    /// <summary>
    /// LockRequestContract SellSideDeliveryDate
    /// </summary>
    public DateTime? SellSideDeliveryDate { get => _sellSideDeliveryDate; set => SetField(ref _sellSideDeliveryDate, value); }

    /// <summary>
    /// LockRequestContract SellSideExpirationDate
    /// </summary>
    public DateTime? SellSideExpirationDate { get => _sellSideExpirationDate; set => SetField(ref _sellSideExpirationDate, value); }

    /// <summary>
    /// LockRequestContract SellSideNewLockExtensionDate
    /// </summary>
    public DateTime? SellSideNewLockExtensionDate { get => _sellSideNewLockExtensionDate; set => SetField(ref _sellSideNewLockExtensionDate, value); }

    /// <summary>
    /// LockRequestContract SellSideNumDayExtended
    /// </summary>
    public int? SellSideNumDayExtended { get => _sellSideNumDayExtended; set => SetField(ref _sellSideNumDayExtended, value); }

    /// <summary>
    /// LockRequestContract SnapshotFields
    /// </summary>
    [AllowNull]
    public IList<LogSnapshotField> SnapshotFields { get => GetField(ref _snapshotFields); set => SetField(ref _snapshotFields, value); }

    /// <summary>
    /// LockRequestContract TimeRequested
    /// </summary>
    public string? TimeRequested { get => _timeRequested; set => SetField(ref _timeRequested, value); }

    /// <summary>
    /// LockRequestContract Voided
    /// </summary>
    public bool? Voided { get => _voided; set => SetField(ref _voided, value); }
}