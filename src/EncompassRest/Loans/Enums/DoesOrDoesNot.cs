using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum DoesOrDoesNot
    {
        [EnumMember(Value = "Does not")]
        DoesNot = 0,
        Does = 1
    }
}