using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// PrintSelection
    /// </summary>
    public enum PrintSelection
    {
        /// <summary>
        /// Affiliate Opt-Out
        /// </summary>
        [EnumMember(Value = "Affiliate Opt-Out")]
        AffiliateOptOut = 0,
        /// <summary>
        /// Affiliate No Opt-Out
        /// </summary>
        [EnumMember(Value = "Affiliate No Opt-Out")]
        AffiliateNoOptOut = 1,
        /// <summary>
        /// No Affiliate Opt-Out
        /// </summary>
        [EnumMember(Value = "No Affiliate Opt-Out")]
        NoAffiliateOptOut = 2,
        /// <summary>
        /// No Affiliate No Opt-Out
        /// </summary>
        [EnumMember(Value = "No Affiliate No Opt-Out")]
        NoAffiliateNoOptOut = 3
    }
}