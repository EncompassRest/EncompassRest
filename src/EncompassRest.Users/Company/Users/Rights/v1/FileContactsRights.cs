using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// FileContactsRights
    /// </summary>
    public sealed class FileContactsRights : ParentAccessRights
    {
        /// <summary>
        /// FileContactsRights GrantWriteAccessToLoanTeamMembers
        /// </summary>
        [AllowNull]
        public GrantWriteAccessToLoanTeamMembersRights GrantWriteAccessToLoanTeamMembers { get => GetEntity<GrantWriteAccessToLoanTeamMembersRights>(); set => SetEntity(value); }

        /// <summary>
        /// FileContactsRights ShowInvestorContact
        /// </summary>
        public bool? ShowInvestorContact { get => GetValue<bool?>(); set => SetValue(value); }
    }
}