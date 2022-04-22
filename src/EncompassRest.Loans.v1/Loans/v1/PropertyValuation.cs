using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// PropertyValuation
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class PropertyValuation : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// AVM Complexity Score [PVALNN09]
    /// </summary>
    public string? AvmComplexityScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Confidence Score [PVALNN04]
    /// </summary>
    public string? AvmConfidenceScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Confidence Score Alt [PVALNN05]
    /// </summary>
    public string? AvmConfidenceScoreAlt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM FSD [PVALNN10]
    /// </summary>
    public string? AvmFsd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Product [PVALNN03]
    /// </summary>
    public string? AvmProduct { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Property ID [PVALNN02]
    /// </summary>
    public string? AvmPropertyId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Property Value [PVALNN01]
    /// </summary>
    public string? AvmPropertyValue { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Provider [PVALNN14]
    /// </summary>
    public string? AvmProvider { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Range High [PVALNN07]
    /// </summary>
    public string? AvmRangeHigh { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Range Low [PVALNN06]
    /// </summary>
    public string? AvmRangeLow { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Report Complete Date/Time [PVALNN12]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? AvmReportCompleteDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Report ID [PVALNN11]
    /// </summary>
    public string? AvmReportId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Report Ordered Date/Time [PVALNN13]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? AvmReportOrderedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AVM Retro Date [PVALNN08]
    /// </summary>
    public DateTime? AvmRetroDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PropertyValuation CorrespondentStatus
    /// </summary>
    public string? CorrespondentStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PropertyValuation EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PropertyValuation Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Valuation Order Type [PVALNN16]
    /// </summary>
    public string? OrderType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Valuation Type [PVALNN15]
    /// </summary>
    public string? PropertyValuationType { get => GetValue<string?>(); set => SetValue(value); }
}