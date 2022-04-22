using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// EVaultRights
    /// </summary>
    public sealed class EVaultRights : DirtyExtensibleObject
    {
        /// <summary>
        /// EVaultRights EVaultPortal
        /// </summary>
        [AllowNull]
        public EVaultPortalRights EVaultPortal { get => GetEntity<EVaultPortalRights>(); set => SetEntity(value); }
    }
}