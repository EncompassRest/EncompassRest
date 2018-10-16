using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Correspondent
    /// </summary>
    public sealed partial class Correspondent : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _additionalLateFeeCharge;
        private DirtyValue<DateTime?> _approvedToFundDate;
        private DirtyValue<decimal?> _basePrice;
        private DirtyValue<DateTime?> _cancelledDate;
        private DirtyValue<StringEnumValue<CommitmentType>> _commitmentType;
        private DirtyValue<DateTime?> _conditionsReceivedDate;
        private DirtyValue<StringEnumValue<CorrespondentStatus>> _correspondentStatus;
        private DirtyValue<DateTime?> _deliveryExpirationDate;
        private DirtyValue<string> _deliveryType;
        private DirtyValue<DateTime?> _fundedDate;
        private DirtyValue<int?> _gracePeriodDays;
        private DirtyValue<DateTime?> _gracePeriodStartDate;
        private DirtyValue<string> _gracePeriodStartTrigger;
        private DirtyValue<string> _id;
        private DirtyValue<DateTime?> _initialSuspenseDate;
        private DirtyValue<DateTime?> _lateDaysBegin;
        private DirtyValue<DateTime?> _lateDaysEnd;
        private DirtyValue<string> _lateDaysEndTrigger;
        private DirtyValue<StringEnumValue<LateFeeChargeType>> _lateFeeChargeType;
        private DirtyValue<string> _lateFeeFrequency;
        private DirtyValue<string> _lateFeeNotes;
        private DirtyValue<decimal?> _lateFeePercentage;
        private DirtyValue<decimal?> _lateFeeTotalPriceAdjustment;
        private DirtyValue<DateTime?> _latestConditionsDate;
        private DirtyValue<decimal?> _lFSAmount;
        private DirtyValue<int?> _lFSCalculateAs;
        private DirtyValue<int?> _lFSDayCleared;
        private DirtyValue<string> _lFSDayClearedOtherDate;
        private DirtyValue<string> _lFSDayClearedOtherDateValue;
        private DirtyValue<int?> _lFSFeeHandledAs;
        private DirtyValue<int?> _lFSGracePeriodCalendar;
        private DirtyValue<int?> _lFSGracePeriodDays;
        private DirtyValue<int?> _lFSGracePeriodLaterOf;
        private DirtyValue<int?> _lFSGracePeriodStarts;
        private DirtyValue<int?> _lFSIncludeDay;
        private DirtyValue<decimal?> _lFSLateFee;
        private DirtyValue<int?> _lFSLateFeeBasedOn;
        private DirtyValue<int?> _lFSMaxLateDays;
        private DirtyValue<string> _lFSOtherDate;
        private DirtyValue<string> _lFSOtherDateValue;
        private DirtyValue<int?> _lFSStartOnWeekend;
        private DirtyValue<DateTime?> _noteDate;
        private DirtyValue<decimal?> _originalPrincipalBalance;
        private DirtyValue<string> _ratesheet;
        private DirtyValue<DateTime?> _receivedDate;
        private DirtyValue<DateTime?> _rejectedDate;
        private DirtyValue<DateTime?> _submittedforPurchaseDate;
        private DirtyValue<int?> _totalLateDays;
        private DirtyValue<decimal?> _totalLateFee;
        private DirtyValue<decimal?> _unpaidPrincipalBalance;
        private DirtyValue<DateTime?> _voidedDate;
        private DirtyValue<DateTime?> _withdrawalRequestedDate;
        private DirtyValue<DateTime?> _withdrawnDate;

        /// <summary>
        /// Correspondent Loan Status - Late Fee - Additional Charge [3932]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AdditionalLateFeeCharge { get => _additionalLateFeeCharge; set => SetField(ref _additionalLateFeeCharge, value); }

        /// <summary>
        /// Correspondent Loan Status - Cleared for Purchase Date [3921]
        /// </summary>
        public DateTime? ApprovedToFundDate { get => _approvedToFundDate; set => SetField(ref _approvedToFundDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Base Price [3924]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BasePrice { get => _basePrice; set => SetField(ref _basePrice, value); }

        /// <summary>
        /// Correspondent Loan Status - Cancelled Date [4207]
        /// </summary>
        public DateTime? CancelledDate { get => _cancelledDate; set => SetField(ref _cancelledDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Commitment Type [4105]
        /// </summary>
        public StringEnumValue<CommitmentType> CommitmentType { get => _commitmentType; set => SetField(ref _commitmentType, value); }

        /// <summary>
        /// Correspondent Loan Status - Purchase Approval Date [3920]
        /// </summary>
        public DateTime? ConditionsReceivedDate { get => _conditionsReceivedDate; set => SetField(ref _conditionsReceivedDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Correspondent Status [3916]
        /// </summary>
        public StringEnumValue<CorrespondentStatus> CorrespondentStatus { get => _correspondentStatus; set => SetField(ref _correspondentStatus, value); }

        /// <summary>
        /// Correspondent Loan Status - Delivery Expiration Date [3926]
        /// </summary>
        public DateTime? DeliveryExpirationDate { get => _deliveryExpirationDate; set => SetField(ref _deliveryExpirationDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Delivery Type [3967]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string DeliveryType { get => _deliveryType; set => SetField(ref _deliveryType, value); }

        /// <summary>
        /// Correspondent Loan Status - Purchase Date [3922]
        /// </summary>
        public DateTime? FundedDate { get => _fundedDate; set => SetField(ref _fundedDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Grace Period # of Days [3927]
        /// </summary>
        public int? GracePeriodDays { get => _gracePeriodDays; set => SetField(ref _gracePeriodDays, value); }

        /// <summary>
        /// Correspondent Loan Status - Grace Period Start Date [4110]
        /// </summary>
        public DateTime? GracePeriodStartDate { get => _gracePeriodStartDate; set => SetField(ref _gracePeriodStartDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Grace Period Start Trigger Date [4111]
        /// </summary>
        public string GracePeriodStartTrigger { get => _gracePeriodStartTrigger; set => SetField(ref _gracePeriodStartTrigger, value); }

        /// <summary>
        /// Correspondent Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Correspondent Loan Status - Purchase Suspense Date [3918]
        /// </summary>
        public DateTime? InitialSuspenseDate { get => _initialSuspenseDate; set => SetField(ref _initialSuspenseDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Late Days Begin [3928]
        /// </summary>
        public DateTime? LateDaysBegin { get => _lateDaysBegin; set => SetField(ref _lateDaysBegin, value); }

        /// <summary>
        /// Correspondent Loan Status - Late Days End [3929]
        /// </summary>
        public DateTime? LateDaysEnd { get => _lateDaysEnd; set => SetField(ref _lateDaysEnd, value); }

        /// <summary>
        /// Correspondent Loan Status - Late Days End Trigger  Date [4112]
        /// </summary>
        public string LateDaysEndTrigger { get => _lateDaysEndTrigger; set => SetField(ref _lateDaysEndTrigger, value); }

        /// <summary>
        /// Correspondent Loan Status - Late Fee Charge Type [3936]
        /// </summary>
        public StringEnumValue<LateFeeChargeType> LateFeeChargeType { get => _lateFeeChargeType; set => SetField(ref _lateFeeChargeType, value); }

        /// <summary>
        /// Correspondent Loan Status - Late Fee - Frequency [3933]
        /// </summary>
        public string LateFeeFrequency { get => _lateFeeFrequency; set => SetField(ref _lateFeeFrequency, value); }

        /// <summary>
        /// Correspondent Loan Status - Late Fee - Notes [3935]
        /// </summary>
        public string LateFeeNotes { get => _lateFeeNotes; set => SetField(ref _lateFeeNotes, value); }

        /// <summary>
        /// Correspondent Loan Status - Late Fee - Late Fee Percentage [3931]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5)]
        public decimal? LateFeePercentage { get => _lateFeePercentage; set => SetField(ref _lateFeePercentage, value); }

        /// <summary>
        /// Correspondent Loan Status - Late Fee - Total Price Adjustment [3934]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5, ReadOnly = true)]
        public decimal? LateFeeTotalPriceAdjustment { get => _lateFeeTotalPriceAdjustment; set => SetField(ref _lateFeeTotalPriceAdjustment, value); }

        /// <summary>
        /// Correspondent Loan Status - Latest Conds Issued Date [3919]
        /// </summary>
        public DateTime? LatestConditionsDate { get => _latestConditionsDate; set => SetField(ref _latestConditionsDate, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - Amount Value [LATEFEESETTING.X17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LFSAmount { get => _lFSAmount; set => SetField(ref _lFSAmount, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - CalculateAs [LATEFEESETTING.X1]
        /// </summary>
        public int? LFSCalculateAs { get => _lFSCalculateAs; set => SetField(ref _lFSCalculateAs, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - DayCleared [LATEFEESETTING.X12]
        /// </summary>
        public int? LFSDayCleared { get => _lFSDayCleared; set => SetField(ref _lFSDayCleared, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - DayClearedOtherDate [LATEFEESETTING.X13]
        /// </summary>
        public string LFSDayClearedOtherDate { get => _lFSDayClearedOtherDate; set => SetField(ref _lFSDayClearedOtherDate, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - DayClearedOtherDate Value [LATEFEESETTING.X15]
        /// </summary>
        public string LFSDayClearedOtherDateValue { get => _lFSDayClearedOtherDateValue; set => SetField(ref _lFSDayClearedOtherDateValue, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - FeeHandledAs [LATEFEESETTING.X2]
        /// </summary>
        public int? LFSFeeHandledAs { get => _lFSFeeHandledAs; set => SetField(ref _lFSFeeHandledAs, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - GracePeriodCalendar [LATEFEESETTING.X3]
        /// </summary>
        public int? LFSGracePeriodCalendar { get => _lFSGracePeriodCalendar; set => SetField(ref _lFSGracePeriodCalendar, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - GracePeriodDays [LATEFEESETTING.X11]
        /// </summary>
        public int? LFSGracePeriodDays { get => _lFSGracePeriodDays; set => SetField(ref _lFSGracePeriodDays, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - GracePeriodLaterOf [LATEFEESETTING.X4]
        /// </summary>
        public int? LFSGracePeriodLaterOf { get => _lFSGracePeriodLaterOf; set => SetField(ref _lFSGracePeriodLaterOf, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - GracePeriodStarts [LATEFEESETTING.X5]
        /// </summary>
        public int? LFSGracePeriodStarts { get => _lFSGracePeriodStarts; set => SetField(ref _lFSGracePeriodStarts, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - CalculateAs [LATEFEESETTING.X6]
        /// </summary>
        public int? LFSIncludeDay { get => _lFSIncludeDay; set => SetField(ref _lFSIncludeDay, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - LateFee Value [LATEFEESETTING.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LFSLateFee { get => _lFSLateFee; set => SetField(ref _lFSLateFee, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - LateFeeBasedOn [LATEFEESETTING.X7]
        /// </summary>
        public int? LFSLateFeeBasedOn { get => _lFSLateFeeBasedOn; set => SetField(ref _lFSLateFeeBasedOn, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - MaxLateDays [LATEFEESETTING.X8]
        /// </summary>
        public int? LFSMaxLateDays { get => _lFSMaxLateDays; set => SetField(ref _lFSMaxLateDays, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - OtherDate [LATEFEESETTING.X9]
        /// </summary>
        public string LFSOtherDate { get => _lFSOtherDate; set => SetField(ref _lFSOtherDate, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - OtherDate Value [LATEFEESETTING.X14]
        /// </summary>
        public string LFSOtherDateValue { get => _lFSOtherDateValue; set => SetField(ref _lFSOtherDateValue, value); }

        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - StartOnWeekend [LATEFEESETTING.X10]
        /// </summary>
        public int? LFSStartOnWeekend { get => _lFSStartOnWeekend; set => SetField(ref _lFSStartOnWeekend, value); }

        /// <summary>
        /// Correspondent Loan Status - Note Date [3925]
        /// </summary>
        public DateTime? NoteDate { get => _noteDate; set => SetField(ref _noteDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Original Principal Balance [4107]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OriginalPrincipalBalance { get => _originalPrincipalBalance; set => SetField(ref _originalPrincipalBalance, value); }

        /// <summary>
        /// Correspondent Loan Status - Rate Sheet ID [3923]
        /// </summary>
        public string Ratesheet { get => _ratesheet; set => SetField(ref _ratesheet, value); }

        /// <summary>
        /// Correspondent Loan Status - Received Date [3917]
        /// </summary>
        public DateTime? ReceivedDate { get => _receivedDate; set => SetField(ref _receivedDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Rejected Date [3940]
        /// </summary>
        public DateTime? RejectedDate { get => _rejectedDate; set => SetField(ref _rejectedDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Submitted for Review Date [4119]
        /// </summary>
        public DateTime? SubmittedforPurchaseDate { get => _submittedforPurchaseDate; set => SetField(ref _submittedforPurchaseDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Total Late Days [3930]
        /// </summary>
        public int? TotalLateDays { get => _totalLateDays; set => SetField(ref _totalLateDays, value); }

        /// <summary>
        /// Correspondent Loan Status - Late Fee -Total Late Fee [3937]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalLateFee { get => _totalLateFee; set => SetField(ref _totalLateFee, value); }

        /// <summary>
        /// Correspondent Loan Status - Unpaid Principal Balance [4106]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UnpaidPrincipalBalance { get => _unpaidPrincipalBalance; set => SetField(ref _unpaidPrincipalBalance, value); }

        /// <summary>
        /// Correspondent Loan Status - Voided Date [4208]
        /// </summary>
        public DateTime? VoidedDate { get => _voidedDate; set => SetField(ref _voidedDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Withdrawal Requested Date [4242]
        /// </summary>
        public DateTime? WithdrawalRequestedDate { get => _withdrawalRequestedDate; set => SetField(ref _withdrawalRequestedDate, value); }

        /// <summary>
        /// Correspondent Loan Status - Withdrawn Date [4120]
        /// </summary>
        public DateTime? WithdrawnDate { get => _withdrawnDate; set => SetField(ref _withdrawnDate, value); }
    }
}