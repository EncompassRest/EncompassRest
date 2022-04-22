using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// LoanTeamMemberRights
    /// </summary>
    public sealed class MoveLoansRights : PersonaAccess
    {
        /// <summary>
        /// LoanTeamMemberRights MoveFrom
        /// </summary>
        [AllowNull]
        public IList<EntityReference> MoveFrom { get => GetList<EntityReference>(); set => SetList(value); }

        /// <summary>
        /// LoanTeamMemberRights MoveTo
        /// </summary>
        [AllowNull]
        public IList<EntityReference> MoveTo { get => GetList<EntityReference>(); set => SetList(value); }
    }
}