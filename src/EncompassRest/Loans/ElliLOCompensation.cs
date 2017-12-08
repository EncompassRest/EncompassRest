#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class ElliLOCompensation : ExtensibleObject
    {
        private DirtyValue<decimal?> _adjustedPlanAdditonalAmountForBroker;
        public decimal? AdjustedPlanAdditonalAmountForBroker { get => _adjustedPlanAdditonalAmountForBroker; set => _adjustedPlanAdditonalAmountForBroker = value; }
        private DirtyValue<decimal?> _adjustedPlanAdditonalAmountForOfficer;
        public decimal? AdjustedPlanAdditonalAmountForOfficer { get => _adjustedPlanAdditonalAmountForOfficer; set => _adjustedPlanAdditonalAmountForOfficer = value; }
        private DirtyValue<decimal?> _adjustedPlanAmountForBroker;
        public decimal? AdjustedPlanAmountForBroker { get => _adjustedPlanAmountForBroker; set => _adjustedPlanAmountForBroker = value; }
        private DirtyValue<decimal?> _adjustedPlanAmountForOfficer;
        public decimal? AdjustedPlanAmountForOfficer { get => _adjustedPlanAmountForOfficer; set => _adjustedPlanAmountForOfficer = value; }
        private DirtyValue<decimal?> _adjustedPlanRateForBroker;
        public decimal? AdjustedPlanRateForBroker { get => _adjustedPlanRateForBroker; set => _adjustedPlanRateForBroker = value; }
        private DirtyValue<decimal?> _adjustedPlanRateForOfficer;
        public decimal? AdjustedPlanRateForOfficer { get => _adjustedPlanRateForOfficer; set => _adjustedPlanRateForOfficer = value; }
        private DirtyValue<string> _adjustmentDescription;
        public string AdjustmentDescription { get => _adjustmentDescription; set => _adjustmentDescription = value; }
        private DirtyValue<string> _adjustmentDescriptionForOfficer;
        public string AdjustmentDescriptionForOfficer { get => _adjustmentDescriptionForOfficer; set => _adjustmentDescriptionForOfficer = value; }
        private DirtyValue<decimal?> _basePlanAdditonalAmountForBroker;
        public decimal? BasePlanAdditonalAmountForBroker { get => _basePlanAdditonalAmountForBroker; set => _basePlanAdditonalAmountForBroker = value; }
        private DirtyValue<decimal?> _basePlanAdditonalAmountForOfficer;
        public decimal? BasePlanAdditonalAmountForOfficer { get => _basePlanAdditonalAmountForOfficer; set => _basePlanAdditonalAmountForOfficer = value; }
        private DirtyValue<decimal?> _basePlanAmountForBroker;
        public decimal? BasePlanAmountForBroker { get => _basePlanAmountForBroker; set => _basePlanAmountForBroker = value; }
        private DirtyValue<decimal?> _basePlanAmountForOfficer;
        public decimal? BasePlanAmountForOfficer { get => _basePlanAmountForOfficer; set => _basePlanAmountForOfficer = value; }
        private DirtyValue<decimal?> _basePlanMaximumAmountForBroker;
        public decimal? BasePlanMaximumAmountForBroker { get => _basePlanMaximumAmountForBroker; set => _basePlanMaximumAmountForBroker = value; }
        private DirtyValue<decimal?> _basePlanMaximumAmountForOfficer;
        public decimal? BasePlanMaximumAmountForOfficer { get => _basePlanMaximumAmountForOfficer; set => _basePlanMaximumAmountForOfficer = value; }
        private DirtyValue<decimal?> _basePlanMinimumAmountForBroker;
        public decimal? BasePlanMinimumAmountForBroker { get => _basePlanMinimumAmountForBroker; set => _basePlanMinimumAmountForBroker = value; }
        private DirtyValue<decimal?> _basePlanMinimumAmountForOfficer;
        public decimal? BasePlanMinimumAmountForOfficer { get => _basePlanMinimumAmountForOfficer; set => _basePlanMinimumAmountForOfficer = value; }
        private DirtyValue<decimal?> _basePlanRateForBroker;
        public decimal? BasePlanRateForBroker { get => _basePlanRateForBroker; set => _basePlanRateForBroker = value; }
        private DirtyValue<decimal?> _basePlanRateForOfficer;
        public decimal? BasePlanRateForOfficer { get => _basePlanRateForOfficer; set => _basePlanRateForOfficer = value; }
        private DirtyValue<decimal?> _bonusCompAdditonalAmount;
        public decimal? BonusCompAdditonalAmount { get => _bonusCompAdditonalAmount; set => _bonusCompAdditonalAmount = value; }
        private DirtyValue<decimal?> _bonusCompAmount;
        public decimal? BonusCompAmount { get => _bonusCompAmount; set => _bonusCompAmount = value; }
        private DirtyValue<decimal?> _bonusCompRate;
        public decimal? BonusCompRate { get => _bonusCompRate; set => _bonusCompRate = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<DateTime?> _lastAppliedDate;
        public DateTime? LastAppliedDate { get => _lastAppliedDate; set => _lastAppliedDate = value; }
        private DirtyValue<string> _lastAppliedDateTime;
        public string LastAppliedDateTime { get => _lastAppliedDateTime; set => _lastAppliedDateTime = value; }
        private DirtyValue<StringEnumValue<LoanAmountType>> _loanAmountType;
        public StringEnumValue<LoanAmountType> LoanAmountType { get => _loanAmountType; set => _loanAmountType = value; }
        private DirtyValue<StringEnumValue<LoanAmountType>> _loanAmountTypeForOfficer;
        public StringEnumValue<LoanAmountType> LoanAmountTypeForOfficer { get => _loanAmountTypeForOfficer; set => _loanAmountTypeForOfficer = value; }
        private DirtyValue<string> _loanOriginatorID;
        public string LoanOriginatorID { get => _loanOriginatorID; set => _loanOriginatorID = value; }
        private DirtyValue<string> _loanOriginatorIDForOfficer;
        public string LoanOriginatorIDForOfficer { get => _loanOriginatorIDForOfficer; set => _loanOriginatorIDForOfficer = value; }
        private DirtyValue<string> _loanOriginatorName;
        public string LoanOriginatorName { get => _loanOriginatorName; set => _loanOriginatorName = value; }
        private DirtyValue<string> _loanOriginatorNameForOfficer;
        public string LoanOriginatorNameForOfficer { get => _loanOriginatorNameForOfficer; set => _loanOriginatorNameForOfficer = value; }
        private DirtyValue<decimal?> _netAdjustedAmountForBroker;
        public decimal? NetAdjustedAmountForBroker { get => _netAdjustedAmountForBroker; set => _netAdjustedAmountForBroker = value; }
        private DirtyValue<decimal?> _netAdjustedAmountForOfficer;
        public decimal? NetAdjustedAmountForOfficer { get => _netAdjustedAmountForOfficer; set => _netAdjustedAmountForOfficer = value; }
        private DirtyValue<DateTime?> _planDate;
        public DateTime? PlanDate { get => _planDate; set => _planDate = value; }
        private DirtyValue<string> _planName;
        public string PlanName { get => _planName; set => _planName = value; }
        private DirtyValue<string> _planNameForOfficer;
        public string PlanNameForOfficer { get => _planNameForOfficer; set => _planNameForOfficer = value; }
        private DirtyValue<StringEnumValue<RoundingMethod>> _roundingMethod;
        public StringEnumValue<RoundingMethod> RoundingMethod { get => _roundingMethod; set => _roundingMethod = value; }
        private DirtyValue<StringEnumValue<RoundingMethod>> _roundingMethodForOfficer;
        public StringEnumValue<RoundingMethod> RoundingMethodForOfficer { get => _roundingMethodForOfficer; set => _roundingMethodForOfficer = value; }
        private DirtyValue<string> _triggerField;
        public string TriggerField { get => _triggerField; set => _triggerField = value; }
        private DirtyValue<StringEnumValue<WhoPaidCompensation>> _whoPaidCompensation;
        public StringEnumValue<WhoPaidCompensation> WhoPaidCompensation { get => _whoPaidCompensation; set => _whoPaidCompensation = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _adjustedPlanAdditonalAmountForBroker.Dirty
                    || _adjustedPlanAdditonalAmountForOfficer.Dirty
                    || _adjustedPlanAmountForBroker.Dirty
                    || _adjustedPlanAmountForOfficer.Dirty
                    || _adjustedPlanRateForBroker.Dirty
                    || _adjustedPlanRateForOfficer.Dirty
                    || _adjustmentDescription.Dirty
                    || _adjustmentDescriptionForOfficer.Dirty
                    || _basePlanAdditonalAmountForBroker.Dirty
                    || _basePlanAdditonalAmountForOfficer.Dirty
                    || _basePlanAmountForBroker.Dirty
                    || _basePlanAmountForOfficer.Dirty
                    || _basePlanMaximumAmountForBroker.Dirty
                    || _basePlanMaximumAmountForOfficer.Dirty
                    || _basePlanMinimumAmountForBroker.Dirty
                    || _basePlanMinimumAmountForOfficer.Dirty
                    || _basePlanRateForBroker.Dirty
                    || _basePlanRateForOfficer.Dirty
                    || _bonusCompAdditonalAmount.Dirty
                    || _bonusCompAmount.Dirty
                    || _bonusCompRate.Dirty
                    || _id.Dirty
                    || _lastAppliedDate.Dirty
                    || _lastAppliedDateTime.Dirty
                    || _loanAmountType.Dirty
                    || _loanAmountTypeForOfficer.Dirty
                    || _loanOriginatorID.Dirty
                    || _loanOriginatorIDForOfficer.Dirty
                    || _loanOriginatorName.Dirty
                    || _loanOriginatorNameForOfficer.Dirty
                    || _netAdjustedAmountForBroker.Dirty
                    || _netAdjustedAmountForOfficer.Dirty
                    || _planDate.Dirty
                    || _planName.Dirty
                    || _planNameForOfficer.Dirty
                    || _roundingMethod.Dirty
                    || _roundingMethodForOfficer.Dirty
                    || _triggerField.Dirty
                    || _whoPaidCompensation.Dirty;
            }
            set
            {
                _adjustedPlanAdditonalAmountForBroker.Dirty = value;
                _adjustedPlanAdditonalAmountForOfficer.Dirty = value;
                _adjustedPlanAmountForBroker.Dirty = value;
                _adjustedPlanAmountForOfficer.Dirty = value;
                _adjustedPlanRateForBroker.Dirty = value;
                _adjustedPlanRateForOfficer.Dirty = value;
                _adjustmentDescription.Dirty = value;
                _adjustmentDescriptionForOfficer.Dirty = value;
                _basePlanAdditonalAmountForBroker.Dirty = value;
                _basePlanAdditonalAmountForOfficer.Dirty = value;
                _basePlanAmountForBroker.Dirty = value;
                _basePlanAmountForOfficer.Dirty = value;
                _basePlanMaximumAmountForBroker.Dirty = value;
                _basePlanMaximumAmountForOfficer.Dirty = value;
                _basePlanMinimumAmountForBroker.Dirty = value;
                _basePlanMinimumAmountForOfficer.Dirty = value;
                _basePlanRateForBroker.Dirty = value;
                _basePlanRateForOfficer.Dirty = value;
                _bonusCompAdditonalAmount.Dirty = value;
                _bonusCompAmount.Dirty = value;
                _bonusCompRate.Dirty = value;
                _id.Dirty = value;
                _lastAppliedDate.Dirty = value;
                _lastAppliedDateTime.Dirty = value;
                _loanAmountType.Dirty = value;
                _loanAmountTypeForOfficer.Dirty = value;
                _loanOriginatorID.Dirty = value;
                _loanOriginatorIDForOfficer.Dirty = value;
                _loanOriginatorName.Dirty = value;
                _loanOriginatorNameForOfficer.Dirty = value;
                _netAdjustedAmountForBroker.Dirty = value;
                _netAdjustedAmountForOfficer.Dirty = value;
                _planDate.Dirty = value;
                _planName.Dirty = value;
                _planNameForOfficer.Dirty = value;
                _roundingMethod.Dirty = value;
                _roundingMethodForOfficer.Dirty = value;
                _triggerField.Dirty = value;
                _whoPaidCompensation.Dirty = value;
            }
        }
    }
}