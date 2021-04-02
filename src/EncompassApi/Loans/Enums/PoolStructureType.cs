using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// PoolStructureType
    /// </summary>
    public enum PoolStructureType
    {
        /// <summary>
        /// Investor Defined Multiple Lender
        /// </summary>
        [Description("Investor Defined Multiple Lender")]
        InvestorDefinedMultipleLender = 0,
        /// <summary>
        /// Lender Initiated Multiple Lender
        /// </summary>
        [Description("Lender Initiated Multiple Lender")]
        LenderInitiatedMultipleLender = 1,
        /// <summary>
        /// Single Lender
        /// </summary>
        [Description("Single Lender")]
        SingleLender = 2
    }
}