using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum DoesOrDoesNot
    {
        Does = 0,
        [EnumMember(Value = "Does not")]
        DoesNot = 1
    }
}