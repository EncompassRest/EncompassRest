using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// CollateralRepandWarrReliefEligibilityType
    /// </summary>
    public enum CollateralRepandWarrReliefEligibilityType
    {
        /// <summary>
        /// Eligible
        /// </summary>
        Eligible = 0,
        /// <summary>
        /// Not Eligible
        /// </summary>
        [Description("Not Eligible")]
        NotEligible = 1,
        /// <summary>
        /// Unavailable
        /// </summary>
        Unavailable = 2
    }
}