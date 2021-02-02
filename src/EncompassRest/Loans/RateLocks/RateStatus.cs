using System.Runtime.Serialization;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// RateStatus
    /// </summary>
    public enum RateStatus
    {
        /// <summary>
        /// Not Locked
        /// </summary>
        [EnumMember(Value = "notLocked")]
        NotLocked = 0,
        /// <summary>
        /// Locked
        /// </summary>
        [EnumMember(Value = "locked")]
        Locked = 1,
        /// <summary>
        /// Expired
        /// </summary>
        [EnumMember(Value = "expired")]
        Expired = 2,
        /// <summary>
        /// Cancelled
        /// </summary>
        [EnumMember(Value = "cancelled")]
        Cancelled = 3
    }
}