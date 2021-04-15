using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// CorrespondentRefinanceType
    /// </summary>
    public enum CorrespondentRefinanceType
    {
        /// <summary>
        /// Lender to Lender Refi
        /// </summary>
        [Description("Lender to Lender Refi")]
        LendertoLenderRefi = 0,
        /// <summary>
        /// New Construction
        /// </summary>
        [Description("New Construction")]
        NewConstruction = 1
    }
}