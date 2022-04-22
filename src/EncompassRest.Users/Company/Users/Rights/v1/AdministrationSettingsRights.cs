namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AdministrationSettingsRights
    /// </summary>
    public sealed class AdministrationSettingsRights : DirtyExtensibleObject
    {
        /// <summary>
        /// AdministrationSettingsRights AccessTPOConnectAdminSite
        /// </summary>
        public bool? AccessTPOConnectAdminSite { get => GetValue<bool?>(); set => SetValue(value); }
    }
}