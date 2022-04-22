using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// CustomModelFields
/// </summary>
public sealed partial class CustomModelFields : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// CustomModelFields CpaPaymentSchedule
    /// </summary>
    [AllowNull]
    public IList<object?> CpaPaymentSchedule { get => GetList<object?>(); set => SetList(value); }

    /// <summary>
    /// CustomModelFields HelocHistoricalPaymentSchedule
    /// </summary>
    [AllowNull]
    public IList<object?> HelocHistoricalPaymentSchedule { get => GetList<object?>(); set => SetList(value); }

    /// <summary>
    /// CustomModelFields HelocMaximumPaymentSchedule
    /// </summary>
    [AllowNull]
    public IList<object?> HelocMaximumPaymentSchedule { get => GetList<object?>(); set => SetList(value); }

    /// <summary>
    /// CustomModelFields HelocMaximumScheduleOnFullLoanAmount
    /// </summary>
    [AllowNull]
    public IList<object?> HelocMaximumScheduleOnFullLoanAmount { get => GetList<object?>(); set => SetList(value); }

    /// <summary>
    /// CustomModelFields HelocMinimumPaymentSchedule
    /// </summary>
    [AllowNull]
    public IList<object?> HelocMinimumPaymentSchedule { get => GetList<object?>(); set => SetList(value); }

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
    /// CustomModelFields ProvideFhaScenario
    /// </summary>
    public bool? ProvideFhaScenario { get => GetValue<bool?>(); set => SetValue(value); }

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

    /// <summary>
    /// CustomModelFields QmPaymentSchedule
    /// </summary>
    [AllowNull]
    public IList<object?> QmPaymentSchedule { get => GetList<object?>(); set => SetList(value); }
}