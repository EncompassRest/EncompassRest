using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AssignLoanTeamMembersRights
    /// </summary>
    public sealed class AssignLoanTeamMembersRights : DirtyExtensibleObject
    {
        /// <summary>
        /// AssignLoanTeamMembersRights FreeRoles
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> FreeRoles { get => GetDictionary<string, bool>(); set => SetDictionary(value); }

        /// <summary>
        /// AssignLoanTeamMembersRights Milestones
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> Milestones { get => GetDictionary<string, bool>(); set => SetDictionary(value); }
    }
}