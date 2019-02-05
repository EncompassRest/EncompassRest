using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// HmdaCreditScoreForDecisionMaking
    /// </summary>
    public enum HmdaCreditScoreForDecisionMaking
    {
        /// <summary>
        /// 1111 Partially Exempt
        /// </summary>
        [Description("1111 Partially Exempt")]
        [EnumMember(Value = "Partially Exempt")]
        PartiallyExempt = 1111,
        /// <summary>
        /// 7777. Credit score is not a number
        /// </summary>
        [Description("7777. Credit score is not a number")]
        [EnumMember(Value = "7777")]
        n7777 = 7777,
        /// <summary>
        /// 8888. Not applicable
        /// </summary>
        [Description("8888. Not applicable")]
        [EnumMember(Value = "8888")]
        n8888 = 8888
    }
}