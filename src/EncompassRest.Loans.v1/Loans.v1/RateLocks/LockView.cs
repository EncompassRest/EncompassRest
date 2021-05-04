using System.Runtime.Serialization;

namespace EncompassRest.Loans.RateLocks.v1
{
    /// <summary>
    /// LockView
    /// </summary>
    public enum LockView
    {
        /// <summary>
        /// detailed
        /// </summary>
        [EnumMember(Value = "detailed")]
        Detailed = 0,
        /// <summary>
        /// summary
        /// </summary>
        [EnumMember(Value = "summary")]
        Summary = 1
    }
}