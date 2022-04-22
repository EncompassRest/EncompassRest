using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LockConfirmLog
/// </summary>
public sealed partial class LockConfirmLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LockConfirmLog AlertIndicator
    /// </summary>
    public bool? AlertIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// LockConfirmLog BuySideExpirationDate
    /// </summary>
    public DateTime? BuySideExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// LockConfirmLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog CommitmentTermEnabled
    /// </summary>
    public bool? CommitmentTermEnabled { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog ConfirmedBy
    /// </summary>
    public string? ConfirmedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog ConfirmedById
    /// </summary>
    public string? ConfirmedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog ConfirmedByIdIndicator
    /// </summary>
    public bool? ConfirmedByIdIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog HideLog
    /// </summary>
    public bool? HideLog { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog IncludeConfirmCount
    /// </summary>
    public bool? IncludeConfirmCount { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog RequestGuid
    /// </summary>
    public string? RequestGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog SellSideDeliveredBy
    /// </summary>
    public string? SellSideDeliveredBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog SellSideDeliveryDate
    /// </summary>
    public DateTime? SellSideDeliveryDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog SellSideExpirationDate
    /// </summary>
    public DateTime? SellSideExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog TimeConfirmed
    /// </summary>
    public string? TimeConfirmed { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LockConfirmLog Voided
    /// </summary>
    public bool? Voided { get => GetValue<bool?>(); set => SetValue(value); }
}