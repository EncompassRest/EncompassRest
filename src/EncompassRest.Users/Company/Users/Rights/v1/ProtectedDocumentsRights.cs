using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ProtectedDocumentsRights
    /// </summary>
    public sealed class ProtectedDocumentsRights : DirtyExtensibleObject
    {
        /// <summary>
        /// ProtectedDocumentsRights DeleteDocument
        /// </summary>
        public bool? DeleteDocument { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ProtectedDocumentsRights EditDocument
        /// </summary>
        [AllowNull]
        public EditDocumentRights EditDocument { get => GetEntity<EditDocumentRights>(); set => SetEntity(value); }
    }
}