using EncompassRest.Schema;
using EncompassRest.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// LockRequest
    /// </summary>
    public sealed partial class LockRequest : DirtyExtensibleObject
    {
        private DirtyValue<decimal?>? _unDiscountedRate;
        private DirtyValue<decimal?>? _startingAdjustRate;
        private DirtyValue<decimal?>? _startingAdjustPrice;
        private DirtyValue<string?>? _programNotes;
        private DirtyValue<decimal?>? _expectedNetPrice;
        private DirtyValue<bool?>? _onrpEligible;
        private DirtyValue<DateTime?>? _onrpDate;
        private DirtyValue<bool?>? _onrpLock;
        private DirtyValue<string?>? _correspondentCommitmentType;
        private DirtyValue<string?>? _correspondentDeliveryType;
        private DirtyValue<int?>? _cumulatedDaystoExtend;
        private DirtyValue<int?>? _extensionSequenceNumber;
        private DirtyValue<bool?>? _hedging;
        private DirtyValue<string?>? _penaltyTerm;
        private DirtyValue<string?>? _prepayPenalty;
        private DirtyValue<int?>? _daystoExtend;
        private DirtyValue<DateTime?>? _extendedLockExpirationDate;
        private DirtyValue<DateTime?>? _fulfilledDate;
        private DirtyValue<string?>? _lockCancellationComment;
        private DirtyValue<DateTime?>? _lockCancellationDate;
        private DirtyValue<string?>? _lockExtendComment;
        private DirtyValue<decimal?>? _lockExtendPriceAdjustment;
        private DirtyValue<decimal?>? _marginSrpPaidOut;
        private DirtyValue<bool?>? _isDeliveryType;
        private DirtyValue<bool?>? _isCancelled;
        private DirtyValue<string?>? _rateStatus;
        private DirtyValue<bool?>? _requestPending;
        private DirtyValue<bool?>? _extensionRequestPending;
        private DirtyValue<bool?>? _cancellationRequestPending;
        private DirtyValue<bool?>? _reLockRequestPending;
        private DirtyValue<string?>? _rateSheetId;
        private DirtyValue<DateTime?>? _lastRateSetDate;
        private DirtyValue<int?>? _lockNumberOfDays;
        private DirtyValue<string?>? _lockExpirationDate;
        private DirtyValue<DateTime?>? _lockDate;
        private DirtyValue<decimal?>? _baseRate;
        private DirtyValue<List<LockAdjustment>?>? _adjustments;
        private DirtyValue<decimal?>? _totalRateAdjustments;
        private DirtyValue<decimal?>? _netRate;
        private DirtyValue<decimal?>? _basePrice;
        private DirtyValue<decimal?>? _totalPriceAdjustments;
        private DirtyValue<decimal?>? _netPrice;
        private DirtyValue<decimal?>? _baseMarginRate;
        private DirtyValue<decimal?>? _totalMarginAdjustments;
        private DirtyValue<decimal?>? _netMarginRate;
        private DirtyValue<string?>? _comments;
        private DirtyValue<DateTime?>? _originalLockExpirationDate;
        private DirtyValue<decimal?>? _srpPaidOut;
        private DirtyValue<string?>? _loanProgram;

        /// <summary>
        /// The rate at par pricing: the rate the borrower would pay if there were no discount points.
        /// </summary>
        public decimal? UnDiscountedRate { get => _unDiscountedRate; set => SetField(ref _unDiscountedRate, value); }

        /// <summary>
        /// Starting adjustment rate.
        /// </summary>
        public decimal? StartingAdjustRate { get => _startingAdjustRate; set => SetField(ref _startingAdjustRate, value); }

        /// <summary>
        /// Starting adjustment price.
        /// </summary>
        public decimal? StartingAdjustPrice { get => _startingAdjustPrice; set => SetField(ref _startingAdjustPrice, value); }

        /// <summary>
        /// Program notes.
        /// </summary>
        public string? ProgramNotes { get => _programNotes; set => SetField(ref _programNotes, value); }

        /// <summary>
        /// Expected net price.
        /// </summary>
        public decimal? ExpectedNetPrice { get => _expectedNetPrice; set => SetField(ref _expectedNetPrice, value); }

        /// <summary>
        /// The time and date of overnight rate protection applied.
        /// </summary>
        public DateTime? OnrpDate { get => _onrpDate; set => SetField(ref _onrpDate, value); }

        /// <summary>
        /// Indicates if this rate lock is eligible for overnight rate protection.
        /// </summary>
        public bool? OnrpEligible { get => _onrpEligible; set => SetField(ref _onrpEligible, value); }

        /// <summary>
        /// Indicates whether the rate lock is ONRP locked.
        /// </summary>
        public bool? OnrpLock { get => _onrpLock; set => SetField(ref _onrpLock, value); }

        /// <summary>
        /// Correspondent commitment type of the request. Possible values are Mandatory or Best Efforts
        /// </summary>
        public string? CorrespondentCommitmentType { get => _correspondentCommitmentType; set => SetField(ref _correspondentCommitmentType, value); }

        /// <summary>
        /// Correspondent delivery type of the request. Possible values are: individual mandatory, individual best efforts
        /// </summary>
        public string? CorrespondentDeliveryType { get => _correspondentDeliveryType; set => SetField(ref _correspondentDeliveryType, value); }

        /// <summary>
        /// Cumulated days to extend.
        /// </summary>
        public int? CumulatedDaystoExtend { get => _cumulatedDaystoExtend; set => SetField(ref _cumulatedDaystoExtend, value); }

        /// <summary>
        /// Extension sequence number of the lock request.
        /// </summary>
        public int? ExtensionSequenceNumber { get => _extensionSequenceNumber; set => SetField(ref _extensionSequenceNumber, value); }

        /// <summary>
        /// Indicates whether the rate lock is in hedging.
        /// </summary>
        public bool? Hedging { get => _hedging; set => SetField(ref _hedging, value); }

        /// <summary>
        /// Penalty term.
        /// </summary>
        public string? PenaltyTerm { get => _penaltyTerm; set => SetField(ref _penaltyTerm, value); }

        /// <summary>
        /// Prepay penalty.
        /// </summary>
        public string? PrepayPenalty { get => _prepayPenalty; set => SetField(ref _prepayPenalty, value); }

        /// <summary>
        /// Number of days to extend the rate lock.
        /// </summary>
        public int? DaystoExtend { get => _daystoExtend; set => SetField(ref _daystoExtend, value); }

        /// <summary>
        /// Expiration date of the extended rate lock.
        /// </summary>
        public DateTime? ExtendedLockExpirationDate { get => _extendedLockExpirationDate; set => SetField(ref _extendedLockExpirationDate, value); }

        /// <summary>
        /// Fulfilled date of the rate lock.
        /// </summary>
        public DateTime? FulfilledDate { get => _fulfilledDate; set => SetField(ref _fulfilledDate, value); }

        /// <summary>
        /// Additional notes and comments related to the lock cancellation.
        /// </summary>
        public string? LockCancellationComment { get => _lockCancellationComment; set => SetField(ref _lockCancellationComment, value); }

        /// <summary>
        /// Date on which the lock was cancelled.
        /// </summary>
        public DateTime? LockCancellationDate { get => _lockCancellationDate; set => SetField(ref _lockCancellationDate, value); }

        /// <summary>
        /// Additional notes and comments related to the lock extension.
        /// </summary>
        public string? LockExtendComment { get => _lockExtendComment; set => SetField(ref _lockExtendComment, value); }

        /// <summary>
        /// Price adjustment on the lock extension.
        /// </summary>
        public decimal? LockExtendPriceAdjustment { get => _lockExtendPriceAdjustment; set => SetField(ref _lockExtendPriceAdjustment, value); }

        /// <summary>
        /// Margin SRP amount that is paid out.
        /// </summary>
        public decimal? MarginSrpPaidOut { get => _marginSrpPaidOut; set => SetField(ref _marginSrpPaidOut, value); }

        /// <summary>
        /// Indicates if rate lock request delivery type is visible.
        /// </summary>
        public bool? IsDeliveryType { get => _isDeliveryType; set => SetField(ref _isDeliveryType, value); }

        /// <summary>
        /// Indicates if the rate lock request is cancelled.
        /// </summary>
        public bool? IsCancelled { get => _isCancelled; set => SetField(ref _isCancelled, value); }

        /// <summary>
        /// The status of the rate. Possible values are 'notLocked', 'locked', 'expired', 'cancelled'.
        /// </summary>
        public string? RateStatus { get => _rateStatus; set => SetField(ref _rateStatus, value); }

        /// <summary>
        /// Indicates if the rate lock request is still pending.
        /// </summary>
        public bool? RequestPending { get => _requestPending; set => SetField(ref _requestPending, value); }

        /// <summary>
        /// Indicates if the rate lock extension request is still pending.
        /// </summary>
        public bool? ExtensionRequestPending { get => _extensionRequestPending; set => SetField(ref _extensionRequestPending, value); }

        /// <summary>
        /// Indicates if the rate lock cancellation request is still pending.
        /// </summary>
        public bool? CancellationRequestPending { get => _cancellationRequestPending; set => SetField(ref _cancellationRequestPending, value); }

        /// <summary>
        /// Indicates if the rate lock's re-lock request is still pending.
        /// </summary>
        public bool? ReLockRequestPending { get => _reLockRequestPending; set => SetField(ref _reLockRequestPending, value); }

        /// <summary>
        /// The ID from the investor's rate sheet for the current lock.
        /// </summary>
        public string? RateSheetId { get => _rateSheetId; set => SetField(ref _rateSheetId, value); }

        /// <summary>
        /// Date when the interest rate for the loan was last locked.
        /// </summary>
        public DateTime? LastRateSetDate { get => _lastRateSetDate; set => SetField(ref _lastRateSetDate, value); }

        /// <summary>
        /// The number of days in the current lock.
        /// </summary>
        public int? LockNumberOfDays { get => _lockNumberOfDays; set => SetField(ref _lockNumberOfDays, value); }

        /// <summary>
        /// Expiration date of the rate lock.
        /// </summary>
        public string? LockExpirationDate { get => _lockExpirationDate; set => SetField(ref _lockExpirationDate, value); }

        /// <summary>
        /// The lock date of the current lock.
        /// </summary>
        [JsonConverter(typeof(DateFormatJsonConverter), "yyyy-MM-dd")]
        public DateTime? LockDate { get => _lockDate; set => SetField(ref _lockDate, value); }

        /// <summary>
        /// The requested base rate (as a percentage) for the lock.
        /// </summary>
        public decimal? BaseRate { get => _baseRate; set => SetField(ref _baseRate, value); }

        /// <summary>
        /// List of the rate adjustments.
        /// </summary>
        public List<LockAdjustment>? Adjustments { get => _adjustments; set => SetField(ref _adjustments, value); }

        /// <summary>
        /// Total amount of rate adjustments.
        /// </summary>
        public decimal? TotalRateAdjustments { get => _totalRateAdjustments; set => SetField(ref _totalRateAdjustments, value); }

        /// <summary>
        /// Net rate. The requested Base Buy Rate plus the Total Rate Adjustments
        /// </summary>
        public decimal? NetRate { get => _netRate; set => SetField(ref _netRate, value); }

        /// <summary>
        /// Base price. The requested base price for the lock. Enter pricing using 100 as par. Example 1: If the base price is .25 above par, enter 100.25. A loan amount of $100,000 with pricing of 100.25 would result in $100,250 being received. Example 2: If the base price is .25 below par, enter 99.75. A loan amount of $100,000 with pricing of 99.75 would result in $99,750 being received.
        /// </summary>
        public decimal? BasePrice { get => _basePrice; set => SetField(ref _basePrice, value); }

        /// <summary>
        /// The total of the price adjustments itemized on the Detailed Lock Request form.
        /// </summary>
        public decimal? TotalPriceAdjustments { get => _totalPriceAdjustments; set => SetField(ref _totalPriceAdjustments, value); }

        /// <summary>
        /// Net rate. The requested Base Buy Rate plus the Total Rate Adjustments
        /// </summary>
        public decimal? NetPrice { get => _netPrice; set => SetField(ref _netPrice, value); }

        /// <summary>
        /// The requested base ARM margin for the lock.
        /// </summary>
        public decimal? BaseMarginRate { get => _baseMarginRate; set => SetField(ref _baseMarginRate, value); }

        /// <summary>
        /// The total of the base ARM margin adjustments.
        /// </summary>
        public decimal? TotalMarginAdjustments { get => _totalMarginAdjustments; set => SetField(ref _totalMarginAdjustments, value); }

        /// <summary>
        /// The requested base ARM margin plus the Total ARM Margin Adjustments.
        /// </summary>
        public decimal? NetMarginRate { get => _netMarginRate; set => SetField(ref _netMarginRate, value); }

        /// <summary>
        /// Additional comments and notes related to the lock request.
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// Original lock expiration date for the requested rate lock extension.
        /// </summary>
        public DateTime? OriginalLockExpirationDate { get => _originalLockExpirationDate; set => SetField(ref _originalLockExpirationDate, value); }

        /// <summary>
        /// Service Release Premium Percentage (SRP) to be paid to the Lender.
        /// </summary>
        public decimal? SrpPaidOut { get => _srpPaidOut; set => SetField(ref _srpPaidOut, value); }

        /// <summary>
        /// The Loan Program associated with the loan.
        /// </summary>
        public string? LoanProgram { get => _loanProgram; set => SetField(ref _loanProgram, value); }
    }
}