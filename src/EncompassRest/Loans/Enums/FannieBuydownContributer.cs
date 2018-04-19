using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FannieBuydownContributer
    /// </summary>
    public enum FannieBuydownContributer
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
        /// Other
        /// </summary>
        Other = 2
    }
}