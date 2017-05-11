using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Correspondent
    {
        public string CorrespondentStatus { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public DateTime? InitialSuspenseDate { get; set; }
        public DateTime? LatestConditionsDate { get; set; }
        public DateTime? ConditionsReceivedDate { get; set; }
        public DateTime? ApprovedToFundDate { get; set; }
        public DateTime? FundedDate { get; set; }
        public string Ratesheet { get; set; }
        public decimal? BasePrice { get; set; }
        public DateTime? NoteDate { get; set; }
        public DateTime? DeliveryExpirationDate { get; set; }
        public int? GracePeriodDays { get; set; }
        public DateTime? LateDaysBegin { get; set; }
        public DateTime? LateDaysEnd { get; set; }
        public int? TotalLateDays { get; set; }
        public decimal? LateFeePercentage { get; set; }
        public decimal? AdditionalLateFeeCharge { get; set; }
        public string LateFeeFrequency { get; set; }
        public decimal? LateFeeTotalPriceAdjustment { get; set; }
        public string LateFeeNotes { get; set; }
        public string LateFeeChargeType { get; set; }
        public decimal? TotalLateFee { get; set; }
        public string DeliveryType { get; set; }
        public DateTime? RejectedDate { get; set; }
        public DateTime? GracePeriodStartDate { get; set; }
        public string GracePeriodStartTrigger { get; set; }
        public string LateDaysEndTrigger { get; set; }
        public DateTime? SubmittedforPurchaseDate { get; set; }
        public DateTime? WithdrawnDate { get; set; }
        public int? LFS_CalculateAs { get; set; }
        public int? LFS_FeeHandledAs { get; set; }
        public int? LFS_GracePeriodCalendar { get; set; }
        public int? LFS_GracePeriodLaterOf { get; set; }
        public int? LFS_GracePeriodStarts { get; set; }
        public int? LFS_IncludeDay { get; set; }
        public int? LFS_LateFeeBasedOn { get; set; }
        public int? LFS_MaxLateDays { get; set; }
        public string LFS_OtherDate { get; set; }
        public int? LFS_StartOnWeekend { get; set; }
        public int? LFS_GracePeriodDays { get; set; }
        public int? LFS_DayCleared { get; set; }
        public string LFS_DayClearedOtherDate { get; set; }
        public string LFS_OtherDateValue { get; set; }
        public string LFS_DayClearedOtherDateValue { get; set; }
        public string CommitmentType { get; set; }
        public decimal? UnpaidPrincipalBalance { get; set; }
        public decimal? OriginalPrincipalBalance { get; set; }
        public string Id { get; set; }
    }
}