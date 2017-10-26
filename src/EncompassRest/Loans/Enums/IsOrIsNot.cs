using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum IsOrIsNot
    {
        [EnumMember(Value = "is")]
        Is = 0,
        [EnumMember(Value = "is not")]
        IsNot = 1
    }
}