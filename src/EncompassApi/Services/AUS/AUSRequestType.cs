using System.Runtime.Serialization;

namespace EncompassApi.Services.AUS
{
    /// <summary>
    /// AUSRequestType
    /// </summary>
    public enum AUSRequestType
    {
        /// <summary>
        /// newOrder
        /// </summary>
        [EnumMember(Value = "newOrder")]
        NewOrder = 0,
        /// <summary>
        /// reissue
        /// </summary>
        [EnumMember(Value = "reissue")]
        Reissue = 1
    }
}