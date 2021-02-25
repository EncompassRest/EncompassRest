using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// FundsTypeDescription
    /// </summary>
    public enum FundsTypeDescription
    {
        /// <summary>
        /// Aggregated Remaining Types
        /// </summary>
        [Description("Aggregated Remaining Types")]
        AggregatedRemainingTypes = 0,
        /// <summary>
        /// Secondary Financing Closed End
        /// </summary>
        [Description("Secondary Financing Closed End")]
        SecondaryFinancingClosedEnd = 1,
        /// <summary>
        /// Secondary Financing HELOC
        /// </summary>
        [Description("Secondary Financing HELOC")]
        SecondaryFinancingHELOC = 2,
        /// <summary>
        /// Grant
        /// </summary>
        Grant = 3
    }
}