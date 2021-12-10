using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// GoodFaithFeeVarianceCureLog
/// </summary>
public sealed partial class GoodFaithFeeVarianceCureLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _alertDate;
    private DirtyValue<decimal?>? _appliedCureAmount;
    private DirtyValue<string?>? _cureComments;
    private DirtyValue<DateTime?>? _dateResolved;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _inLogIndicator;
    private DirtyValue<string?>? _name;
    private EntityReference? _resolvedBy;
    private DirtyValue<decimal?>? _totalVariance;
    private DirtyList<GffvAlertTriggerField>? _triggerFields;

    /// <summary>
    /// GoodFaithFeeVarianceCureLogContract AlertDate
    /// </summary>
    public DateTime? AlertDate { get => _alertDate; set => SetField(ref _alertDate, value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLogContract AppliedCureAmount
    /// </summary>
    public decimal? AppliedCureAmount { get => _appliedCureAmount; set => SetField(ref _appliedCureAmount, value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLogContract CureComments
    /// </summary>
    public string? CureComments { get => _cureComments; set => SetField(ref _cureComments, value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLogContract DateResolved
    /// </summary>
    public DateTime? DateResolved { get => _dateResolved; set => SetField(ref _dateResolved, value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLogContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLogContract InLogIndicator
    /// </summary>
    public bool? InLogIndicator { get => _inLogIndicator; set => SetField(ref _inLogIndicator, value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLogContract Name
    /// </summary>
    public string? Name { get => _name; set => SetField(ref _name, value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLogContract ResolvedBy
    /// </summary>
    [AllowNull]
    public EntityReference ResolvedBy { get => GetField(ref _resolvedBy); set => SetField(ref _resolvedBy, value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLogContract TotalVariance
    /// </summary>
    public decimal? TotalVariance { get => _totalVariance; set => SetField(ref _totalVariance, value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLogContract TriggerFields
    /// </summary>
    [AllowNull]
    public IList<GffvAlertTriggerField> TriggerFields { get => GetField(ref _triggerFields); set => SetField(ref _triggerFields, value); }
}