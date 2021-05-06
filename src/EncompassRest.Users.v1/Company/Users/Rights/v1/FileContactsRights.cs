using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// FileContactsRights
    /// </summary>
    public sealed class FileContactsRights : ParentAccessRights
    {
        private GrantWriteAccessToLoanTeamMembersRights? _grantWriteAccessToLoanTeamMembers;
        private DirtyValue<bool?>? _showInvestorContact;

        /// <summary>
        /// FileContactsRights GrantWriteAccessToLoanTeamMembers
        /// </summary>
        [AllowNull]
        public GrantWriteAccessToLoanTeamMembersRights GrantWriteAccessToLoanTeamMembers { get => GetField(ref _grantWriteAccessToLoanTeamMembers); set => SetField(ref _grantWriteAccessToLoanTeamMembers, value); }

        /// <summary>
        /// FileContactsRights ShowInvestorContact
        /// </summary>
        public bool? ShowInvestorContact { get => _showInvestorContact; set => SetField(ref _showInvestorContact, value); }
    }
}