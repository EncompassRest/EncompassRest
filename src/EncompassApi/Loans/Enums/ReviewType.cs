using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// ReviewType
    /// </summary>
    public enum ReviewType
    {
        /// <summary>
        /// Full
        /// </summary>
        Full = 0,
        /// <summary>
        /// Drive By
        /// </summary>
        [EnumMember(Value = "Drive By")]
        DriveBy = 1,
        /// <summary>
        /// Desk
        /// </summary>
        Desk = 2
    }
}