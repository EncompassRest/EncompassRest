using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// UnderwritingCondition
/// </summary>
public sealed partial class UnderwritingCondition : DirtyExtensibleObject, IIdentifiable
{
    private EntityReference? _addedBy;
    private DirtyValue<DateTime?>? _addedDate;
    private EntityReference? _borrowerPair;
    private DirtyValue<string?>? _category;
    private EntityReference? _clearedBy;
    private DirtyValue<DateTime?>? _clearedDate;
    private DirtyValue<int?>? _daysTillDue;
    private DirtyValue<string?>? _description;
    private DirtyValue<DateTime?>? _expectedDate;
    private DirtyValue<DateTime?>? _expiredDate;
    private EntityReference? _fulfilledBy;
    private DirtyValue<DateTime?>? _fulfilledDate;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _isMarkedRemoved;
    private DirtyValue<bool?>? _isOwnerAllowedToClear;
    private EntityReference? _owner;
    private DirtyList<string?>? _print;
    private DirtyValue<string?>? _priorTo;
    private EntityReference? _receivedBy;
    private DirtyValue<DateTime?>? _receivedDate;
    private EntityReference? _rejectedBy;
    private DirtyValue<DateTime?>? _rejectedDate;
    private EntityReference? _requestedBy;
    private DirtyValue<DateTime?>? _requestedDate;
    private DirtyValue<string?>? _requestedFrom;
    private EntityReference? _rerequestedBy;
    private DirtyValue<DateTime?>? _rerequestedDate;
    private EntityReference? _reviewedBy;
    private DirtyValue<DateTime?>? _reviewedDate;
    private DirtyValue<string?>? _source;
    private DirtyValue<StringEnumValue<ConditionStatus>>? _status;
    private DirtyValue<DateTime?>? _statusDate;
    private DirtyValue<string?>? _title;
    private EntityReference? _waivedBy;
    private DirtyValue<DateTime?>? _waivedDate;

    /// <summary>
    /// UnderwritingConditionContract AddedBy
    /// </summary>
    [AllowNull]
    public EntityReference AddedBy { get => GetField(ref _addedBy); set => SetField(ref _addedBy, value); }

    /// <summary>
    /// UnderwritingConditionContract AddedDate
    /// </summary>
    public DateTime? AddedDate { get => _addedDate; set => SetField(ref _addedDate, value); }

    /// <summary>
    /// UnderwritingConditionContract BorrowerPair
    /// </summary>
    [AllowNull]
    public EntityReference BorrowerPair { get => GetField(ref _borrowerPair); set => SetField(ref _borrowerPair, value); }

    /// <summary>
    /// UnderwritingConditionContract Category
    /// </summary>
    public string? Category { get => _category; set => SetField(ref _category, value); }

    /// <summary>
    /// UnderwritingConditionContract ClearedBy
    /// </summary>
    [AllowNull]
    public EntityReference ClearedBy { get => GetField(ref _clearedBy); set => SetField(ref _clearedBy, value); }

    /// <summary>
    /// UnderwritingConditionContract ClearedDate
    /// </summary>
    public DateTime? ClearedDate { get => _clearedDate; set => SetField(ref _clearedDate, value); }

    /// <summary>
    /// UnderwritingConditionContract DaysTillDue
    /// </summary>
    public int? DaysTillDue { get => _daysTillDue; set => SetField(ref _daysTillDue, value); }

    /// <summary>
    /// UnderwritingConditionContract Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// UnderwritingConditionContract ExpectedDate
    /// </summary>
    public DateTime? ExpectedDate { get => _expectedDate; set => SetField(ref _expectedDate, value); }

    /// <summary>
    /// UnderwritingConditionContract ExpiredDate
    /// </summary>
    public DateTime? ExpiredDate { get => _expiredDate; set => SetField(ref _expiredDate, value); }

    /// <summary>
    /// UnderwritingConditionContract FulfilledBy
    /// </summary>
    [AllowNull]
    public EntityReference FulfilledBy { get => GetField(ref _fulfilledBy); set => SetField(ref _fulfilledBy, value); }

    /// <summary>
    /// UnderwritingConditionContract FulfilledDate
    /// </summary>
    public DateTime? FulfilledDate { get => _fulfilledDate; set => SetField(ref _fulfilledDate, value); }

    /// <summary>
    /// UnderwritingConditionContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// UnderwritingConditionContract IsMarkedRemoved
    /// </summary>
    public bool? IsMarkedRemoved { get => _isMarkedRemoved; set => SetField(ref _isMarkedRemoved, value); }

