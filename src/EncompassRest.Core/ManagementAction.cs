using System.Runtime.Serialization;

namespace EncompassRest
{
    /// <summary>
    /// ManagementAction
    /// </summary>
    public enum ManagementAction
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
        Remove = 1,
        /// <summary>
        /// update
        /// </summary>
        [EnumMember(Value = "update")]
        Update = 2
    }
}