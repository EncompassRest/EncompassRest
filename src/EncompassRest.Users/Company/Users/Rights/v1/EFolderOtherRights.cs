using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// OtherRights
    /// </summary>
    public sealed class EFolderOtherRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _archiveDocuments;
        private DirtyValue<bool?>? _createDuplicateDocuments;
        private EDisclosuresRights? _eDisclosures;
        private ManageAccessToDocumentsRights? _manageAccessToDocuments;
        private PackagesTabRights? _packagesTab;
        private DirtyValue<bool?>? _requestBorrowerDocuments;
        private DirtyValue<bool?>? _requestEllieMaeNetworkServices;
        private DirtyValue<bool?>? _retrieveBorrowerDocuments;
        private DirtyValue<bool?>? _retrieveEllieMaeNetworkServices;
        private DirtyValue<bool?>? _sendConsent;
        private DirtyValue<bool?>? _sendFiles;
        private DirtyValue<bool?>? _sendFilestoLender;
        private DirtyValue<bool?>? _viewAllAnnotations;

        /// <summary>
        /// EFolderOtherRights ArchiveDocuments
        /// </summary>
        public bool? ArchiveDocuments { get => _archiveDocuments; set => SetField(ref _archiveDocuments, value); }

        /// <summary>
        /// EFolderOtherRights CreateDuplicateDocuments
        /// </summary>
        [JsonProperty("create/DuplicateDocuments")]
        public bool? CreateDuplicateDocuments { get => _createDuplicateDocuments; set => SetField(ref _createDuplicateDocuments, value); }

        /// <summary>
        /// EFolderOtherRights EDisclosures
        /// </summary>
        [AllowNull]
        public EDisclosuresRights EDisclosures { get => GetField(ref _eDisclosures); set => SetField(ref _eDisclosures, value); }

        /// <summary>
        /// EFolderOtherRights ManageAccessToDocuments
        /// </summary>
        [AllowNull]
        public ManageAccessToDocumentsRights ManageAccessToDocuments { get => GetField(ref _manageAccessToDocuments); set => SetField(ref _manageAccessToDocuments, value); }

        /// <summary>
        /// EFolderOtherRights PackagesTab
        /// </summary>
        [AllowNull]
        public PackagesTabRights PackagesTab { get => GetField(ref _packagesTab); set => SetField(ref _packagesTab, value); }

        /// <summary>
        /// EFolderOtherRights RequestBorrowerDocuments
        /// </summary>
        public bool? RequestBorrowerDocuments { get => _requestBorrowerDocuments; set => SetField(ref _requestBorrowerDocuments, value); }

        /// <summary>
        /// EFolderOtherRights RequestEllieMaeNetworkServices
        /// </summary>
        public bool? RequestEllieMaeNetworkServices { get => _requestEllieMaeNetworkServices; set => SetField(ref _requestEllieMaeNetworkServices, value); }

        /// <summary>
        /// EFolderOtherRights RetrieveBorrowerDocuments
        /// </summary>
        public bool? RetrieveBorrowerDocuments { get => _retrieveBorrowerDocuments; set => SetField(ref _retrieveBorrowerDocuments, value); }

        /// <summary>
        /// EFolderOtherRights RetrieveEllieMaeNetworkServices
        /// </summary>
        public bool? RetrieveEllieMaeNetworkServices { get => _retrieveEllieMaeNetworkServices; set => SetField(ref _retrieveEllieMaeNetworkServices, value); }

        /// <summary>
        /// EFolderOtherRights SendConsent
        /// </summary>
        public bool? SendConsent { get => _sendConsent; set => SetField(ref _sendConsent, value); }

        /// <summary>
        /// EFolderOtherRights SendFiles
        /// </summary>
        public bool? SendFiles { get => _sendFiles; set => SetField(ref _sendFiles, value); }

        /// <summary>
        /// EFolderOtherRights SendFilestoLender
        /// </summary>
        public bool? SendFilestoLender { get => _sendFilestoLender; set => SetField(ref _sendFilestoLender, value); }

        /// <summary>
        /// EFolderOtherRights ViewAllAnnotations
        /// </summary>
        public bool? ViewAllAnnotations { get => _viewAllAnnotations; set => SetField(ref _viewAllAnnotations, value); }
    }
}