using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// GrantWriteAccessToLoanTeamMembersRights
    /// </summary>
    public sealed class GrantWriteAccessToLoanTeamMembersRights : ParentAccessRights
    {
        /// <summary>
        /// GrantWriteAccessToLoanTeamMembersRights FreeRoles
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> FreeRoles { get => GetDictionary<string, bool>(); set => SetDictionary(value); }

        /// <summary>
        /// GrantWriteAccessToLoanTeamMembersRights Milestones
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> Milestones { get => GetDictionary<string, bool>(); set => SetDictionary(value); }
    }
}