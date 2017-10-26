using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum WhoPaidCompensation
    {
        [EnumMember(Value = "Lender Paid")]
        LenderPaid = 0,
        [EnumMember(Value = "Borrower Paid")]
        BorrowerPaid = 1,
        Exempt = 2
    }
}