using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// NonaffiliateType
    /// </summary>
    public enum NonaffiliateType
    {
        /// <summary>
        /// We do not share personal information with nonaffiliated third parties
        /// </summary>
        [EnumMember(Value = "We do not share personal information with nonaffiliated third parties")]
        WeDoNotSharePersonalInformationWithNonaffiliatedThirdParties = 0,
        /// <summary>
        /// We share personal information with nonaffiliated third parties
        /// </summary>
        [EnumMember(Value = "We share personal information with nonaffiliated third parties")]
        WeSharePersonalInformationWithNonaffiliatedThirdParties = 1
    }
}