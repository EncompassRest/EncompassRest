using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// GoodFaithFeeVarianceCureLog
/// </summary>
public sealed partial class GoodFaithFeeVarianceCureLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// GoodFaithFeeVarianceCureLog AlertDate
    /// </summary>
    public DateTime? AlertDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLog AppliedCureAmount
    /// </summary>
    public decimal? AppliedCureAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLog CureComments
    /// </summary>
    public string? CureComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLog DateResolved
    /// </summary>
    public DateTime? DateResolved { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLog InLogIndicator
    /// </summary>
    public bool? InLogIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLog Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLog ResolvedBy
    /// </summary>
    [AllowNull]
    public EntityReference ResolvedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLog TotalVariance
    /// </summary>
    public decimal? TotalVariance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLog TriggerFields
    /// </summary>
    [AllowNull]
    public IList<GffvAlertTriggerField> TriggerFields { get => GetList<GffvAlertTriggerField>(); set => SetList(value); }
}