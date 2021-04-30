using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// Areas
    /// </summary>
    public enum Areas
    {
        /// <summary>
        /// Targeted Area
        /// </summary>
        [EnumMember(Value = "Targeted Area")]
        TargetedArea = 0,
        /// <summary>
        /// Non-Targeted Area
        /// </summary>
        [EnumMember(Value = "Non-Targeted Area")]
        NonTargetedArea = 1
    }
}