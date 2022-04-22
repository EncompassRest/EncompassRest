using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// PurchaseAdviceFormRights
    /// </summary>
    public sealed class PurchaseAdviceFormRights : ParentAccessRights
    {
        /// <summary>
        /// PurchaseAdviceFormRights CreateEditTemplate
        /// </summary>
        [JsonProperty("create/EditTemplate")]
        public bool? CreateEditTemplate { get => GetValue<bool?>(); set => SetValue(value); }
    }
}