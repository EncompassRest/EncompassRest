using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// TPOConnectRights
    /// </summary>
    public sealed class TPOConnectRights : DirtyExtensibleObject
    {
        /// <summary>
        /// TPOConnectRights AdministrationSettings
        /// </summary>
        [AllowNull]
        public AdministrationSettingsRights AdministrationSettings { get => GetEntity<AdministrationSettingsRights>(); set => SetEntity(value); }

        /// <summary>
        /// TPOConnectRights SiteSettings
        /// </summary>
        [AllowNull]
        public SiteSettingsRights SiteSettings { get => GetEntity<SiteSettingsRights>(); set => SetEntity(value); }
    }
}