using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
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