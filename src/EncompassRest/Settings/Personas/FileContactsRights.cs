namespace EncompassRest.Settings.Personas
{
    /// <summary>
    /// FileContactsRights
    /// </summary>
    public sealed class FileContactsRights : PersonaAccessRights
    {
        private GrantWriteAccessRights _grantWriteAccess;

        /// <summary>
        /// FileContactsRights GrantWriteAccess
        /// </summary>
        public GrantWriteAccessRights GrantWriteAccess { get => GetField(ref _grantWriteAccess); set => SetField(ref _grantWriteAccess, value); }
    }
}