using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// EFolderRights
    /// </summary>
    public sealed class EFolderRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _accessToDocumentTab;
        private UserEFolderRights? _eFolder;
        private EFolderOtherRights? _other;
        private ProtectedDocumentsRights? _protectedDocuments;
        private UnassignedFilesRights? _unassignedFiles;
        private UnprotectedDocumentsRights? _unprotectedDocuments;

        /// <summary>
        /// EFolderRights AccessToDocumentTab
        /// </summary>
        public bool? AccessToDocumentTab { get => _accessToDocumentTab; set => SetField(ref _accessToDocumentTab, value); }

        /// <summary>
        /// EFolderRights EFolder
        /// </summary>
        [AllowNull]
        public UserEFolderRights EFolder { get => GetField(ref _eFolder); set => SetField(ref _eFolder, value); }

        /// <summary>
        /// EFolderRights Other
        /// </summary>
        [AllowNull]
        public EFolderOtherRights Other { get => GetField(ref _other); set => SetField(ref _other, value); }

        /// <summary>
        /// EFolderRights ProtectedDocuments
        /// </summary>
        [AllowNull]
        public ProtectedDocumentsRights ProtectedDocuments { get => GetField(ref _protectedDocuments); set => SetField(ref _protectedDocuments, value); }

        /// <summary>
        /// EFolderRights UnassignedFiles
        /// </summary>
        [AllowNull]
        public UnassignedFilesRights UnassignedFiles { get => GetField(ref _unassignedFiles); set => SetField(ref _unassignedFiles, value); }

        /// <summary>
        /// EFolderRights UnprotectedDocuments
        /// </summary>
        [AllowNull]
        public UnprotectedDocumentsRights UnprotectedDocuments { get => GetField(ref _unprotectedDocuments); set => SetField(ref _unprotectedDocuments, value); }
    }
}