using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum BrokerForPlacingLoan
    {
        [EnumMember(Value = "Is Not")]
        IsNot = 0,
        Is = 1
    }
}