using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AccessToDashboardTabRights
    /// </summary>
    public sealed class AccessToDashboardTabRights : ParentAccessRights
    {
        /// <summary>
        /// AccessToDashboardTabRights FilterDatabyOrganization
        /// </summary>
        [JsonProperty("filterDatabyOrganization*")]
        public bool? FilterDatabyOrganization { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AccessToDashboardTabRights FilterDatabyUserGroup
        /// </summary>
        [JsonProperty("filterDatabyUserGroup*")]
        public bool? FilterDatabyUserGroup { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AccessToDashboardTabRights ManagePersonalSnapshotTemplate
        /// </summary>
        public bool? ManagePersonalSnapshotTemplate { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AccessToDashboardTabRights ManagePersonalView
        /// </summary>
        public bool? ManagePersonalView { get => GetValue<bool?>(); set => SetValue(value); }
    }
}