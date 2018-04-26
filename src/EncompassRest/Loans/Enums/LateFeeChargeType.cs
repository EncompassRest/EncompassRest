using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// LateFeeChargeType
    /// </summary>
    public enum LateFeeChargeType
    {
        /// <summary>
        /// Total Loan Amount
        /// </summary>
        [EnumMember(Value = "Total Loan Amount")]
        TotalLoanAmount = 0,
        /// <summary>
        /// Base Loan Amount
        /// </summary>
        [EnumMember(Value = "Base Loan Amount")]
        BaseLoanAmount = 1
    }
}