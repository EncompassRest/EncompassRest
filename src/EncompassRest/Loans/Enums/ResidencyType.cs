using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// ResidencyType
    /// </summary>
    public enum ResidencyType
    {
        /// <summary>
        /// Owner-Occupant
        /// </summary>
        [Description("Owner-Occupant")]
        OwnedOccupant = 0,
        /// <summary>
        /// Government Agency
        /// </summary>
        [Description("Government Agency")]
        GovernmentAgency = 1,
        /// <summary>
        /// Nonprofit
        /// </summary>
        Nonprofit = 2
    }
}