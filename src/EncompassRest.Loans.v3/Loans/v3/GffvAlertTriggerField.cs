namespace EncompassRest.Loans.v3;

/// <summary>
/// GffvAlertTriggerField
/// </summary>
public sealed partial class GffvAlertTriggerField : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// GffvAlertTriggerField Baseline
    /// </summary>
    public string? Baseline { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GffvAlertTriggerField Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GffvAlertTriggerField DisclosedValue
    /// </summary>
    public decimal? DisclosedValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// GffvAlertTriggerField FieldId
    /// </summary>
    public string? FieldId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GffvAlertTriggerField InitialLeValue
    /// </summary>
    public decimal? InitialLeValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// GffvAlertTriggerField ItemizationValue
    /// </summary>
    public decimal? ItemizationValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// GffvAlertTriggerField VarianceLimit
    /// </summary>
    public string? VarianceLimit { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GffvAlertTriggerField VarianceValue
    /// </summary>
    public decimal? VarianceValue { get => GetValue<decimal?>(); set => SetValue(value); }
}