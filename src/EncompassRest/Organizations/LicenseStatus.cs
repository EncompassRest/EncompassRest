using System.Runtime.Serialization;

namespace EncompassRest.Organizations
{
    public enum LicenseStatus
    {
        [EnumMember(Value = "Transition Requested")]
        TransitionRequested = 0,
        [EnumMember(Value = "Transition Cancelled")]
        TransitionCancelled = 1,
        [EnumMember(Value = "Transition Rejected")]
        TransitionRejected = 2,
        [EnumMember(Value = "Pending Incomplete")]
        PendingIncomplete = 3,
        [EnumMember(Value = "Pending Review")]
        PendingReview = 4,
        [EnumMember(Value = "Pending Deficient")]
        PendingDeficient = 5,
        [EnumMember(Value = "Pending Withdrawal Request")]
        PendingWithdrawalRequest = 6,
        [EnumMember(Value = "Withdrawn Application Abandoned")]
        WithdrawnApplicationAbandoned = 7,
        [EnumMember(Value = "Withdrawn Voluntary without Licensure")]
        WithdrawnVoluntaryWithoutLicensure = 8,
        Denied = 9,
        [EnumMember(Value = "Denied on Appeal")]
        DeniedOnAppeal = 10,
        [EnumMember(Value = "Approved Conditional")]
        ApprovedConditional = 11,
        [EnumMember(Value = "Approved Deficient")]
        ApprovedDeficient = 12,
        [EnumMember(Value = "Approved Failed to Review")]
        ApprovedFailedToReview = 13,
        [EnumMember(Value = "Approved Inactive")]
        ApprovedInactive = 14,
        [EnumMember(Value = "Approved on Appeal")]
        ApprovedOnAppeal = 15,
        [EnumMember(Value = "Approved Surrender/Cancellation Requested")]
        ApprovedSurrenderCancellationRequested = 16,
        Revoked = 17,
        [EnumMember(Value = "Revoked on Appeal")]
        RevokedOnAppeal = 18,
        Suspended = 19,
        [EnumMember(Value = "Suspended on Appeal")]
        SuspendedOnAppeal = 20,
        [EnumMember(Value = "Temporary Cease and Desist")]
        TemporaryCeaseAndDesist = 21,
        [EnumMember(Value = "Temporary Expired")]
        TemporaryExpired = 22,
        [EnumMember(Value = "Temporary Failed to Review")]
        TemporaryFailedToReview = 23,
        [EnumMember(Value = "Terminated Order to Surrender")]
        TerminatedOrderToSurrender = 24,
        [EnumMember(Value = "Terminated Surrendered/CancelledTransition Cancelled")]
        TerminatedSurrenderedCancelledTransitionCancelled = 25
    }
}