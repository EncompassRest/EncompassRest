using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
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