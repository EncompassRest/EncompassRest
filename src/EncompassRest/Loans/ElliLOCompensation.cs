using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ElliLOCompensation
    {
        private Value<decimal?> _adjustedPlanAdditonalAmountForBroker;
        public decimal? AdjustedPlanAdditonalAmountForBroker { get { return _adjustedPlanAdditonalAmountForBroker; } set { _adjustedPlanAdditonalAmountForBroker = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedPlanAdditonalAmountForBroker() => !_adjustedPlanAdditonalAmountForBroker.Clean;
        private Value<decimal?> _adjustedPlanAdditonalAmountForOfficer;
        public decimal? AdjustedPlanAdditonalAmountForOfficer { get { return _adjustedPlanAdditonalAmountForOfficer; } set { _adjustedPlanAdditonalAmountForOfficer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedPlanAdditonalAmountForOfficer() => !_adjustedPlanAdditonalAmountForOfficer.Clean;
        private Value<decimal?> _adjustedPlanAmountForBroker;
        public decimal? AdjustedPlanAmountForBroker { get { return _adjustedPlanAmountForBroker; } set { _adjustedPlanAmountForBroker = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedPlanAmountForBroker() => !_adjustedPlanAmountForBroker.Clean;
        private Value<decimal?> _adjustedPlanAmountForOfficer;
        public decimal? AdjustedPlanAmountForOfficer { get { return _adjustedPlanAmountForOfficer; } set { _adjustedPlanAmountForOfficer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedPlanAmountForOfficer() => !_adjustedPlanAmountForOfficer.Clean;
        private Value<decimal?> _adjustedPlanRateForBroker;
        public decimal? AdjustedPlanRateForBroker { get { return _adjustedPlanRateForBroker; } set { _adjustedPlanRateForBroker = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedPlanRateForBroker() => !_adjustedPlanRateForBroker.Clean;
        private Value<decimal?> _adjustedPlanRateForOfficer;
        public decimal? AdjustedPlanRateForOfficer { get { return _adjustedPlanRateForOfficer; } set { _adjustedPlanRateForOfficer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedPlanRateForOfficer() => !_adjustedPlanRateForOfficer.Clean;
        private Value<string> _adjustmentDescription;
        public string AdjustmentDescription { get { return _adjustmentDescription; } set { _adjustmentDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentDescription() => !_adjustmentDescription.Clean;
        private Value<string> _adjustmentDescriptionForOfficer;
        public string AdjustmentDescriptionForOfficer { get { return _adjustmentDescriptionForOfficer; } set { _adjustmentDescriptionForOfficer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentDescriptionForOfficer() => !_adjustmentDescriptionForOfficer.Clean;
        private Value<decimal?> _basePlanAdditonalAmountForBroker;
        public decimal? BasePlanAdditonalAmountForBroker { get { return _basePlanAdditonalAmountForBroker; } set { _basePlanAdditonalAmountForBroker = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePlanAdditonalAmountForBroker() => !_basePlanAdditonalAmountForBroker.Clean;
        private Value<decimal?> _basePlanAdditonalAmountForOfficer;
        public decimal? BasePlanAdditonalAmountForOfficer { get { return _basePlanAdditonalAmountForOfficer; } set { _basePlanAdditonalAmountForOfficer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePlanAdditonalAmountForOfficer() => !_basePlanAdditonalAmountForOfficer.Clean;
        private Value<decimal?> _basePlanAmountForBroker;
        public decimal? BasePlanAmountForBroker { get { return _basePlanAmountForBroker; } set { _basePlanAmountForBroker = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePlanAmountForBroker() => !_basePlanAmountForBroker.Clean;
        private Value<decimal?> _basePlanAmountForOfficer;
        public decimal? BasePlanAmountForOfficer { get { return _basePlanAmountForOfficer; } set { _basePlanAmountForOfficer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePlanAmountForOfficer() => !_basePlanAmountForOfficer.Clean;
        private Value<decimal?> _basePlanMaximumAmountForBroker;
        public decimal? BasePlanMaximumAmountForBroker { get { return _basePlanMaximumAmountForBroker; } set { _basePlanMaximumAmountForBroker = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePlanMaximumAmountForBroker() => !_basePlanMaximumAmountForBroker.Clean;
        private Value<decimal?> _basePlanMaximumAmountForOfficer;
        public decimal? BasePlanMaximumAmountForOfficer { get { return _basePlanMaximumAmountForOfficer; } set { _basePlanMaximumAmountForOfficer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePlanMaximumAmountForOfficer() => !_basePlanMaximumAmountForOfficer.Clean;
        private Value<decimal?> _basePlanMinimumAmountForBroker;
        public decimal? BasePlanMinimumAmountForBroker { get { return _basePlanMinimumAmountForBroker; } set { _basePlanMinimumAmountForBroker = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePlanMinimumAmountForBroker() => !_basePlanMinimumAmountForBroker.Clean;
        private Value<decimal?> _basePlanMinimumAmountForOfficer;
        public decimal? BasePlanMinimumAmountForOfficer { get { return _basePlanMinimumAmountForOfficer; } set { _basePlanMinimumAmountForOfficer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePlanMinimumAmountForOfficer() => !_basePlanMinimumAmountForOfficer.Clean;
        private Value<decimal?> _basePlanRateForBroker;
        public decimal? BasePlanRateForBroker { get { return _basePlanRateForBroker; } set { _basePlanRateForBroker = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePlanRateForBroker() => !_basePlanRateForBroker.Clean;
        private Value<decimal?> _basePlanRateForOfficer;
        public decimal? BasePlanRateForOfficer { get { return _basePlanRateForOfficer; } set { _basePlanRateForOfficer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePlanRateForOfficer() => !_basePlanRateForOfficer.Clean;
        private Value<decimal?> _bonusCompAdditonalAmount;
        public decimal? BonusCompAdditonalAmount { get { return _bonusCompAdditonalAmount; } set { _bonusCompAdditonalAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBonusCompAdditonalAmount() => !_bonusCompAdditonalAmount.Clean;
        private Value<decimal?> _bonusCompAmount;
        public decimal? BonusCompAmount { get { return _bonusCompAmount; } set { _bonusCompAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBonusCompAmount() => !_bonusCompAmount.Clean;
        private Value<decimal?> _bonusCompRate;
        public decimal? BonusCompRate { get { return _bonusCompRate; } set { _bonusCompRate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBonusCompRate() => !_bonusCompRate.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<DateTime?> _lastAppliedDate;
        public DateTime? LastAppliedDate { get { return _lastAppliedDate; } set { _lastAppliedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastAppliedDate() => !_lastAppliedDate.Clean;
        private Value<string> _lastAppliedDateTime;
        public string LastAppliedDateTime { get { return _lastAppliedDateTime; } set { _lastAppliedDateTime = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastAppliedDateTime() => !_lastAppliedDateTime.Clean;
        private Value<string> _loanAmountType;
        public string LoanAmountType { get { return _loanAmountType; } set { _loanAmountType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmountType() => !_loanAmountType.Clean;
        private Value<string> _loanAmountTypeForOfficer;
        public string LoanAmountTypeForOfficer { get { return _loanAmountTypeForOfficer; } set { _loanAmountTypeForOfficer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmountTypeForOfficer() => !_loanAmountTypeForOfficer.Clean;
        private Value<string> _loanOriginatorID;
        public string LoanOriginatorID { get { return _loanOriginatorID; } set { _loanOriginatorID = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanOriginatorID() => !_loanOriginatorID.Clean;
        private Value<string> _loanOriginatorIDForOfficer;
        public string LoanOriginatorIDForOfficer { get { return _loanOriginatorIDForOfficer; } set { _loanOriginatorIDForOfficer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanOriginatorIDForOfficer() => !_loanOriginatorIDForOfficer.Clean;
        private Value<string> _loanOriginatorName;
        public string LoanOriginatorName { get { return _loanOriginatorName; } set { _loanOriginatorName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanOriginatorName() => !_loanOriginatorName.Clean;
        private Value<string> _loanOriginatorNameForOfficer;
        public string LoanOriginatorNameForOfficer { get { return _loanOriginatorNameForOfficer; } set { _loanOriginatorNameForOfficer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanOriginatorNameForOfficer() => !_loanOriginatorNameForOfficer.Clean;
        private Value<decimal?> _netAdjustedAmountForBroker;
        public decimal? NetAdjustedAmountForBroker { get { return _netAdjustedAmountForBroker; } set { _netAdjustedAmountForBroker = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNetAdjustedAmountForBroker() => !_netAdjustedAmountForBroker.Clean;
        private Value<decimal?> _netAdjustedAmountForOfficer;
        public decimal? NetAdjustedAmountForOfficer { get { return _netAdjustedAmountForOfficer; } set { _netAdjustedAmountForOfficer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNetAdjustedAmountForOfficer() => !_netAdjustedAmountForOfficer.Clean;
        private Value<DateTime?> _planDate;
        public DateTime? PlanDate { get { return _planDate; } set { _planDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlanDate() => !_planDate.Clean;
        private Value<string> _planName;
        public string PlanName { get { return _planName; } set { _planName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlanName() => !_planName.Clean;
        private Value<string> _planNameForOfficer;
        public string PlanNameForOfficer { get { return _planNameForOfficer; } set { _planNameForOfficer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlanNameForOfficer() => !_planNameForOfficer.Clean;
        private Value<string> _roundingMethod;
        public string RoundingMethod { get { return _roundingMethod; } set { _roundingMethod = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRoundingMethod() => !_roundingMethod.Clean;
        private Value<string> _roundingMethodForOfficer;
        public string RoundingMethodForOfficer { get { return _roundingMethodForOfficer; } set { _roundingMethodForOfficer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRoundingMethodForOfficer() => !_roundingMethodForOfficer.Clean;
        private Value<string> _triggerField;
        public string TriggerField { get { return _triggerField; } set { _triggerField = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTriggerField() => !_triggerField.Clean;
        private Value<string> _whoPaidCompensation;
        public string WhoPaidCompensation { get { return _whoPaidCompensation; } set { _whoPaidCompensation = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWhoPaidCompensation() => !_whoPaidCompensation.Clean;
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
                var v0 = _adjustedPlanAdditonalAmountForBroker; v0.Clean = value; _adjustedPlanAdditonalAmountForBroker = v0;
                var v1 = _adjustedPlanAdditonalAmountForOfficer; v1.Clean = value; _adjustedPlanAdditonalAmountForOfficer = v1;
                var v2 = _adjustedPlanAmountForBroker; v2.Clean = value; _adjustedPlanAmountForBroker = v2;
                var v3 = _adjustedPlanAmountForOfficer; v3.Clean = value; _adjustedPlanAmountForOfficer = v3;
                var v4 = _adjustedPlanRateForBroker; v4.Clean = value; _adjustedPlanRateForBroker = v4;
                var v5 = _adjustedPlanRateForOfficer; v5.Clean = value; _adjustedPlanRateForOfficer = v5;
                var v6 = _adjustmentDescription; v6.Clean = value; _adjustmentDescription = v6;
                var v7 = _adjustmentDescriptionForOfficer; v7.Clean = value; _adjustmentDescriptionForOfficer = v7;
                var v8 = _basePlanAdditonalAmountForBroker; v8.Clean = value; _basePlanAdditonalAmountForBroker = v8;
                var v9 = _basePlanAdditonalAmountForOfficer; v9.Clean = value; _basePlanAdditonalAmountForOfficer = v9;
                var v10 = _basePlanAmountForBroker; v10.Clean = value; _basePlanAmountForBroker = v10;
                var v11 = _basePlanAmountForOfficer; v11.Clean = value; _basePlanAmountForOfficer = v11;
                var v12 = _basePlanMaximumAmountForBroker; v12.Clean = value; _basePlanMaximumAmountForBroker = v12;
                var v13 = _basePlanMaximumAmountForOfficer; v13.Clean = value; _basePlanMaximumAmountForOfficer = v13;
                var v14 = _basePlanMinimumAmountForBroker; v14.Clean = value; _basePlanMinimumAmountForBroker = v14;
                var v15 = _basePlanMinimumAmountForOfficer; v15.Clean = value; _basePlanMinimumAmountForOfficer = v15;
                var v16 = _basePlanRateForBroker; v16.Clean = value; _basePlanRateForBroker = v16;
                var v17 = _basePlanRateForOfficer; v17.Clean = value; _basePlanRateForOfficer = v17;
                var v18 = _bonusCompAdditonalAmount; v18.Clean = value; _bonusCompAdditonalAmount = v18;
                var v19 = _bonusCompAmount; v19.Clean = value; _bonusCompAmount = v19;
                var v20 = _bonusCompRate; v20.Clean = value; _bonusCompRate = v20;
                var v21 = _id; v21.Clean = value; _id = v21;
                var v22 = _lastAppliedDate; v22.Clean = value; _lastAppliedDate = v22;
                var v23 = _lastAppliedDateTime; v23.Clean = value; _lastAppliedDateTime = v23;
                var v24 = _loanAmountType; v24.Clean = value; _loanAmountType = v24;
                var v25 = _loanAmountTypeForOfficer; v25.Clean = value; _loanAmountTypeForOfficer = v25;
                var v26 = _loanOriginatorID; v26.Clean = value; _loanOriginatorID = v26;
                var v27 = _loanOriginatorIDForOfficer; v27.Clean = value; _loanOriginatorIDForOfficer = v27;
                var v28 = _loanOriginatorName; v28.Clean = value; _loanOriginatorName = v28;
                var v29 = _loanOriginatorNameForOfficer; v29.Clean = value; _loanOriginatorNameForOfficer = v29;
                var v30 = _netAdjustedAmountForBroker; v30.Clean = value; _netAdjustedAmountForBroker = v30;
                var v31 = _netAdjustedAmountForOfficer; v31.Clean = value; _netAdjustedAmountForOfficer = v31;
                var v32 = _planDate; v32.Clean = value; _planDate = v32;
                var v33 = _planName; v33.Clean = value; _planName = v33;
                var v34 = _planNameForOfficer; v34.Clean = value; _planNameForOfficer = v34;
                var v35 = _roundingMethod; v35.Clean = value; _roundingMethod = v35;
                var v36 = _roundingMethodForOfficer; v36.Clean = value; _roundingMethodForOfficer = v36;
                var v37 = _triggerField; v37.Clean = value; _triggerField = v37;
                var v38 = _whoPaidCompensation; v38.Clean = value; _whoPaidCompensation = v38;
                _settingClean = 0;
            }
        }
    }
}