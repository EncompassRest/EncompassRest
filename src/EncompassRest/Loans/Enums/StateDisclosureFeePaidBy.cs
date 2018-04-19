using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// StateDisclosureFeePaidBy
    /// </summary>
    public enum StateDisclosureFeePaidBy
    {
        /// <summary>
        /// Borrower
        /// </summary>
        Borrower = 0,
        /// <summary>
        /// Lender
        /// </summary>
        Lender = 1,
        /// <summary>
        /// Seller
        /// </summary>
        Seller = 2
    }
}