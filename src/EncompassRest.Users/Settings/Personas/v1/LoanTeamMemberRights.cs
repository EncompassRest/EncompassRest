namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// LoanTeamMemberRights
    /// </summary>
    public sealed class LoanTeamMemberRights : DirtyExtensibleObject
    {
        /// <summary>
        /// LoanTeamMemberRights Role
        /// </summary>
        public EntityReference? Role { get => GetValue<EntityReference?>(); set => SetValue(value); }

        /// <summary>
        /// EntityReference Milestone
        /// </summary>
        public EntityReference? Milestone { get => GetValue<EntityReference?>(); set => SetValue(value); }
    }
}