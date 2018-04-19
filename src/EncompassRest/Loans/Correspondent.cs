using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Correspondent
    /// </summary>
    public sealed partial class Correspondent : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _additionalLateFeeCharge;
        /// <summary>
        /// Correspondent Loan Status - Late Fee - Additional Charge [3932]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Loan Status - Late Fee - Additional Charge")]
        public decimal? AdditionalLateFeeCharge { get => _additionalLateFeeCharge; set => _additionalLateFeeCharge = value; }
        private DirtyValue<DateTime?> _approvedToFundDate;
        /// <summary>
        /// Correspondent Loan Status - Cleared for Purchase Date [3921]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Cleared for Purchase Date")]
        public DateTime? ApprovedToFundDate { get => _approvedToFundDate; set => _approvedToFundDate = value; }
        private DirtyValue<decimal?> _basePrice;
        /// <summary>
        /// Correspondent Loan Status - Base Price [3924]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Correspondent Loan Status - Base Price")]
        public decimal? BasePrice { get => _basePrice; set => _basePrice = value; }
        private DirtyValue<DateTime?> _cancelledDate;
        /// <summary>
        /// Correspondent Loan Status - Cancelled Date [4207]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Cancelled Date")]
        public DateTime? CancelledDate { get => _cancelledDate; set => _cancelledDate = value; }
        private DirtyValue<StringEnumValue<CommitmentType>> _commitmentType;
        /// <summary>
        /// Correspondent Loan Status - Commitment Type [4105]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Commitment Type")]
        public StringEnumValue<CommitmentType> CommitmentType { get => _commitmentType; set => _commitmentType = value; }
        private DirtyValue<DateTime?> _conditionsReceivedDate;
        /// <summary>
        /// Correspondent Loan Status - Purchase Approval Date [3920]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Purchase Approval Date")]
        public DateTime? ConditionsReceivedDate { get => _conditionsReceivedDate; set => _conditionsReceivedDate = value; }
        private DirtyValue<StringEnumValue<CorrespondentStatus>> _correspondentStatus;
        /// <summary>
        /// Correspondent Loan Status - Correspondent Status [3916]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Correspondent Status")]
        public StringEnumValue<CorrespondentStatus> CorrespondentStatus { get => _correspondentStatus; set => _correspondentStatus = value; }
        private DirtyValue<DateTime?> _deliveryExpirationDate;
        /// <summary>
        /// Correspondent Loan Status - Delivery Expiration Date [3926]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Delivery Expiration Date")]
        public DateTime? DeliveryExpirationDate { get => _deliveryExpirationDate; set => _deliveryExpirationDate = value; }
        private DirtyValue<string> _deliveryType;
        /// <summary>
        /// Correspondent Loan Status - Delivery Type [3967]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Correspondent Loan Status - Delivery Type")]
        public string DeliveryType { get => _deliveryType; set => _deliveryType = value; }
        private DirtyValue<DateTime?> _fundedDate;
        /// <summary>
        /// Correspondent Loan Status - Purchase Date [3922]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Purchase Date")]
        public DateTime? FundedDate { get => _fundedDate; set => _fundedDate = value; }
        private DirtyValue<int?> _gracePeriodDays;
        /// <summary>
        /// Correspondent Loan Status - Grace Period # of Days [3927]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Grace Period # of Days")]
        public int? GracePeriodDays { get => _gracePeriodDays; set => _gracePeriodDays = value; }
        private DirtyValue<DateTime?> _gracePeriodStartDate;
        /// <summary>
        /// Correspondent Loan Status - Grace Period Start Date [4110]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Grace Period Start Date")]
        public DateTime? GracePeriodStartDate { get => _gracePeriodStartDate; set => _gracePeriodStartDate = value; }
        private DirtyValue<string> _gracePeriodStartTrigger;
        /// <summary>
        /// Correspondent Loan Status - Grace Period Start Trigger Date [4111]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Grace Period Start Trigger Date")]
        public string GracePeriodStartTrigger { get => _gracePeriodStartTrigger; set => _gracePeriodStartTrigger = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Correspondent Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<DateTime?> _initialSuspenseDate;
        /// <summary>
        /// Correspondent Loan Status - Purchase Suspense Date [3918]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Purchase Suspense Date")]
        public DateTime? InitialSuspenseDate { get => _initialSuspenseDate; set => _initialSuspenseDate = value; }
        private DirtyValue<DateTime?> _lateDaysBegin;
        /// <summary>
        /// Correspondent Loan Status - Late Days Begin [3928]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Late Days Begin")]
        public DateTime? LateDaysBegin { get => _lateDaysBegin; set => _lateDaysBegin = value; }
        private DirtyValue<DateTime?> _lateDaysEnd;
        /// <summary>
        /// Correspondent Loan Status - Late Days End [3929]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Late Days End")]
        public DateTime? LateDaysEnd { get => _lateDaysEnd; set => _lateDaysEnd = value; }
        private DirtyValue<string> _lateDaysEndTrigger;
        /// <summary>
        /// Correspondent Loan Status - Late Days End Trigger  Date [4112]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Late Days End Trigger  Date")]
        public string LateDaysEndTrigger { get => _lateDaysEndTrigger; set => _lateDaysEndTrigger = value; }
        private DirtyValue<StringEnumValue<LateFeeChargeType>> _lateFeeChargeType;
        /// <summary>
        /// Correspondent Loan Status - Late Fee Charge Type [3936]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Late Fee Charge Type")]
        public StringEnumValue<LateFeeChargeType> LateFeeChargeType { get => _lateFeeChargeType; set => _lateFeeChargeType = value; }
        private DirtyValue<string> _lateFeeFrequency;
        /// <summary>
        /// Correspondent Loan Status - Late Fee - Frequency [3933]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Late Fee - Frequency")]
        public string LateFeeFrequency { get => _lateFeeFrequency; set => _lateFeeFrequency = value; }
        private DirtyValue<string> _lateFeeNotes;
        /// <summary>
        /// Correspondent Loan Status - Late Fee - Notes [3935]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Late Fee - Notes")]
        public string LateFeeNotes { get => _lateFeeNotes; set => _lateFeeNotes = value; }
        private DirtyValue<decimal?> _lateFeePercentage;
        /// <summary>
        /// Correspondent Loan Status - Late Fee - Late Fee Percentage [3931]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5, Description = "Correspondent Loan Status - Late Fee - Late Fee Percentage")]
        public decimal? LateFeePercentage { get => _lateFeePercentage; set => _lateFeePercentage = value; }
        private DirtyValue<decimal?> _lateFeeTotalPriceAdjustment;
        /// <summary>
        /// Correspondent Loan Status - Late Fee - Total Price Adjustment [3934]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5, ReadOnly = true, Description = "Correspondent Loan Status - Late Fee - Total Price Adjustment")]
        public decimal? LateFeeTotalPriceAdjustment { get => _lateFeeTotalPriceAdjustment; set => _lateFeeTotalPriceAdjustment = value; }
        private DirtyValue<DateTime?> _latestConditionsDate;
        /// <summary>
        /// Correspondent Loan Status - Latest Conds Issued Date [3919]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Latest Conds Issued Date")]
        public DateTime? LatestConditionsDate { get => _latestConditionsDate; set => _latestConditionsDate = value; }
        private DirtyValue<decimal?> _lFSAmount;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - Amount Value [LATEFEESETTING.X17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Loan Status - External Late Fee Settings - Amount Value")]
        public decimal? LFSAmount { get => _lFSAmount; set => _lFSAmount = value; }
        private DirtyValue<int?> _lFSCalculateAs;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - CalculateAs [LATEFEESETTING.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - CalculateAs")]
        public int? LFSCalculateAs { get => _lFSCalculateAs; set => _lFSCalculateAs = value; }
        private DirtyValue<int?> _lFSDayCleared;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - DayCleared [LATEFEESETTING.X12]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - DayCleared")]
        public int? LFSDayCleared { get => _lFSDayCleared; set => _lFSDayCleared = value; }
        private DirtyValue<string> _lFSDayClearedOtherDate;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - DayClearedOtherDate [LATEFEESETTING.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - DayClearedOtherDate")]
        public string LFSDayClearedOtherDate { get => _lFSDayClearedOtherDate; set => _lFSDayClearedOtherDate = value; }
        private DirtyValue<string> _lFSDayClearedOtherDateValue;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - DayClearedOtherDate Value [LATEFEESETTING.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - DayClearedOtherDate Value")]
        public string LFSDayClearedOtherDateValue { get => _lFSDayClearedOtherDateValue; set => _lFSDayClearedOtherDateValue = value; }
        private DirtyValue<int?> _lFSFeeHandledAs;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - FeeHandledAs [LATEFEESETTING.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - FeeHandledAs")]
        public int? LFSFeeHandledAs { get => _lFSFeeHandledAs; set => _lFSFeeHandledAs = value; }
        private DirtyValue<int?> _lFSGracePeriodCalendar;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - GracePeriodCalendar [LATEFEESETTING.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - GracePeriodCalendar")]
        public int? LFSGracePeriodCalendar { get => _lFSGracePeriodCalendar; set => _lFSGracePeriodCalendar = value; }
        private DirtyValue<int?> _lFSGracePeriodDays;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - GracePeriodDays [LATEFEESETTING.X11]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - GracePeriodDays")]
        public int? LFSGracePeriodDays { get => _lFSGracePeriodDays; set => _lFSGracePeriodDays = value; }
        private DirtyValue<int?> _lFSGracePeriodLaterOf;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - GracePeriodLaterOf [LATEFEESETTING.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - GracePeriodLaterOf")]
        public int? LFSGracePeriodLaterOf { get => _lFSGracePeriodLaterOf; set => _lFSGracePeriodLaterOf = value; }
        private DirtyValue<int?> _lFSGracePeriodStarts;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - GracePeriodStarts [LATEFEESETTING.X5]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - GracePeriodStarts")]
        public int? LFSGracePeriodStarts { get => _lFSGracePeriodStarts; set => _lFSGracePeriodStarts = value; }
        private DirtyValue<int?> _lFSIncludeDay;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - CalculateAs [LATEFEESETTING.X6]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - CalculateAs")]
        public int? LFSIncludeDay { get => _lFSIncludeDay; set => _lFSIncludeDay = value; }
        private DirtyValue<decimal?> _lFSLateFee;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - LateFee Value [LATEFEESETTING.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Loan Status - External Late Fee Settings - LateFee Value")]
        public decimal? LFSLateFee { get => _lFSLateFee; set => _lFSLateFee = value; }
        private DirtyValue<int?> _lFSLateFeeBasedOn;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - LateFeeBasedOn [LATEFEESETTING.X7]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - LateFeeBasedOn")]
        public int? LFSLateFeeBasedOn { get => _lFSLateFeeBasedOn; set => _lFSLateFeeBasedOn = value; }
        private DirtyValue<int?> _lFSMaxLateDays;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - MaxLateDays [LATEFEESETTING.X8]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - MaxLateDays")]
        public int? LFSMaxLateDays { get => _lFSMaxLateDays; set => _lFSMaxLateDays = value; }
        private DirtyValue<string> _lFSOtherDate;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - OtherDate [LATEFEESETTING.X9]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - OtherDate")]
        public string LFSOtherDate { get => _lFSOtherDate; set => _lFSOtherDate = value; }
        private DirtyValue<string> _lFSOtherDateValue;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - OtherDate Value [LATEFEESETTING.X14]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - OtherDate Value")]
        public string LFSOtherDateValue { get => _lFSOtherDateValue; set => _lFSOtherDateValue = value; }
        private DirtyValue<int?> _lFSStartOnWeekend;
        /// <summary>
        /// Correspondent Loan Status - External Late Fee Settings - StartOnWeekend [LATEFEESETTING.X10]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - External Late Fee Settings - StartOnWeekend")]
        public int? LFSStartOnWeekend { get => _lFSStartOnWeekend; set => _lFSStartOnWeekend = value; }
        private DirtyValue<DateTime?> _noteDate;
        /// <summary>
        /// Correspondent Loan Status - Note Date [3925]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Note Date")]
        public DateTime? NoteDate { get => _noteDate; set => _noteDate = value; }
        private DirtyValue<decimal?> _originalPrincipalBalance;
        /// <summary>
        /// Correspondent Loan Status - Original Principal Balance [4107]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Loan Status - Original Principal Balance")]
        public decimal? OriginalPrincipalBalance { get => _originalPrincipalBalance; set => _originalPrincipalBalance = value; }
        private DirtyValue<string> _ratesheet;
        /// <summary>
        /// Correspondent Loan Status - Rate Sheet ID [3923]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Rate Sheet ID")]
        public string Ratesheet { get => _ratesheet; set => _ratesheet = value; }
        private DirtyValue<DateTime?> _receivedDate;
        /// <summary>
        /// Correspondent Loan Status - Received Date [3917]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Received Date")]
        public DateTime? ReceivedDate { get => _receivedDate; set => _receivedDate = value; }
        private DirtyValue<DateTime?> _rejectedDate;
        /// <summary>
        /// Correspondent Loan Status - Rejected Date [3940]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Rejected Date")]
        public DateTime? RejectedDate { get => _rejectedDate; set => _rejectedDate = value; }
        private DirtyValue<DateTime?> _submittedforPurchaseDate;
        /// <summary>
        /// Correspondent Loan Status - Submitted for Review Date [4119]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Submitted for Review Date")]
        public DateTime? SubmittedforPurchaseDate { get => _submittedforPurchaseDate; set => _submittedforPurchaseDate = value; }
        private DirtyValue<int?> _totalLateDays;
        /// <summary>
        /// Correspondent Loan Status - Total Late Days [3930]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Total Late Days")]
        public int? TotalLateDays { get => _totalLateDays; set => _totalLateDays = value; }
        private DirtyValue<decimal?> _totalLateFee;
        /// <summary>
        /// Correspondent Loan Status - Late Fee -Total Late Fee [3937]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Correspondent Loan Status - Late Fee -Total Late Fee")]
        public decimal? TotalLateFee { get => _totalLateFee; set => _totalLateFee = value; }
        private DirtyValue<decimal?> _unpaidPrincipalBalance;
        /// <summary>
        /// Correspondent Loan Status - Unpaid Principal Balance [4106]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Correspondent Loan Status - Unpaid Principal Balance")]
        public decimal? UnpaidPrincipalBalance { get => _unpaidPrincipalBalance; set => _unpaidPrincipalBalance = value; }
        private DirtyValue<DateTime?> _voidedDate;
        /// <summary>
        /// Correspondent Loan Status - Voided Date [4208]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Voided Date")]
        public DateTime? VoidedDate { get => _voidedDate; set => _voidedDate = value; }
        private DirtyValue<DateTime?> _withdrawalRequestedDate;
        /// <summary>
        /// Correspondent Loan Status - Withdrawal Requested Date [4242]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Withdrawal Requested Date")]
        public DateTime? WithdrawalRequestedDate { get => _withdrawalRequestedDate; set => _withdrawalRequestedDate = value; }
        private DirtyValue<DateTime?> _withdrawnDate;
        /// <summary>
        /// Correspondent Loan Status - Withdrawn Date [4120]
        /// </summary>
        [LoanFieldProperty(Description = "Correspondent Loan Status - Withdrawn Date")]
        public DateTime? WithdrawnDate { get => _withdrawnDate; set => _withdrawnDate = value; }
        internal override bool DirtyInternal
        {
            get => _additionalLateFeeCharge.Dirty
                || _approvedToFundDate.Dirty
                || _basePrice.Dirty
                || _cancelledDate.Dirty
                || _commitmentType.Dirty
                || _conditionsReceivedDate.Dirty
                || _correspondentStatus.Dirty
                || _deliveryExpirationDate.Dirty
                || _deliveryType.Dirty
                || _fundedDate.Dirty
                || _gracePeriodDays.Dirty
                || _gracePeriodStartDate.Dirty
                || _gracePeriodStartTrigger.Dirty
                || _id.Dirty
                || _initialSuspenseDate.Dirty
                || _lateDaysBegin.Dirty
                || _lateDaysEnd.Dirty
                || _lateDaysEndTrigger.Dirty
                || _lateFeeChargeType.Dirty
                || _lateFeeFrequency.Dirty
                || _lateFeeNotes.Dirty
                || _lateFeePercentage.Dirty
                || _lateFeeTotalPriceAdjustment.Dirty
                || _latestConditionsDate.Dirty
                || _lFSAmount.Dirty
                || _lFSCalculateAs.Dirty
                || _lFSDayCleared.Dirty
                || _lFSDayClearedOtherDate.Dirty
                || _lFSDayClearedOtherDateValue.Dirty
                || _lFSFeeHandledAs.Dirty
                || _lFSGracePeriodCalendar.Dirty
                || _lFSGracePeriodDays.Dirty
                || _lFSGracePeriodLaterOf.Dirty
                || _lFSGracePeriodStarts.Dirty
                || _lFSIncludeDay.Dirty
                || _lFSLateFee.Dirty
                || _lFSLateFeeBasedOn.Dirty
                || _lFSMaxLateDays.Dirty
                || _lFSOtherDate.Dirty
                || _lFSOtherDateValue.Dirty
                || _lFSStartOnWeekend.Dirty
                || _noteDate.Dirty
                || _originalPrincipalBalance.Dirty
                || _ratesheet.Dirty
                || _receivedDate.Dirty
                || _rejectedDate.Dirty
                || _submittedforPurchaseDate.Dirty
                || _totalLateDays.Dirty
                || _totalLateFee.Dirty
                || _unpaidPrincipalBalance.Dirty
                || _voidedDate.Dirty
                || _withdrawalRequestedDate.Dirty
                || _withdrawnDate.Dirty;
            set
            {
                _additionalLateFeeCharge.Dirty = value;
                _approvedToFundDate.Dirty = value;
                _basePrice.Dirty = value;
                _cancelledDate.Dirty = value;
                _commitmentType.Dirty = value;
                _conditionsReceivedDate.Dirty = value;
                _correspondentStatus.Dirty = value;
                _deliveryExpirationDate.Dirty = value;
                _deliveryType.Dirty = value;
                _fundedDate.Dirty = value;
                _gracePeriodDays.Dirty = value;
                _gracePeriodStartDate.Dirty = value;
                _gracePeriodStartTrigger.Dirty = value;
                _id.Dirty = value;
                _initialSuspenseDate.Dirty = value;
                _lateDaysBegin.Dirty = value;
                _lateDaysEnd.Dirty = value;
                _lateDaysEndTrigger.Dirty = value;
                _lateFeeChargeType.Dirty = value;
                _lateFeeFrequency.Dirty = value;
                _lateFeeNotes.Dirty = value;
                _lateFeePercentage.Dirty = value;
                _lateFeeTotalPriceAdjustment.Dirty = value;
                _latestConditionsDate.Dirty = value;
                _lFSAmount.Dirty = value;
                _lFSCalculateAs.Dirty = value;
                _lFSDayCleared.Dirty = value;
                _lFSDayClearedOtherDate.Dirty = value;
                _lFSDayClearedOtherDateValue.Dirty = value;
                _lFSFeeHandledAs.Dirty = value;
                _lFSGracePeriodCalendar.Dirty = value;
                _lFSGracePeriodDays.Dirty = value;
                _lFSGracePeriodLaterOf.Dirty = value;
                _lFSGracePeriodStarts.Dirty = value;
                _lFSIncludeDay.Dirty = value;
                _lFSLateFee.Dirty = value;
                _lFSLateFeeBasedOn.Dirty = value;
                _lFSMaxLateDays.Dirty = value;
                _lFSOtherDate.Dirty = value;
                _lFSOtherDateValue.Dirty = value;
                _lFSStartOnWeekend.Dirty = value;
                _noteDate.Dirty = value;
                _originalPrincipalBalance.Dirty = value;
                _ratesheet.Dirty = value;
                _receivedDate.Dirty = value;
                _rejectedDate.Dirty = value;
                _submittedforPurchaseDate.Dirty = value;
                _totalLateDays.Dirty = value;
                _totalLateFee.Dirty = value;
                _unpaidPrincipalBalance.Dirty = value;
                _voidedDate.Dirty = value;
                _withdrawalRequestedDate.Dirty = value;
                _withdrawnDate.Dirty = value;
            }
        }
    }
}