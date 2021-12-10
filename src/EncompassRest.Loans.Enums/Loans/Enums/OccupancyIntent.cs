using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// OccupancyIntent
    /// </summary>
    public enum OccupancyIntent
    {
        /// <summary>
        /// Will Occupy
        /// </summary>
        [EnumMember(Value = "Will Occupy")]
        WillOccupy = 0,
        /// <summary>
        /// Will Not Occupy
        /// </summary>
        [EnumMember(Value = "Will Not Occupy")]
        WillNotOccupy = 1,
        /// <summary>
        /// Currently Occupy
        /// </summary>
        [EnumMember(Value = "Currently Occupy")]
        CurrentlyOccupy = 2
    }
}