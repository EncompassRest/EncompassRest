using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// InterestRateCodeType
    /// </summary>
    public enum InterestRateCodeType
    {
        /// <summary>
        /// 1 - Single Variable
        /// </summary>
        [EnumMember(Value = "1 - Single Variable")]
        n1SingleVariable = 1,
        /// <summary>
        /// 2 - Single Fixed
        /// </summary>
        [EnumMember(Value = "2 - Single Fixed")]
        n2SingleFixed = 2,
        /// <summary>
        /// 3 - Multi Variable
        /// </summary>
        [EnumMember(Value = "3 - Multi Variable")]
        n3MultiVariable = 3,
        /// <summary>
        /// 4 - Multi Fixed
        /// </summary>
        [EnumMember(Value = "4 - Multi Fixed")]
        n4MultiFixed = 4
    }
}