    /// <summary>
    /// UnderwritingConditionContract IsOwnerAllowedToClear
    /// </summary>
    public bool? IsOwnerAllowedToClear { get => _isOwnerAllowedToClear; set => SetField(ref _isOwnerAllowedToClear, value); }

    /// <summary>
    /// UnderwritingConditionContract Owner
    /// </summary>
    [AllowNull]
    public EntityReference Owner { get => GetField(ref _owner); set => SetField(ref _owner, value); }

    /// <summary>
    /// UnderwritingConditionContract Print
    /// </summary>
    [AllowNull]
    public IList<string?> Print { get => GetField(ref _print); set => SetField(ref _print, value); }

    /// <summary>
    /// UnderwritingConditionContract PriorTo
    /// </summary>
    public string? PriorTo { get => _priorTo; set => SetField(ref _priorTo, value); }

    /// <summary>
    /// UnderwritingConditionContract ReceivedBy
    /// </summary>
    [AllowNull]
    public EntityReference ReceivedBy { get => GetField(ref _receivedBy); set => SetField(ref _receivedBy, value); }

    /// <summary>
    /// UnderwritingConditionContract ReceivedDate
    /// </summary>
    public DateTime? ReceivedDate { get => _receivedDate; set => SetField(ref _receivedDate, value); }

    /// <summary>
    /// UnderwritingConditionContract RejectedBy
    /// </summary>
    [AllowNull]
    public EntityReference RejectedBy { get => GetField(ref _rejectedBy); set => SetField(ref _rejectedBy, value); }

    /// <summary>
    /// UnderwritingConditionContract RejectedDate
    /// </summary>
    public DateTime? RejectedDate { get => _rejectedDate; set => SetField(ref _rejectedDate, value); }

    /// <summary>
    /// UnderwritingConditionContract RequestedBy
    /// </summary>
    [AllowNull]
    public EntityReference RequestedBy { get => GetField(ref _requestedBy); set => SetField(ref _requestedBy, value); }

    /// <summary>
    /// UnderwritingConditionContract RequestedDate
    /// </summary>
    public DateTime? RequestedDate { get => _requestedDate; set => SetField(ref _requestedDate, value); }

    /// <summary>
    /// UnderwritingConditionContract RequestedFrom
    /// </summary>
    public string? RequestedFrom { get => _requestedFrom; set => SetField(ref _requestedFrom, value); }

    /// <summary>
    /// UnderwritingConditionContract RerequestedBy
    /// </summary>
    [AllowNull]
    public EntityReference RerequestedBy { get => GetField(ref _rerequestedBy); set => SetField(ref _rerequestedBy, value); }

    /// <summary>
    /// UnderwritingConditionContract RerequestedDate
    /// </summary>
    public DateTime? RerequestedDate { get => _rerequestedDate; set => SetField(ref _rerequestedDate, value); }

    /// <summary>
    /// UnderwritingConditionContract ReviewedBy
    /// </summary>
    [AllowNull]
    public EntityReference ReviewedBy { get => GetField(ref _reviewedBy); set => SetField(ref _reviewedBy, value); }

    /// <summary>
    /// UnderwritingConditionContract ReviewedDate
    /// </summary>
    public DateTime? ReviewedDate { get => _reviewedDate; set => SetField(ref _reviewedDate, value); }

    /// <summary>
    /// UnderwritingConditionContract Source
    /// </summary>
    public string? Source { get => _source; set => SetField(ref _source, value); }

    /// <summary>
    /// UnderwritingConditionContract Status
    /// </summary>
    public StringEnumValue<ConditionStatus> Status { get => _status; set => SetField(ref _status, value); }

    /// <summary>
    /// UnderwritingConditionContract StatusDate
    /// </summary>
    public DateTime? StatusDate { get => _statusDate; set => SetField(ref _statusDate, value); }

    /// <summary>
    /// UnderwritingConditionContract Title
    /// </summary>
    public string? Title { get => _title; set => SetField(ref _title, value); }

    /// <summary>
    /// UnderwritingConditionContract WaivedBy
    /// </summary>
    [AllowNull]
    public EntityReference WaivedBy { get => GetField(ref _waivedBy); set => SetField(ref _waivedBy, value); }

    /// <summary>
    /// UnderwritingConditionContract WaivedDate
    /// </summary>
    public DateTime? WaivedDate { get => _waivedDate; set => SetField(ref _waivedDate, value); }
}