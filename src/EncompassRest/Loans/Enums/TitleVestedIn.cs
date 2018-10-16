using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// TitleVestedIn
    /// </summary>
    public enum TitleVestedIn
    {
        /// <summary>
        /// Veteran
        /// </summary>
        Veteran = 0,
        /// <summary>
        /// Veteran &amp; Spouse
        /// </summary>
        [Description("Veteran & Spouse")]
        VeteranAndSpouse = 1,
        /// <summary>
        /// Other
        /// </summary>
        Other = 2
    }
}