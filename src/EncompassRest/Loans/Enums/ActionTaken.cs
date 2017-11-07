using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ActionTaken
    {
        [EnumMember(Value = "Loan Originated")]
        LoanOriginated = 0,
        [EnumMember(Value = "Application approved but not accepted")]
        ApplicationApprovedButNotAccepted = 1,
        [EnumMember(Value = "Application denied")]
        ApplicationDenied = 2,
        [EnumMember(Value = "Application withdrawn")]
        ApplicationWithdrawn = 3,
        [EnumMember(Value = "File Closed for incompleteness")]
        FileClosedForIncompleteness = 4,
        [EnumMember(Value = "Loan purchased by your institution")]
        LoanPurchasedByYourInstitution = 5,
        [EnumMember(Value = "Preapproval request denied by financial institution")]
        PreapprovalRequestDeniedByFinancialInstitution = 6,
        [EnumMember(Value = "Preapproval request approved but not accepted")]
        PreapprovalRequestApprovedButNotAccepted = 7
    }
}