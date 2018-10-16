using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// GuaranteeType
    /// </summary>
    public enum GuaranteeType
    {
        /// <summary>
        /// 1. Line of Credit
        /// </summary>
        [EnumMember(Value = "1. Line of Credit")]
        n1LineOfCredit = 1,
        /// <summary>
        /// 2. Loan Note Guarantee
        /// </summary>
        [EnumMember(Value = "2. Loan Note Guarantee")]
        n2LoanNoteGuarantee = 2
    }
}