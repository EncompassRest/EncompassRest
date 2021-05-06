using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// TPOConnectRights
    /// </summary>
    public sealed class TPOConnectRights : DirtyExtensibleObject
    {
        private AdministrationSettingsRights? _administrationSettings;
        private SiteSettingsRights? _siteSettings;

        /// <summary>
        /// TPOConnectRights AdministrationSettings
        /// </summary>
        [AllowNull]
        public AdministrationSettingsRights AdministrationSettings { get => GetField(ref _administrationSettings); set => SetField(ref _administrationSettings, value); }

        /// <summary>
        /// TPOConnectRights SiteSettings
        /// </summary>
        [AllowNull]
        public SiteSettingsRights SiteSettings { get => GetField(ref _siteSettings); set => SetField(ref _siteSettings, value); }
    }
}