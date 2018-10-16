using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// HmdaGenderType
    /// </summary>
    public enum HmdaGenderType
    {
        /// <summary>
        /// Male
        /// </summary>
        Male = 0,
        /// <summary>
        /// Female
        /// </summary>
        Female = 1,
        /// <summary>
        /// Not Provided/Unknown
        /// </summary>
        [Description("Not Provided/Unknown")]
        InformationNotProvidedUnknown = 2,
        /// <summary>
        /// Not Applicable
        /// </summary>
        [Description("Not Applicable")]
        NotApplicable = 3
    }
}