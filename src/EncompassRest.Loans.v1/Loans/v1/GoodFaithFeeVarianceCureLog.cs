using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// GoodFaithFeeVarianceCureLog
/// </summary>
public sealed partial class GoodFaithFeeVarianceCureLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _alertDateUtc;
    private DirtyValue<decimal?>? _appliedCureAmount;
    private DirtyValue<string?>? _cureComments;
    private DirtyValue<DateTime?>? _dateResolved;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _inLogIndicator;
    private DirtyValue<string?>? _name;
    private DirtyValue<string?>? _resolvedBy;
    private DirtyValue<string?>? _resolvedById;
    private DirtyValue<decimal?>? _totalVariance;

    /// <summary>
    /// GoodFaithFeeVarianceCureLog AlertDateUtc
    /// </summary>
    public DateTime? AlertDateUtc { get => _alertDateUtc; set => SetField(ref _alertDateUtc, value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLog AppliedCureAmount
    /// </summary>
    public decimal? AppliedCureAmount { get => _appliedCureAmount; set => SetField(ref _appliedCureAmount, value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLog CureComments
    /// </summary>
    public string? CureComments { get => _cureComments; set => SetField(ref _cureComments, value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLog DateResolved
    /// </summary>
    public DateTime? DateResolved { get => _dateResolved; set => SetField(ref _dateResolved, value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLog Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLog InLogIndicator
    /// </summary>
    public bool? InLogIndicator { get => _inLogIndicator; set => SetField(ref _inLogIndicator, value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLog Name
    /// </summary>
    public string? Name { get => _name; set => SetField(ref _name, value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLog ResolvedBy
    /// </summary>
    public string? ResolvedBy { get => _resolvedBy; set => SetField(ref _resolvedBy, value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLog ResolvedById
    /// </summary>
    public string? ResolvedById { get => _resolvedById; set => SetField(ref _resolvedById, value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLog TotalVariance
    /// </summary>
    public decimal? TotalVariance { get => _totalVariance; set => SetField(ref _totalVariance, value); }
}