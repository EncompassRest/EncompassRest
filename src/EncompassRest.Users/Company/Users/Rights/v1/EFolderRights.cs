using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// EFolderRights
    /// </summary>
    public sealed class EFolderRights : DirtyExtensibleObject
    {
        /// <summary>
        /// EFolderRights AccessToDocumentTab
        /// </summary>
        public bool? AccessToDocumentTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderRights EFolder
        /// </summary>
        [AllowNull]
        public UserEFolderRights EFolder { get => GetEntity<UserEFolderRights>(); set => SetEntity(value); }

        /// <summary>
        /// EFolderRights Other
        /// </summary>
        [AllowNull]
        public EFolderOtherRights Other { get => GetEntity<EFolderOtherRights>(); set => SetEntity(value); }

        /// <summary>
        /// EFolderRights ProtectedDocuments
        /// </summary>
        [AllowNull]
        public ProtectedDocumentsRights ProtectedDocuments { get => GetEntity<ProtectedDocumentsRights>(); set => SetEntity(value); }

        /// <summary>
        /// EFolderRights UnassignedFiles
        /// </summary>
        [AllowNull]
        public UnassignedFilesRights UnassignedFiles { get => GetEntity<UnassignedFilesRights>(); set => SetEntity(value); }

        /// <summary>
        /// EFolderRights UnprotectedDocuments
        /// </summary>
        [AllowNull]
        public UnprotectedDocumentsRights UnprotectedDocuments { get => GetEntity<UnprotectedDocumentsRights>(); set => SetEntity(value); }
    }
}