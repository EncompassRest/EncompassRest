using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// UnderwritingConditionLog
/// </summary>
public sealed partial class UnderwritingConditionLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// UnderwritingConditionLog AddedBy
    /// </summary>
    public string? AddedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// UnderwritingConditionLog AlertsXml
    /// </summary>
    public string? AlertsXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog AllowToClearIndicator
    /// </summary>
    public bool? AllowToClearIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog Category
    /// </summary>
    public string? Category { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog Cleared
    /// </summary>
    public bool? Cleared { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog ClearedBy
    /// </summary>
    public string? ClearedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// UnderwritingConditionLog CommentListXml
    /// </summary>
    public string? CommentListXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog DateAddedUtc
    /// </summary>
    public DateTime? DateAddedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog DateClearedUtc
    /// </summary>
    public DateTime? DateClearedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog DateExpected
    /// </summary>
    public DateTime? DateExpected { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog DateExpiredUtc
    /// </summary>
    public DateTime? DateExpiredUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog DateFulfilledUtc
    /// </summary>
    public DateTime? DateFulfilledUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog DateReceived
    /// </summary>
    public DateTime? DateReceived { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog DateReceivedUtc
    /// </summary>
    public DateTime? DateReceivedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog DateRejectedUtc
    /// </summary>
    public DateTime? DateRejectedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog DateRequestedUtc
    /// </summary>
    public DateTime? DateRequestedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog DateRerequestedUtc
    /// </summary>
    public DateTime? DateRerequestedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog DateReviewedUtc
    /// </summary>
    public DateTime? DateReviewedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog DateWaivedUtc
    /// </summary>
    public DateTime? DateWaivedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog Details
    /// </summary>
    public string? Details { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog Expected
    /// </summary>
    public bool? Expected { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog ForRoleId
    /// </summary>
    public int? ForRoleId { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog Fulfilled
    /// </summary>
    public bool? Fulfilled { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog FulfilledBy
    /// </summary>
    public string? FulfilledBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog IsExternalIndicator
    /// </summary>
    public bool? IsExternalIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog IsInternalIndicator
    /// </summary>
    public bool? IsInternalIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog IsMarkedRemoved
    /// </summary>
    public bool? IsMarkedRemoved { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog IsPastDue
    /// </summary>
    public bool? IsPastDue { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog PairId
    /// </summary>
    public string? PairId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog PriorTo
    /// </summary>
    public string? PriorTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog Received
    /// </summary>
    public bool? Received { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog ReceivedBy
    /// </summary>
    public string? ReceivedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog Rejected
    /// </summary>
    public bool? Rejected { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog RejectedBy
    /// </summary>
    public string? RejectedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog Requested
    /// </summary>
    public bool? Requested { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog RequestedBy
    /// </summary>
    public string? RequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog Rerequested
    /// </summary>
    public bool? Rerequested { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog RerequestedBy
    /// </summary>
    public string? RerequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog Reviewed
    /// </summary>
    public bool? Reviewed { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog ReviewedBy
    /// </summary>
    public string? ReviewedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog Source
    /// </summary>
    public string? Source { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog Status
    /// </summary>
    public string? Status { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog StatusDescription
    /// </summary>
    public string? StatusDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog Title
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog Waived
    /// </summary>
    public bool? Waived { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingConditionLog WaivedBy
    /// </summary>
    public string? WaivedBy { get => GetValue<string?>(); set => SetValue(value); }
}