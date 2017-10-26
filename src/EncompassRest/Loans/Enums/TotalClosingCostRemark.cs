using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum TotalClosingCostRemark
    {
        [EnumMember(Value = "Total Loan Costs (D)")]
        TotalLoanCostsD = 0,
        [EnumMember(Value = "Total Other Costs (I)")]
        TotalOtherCostsI = 1,
        [EnumMember(Value = "Total Loan Costs (D) and Total Other Costs (I)")]
        TotalLoanCostsDAndTotalOtherCostsI = 2
    }
}