using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// AccessToDashboardTabRights
    /// </summary>
    public sealed class AccessToDashboardTabRights : ParentAccessRights
    {
        private DirtyValue<bool?> _filterDatabyOrganization;
        private DirtyValue<bool?> _filterDatabyUserGroup;
        private DirtyValue<bool?> _managePersonalSnapshotTemplate;
        private DirtyValue<bool?> _managePersonalView;

        /// <summary>
        /// AccessToDashboardTabRights FilterDatabyOrganization
        /// </summary>
        [JsonProperty("filterDatabyOrganization*")]
        public bool? FilterDatabyOrganization { get => _filterDatabyOrganization; set => SetField(ref _filterDatabyOrganization, value); }

        /// <summary>
        /// AccessToDashboardTabRights FilterDatabyUserGroup
        /// </summary>
        [JsonProperty("filterDatabyUserGroup*")]
        public bool? FilterDatabyUserGroup { get => _filterDatabyUserGroup; set => SetField(ref _filterDatabyUserGroup, value); }

        /// <summary>
        /// AccessToDashboardTabRights ManagePersonalSnapshotTemplate
        /// </summary>
        public bool? ManagePersonalSnapshotTemplate { get => _managePersonalSnapshotTemplate; set => SetField(ref _managePersonalSnapshotTemplate, value); }

        /// <summary>
        /// AccessToDashboardTabRights ManagePersonalView
        /// </summary>
        public bool? ManagePersonalView { get => _managePersonalView; set => SetField(ref _managePersonalView, value); }
    }
}