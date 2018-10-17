using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// LenderStatusCodeType
    /// </summary>
    public enum LenderStatusCodeType
    {
        /// <summary>
        /// 1. Approved
        /// </summary>
        [EnumMember(Value = "1. Approved")]
        n1Approved = 1,
        /// <summary>
        /// 2. Eligible
        /// </summary>
        [EnumMember(Value = "2. Eligible")]
        n2Eligible = 2,
        /// <summary>
        /// 3. Certified
        /// </summary>
        [EnumMember(Value = "3. Certified")]
        n3Certified = 3
    }
}