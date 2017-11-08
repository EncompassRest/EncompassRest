using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PenaltyChargeMoreThan36Months
    {
        [EnumMember(Value = "will")]
        Will = 0,
        [EnumMember(Value = "will not")]
        WillNot = 1
    }
}