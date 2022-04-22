using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// GrantWriteAccessRights
    /// </summary>
    public sealed class GrantWriteAccessRights : PersonaAccess
    {
        /// <summary>
        /// GrantWriteAccessRights LoanTeam
        /// </summary>
        [AllowNull]
        public IList<LoanTeamMemberRights> LoanTeam { get => GetList<LoanTeamMemberRights>(); set => SetList(value); }
    }
}