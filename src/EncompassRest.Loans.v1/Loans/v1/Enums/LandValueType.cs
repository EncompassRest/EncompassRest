using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// LandValueType
    /// </summary>
    public enum LandValueType
    {
        /// <summary>
        /// Original
        /// </summary>
        Original = 0,
        /// <summary>
        /// Appraised
        /// </summary>
        Appraised = 1,
        /// <summary>
        /// Not Applicable
        /// </summary>
        [Description("Not Applicable")]
        NotApplicable = 2
    }
}