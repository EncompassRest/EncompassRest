using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// TPOWebCenterDocumentsTabRights
    /// </summary>
    public sealed class TPOWebCenterDocumentsTabRights : ParentAccessRights
    {
        /// <summary>
        /// TPOWebCenterDocumentsTabRights AddEditTPOWebCenterAdditionalDocuments
        /// </summary>
        [JsonProperty("add/EditTPOWebCenterAdditionalDocuments")]
        [AllowNull]
        public AddEditTPOWebCenterAdditionalDocumentsRights AddEditTPOWebCenterAdditionalDocuments { get => GetEntity<AddEditTPOWebCenterAdditionalDocumentsRights>(); set => SetEntity(value); }

        /// <summary>
        /// TPOWebCenterDocumentsTabRights DisableTPOWebCenterGlobalDocuments
        /// </summary>
        public bool? DisableTPOWebCenterGlobalDocuments { get => GetValue<bool?>(); set => SetValue(value); }
    }
}