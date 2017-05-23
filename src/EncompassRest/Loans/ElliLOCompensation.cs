using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class ElliLOCompensation
    {
        public JsonNullable<decimal?> AdjustedPlanAdditonalAmountForBroker { get; set; }
        public JsonNullable<decimal?> AdjustedPlanAdditonalAmountForOfficer { get; set; }
        public JsonNullable<decimal?> AdjustedPlanAmountForBroker { get; set; }
        public JsonNullable<decimal?> AdjustedPlanAmountForOfficer { get; set; }
        public JsonNullable<decimal?> AdjustedPlanRateForBroker { get; set; }
        public JsonNullable<decimal?> AdjustedPlanRateForOfficer { get; set; }
        public string AdjustmentDescription { get; set; }
        public string AdjustmentDescriptionForOfficer { get; set; }
        public JsonNullable<decimal?> BasePlanAdditonalAmountForBroker { get; set; }
        public JsonNullable<decimal?> BasePlanAdditonalAmountForOfficer { get; set; }
        public JsonNullable<decimal?> BasePlanAmountForBroker { get; set; }
        public JsonNullable<decimal?> BasePlanAmountForOfficer { get; set; }
        public JsonNullable<decimal?> BasePlanMaximumAmountForBroker { get; set; }
        public JsonNullable<decimal?> BasePlanMaximumAmountForOfficer { get; set; }
        public JsonNullable<decimal?> BasePlanMinimumAmountForBroker { get; set; }
        public JsonNullable<decimal?> BasePlanMinimumAmountForOfficer { get; set; }
        public JsonNullable<decimal?> BasePlanRateForBroker { get; set; }
        public JsonNullable<decimal?> BasePlanRateForOfficer { get; set; }
        public JsonNullable<decimal?> BonusCompAdditonalAmount { get; set; }
        public JsonNullable<decimal?> BonusCompAmount { get; set; }
        public JsonNullable<decimal?> BonusCompRate { get; set; }
        public string Id { get; set; }
        public JsonNullable<DateTime?> LastAppliedDate { get; set; }
        public string LastAppliedDateTime { get; set; }
        public string LoanAmountType { get; set; }
        public string LoanAmountTypeForOfficer { get; set; }
        public string LoanOriginatorID { get; set; }
        public string LoanOriginatorIDForOfficer { get; set; }
        public string LoanOriginatorName { get; set; }
        public string LoanOriginatorNameForOfficer { get; set; }
        public JsonNullable<decimal?> NetAdjustedAmountForBroker { get; set; }
        public JsonNullable<decimal?> NetAdjustedAmountForOfficer { get; set; }
        public JsonNullable<DateTime?> PlanDate { get; set; }
        public string PlanName { get; set; }
        public string PlanNameForOfficer { get; set; }
        public string RoundingMethod { get; set; }
        public string RoundingMethodForOfficer { get; set; }
        public string TriggerField { get; set; }
        public string WhoPaidCompensation { get; set; }
    }
}