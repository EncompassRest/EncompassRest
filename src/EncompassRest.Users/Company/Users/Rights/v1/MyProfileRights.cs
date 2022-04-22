using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// MyProfileRights
    /// </summary>
    public sealed class MyProfileRights : DirtyExtensibleObject
    {
        /// <summary>
        /// MyProfileRights Cell
        /// </summary>
        [JsonProperty("cell#")]
        public bool? Cell { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MyProfileRights Email
        /// </summary>
        public bool? Email { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MyProfileRights Fax
        /// </summary>
        [JsonProperty("fax#")]
        public bool? Fax { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MyProfileRights Name
        /// </summary>
        public bool? Name { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MyProfileRights Phone
        /// </summary>
        [JsonProperty("phone#")]
        public bool? Phone { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MyProfileRights PublicProfile
        /// </summary>
        public bool? PublicProfile { get => GetValue<bool?>(); set => SetValue(value); }
    }
}