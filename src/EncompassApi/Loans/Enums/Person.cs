using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// Person
    /// </summary>
    public enum Person
    {
        /// <summary>
        /// Borrower
        /// </summary>
        Borrower = 0,
        /// <summary>
        /// Co-Borrower
        /// </summary>
        [Description("Co-Borrower")]
        CoBorrower = 1,
        /// <summary>
        /// Both
        /// </summary>
        Both = 2,
        /// <summary>
        /// Other
        /// </summary>
        Other = 3
    }
}