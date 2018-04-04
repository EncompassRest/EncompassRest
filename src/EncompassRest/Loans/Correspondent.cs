#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Correspondent : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _additionalLateFeeCharge;
        public decimal? AdditionalLateFeeCharge { get => _additionalLateFeeCharge; set => _additionalLateFeeCharge = value; }
        private DirtyValue<DateTime?> _approvedToFundDate;
        public DateTime? ApprovedToFundDate { get => _approvedToFundDate; set => _approvedToFundDate = value; }
        private DirtyValue<decimal?> _basePrice;
        public decimal? BasePrice { get => _basePrice; set => _basePrice = value; }
        private DirtyValue<DateTime?> _cancelledDate;
        public DateTime? CancelledDate { get => _cancelledDate; set => _cancelledDate = value; }
        private DirtyValue<StringEnumValue<CommitmentType>> _commitmentType;
        public StringEnumValue<CommitmentType> CommitmentType { get => _commitmentType; set => _commitmentType = value; }
        private DirtyValue<DateTime?> _conditionsReceivedDate;
        public DateTime? ConditionsReceivedDate { get => _conditionsReceivedDate; set => _conditionsReceivedDate = value; }
        private DirtyValue<StringEnumValue<CorrespondentStatus>> _correspondentStatus;
        public StringEnumValue<CorrespondentStatus> CorrespondentStatus { get => _correspondentStatus; set => _correspondentStatus = value; }
        private DirtyValue<DateTime?> _deliveryExpirationDate;
        public DateTime? DeliveryExpirationDate { get => _deliveryExpirationDate; set => _deliveryExpirationDate = value; }
        private DirtyValue<string> _deliveryType;
        public string DeliveryType { get => _deliveryType; set => _deliveryType = value; }
        private DirtyValue<DateTime?> _fundedDate;
        public DateTime? FundedDate { get => _fundedDate; set => _fundedDate = value; }
        private DirtyValue<int?> _gracePeriodDays;
        public int? GracePeriodDays { get => _gracePeriodDays; set => _gracePeriodDays = value; }
        private DirtyValue<DateTime?> _gracePeriodStartDate;
        public DateTime? GracePeriodStartDate { get => _gracePeriodStartDate; set => _gracePeriodStartDate = value; }
        private DirtyValue<string> _gracePeriodStartTrigger;
        public string GracePeriodStartTrigger { get => _gracePeriodStartTrigger; set => _gracePeriodStartTrigger = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<DateTime?> _initialSuspenseDate;
        public DateTime? InitialSuspenseDate { get => _initialSuspenseDate; set => _initialSuspenseDate = value; }
        private DirtyValue<DateTime?> _lateDaysBegin;
        public DateTime? LateDaysBegin { get => _lateDaysBegin; set => _lateDaysBegin = value; }
        private DirtyValue<DateTime?> _lateDaysEnd;
        public DateTime? LateDaysEnd { get => _lateDaysEnd; set => _lateDaysEnd = value; }
        private DirtyValue<string> _lateDaysEndTrigger;
        public string LateDaysEndTrigger { get => _lateDaysEndTrigger; set => _lateDaysEndTrigger = value; }
        private DirtyValue<StringEnumValue<LateFeeChargeType>> _lateFeeChargeType;
        public StringEnumValue<LateFeeChargeType> LateFeeChargeType { get => _lateFeeChargeType; set => _lateFeeChargeType = value; }
        private DirtyValue<string> _lateFeeFrequency;
        public string LateFeeFrequency { get => _lateFeeFrequency; set => _lateFeeFrequency = value; }
        private DirtyValue<string> _lateFeeNotes;
        public string LateFeeNotes { get => _lateFeeNotes; set => _lateFeeNotes = value; }
        private DirtyValue<decimal?> _lateFeePercentage;
        public decimal? LateFeePercentage { get => _lateFeePercentage; set => _lateFeePercentage = value; }
        private DirtyValue<decimal?> _lateFeeTotalPriceAdjustment;
        public decimal? LateFeeTotalPriceAdjustment { get => _lateFeeTotalPriceAdjustment; set => _lateFeeTotalPriceAdjustment = value; }
        private DirtyValue<DateTime?> _latestConditionsDate;
        public DateTime? LatestConditionsDate { get => _latestConditionsDate; set => _latestConditionsDate = value; }
        private DirtyValue<decimal?> _lFSAmount;
        public decimal? LFSAmount { get => _lFSAmount; set => _lFSAmount = value; }
        private DirtyValue<int?> _lFSCalculateAs;
        public int? LFSCalculateAs { get => _lFSCalculateAs; set => _lFSCalculateAs = value; }
        private DirtyValue<int?> _lFSDayCleared;
        public int? LFSDayCleared { get => _lFSDayCleared; set => _lFSDayCleared = value; }
        private DirtyValue<string> _lFSDayClearedOtherDate;
        public string LFSDayClearedOtherDate { get => _lFSDayClearedOtherDate; set => _lFSDayClearedOtherDate = value; }
        private DirtyValue<string> _lFSDayClearedOtherDateValue;
        public string LFSDayClearedOtherDateValue { get => _lFSDayClearedOtherDateValue; set => _lFSDayClearedOtherDateValue = value; }
        private DirtyValue<int?> _lFSFeeHandledAs;
        public int? LFSFeeHandledAs { get => _lFSFeeHandledAs; set => _lFSFeeHandledAs = value; }
        private DirtyValue<int?> _lFSGracePeriodCalendar;
        public int? LFSGracePeriodCalendar { get => _lFSGracePeriodCalendar; set => _lFSGracePeriodCalendar = value; }
        private DirtyValue<int?> _lFSGracePeriodDays;
        public int? LFSGracePeriodDays { get => _lFSGracePeriodDays; set => _lFSGracePeriodDays = value; }
        private DirtyValue<int?> _lFSGracePeriodLaterOf;
        public int? LFSGracePeriodLaterOf { get => _lFSGracePeriodLaterOf; set => _lFSGracePeriodLaterOf = value; }
        private DirtyValue<int?> _lFSGracePeriodStarts;
        public int? LFSGracePeriodStarts { get => _lFSGracePeriodStarts; set => _lFSGracePeriodStarts = value; }
        private DirtyValue<int?> _lFSIncludeDay;
        public int? LFSIncludeDay { get => _lFSIncludeDay; set => _lFSIncludeDay = value; }
        private DirtyValue<decimal?> _lFSLateFee;
        public decimal? LFSLateFee { get => _lFSLateFee; set => _lFSLateFee = value; }
        private DirtyValue<int?> _lFSLateFeeBasedOn;
        public int? LFSLateFeeBasedOn { get => _lFSLateFeeBasedOn; set => _lFSLateFeeBasedOn = value; }
        private DirtyValue<int?> _lFSMaxLateDays;
        public int? LFSMaxLateDays { get => _lFSMaxLateDays; set => _lFSMaxLateDays = value; }
        private DirtyValue<string> _lFSOtherDate;
        public string LFSOtherDate { get => _lFSOtherDate; set => _lFSOtherDate = value; }
        private DirtyValue<string> _lFSOtherDateValue;
        public string LFSOtherDateValue { get => _lFSOtherDateValue; set => _lFSOtherDateValue = value; }
        private DirtyValue<int?> _lFSStartOnWeekend;
        public int? LFSStartOnWeekend { get => _lFSStartOnWeekend; set => _lFSStartOnWeekend = value; }
        private DirtyValue<DateTime?> _noteDate;
        public DateTime? NoteDate { get => _noteDate; set => _noteDate = value; }
        private DirtyValue<decimal?> _originalPrincipalBalance;
        public decimal? OriginalPrincipalBalance { get => _originalPrincipalBalance; set => _originalPrincipalBalance = value; }
        private DirtyValue<string> _ratesheet;
        public string Ratesheet { get => _ratesheet; set => _ratesheet = value; }
        private DirtyValue<DateTime?> _receivedDate;
        public DateTime? ReceivedDate { get => _receivedDate; set => _receivedDate = value; }
        private DirtyValue<DateTime?> _rejectedDate;
        public DateTime? RejectedDate { get => _rejectedDate; set => _rejectedDate = value; }
        private DirtyValue<DateTime?> _submittedforPurchaseDate;
        public DateTime? SubmittedforPurchaseDate { get => _submittedforPurchaseDate; set => _submittedforPurchaseDate = value; }
        private DirtyValue<int?> _totalLateDays;
        public int? TotalLateDays { get => _totalLateDays; set => _totalLateDays = value; }
        private DirtyValue<decimal?> _totalLateFee;
        public decimal? TotalLateFee { get => _totalLateFee; set => _totalLateFee = value; }
        private DirtyValue<decimal?> _unpaidPrincipalBalance;
        public decimal? UnpaidPrincipalBalance { get => _unpaidPrincipalBalance; set => _unpaidPrincipalBalance = value; }
        private DirtyValue<DateTime?> _voidedDate;
        public DateTime? VoidedDate { get => _voidedDate; set => _voidedDate = value; }
        private DirtyValue<DateTime?> _withdrawalRequestedDate;
        public DateTime? WithdrawalRequestedDate { get => _withdrawalRequestedDate; set => _withdrawalRequestedDate = value; }
        private DirtyValue<DateTime?> _withdrawnDate;
        public DateTime? WithdrawnDate { get => _withdrawnDate; set => _withdrawnDate = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _additionalLateFeeCharge.Dirty
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
            }
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