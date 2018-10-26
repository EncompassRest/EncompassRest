namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// ExternalSettingsRightsEditDocumentRights
    /// </summary>
    public sealed class TPOWebCenterDocumentListSettingsEditDocumentRights : ParentAccessRights
    {
        private DirtyValue<bool?> _deleteDocument;

        /// <summary>
        /// ExternalSettingsRightsEditDocumentRights DeleteDocument
        /// </summary>
        public bool? DeleteDocument { get => _deleteDocument; set => SetField(ref _deleteDocument, value); }
    }
}