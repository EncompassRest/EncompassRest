using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// ActionTaken
    /// </summary>
    public enum ActionTaken
    {
        /// <summary>
        /// Active Loan
        /// </summary>
        [Description("Active Loan")]
        [EnumMember(Value = "")]
        ActiveLoan = 0,
        /// <summary>
        /// 1. Loan originated
        /// </summary>
        [Description("1. Loan originated")]
        [EnumMember(Value = "Loan Originated")]
        LoanOriginated = 1,
        /// <summary>
        /// 2. Application approved but not accepted
        /// </summary>
        [Description("2. Application approved but not accepted")]
        [EnumMember(Value = "Application approved but not accepted")]
        ApplicationApprovedButNotAccepted = 2,
        /// <summary>
        /// 3. Application denied
        /// </summary>
        [Description("3. Application denied")]
        [EnumMember(Value = "Application denied")]
        ApplicationDenied = 3,
        /// <summary>
        /// 4. Application withdrawn by applicant
        /// </summary>
        [Description("4. Application withdrawn by applicant")]
        [EnumMember(Value = "Application withdrawn")]
        ApplicationWithdrawn = 4,
        /// <summary>
        /// 5. File closed for incompleteness
        /// </summary>
        [Description("5. File closed for incompleteness")]
        [EnumMember(Value = "File Closed for incompleteness")]
        FileClosedForIncompleteness = 5,
        /// <summary>
        /// 6. Purchased loan
        /// </summary>
        [Description("6. Purchased loan")]
        [EnumMember(Value = "Loan purchased by your institution")]
        LoanPurchasedByYourInstitution = 6,
        /// <summary>
        /// 7. Preapproval request denied
        /// </summary>
        [Description("7. Preapproval request denied")]
        [EnumMember(Value = "Preapproval request denied by financial institution")]
        PreapprovalRequestDeniedByFinancialInstitution = 7,
        /// <summary>
        /// 8. Preapproval request approved but not accepted
        /// </summary>
        [Description("8. Preapproval request approved but not accepted")]
        [EnumMember(Value = "Preapproval request approved but not accepted")]
        PreapprovalRequestApprovedButNotAccepted = 8
    }
}