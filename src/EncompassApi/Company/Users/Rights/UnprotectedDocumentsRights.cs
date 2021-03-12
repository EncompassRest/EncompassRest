using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// UnprotectedDocumentsRights
    /// </summary>
    public sealed class UnprotectedDocumentsRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _deleteDocument;
        private EditDocumentRights? _editDocument;

        /// <summary>
        /// UnprotectedDocumentsRights DeleteDocument
        /// </summary>
        public bool? DeleteDocument { get => _deleteDocument; set => SetField(ref _deleteDocument, value); }

        /// <summary>
        /// UnprotectedDocumentsRights EditDocument
        /// </summary>
        [AllowNull]
        public EditDocumentRights EditDocument { get => GetField(ref _editDocument); set => SetField(ref _editDocument, value); }
    }
}