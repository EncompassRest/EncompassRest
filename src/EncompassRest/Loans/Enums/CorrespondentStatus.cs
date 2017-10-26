using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum CorrespondentStatus
    {
        [EnumMember(Value = "Loan Received (Delivered)")]
        LoanReceivedDelivered = 0,
        [EnumMember(Value = "Submitted for Review")]
        SubmittedForReview = 1,
        [EnumMember(Value = "Purchase Suspense")]
        PurchaseSuspense = 2,
        [EnumMember(Value = "Purchase Approval")]
        PurchaseApproval = 3,
        [EnumMember(Value = "Cleared for Purchase")]
        ClearedForPurchase = 4,
        Purchased = 5,
        Rejected = 6,
        Withdrawn = 7,
        Cancelled = 8,
        Voided = 9
    }
}