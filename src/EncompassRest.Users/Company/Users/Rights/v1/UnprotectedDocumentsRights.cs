using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// UnprotectedDocumentsRights
    /// </summary>
    public sealed class UnprotectedDocumentsRights : DirtyExtensibleObject
    {
        /// <summary>
        /// UnprotectedDocumentsRights DeleteDocument
        /// </summary>
        public bool? DeleteDocument { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UnprotectedDocumentsRights EditDocument
        /// </summary>
        [AllowNull]
        public EditDocumentRights EditDocument { get => GetEntity<EditDocumentRights>(); set => SetEntity(value); }
    }
}