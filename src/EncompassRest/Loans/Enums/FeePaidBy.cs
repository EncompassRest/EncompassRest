using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FeePaidBy
    /// </summary>
    public enum FeePaidBy
    {
        /// <summary>
        /// Borrower
        /// </summary>
        Borrower = 0,
        /// <summary>
        /// Lender
        /// </summary>
        Lender = 1,
        /// <summary>
        /// Seller
        /// </summary>
        Seller = 2,
        /// <summary>
        /// Broker (Realtor)
        /// </summary>
        [EnumMember(Value = "Broker (Realtor)")]
        BrokerRealtor = 3
    }
}