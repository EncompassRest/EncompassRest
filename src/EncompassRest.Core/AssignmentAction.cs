using System.Runtime.Serialization;

namespace EncompassRest
{
    /// <summary>
    /// AssignmentAction
    /// </summary>
    public enum AssignmentAction
    {
        /// <summary>
        /// add
        /// </summary>
        [EnumMember(Value = "add")]
        Add = 0,
        /// <summary>
        /// remove
        /// </summary>
        [EnumMember(Value = "remove")]
        Remove = 1
    }
}