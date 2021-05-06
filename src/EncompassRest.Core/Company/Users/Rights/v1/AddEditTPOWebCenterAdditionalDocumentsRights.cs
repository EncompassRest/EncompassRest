namespace EncompassRest.Company.Users.Rights.v1
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