namespace EncompassRest.Settings.Personas
{
    /// <summary>
    /// LoanTeamMemberRights
    /// </summary>
    public sealed class LoanTeamMemberRights : DirtyExtensibleObject
    {
        private EntityReference _role;
        private EntityReference _milestone;

        /// <summary>
        /// LoanTeamMemberRights Role
        /// </summary>
        public EntityReference Role { get => _role; set => SetField(ref _role, value); }

        /// <summary>
        /// EntityReference Milestone
        /// </summary>
        public EntityReference Milestone { get => _milestone; set => SetField(ref _milestone, value); }
    }
}