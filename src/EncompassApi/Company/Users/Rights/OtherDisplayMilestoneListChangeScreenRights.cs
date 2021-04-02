namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// OtherDisplayMilestoneListChangeScreenRights
    /// </summary>
    public sealed class OtherDisplayMilestoneListChangeScreenRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _modifyWhoReceivesNotificationOfAccessLoss;

        /// <summary>
        /// OtherDisplayMilestoneListChangeScreenRights ModifyWhoReceivesNotificationOfAccessLoss
        /// </summary>
        public bool? ModifyWhoReceivesNotificationOfAccessLoss { get => _modifyWhoReceivesNotificationOfAccessLoss; set => SetField(ref _modifyWhoReceivesNotificationOfAccessLoss, value); }
    }
}