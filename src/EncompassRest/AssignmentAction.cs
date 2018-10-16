using System.Runtime.Serialization;

namespace EncompassRest
{
    public enum AssignmentAction
    {
        [EnumMember(Value = "add")]
        Add = 0,
        [EnumMember(Value = "remove")]
        Remove = 1
    }
}