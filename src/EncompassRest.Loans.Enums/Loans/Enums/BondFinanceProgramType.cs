using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// BondFinanceProgramType
    /// </summary>
    public enum BondFinanceProgramType
    {
        /// <summary>
        /// Builder Bond
        /// </summary>
        [Description("Builder Bond")]
        BuilderBond = 0,
        /// <summary>
        /// Consolidated Bond
        /// </summary>
        [Description("Consolidated Bond")]
        ConsolidatedBond = 1,
        /// <summary>
        /// Final Bond
        /// </summary>
        [Description("Final Bond")]
        FinalBond = 2
    }
}