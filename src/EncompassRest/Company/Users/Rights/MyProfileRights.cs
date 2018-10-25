using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// MyProfileRights
    /// </summary>
    public sealed class MyProfileRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?> _cell;
        private DirtyValue<bool?> _email;
        private DirtyValue<bool?> _fax;
        private DirtyValue<bool?> _name;
        private DirtyValue<bool?> _phone;
        private DirtyValue<bool?> _publicProfile;

        /// <summary>
        /// MyProfileRights Cell
        /// </summary>
        [JsonProperty("cell#")]
        public bool? Cell { get => _cell; set => SetField(ref _cell, value); }

        /// <summary>
        /// MyProfileRights Email
        /// </summary>
        public bool? Email { get => _email; set => SetField(ref _email, value); }

        /// <summary>
        /// MyProfileRights Fax
        /// </summary>
        [JsonProperty("fax#")]
        public bool? Fax { get => _fax; set => SetField(ref _fax, value); }

        /// <summary>
        /// MyProfileRights Name
        /// </summary>
        public bool? Name { get => _name; set => SetField(ref _name, value); }

        /// <summary>
        /// MyProfileRights Phone
        /// </summary>
        [JsonProperty("phone#")]
        public bool? Phone { get => _phone; set => SetField(ref _phone, value); }

        /// <summary>
        /// MyProfileRights PublicProfile
        /// </summary>
        public bool? PublicProfile { get => _publicProfile; set => SetField(ref _publicProfile, value); }
    }
}