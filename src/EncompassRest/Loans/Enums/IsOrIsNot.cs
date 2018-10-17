using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// IsOrIsNot
    /// </summary>
    public enum IsOrIsNot
    {
        /// <summary>
        /// is not
        /// </summary>
        [EnumMember(Value = "is not")]
        IsNot = 0,
        /// <summary>
        /// is
        /// </summary>
        [EnumMember(Value = "is")]
        Is = 1
    }
}