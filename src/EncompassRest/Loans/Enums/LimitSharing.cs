using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// LimitSharing
    /// </summary>
    public enum LimitSharing
    {
        /// <summary>
        /// No
        /// </summary>
        No = 0,
        /// <summary>
        /// Yes
        /// </summary>
        Yes = 1,
        /// <summary>
        /// We Don't Share
        /// </summary>
        [EnumMember(Value = "We Don't Share")]
        WeDontShare = 2
    }
}