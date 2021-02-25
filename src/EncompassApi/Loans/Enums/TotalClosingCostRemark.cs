using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// TotalClosingCostRemark
    /// </summary>
    public enum TotalClosingCostRemark
    {
        /// <summary>
        /// Total Loan Costs (D)
        /// </summary>
        [EnumMember(Value = "Total Loan Costs (D)")]
        TotalLoanCostsD = 0,
        /// <summary>
        /// Total Other Costs (I)
        /// </summary>
        [EnumMember(Value = "Total Other Costs (I)")]
        TotalOtherCostsI = 1,
        /// <summary>
        /// Total Loan Costs (D) and Total Other Costs (I)
        /// </summary>
        [EnumMember(Value = "Total Loan Costs (D) and Total Other Costs (I)")]
        TotalLoanCostsDAndTotalOtherCostsI = 2
    }
}