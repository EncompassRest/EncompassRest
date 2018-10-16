using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// PremiumSource
    /// </summary>
    public enum PremiumSource
    {
        /// <summary>
        /// Borrower Paid
        /// </summary>
        [EnumMember(Value = "Borrower Paid")]
        BorrowerPaid = 0,
        /// <summary>
        /// Lender Paid
        /// </summary>
        [EnumMember(Value = "Lender Paid")]
        LenderPaid = 1,
        /// <summary>
        /// Lender Paid Option 2
        /// </summary>
        [EnumMember(Value = "Lender Paid Option 2")]
        LenderPaidOption2 = 2
    }
}