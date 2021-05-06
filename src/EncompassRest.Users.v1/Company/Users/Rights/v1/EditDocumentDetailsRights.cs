namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// EditDocumentDetailsRights
    /// </summary>
    public sealed class EditDocumentDetailsRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _createNewDocumentName;

        /// <summary>
        /// EditDocumentDetailsRights CreateNewDocumentName
        /// </summary>
        public bool? CreateNewDocumentName { get => _createNewDocumentName; set => SetField(ref _createNewDocumentName, value); }
    }
}