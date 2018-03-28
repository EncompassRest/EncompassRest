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
        private DirtyValue<decimal?> _lFS_Amount;
        public decimal? LFS_Amount { get => _lFS_Amount; set => _lFS_Amount = value; }
        private DirtyValue<int?> _lFS_CalculateAs;
        public int? LFS_CalculateAs { get => _lFS_CalculateAs; set => _lFS_CalculateAs = value; }
        private DirtyValue<int?> _lFS_DayCleared;
        public int? LFS_DayCleared { get => _lFS_DayCleared; set => _lFS_DayCleared = value; }
        private DirtyValue<string> _lFS_DayClearedOtherDate;
        public string LFS_DayClearedOtherDate { get => _lFS_DayClearedOtherDate; set => _lFS_DayClearedOtherDate = value; }
        private DirtyValue<string> _lFS_DayClearedOtherDateValue;
        public string LFS_DayClearedOtherDateValue { get => _lFS_DayClearedOtherDateValue; set => _lFS_DayClearedOtherDateValue = value; }
        private DirtyValue<int?> _lFS_FeeHandledAs;
        public int? LFS_FeeHandledAs { get => _lFS_FeeHandledAs; set => _lFS_FeeHandledAs = value; }
        private DirtyValue<int?> _lFS_GracePeriodCalendar;
        public int? LFS_GracePeriodCalendar { get => _lFS_GracePeriodCalendar; set => _lFS_GracePeriodCalendar = value; }
        private DirtyValue<int?> _lFS_GracePeriodDays;
        public int? LFS_GracePeriodDays { get => _lFS_GracePeriodDays; set => _lFS_GracePeriodDays = value; }
        private DirtyValue<int?> _lFS_GracePeriodLaterOf;
        public int? LFS_GracePeriodLaterOf { get => _lFS_GracePeriodLaterOf; set => _lFS_GracePeriodLaterOf = value; }
        private DirtyValue<int?> _lFS_GracePeriodStarts;
        public int? LFS_GracePeriodStarts { get => _lFS_GracePeriodStarts; set => _lFS_GracePeriodStarts = value; }
        private DirtyValue<int?> _lFS_IncludeDay;
        public int? LFS_IncludeDay { get => _lFS_IncludeDay; set => _lFS_IncludeDay = value; }
        private DirtyValue<decimal?> _lFS_LateFee;
        public decimal? LFS_LateFee { get => _lFS_LateFee; set => _lFS_LateFee = value; }
        private DirtyValue<int?> _lFS_LateFeeBasedOn;
        public int? LFS_LateFeeBasedOn { get => _lFS_LateFeeBasedOn; set => _lFS_LateFeeBasedOn = value; }
        private DirtyValue<int?> _lFS_MaxLateDays;
        public int? LFS_MaxLateDays { get => _lFS_MaxLateDays; set => _lFS_MaxLateDays = value; }
        private DirtyValue<string> _lFS_OtherDate;
        public string LFS_OtherDate { get => _lFS_OtherDate; set => _lFS_OtherDate = value; }
        private DirtyValue<string> _lFS_OtherDateValue;
        public string LFS_OtherDateValue { get => _lFS_OtherDateValue; set => _lFS_OtherDateValue = value; }
        private DirtyValue<int?> _lFS_StartOnWeekend;
        public int? LFS_StartOnWeekend { get => _lFS_StartOnWeekend; set => _lFS_StartOnWeekend = value; }
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
                    || _lFS_Amount.Dirty
                    || _lFS_CalculateAs.Dirty
                    || _lFS_DayCleared.Dirty
                    || _lFS_DayClearedOtherDate.Dirty
                    || _lFS_DayClearedOtherDateValue.Dirty
                    || _lFS_FeeHandledAs.Dirty
                    || _lFS_GracePeriodCalendar.Dirty
                    || _lFS_GracePeriodDays.Dirty
                    || _lFS_GracePeriodLaterOf.Dirty
                    || _lFS_GracePeriodStarts.Dirty
                    || _lFS_IncludeDay.Dirty
                    || _lFS_LateFee.Dirty
                    || _lFS_LateFeeBasedOn.Dirty
                    || _lFS_MaxLateDays.Dirty
                    || _lFS_OtherDate.Dirty
                    || _lFS_OtherDateValue.Dirty
                    || _lFS_StartOnWeekend.Dirty
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
                _lFS_Amount.Dirty = value;
                _lFS_CalculateAs.Dirty = value;
                _lFS_DayCleared.Dirty = value;
                _lFS_DayClearedOtherDate.Dirty = value;
                _lFS_DayClearedOtherDateValue.Dirty = value;
                _lFS_FeeHandledAs.Dirty = value;
                _lFS_GracePeriodCalendar.Dirty = value;
                _lFS_GracePeriodDays.Dirty = value;
                _lFS_GracePeriodLaterOf.Dirty = value;
                _lFS_GracePeriodStarts.Dirty = value;
                _lFS_IncludeDay.Dirty = value;
                _lFS_LateFee.Dirty = value;
                _lFS_LateFeeBasedOn.Dirty = value;
                _lFS_MaxLateDays.Dirty = value;
                _lFS_OtherDate.Dirty = value;
                _lFS_OtherDateValue.Dirty = value;
                _lFS_StartOnWeekend.Dirty = value;
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