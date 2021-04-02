namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// AUSTrackingRights
    /// </summary>
    public sealed class AUSTrackingRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _createManualEntry;

        /// <summary>
        /// AUSTrackingRights CreateManualEntry
        /// </summary>
        public bool? CreateManualEntry { get => _createManualEntry; set => SetField(ref _createManualEntry, value); }
    }
}