using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

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
                var v0 = _additionalLateFeeCharge; v0.Clean = value; _additionalLateFeeCharge = v0;
                var v1 = _approvedToFundDate; v1.Clean = value; _approvedToFundDate = v1;
                var v2 = _basePrice; v2.Clean = value; _basePrice = v2;
                var v3 = _commitmentType; v3.Clean = value; _commitmentType = v3;
                var v4 = _conditionsReceivedDate; v4.Clean = value; _conditionsReceivedDate = v4;
                var v5 = _correspondentStatus; v5.Clean = value; _correspondentStatus = v5;
                var v6 = _deliveryExpirationDate; v6.Clean = value; _deliveryExpirationDate = v6;
                var v7 = _deliveryType; v7.Clean = value; _deliveryType = v7;
                var v8 = _fundedDate; v8.Clean = value; _fundedDate = v8;
                var v9 = _gracePeriodDays; v9.Clean = value; _gracePeriodDays = v9;
                var v10 = _gracePeriodStartDate; v10.Clean = value; _gracePeriodStartDate = v10;
                var v11 = _gracePeriodStartTrigger; v11.Clean = value; _gracePeriodStartTrigger = v11;
                var v12 = _id; v12.Clean = value; _id = v12;
                var v13 = _initialSuspenseDate; v13.Clean = value; _initialSuspenseDate = v13;
                var v14 = _lateDaysBegin; v14.Clean = value; _lateDaysBegin = v14;
                var v15 = _lateDaysEnd; v15.Clean = value; _lateDaysEnd = v15;
                var v16 = _lateDaysEndTrigger; v16.Clean = value; _lateDaysEndTrigger = v16;
                var v17 = _lateFeeChargeType; v17.Clean = value; _lateFeeChargeType = v17;
                var v18 = _lateFeeFrequency; v18.Clean = value; _lateFeeFrequency = v18;
                var v19 = _lateFeeNotes; v19.Clean = value; _lateFeeNotes = v19;
                var v20 = _lateFeePercentage; v20.Clean = value; _lateFeePercentage = v20;
                var v21 = _lateFeeTotalPriceAdjustment; v21.Clean = value; _lateFeeTotalPriceAdjustment = v21;
                var v22 = _latestConditionsDate; v22.Clean = value; _latestConditionsDate = v22;
                var v23 = _lFS_CalculateAs; v23.Clean = value; _lFS_CalculateAs = v23;
                var v24 = _lFS_DayCleared; v24.Clean = value; _lFS_DayCleared = v24;
                var v25 = _lFS_DayClearedOtherDate; v25.Clean = value; _lFS_DayClearedOtherDate = v25;
                var v26 = _lFS_DayClearedOtherDateValue; v26.Clean = value; _lFS_DayClearedOtherDateValue = v26;
                var v27 = _lFS_FeeHandledAs; v27.Clean = value; _lFS_FeeHandledAs = v27;
                var v28 = _lFS_GracePeriodCalendar; v28.Clean = value; _lFS_GracePeriodCalendar = v28;
                var v29 = _lFS_GracePeriodDays; v29.Clean = value; _lFS_GracePeriodDays = v29;
                var v30 = _lFS_GracePeriodLaterOf; v30.Clean = value; _lFS_GracePeriodLaterOf = v30;
                var v31 = _lFS_GracePeriodStarts; v31.Clean = value; _lFS_GracePeriodStarts = v31;
                var v32 = _lFS_IncludeDay; v32.Clean = value; _lFS_IncludeDay = v32;
                var v33 = _lFS_LateFeeBasedOn; v33.Clean = value; _lFS_LateFeeBasedOn = v33;
                var v34 = _lFS_MaxLateDays; v34.Clean = value; _lFS_MaxLateDays = v34;
                var v35 = _lFS_OtherDate; v35.Clean = value; _lFS_OtherDate = v35;
                var v36 = _lFS_OtherDateValue; v36.Clean = value; _lFS_OtherDateValue = v36;
                var v37 = _lFS_StartOnWeekend; v37.Clean = value; _lFS_StartOnWeekend = v37;
                var v38 = _noteDate; v38.Clean = value; _noteDate = v38;
                var v39 = _originalPrincipalBalance; v39.Clean = value; _originalPrincipalBalance = v39;
                var v40 = _ratesheet; v40.Clean = value; _ratesheet = v40;
                var v41 = _receivedDate; v41.Clean = value; _receivedDate = v41;
                var v42 = _rejectedDate; v42.Clean = value; _rejectedDate = v42;
                var v43 = _submittedforPurchaseDate; v43.Clean = value; _submittedforPurchaseDate = v43;
                var v44 = _totalLateDays; v44.Clean = value; _totalLateDays = v44;
                var v45 = _totalLateFee; v45.Clean = value; _totalLateFee = v45;
                var v46 = _unpaidPrincipalBalance; v46.Clean = value; _unpaidPrincipalBalance = v46;
                var v47 = _withdrawnDate; v47.Clean = value; _withdrawnDate = v47;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}