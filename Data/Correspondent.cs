
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class Correspondent
{
public string correspondentStatus { get; set; }
public DateTime? receivedDate { get; set; }
public DateTime? initialSuspenseDate { get; set; }
public DateTime? latestConditionsDate { get; set; }
public DateTime? conditionsReceivedDate { get; set; }
public DateTime? approvedToFundDate { get; set; }
public DateTime? fundedDate { get; set; }
public string ratesheet { get; set; }
public decimal? basePrice { get; set; }
public DateTime? noteDate { get; set; }
public DateTime? deliveryExpirationDate { get; set; }
public int? gracePeriodDays { get; set; }
public DateTime? lateDaysBegin { get; set; }
public DateTime? lateDaysEnd { get; set; }
public int? totalLateDays { get; set; }
public decimal? lateFeePercentage { get; set; }
public decimal? additionalLateFeeCharge { get; set; }
public string lateFeeFrequency { get; set; }
public decimal? lateFeeTotalPriceAdjustment { get; set; }
public string lateFeeNotes { get; set; }
public string lateFeeChargeType { get; set; }
public decimal? totalLateFee { get; set; }
public string deliveryType { get; set; }
public DateTime? rejectedDate { get; set; }
public DateTime? gracePeriodStartDate { get; set; }
public string gracePeriodStartTrigger { get; set; }
public string lateDaysEndTrigger { get; set; }
public int? lFS_CalculateAs { get; set; }
public int? lFS_FeeHandledAs { get; set; }
public int? lFS_GracePeriodCalendar { get; set; }
public int? lFS_GracePeriodLaterOf { get; set; }
public int? lFS_GracePeriodStarts { get; set; }
public int? lFS_IncludeDay { get; set; }
public int? lFS_LateFeeBasedOn { get; set; }
public int? lFS_MaxLateDays { get; set; }
public string lFS_OtherDate { get; set; }
public int? lFS_StartOnWeekend { get; set; }
public int? lFS_GracePeriodDays { get; set; }
public int? lFS_DayCleared { get; set; }
public string lFS_DayClearedOtherDate { get; set; }
public string commitmentType { get; set; }
public decimal? unpaidPrincipalBalance { get; set; }
public decimal? originalPrincipalBalance { get; set; }
public string id { get; set; }

    }
}