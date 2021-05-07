using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// PersonaAccessRights
    /// </summary>
    public class PersonaAccessRights : PersonaAccess
    {
        private DirtyList<string>? _rights;

        /// <summary>
        /// Persona Rights
        /// </summary>
        [AllowNull]
        public IList<string> Rights { get => GetField(ref _rights); set => SetField(ref _rights, value); }
    }
}