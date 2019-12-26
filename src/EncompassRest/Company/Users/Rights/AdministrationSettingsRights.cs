namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// AdministrationSettingsRights
    /// </summary>
    public sealed class AdministrationSettingsRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _accessTPOConnectAdminSite;

        /// <summary>
        /// AdministrationSettingsRights AccessTPOConnectAdminSite
        /// </summary>
        public bool? AccessTPOConnectAdminSite { get => _accessTPOConnectAdminSite; set => SetField(ref _accessTPOConnectAdminSite, value); }
    }
}