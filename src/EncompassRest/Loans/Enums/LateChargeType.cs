using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LateChargeType
    {
        [EnumMember(Value = "of the payment")]
        OfThePayment = 0,
        [EnumMember(Value = "of the overdue payment")]
        OfTheOverduePayment = 1,
        [EnumMember(Value = "of the interest payment due")]
        OfTheInterestPaymentDue = 2,
        [EnumMember(Value = "of the principal and interest overdue")]
        OfThePrincipalAndInterestOverdue = 3
    }
}