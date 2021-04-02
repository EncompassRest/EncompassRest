using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// SignedByTyp
    /// </summary>
    public enum SignedByTyp
    {
        /// <summary>
        /// Loan Originator
        /// </summary>
        [EnumMember(Value = "Loan Originator")]
        LoanOriginator = 0,
        /// <summary>
        /// Loan Closer
        /// </summary>
        [EnumMember(Value = "Loan Closer")]
        LoanCloser = 1,
        /// <summary>
        /// Lender Contact
        /// </summary>
        [EnumMember(Value = "Lender Contact")]
        LenderContact = 2
    }
}