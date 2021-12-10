using System;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// PostClosingCondition
/// </summary>
public sealed partial class PostClosingCondition : DirtyExtensibleObject, IIdentifiable
{
    private EntityReference? _addedBy;
    private DirtyValue<DateTime?>? _addedDate;
    private EntityReference? _borrowerPair;
    private EntityReference? _clearedBy;
    private DirtyValue<DateTime?>? _clearedDate;
    private DirtyValue<int?>? _daysTillDue;
    private DirtyValue<string?>? _description;
    private DirtyValue<DateTime?>? _expectedDate;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _isMarkedRemoved;
    private EntityReference? _receivedBy;
    private DirtyValue<DateTime?>? _receivedDate;
    private DirtyValue<string?>? _recipient;
    private EntityReference? _requestedBy;
    private DirtyValue<DateTime?>? _requestedDate;
    private DirtyValue<string?>? _requestedFrom;
    private EntityReference? _rerequestedBy;
    private DirtyValue<DateTime?>? _rerequestedDate;
    private EntityReference? _sentBy;
    private DirtyValue<DateTime?>? _sentDate;
    private DirtyValue<string?>? _source;
    private DirtyValue<StringEnumValue<ConditionStatus>>? _status;
    private DirtyValue<DateTime?>? _statusDate;
    private DirtyValue<string?>? _title;

    /// <summary>
    /// PostClosingConditionContract AddedBy
    /// </summary>
    [AllowNull]
    public EntityReference AddedBy { get => GetField(ref _addedBy); set => SetField(ref _addedBy, value); }

    /// <summary>
    /// PostClosingConditionContract AddedDate
    /// </summary>
    public DateTime? AddedDate { get => _addedDate; set => SetField(ref _addedDate, value); }

    /// <summary>
    /// PostClosingConditionContract BorrowerPair
    /// </summary>
    [AllowNull]
    public EntityReference BorrowerPair { get => GetField(ref _borrowerPair); set => SetField(ref _borrowerPair, value); }

    /// <summary>
    /// PostClosingConditionContract ClearedBy
    /// </summary>
    [AllowNull]
    public EntityReference ClearedBy { get => GetField(ref _clearedBy); set => SetField(ref _clearedBy, value); }

    /// <summary>
    /// PostClosingConditionContract ClearedDate
    /// </summary>
    public DateTime? ClearedDate { get => _clearedDate; set => SetField(ref _clearedDate, value); }

    /// <summary>
    /// PostClosingConditionContract DaysTillDue
    /// </summary>
    public int? DaysTillDue { get => _daysTillDue; set => SetField(ref _daysTillDue, value); }

    /// <summary>
    /// PostClosingConditionContract Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// PostClosingConditionContract ExpectedDate
    /// </summary>
    public DateTime? ExpectedDate { get => _expectedDate; set => SetField(ref _expectedDate, value); }

    /// <summary>
    /// PostClosingConditionContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// PostClosingConditionContract IsMarkedRemoved
    /// </summary>
    public bool? IsMarkedRemoved { get => _isMarkedRemoved; set => SetField(ref _isMarkedRemoved, value); }

    /// <summary>
    /// PostClosingConditionContract ReceivedBy
    /// </summary>
    [AllowNull]
    public EntityReference ReceivedBy { get => GetField(ref _receivedBy); set => SetField(ref _receivedBy, value); }

    /// <summary>
    /// PostClosingConditionContract ReceivedDate
    /// </summary>
    public DateTime? ReceivedDate { get => _receivedDate; set => SetField(ref _receivedDate, value); }

    /// <summary>
    /// PostClosingConditionContract Recipient
    /// </summary>
    public string? Recipient { get => _recipient; set => SetField(ref _recipient, value); }

    /// <summary>
    /// PostClosingConditionContract RequestedBy
    /// </summary>
    [AllowNull]
    public EntityReference RequestedBy { get => GetField(ref _requestedBy); set => SetField(ref _requestedBy, value); }

    /// <summary>
    /// PostClosingConditionContract RequestedDate
    /// </summary>
    public DateTime? RequestedDate { get => _requestedDate; set => SetField(ref _requestedDate, value); }

    /// <summary>
    /// PostClosingConditionContract RequestedFrom
    /// </summary>
    public string? RequestedFrom { get => _requestedFrom; set => SetField(ref _requestedFrom, value); }

    /// <summary>
    /// PostClosingConditionContract RerequestedBy
    /// </summary>
    [AllowNull]
    public EntityReference RerequestedBy { get => GetField(ref _rerequestedBy); set => SetField(ref _rerequestedBy, value); }

    /// <summary>
    /// PostClosingConditionContract RerequestedDate
    /// </summary>
    public DateTime? RerequestedDate { get => _rerequestedDate; set => SetField(ref _rerequestedDate, value); }

    /// <summary>
    /// PostClosingConditionContract SentBy
    /// </summary>
    [AllowNull]
    public EntityReference SentBy { get => GetField(ref _sentBy); set => SetField(ref _sentBy, value); }

    /// <summary>
    /// PostClosingConditionContract SentDate
    /// </summary>
    public DateTime? SentDate { get => _sentDate; set => SetField(ref _sentDate, value); }

    /// <summary>
    /// PostClosingConditionContract Source
    /// </summary>
    public string? Source { get => _source; set => SetField(ref _source, value); }

    /// <summary>
    /// PostClosingConditionContract Status
    /// </summary>
    public StringEnumValue<ConditionStatus> Status { get => _status; set => SetField(ref _status, value); }

    /// <summary>
    /// PostClosingConditionContract StatusDate
    /// </summary>
    public DateTime? StatusDate { get => _statusDate; set => SetField(ref _statusDate, value); }

    /// <summary>
    /// PostClosingConditionContract Title
    /// </summary>
    public string? Title { get => _title; set => SetField(ref _title, value); }
}