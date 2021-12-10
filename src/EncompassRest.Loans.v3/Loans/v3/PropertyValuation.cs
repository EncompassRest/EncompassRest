using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// PropertyValuation
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class PropertyValuation : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _avmComplexityScore;
    private DirtyValue<string?>? _avmConfidenceScore;
    private DirtyValue<string?>? _avmConfidenceScoreAlt;
    private DirtyValue<string?>? _avmFsd;
    private DirtyValue<string?>? _avmProduct;
    private DirtyValue<string?>? _avmPropertyId;
    private DirtyValue<string?>? _avmPropertyValue;
    private DirtyValue<string?>? _avmProvider;
    private DirtyValue<string?>? _avmRangeHigh;
    private DirtyValue<string?>? _avmRangeLow;
    private DirtyValue<DateTime?>? _avmReportCompleteDate;
    private DirtyValue<string?>? _avmReportId;
    private DirtyValue<DateTime?>? _avmReportOrderedDate;
    private DirtyValue<DateTime?>? _avmRetroDate;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _orderType;
    private DirtyValue<string?>? _propertyValuationType;

    /// <summary>
    /// AVM Complexity Score [PVAL0009]
    /// </summary>
    public string? AvmComplexityScore { get => _avmComplexityScore; set => SetField(ref _avmComplexityScore, value); }

    /// <summary>
    /// AVM Confidence Score [PVAL0004]
    /// </summary>
    public string? AvmConfidenceScore { get => _avmConfidenceScore; set => SetField(ref _avmConfidenceScore, value); }

    /// <summary>
    /// AVM Confidence Score Alt [PVAL0005]
    /// </summary>
    public string? AvmConfidenceScoreAlt { get => _avmConfidenceScoreAlt; set => SetField(ref _avmConfidenceScoreAlt, value); }

    /// <summary>
    /// AVM FSD [PVAL0010]
    /// </summary>
    public string? AvmFsd { get => _avmFsd; set => SetField(ref _avmFsd, value); }

    /// <summary>
    /// AVM Product [PVAL0003]
    /// </summary>
    public string? AvmProduct { get => _avmProduct; set => SetField(ref _avmProduct, value); }

    /// <summary>
    /// AVM Property ID [PVAL0002]
    /// </summary>
    public string? AvmPropertyId { get => _avmPropertyId; set => SetField(ref _avmPropertyId, value); }

    /// <summary>
    /// AVM Property Value [PVAL0001]
    /// </summary>
    public string? AvmPropertyValue { get => _avmPropertyValue; set => SetField(ref _avmPropertyValue, value); }

    /// <summary>
    /// AVM Provider [PVAL0014]
    /// </summary>
    public string? AvmProvider { get => _avmProvider; set => SetField(ref _avmProvider, value); }

    /// <summary>
    /// AVM Range High [PVAL0007]
    /// </summary>
    public string? AvmRangeHigh { get => _avmRangeHigh; set => SetField(ref _avmRangeHigh, value); }

    /// <summary>
    /// AVM Range Low [PVAL0006]
    /// </summary>
    public string? AvmRangeLow { get => _avmRangeLow; set => SetField(ref _avmRangeLow, value); }

    /// <summary>
    /// AVM Report Complete Date/Time [PVAL0012]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? AvmReportCompleteDate { get => _avmReportCompleteDate; set => SetField(ref _avmReportCompleteDate, value); }

    /// <summary>
    /// AVM Report ID [PVAL0011]
    /// </summary>
    public string? AvmReportId { get => _avmReportId; set => SetField(ref _avmReportId, value); }

    /// <summary>
    /// AVM Report Ordered Date/Time [PVAL0013]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? AvmReportOrderedDate { get => _avmReportOrderedDate; set => SetField(ref _avmReportOrderedDate, value); }

    /// <summary>
    /// AVM Retro Date [PVAL0008]
    /// </summary>
    public DateTime? AvmRetroDate { get => _avmRetroDate; set => SetField(ref _avmRetroDate, value); }

    /// <summary>
    /// PropertyValuationContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Property Valuation Order Type [PVAL0016]
    /// </summary>
    public string? OrderType { get => _orderType; set => SetField(ref _orderType, value); }

    /// <summary>
    /// Property Valuation Type [PVAL0015]
    /// </summary>
    public string? PropertyValuationType { get => _propertyValuationType; set => SetField(ref _propertyValuationType, value); }
}