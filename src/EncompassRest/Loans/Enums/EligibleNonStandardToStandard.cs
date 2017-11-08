using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum EligibleNonStandardToStandard
    {
        May = 0,
        [EnumMember(Value = "May Not")]
        MayNot = 1
    }
}