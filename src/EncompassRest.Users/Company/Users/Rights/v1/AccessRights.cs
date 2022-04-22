using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AccessRights
    /// </summary>
    public sealed class AccessRights : DirtyExtensibleObject
    {
        /// <summary>
        /// AccessRights MobileAccess
        /// </summary>
        [AllowNull]
        public MobileAccessRights MobileAccess { get => GetEntity<MobileAccessRights>(); set => SetEntity(value); }
    }
}