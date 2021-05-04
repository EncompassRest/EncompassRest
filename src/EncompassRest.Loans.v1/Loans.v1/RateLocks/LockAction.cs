using System.Runtime.Serialization;

namespace EncompassRest.Loans.RateLocks.v1
{
    /// <summary>
    /// LockAction
    /// </summary>
    public enum LockAction
    {
        /// <summary>
        /// confirm
        /// </summary>
        [EnumMember(Value = "confirm")]
        Confirm = 0,
        /// <summary>
        /// relock
        /// </summary>
        [EnumMember(Value = "relock")]
        Relock = 1,
        /// <summary>
        /// extend
        /// </summary>
        [EnumMember(Value = "extend")]
        Extend = 2,
        /// <summary>
        /// cancel
        /// </summary>
        [EnumMember(Value = "cancel")]
        Cancel = 3
    }
}