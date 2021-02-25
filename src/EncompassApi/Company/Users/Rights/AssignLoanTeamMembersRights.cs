using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// AssignLoanTeamMembersRights
    /// </summary>
    public sealed class AssignLoanTeamMembersRights : DirtyExtensibleObject
    {
        private DirtyDictionary<string, bool>? _freeRoles;
        private DirtyDictionary<string, bool>? _milestones;

        /// <summary>
        /// AssignLoanTeamMembersRights FreeRoles
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> FreeRoles { get => GetField(ref _freeRoles); set => SetField(ref _freeRoles, value); }

        /// <summary>
        /// AssignLoanTeamMembersRights Milestones
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> Milestones { get => GetField(ref _milestones); set => SetField(ref _milestones, value); }
    }
}