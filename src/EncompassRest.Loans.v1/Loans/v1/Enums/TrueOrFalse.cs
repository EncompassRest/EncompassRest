using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
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