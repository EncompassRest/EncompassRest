using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// PropertyOccupancyType
    /// </summary>
    public enum PropertyOccupancyType
    {
        /// <summary>
        /// Occupied by owner
        /// </summary>
        [EnumMember(Value = "Occupied by owner")]
        OccupiedByOwner = 0,
        /// <summary>
        /// Never occupied
        /// </summary>
        [EnumMember(Value = "Never occupied")]
        NeverOccupied = 1,
        /// <summary>
        /// Vacant
        /// </summary>
        Vacant = 2,
        /// <summary>
        /// Occupied by tenant
        /// </summary>
        [EnumMember(Value = "Occupied by tenant")]
        OccupiedByTenant = 3
    }
}