namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// TQLComplianceAlert
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class TQLComplianceAlert : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _lastComplianceOrderAlertCategories;
        private DirtyValue<string?>? _lastComplianceOrderAlertMessage;
        private DirtyValue<string?>? _lastComplianceOrderDescriptionOfAlerts;
        private DirtyValue<int?>? _tQLComplianceAlertIndex;

        /// <summary>
        /// TQLComplianceAlert Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// TQL - Compliance Orders - Last Alert Categories [TQLCOMPLIANCEALERTNN01]
        /// </summary>
        public string? LastComplianceOrderAlertCategories { get => _lastComplianceOrderAlertCategories; set => SetField(ref _lastComplianceOrderAlertCategories, value); }

        /// <summary>
        /// TQL - Compliance Orders - Last Alert Message [TQLCOMPLIANCEALERTNN03]
        /// </summary>
        public string? LastComplianceOrderAlertMessage { get => _lastComplianceOrderAlertMessage; set => SetField(ref _lastComplianceOrderAlertMessage, value); }

        /// <summary>
        /// TQL - Compliance Orders - Last Alert Category Result [TQLCOMPLIANCEALERTNN02]
        /// </summary>
        public string? LastComplianceOrderDescriptionOfAlerts { get => _lastComplianceOrderDescriptionOfAlerts; set => SetField(ref _lastComplianceOrderDescriptionOfAlerts, value); }

        /// <summary>
        /// TQLComplianceAlert TQLComplianceAlertIndex
        /// </summary>
        public int? TQLComplianceAlertIndex { get => _tQLComplianceAlertIndex; set => SetField(ref _tQLComplianceAlertIndex, value); }
    }
}