using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum NonaffiliateType
    {
        [EnumMember(Value = "We do not share personal information with nonaffiliated third parties")]
        WeDoNotSharePersonalInformationWithNonaffiliatedThirdParties = 0,
        [EnumMember(Value = "We share personal information with nonaffiliated third parties")]
        WeSharePersonalInformationWithNonaffiliatedThirdParties = 1
    }
}