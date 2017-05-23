using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Correspondent
    {
        public JsonNullable<decimal?> AdditionalLateFeeCharge { get; set; }
        public JsonNullable<DateTime?> ApprovedToFundDate { get; set; }
        public JsonNullable<decimal?> BasePrice { get; set; }
        public string CommitmentType { get; set; }
        public JsonNullable<DateTime?> ConditionsReceivedDate { get; set; }
        public string CorrespondentStatus { get; set; }
        public JsonNullable<DateTime?> DeliveryExpirationDate { get; set; }
        public string DeliveryType { get; set; }
        public JsonNullable<DateTime?> FundedDate { get; set; }
        public JsonNullable<int?> GracePeriodDays { get; set; }
        public JsonNullable<DateTime?> GracePeriodStartDate { get; set; }
        public string GracePeriodStartTrigger { get; set; }
        public string Id { get; set; }
        public JsonNullable<DateTime?> InitialSuspenseDate { get; set; }
        public JsonNullable<DateTime?> LateDaysBegin { get; set; }
        public JsonNullable<DateTime?> LateDaysEnd { get; set; }
        public string LateDaysEndTrigger { get; set; }
        public string LateFeeChargeType { get; set; }
        public string LateFeeFrequency { get; set; }
        public string LateFeeNotes { get; set; }
        public JsonNullable<decimal?> LateFeePercentage { get; set; }
        public JsonNullable<decimal?> LateFeeTotalPriceAdjustment { get; set; }
        public JsonNullable<DateTime?> LatestConditionsDate { get; set; }
        public JsonNullable<int?> LFS_CalculateAs { get; set; }
        public JsonNullable<int?> LFS_DayCleared { get; set; }
        public string LFS_DayClearedOtherDate { get; set; }
        public string LFS_DayClearedOtherDateValue { get; set; }
        public JsonNullable<int?> LFS_FeeHandledAs { get; set; }
        public JsonNullable<int?> LFS_GracePeriodCalendar { get; set; }
        public JsonNullable<int?> LFS_GracePeriodDays { get; set; }
        public JsonNullable<int?> LFS_GracePeriodLaterOf { get; set; }
        public JsonNullable<int?> LFS_GracePeriodStarts { get; set; }
        public JsonNullable<int?> LFS_IncludeDay { get; set; }
        public JsonNullable<int?> LFS_LateFeeBasedOn { get; set; }
        public JsonNullable<int?> LFS_MaxLateDays { get; set; }
        public string LFS_OtherDate { get; set; }
        public string LFS_OtherDateValue { get; set; }
        public JsonNullable<int?> LFS_StartOnWeekend { get; set; }
        public JsonNullable<DateTime?> NoteDate { get; set; }
        public JsonNullable<decimal?> OriginalPrincipalBalance { get; set; }
        public string Ratesheet { get; set; }
        public JsonNullable<DateTime?> ReceivedDate { get; set; }
        public JsonNullable<DateTime?> RejectedDate { get; set; }
        public JsonNullable<DateTime?> SubmittedforPurchaseDate { get; set; }
        public JsonNullable<int?> TotalLateDays { get; set; }
        public JsonNullable<decimal?> TotalLateFee { get; set; }
        public JsonNullable<decimal?> UnpaidPrincipalBalance { get; set; }
        public JsonNullable<DateTime?> WithdrawnDate { get; set; }
    }
}