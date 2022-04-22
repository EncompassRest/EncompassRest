using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// PostClosingConditionLog
/// </summary>
public sealed partial class PostClosingConditionLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PostClosingConditionLog AddedBy
    /// </summary>
    public string? AddedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// PostClosingConditionLog AlertsXml
    /// </summary>
    public string? AlertsXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog Cleared
    /// </summary>
    public bool? Cleared { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog ClearedBy
    /// </summary>
    public string? ClearedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// PostClosingConditionLog CommentListXml
    /// </summary>
    public string? CommentListXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog DateAddedUtc
    /// </summary>
    public DateTime? DateAddedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog DateClearedUtc
    /// </summary>
    public DateTime? DateClearedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog DateExpected
    /// </summary>
    public DateTime? DateExpected { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog DateReceived
    /// </summary>
    public DateTime? DateReceived { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog DateRequestedUtc
    /// </summary>
    public DateTime? DateRequestedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog DateRerequestedUtc
    /// </summary>
    public DateTime? DateRerequestedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog DateSentUtc
    /// </summary>
    public DateTime? DateSentUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog DaysTillDue
    /// </summary>
    public int? DaysTillDue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog Details
    /// </summary>
    public string? Details { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog Expected
    /// </summary>
    public bool? Expected { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog IsExternalIndicator
    /// </summary>
    public bool? IsExternalIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog IsInternalIndicator
    /// </summary>
    public bool? IsInternalIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog IsMarkedRemoved
    /// </summary>
    public bool? IsMarkedRemoved { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog IsPastDue
    /// </summary>
    public bool? IsPastDue { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog PairId
    /// </summary>
    public string? PairId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog Received
    /// </summary>
    public bool? Received { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog ReceivedBy
    /// </summary>
    public string? ReceivedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog Recipient
    /// </summary>
    public string? Recipient { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog Requested
    /// </summary>
    public bool? Requested { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog RequestedBy
    /// </summary>
    public string? RequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog RequestedFrom
    /// </summary>
    public string? RequestedFrom { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog Rerequested
    /// </summary>
    public bool? Rerequested { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog RerequestedBy
    /// </summary>
    public string? RerequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog Sent
    /// </summary>
    public bool? Sent { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog SentBy
    /// </summary>
    public string? SentBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog Source
    /// </summary>
    public string? Source { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog Status
    /// </summary>
    public string? Status { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog StatusDescription
    /// </summary>
    public string? StatusDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog Title
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingConditionLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}