using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// WeAreAbleType
    /// </summary>
    public enum WeAreAbleType
    {
        /// <summary>
        /// will not
        /// </summary>
        [EnumMember(Value = "will not")]
        WillNot = 0,
        /// <summary>
        /// will
        /// </summary>
        [EnumMember(Value = "will")]
        Will = 1,
        /// <summary>
        /// haven't decided to
        /// </summary>
        [EnumMember(Value = "haven't decided to")]
        HaventDecidedTo = 2
    }
}