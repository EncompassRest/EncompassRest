using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FeePaidBy
    {
        Borrower = 0,
        Lender = 1,
        Seller = 2,
        [EnumMember(Value = "Broker (Realtor)")]
        BrokerRealtor = 3
    }
}