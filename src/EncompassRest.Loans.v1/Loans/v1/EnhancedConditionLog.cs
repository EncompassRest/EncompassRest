using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// EnhancedConditionLog
/// </summary>
public sealed partial class EnhancedConditionLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<int?>? _age;
    private DirtyValue<DateTime?>? _ageClosedDate;
    private DirtyValue<DateTime?>? _ageStartDate;
    private DirtyValue<EntityReference?>? _application;
    private DirtyList<EntityReference>? _assignedTo;
    private DirtyValue<string?>? _category;
    private DirtyList<LogComment>? _commentList;
    private DirtyValue<int?>? _commentsCount;
    private DirtyValue<string?>? _conditionType;
    private DirtyValue<EntityReference?>? _createdBy;
    private DirtyValue<DateTime?>? _createdDate;
    private DirtyValue<int?>? _daysToReceive;
    private DirtyValue<EnhancedConditionDefinition?>? _definitions;
    private DirtyValue<DateTime?>? _documentReceiptDate;
    private DirtyValue<DateTime?>? _endDate;
    private DirtyValue<string?>? _externalDescription;
    private DirtyValue<string?>? _externalId;
    private DirtyValue<bool?>? _externalPrint;
    private DirtyValue<DateTime?>? _externalPrintDate;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _internalDescription;
    private DirtyValue<string?>? _internalId;
    private DirtyValue<bool?>? _internalPrint;
    private DirtyValue<bool?>? _isRemoved;
    private DirtyValue<EntityReference?>? _lastModifiedBy;
    private DirtyValue<DateTime?>? _lastModifiedDate;
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
    private DirtyList<TrackingEntryLog>? _tracking;

    /// <summary>
    /// EnhancedConditionLog Age
    /// </summary>
    public int? Age { get => _age; set => SetField(ref _age, value); }

    /// <summary>
    /// EnhancedConditionLog AgeClosedDate
    /// </summary>
    public DateTime? AgeClosedDate { get => _ageClosedDate; set => SetField(ref _ageClosedDate, value); }

    /// <summary>
    /// EnhancedConditionLog AgeStartDate
    /// </summary>
    public DateTime? AgeStartDate { get => _ageStartDate; set => SetField(ref _ageStartDate, value); }

    /// <summary>
    /// EnhancedConditionLog Application
    /// </summary>
    public EntityReference? Application { get => _application; set => SetField(ref _application, value); }

    /// <summary>
    /// EnhancedConditionLog AssignedTo
    /// </summary>
    [AllowNull]
    public IList<EntityReference> AssignedTo { get => GetField(ref _assignedTo); set => SetField(ref _assignedTo, value); }

    /// <summary>
    /// EnhancedConditionLog Category
    /// </summary>
    public string? Category { get => _category; set => SetField(ref _category, value); }

    /// <summary>
    /// EnhancedConditionLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

    /// <summary>
    /// EnhancedConditionLog CommentsCount
    /// </summary>
    public int? CommentsCount { get => _commentsCount; set => SetField(ref _commentsCount, value); }

    /// <summary>
    /// EnhancedConditionLog ConditionType
    /// </summary>
    public string? ConditionType { get => _conditionType; set => SetField(ref _conditionType, value); }

    /// <summary>
    /// EnhancedConditionLog CreatedBy
    /// </summary>
    public EntityReference? CreatedBy { get => _createdBy; set => SetField(ref _createdBy, value); }

    /// <summary>
    /// EnhancedConditionLog CreatedDate
    /// </summary>
    public DateTime? CreatedDate { get => _createdDate; set => SetField(ref _createdDate, value); }

    /// <summary>
    /// EnhancedConditionLog DaysToReceive
    /// </summary>
    public int? DaysToReceive { get => _daysToReceive; set => SetField(ref _daysToReceive, value); }

    /// <summary>
    /// EnhancedConditionLog Definitions
    /// </summary>
    public EnhancedConditionDefinition? Definitions { get => _definitions; set => SetField(ref _definitions, value); }

    /// <summary>
    /// EnhancedConditionLog DocumentReceiptDate
    /// </summary>
    public DateTime? DocumentReceiptDate { get => _documentReceiptDate; set => SetField(ref _documentReceiptDate, value); }

    /// <summary>
    /// EnhancedConditionLog EndDate
    /// </summary>
    public DateTime? EndDate { get => _endDate; set => SetField(ref _endDate, value); }

    /// <summary>
    /// EnhancedConditionLog ExternalDescription
    /// </summary>
    public string? ExternalDescription { get => _externalDescription; set => SetField(ref _externalDescription, value); }

    /// <summary>
    /// EnhancedConditionLog ExternalId
    /// </summary>
    public string? ExternalId { get => _externalId; set => SetField(ref _externalId, value); }

    /// <summary>
    /// EnhancedConditionLog ExternalPrint
    /// </summary>
    public bool? ExternalPrint { get => _externalPrint; set => SetField(ref _externalPrint, value); }

    /// <summary>
    /// EnhancedConditionLog ExternalPrintDate
    /// </summary>
    public DateTime? ExternalPrintDate { get => _externalPrintDate; set => SetField(ref _externalPrintDate, value); }

    /// <summary>
    /// EnhancedConditionLog Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// EnhancedConditionLog InternalDescription
    /// </summary>
    public string? InternalDescription { get => _internalDescription; set => SetField(ref _internalDescription, value); }

    /// <summary>
    /// EnhancedConditionLog InternalId
    /// </summary>
    public string? InternalId { get => _internalId; set => SetField(ref _internalId, value); }

    /// <summary>
    /// EnhancedConditionLog InternalPrint
    /// </summary>
    public bool? InternalPrint { get => _internalPrint; set => SetField(ref _internalPrint, value); }

    /// <summary>
    /// EnhancedConditionLog IsRemoved
    /// </summary>
    public bool? IsRemoved { get => _isRemoved; set => SetField(ref _isRemoved, value); }

    /// <summary>
    /// EnhancedConditionLog LastModifiedBy
    /// </summary>
    public EntityReference? LastModifiedBy { get => _lastModifiedBy; set => SetField(ref _lastModifiedBy, value); }

    /// <summary>
    /// EnhancedConditionLog LastModifiedDate
    /// </summary>
    public DateTime? LastModifiedDate { get => _lastModifiedDate; set => SetField(ref _lastModifiedDate, value); }

    /// <summary>
    /// EnhancedConditionLog PriorTo
    /// </summary>
    public string? PriorTo { get => _priorTo; set => SetField(ref _priorTo, value); }

    /// <summary>
    /// EnhancedConditionLog PublishedDate
    /// </summary>
    public DateTime? PublishedDate { get => _publishedDate; set => SetField(ref _publishedDate, value); }

    /// <summary>
    /// EnhancedConditionLog Recipient
    /// </summary>
    public string? Recipient { get => _recipient; set => SetField(ref _recipient, value); }

    /// <summary>
    /// EnhancedConditionLog RequestedFrom
    /// </summary>
    public string? RequestedFrom { get => _requestedFrom; set => SetField(ref _requestedFrom, value); }

    /// <summary>
    /// EnhancedConditionLog Source
    /// </summary>
    public string? Source { get => _source; set => SetField(ref _source, value); }

    /// <summary>
    /// EnhancedConditionLog SourceOfCondition
    /// </summary>
    public StringEnumValue<SourceOfCondition> SourceOfCondition { get => _sourceOfCondition; set => SetField(ref _sourceOfCondition, value); }

    /// <summary>
    /// EnhancedConditionLog StartDate
    /// </summary>
    public DateTime? StartDate { get => _startDate; set => SetField(ref _startDate, value); }

    /// <summary>
    /// EnhancedConditionLog Status
    /// </summary>
    public string? Status { get => _status; set => SetField(ref _status, value); }

    /// <summary>
    /// EnhancedConditionLog StatusDate
    /// </summary>
    public DateTime? StatusDate { get => _statusDate; set => SetField(ref _statusDate, value); }

    /// <summary>
    /// EnhancedConditionLog StatusOpen
    /// </summary>
    public bool? StatusOpen { get => _statusOpen; set => SetField(ref _statusOpen, value); }

    /// <summary>
    /// EnhancedConditionLog Title
    /// </summary>
    public string? Title { get => _title; set => SetField(ref _title, value); }

    /// <summary>
    /// EnhancedConditionLog Tracking
    /// </summary>
    [AllowNull]
    public IList<TrackingEntryLog> Tracking { get => GetField(ref _tracking); set => SetField(ref _tracking, value); }
}