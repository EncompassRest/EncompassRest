using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Settings.Personas
{
    /// <summary>
    /// GrantWriteAccessRights
    /// </summary>
    public sealed class GrantWriteAccessRights : PersonaAccess
    {
        private DirtyList<LoanTeamMemberRights>? _loanTeam;

        /// <summary>
        /// GrantWriteAccessRights LoanTeam
        /// </summary>
        [AllowNull]
        public IList<LoanTeamMemberRights> LoanTeam { get => GetField(ref _loanTeam); set => SetField(ref _loanTeam, value); }
    }
}