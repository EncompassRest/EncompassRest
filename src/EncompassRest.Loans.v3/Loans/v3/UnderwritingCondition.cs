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
    /// <summary>
    /// UnderwritingCondition AddedBy
    /// </summary>
    [AllowNull]
    public EntityReference AddedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// UnderwritingCondition AddedDate
    /// </summary>
    public DateTime? AddedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition BorrowerPair
    /// </summary>
    [AllowNull]
    public EntityReference BorrowerPair { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// UnderwritingCondition Category
    /// </summary>
    public string? Category { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition ClearedBy
    /// </summary>
    [AllowNull]
    public EntityReference ClearedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// UnderwritingCondition ClearedDate
    /// </summary>
    public DateTime? ClearedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition DaysTillDue
    /// </summary>
    public int? DaysTillDue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition ExpectedDate
    /// </summary>
    public DateTime? ExpectedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition ExpiredDate
    /// </summary>
    public DateTime? ExpiredDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition FulfilledBy
    /// </summary>
    [AllowNull]
    public EntityReference FulfilledBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// UnderwritingCondition FulfilledDate
    /// </summary>
    public DateTime? FulfilledDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition IsMarkedRemoved
    /// </summary>
    public bool? IsMarkedRemoved { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition IsOwnerAllowedToClear
    /// </summary>
    public bool? IsOwnerAllowedToClear { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition Owner
    /// </summary>
    [AllowNull]
    public EntityReference Owner { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// UnderwritingCondition Print
    /// </summary>
    [AllowNull]
    public IList<string?> Print { get => GetList<string?>(); set => SetList(value); }

    /// <summary>
    /// UnderwritingCondition PriorTo
    /// </summary>
    public string? PriorTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition ReceivedBy
    /// </summary>
    [AllowNull]
    public EntityReference ReceivedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// UnderwritingCondition ReceivedDate
    /// </summary>
    public DateTime? ReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition RejectedBy
    /// </summary>
    [AllowNull]
    public EntityReference RejectedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// UnderwritingCondition RejectedDate
    /// </summary>
    public DateTime? RejectedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition RequestedBy
    /// </summary>
    [AllowNull]
    public EntityReference RequestedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// UnderwritingCondition RequestedDate
    /// </summary>
    public DateTime? RequestedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition RequestedFrom
    /// </summary>
    public string? RequestedFrom { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition RerequestedBy
    /// </summary>
    [AllowNull]
    public EntityReference RerequestedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// UnderwritingCondition RerequestedDate
    /// </summary>
    public DateTime? RerequestedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition ReviewedBy
    /// </summary>
    [AllowNull]
    public EntityReference ReviewedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// UnderwritingCondition ReviewedDate
    /// </summary>
    public DateTime? ReviewedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition Source
    /// </summary>
    public string? Source { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition Status
    /// </summary>
    public StringEnumValue<ConditionStatus> Status { get => GetValue<StringEnumValue<ConditionStatus>>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition StatusDate
    /// </summary>
    public DateTime? StatusDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition Title
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwritingCondition WaivedBy
    /// </summary>
    [AllowNull]
    public EntityReference WaivedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// UnderwritingCondition WaivedDate
    /// </summary>
    public DateTime? WaivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}