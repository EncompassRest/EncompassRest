using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PrintSelection
    {
        [EnumMember(Value = "Affiliate Opt-Out")]
        AffiliateOptOut = 0,
        [EnumMember(Value = "Affiliate No Opt-Out")]
        AffiliateNoOptOut = 1,
        [EnumMember(Value = "No Affiliate Opt-Out")]
        NoAffiliateOptOut = 2,
        [EnumMember(Value = "No Affiliate No Opt-Out")]
        NoAffiliateNoOptOut = 3
    }
}