using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// AlsoCollectFrom
    /// </summary>
    public enum AlsoCollectFrom
    {
        /// <summary>
        /// We also collect your personal information from others, such as credit bureaus, affiliates, or other companies
        /// </summary>
        [EnumMember(Value = "We also collect your personal information from others, such as credit bureaus, affiliates, or other companies")]
        WeAlsoCollectYourPersonalInformationFromOthersSuchAsCreditBureausAffiliatesOrOtherCompanies = 0,
        /// <summary>
        /// We also collect your personal information from other companies
        /// </summary>
        [EnumMember(Value = "We also collect your personal information from other companies")]
        WeAlsoCollectYourPersonalInformationFromOtherCompanies = 1
    }
}