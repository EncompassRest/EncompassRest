using System.Collections.Generic;

namespace EncompassRest.Settings.Personas
{
    /// <summary>
    /// PersonaAccessRights
    /// </summary>
    public class PersonaAccessRights : PersonaAccess
    {
        /// <summary>
        /// Persona Rights
        /// </summary>
        public IList<string> Rights { get; set; }
    }
}
