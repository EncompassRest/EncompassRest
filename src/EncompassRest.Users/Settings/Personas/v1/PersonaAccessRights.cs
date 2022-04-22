using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// PersonaAccessRights
    /// </summary>
    public class PersonaAccessRights : PersonaAccess
    {
        /// <summary>
        /// Persona Rights
        /// </summary>
        [AllowNull]
        public IList<string> Rights { get => GetList<string>(); set => SetList(value); }
    }
}