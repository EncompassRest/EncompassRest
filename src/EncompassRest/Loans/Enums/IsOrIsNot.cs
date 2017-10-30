using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum IsOrIsNot
    {
        [EnumMember(Value = "is not")]
        IsNot = 0,
        [EnumMember(Value = "is")]
        Is = 1
    }
}