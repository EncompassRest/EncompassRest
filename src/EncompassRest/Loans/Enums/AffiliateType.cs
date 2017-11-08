using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum AffiliateType
    {
        [EnumMember(Value = "We do not have affiliates")]
        WeDoNotHaveAffiliates = 0,
        [EnumMember(Value = "We have affiliates but do not share personal information with them")]
        WeHaveAffiliatesButDoNotSharePersonalInformationWithThem = 1,
        [EnumMember(Value = "We have affiliates and share personal information with them")]
        WeHaveAffiliatesAndSharePersonalInformationWithThem = 2
    }
}