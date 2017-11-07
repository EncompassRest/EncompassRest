using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PaymentOfPrincipleType
    {
        [EnumMember(Value = "Original Balance")]
        OriginalBalance = 0,
        [EnumMember(Value = "Unpaid Balance")]
        UnpaidBalance = 1
    }
}