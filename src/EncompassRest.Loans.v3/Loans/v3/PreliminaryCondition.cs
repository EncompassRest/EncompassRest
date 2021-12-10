using System;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// PreliminaryCondition
/// </summary>
public sealed partial class PreliminaryCondition : DirtyExtensibleObject, IIdentifiable
{
    private EntityReference? _addedBy;
    private DirtyValue<DateTime?>? _addedDate;
    private DirtyValue<bool?>? _allowUnderwriterAccess;
    private EntityReference? _borrowerPair;
    private DirtyValue<string?>? _category;
    private DirtyValue<int?>? _daysTillDue;
    private DirtyValue<string?>? _description;
    private DirtyValue<DateTime?>? _expectedDate;
    private EntityReference? _fulfilledBy;
    private DirtyValue<DateTime?>? _fulfilledDate;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _isMarkedRemoved;
    private DirtyValue<string?>? _priorTo;
    private EntityReference? _receivedBy;
    private DirtyValue<DateTime?>? _receivedDate;
    private EntityReference? _requestedBy;
    private DirtyValue<DateTime?>? _requestedDate;
    private DirtyValue<string?>? _requestedFrom;
    private EntityReference? _rerequestedBy;
    private DirtyValue<DateTime?>? _rerequestedDate;
    private DirtyValue<string?>? _source;
    private DirtyValue<StringEnumValue<ConditionStatus>>? _status;
    private DirtyValue<DateTime?>? _statusDate;
    private DirtyValue<string?>? _title;

    /// <summary>
    /// PreliminaryConditionContract AddedBy
    /// </summary>
    [AllowNull]
    public EntityReference AddedBy { get => GetField(ref _addedBy); set => SetField(ref _addedBy, value); }

    /// <summary>
    /// PreliminaryConditionContract AddedDate
    /// </summary>
    public DateTime? AddedDate { get => _addedDate; set => SetField(ref _addedDate, value); }

    /// <summary>
    /// PreliminaryConditionContract AllowUnderwriterAccess
    /// </summary>
    public bool? AllowUnderwriterAccess { get => _allowUnderwriterAccess; set => SetField(ref _allowUnderwriterAccess, value); }

    /// <summary>
    /// PreliminaryConditionContract BorrowerPair
    /// </summary>
    [AllowNull]
    public EntityReference BorrowerPair { get => GetField(ref _borrowerPair); set => SetField(ref _borrowerPair, value); }

    /// <summary>
    /// PreliminaryConditionContract Category
    /// </summary>
    public string? Category { get => _category; set => SetField(ref _category, value); }

    /// <summary>
    /// PreliminaryConditionContract DaysTillDue
    /// </summary>
    public int? DaysTillDue { get => _daysTillDue; set => SetField(ref _daysTillDue, value); }

    /// <summary>
    /// PreliminaryConditionContract Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// PreliminaryConditionContract ExpectedDate
    /// </summary>
    public DateTime? ExpectedDate { get => _expectedDate; set => SetField(ref _expectedDate, value); }

    /// <summary>
    /// PreliminaryConditionContract FulfilledBy
    /// </summary>
    [AllowNull]
    public EntityReference FulfilledBy { get => GetField(ref _fulfilledBy); set => SetField(ref _fulfilledBy, value); }

    /// <summary>
    /// PreliminaryConditionContract FulfilledDate
    /// </summary>
    public DateTime? FulfilledDate { get => _fulfilledDate; set => SetField(ref _fulfilledDate, value); }

    /// <summary>
    /// PreliminaryConditionContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// PreliminaryConditionContract IsMarkedRemoved
    /// </summary>
    public bool? IsMarkedRemoved { get => _isMarkedRemoved; set => SetField(ref _isMarkedRemoved, value); }

    /// <summary>
    /// PreliminaryConditionContract PriorTo
    /// </summary>
    public string? PriorTo { get => _priorTo; set => SetField(ref _priorTo, value); }

    /// <summary>
    /// PreliminaryConditionContract ReceivedBy
    /// </summary>
    [AllowNull]
    public EntityReference ReceivedBy { get => GetField(ref _receivedBy); set => SetField(ref _receivedBy, value); }

    /// <summary>
    /// PreliminaryConditionContract ReceivedDate
    /// </summary>
    public DateTime? ReceivedDate { get => _receivedDate; set => SetField(ref _receivedDate, value); }

    /// <summary>
    /// PreliminaryConditionContract RequestedBy
    /// </summary>
    [AllowNull]
    public EntityReference RequestedBy { get => GetField(ref _requestedBy); set => SetField(ref _requestedBy, value); }

    /// <summary>
    /// PreliminaryConditionContract RequestedDate
    /// </summary>
    public DateTime? RequestedDate { get => _requestedDate; set => SetField(ref _requestedDate, value); }

    /// <summary>
    /// PreliminaryConditionContract RequestedFrom
    /// </summary>
    public string? RequestedFrom { get => _requestedFrom; set => SetField(ref _requestedFrom, value); }

    /// <summary>
    /// PreliminaryConditionContract RerequestedBy
    /// </summary>
    [AllowNull]
    public EntityReference RerequestedBy { get => GetField(ref _rerequestedBy); set => SetField(ref _rerequestedBy, value); }

    /// <summary>
    /// PreliminaryConditionContract RerequestedDate
    /// </summary>
    public DateTime? RerequestedDate { get => _rerequestedDate; set => SetField(ref _rerequestedDate, value); }

    /// <summary>
    /// PreliminaryConditionContract Source
    /// </summary>
    public string? Source { get => _source; set => SetField(ref _source, value); }

    /// <summary>
    /// PreliminaryConditionContract Status
    /// </summary>
    public StringEnumValue<ConditionStatus> Status { get => _status; set => SetField(ref _status, value); }

    /// <summary>
    /// PreliminaryConditionContract StatusDate
    /// </summary>
    public DateTime? StatusDate { get => _statusDate; set => SetField(ref _statusDate, value); }

    /// <summary>
    /// PreliminaryConditionContract Title
    /// </summary>
    public string? Title { get => _title; set => SetField(ref _title, value); }
}