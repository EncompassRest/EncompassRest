namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CampaignManagementRights
    /// </summary>
    public sealed class CampaignManagementRights : ParentAccessRights
    {
        /// <summary>
        /// CampaignManagementRights AssignTasksToOthers
        /// </summary>
        public bool? AssignTasksToOthers { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// CampaignManagementRights ManagePersonalCampaignTemplates
        /// </summary>
        public bool? ManagePersonalCampaignTemplates { get => GetValue<bool?>(); set => SetValue(value); }
    }
}