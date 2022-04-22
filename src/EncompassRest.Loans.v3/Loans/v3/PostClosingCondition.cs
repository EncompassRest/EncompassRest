using System;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// PostClosingCondition
/// </summary>
public sealed partial class PostClosingCondition : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PostClosingCondition AddedBy
    /// </summary>
    [AllowNull]
    public EntityReference AddedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// PostClosingCondition AddedDate
    /// </summary>
    public DateTime? AddedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingCondition BorrowerPair
    /// </summary>
    [AllowNull]
    public EntityReference BorrowerPair { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// PostClosingCondition ClearedBy
    /// </summary>
    [AllowNull]
    public EntityReference ClearedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// PostClosingCondition ClearedDate
    /// </summary>
    public DateTime? ClearedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingCondition DaysTillDue
    /// </summary>
    public int? DaysTillDue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingCondition Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingCondition ExpectedDate
    /// </summary>
    public DateTime? ExpectedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingCondition Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingCondition IsMarkedRemoved
    /// </summary>
    public bool? IsMarkedRemoved { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingCondition ReceivedBy
    /// </summary>
    [AllowNull]
    public EntityReference ReceivedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// PostClosingCondition ReceivedDate
    /// </summary>
    public DateTime? ReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingCondition Recipient
    /// </summary>
    public string? Recipient { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingCondition RequestedBy
    /// </summary>
    [AllowNull]
    public EntityReference RequestedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// PostClosingCondition RequestedDate
    /// </summary>
    public DateTime? RequestedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingCondition RequestedFrom
    /// </summary>
    public string? RequestedFrom { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingCondition RerequestedBy
    /// </summary>
    [AllowNull]
    public EntityReference RerequestedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// PostClosingCondition RerequestedDate
    /// </summary>
    public DateTime? RerequestedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingCondition SentBy
    /// </summary>
    [AllowNull]
    public EntityReference SentBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// PostClosingCondition SentDate
    /// </summary>
    public DateTime? SentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingCondition Source
    /// </summary>
    public string? Source { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingCondition Status
    /// </summary>
    public StringEnumValue<ConditionStatus> Status { get => GetValue<StringEnumValue<ConditionStatus>>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingCondition StatusDate
    /// </summary>
    public DateTime? StatusDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PostClosingCondition Title
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }
}