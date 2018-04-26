using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// PenaltyTerm
    /// </summary>
    public enum PenaltyTerm
    {
        /// <summary>
        /// 1 Year
        /// </summary>
        [EnumMember(Value = "1 Year")]
        n1Year = 1,
        /// <summary>
        /// 2 Years
        /// </summary>
        [EnumMember(Value = "2 Years")]
        n2Years = 2,
        /// <summary>
        /// 3 Years
        /// </summary>
        [EnumMember(Value = "3 Years")]
        n3Years = 3
    }
}