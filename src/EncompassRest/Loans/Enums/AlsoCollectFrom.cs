using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum AlsoCollectFrom
    {
        [EnumMember(Value = "We also collect your personal information from others, such as credit bureaus, affiliates, or other companies")]
        WeAlsoCollectYourPersonalInformationFromOthersSuchAsCreditBureausAffiliatesOrOtherCompanies = 0,
        [EnumMember(Value = "We also collect your personal information from other companies")]
        WeAlsoCollectYourPersonalInformationFromOtherCompanies = 1
    }
}