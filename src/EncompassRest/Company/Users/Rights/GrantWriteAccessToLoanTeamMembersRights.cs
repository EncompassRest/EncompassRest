using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// GrantWriteAccessToLoanTeamMembersRights
    /// </summary>
    public sealed class GrantWriteAccessToLoanTeamMembersRights : ParentAccessRights
    {
        private DirtyDictionary<string, bool>? _freeRoles;
        private DirtyDictionary<string, bool>? _milestones;

        /// <summary>
        /// GrantWriteAccessToLoanTeamMembersRights FreeRoles
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> FreeRoles { get => GetField(ref _freeRoles); set => SetField(ref _freeRoles, value); }

        /// <summary>
        /// GrantWriteAccessToLoanTeamMembersRights Milestones
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> Milestones { get => GetField(ref _milestones); set => SetField(ref _milestones, value); }
    }
}