using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// Owner
    /// </summary>
    public enum Owner
    {
        /// <summary>
        /// Borrower
        /// </summary>
        Borrower = 0,
        /// <summary>
        /// CoBorrower
        /// </summary>
        CoBorrower = 1,
        /// <summary>
        /// Both
        /// </summary>
        Both = 2
    }
}