using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// DashboardRights
    /// </summary>
    public sealed class DashboardRights : DirtyExtensibleObject
    {
        /// <summary>
        /// DashboardRights AccessToDashboardTab
        /// </summary>
        [AllowNull]
        public AccessToDashboardTabRights AccessToDashboardTab { get => GetEntity<AccessToDashboardTabRights>(); set => SetEntity(value); }
    }
}