using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class FeeVarianceOther : IClean
    {
        private Value<decimal?> _appliedCureAmount;
        public decimal? AppliedCureAmount { get { return _appliedCureAmount; } set { _appliedCureAmount = value; } }
        private Value<string> _cannotDecreaseCDBaselineGuid;
        public string CannotDecreaseCDBaselineGuid { get { return _cannotDecreaseCDBaselineGuid; } set { _cannotDecreaseCDBaselineGuid = value; } }
        private Value<string> _cannotDecreaseLEBaselineGuid;
        public string CannotDecreaseLEBaselineGuid { get { return _cannotDecreaseLEBaselineGuid; } set { _cannotDecreaseLEBaselineGuid = value; } }
        private Value<string> _cannotIncrease10CDBaselineGuid;
        public string CannotIncrease10CDBaselineGuid { get { return _cannotIncrease10CDBaselineGuid; } set { _cannotIncrease10CDBaselineGuid = value; } }
        private Value<string> _cannotIncrease10LEBaselineGuid;
        public string CannotIncrease10LEBaselineGuid { get { return _cannotIncrease10LEBaselineGuid; } set { _cannotIncrease10LEBaselineGuid = value; } }
        private Value<string> _cannotIncreaseCDBaselineGuid;
        public string CannotIncreaseCDBaselineGuid { get { return _cannotIncreaseCDBaselineGuid; } set { _cannotIncreaseCDBaselineGuid = value; } }
        private Value<string> _cannotIncreaseLEBaselineGuid;
        public string CannotIncreaseLEBaselineGuid { get { return _cannotIncreaseLEBaselineGuid; } set { _cannotIncreaseLEBaselineGuid = value; } }
        private Value<string> _cDInitialGuid;
        public string CDInitialGuid { get { return _cDInitialGuid; } set { _cDInitialGuid = value; } }
        private Value<string> _cDInitialReceivedDateGuid;
        public string CDInitialReceivedDateGuid { get { return _cDInitialReceivedDateGuid; } set { _cDInitialReceivedDateGuid = value; } }
        private Value<string> _cDLatestGuid;
        public string CDLatestGuid { get { return _cDLatestGuid; } set { _cDLatestGuid = value; } }
        private Value<string> _cDPostConGuid;
        public string CDPostConGuid { get { return _cDPostConGuid; } set { _cDPostConGuid = value; } }
        private Value<string> _cDRecentAppliedCure;
        public string CDRecentAppliedCure { get { return _cDRecentAppliedCure; } set { _cDRecentAppliedCure = value; } }
        private Value<string> _cDRevisedReceivedDateGuid;
        public string CDRevisedReceivedDateGuid { get { return _cDRevisedReceivedDateGuid; } set { _cDRevisedReceivedDateGuid = value; } }
        private Value<DateTime?> _chargesCannotIncrease10CD1;
        public DateTime? ChargesCannotIncrease10CD1 { get { return _chargesCannotIncrease10CD1; } set { _chargesCannotIncrease10CD1 = value; } }
        private Value<DateTime?> _chargesCannotIncrease10InitialLE1;
        public DateTime? ChargesCannotIncrease10InitialLE1 { get { return _chargesCannotIncrease10InitialLE1; } set { _chargesCannotIncrease10InitialLE1 = value; } }
        private Value<DateTime?> _chargesCannotIncrease10LE1;
        public DateTime? ChargesCannotIncrease10LE1 { get { return _chargesCannotIncrease10LE1; } set { _chargesCannotIncrease10LE1 = value; } }
        private Value<DateTime?> _chargesThatCanChangeCD1;
        public DateTime? ChargesThatCanChangeCD1 { get { return _chargesThatCanChangeCD1; } set { _chargesThatCanChangeCD1 = value; } }
        private Value<DateTime?> _chargesThatCanChangeInitialLE1;
        public DateTime? ChargesThatCanChangeInitialLE1 { get { return _chargesThatCanChangeInitialLE1; } set { _chargesThatCanChangeInitialLE1 = value; } }
        private Value<DateTime?> _chargesThatCanChangeLE1;
        public DateTime? ChargesThatCanChangeLE1 { get { return _chargesThatCanChangeLE1; } set { _chargesThatCanChangeLE1 = value; } }
        private Value<DateTime?> _chargesThatCannotDecreaseCD1;
        public DateTime? ChargesThatCannotDecreaseCD1 { get { return _chargesThatCannotDecreaseCD1; } set { _chargesThatCannotDecreaseCD1 = value; } }
        private Value<DateTime?> _chargesThatCannotDecreaseInitialLE1;
        public DateTime? ChargesThatCannotDecreaseInitialLE1 { get { return _chargesThatCannotDecreaseInitialLE1; } set { _chargesThatCannotDecreaseInitialLE1 = value; } }
        private Value<DateTime?> _chargesThatCannotDecreaseLE1;
        public DateTime? ChargesThatCannotDecreaseLE1 { get { return _chargesThatCannotDecreaseLE1; } set { _chargesThatCannotDecreaseLE1 = value; } }
        private Value<DateTime?> _chargesThatCannotIncreaseCD1;
        public DateTime? ChargesThatCannotIncreaseCD1 { get { return _chargesThatCannotIncreaseCD1; } set { _chargesThatCannotIncreaseCD1 = value; } }
        private Value<DateTime?> _chargesThatCannotIncreaseInitialLE1;
        public DateTime? ChargesThatCannotIncreaseInitialLE1 { get { return _chargesThatCannotIncreaseInitialLE1; } set { _chargesThatCannotIncreaseInitialLE1 = value; } }
        private Value<DateTime?> _chargesThatCannotIncreaseLE1;
        public DateTime? ChargesThatCannotIncreaseLE1 { get { return _chargesThatCannotIncreaseLE1; } set { _chargesThatCannotIncreaseLE1 = value; } }
        private Value<string> _disclosureLogGUIDForECD;
        public string DisclosureLogGUIDForECD { get { return _disclosureLogGUIDForECD; } set { _disclosureLogGUIDForECD = value; } }
        private Value<string> _disclosureLogGUIDReceivedForECD;
        public string DisclosureLogGUIDReceivedForECD { get { return _disclosureLogGUIDReceivedForECD; } set { _disclosureLogGUIDReceivedForECD = value; } }
        private Value<DateTime?> _goodFaithAmountInitialLE1;
        public DateTime? GoodFaithAmountInitialLE1 { get { return _goodFaithAmountInitialLE1; } set { _goodFaithAmountInitialLE1 = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _lEBaselineUsedCannotDecrease;
        public bool? LEBaselineUsedCannotDecrease { get { return _lEBaselineUsedCannotDecrease; } set { _lEBaselineUsedCannotDecrease = value; } }
        private Value<bool?> _lEBaselineUsedCannotIncrease;
        public bool? LEBaselineUsedCannotIncrease { get { return _lEBaselineUsedCannotIncrease; } set { _lEBaselineUsedCannotIncrease = value; } }
        private Value<bool?> _lEBaselineUsedCannotIncrease10;
        public bool? LEBaselineUsedCannotIncrease10 { get { return _lEBaselineUsedCannotIncrease10; } set { _lEBaselineUsedCannotIncrease10 = value; } }
        private Value<string> _lEInitialDTGuid;
        public string LEInitialDTGuid { get { return _lEInitialDTGuid; } set { _lEInitialDTGuid = value; } }
        private Value<string> _lEInitialGuid;
        public string LEInitialGuid { get { return _lEInitialGuid; } set { _lEInitialGuid = value; } }
        private Value<string> _lEInitialReceivedDateGuid;
        public string LEInitialReceivedDateGuid { get { return _lEInitialReceivedDateGuid; } set { _lEInitialReceivedDateGuid = value; } }
        private Value<string> _lELatestGuid;
        public string LELatestGuid { get { return _lELatestGuid; } set { _lELatestGuid = value; } }
        private Value<string> _lERevisedReceivedDateGuid;
        public string LERevisedReceivedDateGuid { get { return _lERevisedReceivedDateGuid; } set { _lERevisedReceivedDateGuid = value; } }
        private Value<string> _lERevisedSentDateGuid;
        public string LERevisedSentDateGuid { get { return _lERevisedSentDateGuid; } set { _lERevisedSentDateGuid = value; } }
        private Value<decimal?> _requiredCureAmount;
        public decimal? RequiredCureAmount { get { return _requiredCureAmount; } set { _requiredCureAmount = value; } }
        private Value<string> _safeHarborGuid;
        public string SafeHarborGuid { get { return _safeHarborGuid; } set { _safeHarborGuid = value; } }
        private Value<string> _sSPLGuid;
        public string SSPLGuid { get { return _sSPLGuid; } set { _sSPLGuid = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _appliedCureAmount.Clean
                    && _cannotDecreaseCDBaselineGuid.Clean
                    && _cannotDecreaseLEBaselineGuid.Clean
                    && _cannotIncrease10CDBaselineGuid.Clean
                    && _cannotIncrease10LEBaselineGuid.Clean
                    && _cannotIncreaseCDBaselineGuid.Clean
                    && _cannotIncreaseLEBaselineGuid.Clean
                    && _cDInitialGuid.Clean
                    && _cDInitialReceivedDateGuid.Clean
                    && _cDLatestGuid.Clean
                    && _cDPostConGuid.Clean
                    && _cDRecentAppliedCure.Clean
                    && _cDRevisedReceivedDateGuid.Clean
                    && _chargesCannotIncrease10CD1.Clean
                    && _chargesCannotIncrease10InitialLE1.Clean
                    && _chargesCannotIncrease10LE1.Clean
                    && _chargesThatCanChangeCD1.Clean
                    && _chargesThatCanChangeInitialLE1.Clean
                    && _chargesThatCanChangeLE1.Clean
                    && _chargesThatCannotDecreaseCD1.Clean
                    && _chargesThatCannotDecreaseInitialLE1.Clean
                    && _chargesThatCannotDecreaseLE1.Clean
                    && _chargesThatCannotIncreaseCD1.Clean
                    && _chargesThatCannotIncreaseInitialLE1.Clean
                    && _chargesThatCannotIncreaseLE1.Clean
                    && _disclosureLogGUIDForECD.Clean
                    && _disclosureLogGUIDReceivedForECD.Clean
                    && _goodFaithAmountInitialLE1.Clean
                    && _id.Clean
                    && _lEBaselineUsedCannotDecrease.Clean
                    && _lEBaselineUsedCannotIncrease.Clean
                    && _lEBaselineUsedCannotIncrease10.Clean
                    && _lEInitialDTGuid.Clean
                    && _lEInitialGuid.Clean
                    && _lEInitialReceivedDateGuid.Clean
                    && _lELatestGuid.Clean
                    && _lERevisedReceivedDateGuid.Clean
                    && _lERevisedSentDateGuid.Clean
                    && _requiredCureAmount.Clean
                    && _safeHarborGuid.Clean
                    && _sSPLGuid.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _appliedCureAmount; v0.Clean = value; _appliedCureAmount = v0;
                var v1 = _cannotDecreaseCDBaselineGuid; v1.Clean = value; _cannotDecreaseCDBaselineGuid = v1;
                var v2 = _cannotDecreaseLEBaselineGuid; v2.Clean = value; _cannotDecreaseLEBaselineGuid = v2;
                var v3 = _cannotIncrease10CDBaselineGuid; v3.Clean = value; _cannotIncrease10CDBaselineGuid = v3;
                var v4 = _cannotIncrease10LEBaselineGuid; v4.Clean = value; _cannotIncrease10LEBaselineGuid = v4;
                var v5 = _cannotIncreaseCDBaselineGuid; v5.Clean = value; _cannotIncreaseCDBaselineGuid = v5;
                var v6 = _cannotIncreaseLEBaselineGuid; v6.Clean = value; _cannotIncreaseLEBaselineGuid = v6;
                var v7 = _cDInitialGuid; v7.Clean = value; _cDInitialGuid = v7;
                var v8 = _cDInitialReceivedDateGuid; v8.Clean = value; _cDInitialReceivedDateGuid = v8;
                var v9 = _cDLatestGuid; v9.Clean = value; _cDLatestGuid = v9;
                var v10 = _cDPostConGuid; v10.Clean = value; _cDPostConGuid = v10;
                var v11 = _cDRecentAppliedCure; v11.Clean = value; _cDRecentAppliedCure = v11;
                var v12 = _cDRevisedReceivedDateGuid; v12.Clean = value; _cDRevisedReceivedDateGuid = v12;
                var v13 = _chargesCannotIncrease10CD1; v13.Clean = value; _chargesCannotIncrease10CD1 = v13;
                var v14 = _chargesCannotIncrease10InitialLE1; v14.Clean = value; _chargesCannotIncrease10InitialLE1 = v14;
                var v15 = _chargesCannotIncrease10LE1; v15.Clean = value; _chargesCannotIncrease10LE1 = v15;
                var v16 = _chargesThatCanChangeCD1; v16.Clean = value; _chargesThatCanChangeCD1 = v16;
                var v17 = _chargesThatCanChangeInitialLE1; v17.Clean = value; _chargesThatCanChangeInitialLE1 = v17;
                var v18 = _chargesThatCanChangeLE1; v18.Clean = value; _chargesThatCanChangeLE1 = v18;
                var v19 = _chargesThatCannotDecreaseCD1; v19.Clean = value; _chargesThatCannotDecreaseCD1 = v19;
                var v20 = _chargesThatCannotDecreaseInitialLE1; v20.Clean = value; _chargesThatCannotDecreaseInitialLE1 = v20;
                var v21 = _chargesThatCannotDecreaseLE1; v21.Clean = value; _chargesThatCannotDecreaseLE1 = v21;
                var v22 = _chargesThatCannotIncreaseCD1; v22.Clean = value; _chargesThatCannotIncreaseCD1 = v22;
                var v23 = _chargesThatCannotIncreaseInitialLE1; v23.Clean = value; _chargesThatCannotIncreaseInitialLE1 = v23;
                var v24 = _chargesThatCannotIncreaseLE1; v24.Clean = value; _chargesThatCannotIncreaseLE1 = v24;
                var v25 = _disclosureLogGUIDForECD; v25.Clean = value; _disclosureLogGUIDForECD = v25;
                var v26 = _disclosureLogGUIDReceivedForECD; v26.Clean = value; _disclosureLogGUIDReceivedForECD = v26;
                var v27 = _goodFaithAmountInitialLE1; v27.Clean = value; _goodFaithAmountInitialLE1 = v27;
                var v28 = _id; v28.Clean = value; _id = v28;
                var v29 = _lEBaselineUsedCannotDecrease; v29.Clean = value; _lEBaselineUsedCannotDecrease = v29;
                var v30 = _lEBaselineUsedCannotIncrease; v30.Clean = value; _lEBaselineUsedCannotIncrease = v30;
                var v31 = _lEBaselineUsedCannotIncrease10; v31.Clean = value; _lEBaselineUsedCannotIncrease10 = v31;
                var v32 = _lEInitialDTGuid; v32.Clean = value; _lEInitialDTGuid = v32;
                var v33 = _lEInitialGuid; v33.Clean = value; _lEInitialGuid = v33;
                var v34 = _lEInitialReceivedDateGuid; v34.Clean = value; _lEInitialReceivedDateGuid = v34;
                var v35 = _lELatestGuid; v35.Clean = value; _lELatestGuid = v35;
                var v36 = _lERevisedReceivedDateGuid; v36.Clean = value; _lERevisedReceivedDateGuid = v36;
                var v37 = _lERevisedSentDateGuid; v37.Clean = value; _lERevisedSentDateGuid = v37;
                var v38 = _requiredCureAmount; v38.Clean = value; _requiredCureAmount = v38;
                var v39 = _safeHarborGuid; v39.Clean = value; _safeHarborGuid = v39;
                var v40 = _sSPLGuid; v40.Clean = value; _sSPLGuid = v40;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public FeeVarianceOther()
        {
            Clean = true;
        }
    }
}