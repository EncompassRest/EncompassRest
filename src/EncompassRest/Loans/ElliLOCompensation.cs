using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class ElliLOCompensation
    {
        public string WhoPaidCompensation { get; set; }
        public string LoanOriginatorName { get; set; }
        public string PlanName { get; set; }
        public string TriggerField { get; set; }
        public DateTime? PlanDate { get; set; }
        public decimal? BasePlanRateForBroker { get; set; }
        public decimal? BasePlanAdditonalAmountForBroker { get; set; }
        public decimal? BasePlanAmountForBroker { get; set; }
        public decimal? BasePlanMinimumAmountForBroker { get; set; }
        public decimal? BasePlanMaximumAmountForBroker { get; set; }
        public decimal? AdjustedPlanRateForBroker { get; set; }
        public decimal? AdjustedPlanAdditonalAmountForBroker { get; set; }
        public decimal? AdjustedPlanAmountForBroker { get; set; }
        public decimal? NetAdjustedAmountForBroker { get; set; }
        public string AdjustmentDescription { get; set; }
        public string RoundingMethod { get; set; }
        public string LoanAmountType { get; set; }
        public string LoanOriginatorID { get; set; }
        public string LastAppliedDateTime { get; set; }
        public DateTime? LastAppliedDate { get; set; }
        public string LoanOriginatorNameForOfficer { get; set; }
        public string PlanNameForOfficer { get; set; }
        public string RoundingMethodForOfficer { get; set; }
        public string LoanAmountTypeForOfficer { get; set; }
        public decimal? BasePlanRateForOfficer { get; set; }
        public decimal? BasePlanAdditonalAmountForOfficer { get; set; }
        public decimal? BasePlanAmountForOfficer { get; set; }
        public decimal? BasePlanMinimumAmountForOfficer { get; set; }
        public decimal? BasePlanMaximumAmountForOfficer { get; set; }
        public decimal? BonusCompRate { get; set; }
        public decimal? BonusCompAdditonalAmount { get; set; }
        public decimal? BonusCompAmount { get; set; }
        public decimal? AdjustedPlanRateForOfficer { get; set; }
        public decimal? AdjustedPlanAdditonalAmountForOfficer { get; set; }
        public decimal? AdjustedPlanAmountForOfficer { get; set; }
        public decimal? NetAdjustedAmountForOfficer { get; set; }
        public string AdjustmentDescriptionForOfficer { get; set; }
        public string LoanOriginatorIDForOfficer { get; set; }
        public string Id { get; set; }
    }
}