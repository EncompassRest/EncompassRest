using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// AccessRights
    /// </summary>
    public sealed class AccessRights : DirtyExtensibleObject
    {
        private MobileAccessRights? _mobileAccess;

        /// <summary>
        /// AccessRights MobileAccess
        /// </summary>
        [AllowNull]
        public MobileAccessRights MobileAccess { get => GetField(ref _mobileAccess); set => SetField(ref _mobileAccess, value); }
    }
}