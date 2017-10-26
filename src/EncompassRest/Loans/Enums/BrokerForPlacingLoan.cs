using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum BrokerForPlacingLoan
    {
        Is = 0,
        [EnumMember(Value = "Is Not")]
        IsNot = 1
    }
}