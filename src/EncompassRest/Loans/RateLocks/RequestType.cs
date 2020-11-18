using System.Runtime.Serialization;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// RequestType
    /// </summary>
    public enum RequestType
    {
        /// <summary>
        /// Lock
        /// </summary>
        [EnumMember(Value = "Lock")]
        Lock = 0,
        /// <summary>
        /// Re-Lock
        /// </summary>
        [EnumMember(Value = "Re-lock")]
        ReLock = 1,
        /// <summary>
        /// Trade Extension
        /// </summary>
        [EnumMember(Value = "Trade Extension")]
        TradeExtension = 2,
        /// <summary>
        /// Cancellation
        /// </summary>
        [EnumMember(Value = "Cancellation")]
        Cancellation = 3
        
    }
}