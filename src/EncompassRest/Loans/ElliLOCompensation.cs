using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ElliLOCompensation : IDirty
    {
        private DirtyValue<decimal?> _adjustedPlanAdditonalAmountForBroker;
        public decimal? AdjustedPlanAdditonalAmountForBroker { get { return _adjustedPlanAdditonalAmountForBroker; } set { _adjustedPlanAdditonalAmountForBroker = value; } }
        private DirtyValue<decimal?> _adjustedPlanAdditonalAmountForOfficer;
        public decimal? AdjustedPlanAdditonalAmountForOfficer { get { return _adjustedPlanAdditonalAmountForOfficer; } set { _adjustedPlanAdditonalAmountForOfficer = value; } }
        private DirtyValue<decimal?> _adjustedPlanAmountForBroker;
        public decimal? AdjustedPlanAmountForBroker { get { return _adjustedPlanAmountForBroker; } set { _adjustedPlanAmountForBroker = value; } }
        private DirtyValue<decimal?> _adjustedPlanAmountForOfficer;
        public decimal? AdjustedPlanAmountForOfficer { get { return _adjustedPlanAmountForOfficer; } set { _adjustedPlanAmountForOfficer = value; } }
        private DirtyValue<decimal?> _adjustedPlanRateForBroker;
        public decimal? AdjustedPlanRateForBroker { get { return _adjustedPlanRateForBroker; } set { _adjustedPlanRateForBroker = value; } }
        private DirtyValue<decimal?> _adjustedPlanRateForOfficer;
        public decimal? AdjustedPlanRateForOfficer { get { return _adjustedPlanRateForOfficer; } set { _adjustedPlanRateForOfficer = value; } }
        private DirtyValue<string> _adjustmentDescription;
        public string AdjustmentDescription { get { return _adjustmentDescription; } set { _adjustmentDescription = value; } }
        private DirtyValue<string> _adjustmentDescriptionForOfficer;
        public string AdjustmentDescriptionForOfficer { get { return _adjustmentDescriptionForOfficer; } set { _adjustmentDescriptionForOfficer = value; } }
        private DirtyValue<decimal?> _basePlanAdditonalAmountForBroker;
        public decimal? BasePlanAdditonalAmountForBroker { get { return _basePlanAdditonalAmountForBroker; } set { _basePlanAdditonalAmountForBroker = value; } }
        private DirtyValue<decimal?> _basePlanAdditonalAmountForOfficer;
        public decimal? BasePlanAdditonalAmountForOfficer { get { return _basePlanAdditonalAmountForOfficer; } set { _basePlanAdditonalAmountForOfficer = value; } }
        private DirtyValue<decimal?> _basePlanAmountForBroker;
        public decimal? BasePlanAmountForBroker { get { return _basePlanAmountForBroker; } set { _basePlanAmountForBroker = value; } }
        private DirtyValue<decimal?> _basePlanAmountForOfficer;
        public decimal? BasePlanAmountForOfficer { get { return _basePlanAmountForOfficer; } set { _basePlanAmountForOfficer = value; } }
        private DirtyValue<decimal?> _basePlanMaximumAmountForBroker;
        public decimal? BasePlanMaximumAmountForBroker { get { return _basePlanMaximumAmountForBroker; } set { _basePlanMaximumAmountForBroker = value; } }
        private DirtyValue<decimal?> _basePlanMaximumAmountForOfficer;
        public decimal? BasePlanMaximumAmountForOfficer { get { return _basePlanMaximumAmountForOfficer; } set { _basePlanMaximumAmountForOfficer = value; } }
        private DirtyValue<decimal?> _basePlanMinimumAmountForBroker;
        public decimal? BasePlanMinimumAmountForBroker { get { return _basePlanMinimumAmountForBroker; } set { _basePlanMinimumAmountForBroker = value; } }
        private DirtyValue<decimal?> _basePlanMinimumAmountForOfficer;
        public decimal? BasePlanMinimumAmountForOfficer { get { return _basePlanMinimumAmountForOfficer; } set { _basePlanMinimumAmountForOfficer = value; } }
        private DirtyValue<decimal?> _basePlanRateForBroker;
        public decimal? BasePlanRateForBroker { get { return _basePlanRateForBroker; } set { _basePlanRateForBroker = value; } }
        private DirtyValue<decimal?> _basePlanRateForOfficer;
        public decimal? BasePlanRateForOfficer { get { return _basePlanRateForOfficer; } set { _basePlanRateForOfficer = value; } }
        private DirtyValue<decimal?> _bonusCompAdditonalAmount;
        public decimal? BonusCompAdditonalAmount { get { return _bonusCompAdditonalAmount; } set { _bonusCompAdditonalAmount = value; } }
        private DirtyValue<decimal?> _bonusCompAmount;
        public decimal? BonusCompAmount { get { return _bonusCompAmount; } set { _bonusCompAmount = value; } }
        private DirtyValue<decimal?> _bonusCompRate;
        public decimal? BonusCompRate { get { return _bonusCompRate; } set { _bonusCompRate = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<DateTime?> _lastAppliedDate;
        public DateTime? LastAppliedDate { get { return _lastAppliedDate; } set { _lastAppliedDate = value; } }
        private DirtyValue<string> _lastAppliedDateTime;
        public string LastAppliedDateTime { get { return _lastAppliedDateTime; } set { _lastAppliedDateTime = value; } }
        private DirtyValue<string> _loanAmountType;
        public string LoanAmountType { get { return _loanAmountType; } set { _loanAmountType = value; } }
        private DirtyValue<string> _loanAmountTypeForOfficer;
        public string LoanAmountTypeForOfficer { get { return _loanAmountTypeForOfficer; } set { _loanAmountTypeForOfficer = value; } }
        private DirtyValue<string> _loanOriginatorID;
        public string LoanOriginatorID { get { return _loanOriginatorID; } set { _loanOriginatorID = value; } }
        private DirtyValue<string> _loanOriginatorIDForOfficer;
        public string LoanOriginatorIDForOfficer { get { return _loanOriginatorIDForOfficer; } set { _loanOriginatorIDForOfficer = value; } }
        private DirtyValue<string> _loanOriginatorName;
        public string LoanOriginatorName { get { return _loanOriginatorName; } set { _loanOriginatorName = value; } }
        private DirtyValue<string> _loanOriginatorNameForOfficer;
        public string LoanOriginatorNameForOfficer { get { return _loanOriginatorNameForOfficer; } set { _loanOriginatorNameForOfficer = value; } }
        private DirtyValue<decimal?> _netAdjustedAmountForBroker;
        public decimal? NetAdjustedAmountForBroker { get { return _netAdjustedAmountForBroker; } set { _netAdjustedAmountForBroker = value; } }
        private DirtyValue<decimal?> _netAdjustedAmountForOfficer;
        public decimal? NetAdjustedAmountForOfficer { get { return _netAdjustedAmountForOfficer; } set { _netAdjustedAmountForOfficer = value; } }
        private DirtyValue<DateTime?> _planDate;
        public DateTime? PlanDate { get { return _planDate; } set { _planDate = value; } }
        private DirtyValue<string> _planName;
        public string PlanName { get { return _planName; } set { _planName = value; } }
        private DirtyValue<string> _planNameForOfficer;
        public string PlanNameForOfficer { get { return _planNameForOfficer; } set { _planNameForOfficer = value; } }
        private DirtyValue<string> _roundingMethod;
        public string RoundingMethod { get { return _roundingMethod; } set { _roundingMethod = value; } }
        private DirtyValue<string> _roundingMethodForOfficer;
        public string RoundingMethodForOfficer { get { return _roundingMethodForOfficer; } set { _roundingMethodForOfficer = value; } }
        private DirtyValue<string> _triggerField;
        public string TriggerField { get { return _triggerField; } set { _triggerField = value; } }
        private DirtyValue<string> _whoPaidCompensation;
        public string WhoPaidCompensation { get { return _whoPaidCompensation; } set { _whoPaidCompensation = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _adjustedPlanAdditonalAmountForBroker.Dirty
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
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}