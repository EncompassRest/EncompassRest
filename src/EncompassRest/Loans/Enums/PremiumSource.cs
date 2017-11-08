using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PremiumSource
    {
        [EnumMember(Value = "Borrower Paid")]
        BorrowerPaid = 0,
        [EnumMember(Value = "Lender Paid")]
        LenderPaid = 1,
        [EnumMember(Value = "Lender Paid Option 2")]
        LenderPaidOption2 = 2
    }
}