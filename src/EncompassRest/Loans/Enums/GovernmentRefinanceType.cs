using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// GovernmentRefinanceType
    /// </summary>
    public enum GovernmentRefinanceType
    {
        /// <summary>
        /// FullDocumentation
        /// </summary>
        FullDocumentation = 0,
        /// <summary>
        /// InterestRateReductionRefinanceLoan
        /// </summary>
        InterestRateReductionRefinanceLoan = 1,
        /// <summary>
        /// Other
        /// </summary>
        Other = 2,
        /// <summary>
        /// StreamlineWithAppraisal
        /// </summary>
        StreamlineWithAppraisal = 3,
        /// <summary>
        /// StreamlineWithoutAppraisal
        /// </summary>
        StreamlineWithoutAppraisal = 4
    }
}