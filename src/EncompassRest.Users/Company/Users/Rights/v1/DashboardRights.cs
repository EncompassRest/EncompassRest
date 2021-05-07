using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// DashboardRights
    /// </summary>
    public sealed class DashboardRights : DirtyExtensibleObject
    {
        private AccessToDashboardTabRights? _accessToDashboardTab;

        /// <summary>
        /// DashboardRights AccessToDashboardTab
        /// </summary>
        [AllowNull]
        public AccessToDashboardTabRights AccessToDashboardTab { get => GetField(ref _accessToDashboardTab); set => SetField(ref _accessToDashboardTab, value); }
    }
}