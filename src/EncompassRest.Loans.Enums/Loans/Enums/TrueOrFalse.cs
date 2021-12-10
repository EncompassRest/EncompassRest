using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// TrueOrFalse
    /// </summary>
    public enum TrueOrFalse
    {
        /// <summary>
        /// false
        /// </summary>
        [EnumMember(Value = "false")]
        False = 0,
        /// <summary>
        /// true
        /// </summary>
        [EnumMember(Value = "true")]
        True = 1
    }
}