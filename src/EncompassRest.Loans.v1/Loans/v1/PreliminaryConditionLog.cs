using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// PreliminaryConditionLog
/// </summary>
public sealed partial class PreliminaryConditionLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PreliminaryConditionLog AddedBy
    /// </summary>
    public string? AddedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// PreliminaryConditionLog AlertsXml
    /// </summary>
    public string? AlertsXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog Category
    /// </summary>
    public string? Category { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// PreliminaryConditionLog CommentListXml
    /// </summary>
    public string? CommentListXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog DateAddedUtc
    /// </summary>
    public DateTime? DateAddedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog DateExpected
    /// </summary>
    public DateTime? DateExpected { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog DateFulfilled
    /// </summary>
    public DateTime? DateFulfilled { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog DateReceived
    /// </summary>
    public DateTime? DateReceived { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog DateRequestedUtc
    /// </summary>
    public DateTime? DateRequestedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog DateRerequestedUtc
    /// </summary>
    public DateTime? DateRerequestedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog Details
    /// </summary>
    public string? Details { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog Expected
    /// </summary>
    public bool? Expected { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog Fulfilled
    /// </summary>
    public bool? Fulfilled { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog FulfilledBy
    /// </summary>
    public string? FulfilledBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog IsMarkedRemoved
    /// </summary>
    public bool? IsMarkedRemoved { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog IsPastDue
    /// </summary>
    public bool? IsPastDue { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog PairId
    /// </summary>
    public string? PairId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog PriorTo
    /// </summary>
    public string? PriorTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog Received
    /// </summary>
    public bool? Received { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog ReceivedBy
    /// </summary>
    public string? ReceivedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog Requested
    /// </summary>
    public bool? Requested { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog RequestedBy
    /// </summary>
    public string? RequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog Rerequested
    /// </summary>
    public bool? Rerequested { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog RerequestedBy
    /// </summary>
    public string? RerequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog Source
    /// </summary>
    public string? Source { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog Status
    /// </summary>
    public string? Status { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog StatusDescription
    /// </summary>
    public string? StatusDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog Title
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog UnderwriterAccessIndicator
    /// </summary>
    public bool? UnderwriterAccessIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryConditionLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}