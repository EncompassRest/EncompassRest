using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// TPOWebCenterDocumentsTabRights
    /// </summary>
    public sealed class TPOWebCenterDocumentsTabRights : ParentAccessRights
    {
        private AddEditTPOWebCenterAdditionalDocumentsRights? _addEditTPOWebCenterAdditionalDocuments;
        private DirtyValue<bool?>? _disableTPOWebCenterGlobalDocuments;

        /// <summary>
        /// TPOWebCenterDocumentsTabRights AddEditTPOWebCenterAdditionalDocuments
        /// </summary>
        [JsonProperty("add/EditTPOWebCenterAdditionalDocuments")]
        [AllowNull]
        public AddEditTPOWebCenterAdditionalDocumentsRights AddEditTPOWebCenterAdditionalDocuments { get => GetField(ref _addEditTPOWebCenterAdditionalDocuments); set => SetField(ref _addEditTPOWebCenterAdditionalDocuments, value); }

        /// <summary>
        /// TPOWebCenterDocumentsTabRights DisableTPOWebCenterGlobalDocuments
        /// </summary>
        public bool? DisableTPOWebCenterGlobalDocuments { get => _disableTPOWebCenterGlobalDocuments; set => SetField(ref _disableTPOWebCenterGlobalDocuments, value); }
    }
}