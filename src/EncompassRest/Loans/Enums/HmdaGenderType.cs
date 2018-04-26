using System.ComponentModel;
using System.Runtime.Serialization;

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
        /// I do not wish to provide this information
        /// </summary>
        [Description("I do not wish to provide this information")]
        InformationNotProvidedUnknown = 2,
        /// <summary>
        /// Not Applicable
        /// </summary>
        [Description("Not Applicable")]
        NotApplicable = 3
    }
}