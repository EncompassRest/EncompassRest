using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum Person
    {
        Borrower = 0,
        CoBorrower = 1,
        Both = 2,
        Other = 3
    }
}