using System;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// PreliminaryCondition
/// </summary>
public sealed partial class PreliminaryCondition : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PreliminaryCondition AddedBy
    /// </summary>
    [AllowNull]
    public EntityReference AddedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// PreliminaryCondition AddedDate
    /// </summary>
    public DateTime? AddedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryCondition AllowUnderwriterAccess
    /// </summary>
    public bool? AllowUnderwriterAccess { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryCondition BorrowerPair
    /// </summary>
    [AllowNull]
    public EntityReference BorrowerPair { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// PreliminaryCondition Category
    /// </summary>
    public string? Category { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryCondition DaysTillDue
    /// </summary>
    public int? DaysTillDue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryCondition Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryCondition ExpectedDate
    /// </summary>
    public DateTime? ExpectedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryCondition FulfilledBy
    /// </summary>
    [AllowNull]
    public EntityReference FulfilledBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// PreliminaryCondition FulfilledDate
    /// </summary>
    public DateTime? FulfilledDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryCondition Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryCondition IsMarkedRemoved
    /// </summary>
    public bool? IsMarkedRemoved { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryCondition PriorTo
    /// </summary>
    public string? PriorTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryCondition ReceivedBy
    /// </summary>
    [AllowNull]
    public EntityReference ReceivedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// PreliminaryCondition ReceivedDate
    /// </summary>
    public DateTime? ReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryCondition RequestedBy
    /// </summary>
    [AllowNull]
    public EntityReference RequestedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// PreliminaryCondition RequestedDate
    /// </summary>
    public DateTime? RequestedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryCondition RequestedFrom
    /// </summary>
    public string? RequestedFrom { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryCondition RerequestedBy
    /// </summary>
    [AllowNull]
    public EntityReference RerequestedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// PreliminaryCondition RerequestedDate
    /// </summary>
    public DateTime? RerequestedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryCondition Source
    /// </summary>
    public string? Source { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryCondition Status
    /// </summary>
    public StringEnumValue<ConditionStatus> Status { get => GetValue<StringEnumValue<ConditionStatus>>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryCondition StatusDate
    /// </summary>
    public DateTime? StatusDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PreliminaryCondition Title
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }
}