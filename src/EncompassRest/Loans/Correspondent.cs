using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Correspondent : IClean
    {
        private Value<decimal?> _additionalLateFeeCharge;
        public decimal? AdditionalLateFeeCharge { get { return _additionalLateFeeCharge; } set { _additionalLateFeeCharge = value; } }
        private Value<DateTime?> _approvedToFundDate;
        public DateTime? ApprovedToFundDate { get { return _approvedToFundDate; } set { _approvedToFundDate = value; } }
        private Value<decimal?> _basePrice;
        public decimal? BasePrice { get { return _basePrice; } set { _basePrice = value; } }
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
        private Value<DateTime?> _withdrawnDate;
        public DateTime? WithdrawnDate { get { return _withdrawnDate; } set { _withdrawnDate = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _additionalLateFeeCharge.Clean
                    && _approvedToFundDate.Clean
                    && _basePrice.Clean
                    && _commitmentType.Clean
                    && _conditionsReceivedDate.Clean
                    && _correspondentStatus.Clean
                    && _deliveryExpirationDate.Clean
                    && _deliveryType.Clean
                    && _fundedDate.Clean
                    && _gracePeriodDays.Clean
                    && _gracePeriodStartDate.Clean
                    && _gracePeriodStartTrigger.Clean
                    && _id.Clean
                    && _initialSuspenseDate.Clean
                    && _lateDaysBegin.Clean
                    && _lateDaysEnd.Clean
                    && _lateDaysEndTrigger.Clean
                    && _lateFeeChargeType.Clean
                    && _lateFeeFrequency.Clean
                    && _lateFeeNotes.Clean
                    && _lateFeePercentage.Clean
                    && _lateFeeTotalPriceAdjustment.Clean
                    && _latestConditionsDate.Clean
                    && _lFS_CalculateAs.Clean
                    && _lFS_DayCleared.Clean
                    && _lFS_DayClearedOtherDate.Clean
                    && _lFS_DayClearedOtherDateValue.Clean
                    && _lFS_FeeHandledAs.Clean
                    && _lFS_GracePeriodCalendar.Clean
                    && _lFS_GracePeriodDays.Clean
                    && _lFS_GracePeriodLaterOf.Clean
                    && _lFS_GracePeriodStarts.Clean
                    && _lFS_IncludeDay.Clean
                    && _lFS_LateFeeBasedOn.Clean
                    && _lFS_MaxLateDays.Clean
                    && _lFS_OtherDate.Clean
                    && _lFS_OtherDateValue.Clean
                    && _lFS_StartOnWeekend.Clean
                    && _noteDate.Clean
                    && _originalPrincipalBalance.Clean
                    && _ratesheet.Clean
                    && _receivedDate.Clean
                    && _rejectedDate.Clean
                    && _submittedforPurchaseDate.Clean
                    && _totalLateDays.Clean
                    && _totalLateFee.Clean
                    && _unpaidPrincipalBalance.Clean
                    && _withdrawnDate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var additionalLateFeeCharge = _additionalLateFeeCharge; additionalLateFeeCharge.Clean = value; _additionalLateFeeCharge = additionalLateFeeCharge;
                var approvedToFundDate = _approvedToFundDate; approvedToFundDate.Clean = value; _approvedToFundDate = approvedToFundDate;
                var basePrice = _basePrice; basePrice.Clean = value; _basePrice = basePrice;
                var commitmentType = _commitmentType; commitmentType.Clean = value; _commitmentType = commitmentType;
                var conditionsReceivedDate = _conditionsReceivedDate; conditionsReceivedDate.Clean = value; _conditionsReceivedDate = conditionsReceivedDate;
                var correspondentStatus = _correspondentStatus; correspondentStatus.Clean = value; _correspondentStatus = correspondentStatus;
                var deliveryExpirationDate = _deliveryExpirationDate; deliveryExpirationDate.Clean = value; _deliveryExpirationDate = deliveryExpirationDate;
                var deliveryType = _deliveryType; deliveryType.Clean = value; _deliveryType = deliveryType;
                var fundedDate = _fundedDate; fundedDate.Clean = value; _fundedDate = fundedDate;
                var gracePeriodDays = _gracePeriodDays; gracePeriodDays.Clean = value; _gracePeriodDays = gracePeriodDays;
                var gracePeriodStartDate = _gracePeriodStartDate; gracePeriodStartDate.Clean = value; _gracePeriodStartDate = gracePeriodStartDate;
                var gracePeriodStartTrigger = _gracePeriodStartTrigger; gracePeriodStartTrigger.Clean = value; _gracePeriodStartTrigger = gracePeriodStartTrigger;
                var id = _id; id.Clean = value; _id = id;
                var initialSuspenseDate = _initialSuspenseDate; initialSuspenseDate.Clean = value; _initialSuspenseDate = initialSuspenseDate;
                var lateDaysBegin = _lateDaysBegin; lateDaysBegin.Clean = value; _lateDaysBegin = lateDaysBegin;
                var lateDaysEnd = _lateDaysEnd; lateDaysEnd.Clean = value; _lateDaysEnd = lateDaysEnd;
                var lateDaysEndTrigger = _lateDaysEndTrigger; lateDaysEndTrigger.Clean = value; _lateDaysEndTrigger = lateDaysEndTrigger;
                var lateFeeChargeType = _lateFeeChargeType; lateFeeChargeType.Clean = value; _lateFeeChargeType = lateFeeChargeType;
                var lateFeeFrequency = _lateFeeFrequency; lateFeeFrequency.Clean = value; _lateFeeFrequency = lateFeeFrequency;
                var lateFeeNotes = _lateFeeNotes; lateFeeNotes.Clean = value; _lateFeeNotes = lateFeeNotes;
                var lateFeePercentage = _lateFeePercentage; lateFeePercentage.Clean = value; _lateFeePercentage = lateFeePercentage;
                var lateFeeTotalPriceAdjustment = _lateFeeTotalPriceAdjustment; lateFeeTotalPriceAdjustment.Clean = value; _lateFeeTotalPriceAdjustment = lateFeeTotalPriceAdjustment;
                var latestConditionsDate = _latestConditionsDate; latestConditionsDate.Clean = value; _latestConditionsDate = latestConditionsDate;
                var lFS_CalculateAs = _lFS_CalculateAs; lFS_CalculateAs.Clean = value; _lFS_CalculateAs = lFS_CalculateAs;
                var lFS_DayCleared = _lFS_DayCleared; lFS_DayCleared.Clean = value; _lFS_DayCleared = lFS_DayCleared;
                var lFS_DayClearedOtherDate = _lFS_DayClearedOtherDate; lFS_DayClearedOtherDate.Clean = value; _lFS_DayClearedOtherDate = lFS_DayClearedOtherDate;
                var lFS_DayClearedOtherDateValue = _lFS_DayClearedOtherDateValue; lFS_DayClearedOtherDateValue.Clean = value; _lFS_DayClearedOtherDateValue = lFS_DayClearedOtherDateValue;
                var lFS_FeeHandledAs = _lFS_FeeHandledAs; lFS_FeeHandledAs.Clean = value; _lFS_FeeHandledAs = lFS_FeeHandledAs;
                var lFS_GracePeriodCalendar = _lFS_GracePeriodCalendar; lFS_GracePeriodCalendar.Clean = value; _lFS_GracePeriodCalendar = lFS_GracePeriodCalendar;
                var lFS_GracePeriodDays = _lFS_GracePeriodDays; lFS_GracePeriodDays.Clean = value; _lFS_GracePeriodDays = lFS_GracePeriodDays;
                var lFS_GracePeriodLaterOf = _lFS_GracePeriodLaterOf; lFS_GracePeriodLaterOf.Clean = value; _lFS_GracePeriodLaterOf = lFS_GracePeriodLaterOf;
                var lFS_GracePeriodStarts = _lFS_GracePeriodStarts; lFS_GracePeriodStarts.Clean = value; _lFS_GracePeriodStarts = lFS_GracePeriodStarts;
                var lFS_IncludeDay = _lFS_IncludeDay; lFS_IncludeDay.Clean = value; _lFS_IncludeDay = lFS_IncludeDay;
                var lFS_LateFeeBasedOn = _lFS_LateFeeBasedOn; lFS_LateFeeBasedOn.Clean = value; _lFS_LateFeeBasedOn = lFS_LateFeeBasedOn;
                var lFS_MaxLateDays = _lFS_MaxLateDays; lFS_MaxLateDays.Clean = value; _lFS_MaxLateDays = lFS_MaxLateDays;
                var lFS_OtherDate = _lFS_OtherDate; lFS_OtherDate.Clean = value; _lFS_OtherDate = lFS_OtherDate;
                var lFS_OtherDateValue = _lFS_OtherDateValue; lFS_OtherDateValue.Clean = value; _lFS_OtherDateValue = lFS_OtherDateValue;
                var lFS_StartOnWeekend = _lFS_StartOnWeekend; lFS_StartOnWeekend.Clean = value; _lFS_StartOnWeekend = lFS_StartOnWeekend;
                var noteDate = _noteDate; noteDate.Clean = value; _noteDate = noteDate;
                var originalPrincipalBalance = _originalPrincipalBalance; originalPrincipalBalance.Clean = value; _originalPrincipalBalance = originalPrincipalBalance;
                var ratesheet = _ratesheet; ratesheet.Clean = value; _ratesheet = ratesheet;
                var receivedDate = _receivedDate; receivedDate.Clean = value; _receivedDate = receivedDate;
                var rejectedDate = _rejectedDate; rejectedDate.Clean = value; _rejectedDate = rejectedDate;
                var submittedforPurchaseDate = _submittedforPurchaseDate; submittedforPurchaseDate.Clean = value; _submittedforPurchaseDate = submittedforPurchaseDate;
                var totalLateDays = _totalLateDays; totalLateDays.Clean = value; _totalLateDays = totalLateDays;
                var totalLateFee = _totalLateFee; totalLateFee.Clean = value; _totalLateFee = totalLateFee;
                var unpaidPrincipalBalance = _unpaidPrincipalBalance; unpaidPrincipalBalance.Clean = value; _unpaidPrincipalBalance = unpaidPrincipalBalance;
                var withdrawnDate = _withdrawnDate; withdrawnDate.Clean = value; _withdrawnDate = withdrawnDate;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Correspondent()
        {
            Clean = true;
        }
    }
}