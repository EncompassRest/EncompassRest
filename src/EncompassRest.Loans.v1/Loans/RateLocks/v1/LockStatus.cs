using System.Runtime.Serialization;

namespace EncompassRest.Loans.RateLocks.v1
{
    /// <summary>
    /// LockStatus
    /// </summary>
    public enum LockStatus
    {
        /// <summary>
        /// Requested
        /// </summary>
        Requested = 0,
        /// <summary>
        /// Locked
        /// </summary>
        Locked = 1,
        /// <summary>
        /// Old Lock
        /// </summary>
        [EnumMember(Value = "Old Lock")]
        OldLock = 2,
        /// <summary>
        /// Old Request
        /// </summary>
        [EnumMember(Value = "Old Request")]
        OldRequest = 3,
        /// <summary>
        /// Expired
        /// </summary>
        Expired = 4,
        /// <summary>
        /// Cancelled
        /// </summary>
        Cancelled = 5,
        /// <summary>
        /// Extension Requested
        /// </summary>
        [EnumMember(Value = "Extension Requested")]
        ExtensionRequested = 6,
        /// <summary>
        /// Denied
        /// </summary>
        Denied = 7,
        /// <summary>
        /// Registered
        /// </summary>
        Registered = 8,
        /// <summary>
        /// Old Registration
        /// </summary>
        [EnumMember(Value = "Old Registration")]
        OldRegistration = 9
    }
}