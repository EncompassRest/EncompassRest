namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// FileContactsRights
    /// </summary>
    public sealed class FileContactsRights : ParentAccessRights
    {
        private GrantWriteAccessToLoanTeamMembersRights _grantWriteAccessToLoanTeamMembers;
        private DirtyValue<bool?> _showInvestorContact;

        /// <summary>
        /// FileContactsRights GrantWriteAccessToLoanTeamMembers
        /// </summary>
        public GrantWriteAccessToLoanTeamMembersRights GrantWriteAccessToLoanTeamMembers { get => GetField(ref _grantWriteAccessToLoanTeamMembers); set => SetField(ref _grantWriteAccessToLoanTeamMembers, value); }

        /// <summary>
        /// FileContactsRights ShowInvestorContact
        /// </summary>
        public bool? ShowInvestorContact { get => _showInvestorContact; set => SetField(ref _showInvestorContact, value); }
    }
}