using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// BorrowerOrCoBorrower
    /// </summary>
    public enum BorrowerOrCoBorrower
    {
        /// <summary>
        /// Borrower
        /// </summary>
        Borrower = 0,
        /// <summary>
        /// CoBorrower
        /// </summary>
        CoBorrower = 1
    }
}