using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum TrueOrFalse
    {
        [EnumMember(Value = "true")]
        True = 0,
        [EnumMember(Value = "false")]
        False = 1
    }
}