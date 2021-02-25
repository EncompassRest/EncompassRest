using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassApi.Company.Users.Rights
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
        private DirtyValue<bool?>? _requestBorrowerDocuments;
        private DirtyValue<bool?>? _requestEllieMaeNetworkServices;
        private DirtyValue<bool?>? _retrieveBorrowerDocuments;
        private DirtyValue<bool?>? _retrieveEllieMaeNetworkServices;
        private DirtyValue<bool?>? _sendConsent;
        private DirtyValue<bool?>? _sendFiles;
        private DirtyValue<bool?>? _sendFilestoLender;
        private DirtyValue<bool?>? _viewAllAnnotations;

        /// <summary>
        /// OtherRights ArchiveDocuments
        /// </summary>
        public bool? ArchiveDocuments { get => _archiveDocuments; set => SetField(ref _archiveDocuments, value); }

        /// <summary>
        /// OtherRights CreateDuplicateDocuments
        /// </summary>
        [JsonProperty("create/DuplicateDocuments")]
        public bool? CreateDuplicateDocuments { get => _createDuplicateDocuments; set => SetField(ref _createDuplicateDocuments, value); }

        /// <summary>
        /// OtherRights EDisclosures
        /// </summary>
        [AllowNull]
        public EDisclosuresRights EDisclosures { get => GetField(ref _eDisclosures); set => SetField(ref _eDisclosures, value); }

        /// <summary>
        /// OtherRights ManageAccessToDocuments
        /// </summary>
        [AllowNull]
        public ManageAccessToDocumentsRights ManageAccessToDocuments { get => GetField(ref _manageAccessToDocuments); set => SetField(ref _manageAccessToDocuments, value); }

        /// <summary>
        /// OtherRights RequestBorrowerDocuments
        /// </summary>
        public bool? RequestBorrowerDocuments { get => _requestBorrowerDocuments; set => SetField(ref _requestBorrowerDocuments, value); }

        /// <summary>
        /// OtherRights RequestEllieMaeNetworkServices
        /// </summary>
        public bool? RequestEllieMaeNetworkServices { get => _requestEllieMaeNetworkServices; set => SetField(ref _requestEllieMaeNetworkServices, value); }

        /// <summary>
        /// OtherRights RetrieveBorrowerDocuments
        /// </summary>
        public bool? RetrieveBorrowerDocuments { get => _retrieveBorrowerDocuments; set => SetField(ref _retrieveBorrowerDocuments, value); }

        /// <summary>
        /// OtherRights RetrieveEllieMaeNetworkServices
        /// </summary>
        public bool? RetrieveEllieMaeNetworkServices { get => _retrieveEllieMaeNetworkServices; set => SetField(ref _retrieveEllieMaeNetworkServices, value); }

        /// <summary>
        /// OtherRights SendConsent
        /// </summary>
        public bool? SendConsent { get => _sendConsent; set => SetField(ref _sendConsent, value); }

        /// <summary>
        /// OtherRights SendFiles
        /// </summary>
        public bool? SendFiles { get => _sendFiles; set => SetField(ref _sendFiles, value); }

        /// <summary>
        /// OtherRights SendFilestoLender
        /// </summary>
        public bool? SendFilestoLender { get => _sendFilestoLender; set => SetField(ref _sendFilestoLender, value); }

        /// <summary>
        /// OtherRights ViewAllAnnotations
        /// </summary>
        public bool? ViewAllAnnotations { get => _viewAllAnnotations; set => SetField(ref _viewAllAnnotations, value); }
    }
}