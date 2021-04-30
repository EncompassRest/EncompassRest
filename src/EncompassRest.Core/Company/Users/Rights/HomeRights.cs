using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// HomeRights
    /// </summary>
    public sealed class HomeRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _allowAccessToTheCompanysMyAccountModuleAndPages;

        /// <summary>
        /// HomeRights AllowAccessToTheCompanysMyAccountModuleAndPages
        /// </summary>
        [JsonProperty("allowAccessToTheCompany'sMyAccountModuleAndPages.")]
        public bool? AllowAccessToTheCompanysMyAccountModuleAndPages { get => _allowAccessToTheCompanysMyAccountModuleAndPages; set => SetField(ref _allowAccessToTheCompanysMyAccountModuleAndPages, value); }
    }
}