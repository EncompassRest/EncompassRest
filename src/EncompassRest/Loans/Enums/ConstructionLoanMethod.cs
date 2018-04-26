using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// ConstructionLoanMethod
    /// </summary>
    public enum ConstructionLoanMethod
    {
        /// <summary>
        /// A (Half Loan)
        /// </summary>
        [Description("A (Half Loan)")]
        A = 0,
        /// <summary>
        /// B (Full Loan)
        /// </summary>
        [Description("B (Full Loan)")]
        B = 1
    }
}