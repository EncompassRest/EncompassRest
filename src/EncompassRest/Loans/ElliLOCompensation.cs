using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ElliLOCompensation : IClean
    {
        private Value<decimal?> _adjustedPlanAdditonalAmountForBroker;
        public decimal? AdjustedPlanAdditonalAmountForBroker { get { return _adjustedPlanAdditonalAmountForBroker; } set { _adjustedPlanAdditonalAmountForBroker = value; } }
        private Value<decimal?> _adjustedPlanAdditonalAmountForOfficer;
        public decimal? AdjustedPlanAdditonalAmountForOfficer { get { return _adjustedPlanAdditonalAmountForOfficer; } set { _adjustedPlanAdditonalAmountForOfficer = value; } }
        private Value<decimal?> _adjustedPlanAmountForBroker;
        public decimal? AdjustedPlanAmountForBroker { get { return _adjustedPlanAmountForBroker; } set { _adjustedPlanAmountForBroker = value; } }
        private Value<decimal?> _adjustedPlanAmountForOfficer;
        public decimal? AdjustedPlanAmountForOfficer { get { return _adjustedPlanAmountForOfficer; } set { _adjustedPlanAmountForOfficer = value; } }
        private Value<decimal?> _adjustedPlanRateForBroker;
        public decimal? AdjustedPlanRateForBroker { get { return _adjustedPlanRateForBroker; } set { _adjustedPlanRateForBroker = value; } }
        private Value<decimal?> _adjustedPlanRateForOfficer;
        public decimal? AdjustedPlanRateForOfficer { get { return _adjustedPlanRateForOfficer; } set { _adjustedPlanRateForOfficer = value; } }
        private Value<string> _adjustmentDescription;
        public string AdjustmentDescription { get { return _adjustmentDescription; } set { _adjustmentDescription = value; } }
        private Value<string> _adjustmentDescriptionForOfficer;
        public string AdjustmentDescriptionForOfficer { get { return _adjustmentDescriptionForOfficer; } set { _adjustmentDescriptionForOfficer = value; } }
        private Value<decimal?> _basePlanAdditonalAmountForBroker;
        public decimal? BasePlanAdditonalAmountForBroker { get { return _basePlanAdditonalAmountForBroker; } set { _basePlanAdditonalAmountForBroker = value; } }
        private Value<decimal?> _basePlanAdditonalAmountForOfficer;
        public decimal? BasePlanAdditonalAmountForOfficer { get { return _basePlanAdditonalAmountForOfficer; } set { _basePlanAdditonalAmountForOfficer = value; } }
        private Value<decimal?> _basePlanAmountForBroker;
        public decimal? BasePlanAmountForBroker { get { return _basePlanAmountForBroker; } set { _basePlanAmountForBroker = value; } }
        private Value<decimal?> _basePlanAmountForOfficer;
        public decimal? BasePlanAmountForOfficer { get { return _basePlanAmountForOfficer; } set { _basePlanAmountForOfficer = value; } }
        private Value<decimal?> _basePlanMaximumAmountForBroker;
        public decimal? BasePlanMaximumAmountForBroker { get { return _basePlanMaximumAmountForBroker; } set { _basePlanMaximumAmountForBroker = value; } }
        private Value<decimal?> _basePlanMaximumAmountForOfficer;
        public decimal? BasePlanMaximumAmountForOfficer { get { return _basePlanMaximumAmountForOfficer; } set { _basePlanMaximumAmountForOfficer = value; } }
        private Value<decimal?> _basePlanMinimumAmountForBroker;
        public decimal? BasePlanMinimumAmountForBroker { get { return _basePlanMinimumAmountForBroker; } set { _basePlanMinimumAmountForBroker = value; } }
        private Value<decimal?> _basePlanMinimumAmountForOfficer;
        public decimal? BasePlanMinimumAmountForOfficer { get { return _basePlanMinimumAmountForOfficer; } set { _basePlanMinimumAmountForOfficer = value; } }
        private Value<decimal?> _basePlanRateForBroker;
        public decimal? BasePlanRateForBroker { get { return _basePlanRateForBroker; } set { _basePlanRateForBroker = value; } }
        private Value<decimal?> _basePlanRateForOfficer;
        public decimal? BasePlanRateForOfficer { get { return _basePlanRateForOfficer; } set { _basePlanRateForOfficer = value; } }
        private Value<decimal?> _bonusCompAdditonalAmount;
        public decimal? BonusCompAdditonalAmount { get { return _bonusCompAdditonalAmount; } set { _bonusCompAdditonalAmount = value; } }
        private Value<decimal?> _bonusCompAmount;
        public decimal? BonusCompAmount { get { return _bonusCompAmount; } set { _bonusCompAmount = value; } }
        private Value<decimal?> _bonusCompRate;
        public decimal? BonusCompRate { get { return _bonusCompRate; } set { _bonusCompRate = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<DateTime?> _lastAppliedDate;
        public DateTime? LastAppliedDate { get { return _lastAppliedDate; } set { _lastAppliedDate = value; } }
        private Value<string> _lastAppliedDateTime;
        public string LastAppliedDateTime { get { return _lastAppliedDateTime; } set { _lastAppliedDateTime = value; } }
        private Value<string> _loanAmountType;
        public string LoanAmountType { get { return _loanAmountType; } set { _loanAmountType = value; } }
        private Value<string> _loanAmountTypeForOfficer;
        public string LoanAmountTypeForOfficer { get { return _loanAmountTypeForOfficer; } set { _loanAmountTypeForOfficer = value; } }
        private Value<string> _loanOriginatorID;
        public string LoanOriginatorID { get { return _loanOriginatorID; } set { _loanOriginatorID = value; } }
        private Value<string> _loanOriginatorIDForOfficer;
        public string LoanOriginatorIDForOfficer { get { return _loanOriginatorIDForOfficer; } set { _loanOriginatorIDForOfficer = value; } }
        private Value<string> _loanOriginatorName;
        public string LoanOriginatorName { get { return _loanOriginatorName; } set { _loanOriginatorName = value; } }
        private Value<string> _loanOriginatorNameForOfficer;
        public string LoanOriginatorNameForOfficer { get { return _loanOriginatorNameForOfficer; } set { _loanOriginatorNameForOfficer = value; } }
        private Value<decimal?> _netAdjustedAmountForBroker;
        public decimal? NetAdjustedAmountForBroker { get { return _netAdjustedAmountForBroker; } set { _netAdjustedAmountForBroker = value; } }
        private Value<decimal?> _netAdjustedAmountForOfficer;
        public decimal? NetAdjustedAmountForOfficer { get { return _netAdjustedAmountForOfficer; } set { _netAdjustedAmountForOfficer = value; } }
        private Value<DateTime?> _planDate;
        public DateTime? PlanDate { get { return _planDate; } set { _planDate = value; } }
        private Value<string> _planName;
        public string PlanName { get { return _planName; } set { _planName = value; } }
        private Value<string> _planNameForOfficer;
        public string PlanNameForOfficer { get { return _planNameForOfficer; } set { _planNameForOfficer = value; } }
        private Value<string> _roundingMethod;
        public string RoundingMethod { get { return _roundingMethod; } set { _roundingMethod = value; } }
        private Value<string> _roundingMethodForOfficer;
        public string RoundingMethodForOfficer { get { return _roundingMethodForOfficer; } set { _roundingMethodForOfficer = value; } }
        private Value<string> _triggerField;
        public string TriggerField { get { return _triggerField; } set { _triggerField = value; } }
        private Value<string> _whoPaidCompensation;
        public string WhoPaidCompensation { get { return _whoPaidCompensation; } set { _whoPaidCompensation = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _adjustedPlanAdditonalAmountForBroker.Clean
                    && _adjustedPlanAdditonalAmountForOfficer.Clean
                    && _adjustedPlanAmountForBroker.Clean
                    && _adjustedPlanAmountForOfficer.Clean
                    && _adjustedPlanRateForBroker.Clean
                    && _adjustedPlanRateForOfficer.Clean
                    && _adjustmentDescription.Clean
                    && _adjustmentDescriptionForOfficer.Clean
                    && _basePlanAdditonalAmountForBroker.Clean
                    && _basePlanAdditonalAmountForOfficer.Clean
                    && _basePlanAmountForBroker.Clean
                    && _basePlanAmountForOfficer.Clean
                    && _basePlanMaximumAmountForBroker.Clean
                    && _basePlanMaximumAmountForOfficer.Clean
                    && _basePlanMinimumAmountForBroker.Clean
                    && _basePlanMinimumAmountForOfficer.Clean
                    && _basePlanRateForBroker.Clean
                    && _basePlanRateForOfficer.Clean
                    && _bonusCompAdditonalAmount.Clean
                    && _bonusCompAmount.Clean
                    && _bonusCompRate.Clean
                    && _id.Clean
                    && _lastAppliedDate.Clean
                    && _lastAppliedDateTime.Clean
                    && _loanAmountType.Clean
                    && _loanAmountTypeForOfficer.Clean
                    && _loanOriginatorID.Clean
                    && _loanOriginatorIDForOfficer.Clean
                    && _loanOriginatorName.Clean
                    && _loanOriginatorNameForOfficer.Clean
                    && _netAdjustedAmountForBroker.Clean
                    && _netAdjustedAmountForOfficer.Clean
                    && _planDate.Clean
                    && _planName.Clean
                    && _planNameForOfficer.Clean
                    && _roundingMethod.Clean
                    && _roundingMethodForOfficer.Clean
                    && _triggerField.Clean
                    && _whoPaidCompensation.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var adjustedPlanAdditonalAmountForBroker = _adjustedPlanAdditonalAmountForBroker; adjustedPlanAdditonalAmountForBroker.Clean = value; _adjustedPlanAdditonalAmountForBroker = adjustedPlanAdditonalAmountForBroker;
                var adjustedPlanAdditonalAmountForOfficer = _adjustedPlanAdditonalAmountForOfficer; adjustedPlanAdditonalAmountForOfficer.Clean = value; _adjustedPlanAdditonalAmountForOfficer = adjustedPlanAdditonalAmountForOfficer;
                var adjustedPlanAmountForBroker = _adjustedPlanAmountForBroker; adjustedPlanAmountForBroker.Clean = value; _adjustedPlanAmountForBroker = adjustedPlanAmountForBroker;
                var adjustedPlanAmountForOfficer = _adjustedPlanAmountForOfficer; adjustedPlanAmountForOfficer.Clean = value; _adjustedPlanAmountForOfficer = adjustedPlanAmountForOfficer;
                var adjustedPlanRateForBroker = _adjustedPlanRateForBroker; adjustedPlanRateForBroker.Clean = value; _adjustedPlanRateForBroker = adjustedPlanRateForBroker;
                var adjustedPlanRateForOfficer = _adjustedPlanRateForOfficer; adjustedPlanRateForOfficer.Clean = value; _adjustedPlanRateForOfficer = adjustedPlanRateForOfficer;
                var adjustmentDescription = _adjustmentDescription; adjustmentDescription.Clean = value; _adjustmentDescription = adjustmentDescription;
                var adjustmentDescriptionForOfficer = _adjustmentDescriptionForOfficer; adjustmentDescriptionForOfficer.Clean = value; _adjustmentDescriptionForOfficer = adjustmentDescriptionForOfficer;
                var basePlanAdditonalAmountForBroker = _basePlanAdditonalAmountForBroker; basePlanAdditonalAmountForBroker.Clean = value; _basePlanAdditonalAmountForBroker = basePlanAdditonalAmountForBroker;
                var basePlanAdditonalAmountForOfficer = _basePlanAdditonalAmountForOfficer; basePlanAdditonalAmountForOfficer.Clean = value; _basePlanAdditonalAmountForOfficer = basePlanAdditonalAmountForOfficer;
                var basePlanAmountForBroker = _basePlanAmountForBroker; basePlanAmountForBroker.Clean = value; _basePlanAmountForBroker = basePlanAmountForBroker;
                var basePlanAmountForOfficer = _basePlanAmountForOfficer; basePlanAmountForOfficer.Clean = value; _basePlanAmountForOfficer = basePlanAmountForOfficer;
                var basePlanMaximumAmountForBroker = _basePlanMaximumAmountForBroker; basePlanMaximumAmountForBroker.Clean = value; _basePlanMaximumAmountForBroker = basePlanMaximumAmountForBroker;
                var basePlanMaximumAmountForOfficer = _basePlanMaximumAmountForOfficer; basePlanMaximumAmountForOfficer.Clean = value; _basePlanMaximumAmountForOfficer = basePlanMaximumAmountForOfficer;
                var basePlanMinimumAmountForBroker = _basePlanMinimumAmountForBroker; basePlanMinimumAmountForBroker.Clean = value; _basePlanMinimumAmountForBroker = basePlanMinimumAmountForBroker;
                var basePlanMinimumAmountForOfficer = _basePlanMinimumAmountForOfficer; basePlanMinimumAmountForOfficer.Clean = value; _basePlanMinimumAmountForOfficer = basePlanMinimumAmountForOfficer;
                var basePlanRateForBroker = _basePlanRateForBroker; basePlanRateForBroker.Clean = value; _basePlanRateForBroker = basePlanRateForBroker;
                var basePlanRateForOfficer = _basePlanRateForOfficer; basePlanRateForOfficer.Clean = value; _basePlanRateForOfficer = basePlanRateForOfficer;
                var bonusCompAdditonalAmount = _bonusCompAdditonalAmount; bonusCompAdditonalAmount.Clean = value; _bonusCompAdditonalAmount = bonusCompAdditonalAmount;
                var bonusCompAmount = _bonusCompAmount; bonusCompAmount.Clean = value; _bonusCompAmount = bonusCompAmount;
                var bonusCompRate = _bonusCompRate; bonusCompRate.Clean = value; _bonusCompRate = bonusCompRate;
                var id = _id; id.Clean = value; _id = id;
                var lastAppliedDate = _lastAppliedDate; lastAppliedDate.Clean = value; _lastAppliedDate = lastAppliedDate;
                var lastAppliedDateTime = _lastAppliedDateTime; lastAppliedDateTime.Clean = value; _lastAppliedDateTime = lastAppliedDateTime;
                var loanAmountType = _loanAmountType; loanAmountType.Clean = value; _loanAmountType = loanAmountType;
                var loanAmountTypeForOfficer = _loanAmountTypeForOfficer; loanAmountTypeForOfficer.Clean = value; _loanAmountTypeForOfficer = loanAmountTypeForOfficer;
                var loanOriginatorID = _loanOriginatorID; loanOriginatorID.Clean = value; _loanOriginatorID = loanOriginatorID;
                var loanOriginatorIDForOfficer = _loanOriginatorIDForOfficer; loanOriginatorIDForOfficer.Clean = value; _loanOriginatorIDForOfficer = loanOriginatorIDForOfficer;
                var loanOriginatorName = _loanOriginatorName; loanOriginatorName.Clean = value; _loanOriginatorName = loanOriginatorName;
                var loanOriginatorNameForOfficer = _loanOriginatorNameForOfficer; loanOriginatorNameForOfficer.Clean = value; _loanOriginatorNameForOfficer = loanOriginatorNameForOfficer;
                var netAdjustedAmountForBroker = _netAdjustedAmountForBroker; netAdjustedAmountForBroker.Clean = value; _netAdjustedAmountForBroker = netAdjustedAmountForBroker;
                var netAdjustedAmountForOfficer = _netAdjustedAmountForOfficer; netAdjustedAmountForOfficer.Clean = value; _netAdjustedAmountForOfficer = netAdjustedAmountForOfficer;
                var planDate = _planDate; planDate.Clean = value; _planDate = planDate;
                var planName = _planName; planName.Clean = value; _planName = planName;
                var planNameForOfficer = _planNameForOfficer; planNameForOfficer.Clean = value; _planNameForOfficer = planNameForOfficer;
                var roundingMethod = _roundingMethod; roundingMethod.Clean = value; _roundingMethod = roundingMethod;
                var roundingMethodForOfficer = _roundingMethodForOfficer; roundingMethodForOfficer.Clean = value; _roundingMethodForOfficer = roundingMethodForOfficer;
                var triggerField = _triggerField; triggerField.Clean = value; _triggerField = triggerField;
                var whoPaidCompensation = _whoPaidCompensation; whoPaidCompensation.Clean = value; _whoPaidCompensation = whoPaidCompensation;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public ElliLOCompensation()
        {
            Clean = true;
        }
    }
}