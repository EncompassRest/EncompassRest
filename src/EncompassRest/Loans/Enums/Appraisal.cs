using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum Appraisal
    {
        [EnumMember(Value = "Omit from print")]
        OmitFromPrint = 0,
        [EnumMember(Value = "Use Section 35")]
        UseSection35 = 1
    }
}