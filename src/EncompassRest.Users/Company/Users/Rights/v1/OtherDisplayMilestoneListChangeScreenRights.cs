namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// OtherDisplayMilestoneListChangeScreenRights
    /// </summary>
    public sealed class OtherDisplayMilestoneListChangeScreenRights : ParentAccessRights
    {
        /// <summary>
        /// OtherDisplayMilestoneListChangeScreenRights ModifyWhoReceivesNotificationOfAccessLoss
        /// </summary>
        public bool? ModifyWhoReceivesNotificationOfAccessLoss { get => GetValue<bool?>(); set => SetValue(value); }
    }
}