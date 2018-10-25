namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// TPOConnectRights
    /// </summary>
    public sealed class TPOConnectRights : DirtyExtensibleObject
    {
        private AdministrationSettingsRights _administrationSettings;
        private SiteSettingsRights _siteSettings;

        /// <summary>
        /// TPOConnectRights AdministrationSettings
        /// </summary>
        public AdministrationSettingsRights AdministrationSettings { get => GetField(ref _administrationSettings); set => SetField(ref _administrationSettings, value); }

        /// <summary>
        /// TPOConnectRights SiteSettings
        /// </summary>
        public SiteSettingsRights SiteSettings { get => GetField(ref _siteSettings); set => SetField(ref _siteSettings, value); }
    }
}