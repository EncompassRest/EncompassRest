namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// AddEditTPOWebCenterAdditionalDocumentsRights
    /// </summary>
    public sealed class AddEditTPOWebCenterAdditionalDocumentsRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _deleteTPOWebCenterDocuments;

        /// <summary>
        /// AddEditTPOWebCenterAdditionalDocumentsRights DeleteTPOWebCenterDocuments
        /// </summary>
        public bool? DeleteTPOWebCenterDocuments { get => _deleteTPOWebCenterDocuments; set => SetField(ref _deleteTPOWebCenterDocuments, value); }
    }
}