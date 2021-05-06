using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// ATRQMStatus
    /// </summary>
    public enum ATRQMStatus
    {
        /// <summary>
        /// Meets Standard
        /// </summary>
        [EnumMember(Value = "Meets Standard")]
        MeetsStandard = 0,
        /// <summary>
        /// Not Meet
        /// </summary>
        [EnumMember(Value = "Not Meet")]
        NotMeet = 1,
        /// <summary>
        /// Reviewed
        /// </summary>
        [Description("Reviewed")]
        [EnumMember(Value = "Review Needed")]
        ReviewNeeded = 2
    }
}