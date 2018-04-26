using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// BuildingType
    /// </summary>
    public enum BuildingType
    {
        /// <summary>
        /// Detached
        /// </summary>
        Detached = 0,
        /// <summary>
        /// Semi-Detached
        /// </summary>
        [EnumMember(Value = "Semi-Detached")]
        SemiDetached = 1,
        /// <summary>
        /// Row
        /// </summary>
        Row = 2,
        /// <summary>
        /// Apt Unit
        /// </summary>
        [EnumMember(Value = "Apt Unit")]
        AptUnit = 3
    }
}