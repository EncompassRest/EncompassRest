using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum GuaranteeFeePurposeCodeType
    {
        [EnumMember(Value = "1. Substitution")]
        n1Substitution = 1,
        [EnumMember(Value = "2. Extension")]
        n2Extension = 2,
        [EnumMember(Value = "3. Initial Closing Fee")]
        n3InitialClosingFee = 3,
        [EnumMember(Value = "4. Second Half Payment")]
        n4SecondHalfPayment = 4,
        [EnumMember(Value = "5. Consolidation")]
        n5Consolidation = 5,
        [EnumMember(Value = "6. Reserved")]
        n6Reserved = 6,
        [EnumMember(Value = "7. Initial Closing")]
        n7InitialClosing = 7
    }
}