using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// HomeRights
    /// </summary>
    public sealed class HomeRights : DirtyExtensibleObject
    {
        /// <summary>
        /// HomeRights AllowAccessToTheCompanysMyAccountModuleAndPages
        /// </summary>
        [JsonProperty("allowAccessToTheCompany'sMyAccountModuleAndPages.")]
        public bool? AllowAccessToTheCompanysMyAccountModuleAndPages { get => GetValue<bool?>(); set => SetValue(value); }
    }
}