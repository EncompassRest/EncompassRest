using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Correspondent : IDirty
    {
        private Value<decimal?> _additionalLateFeeCharge;
        public decimal? AdditionalLateFeeCharge { get { return _additionalLateFeeCharge; } set { _additionalLateFeeCharge = value; } }
        private Value<DateTime?> _approvedToFundDate;
        public DateTime? ApprovedToFundDate { get { return _approvedToFundDate; } set { _approvedToFundDate = value; } }
        private Value<decimal?> _basePrice;
        public decimal? BasePrice { get { return _basePrice; } set { _basePrice = value; } }
        private Value<DateTime?> _cancelledDate;
        public DateTime? CancelledDate { get { return _cancelledDate; } set { _cancelledDate = value; } }
        private Value<string> _commitmentType;
        public string CommitmentType { get { return _commitmentType; } set { _commitmentType = value; } }
        private Value<DateTime?> _conditionsReceivedDate;
        public DateTime? ConditionsReceivedDate { get { return _conditionsReceivedDate; } set { _conditionsReceivedDate = value; } }
        private Value<string> _correspondentStatus;
        public string CorrespondentStatus { get { return _correspondentStatus; } set { _correspondentStatus = value; } }
        private Value<DateTime?> _deliveryExpirationDate;
        public DateTime? DeliveryExpirationDate { get { return _deliveryExpirationDate; } set { _deliveryExpirationDate = value; } }
        private Value<string> _deliveryType;
        public string DeliveryType { get { return _deliveryType; } set { _deliveryType = value; } }
        private Value<DateTime?> _fundedDate;
        public DateTime? FundedDate { get { return _fundedDate; } set { _fundedDate = value; } }
        private Value<int?> _gracePeriodDays;
        public int? GracePeriodDays { get { return _gracePeriodDays; } set { _gracePeriodDays = value; } }
        private Value<DateTime?> _gracePeriodStartDate;
        public DateTime? GracePeriodStartDate { get { return _gracePeriodStartDate; } set { _gracePeriodStartDate = value; } }
        private Value<string> _gracePeriodStartTrigger;
        public string GracePeriodStartTrigger { get { return _gracePeriodStartTrigger; } set { _gracePeriodStartTrigger = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<DateTime?> _initialSuspenseDate;
        public DateTime? InitialSuspenseDate { get { return _initialSuspenseDate; } set { _initialSuspenseDate = value; } }
        private Value<DateTime?> _lateDaysBegin;
        public DateTime? LateDaysBegin { get { return _lateDaysBegin; } set { _lateDaysBegin = value; } }
        private Value<DateTime?> _lateDaysEnd;
        public DateTime? LateDaysEnd { get { return _lateDaysEnd; } set { _lateDaysEnd = value; } }
        private Value<string> _lateDaysEndTrigger;
        public string LateDaysEndTrigger { get { return _lateDaysEndTrigger; } set { _lateDaysEndTrigger = value; } }
        private Value<string> _lateFeeChargeType;
        public string LateFeeChargeType { get { return _lateFeeChargeType; } set { _lateFeeChargeType = value; } }
        private Value<string> _lateFeeFrequency;
        public string LateFeeFrequency { get { return _lateFeeFrequency; } set { _lateFeeFrequency = value; } }
        private Value<string> _lateFeeNotes;
        public string LateFeeNotes { get { return _lateFeeNotes; } set { _lateFeeNotes = value; } }
        private Value<decimal?> _lateFeePercentage;
        public decimal? LateFeePercentage { get { return _lateFeePercentage; } set { _lateFeePercentage = value; } }
        private Value<decimal?> _lateFeeTotalPriceAdjustment;
        public decimal? LateFeeTotalPriceAdjustment { get { return _lateFeeTotalPriceAdjustment; } set { _lateFeeTotalPriceAdjustment = value; } }
        private Value<DateTime?> _latestConditionsDate;
        public DateTime? LatestConditionsDate { get { return _latestConditionsDate; } set { _latestConditionsDate = value; } }
        private Value<int?> _lFS_CalculateAs;
        public int? LFS_CalculateAs { get { return _lFS_CalculateAs; } set { _lFS_CalculateAs = value; } }
        private Value<int?> _lFS_DayCleared;
        public int? LFS_DayCleared { get { return _lFS_DayCleared; } set { _lFS_DayCleared = value; } }
        private Value<string> _lFS_DayClearedOtherDate;
        public string LFS_DayClearedOtherDate { get { return _lFS_DayClearedOtherDate; } set { _lFS_DayClearedOtherDate = value; } }
        private Value<string> _lFS_DayClearedOtherDateValue;
        public string LFS_DayClearedOtherDateValue { get { return _lFS_DayClearedOtherDateValue; } set { _lFS_DayClearedOtherDateValue = value; } }
        private Value<int?> _lFS_FeeHandledAs;
        public int? LFS_FeeHandledAs { get { return _lFS_FeeHandledAs; } set { _lFS_FeeHandledAs = value; } }
        private Value<int?> _lFS_GracePeriodCalendar;
        public int? LFS_GracePeriodCalendar { get { return _lFS_GracePeriodCalendar; } set { _lFS_GracePeriodCalendar = value; } }
        private Value<int?> _lFS_GracePeriodDays;
        public int? LFS_GracePeriodDays { get { return _lFS_GracePeriodDays; } set { _lFS_GracePeriodDays = value; } }
        private Value<int?> _lFS_GracePeriodLaterOf;
        public int? LFS_GracePeriodLaterOf { get { return _lFS_GracePeriodLaterOf; } set { _lFS_GracePeriodLaterOf = value; } }
        private Value<int?> _lFS_GracePeriodStarts;
        public int? LFS_GracePeriodStarts { get { return _lFS_GracePeriodStarts; } set { _lFS_GracePeriodStarts = value; } }
        private Value<int?> _lFS_IncludeDay;
        public int? LFS_IncludeDay { get { return _lFS_IncludeDay; } set { _lFS_IncludeDay = value; } }
        private Value<int?> _lFS_LateFeeBasedOn;
        public int? LFS_LateFeeBasedOn { get { return _lFS_LateFeeBasedOn; } set { _lFS_LateFeeBasedOn = value; } }
        private Value<int?> _lFS_MaxLateDays;
        public int? LFS_MaxLateDays { get { return _lFS_MaxLateDays; } set { _lFS_MaxLateDays = value; } }
        private Value<string> _lFS_OtherDate;
        public string LFS_OtherDate { get { return _lFS_OtherDate; } set { _lFS_OtherDate = value; } }
        private Value<string> _lFS_OtherDateValue;
        public string LFS_OtherDateValue { get { return _lFS_OtherDateValue; } set { _lFS_OtherDateValue = value; } }
        private Value<int?> _lFS_StartOnWeekend;
        public int? LFS_StartOnWeekend { get { return _lFS_StartOnWeekend; } set { _lFS_StartOnWeekend = value; } }
        private Value<DateTime?> _noteDate;
        public DateTime? NoteDate { get { return _noteDate; } set { _noteDate = value; } }
        private Value<decimal?> _originalPrincipalBalance;
        public decimal? OriginalPrincipalBalance { get { return _originalPrincipalBalance; } set { _originalPrincipalBalance = value; } }
        private Value<string> _ratesheet;
        public string Ratesheet { get { return _ratesheet; } set { _ratesheet = value; } }
        private Value<DateTime?> _receivedDate;
        public DateTime? ReceivedDate { get { return _receivedDate; } set { _receivedDate = value; } }
        private Value<DateTime?> _rejectedDate;
        public DateTime? RejectedDate { get { return _rejectedDate; } set { _rejectedDate = value; } }
        private Value<DateTime?> _submittedforPurchaseDate;
        public DateTime? SubmittedforPurchaseDate { get { return _submittedforPurchaseDate; } set { _submittedforPurchaseDate = value; } }
        private Value<int?> _totalLateDays;
        public int? TotalLateDays { get { return _totalLateDays; } set { _totalLateDays = value; } }
        private Value<decimal?> _totalLateFee;
        public decimal? TotalLateFee { get { return _totalLateFee; } set { _totalLateFee = value; } }
        private Value<decimal?> _unpaidPrincipalBalance;
        public decimal? UnpaidPrincipalBalance { get { return _unpaidPrincipalBalance; } set { _unpaidPrincipalBalance = value; } }
        private Value<DateTime?> _voidedDate;
        public DateTime? VoidedDate { get { return _voidedDate; } set { _voidedDate = value; } }
        private Value<DateTime?> _withdrawnDate;
        public DateTime? WithdrawnDate { get { return _withdrawnDate; } set { _withdrawnDate = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _additionalLateFeeCharge.Dirty
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
                    || _withdrawnDate.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _withdrawnDate.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}