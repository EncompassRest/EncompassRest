using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Correspondent
    {
        public Value<decimal?> AdditionalLateFeeCharge { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalLateFeeCharge() => !AdditionalLateFeeCharge.Clean;
        public Value<DateTime?> ApprovedToFundDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApprovedToFundDate() => !ApprovedToFundDate.Clean;
        public Value<decimal?> BasePrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePrice() => !BasePrice.Clean;
        public Value<string> CommitmentType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentType() => !CommitmentType.Clean;
        public Value<DateTime?> ConditionsReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConditionsReceivedDate() => !ConditionsReceivedDate.Clean;
        public Value<string> CorrespondentStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCorrespondentStatus() => !CorrespondentStatus.Clean;
        public Value<DateTime?> DeliveryExpirationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDeliveryExpirationDate() => !DeliveryExpirationDate.Clean;
        public Value<string> DeliveryType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDeliveryType() => !DeliveryType.Clean;
        public Value<DateTime?> FundedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundedDate() => !FundedDate.Clean;
        public Value<int?> GracePeriodDays { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGracePeriodDays() => !GracePeriodDays.Clean;
        public Value<DateTime?> GracePeriodStartDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGracePeriodStartDate() => !GracePeriodStartDate.Clean;
        public Value<string> GracePeriodStartTrigger { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGracePeriodStartTrigger() => !GracePeriodStartTrigger.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<DateTime?> InitialSuspenseDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialSuspenseDate() => !InitialSuspenseDate.Clean;
        public Value<DateTime?> LateDaysBegin { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLateDaysBegin() => !LateDaysBegin.Clean;
        public Value<DateTime?> LateDaysEnd { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLateDaysEnd() => !LateDaysEnd.Clean;
        public Value<string> LateDaysEndTrigger { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLateDaysEndTrigger() => !LateDaysEndTrigger.Clean;
        public Value<string> LateFeeChargeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLateFeeChargeType() => !LateFeeChargeType.Clean;
        public Value<string> LateFeeFrequency { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLateFeeFrequency() => !LateFeeFrequency.Clean;
        public Value<string> LateFeeNotes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLateFeeNotes() => !LateFeeNotes.Clean;
        public Value<decimal?> LateFeePercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLateFeePercentage() => !LateFeePercentage.Clean;
        public Value<decimal?> LateFeeTotalPriceAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLateFeeTotalPriceAdjustment() => !LateFeeTotalPriceAdjustment.Clean;
        public Value<DateTime?> LatestConditionsDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLatestConditionsDate() => !LatestConditionsDate.Clean;
        public Value<int?> LFS_CalculateAs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLFS_CalculateAs() => !LFS_CalculateAs.Clean;
        public Value<int?> LFS_DayCleared { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLFS_DayCleared() => !LFS_DayCleared.Clean;
        public Value<string> LFS_DayClearedOtherDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLFS_DayClearedOtherDate() => !LFS_DayClearedOtherDate.Clean;
        public Value<string> LFS_DayClearedOtherDateValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLFS_DayClearedOtherDateValue() => !LFS_DayClearedOtherDateValue.Clean;
        public Value<int?> LFS_FeeHandledAs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLFS_FeeHandledAs() => !LFS_FeeHandledAs.Clean;
        public Value<int?> LFS_GracePeriodCalendar { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLFS_GracePeriodCalendar() => !LFS_GracePeriodCalendar.Clean;
        public Value<int?> LFS_GracePeriodDays { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLFS_GracePeriodDays() => !LFS_GracePeriodDays.Clean;
        public Value<int?> LFS_GracePeriodLaterOf { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLFS_GracePeriodLaterOf() => !LFS_GracePeriodLaterOf.Clean;
        public Value<int?> LFS_GracePeriodStarts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLFS_GracePeriodStarts() => !LFS_GracePeriodStarts.Clean;
        public Value<int?> LFS_IncludeDay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLFS_IncludeDay() => !LFS_IncludeDay.Clean;
        public Value<int?> LFS_LateFeeBasedOn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLFS_LateFeeBasedOn() => !LFS_LateFeeBasedOn.Clean;
        public Value<int?> LFS_MaxLateDays { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLFS_MaxLateDays() => !LFS_MaxLateDays.Clean;
        public Value<string> LFS_OtherDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLFS_OtherDate() => !LFS_OtherDate.Clean;
        public Value<string> LFS_OtherDateValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLFS_OtherDateValue() => !LFS_OtherDateValue.Clean;
        public Value<int?> LFS_StartOnWeekend { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLFS_StartOnWeekend() => !LFS_StartOnWeekend.Clean;
        public Value<DateTime?> NoteDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNoteDate() => !NoteDate.Clean;
        public Value<decimal?> OriginalPrincipalBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginalPrincipalBalance() => !OriginalPrincipalBalance.Clean;
        public Value<string> Ratesheet { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRatesheet() => !Ratesheet.Clean;
        public Value<DateTime?> ReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceivedDate() => !ReceivedDate.Clean;
        public Value<DateTime?> RejectedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRejectedDate() => !RejectedDate.Clean;
        public Value<DateTime?> SubmittedforPurchaseDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittedforPurchaseDate() => !SubmittedforPurchaseDate.Clean;
        public Value<int?> TotalLateDays { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalLateDays() => !TotalLateDays.Clean;
        public Value<decimal?> TotalLateFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalLateFee() => !TotalLateFee.Clean;
        public Value<decimal?> UnpaidPrincipalBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidPrincipalBalance() => !UnpaidPrincipalBalance.Clean;
        public Value<DateTime?> WithdrawnDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWithdrawnDate() => !WithdrawnDate.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AdditionalLateFeeCharge.Clean
                    && ApprovedToFundDate.Clean
                    && BasePrice.Clean
                    && CommitmentType.Clean
                    && ConditionsReceivedDate.Clean
                    && CorrespondentStatus.Clean
                    && DeliveryExpirationDate.Clean
                    && DeliveryType.Clean
                    && FundedDate.Clean
                    && GracePeriodDays.Clean
                    && GracePeriodStartDate.Clean
                    && GracePeriodStartTrigger.Clean
                    && Id.Clean
                    && InitialSuspenseDate.Clean
                    && LateDaysBegin.Clean
                    && LateDaysEnd.Clean
                    && LateDaysEndTrigger.Clean
                    && LateFeeChargeType.Clean
                    && LateFeeFrequency.Clean
                    && LateFeeNotes.Clean
                    && LateFeePercentage.Clean
                    && LateFeeTotalPriceAdjustment.Clean
                    && LatestConditionsDate.Clean
                    && LFS_CalculateAs.Clean
                    && LFS_DayCleared.Clean
                    && LFS_DayClearedOtherDate.Clean
                    && LFS_DayClearedOtherDateValue.Clean
                    && LFS_FeeHandledAs.Clean
                    && LFS_GracePeriodCalendar.Clean
                    && LFS_GracePeriodDays.Clean
                    && LFS_GracePeriodLaterOf.Clean
                    && LFS_GracePeriodStarts.Clean
                    && LFS_IncludeDay.Clean
                    && LFS_LateFeeBasedOn.Clean
                    && LFS_MaxLateDays.Clean
                    && LFS_OtherDate.Clean
                    && LFS_OtherDateValue.Clean
                    && LFS_StartOnWeekend.Clean
                    && NoteDate.Clean
                    && OriginalPrincipalBalance.Clean
                    && Ratesheet.Clean
                    && ReceivedDate.Clean
                    && RejectedDate.Clean
                    && SubmittedforPurchaseDate.Clean
                    && TotalLateDays.Clean
                    && TotalLateFee.Clean
                    && UnpaidPrincipalBalance.Clean
                    && WithdrawnDate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AdditionalLateFeeCharge; v0.Clean = value; AdditionalLateFeeCharge = v0;
                var v1 = ApprovedToFundDate; v1.Clean = value; ApprovedToFundDate = v1;
                var v2 = BasePrice; v2.Clean = value; BasePrice = v2;
                var v3 = CommitmentType; v3.Clean = value; CommitmentType = v3;
                var v4 = ConditionsReceivedDate; v4.Clean = value; ConditionsReceivedDate = v4;
                var v5 = CorrespondentStatus; v5.Clean = value; CorrespondentStatus = v5;
                var v6 = DeliveryExpirationDate; v6.Clean = value; DeliveryExpirationDate = v6;
                var v7 = DeliveryType; v7.Clean = value; DeliveryType = v7;
                var v8 = FundedDate; v8.Clean = value; FundedDate = v8;
                var v9 = GracePeriodDays; v9.Clean = value; GracePeriodDays = v9;
                var v10 = GracePeriodStartDate; v10.Clean = value; GracePeriodStartDate = v10;
                var v11 = GracePeriodStartTrigger; v11.Clean = value; GracePeriodStartTrigger = v11;
                var v12 = Id; v12.Clean = value; Id = v12;
                var v13 = InitialSuspenseDate; v13.Clean = value; InitialSuspenseDate = v13;
                var v14 = LateDaysBegin; v14.Clean = value; LateDaysBegin = v14;
                var v15 = LateDaysEnd; v15.Clean = value; LateDaysEnd = v15;
                var v16 = LateDaysEndTrigger; v16.Clean = value; LateDaysEndTrigger = v16;
                var v17 = LateFeeChargeType; v17.Clean = value; LateFeeChargeType = v17;
                var v18 = LateFeeFrequency; v18.Clean = value; LateFeeFrequency = v18;
                var v19 = LateFeeNotes; v19.Clean = value; LateFeeNotes = v19;
                var v20 = LateFeePercentage; v20.Clean = value; LateFeePercentage = v20;
                var v21 = LateFeeTotalPriceAdjustment; v21.Clean = value; LateFeeTotalPriceAdjustment = v21;
                var v22 = LatestConditionsDate; v22.Clean = value; LatestConditionsDate = v22;
                var v23 = LFS_CalculateAs; v23.Clean = value; LFS_CalculateAs = v23;
                var v24 = LFS_DayCleared; v24.Clean = value; LFS_DayCleared = v24;
                var v25 = LFS_DayClearedOtherDate; v25.Clean = value; LFS_DayClearedOtherDate = v25;
                var v26 = LFS_DayClearedOtherDateValue; v26.Clean = value; LFS_DayClearedOtherDateValue = v26;
                var v27 = LFS_FeeHandledAs; v27.Clean = value; LFS_FeeHandledAs = v27;
                var v28 = LFS_GracePeriodCalendar; v28.Clean = value; LFS_GracePeriodCalendar = v28;
                var v29 = LFS_GracePeriodDays; v29.Clean = value; LFS_GracePeriodDays = v29;
                var v30 = LFS_GracePeriodLaterOf; v30.Clean = value; LFS_GracePeriodLaterOf = v30;
                var v31 = LFS_GracePeriodStarts; v31.Clean = value; LFS_GracePeriodStarts = v31;
                var v32 = LFS_IncludeDay; v32.Clean = value; LFS_IncludeDay = v32;
                var v33 = LFS_LateFeeBasedOn; v33.Clean = value; LFS_LateFeeBasedOn = v33;
                var v34 = LFS_MaxLateDays; v34.Clean = value; LFS_MaxLateDays = v34;
                var v35 = LFS_OtherDate; v35.Clean = value; LFS_OtherDate = v35;
                var v36 = LFS_OtherDateValue; v36.Clean = value; LFS_OtherDateValue = v36;
                var v37 = LFS_StartOnWeekend; v37.Clean = value; LFS_StartOnWeekend = v37;
                var v38 = NoteDate; v38.Clean = value; NoteDate = v38;
                var v39 = OriginalPrincipalBalance; v39.Clean = value; OriginalPrincipalBalance = v39;
                var v40 = Ratesheet; v40.Clean = value; Ratesheet = v40;
                var v41 = ReceivedDate; v41.Clean = value; ReceivedDate = v41;
                var v42 = RejectedDate; v42.Clean = value; RejectedDate = v42;
                var v43 = SubmittedforPurchaseDate; v43.Clean = value; SubmittedforPurchaseDate = v43;
                var v44 = TotalLateDays; v44.Clean = value; TotalLateDays = v44;
                var v45 = TotalLateFee; v45.Clean = value; TotalLateFee = v45;
                var v46 = UnpaidPrincipalBalance; v46.Clean = value; UnpaidPrincipalBalance = v46;
                var v47 = WithdrawnDate; v47.Clean = value; WithdrawnDate = v47;
                _settingClean = 0;
            }
        }
    }
}