using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// FileContactsRights
    /// </summary>
    public sealed class FileContactsRights : PersonaAccessRights
    {
        /// <summary>
        /// FileContactsRights GrantWriteAccess
        /// </summary>
        [AllowNull]
        public GrantWriteAccessRights GrantWriteAccess { get => GetEntity<GrantWriteAccessRights>(); set => SetEntity(value); }
    }
}