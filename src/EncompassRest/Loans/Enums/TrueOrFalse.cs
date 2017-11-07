using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum TrueOrFalse
    {
        [EnumMember(Value = "false")]
        False = 0,
        [EnumMember(Value = "true")]
        True = 1
    }
}