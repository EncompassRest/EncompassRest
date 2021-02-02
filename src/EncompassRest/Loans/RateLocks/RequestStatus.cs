using System.Runtime.Serialization;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// RequestStatus
    /// </summary>
    public enum RequestStatus
    {
        /// <summary>
        /// Not Locked
        /// </summary>
        [EnumMember(Value = "Not Locked")]
        NotLocked = 0,
        /// <summary>
        /// Active Lock
        /// </summary>
        [EnumMember(Value = "Active Lock")]
        ActiveLock = 1,
        /// <summary>
        /// Cancelled Lock
        /// </summary>
        [EnumMember(Value = "Cancelled Lock")]
        CancelledLock = 2,
        /// <summary>
        /// Expired Lock
        /// </summary>
        [EnumMember(Value = "Expired Lock")]
        ExpiredLock = 3
        
    }
}