using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// GuaranteeFeePurposeCodeType
    /// </summary>
    public enum GuaranteeFeePurposeCodeType
    {
        /// <summary>
        /// 1. Substitution
        /// </summary>
        [EnumMember(Value = "1. Substitution")]
        n1Substitution = 1,
        /// <summary>
        /// 2. Extension
        /// </summary>
        [EnumMember(Value = "2. Extension")]
        n2Extension = 2,
        /// <summary>
        /// 3. Initial Closing Fee
        /// </summary>
        [EnumMember(Value = "3. Initial Closing Fee")]
        n3InitialClosingFee = 3,
        /// <summary>
        /// 4. Second Half Payment
        /// </summary>
        [EnumMember(Value = "4. Second Half Payment")]
        n4SecondHalfPayment = 4,
        /// <summary>
        /// 5. Consolidation
        /// </summary>
        [EnumMember(Value = "5. Consolidation")]
        n5Consolidation = 5,
        /// <summary>
        /// 6. Reserved
        /// </summary>
        [EnumMember(Value = "6. Reserved")]
        n6Reserved = 6,
        /// <summary>
        /// 7. Initial Closing
        /// </summary>
        [EnumMember(Value = "7. Initial Closing")]
        n7InitialClosing = 7
    }
}