using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// RiskClassification
    /// </summary>
    public enum RiskClassification
    {
        /// <summary>
        /// APPROVE
        /// </summary>
        [Description("APPROVE")]
        [EnumMember(Value = "1")]
        n1 = 1,
        /// <summary>
        /// REFER
        /// </summary>
        [Description("REFER")]
        [EnumMember(Value = "2")]
        n2 = 2
    }
}