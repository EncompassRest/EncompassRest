
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class ElliLOCompensation
{
public string whoPaidCompensation { get; set; }
public string loanOriginatorName { get; set; }
public string planName { get; set; }
public string triggerField { get; set; }
public DateTime? planDate { get; set; }
public decimal? basePlanRateForBroker { get; set; }
public decimal? basePlanAdditonalAmountForBroker { get; set; }
public decimal? basePlanAmountForBroker { get; set; }
public decimal? basePlanMinimumAmountForBroker { get; set; }
public decimal? basePlanMaximumAmountForBroker { get; set; }
public decimal? adjustedPlanRateForBroker { get; set; }
public decimal? adjustedPlanAdditonalAmountForBroker { get; set; }
public decimal? adjustedPlanAmountForBroker { get; set; }
public decimal? netAdjustedAmountForBroker { get; set; }
public string adjustmentDescription { get; set; }
public string roundingMethod { get; set; }
public string loanAmountType { get; set; }
public string loanOriginatorID { get; set; }
public string lastAppliedDateTime { get; set; }
public DateTime? lastAppliedDate { get; set; }
public string loanOriginatorNameForOfficer { get; set; }
public string planNameForOfficer { get; set; }
public string roundingMethodForOfficer { get; set; }
public string loanAmountTypeForOfficer { get; set; }
public decimal? basePlanRateForOfficer { get; set; }
public decimal? basePlanAdditonalAmountForOfficer { get; set; }
public decimal? basePlanAmountForOfficer { get; set; }
public decimal? basePlanMinimumAmountForOfficer { get; set; }
public decimal? basePlanMaximumAmountForOfficer { get; set; }
public decimal? bonusCompRate { get; set; }
public decimal? bonusCompAdditonalAmount { get; set; }
public decimal? bonusCompAmount { get; set; }
public decimal? adjustedPlanRateForOfficer { get; set; }
public decimal? adjustedPlanAdditonalAmountForOfficer { get; set; }
public decimal? adjustedPlanAmountForOfficer { get; set; }
public decimal? netAdjustedAmountForOfficer { get; set; }
public string adjustmentDescriptionForOfficer { get; set; }
public string loanOriginatorIDForOfficer { get; set; }
public string id { get; set; }

    }
}