using System.Runtime.Serialization;

namespace EncompassRest.Organizations
{
    /// <summary>
    /// LicenseStatus
    /// </summary>
    public enum LicenseStatus
    {
        /// <summary>
        /// Transition Requested
        /// </summary>
        [EnumMember(Value = "Transition Requested")]
        TransitionRequested = 0,
        /// <summary>
        /// Transition Cancelled
        /// </summary>
        [EnumMember(Value = "Transition Cancelled")]
        TransitionCancelled = 1,
        /// <summary>
        /// Transition Rejected
        /// </summary>
        [EnumMember(Value = "Transition Rejected")]
        TransitionRejected = 2,
        /// <summary>
        /// Pending Incomplete
        /// </summary>
        [EnumMember(Value = "Pending Incomplete")]
        PendingIncomplete = 3,
        /// <summary>
        /// Pending Review
        /// </summary>
        [EnumMember(Value = "Pending Review")]
        PendingReview = 4,
        /// <summary>
        /// Pending Deficient
        /// </summary>
        [EnumMember(Value = "Pending Deficient")]
        PendingDeficient = 5,
        /// <summary>
        /// Pending Withdrawal Request
        /// </summary>
        [EnumMember(Value = "Pending Withdrawal Request")]
        PendingWithdrawalRequest = 6,
        /// <summary>
        /// Withdrawn Application Abandoned
        /// </summary>
        [EnumMember(Value = "Withdrawn Application Abandoned")]
        WithdrawnApplicationAbandoned = 7,
        /// <summary>
        /// Withdrawn Voluntary without Licensure
        /// </summary>
        [EnumMember(Value = "Withdrawn Voluntary without Licensure")]
        WithdrawnVoluntaryWithoutLicensure = 8,
        /// <summary>
        /// Denied
        /// </summary>
        Denied = 9,
        /// <summary>
        /// Denied on Appeal
        /// </summary>
        [EnumMember(Value = "Denied on Appeal")]
        DeniedOnAppeal = 10,
        /// <summary>
        /// Approved Conditional
        /// </summary>
        [EnumMember(Value = "Approved Conditional")]
        ApprovedConditional = 11,
        /// <summary>
        /// Approved Deficient
        /// </summary>
        [EnumMember(Value = "Approved Deficient")]
        ApprovedDeficient = 12,
        /// <summary>
        /// Approved Failed to Review
        /// </summary>
        [EnumMember(Value = "Approved Failed to Review")]
        ApprovedFailedToReview = 13,
        /// <summary>
        /// Approved Inactive
        /// </summary>
        [EnumMember(Value = "Approved Inactive")]
        ApprovedInactive = 14,
        /// <summary>
        /// Approved on Appeal
        /// </summary>
        [EnumMember(Value = "Approved on Appeal")]
        ApprovedOnAppeal = 15,
        /// <summary>
        /// Approved Surrender/Cancellation Requested
        /// </summary>
        [EnumMember(Value = "Approved Surrender/Cancellation Requested")]
        ApprovedSurrenderCancellationRequested = 16,
        /// <summary>
        /// Revoked
        /// </summary>
        Revoked = 17,
        /// <summary>
        /// Revoked on Appeal
        /// </summary>
        [EnumMember(Value = "Revoked on Appeal")]
        RevokedOnAppeal = 18,
        /// <summary>
        /// Suspended
        /// </summary>
        Suspended = 19,
        /// <summary>
        /// Suspended on Appeal
        /// </summary>
        [EnumMember(Value = "Suspended on Appeal")]
        SuspendedOnAppeal = 20,
        /// <summary>
        /// Temporary Cease and Desist
        /// </summary>
        [EnumMember(Value = "Temporary Cease and Desist")]
        TemporaryCeaseAndDesist = 21,
        /// <summary>
        /// Temporary Expired
        /// </summary>
        [EnumMember(Value = "Temporary Expired")]
        TemporaryExpired = 22,
        /// <summary>
        /// Temporary Failed to Review
        /// </summary>
        [EnumMember(Value = "Temporary Failed to Review")]
        TemporaryFailedToReview = 23,
        /// <summary>
        /// Terminated Order to Surrender
        /// </summary>
        [EnumMember(Value = "Terminated Order to Surrender")]
        TerminatedOrderToSurrender = 24,
        /// <summary>
        /// Terminated Surrendered/CancelledTransition Cancelled
        /// </summary>
        [EnumMember(Value = "Terminated Surrendered/CancelledTransition Cancelled")]
        TerminatedSurrenderedCancelledTransitionCancelled = 25
    }
}