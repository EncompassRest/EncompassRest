using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// PreferredAus
    /// </summary>
    public enum PreferredAus
    {
        /// <summary>
        /// No Preference
        /// </summary>
        [Description("No Preference")]
        NoPreference = 0,
        /// <summary>
        /// DU
        /// </summary>
        DU = 1,
        /// <summary>
        /// LPA
        /// </summary>
        LPA = 2
    }
}