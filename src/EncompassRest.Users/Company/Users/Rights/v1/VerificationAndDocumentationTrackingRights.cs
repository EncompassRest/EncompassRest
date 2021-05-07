namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// VerificationAndDocumentationTrackingRights
    /// </summary>
    public sealed class VerificationAndDocumentationTrackingRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _createNewEntry;
        private DirtyValue<bool?>? _editEntry;

        /// <summary>
        /// VerificationAndDocumentationTrackingRights CreateNewEntry
        /// </summary>
        public bool? CreateNewEntry { get => _createNewEntry; set => SetField(ref _createNewEntry, value); }

        /// <summary>
        /// VerificationAndDocumentationTrackingRights EditEntry
        /// </summary>
        public bool? EditEntry { get => _editEntry; set => SetField(ref _editEntry, value); }
    }
}