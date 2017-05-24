using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ElliLOCompensation
    {
        public Value<decimal?> AdjustedPlanAdditonalAmountForBroker { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedPlanAdditonalAmountForBroker() => !AdjustedPlanAdditonalAmountForBroker.Clean;
        public Value<decimal?> AdjustedPlanAdditonalAmountForOfficer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedPlanAdditonalAmountForOfficer() => !AdjustedPlanAdditonalAmountForOfficer.Clean;
        public Value<decimal?> AdjustedPlanAmountForBroker { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedPlanAmountForBroker() => !AdjustedPlanAmountForBroker.Clean;
        public Value<decimal?> AdjustedPlanAmountForOfficer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedPlanAmountForOfficer() => !AdjustedPlanAmountForOfficer.Clean;
        public Value<decimal?> AdjustedPlanRateForBroker { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedPlanRateForBroker() => !AdjustedPlanRateForBroker.Clean;
        public Value<decimal?> AdjustedPlanRateForOfficer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedPlanRateForOfficer() => !AdjustedPlanRateForOfficer.Clean;
        public Value<string> AdjustmentDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentDescription() => !AdjustmentDescription.Clean;
        public Value<string> AdjustmentDescriptionForOfficer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentDescriptionForOfficer() => !AdjustmentDescriptionForOfficer.Clean;
        public Value<decimal?> BasePlanAdditonalAmountForBroker { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePlanAdditonalAmountForBroker() => !BasePlanAdditonalAmountForBroker.Clean;
        public Value<decimal?> BasePlanAdditonalAmountForOfficer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePlanAdditonalAmountForOfficer() => !BasePlanAdditonalAmountForOfficer.Clean;
        public Value<decimal?> BasePlanAmountForBroker { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePlanAmountForBroker() => !BasePlanAmountForBroker.Clean;
        public Value<decimal?> BasePlanAmountForOfficer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePlanAmountForOfficer() => !BasePlanAmountForOfficer.Clean;
        public Value<decimal?> BasePlanMaximumAmountForBroker { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePlanMaximumAmountForBroker() => !BasePlanMaximumAmountForBroker.Clean;
        public Value<decimal?> BasePlanMaximumAmountForOfficer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePlanMaximumAmountForOfficer() => !BasePlanMaximumAmountForOfficer.Clean;
        public Value<decimal?> BasePlanMinimumAmountForBroker { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePlanMinimumAmountForBroker() => !BasePlanMinimumAmountForBroker.Clean;
        public Value<decimal?> BasePlanMinimumAmountForOfficer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePlanMinimumAmountForOfficer() => !BasePlanMinimumAmountForOfficer.Clean;
        public Value<decimal?> BasePlanRateForBroker { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePlanRateForBroker() => !BasePlanRateForBroker.Clean;
        public Value<decimal?> BasePlanRateForOfficer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasePlanRateForOfficer() => !BasePlanRateForOfficer.Clean;
        public Value<decimal?> BonusCompAdditonalAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBonusCompAdditonalAmount() => !BonusCompAdditonalAmount.Clean;
        public Value<decimal?> BonusCompAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBonusCompAmount() => !BonusCompAmount.Clean;
        public Value<decimal?> BonusCompRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBonusCompRate() => !BonusCompRate.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<DateTime?> LastAppliedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastAppliedDate() => !LastAppliedDate.Clean;
        public Value<string> LastAppliedDateTime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastAppliedDateTime() => !LastAppliedDateTime.Clean;
        public Value<string> LoanAmountType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmountType() => !LoanAmountType.Clean;
        public Value<string> LoanAmountTypeForOfficer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmountTypeForOfficer() => !LoanAmountTypeForOfficer.Clean;
        public Value<string> LoanOriginatorID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanOriginatorID() => !LoanOriginatorID.Clean;
        public Value<string> LoanOriginatorIDForOfficer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanOriginatorIDForOfficer() => !LoanOriginatorIDForOfficer.Clean;
        public Value<string> LoanOriginatorName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanOriginatorName() => !LoanOriginatorName.Clean;
        public Value<string> LoanOriginatorNameForOfficer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanOriginatorNameForOfficer() => !LoanOriginatorNameForOfficer.Clean;
        public Value<decimal?> NetAdjustedAmountForBroker { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNetAdjustedAmountForBroker() => !NetAdjustedAmountForBroker.Clean;
        public Value<decimal?> NetAdjustedAmountForOfficer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNetAdjustedAmountForOfficer() => !NetAdjustedAmountForOfficer.Clean;
        public Value<DateTime?> PlanDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlanDate() => !PlanDate.Clean;
        public Value<string> PlanName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlanName() => !PlanName.Clean;
        public Value<string> PlanNameForOfficer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlanNameForOfficer() => !PlanNameForOfficer.Clean;
        public Value<string> RoundingMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRoundingMethod() => !RoundingMethod.Clean;
        public Value<string> RoundingMethodForOfficer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRoundingMethodForOfficer() => !RoundingMethodForOfficer.Clean;
        public Value<string> TriggerField { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTriggerField() => !TriggerField.Clean;
        public Value<string> WhoPaidCompensation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWhoPaidCompensation() => !WhoPaidCompensation.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AdjustedPlanAdditonalAmountForBroker.Clean
                    && AdjustedPlanAdditonalAmountForOfficer.Clean
                    && AdjustedPlanAmountForBroker.Clean
                    && AdjustedPlanAmountForOfficer.Clean
                    && AdjustedPlanRateForBroker.Clean
                    && AdjustedPlanRateForOfficer.Clean
                    && AdjustmentDescription.Clean
                    && AdjustmentDescriptionForOfficer.Clean
                    && BasePlanAdditonalAmountForBroker.Clean
                    && BasePlanAdditonalAmountForOfficer.Clean
                    && BasePlanAmountForBroker.Clean
                    && BasePlanAmountForOfficer.Clean
                    && BasePlanMaximumAmountForBroker.Clean
                    && BasePlanMaximumAmountForOfficer.Clean
                    && BasePlanMinimumAmountForBroker.Clean
                    && BasePlanMinimumAmountForOfficer.Clean
                    && BasePlanRateForBroker.Clean
                    && BasePlanRateForOfficer.Clean
                    && BonusCompAdditonalAmount.Clean
                    && BonusCompAmount.Clean
                    && BonusCompRate.Clean
                    && Id.Clean
                    && LastAppliedDate.Clean
                    && LastAppliedDateTime.Clean
                    && LoanAmountType.Clean
                    && LoanAmountTypeForOfficer.Clean
                    && LoanOriginatorID.Clean
                    && LoanOriginatorIDForOfficer.Clean
                    && LoanOriginatorName.Clean
                    && LoanOriginatorNameForOfficer.Clean
                    && NetAdjustedAmountForBroker.Clean
                    && NetAdjustedAmountForOfficer.Clean
                    && PlanDate.Clean
                    && PlanName.Clean
                    && PlanNameForOfficer.Clean
                    && RoundingMethod.Clean
                    && RoundingMethodForOfficer.Clean
                    && TriggerField.Clean
                    && WhoPaidCompensation.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AdjustedPlanAdditonalAmountForBroker; v0.Clean = value; AdjustedPlanAdditonalAmountForBroker = v0;
                var v1 = AdjustedPlanAdditonalAmountForOfficer; v1.Clean = value; AdjustedPlanAdditonalAmountForOfficer = v1;
                var v2 = AdjustedPlanAmountForBroker; v2.Clean = value; AdjustedPlanAmountForBroker = v2;
                var v3 = AdjustedPlanAmountForOfficer; v3.Clean = value; AdjustedPlanAmountForOfficer = v3;
                var v4 = AdjustedPlanRateForBroker; v4.Clean = value; AdjustedPlanRateForBroker = v4;
                var v5 = AdjustedPlanRateForOfficer; v5.Clean = value; AdjustedPlanRateForOfficer = v5;
                var v6 = AdjustmentDescription; v6.Clean = value; AdjustmentDescription = v6;
                var v7 = AdjustmentDescriptionForOfficer; v7.Clean = value; AdjustmentDescriptionForOfficer = v7;
                var v8 = BasePlanAdditonalAmountForBroker; v8.Clean = value; BasePlanAdditonalAmountForBroker = v8;
                var v9 = BasePlanAdditonalAmountForOfficer; v9.Clean = value; BasePlanAdditonalAmountForOfficer = v9;
                var v10 = BasePlanAmountForBroker; v10.Clean = value; BasePlanAmountForBroker = v10;
                var v11 = BasePlanAmountForOfficer; v11.Clean = value; BasePlanAmountForOfficer = v11;
                var v12 = BasePlanMaximumAmountForBroker; v12.Clean = value; BasePlanMaximumAmountForBroker = v12;
                var v13 = BasePlanMaximumAmountForOfficer; v13.Clean = value; BasePlanMaximumAmountForOfficer = v13;
                var v14 = BasePlanMinimumAmountForBroker; v14.Clean = value; BasePlanMinimumAmountForBroker = v14;
                var v15 = BasePlanMinimumAmountForOfficer; v15.Clean = value; BasePlanMinimumAmountForOfficer = v15;
                var v16 = BasePlanRateForBroker; v16.Clean = value; BasePlanRateForBroker = v16;
                var v17 = BasePlanRateForOfficer; v17.Clean = value; BasePlanRateForOfficer = v17;
                var v18 = BonusCompAdditonalAmount; v18.Clean = value; BonusCompAdditonalAmount = v18;
                var v19 = BonusCompAmount; v19.Clean = value; BonusCompAmount = v19;
                var v20 = BonusCompRate; v20.Clean = value; BonusCompRate = v20;
                var v21 = Id; v21.Clean = value; Id = v21;
                var v22 = LastAppliedDate; v22.Clean = value; LastAppliedDate = v22;
                var v23 = LastAppliedDateTime; v23.Clean = value; LastAppliedDateTime = v23;
                var v24 = LoanAmountType; v24.Clean = value; LoanAmountType = v24;
                var v25 = LoanAmountTypeForOfficer; v25.Clean = value; LoanAmountTypeForOfficer = v25;
                var v26 = LoanOriginatorID; v26.Clean = value; LoanOriginatorID = v26;
                var v27 = LoanOriginatorIDForOfficer; v27.Clean = value; LoanOriginatorIDForOfficer = v27;
                var v28 = LoanOriginatorName; v28.Clean = value; LoanOriginatorName = v28;
                var v29 = LoanOriginatorNameForOfficer; v29.Clean = value; LoanOriginatorNameForOfficer = v29;
                var v30 = NetAdjustedAmountForBroker; v30.Clean = value; NetAdjustedAmountForBroker = v30;
                var v31 = NetAdjustedAmountForOfficer; v31.Clean = value; NetAdjustedAmountForOfficer = v31;
                var v32 = PlanDate; v32.Clean = value; PlanDate = v32;
                var v33 = PlanName; v33.Clean = value; PlanName = v33;
                var v34 = PlanNameForOfficer; v34.Clean = value; PlanNameForOfficer = v34;
                var v35 = RoundingMethod; v35.Clean = value; RoundingMethod = v35;
                var v36 = RoundingMethodForOfficer; v36.Clean = value; RoundingMethodForOfficer = v36;
                var v37 = TriggerField; v37.Clean = value; TriggerField = v37;
                var v38 = WhoPaidCompensation; v38.Clean = value; WhoPaidCompensation = v38;
                _settingClean = 0;
            }
        }
    }
}