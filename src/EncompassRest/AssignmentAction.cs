using System.Runtime.Serialization;

namespace EncompassRest
{
    /// <summary>
    /// AssignmentAction
    /// </summary>
    public enum AssignmentAction
    {
        /// <summary>
        /// Add
        /// </summary>
        [EnumMember(Value = "add")]
        Add = 0,
        /// <summary>
        /// Remove
        /// </summary>
        [EnumMember(Value = "remove")]
        Remove = 1
    }
}