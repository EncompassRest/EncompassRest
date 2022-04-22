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
    /// <summary>
    /// EnhancedCondition Age
    /// </summary>
    public int? Age { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition AgeClosedDate
    /// </summary>
    public DateTime? AgeClosedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition AgeStartDate
    /// </summary>
    public DateTime? AgeStartDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition Application
    /// </summary>
    [AllowNull]
    public ApplicationReference Application { get => GetEntity<ApplicationReference>(); set => SetEntity(value); }

    /// <summary>
    /// EnhancedCondition AssignedTo
    /// </summary>
    [AllowNull]
    public IList<EntityReference> AssignedTo { get => GetList<EntityReference>(); set => SetList(value); }

    /// <summary>
    /// EnhancedCondition Category
    /// </summary>
    public string? Category { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition Comments
    /// </summary>
    [AllowNull]
    public IList<LogComment> Comments { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// EnhancedCondition CommentsCount
    /// </summary>
    public int? CommentsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition ConditionType
    /// </summary>
    public string? ConditionType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition CreatedBy
    /// </summary>
    [AllowNull]
    public EntityReference CreatedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// EnhancedCondition CreatedDate
    /// </summary>
    public DateTime? CreatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition DaysToReceive
    /// </summary>
    public int? DaysToReceive { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition Definitions
    /// </summary>
    [AllowNull]
    public EnhancedConditionDefinition Definitions { get => GetEntity<EnhancedConditionDefinition>(); set => SetEntity(value); }

    /// <summary>
    /// EnhancedCondition DocumentReceiptDate
    /// </summary>
    public DateTime? DocumentReceiptDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition EndDate
    /// </summary>
    public DateTime? EndDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition ExternalDescription
    /// </summary>
    public string? ExternalDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition ExternalId
    /// </summary>
    public string? ExternalId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition ExternalPrintDate
    /// </summary>
    public DateTime? ExternalPrintDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition InternalDescription
    /// </summary>
    public string? InternalDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition InternalId
    /// </summary>
    public string? InternalId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition IsRemoved
    /// </summary>
    public bool? IsRemoved { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition LastModifiedBy
    /// </summary>
    [AllowNull]
    public EntityReference LastModifiedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// EnhancedCondition LastModifiedDate
    /// </summary>
    public DateTime? LastModifiedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition PrintDefinitions
    /// </summary>
    [AllowNull]
    public IList<string?> PrintDefinitions { get => GetList<string?>(); set => SetList(value); }

    /// <summary>
    /// EnhancedCondition PriorTo
    /// </summary>
    public string? PriorTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition PublishedDate
    /// </summary>
    public DateTime? PublishedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition Recipient
    /// </summary>
    public string? Recipient { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition RequestedFrom
    /// </summary>
    public string? RequestedFrom { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition Source
    /// </summary>
    public string? Source { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition SourceOfCondition
    /// </summary>
    public StringEnumValue<SourceOfCondition> SourceOfCondition { get => GetValue<StringEnumValue<SourceOfCondition>>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition StartDate
    /// </summary>
    public DateTime? StartDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition Status
    /// </summary>
    public string? Status { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition StatusDate
    /// </summary>
    public DateTime? StatusDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition StatusOpen
    /// </summary>
    public bool? StatusOpen { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition Title
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedCondition Tracking
    /// </summary>
    [AllowNull]
    public IList<TrackingEntry> Tracking { get => GetList<TrackingEntry>(); set => SetList(value); }
}