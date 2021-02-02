using System.Runtime.Serialization;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// LockStatus
    /// </summary>
    public enum LockStatus
    {
        /// <summary>
        /// Requested
        /// </summary>
        [EnumMember(Value = "Requested")]
        Requested = 0,
        /// <summary>
        /// Locked
        /// </summary>
        [EnumMember(Value = "Locked")]
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
        [EnumMember(Value = "Expired")]
        Expired = 4,
        /// <summary>
        /// Cancelled
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled = 5,
        /// <summary>
        /// Extension Requested
        /// </summary>
        [EnumMember(Value = "Extension Requested")]
        ExtensionRequested = 6,
        /// <summary>
        /// Denied
        /// </summary>
        [EnumMember(Value = "Denied")]
        Denied = 7,
        /// <summary>
        /// Registered
        /// </summary>
        [EnumMember(Value = "Registered")]
        Registered = 8,
        /// <summary>
        /// Old Registration
        /// </summary>
        [EnumMember(Value = "Old Registration")]
        OldRegistration = 9
        
    }
}