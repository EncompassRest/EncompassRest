namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// CustomModelFields
    /// </summary>
    public sealed partial class CustomModelFields : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _helocExampleScheduleData;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _provideAmortizationScenario;
        private DirtyValue<bool?>? _provideBestCaseScenario;
        private DirtyValue<bool?>? _provideCpaPaymentSchedule;
        private DirtyValue<bool?>? _provideFHAScenario;
        private DirtyValue<bool?>? _provideHelocExampleSchedules;
        private DirtyValue<bool?>? _provideQmPaymentSchedule;
        private DirtyValue<bool?>? _provideWorstCaseScenario;

        /// <summary>
        /// CustomModelFields HelocExampleScheduleData
        /// </summary>
        public string? HelocExampleScheduleData { get => _helocExampleScheduleData; set => SetField(ref _helocExampleScheduleData, value); }

        /// <summary>
        /// CustomModelFields Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// CustomModelFields ProvideAmortizationScenario
        /// </summary>
        public bool? ProvideAmortizationScenario { get => _provideAmortizationScenario; set => SetField(ref _provideAmortizationScenario, value); }

        /// <summary>
        /// CustomModelFields ProvideBestCaseScenario
        /// </summary>
        public bool? ProvideBestCaseScenario { get => _provideBestCaseScenario; set => SetField(ref _provideBestCaseScenario, value); }

        /// <summary>
        /// CustomModelFields ProvideCpaPaymentSchedule
        /// </summary>
        public bool? ProvideCpaPaymentSchedule { get => _provideCpaPaymentSchedule; set => SetField(ref _provideCpaPaymentSchedule, value); }

        /// <summary>
        /// CustomModelFields ProvideFHAScenario
        /// </summary>
        public bool? ProvideFHAScenario { get => _provideFHAScenario; set => SetField(ref _provideFHAScenario, value); }

        /// <summary>
        /// CustomModelFields ProvideHelocExampleSchedules
        /// </summary>
        public bool? ProvideHelocExampleSchedules { get => _provideHelocExampleSchedules; set => SetField(ref _provideHelocExampleSchedules, value); }

        /// <summary>
        /// CustomModelFields ProvideQmPaymentSchedule
        /// </summary>
        public bool? ProvideQmPaymentSchedule { get => _provideQmPaymentSchedule; set => SetField(ref _provideQmPaymentSchedule, value); }

        /// <summary>
        /// CustomModelFields ProvideWorstCaseScenario
        /// </summary>
        public bool? ProvideWorstCaseScenario { get => _provideWorstCaseScenario; set => SetField(ref _provideWorstCaseScenario, value); }
    }
}