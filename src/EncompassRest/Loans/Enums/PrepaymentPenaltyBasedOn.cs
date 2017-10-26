using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PrepaymentPenaltyBasedOn
    {
        [EnumMember(Value = "Original Principal Amount")]
        OriginalPrincipalAmount = 0,
        [EnumMember(Value = "Amount Prepaid")]
        AmountPrepaid = 1,
        [EnumMember(Value = "Unpaid Balance")]
        UnpaidBalance = 2
    }
}