using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// UsdaLoanType
    /// </summary>
    public enum UsdaLoanType
    {
        /// <summary>
        /// Section 502
        /// </summary>
        [EnumMember(Value = "Section 502")]
        Section502 = 0,
        /// <summary>
        /// Section 504 Loan
        /// </summary>
        [EnumMember(Value = "Section 504 Loan")]
        Section504Loan = 1,
        /// <summary>
        /// Grant
        /// </summary>
        Grant = 2
    }
}