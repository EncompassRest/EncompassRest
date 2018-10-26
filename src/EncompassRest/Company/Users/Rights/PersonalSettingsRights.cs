namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// PersonalSettingsRights
    /// </summary>
    public sealed class PersonalSettingsRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?> _defaultFileContacts;
        private DirtyValue<bool?> _grantFileAccess;
        private MyProfileRights _myProfile;

        /// <summary>
        /// PersonalSettingsRights DefaultFileContacts
        /// </summary>
        public bool? DefaultFileContacts { get => _defaultFileContacts; set => SetField(ref _defaultFileContacts, value); }

        /// <summary>
        /// PersonalSettingsRights GrantFileAccess
        /// </summary>
        public bool? GrantFileAccess { get => _grantFileAccess; set => SetField(ref _grantFileAccess, value); }

        /// <summary>
        /// PersonalSettingsRights MyProfile
        /// </summary>
        public MyProfileRights MyProfile { get => GetField(ref _myProfile); set => SetField(ref _myProfile, value); }
    }
}