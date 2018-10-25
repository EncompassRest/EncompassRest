namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// DashboardRights
    /// </summary>
    public sealed class DashboardRights : DirtyExtensibleObject
    {
        private AccessToDashboardTabRights _accessToDashboardTab;

        /// <summary>
        /// DashboardRights AccessToDashboardTab
        /// </summary>
        public AccessToDashboardTabRights AccessToDashboardTab { get => GetField(ref _accessToDashboardTab); set => SetField(ref _accessToDashboardTab, value); }
    }
}