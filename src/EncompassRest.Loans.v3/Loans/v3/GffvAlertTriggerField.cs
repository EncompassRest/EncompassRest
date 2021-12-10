namespace EncompassRest.Loans.v3;

/// <summary>
/// GffvAlertTriggerField
/// </summary>
public sealed partial class GffvAlertTriggerField : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _baseline;
    private DirtyValue<string?>? _description;
    private DirtyValue<decimal?>? _disclosedValue;
    private DirtyValue<string?>? _fieldId;
    private DirtyValue<decimal?>? _initialLeValue;
    private DirtyValue<decimal?>? _itemizationValue;
    private DirtyValue<string?>? _varianceLimit;
    private DirtyValue<decimal?>? _varianceValue;

    /// <summary>
    /// GffvAlertTriggerFieldContract Baseline
    /// </summary>
    public string? Baseline { get => _baseline; set => SetField(ref _baseline, value); }

    /// <summary>
    /// GffvAlertTriggerFieldContract Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// GffvAlertTriggerFieldContract DisclosedValue
    /// </summary>
    public decimal? DisclosedValue { get => _disclosedValue; set => SetField(ref _disclosedValue, value); }

    /// <summary>
    /// GffvAlertTriggerFieldContract FieldId
    /// </summary>
    public string? FieldId { get => _fieldId; set => SetField(ref _fieldId, value); }

    /// <summary>
    /// GffvAlertTriggerFieldContract InitialLeValue
    /// </summary>
    public decimal? InitialLeValue { get => _initialLeValue; set => SetField(ref _initialLeValue, value); }

    /// <summary>
    /// GffvAlertTriggerFieldContract ItemizationValue
    /// </summary>
    public decimal? ItemizationValue { get => _itemizationValue; set => SetField(ref _itemizationValue, value); }

    /// <summary>
    /// GffvAlertTriggerFieldContract VarianceLimit
    /// </summary>
    public string? VarianceLimit { get => _varianceLimit; set => SetField(ref _varianceLimit, value); }

    /// <summary>
    /// GffvAlertTriggerFieldContract VarianceValue
    /// </summary>
    public decimal? VarianceValue { get => _varianceValue; set => SetField(ref _varianceValue, value); }
}