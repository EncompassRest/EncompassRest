using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// HelocTAIntroRateAppliedOn
    /// </summary>
    public enum HelocTAIntroRateAppliedOn
    {
        /// <summary>
        /// last day
        /// </summary>
        [EnumMember(Value = "last day")]
        LastDay = 0,
        /// <summary>
        /// first day
        /// </summary>
        [EnumMember(Value = "first day")]
        FirstDay = 1
    }
}