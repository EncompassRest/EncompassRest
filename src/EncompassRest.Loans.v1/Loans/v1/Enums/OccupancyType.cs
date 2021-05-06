using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// OccupancyType
    /// </summary>
    public enum OccupancyType
    {
        /// <summary>
        /// Owner Occupied
        /// </summary>
        [Description("Owner Occupied")]
        OwnerOccupied = 0,
        /// <summary>
        /// Non-Owner Occupied
        /// </summary>
        [Description("Non-Owner Occupied")]
        NonOwnerOccupied = 1
    }
}