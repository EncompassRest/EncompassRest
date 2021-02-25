namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// CampaignManagementRights
    /// </summary>
    public sealed class CampaignManagementRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _assignTasksToOthers;
        private DirtyValue<bool?>? _managePersonalCampaignTemplates;

        /// <summary>
        /// CampaignManagementRights AssignTasksToOthers
        /// </summary>
        public bool? AssignTasksToOthers { get => _assignTasksToOthers; set => SetField(ref _assignTasksToOthers, value); }

        /// <summary>
        /// CampaignManagementRights ManagePersonalCampaignTemplates
        /// </summary>
        public bool? ManagePersonalCampaignTemplates { get => _managePersonalCampaignTemplates; set => SetField(ref _managePersonalCampaignTemplates, value); }
    }
}