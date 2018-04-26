using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// VaLoanSummaryApplicantType
    /// </summary>
    public enum VaLoanSummaryApplicantType
    {
        /// <summary>
        /// Borrower
        /// </summary>
        Borrower = 0,
        /// <summary>
        /// Co-Borrower
        /// </summary>
        [Description("Co-Borrower")]
        CoBorrower = 1
    }
}