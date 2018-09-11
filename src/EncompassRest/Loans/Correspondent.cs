using System;
using System.Collections.Generic;
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
        /// <summary>
        /// Correspondent Loan Status - Late Fee - Additional Charge [3932]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Loan Status - Late Fee - Additional Charge")]
        public decimal? AdditionalLateFeeCharge { get => _additionalLateFeeCharge; set => SetField(ref _additionalLateFeeCharge, value); }
        private DirtyValue<DateTime?> _approvedToFundDate;
        /// <summary>
        /// Correspondent Loan Status - Cleared for Purchase Date [3921]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Cleared for Purchase Date")]
        public DateTime? ApprovedToFundDate { get => _approvedToFundDate; set => SetField(ref _approvedToFundDate, value); }
        private DirtyValue<decimal?> _basePrice;
        /// <summary>
        /// Correspondent Loan Status - Base Price [3924]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Correspondent Loan Status - Base Price")]
        public decimal? BasePrice { get => _basePrice; set => SetField(ref _basePrice, value); }
        private DirtyValue<DateTime?> _cancelledDate;
        /// <summary>
        /// Correspondent Loan Status - Cancelled Date [4207]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Cancelled Date")]
        public DateTime? CancelledDate { get => _cancelledDate; set => SetField(ref _cancelledDate, value); }
        private DirtyValue<StringEnumValue<CommitmentType>> _commitmentType;
        /// <summary>
        /// Correspondent Loan Status - Commitment Type [4105]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Commitment Type")]
        public StringEnumValue<CommitmentType> CommitmentType { get => _commitmentType; set => SetField(ref _commitmentType, value); }
        private DirtyValue<DateTime?> _conditionsReceivedDate;
        /// <summary>
        /// Correspondent Loan Status - Purchase Approval Date [3920]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Purchase Approval Date")]
        public DateTime? ConditionsReceivedDate { get => _conditionsReceivedDate; set => SetField(ref _conditionsReceivedDate, value); }
        private DirtyValue<StringEnumValue<CorrespondentStatus>> _correspondentStatus;
        /// <summary>
        /// Correspondent Loan Status - Correspondent Status [3916]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Correspondent Status")]
        public StringEnumValue<CorrespondentStatus> CorrespondentStatus { get => _correspondentStatus; set => SetField(ref _correspondentStatus, value); }
        private DirtyValue<DateTime?> _deliveryExpirationDate;
        /// <summary>
        /// Correspondent Loan Status - Delivery Expiration Date [3926]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Delivery Expiration Date")]
        public DateTime? DeliveryExpirationDate { get => _deliveryExpirationDate; set => SetField(ref _deliveryExpirationDate, value); }
        private DirtyValue<string> _deliveryType;
        /// <summary>
        /// Correspondent Loan Status - Delivery Type [3967]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Correspondent Loan Status - Delivery Type")]
        public string DeliveryType { get => _deliveryType; set => SetField(ref _deliveryType, value); }
        private DirtyValue<DateTime?> _fundedDate;
        /// <summary>
        /// Correspondent Loan Status - Purchase Date [3922]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Purchase Date")]
        public DateTime? FundedDate { get => _fundedDate; set => SetField(ref _fundedDate, value); }
        private DirtyValue<int?> _gracePeriodDays;
        /// <summary>
        /// Correspondent Loan Status - Grace Period # of Days [3927]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Grace Period # of Days")]
        public int? GracePeriodDays { get => _gracePeriodDays; set => SetField(ref _gracePeriodDays, value); }
        private DirtyValue<DateTime?> _gracePeriodStartDate;
        /// <summary>
        /// Correspondent Loan Status - Grace Period Start Date [4110]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Grace Period Start Date")]
        public DateTime? GracePeriodStartDate { get => _gracePeriodStartDate; set => SetField(ref _gracePeriodStartDate, value); }
        private DirtyValue<string> _gracePeriodStartTrigger;
        /// <summary>
        /// Correspondent Loan Status - Grace Period Start Trigger Date [4111]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Grace Period Start Trigger Date")]
        public string GracePeriodStartTrigger { get => _gracePeriodStartTrigger; set => SetField(ref _gracePeriodStartTrigger, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Correspondent Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<DateTime?> _initialSuspenseDate;
        /// <summary>
        /// Correspondent Loan Status - Purchase Suspense Date [3918]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Purchase Suspense Date")]
        public DateTime? InitialSuspenseDate { get => _initialSuspenseDate; set => SetField(ref _initialSuspenseDate, value); }
        private DirtyValue<DateTime?> _lateDaysBegin;
        /// <summary>
        /// Correspondent Loan Status - Late Days Begin [3928]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Late Days Begin")]
        public DateTime? LateDaysBegin { get => _lateDaysBegin; set => SetField(ref _lateDaysBegin, value); }
        private DirtyValue<DateTime?> _lateDaysEnd;
        /// <summary>
        /// Correspondent Loan Status - Late Days End [3929]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Late Days End")]
        public DateTime? LateDaysEnd { get => _lateDaysEnd; set => SetField(ref _lateDaysEnd, value); }
        private DirtyValue<string> _lateDaysEndTrigger;
        /// <summary>
        /// Correspondent Loan Status - Late Days End Trigger  Date [4112]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Late Days End Trigger  Date")]
        public string LateDaysEndTrigger { get => _lateDaysEndTrigger; set => SetField(ref _lateDaysEndTrigger, value); }
        private DirtyValue<StringEnumValue<LateFeeChargeType>> _lateFeeChargeType;
        /// <summary>
        /// Correspondent Loan Status - Late Fee Charge Type [3936]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Late Fee Charge Type")]
        public StringEnumValue<LateFeeChargeType> LateFeeChargeType { get => _lateFeeChargeType; set => SetField(ref _lateFeeChargeType, value); }
        private DirtyValue<string> _lateFeeFrequency;
        /// <summary>
        /// Correspondent Loan Status - Late Fee - Frequency [3933]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Late Fee - Frequency")]
        public string LateFeeFrequency { get => _lateFeeFrequency; set => SetField(ref _lateFeeFrequency, value); }
        private DirtyValue<string> _lateFeeNotes;
        /// <summary>
        /// Correspondent Loan Status - Late Fee - Notes [3935]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Late Fee - Notes")]
        public string LateFeeNotes { get => _lateFeeNotes; set => SetField(ref _lateFeeNotes, value); }
        private DirtyValue<decimal?> _lateFeePercentage;
        /// <summary>
        /// Correspondent Loan Status - Late Fee - Late Fee Percentage [3931]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5, Description = "Correspondent Loan Status - Late Fee - Late Fee Percentage")]
        public decimal? LateFeePercentage { get => _lateFeePercentage; set => SetField(ref _lateFeePercentage, value); }
        private DirtyValue<decimal?> _lateFeeTotalPriceAdjustment;
        /// <summary>
        /// Correspondent Loan Status - Late Fee - Total Price Adjustment [3934]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5, ReadOnly = true, Description = "Correspondent Loan Status - Late Fee - Total Price Adjustment")]
        public decimal? LateFeeTotalPriceAdjustment { get => _lateFeeTotalPriceAdjustment; set => SetField(ref _lateFeeTotalPriceAdjustment, value); }
        private DirtyValue<DateTime?> _latestConditionsDate;
        /// <summary>
        /// Correspondent Loan Status - Latest Conds Issued Date [3919]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Latest Conds Issued Date")]
        public DateTime? LatestConditionsDate { get => _latestConditionsDate; set => SetField(ref _latestConditionsDate, value); }
        private DirtyValue<decimal?> _lFSAmount;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - Amount Value [LATEFEESETTING.X17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Loan Status - External Late Fee Settings - Amount Value")]
        public decimal? LFSAmount { get => _lFSAmount; set => SetField(ref _lFSAmount, value); }
        private DirtyValue<int?> _lFSCalculateAs;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - CalculateAs [LATEFEESETTING.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - CalculateAs")]
        public int? LFSCalculateAs { get => _lFSCalculateAs; set => SetField(ref _lFSCalculateAs, value); }
        private DirtyValue<int?> _lFSDayCleared;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - DayCleared [LATEFEESETTING.X12]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - DayCleared")]
        public int? LFSDayCleared { get => _lFSDayCleared; set => SetField(ref _lFSDayCleared, value); }
        private DirtyValue<string> _lFSDayClearedOtherDate;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - DayClearedOtherDate [LATEFEESETTING.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - DayClearedOtherDate")]
        public string LFSDayClearedOtherDate { get => _lFSDayClearedOtherDate; set => SetField(ref _lFSDayClearedOtherDate, value); }
        private DirtyValue<string> _lFSDayClearedOtherDateValue;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - DayClearedOtherDate Value [LATEFEESETTING.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - DayClearedOtherDate Value")]
        public string LFSDayClearedOtherDateValue { get => _lFSDayClearedOtherDateValue; set => SetField(ref _lFSDayClearedOtherDateValue, value); }
        private DirtyValue<int?> _lFSFeeHandledAs;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - FeeHandledAs [LATEFEESETTING.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - FeeHandledAs")]
        public int? LFSFeeHandledAs { get => _lFSFeeHandledAs; set => SetField(ref _lFSFeeHandledAs, value); }
        private DirtyValue<int?> _lFSGracePeriodCalendar;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - GracePeriodCalendar [LATEFEESETTING.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - GracePeriodCalendar")]
        public int? LFSGracePeriodCalendar { get => _lFSGracePeriodCalendar; set => SetField(ref _lFSGracePeriodCalendar, value); }
        private DirtyValue<int?> _lFSGracePeriodDays;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - GracePeriodDays [LATEFEESETTING.X11]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - GracePeriodDays")]
        public int? LFSGracePeriodDays { get => _lFSGracePeriodDays; set => SetField(ref _lFSGracePeriodDays, value); }
        private DirtyValue<int?> _lFSGracePeriodLaterOf;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - GracePeriodLaterOf [LATEFEESETTING.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - GracePeriodLaterOf")]
        public int? LFSGracePeriodLaterOf { get => _lFSGracePeriodLaterOf; set => SetField(ref _lFSGracePeriodLaterOf, value); }
        private DirtyValue<int?> _lFSGracePeriodStarts;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - GracePeriodStarts [LATEFEESETTING.X5]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - GracePeriodStarts")]
        public int? LFSGracePeriodStarts { get => _lFSGracePeriodStarts; set => SetField(ref _lFSGracePeriodStarts, value); }
        private DirtyValue<int?> _lFSIncludeDay;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - CalculateAs [LATEFEESETTING.X6]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - CalculateAs")]
        public int? LFSIncludeDay { get => _lFSIncludeDay; set => SetField(ref _lFSIncludeDay, value); }
        private DirtyValue<decimal?> _lFSLateFee;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - LateFee Value [LATEFEESETTING.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Loan Status - External Late Fee Settings - LateFee Value")]
        public decimal? LFSLateFee { get => _lFSLateFee; set => SetField(ref _lFSLateFee, value); }
        private DirtyValue<int?> _lFSLateFeeBasedOn;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - LateFeeBasedOn [LATEFEESETTING.X7]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - LateFeeBasedOn")]
        public int? LFSLateFeeBasedOn { get => _lFSLateFeeBasedOn; set => SetField(ref _lFSLateFeeBasedOn, value); }
        private DirtyValue<int?> _lFSMaxLateDays;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - MaxLateDays [LATEFEESETTING.X8]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - MaxLateDays")]
        public int? LFSMaxLateDays { get => _lFSMaxLateDays; set => SetField(ref _lFSMaxLateDays, value); }
        private DirtyValue<string> _lFSOtherDate;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - OtherDate [LATEFEESETTING.X9]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - OtherDate")]
        public string LFSOtherDate { get => _lFSOtherDate; set => SetField(ref _lFSOtherDate, value); }
        private DirtyValue<string> _lFSOtherDateValue;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - OtherDate Value [LATEFEESETTING.X14]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - OtherDate Value")]
        public string LFSOtherDateValue { get => _lFSOtherDateValue; set => SetField(ref _lFSOtherDateValue, value); }
        private DirtyValue<int?> _lFSStartOnWeekend;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - StartOnWeekend [LATEFEESETTING.X10]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - StartOnWeekend")]
        public int? LFSStartOnWeekend { get => _lFSStartOnWeekend; set => SetField(ref _lFSStartOnWeekend, value); }
        private DirtyValue<DateTime?> _noteDate;
        /// <summary>
        /// Correspondent Loan Status - Note Date [3925]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Note Date")]
        public DateTime? NoteDate { get => _noteDate; set => SetField(ref _noteDate, value); }
        private DirtyValue<decimal?> _originalPrincipalBalance;
        /// <summary>
        /// Correspondent Loan Status - Original Principal Balance [4107]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Loan Status - Original Principal Balance")]
        public decimal? OriginalPrincipalBalance { get => _originalPrincipalBalance; set => SetField(ref _originalPrincipalBalance, value); }
        private DirtyValue<string> _ratesheet;
        /// <summary>
        /// Correspondent Loan Status - Rate Sheet ID [3923]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Rate Sheet ID")]
        public string Ratesheet { get => _ratesheet; set => SetField(ref _ratesheet, value); }
        private DirtyValue<DateTime?> _receivedDate;
        /// <summary>
        /// Correspondent Loan Status - Received Date [3917]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Received Date")]
        public DateTime? ReceivedDate { get => _receivedDate; set => SetField(ref _receivedDate, value); }
        private DirtyValue<DateTime?> _rejectedDate;
        /// <summary>
        /// Correspondent Loan Status - Rejected Date [3940]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Rejected Date")]
        public DateTime? RejectedDate { get => _rejectedDate; set => SetField(ref _rejectedDate, value); }
        private DirtyValue<DateTime?> _submittedforPurchaseDate;
        /// <summary>
        /// Correspondent Loan Status - Submitted for Review Date [4119]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Submitted for Review Date")]
        public DateTime? SubmittedforPurchaseDate { get => _submittedforPurchaseDate; set => SetField(ref _submittedforPurchaseDate, value); }
        private DirtyValue<int?> _totalLateDays;
        /// <summary>
        /// Correspondent Loan Status - Total Late Days [3930]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Total Late Days")]
        public int? TotalLateDays { get => _totalLateDays; set => SetField(ref _totalLateDays, value); }
        private DirtyValue<decimal?> _totalLateFee;
        /// <summary>
        /// Correspondent Loan Status - Late Fee -Total Late Fee [3937]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Correspondent Loan Status - Late Fee -Total Late Fee")]
        public decimal? TotalLateFee { get => _totalLateFee; set => SetField(ref _totalLateFee, value); }
        private DirtyValue<decimal?> _unpaidPrincipalBalance;
        /// <summary>
        /// Correspondent Loan Status - Unpaid Principal Balance [4106]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Loan Status - Unpaid Principal Balance")]
        public decimal? UnpaidPrincipalBalance { get => _unpaidPrincipalBalance; set => SetField(ref _unpaidPrincipalBalance, value); }
        private DirtyValue<DateTime?> _voidedDate;
        /// <summary>
        /// Correspondent Loan Status - Voided Date [4208]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Voided Date")]
        public DateTime? VoidedDate { get => _voidedDate; set => SetField(ref _voidedDate, value); }
        private DirtyValue<DateTime?> _withdrawalRequestedDate;
        /// <summary>
        /// Correspondent Loan Status - Withdrawal Requested Date [4242]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Withdrawal Requested Date")]
        public DateTime? WithdrawalRequestedDate { get => _withdrawalRequestedDate; set => SetField(ref _withdrawalRequestedDate, value); }
        private DirtyValue<DateTime?> _withdrawnDate;
        /// <summary>
        /// Correspondent Loan Status - Withdrawn Date [4120]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Withdrawn Date")]
        public DateTime? WithdrawnDate { get => _withdrawnDate; set => SetField(ref _withdrawnDate, value); }
    }
}