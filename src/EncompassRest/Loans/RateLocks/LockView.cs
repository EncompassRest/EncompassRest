using System.Runtime.Serialization;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// LockView
    /// </summary>
    public enum LockView
    {
        /// <summary>
        /// Detailed
        /// </summary>
        [EnumMember(Value = "detailed")]
        Detailed = 0,
        /// <summary>
        /// Summary
        /// </summary>
        [EnumMember(Value = "summary")]
        Summary = 1
    }
}