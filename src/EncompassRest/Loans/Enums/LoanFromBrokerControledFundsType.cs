using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LoanFromBrokerControledFundsType
    {
        [EnumMember(Value = "may")]
        May = 0,
        [EnumMember(Value = "will")]
        Will = 1,
        [EnumMember(Value = "will not")]
        WillNot = 2
    }
}