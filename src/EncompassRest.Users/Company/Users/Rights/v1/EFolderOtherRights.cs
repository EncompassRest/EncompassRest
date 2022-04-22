using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// OtherRights
    /// </summary>
    public sealed class EFolderOtherRights : DirtyExtensibleObject
    {
        /// <summary>
        /// EFolderOtherRights ArchiveDocuments
        /// </summary>
        public bool? ArchiveDocuments { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderOtherRights CreateDuplicateDocuments
        /// </summary>
        [JsonProperty("create/DuplicateDocuments")]
        public bool? CreateDuplicateDocuments { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderOtherRights EDisclosures
        /// </summary>
        [AllowNull]
        public EDisclosuresRights EDisclosures { get => GetEntity<EDisclosuresRights>(); set => SetEntity(value); }

        /// <summary>
        /// EFolderOtherRights ManageAccessToDocuments
        /// </summary>
        [AllowNull]
        public ManageAccessToDocumentsRights ManageAccessToDocuments { get => GetEntity<ManageAccessToDocumentsRights>(); set => SetEntity(value); }

        /// <summary>
        /// EFolderOtherRights PackagesTab
        /// </summary>
        [AllowNull]
        public PackagesTabRights PackagesTab { get => GetEntity<PackagesTabRights>(); set => SetEntity(value); }

        /// <summary>
        /// EFolderOtherRights RequestBorrowerDocuments
        /// </summary>
        public bool? RequestBorrowerDocuments { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderOtherRights RequestEllieMaeNetworkServices
        /// </summary>
        public bool? RequestEllieMaeNetworkServices { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderOtherRights RetrieveBorrowerDocuments
        /// </summary>
        public bool? RetrieveBorrowerDocuments { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderOtherRights RetrieveEllieMaeNetworkServices
        /// </summary>
        public bool? RetrieveEllieMaeNetworkServices { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderOtherRights SendConsent
        /// </summary>
        public bool? SendConsent { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderOtherRights SendFiles
        /// </summary>
        public bool? SendFiles { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderOtherRights SendFilestoLender
        /// </summary>
        public bool? SendFilestoLender { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EFolderOtherRights ViewAllAnnotations
        /// </summary>
        public bool? ViewAllAnnotations { get => GetValue<bool?>(); set => SetValue(value); }
    }
}