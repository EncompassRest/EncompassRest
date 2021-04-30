using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// PaidToOrBy
    /// </summary>
    public enum PaidToOrBy
    {
        /// <summary>
        /// Borrower
        /// </summary>
        Borrower = 0,
        /// <summary>
        /// Seller
        /// </summary>
        Seller = 1,
        /// <summary>
        /// Lender
        /// </summary>
        Lender = 2,
        /// <summary>
        /// Broker (Realtor)
        /// </summary>
        [EnumMember(Value = "Broker (Realtor)")]
        BrokerRealtor = 3
    }
}