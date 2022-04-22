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
    /// <summary>
    /// EnhancedConditionLog Age
    /// </summary>
    public int? Age { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog AgeClosedDate
    /// </summary>
    public DateTime? AgeClosedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog AgeStartDate
    /// </summary>
    public DateTime? AgeStartDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog Application
    /// </summary>
    public EntityReference? Application { get => GetValue<EntityReference?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog AssignedTo
    /// </summary>
    [AllowNull]
    public IList<EntityReference> AssignedTo { get => GetList<EntityReference>(); set => SetList(value); }

    /// <summary>
    /// EnhancedConditionLog Category
    /// </summary>
    public string? Category { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// EnhancedConditionLog CommentsCount
    /// </summary>
    public int? CommentsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog ConditionType
    /// </summary>
    public string? ConditionType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog CreatedBy
    /// </summary>
    public EntityReference? CreatedBy { get => GetValue<EntityReference?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog CreatedDate
    /// </summary>
    public DateTime? CreatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog DaysToReceive
    /// </summary>
    public int? DaysToReceive { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog Definitions
    /// </summary>
    public EnhancedConditionDefinition? Definitions { get => GetValue<EnhancedConditionDefinition?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog DocumentReceiptDate
    /// </summary>
    public DateTime? DocumentReceiptDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog EndDate
    /// </summary>
    public DateTime? EndDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog ExternalDescription
    /// </summary>
    public string? ExternalDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog ExternalId
    /// </summary>
    public string? ExternalId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog ExternalPrint
    /// </summary>
    public bool? ExternalPrint { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog ExternalPrintDate
    /// </summary>
    public DateTime? ExternalPrintDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog InternalDescription
    /// </summary>
    public string? InternalDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog InternalId
    /// </summary>
    public string? InternalId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog InternalPrint
    /// </summary>
    public bool? InternalPrint { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog IsRemoved
    /// </summary>
    public bool? IsRemoved { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog LastModifiedBy
    /// </summary>
    public EntityReference? LastModifiedBy { get => GetValue<EntityReference?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog LastModifiedDate
    /// </summary>
    public DateTime? LastModifiedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog PriorTo
    /// </summary>
    public string? PriorTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog PublishedDate
    /// </summary>
    public DateTime? PublishedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog Recipient
    /// </summary>
    public string? Recipient { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog RequestedFrom
    /// </summary>
    public string? RequestedFrom { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog Source
    /// </summary>
    public string? Source { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog SourceOfCondition
    /// </summary>
    public StringEnumValue<SourceOfCondition> SourceOfCondition { get => GetValue<StringEnumValue<SourceOfCondition>>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog StartDate
    /// </summary>
    public DateTime? StartDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog Status
    /// </summary>
    public string? Status { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog StatusDate
    /// </summary>
    public DateTime? StatusDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog StatusOpen
    /// </summary>
    public bool? StatusOpen { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog Title
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedConditionLog Tracking
    /// </summary>
    [AllowNull]
    public IList<TrackingEntryLog> Tracking { get => GetList<TrackingEntryLog>(); set => SetList(value); }
}