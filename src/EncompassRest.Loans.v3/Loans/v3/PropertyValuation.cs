using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// PropertyValuation
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class PropertyValuation : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// AVM Complexity Score [PVAL0009]
    /// </summary>
    public string? AvmComplexityScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Confidence Score [PVAL0004]
    /// </summary>
    public string? AvmConfidenceScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Confidence Score Alt [PVAL0005]
    /// </summary>
    public string? AvmConfidenceScoreAlt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM FSD [PVAL0010]
    /// </summary>
    public string? AvmFsd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Product [PVAL0003]
    /// </summary>
    public string? AvmProduct { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Property ID [PVAL0002]
    /// </summary>
    public string? AvmPropertyId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Property Value [PVAL0001]
    /// </summary>
    public string? AvmPropertyValue { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Provider [PVAL0014]
    /// </summary>
    public string? AvmProvider { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Range High [PVAL0007]
    /// </summary>
    public string? AvmRangeHigh { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Range Low [PVAL0006]
    /// </summary>
    public string? AvmRangeLow { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Report Complete Date/Time [PVAL0012]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? AvmReportCompleteDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Report ID [PVAL0011]
    /// </summary>
    public string? AvmReportId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Report Ordered Date/Time [PVAL0013]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? AvmReportOrderedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Retro Date [PVAL0008]
    /// </summary>
    public DateTime? AvmRetroDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PropertyValuation Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Valuation Order Type [PVAL0016]
    /// </summary>
    public string? OrderType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Valuation Type [PVAL0015]
    /// </summary>
    public string? PropertyValuationType { get => GetValue<string?>(); set => SetValue(value); }
}