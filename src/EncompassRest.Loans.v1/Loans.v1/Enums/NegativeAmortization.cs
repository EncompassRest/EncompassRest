using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// NegativeAmortization
    /// </summary>
    public enum NegativeAmortization
    {
        /// <summary>
        /// scheduled
        /// </summary>
        [EnumMember(Value = "scheduled")]
        Scheduled = 0,
        /// <summary>
        /// potential
        /// </summary>
        [EnumMember(Value = "potential")]
        Potential = 1,
        /// <summary>
        /// none
        /// </summary>
        [EnumMember(Value = "none")]
        None = 2
    }
}