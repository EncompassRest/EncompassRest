using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// HudLoanDataRiskClass
    /// </summary>
    public enum HudLoanDataRiskClass
    {
        /// <summary>
        /// A/A
        /// </summary>
        [EnumMember(Value = "A/A")]
        AA = 0,
        /// <summary>
        /// Refer
        /// </summary>
        Refer = 1
    }
}