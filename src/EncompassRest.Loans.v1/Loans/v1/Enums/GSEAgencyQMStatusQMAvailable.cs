using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// GSEAgencyQMStatusQMAvailable
    /// </summary>
    public enum GSEAgencyQMStatusQMAvailable
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
        /// NA
        /// </summary>
        NA = 2
    }
}