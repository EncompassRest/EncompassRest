using System.Runtime.Serialization;

namespace EncompassRest.Schema.v3
{
    /// <summary>
    /// PropertyFormat
    /// </summary>
    public enum PropertyFormat
    {
        /// <summary>
        /// date
        /// </summary>
        [EnumMember(Value = "date")]
        Date = 0,
        /// <summary>
        /// date-time
        /// </summary>
        [EnumMember(Value = "date-time")]
        DateTime = 1
    }
}
