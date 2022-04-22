namespace EncompassRest.Loans.v1;

/// <summary>
/// CustomModelFields
/// </summary>
public sealed partial class CustomModelFields : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// CustomModelFields HelocExampleScheduleData
    /// </summary>
    public string? HelocExampleScheduleData { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CustomModelFields Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CustomModelFields ProvideAmortizationScenario
    /// </summary>
    public bool? ProvideAmortizationScenario { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// CustomModelFields ProvideBestCaseScenario
    /// </summary>
    public bool? ProvideBestCaseScenario { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// CustomModelFields ProvideCpaPaymentSchedule
    /// </summary>
    public bool? ProvideCpaPaymentSchedule { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// CustomModelFields ProvideFHAScenario
    /// </summary>
    public bool? ProvideFHAScenario { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// CustomModelFields ProvideHelocExampleSchedules
    /// </summary>
    public bool? ProvideHelocExampleSchedules { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// CustomModelFields ProvideQmPaymentSchedule
    /// </summary>
    public bool? ProvideQmPaymentSchedule { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// CustomModelFields ProvideWorstCaseScenario
    /// </summary>
    public bool? ProvideWorstCaseScenario { get => GetValue<bool?>(); set => SetValue(value); }
}