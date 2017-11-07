using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FreddieAutoUWDec
    {
        [EnumMember(Value = "A1 Accept")]
        A1Accept = 0,
        [EnumMember(Value = "A2 Accept")]
        A2Accept = 1,
        Accept = 2,
        Approve = 3,
        [EnumMember(Value = "Approve Eligible")]
        ApproveEligible = 4,
        [EnumMember(Value = "C1 Caution")]
        C1Caution = 5,
        [EnumMember(Value = "C2 Caution")]
        C2Caution = 6,
        Caution = 7,
        [EnumMember(Value = "Caution Eligible For A Minus")]
        CautionEligibleForAMinus = 8
    }
}