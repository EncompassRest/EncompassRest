using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// OrderMortgageInsurance
    /// </summary>
    public enum OrderMortgageInsurance
    {
        /// <summary>
        /// No
        /// </summary>
        [Description("No")]
        [EnumMember(Value = "0")]
        n0 = 0,
        /// <summary>
        /// Yes
        /// </summary>
        [Description("Yes")]
        [EnumMember(Value = "1")]
        n1 = 1,
        /// <summary>
        /// Check MI Status
        /// </summary>
        [Description("Check MI Status")]
        [EnumMember(Value = "2")]
        n2 = 2
    }
}