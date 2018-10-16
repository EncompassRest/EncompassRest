using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// CorrespondentStatus
    /// </summary>
    public enum CorrespondentStatus
    {
        /// <summary>
        /// Loan Received (Delivered)
        /// </summary>
        [EnumMember(Value = "Loan Received (Delivered)")]
        LoanReceivedDelivered = 0,
        /// <summary>
        /// Submitted for Review
        /// </summary>
        [EnumMember(Value = "Submitted for Review")]
        SubmittedForReview = 1,
        /// <summary>
        /// Purchase Suspense
        /// </summary>
        [EnumMember(Value = "Purchase Suspense")]
        PurchaseSuspense = 2,
        /// <summary>
        /// Purchase Approval
        /// </summary>
        [EnumMember(Value = "Purchase Approval")]
        PurchaseApproval = 3,
        /// <summary>
        /// Cleared for Purchase
        /// </summary>
        [EnumMember(Value = "Cleared for Purchase")]
        ClearedForPurchase = 4,
        /// <summary>
        /// Purchased
        /// </summary>
        Purchased = 5,
        /// <summary>
        /// Rejected
        /// </summary>
        Rejected = 6,
        /// <summary>
        /// Withdrawn
        /// </summary>
        Withdrawn = 7,
        /// <summary>
        /// Cancelled
        /// </summary>
        Cancelled = 8,
        /// <summary>
        /// Voided
        /// </summary>
        Voided = 9
    }
}