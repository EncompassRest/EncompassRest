using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum DoesOrDoesNot2
    {
        [EnumMember(Value = "does not")]
        DoesNot = 0,
        [EnumMember(Value = "does")]
        Does = 1
    }
}