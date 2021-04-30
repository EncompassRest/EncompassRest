using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// AppraisalMade
    /// </summary>
    public enum AppraisalMade
    {
        /// <summary>
        /// As Is
        /// </summary>
        [EnumMember(Value = "As Is")]
        AsIs = 0,
        /// <summary>
        /// As Improved
        /// </summary>
        [EnumMember(Value = "As Improved")]
        AsImproved = 1
    }
}