using System.Runtime.Serialization;

namespace EncompassRest.Loans.RateLocks.v1
{
    /// <summary>
    /// LockAction
    /// </summary>
    public enum LockAction
    {
        /// <summary>
        /// Confirm
        /// </summary>
        [EnumMember(Value = "confirm")]
        Confirm = 0,
        /// <summary>
        /// Relock
        /// </summary>
        [EnumMember(Value = "relock")]
        Relock = 1,
        /// <summary>
        /// Extend
        /// </summary>
        [EnumMember(Value = "extend")]
        Extend = 2,
        /// <summary>
        /// Cancel
        /// </summary>
        [EnumMember(Value = "cancel")]
        Cancel = 3
    }
}