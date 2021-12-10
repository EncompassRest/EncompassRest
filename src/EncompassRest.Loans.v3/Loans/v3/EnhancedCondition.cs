using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// EnhancedCondition
/// </summary>
public sealed partial class EnhancedCondition : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<int?>? _age;
    private DirtyValue<DateTime?>? _ageClosedDate;
    private DirtyValue<DateTime?>? _ageStartDate;
    private ApplicationReference? _application;
    private DirtyList<EntityReference>? _assignedTo;
    private DirtyValue<string?>? _category;
    private DirtyList<LogComment>? _comments;
    private DirtyValue<int?>? _commentsCount;
    private DirtyValue<string?>? _conditionType;
    private EntityReference? _createdBy;
    private DirtyValue<DateTime?>? _createdDate;
    private DirtyValue<int?>? _daysToReceive;
    private EnhancedConditionDefinition? _definitions;
    private DirtyValue<DateTime?>? _documentReceiptDate;
    private DirtyValue<DateTime?>? _endDate;
    private DirtyValue<string?>? _externalDescription;
    private DirtyValue<string?>? _externalId;
    private DirtyValue<DateTime?>? _externalPrintDate;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _internalDescription;
    private DirtyValue<string?>? _internalId;
    private DirtyValue<bool?>? _isRemoved;
    private EntityReference? _lastModifiedBy;
    private DirtyValue<DateTime?>? _lastModifiedDate;
    private DirtyList<string?>? _printDefinitions;
    private DirtyValue<string?>? _priorTo;
    private DirtyValue<DateTime?>? _publishedDate;
    private DirtyValue<string?>? _recipient;
    private DirtyValue<string?>? _requestedFrom;
    private DirtyValue<string?>? _source;
    private DirtyValue<StringEnumValue<SourceOfCondition>>? _sourceOfCondition;
    private DirtyValue<DateTime?>? _startDate;
    private DirtyValue<string?>? _status;
    private DirtyValue<DateTime?>? _statusDate;
    private DirtyValue<bool?>? _statusOpen;
    private DirtyValue<string?>? _title;
    private DirtyList<TrackingEntry>? _tracking;

    /// <summary>
    /// EnhancedConditionContract Age
    /// </summary>
    public int? Age { get => _age; set => SetField(ref _age, value); }

    /// <summary>
    /// EnhancedConditionContract AgeClosedDate
    /// </summary>
    public DateTime? AgeClosedDate { get => _ageClosedDate; set => SetField(ref _ageClosedDate, value); }

    /// <summary>
    /// EnhancedConditionContract AgeStartDate
    /// </summary>
    public DateTime? AgeStartDate { get => _ageStartDate; set => SetField(ref _ageStartDate, value); }

    /// <summary>
    /// EnhancedConditionContract Application
    /// </summary>
    [AllowNull]
    public ApplicationReference Application { get => GetField(ref _application); set => SetField(ref _application, value); }

    /// <summary>
    /// EnhancedConditionContract AssignedTo
    /// </summary>
    [AllowNull]
    public IList<EntityReference> AssignedTo { get => GetField(ref _assignedTo); set => SetField(ref _assignedTo, value); }

    /// <summary>
    /// EnhancedConditionContract Category
    /// </summary>
    public string? Category { get => _category; set => SetField(ref _category, value); }

    /// <summary>
    /// EnhancedConditionContract Comments
    /// </summary>
    [AllowNull]
    public IList<LogComment> Comments { get => GetField(ref _comments); set => SetField(ref _comments, value); }

    /// <summary>
    /// EnhancedConditionContract CommentsCount
    /// </summary>
    public int? CommentsCount { get => _commentsCount; set => SetField(ref _commentsCount, value); }

    /// <summary>
    /// EnhancedConditionContract ConditionType
    /// </summary>
    public string? ConditionType { get => _conditionType; set => SetField(ref _conditionType, value); }

    /// <summary>
    /// EnhancedConditionContract CreatedBy
    /// </summary>
    [AllowNull]
    public EntityReference CreatedBy { get => GetField(ref _createdBy); set => SetField(ref _createdBy, value); }

    /// <summary>
    /// EnhancedConditionContract CreatedDate
    /// </summary>
    public DateTime? CreatedDate { get => _createdDate; set => SetField(ref _createdDate, value); }

    /// <summary>
    /// EnhancedConditionContract DaysToReceive
    /// </summary>
    public int? DaysToReceive { get => _daysToReceive; set => SetField(ref _daysToReceive, value); }

    /// <summary>
    /// EnhancedConditionContract Definitions
    /// </summary>
    [AllowNull]
    public EnhancedConditionDefinition Definitions { get => GetField(ref _definitions); set => SetField(ref _definitions, value); }

    /// <summary>
    /// EnhancedConditionContract DocumentReceiptDate
    /// </summary>
    public DateTime? DocumentReceiptDate { get => _documentReceiptDate; set => SetField(ref _documentReceiptDate, value); }

    /// <summary>
    /// EnhancedConditionContract EndDate
    /// </summary>
    public DateTime? EndDate { get => _endDate; set => SetField(ref _endDate, value); }

    /// <summary>
    /// EnhancedConditionContract ExternalDescription
    /// </summary>
    public string? ExternalDescription { get => _externalDescription; set => SetField(ref _externalDescription, value); }

    /// <summary>
    /// EnhancedConditionContract ExternalId
    /// </summary>
    public string? ExternalId { get => _externalId; set => SetField(ref _externalId, value); }

    /// <summary>
    /// EnhancedConditionContract ExternalPrintDate
    /// </summary>
    public DateTime? ExternalPrintDate { get => _externalPrintDate; set => SetField(ref _externalPrintDate, value); }

    /// <summary>
    /// EnhancedConditionContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// EnhancedConditionContract InternalDescription
    /// </summary>
    public string? InternalDescription { get => _internalDescription; set => SetField(ref _internalDescription, value); }

    /// <summary>
    /// EnhancedConditionContract InternalId
    /// </summary>
    public string? InternalId { get => _internalId; set => SetField(ref _internalId, value); }

    /// <summary>
    /// EnhancedConditionContract IsRemoved
    /// </summary>
    public bool? IsRemoved { get => _isRemoved; set => SetField(ref _isRemoved, value); }

    /// <summary>
    /// EnhancedConditionContract LastModifiedBy
    /// </summary>
    [AllowNull]
    public EntityReference LastModifiedBy { get => GetField(ref _lastModifiedBy); set => SetField(ref _lastModifiedBy, value); }

    /// <summary>
    /// EnhancedConditionContract LastModifiedDate
    /// </summary>
    public DateTime? LastModifiedDate { get => _lastModifiedDate; set => SetField(ref _lastModifiedDate, value); }

    /// <summary>
    /// EnhancedConditionContract PrintDefinitions
    /// </summary>
    [AllowNull]
    public IList<string?> PrintDefinitions { get => GetField(ref _printDefinitions); set => SetField(ref _printDefinitions, value); }

    /// <summary>
    /// EnhancedConditionContract PriorTo
    /// </summary>
    public string? PriorTo { get => _priorTo; set => SetField(ref _priorTo, value); }

    /// <summary>
    /// EnhancedConditionContract PublishedDate
    /// </summary>
    public DateTime? PublishedDate { get => _publishedDate; set => SetField(ref _publishedDate, value); }

    /// <summary>
    /// EnhancedConditionContract Recipient
    /// </summary>
    public string? Recipient { get => _recipient; set => SetField(ref _recipient, value); }

    /// <summary>
    /// EnhancedConditionContract RequestedFrom
    /// </summary>
    public string? RequestedFrom { get => _requestedFrom; set => SetField(ref _requestedFrom, value); }

    /// <summary>
    /// EnhancedConditionContract Source
    /// </summary>
    public string? Source { get => _source; set => SetField(ref _source, value); }

    /// <summary>
    /// EnhancedConditionContract SourceOfCondition
    /// </summary>
    public StringEnumValue<SourceOfCondition> SourceOfCondition { get => _sourceOfCondition; set => SetField(ref _sourceOfCondition, value); }

    /// <summary>
    /// EnhancedConditionContract StartDate
    /// </summary>
    public DateTime? StartDate { get => _startDate; set => SetField(ref _startDate, value); }

    /// <summary>
    /// EnhancedConditionContract Status
    /// </summary>
    public string? Status { get => _status; set => SetField(ref _status, value); }

    /// <summary>
    /// EnhancedConditionContract StatusDate
    /// </summary>
    public DateTime? StatusDate { get => _statusDate; set => SetField(ref _statusDate, value); }

    /// <summary>
    /// EnhancedConditionContract StatusOpen
    /// </summary>
    public bool? StatusOpen { get => _statusOpen; set => SetField(ref _statusOpen, value); }

    /// <summary>
    /// EnhancedConditionContract Title
    /// </summary>
    public string? Title { get => _title; set => SetField(ref _title, value); }

    /// <summary>
    /// EnhancedConditionContract Tracking
    /// </summary>
    [AllowNull]
    public IList<TrackingEntry> Tracking { get => GetField(ref _tracking); set => SetField(ref _tracking, value); }
}