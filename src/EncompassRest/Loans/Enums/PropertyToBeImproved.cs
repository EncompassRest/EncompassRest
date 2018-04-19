using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// PropertyToBeImproved
    /// </summary>
    public enum PropertyToBeImproved
    {
        /// <summary>
        /// Manufactured home
        /// </summary>
        [Description("Manufactured home")]
        ManufacturedHome = 0,
        /// <summary>
        /// Single family
        /// </summary>
        [Description("Single family")]
        SingleFamily = 1,
        /// <summary>
        /// Historic residential
        /// </summary>
        [Description("Historic residential")]
        HistoricResidential = 2,
        /// <summary>
        /// Health care facility
        /// </summary>
        [Description("Health care facility")]
        HealthcareFacility = 3,
        /// <summary>
        /// Nonresidential
        /// </summary>
        Nonresidential = 4,
        /// <summary>
        /// Multifamily
        /// </summary>
        [Description("Multifamily")]
        MultiFamily = 5
    }
}