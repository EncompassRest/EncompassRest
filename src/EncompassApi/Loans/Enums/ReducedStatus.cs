using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// ReducedStatus
    /// </summary>
    public enum ReducedStatus
    {
        /// <summary>
        /// did not change
        /// </summary>
        [EnumMember(Value = "did not change")]
        DidNotChange = 0,
        /// <summary>
        /// increased
        /// </summary>
        [EnumMember(Value = "increased")]
        Increased = 1,
        /// <summary>
        /// decreased
        /// </summary>
        [EnumMember(Value = "decreased")]
        Decreased = 2
    }
}