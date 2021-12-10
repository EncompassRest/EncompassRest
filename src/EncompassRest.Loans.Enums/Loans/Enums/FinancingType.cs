using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FinancingType
    /// </summary>
    public enum FinancingType
    {
        /// <summary>
        /// All
        /// </summary>
        [Description("All")]
        FinancingAll = 0,
        /// <summary>
        /// Portion
        /// </summary>
        [Description("Portion")]
        FinancingPortion = 1
    }
}