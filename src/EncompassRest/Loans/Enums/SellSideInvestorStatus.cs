using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum SellSideInvestorStatus
    {
        AssignedBulk = 0,
        AssignedFlow = 1,
        Shipped = 2,
        Purchased = 3,
        Rejected = 4
    }
}