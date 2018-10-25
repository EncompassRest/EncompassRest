namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// ProtectedDocumentsRights
    /// </summary>
    public sealed class ProtectedDocumentsRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?> _deleteDocument;
        private EditDocumentRights _editDocument;

        /// <summary>
        /// ProtectedDocumentsRights DeleteDocument
        /// </summary>
        public bool? DeleteDocument { get => _deleteDocument; set => SetField(ref _deleteDocument, value); }

        /// <summary>
        /// ProtectedDocumentsRights EditDocument
        /// </summary>
        public EditDocumentRights EditDocument { get => GetField(ref _editDocument); set => SetField(ref _editDocument, value); }
    }
}