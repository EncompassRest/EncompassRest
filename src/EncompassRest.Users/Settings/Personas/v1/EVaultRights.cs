using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// EVaultRights
    /// </summary>
    public sealed class EVaultRights : DirtyExtensibleObject
    {
        private EVaultPortalRights? _eVaultPortal;

        /// <summary>
        /// EVaultRights EVaultPortal
        /// </summary>
        [AllowNull]
        public EVaultPortalRights EVaultPortal { get => GetField(ref _eVaultPortal); set => SetField(ref _eVaultPortal, value); }
    }
}