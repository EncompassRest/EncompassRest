using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// PersonalSettingsRights
    /// </summary>
    public sealed class PersonalSettingsRights : DirtyExtensibleObject
    {
        /// <summary>
        /// PersonalSettingsRights DefaultFileContacts
        /// </summary>
        public bool? DefaultFileContacts { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PersonalSettingsRights GrantFileAccess
        /// </summary>
        public bool? GrantFileAccess { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PersonalSettingsRights MyProfile
        /// </summary>
        [AllowNull]
        public MyProfileRights MyProfile { get => GetEntity<MyProfileRights>(); set => SetEntity(value); }
    }
}