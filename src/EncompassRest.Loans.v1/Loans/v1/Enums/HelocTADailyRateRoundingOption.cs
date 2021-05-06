using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// HelocTADailyRateRoundingOption
    /// </summary>
    public enum HelocTADailyRateRoundingOption
    {
        /// <summary>
        /// to the nearest
        /// </summary>
        [EnumMember(Value = "to the nearest")]
        ToTheNearest = 0,
        /// <summary>
        /// down to the nearest
        /// </summary>
        [EnumMember(Value = "down to the nearest")]
        DownToTheNearest = 1,
        /// <summary>
        /// up to the nearest
        /// </summary>
        [EnumMember(Value = "up to the nearest")]
        UpToTheNearest = 2
    }
}