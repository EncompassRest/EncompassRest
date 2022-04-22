using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// GoodFaithFeeVarianceCureLog
/// </summary>
public sealed partial class GoodFaithFeeVarianceCureLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// GoodFaithFeeVarianceCureLog AlertDateUtc
    /// </summary>
    public DateTime? AlertDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

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
    public string? ResolvedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLog ResolvedById
    /// </summary>
    public string? ResolvedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GoodFaithFeeVarianceCureLog TotalVariance
    /// </summary>
    public decimal? TotalVariance { get => GetValue<decimal?>(); set => SetValue(value); }
}