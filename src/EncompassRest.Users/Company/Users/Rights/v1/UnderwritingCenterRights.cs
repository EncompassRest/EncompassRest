namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// UnderwritingCenterRights
    /// </summary>
    public sealed class UnderwritingCenterRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _createManualEntry;
        private DirtyValue<bool?>? _repWarrantTracker;

        /// <summary>
        /// UnderwritingCenterRights CreateManualEntry
        /// </summary>
        public bool? CreateManualEntry { get => _createManualEntry; set => SetField(ref _createManualEntry, value); }

        /// <summary>
        /// UnderwritingCenterRights RepWarrantTracker
        /// </summary>
        public bool? RepWarrantTracker { get => _repWarrantTracker; set => SetField(ref _repWarrantTracker, value); }
    }
}