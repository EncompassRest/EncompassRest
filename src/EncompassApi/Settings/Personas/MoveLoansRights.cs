using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Settings.Personas
{
    /// <summary>
    /// LoanTeamMemberRights
    /// </summary>
    public sealed class MoveLoansRights : PersonaAccess
    {
        private DirtyList<EntityReference>? _moveFrom;
        private DirtyList<EntityReference>? _moveTo;

        /// <summary>
        /// LoanTeamMemberRights MoveFrom
        /// </summary>
        [AllowNull]
        public IList<EntityReference> MoveFrom { get => GetField(ref _moveFrom); set => SetField(ref _moveFrom, value); }

        /// <summary>
        /// LoanTeamMemberRights MoveTo
        /// </summary>
        [AllowNull]
        public IList<EntityReference> MoveTo { get => GetField(ref _moveTo); set => SetField(ref _moveTo, value); }
    }
}