using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// AffiliateType
    /// </summary>
    public enum AffiliateType
    {
        /// <summary>
        /// We do not have affiliates
        /// </summary>
        [EnumMember(Value = "We do not have affiliates")]
        WeDoNotHaveAffiliates = 0,
        /// <summary>
        /// We have affiliates but do not share personal information with them
        /// </summary>
        [EnumMember(Value = "We have affiliates but do not share personal information with them")]
        WeHaveAffiliatesButDoNotSharePersonalInformationWithThem = 1,
        /// <summary>
        /// We have affiliates and share personal information with them
        /// </summary>
        [EnumMember(Value = "We have affiliates and share personal information with them")]
        WeHaveAffiliatesAndSharePersonalInformationWithThem = 2
    }
}