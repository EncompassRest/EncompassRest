using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// CustomModelFields
/// </summary>
public sealed partial class CustomModelFields : DirtyExtensibleObject, IIdentifiable
{
    private DirtyList<object?>? _cpaPaymentSchedule;
    private DirtyValue<object?>? _helocExampleScheduleData;
    private DirtyList<object?>? _helocHistoricalPaymentSchedule;
    private DirtyList<object?>? _helocMaximumPaymentSchedule;
    private DirtyList<object?>? _helocMaximumScheduleOnFullLoanAmount;
    private DirtyList<object?>? _helocMinimumPaymentSchedule;
    private DirtyValue<bool?>? _provideAmortizationScenario;
    private DirtyValue<bool?>? _provideBestCaseScenario;
    private DirtyValue<bool?>? _provideCpaPaymentSchedule;
    private DirtyValue<bool?>? _provideFhaScenario;
    private DirtyValue<bool?>? _provideHelocExampleSchedules;
    private DirtyValue<bool?>? _provideQmPaymentSchedule;
    private DirtyValue<bool?>? _provideWorstCaseScenario;
    private DirtyList<object?>? _qmPaymentSchedule;

    /// <summary>
    /// CustomModelFieldsContract CpaPaymentSchedule
    /// </summary>
    [AllowNull]
    public IList<object?> CpaPaymentSchedule { get => GetField(ref _cpaPaymentSchedule); set => SetField(ref _cpaPaymentSchedule, value); }

    /// <summary>
    /// CustomModelFieldsContract HelocExampleScheduleData
    /// </summary>
    public object? HelocExampleScheduleData { get => _helocExampleScheduleData; set => SetField(ref _helocExampleScheduleData, value); }

    /// <summary>
    /// CustomModelFieldsContract HelocHistoricalPaymentSchedule
    /// </summary>
    [AllowNull]
    public IList<object?> HelocHistoricalPaymentSchedule { get => GetField(ref _helocHistoricalPaymentSchedule); set => SetField(ref _helocHistoricalPaymentSchedule, value); }

    /// <summary>
    /// CustomModelFieldsContract HelocMaximumPaymentSchedule
    /// </summary>
    [AllowNull]
    public IList<object?> HelocMaximumPaymentSchedule { get => GetField(ref _helocMaximumPaymentSchedule); set => SetField(ref _helocMaximumPaymentSchedule, value); }

    /// <summary>
    /// CustomModelFieldsContract HelocMaximumScheduleOnFullLoanAmount
    /// </summary>
    [AllowNull]
    public IList<object?> HelocMaximumScheduleOnFullLoanAmount { get => GetField(ref _helocMaximumScheduleOnFullLoanAmount); set => SetField(ref _helocMaximumScheduleOnFullLoanAmount, value); }

    /// <summary>
    /// CustomModelFieldsContract HelocMinimumPaymentSchedule
    /// </summary>
    [AllowNull]
    public IList<object?> HelocMinimumPaymentSchedule { get => GetField(ref _helocMinimumPaymentSchedule); set => SetField(ref _helocMinimumPaymentSchedule, value); }

    /// <summary>
    /// CustomModelFieldsContract ProvideAmortizationScenario
    /// </summary>
    public bool? ProvideAmortizationScenario { get => _provideAmortizationScenario; set => SetField(ref _provideAmortizationScenario, value); }

    /// <summary>
    /// CustomModelFieldsContract ProvideBestCaseScenario
    /// </summary>
    public bool? ProvideBestCaseScenario { get => _provideBestCaseScenario; set => SetField(ref _provideBestCaseScenario, value); }

    /// <summary>
    /// CustomModelFieldsContract ProvideCpaPaymentSchedule
    /// </summary>
    public bool? ProvideCpaPaymentSchedule { get => _provideCpaPaymentSchedule; set => SetField(ref _provideCpaPaymentSchedule, value); }

    /// <summary>
    /// CustomModelFieldsContract ProvideFhaScenario
    /// </summary>
    public bool? ProvideFhaScenario { get => _provideFhaScenario; set => SetField(ref _provideFhaScenario, value); }

    /// <summary>
    /// CustomModelFieldsContract ProvideHelocExampleSchedules
    /// </summary>
    public bool? ProvideHelocExampleSchedules { get => _provideHelocExampleSchedules; set => SetField(ref _provideHelocExampleSchedules, value); }

    /// <summary>
    /// CustomModelFieldsContract ProvideQmPaymentSchedule
    /// </summary>
    public bool? ProvideQmPaymentSchedule { get => _provideQmPaymentSchedule; set => SetField(ref _provideQmPaymentSchedule, value); }

    /// <summary>
    /// CustomModelFieldsContract ProvideWorstCaseScenario
    /// </summary>
    public bool? ProvideWorstCaseScenario { get => _provideWorstCaseScenario; set => SetField(ref _provideWorstCaseScenario, value); }

    /// <summary>
    /// CustomModelFieldsContract QmPaymentSchedule
    /// </summary>
    [AllowNull]
    public IList<object?> QmPaymentSchedule { get => GetField(ref _qmPaymentSchedule); set => SetField(ref _qmPaymentSchedule, value); }
}