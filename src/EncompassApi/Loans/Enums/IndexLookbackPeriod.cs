using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// IndexLookbackPeriod
    /// </summary>
    public enum IndexLookbackPeriod
    {
        /// <summary>
        /// First Business Day
        /// </summary>
        [EnumMember(Value = "First Business Day")]
        FirstBusinessDay = 1,
        /// <summary>
        /// 30 days
        /// </summary>
        [EnumMember(Value = "30 days")]
        n30Days = 30,
        /// <summary>
        /// 45 days
        /// </summary>
        [EnumMember(Value = "45 days")]
        n45Days = 45
    }
}