using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
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