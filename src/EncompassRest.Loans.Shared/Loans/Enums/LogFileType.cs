using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// LogFileType
    /// </summary>
    public enum LogFileType
    {
        /// <summary>
        /// ULDD
        /// </summary>
        ULDD = 0,
        /// <summary>
        /// 1003
        /// </summary>
        [EnumMember(Value = "1003")]
        n1003 = 1,
        /// <summary>
        /// ULAD
        /// </summary>
        ULAD = 2
    }
}