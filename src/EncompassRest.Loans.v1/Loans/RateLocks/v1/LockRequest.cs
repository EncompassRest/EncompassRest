using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans.RateLocks.v1
{
    /// <summary>
    /// LockRequest
    /// </summary>
    public sealed partial class LockRequest : DirtyExtensibleObject
    {
        /// <summary>
        /// The rate at par pricing: the rate the borrower would pay if there were no discount points.
        /// </summary>
        public decimal? UnDiscountedRate { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Starting adjustment rate.
        /// </summary>
        public decimal? StartingAdjustRate { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Starting adjustment price.
        /// </summary>
        public decimal? StartingAdjustPrice { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Program notes.
        /// </summary>
        public string? ProgramNotes { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Expected net price.
        /// </summary>
        public decimal? ExpectedNetPrice { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The time and date of overnight rate protection applied.
        /// </summary>
        [JsonConverter(typeof(ElliDateJsonConverter))]
        public DateTime? OnrpDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates if this rate lock is eligible for overnight rate protection.
        /// </summary>
        public bool? OnrpEligible { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the rate lock is ONRP locked.
        /// </summary>
        public bool? OnrpLock { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Correspondent commitment type of the request. Possible values are Mandatory or Best Efforts
        /// </summary>
        public StringEnumValue<CommitmentType> CorrespondentCommitmentType { get => GetValue<StringEnumValue<CommitmentType>>(); set => SetValue(value); }

        /// <summary>
        /// Correspondent delivery type of the request. Possible values are: individual mandatory, individual best efforts
        /// </summary>
        public StringEnumValue<CorrespondentDeliveryType> CorrespondentDeliveryType { get => GetValue<StringEnumValue<CorrespondentDeliveryType>>(); set => SetValue(value); }

        /// <summary>
        /// Cumulated days to extend.
        /// </summary>
        public int? CumulatedDaystoExtend { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// Extension sequence number of the lock request.
        /// </summary>
        public int? ExtensionSequenceNumber { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the rate lock is in hedging.
        /// </summary>
        public bool? Hedging { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Penalty term.
        /// </summary>
        public string? PenaltyTerm { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Prepay penalty.
        /// </summary>
        public string? PrepayPenalty { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Number of days to extend the rate lock.
        /// </summary>
        public int? DaystoExtend { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// Expiration date of the extended rate lock.
        /// </summary>
        [JsonConverter(typeof(ElliDateJsonConverter))]
        public DateTime? ExtendedLockExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Fulfilled date of the rate lock.
        /// </summary>
        public DateTime? FulfilledDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Additional notes and comments related to the lock cancellation.
        /// </summary>
        public string? LockCancellationComment { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Date on which the lock was cancelled.
        /// </summary>
        [JsonConverter(typeof(ElliDateJsonConverter))]
        public DateTime? LockCancellationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Additional notes and comments related to the lock extension.
        /// </summary>
        public string? LockExtendComment { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Price adjustment on the lock extension.
        /// </summary>
        public decimal? LockExtendPriceAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Margin SRP amount that is paid out.
        /// </summary>
        public decimal? MarginSrpPaidOut { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates if rate lock request delivery type is visible.
        /// </summary>
        public bool? IsDeliveryType { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates if the rate lock request is cancelled.
        /// </summary>
        public bool? IsCancelled { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// The status of the rate. Possible values are 'notLocked', 'locked', 'expired', 'cancelled'.
        /// </summary>
        public StringEnumValue<RateStatus> RateStatus { get => GetValue<StringEnumValue<RateStatus>>(); set => SetValue(value); }

        /// <summary>
        /// Indicates if the rate lock request is still pending.
        /// </summary>
        public bool? RequestPending { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates if the rate lock extension request is still pending.
        /// </summary>
        public bool? ExtensionRequestPending { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates if the rate lock cancellation request is still pending.
        /// </summary>
        public bool? CancellationRequestPending { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates if the rate lock's re-lock request is still pending.
        /// </summary>
        public bool? ReLockRequestPending { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// The ID from the investor's rate sheet for the current lock.
        /// </summary>
        public string? RateSheetId { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Date when the interest rate for the loan was last locked.
        /// </summary>
        [JsonConverter(typeof(ElliDateJsonConverter))]
        public DateTime? LastRateSetDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The number of days in the current lock.
        /// </summary>
        public int? LockNumberOfDays { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// Expiration date of the rate lock.
        /// </summary>
        [JsonConverter(typeof(ElliDateJsonConverter))]
        public DateTime? LockExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The lock date of the current lock.
        /// </summary>
        [JsonConverter(typeof(ElliDateJsonConverter))]
        public DateTime? LockDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The requested base rate (as a percentage) for the lock.
        /// </summary>
        public decimal? BaseRate { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// List of the rate adjustments.
        /// </summary>
        [AllowNull]
        public IList<LockAdjustment> Adjustments { get => GetList<LockAdjustment>(); set => SetList(value); }

        /// <summary>
        /// Total amount of rate adjustments.
        /// </summary>
        public decimal? TotalRateAdjustments { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Net rate. The requested Base Buy Rate plus the Total Rate Adjustments
        /// </summary>
        public decimal? NetRate { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Base price. The requested base price for the lock. Enter pricing using 100 as par. Example 1: If the base price is .25 above par, enter 100.25. A loan amount of $100,000 with pricing of 100.25 would result in $100,250 being received. Example 2: If the base price is .25 below par, enter 99.75. A loan amount of $100,000 with pricing of 99.75 would result in $99,750 being received.
        /// </summary>
        public decimal? BasePrice { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The total of the price adjustments itemized on the Detailed Lock Request form.
        /// </summary>
        public decimal? TotalPriceAdjustments { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Net rate. The requested Base Buy Rate plus the Total Rate Adjustments
        /// </summary>
        public decimal? NetPrice { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The requested base ARM margin for the lock.
        /// </summary>
        public decimal? BaseMarginRate { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The total of the base ARM margin adjustments.
        /// </summary>
        public decimal? TotalMarginAdjustments { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The requested base ARM margin plus the Total ARM Margin Adjustments.
        /// </summary>
        public decimal? NetMarginRate { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// Additional comments and notes related to the lock request.
        /// </summary>
        public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Original lock expiration date for the requested rate lock extension.
        /// </summary>
        [JsonConverter(typeof(ElliDateJsonConverter))]
        public DateTime? OriginalLockExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Service Release Premium Percentage (SRP) to be paid to the Lender.
        /// </summary>
        public decimal? SrpPaidOut { get => GetValue<decimal?>(); set => SetValue(value); }

        /// <summary>
        /// The Loan Program associated with the loan.
        /// </summary>
        public string? LoanProgram { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The entityRefContract describing the entity or user who submitted the lock request.
        /// </summary>
        public EntityReference? RequestedBy { get => GetValue<EntityReference?>(); set => SetValue(value); }
    }
}