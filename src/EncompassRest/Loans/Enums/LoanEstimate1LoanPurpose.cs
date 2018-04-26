using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// LoanEstimate1LoanPurpose
    /// </summary>
    public enum LoanEstimate1LoanPurpose
    {
        /// <summary>
        /// Purchase
        /// </summary>
        Purchase = 0,
        /// <summary>
        /// Refinance
        /// </summary>
        Refinance = 1,
        /// <summary>
        /// Construction
        /// </summary>
        Construction = 2,
        /// <summary>
        /// Home Equity Loan
        /// </summary>
        [EnumMember(Value = "Home Equity Loan")]
        HomeEquityLoan = 3
    }
}