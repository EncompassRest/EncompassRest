using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// FileContactsRights
    /// </summary>
    public sealed class FileContactsRights : PersonaAccessRights
    {
        private GrantWriteAccessRights? _grantWriteAccess;

        /// <summary>
        /// FileContactsRights GrantWriteAccess
        /// </summary>
        [AllowNull]
        public GrantWriteAccessRights GrantWriteAccess { get => GetField(ref _grantWriteAccess); set => SetField(ref _grantWriteAccess, value); }
    }
}