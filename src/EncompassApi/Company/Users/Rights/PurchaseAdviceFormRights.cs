using Newtonsoft.Json;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// PurchaseAdviceFormRights
    /// </summary>
    public sealed class PurchaseAdviceFormRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _createEditTemplate;

        /// <summary>
        /// PurchaseAdviceFormRights CreateEditTemplate
        /// </summary>
        [JsonProperty("create/EditTemplate")]
        public bool? CreateEditTemplate { get => _createEditTemplate; set => SetField(ref _createEditTemplate, value); }
    }
}