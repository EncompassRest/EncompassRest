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
                var appliedCureAmount = _appliedCureAmount; appliedCureAmount.Clean = value; _appliedCureAmount = appliedCureAmount;
                var cannotDecreaseCDBaselineGuid = _cannotDecreaseCDBaselineGuid; cannotDecreaseCDBaselineGuid.Clean = value; _cannotDecreaseCDBaselineGuid = cannotDecreaseCDBaselineGuid;
                var cannotDecreaseLEBaselineGuid = _cannotDecreaseLEBaselineGuid; cannotDecreaseLEBaselineGuid.Clean = value; _cannotDecreaseLEBaselineGuid = cannotDecreaseLEBaselineGuid;
                var cannotIncrease10CDBaselineGuid = _cannotIncrease10CDBaselineGuid; cannotIncrease10CDBaselineGuid.Clean = value; _cannotIncrease10CDBaselineGuid = cannotIncrease10CDBaselineGuid;
                var cannotIncrease10LEBaselineGuid = _cannotIncrease10LEBaselineGuid; cannotIncrease10LEBaselineGuid.Clean = value; _cannotIncrease10LEBaselineGuid = cannotIncrease10LEBaselineGuid;
                var cannotIncreaseCDBaselineGuid = _cannotIncreaseCDBaselineGuid; cannotIncreaseCDBaselineGuid.Clean = value; _cannotIncreaseCDBaselineGuid = cannotIncreaseCDBaselineGuid;
                var cannotIncreaseLEBaselineGuid = _cannotIncreaseLEBaselineGuid; cannotIncreaseLEBaselineGuid.Clean = value; _cannotIncreaseLEBaselineGuid = cannotIncreaseLEBaselineGuid;
                var cDInitialGuid = _cDInitialGuid; cDInitialGuid.Clean = value; _cDInitialGuid = cDInitialGuid;
                var cDInitialReceivedDateGuid = _cDInitialReceivedDateGuid; cDInitialReceivedDateGuid.Clean = value; _cDInitialReceivedDateGuid = cDInitialReceivedDateGuid;
                var cDLatestGuid = _cDLatestGuid; cDLatestGuid.Clean = value; _cDLatestGuid = cDLatestGuid;
                var cDPostConGuid = _cDPostConGuid; cDPostConGuid.Clean = value; _cDPostConGuid = cDPostConGuid;
                var cDRecentAppliedCure = _cDRecentAppliedCure; cDRecentAppliedCure.Clean = value; _cDRecentAppliedCure = cDRecentAppliedCure;
                var cDRevisedReceivedDateGuid = _cDRevisedReceivedDateGuid; cDRevisedReceivedDateGuid.Clean = value; _cDRevisedReceivedDateGuid = cDRevisedReceivedDateGuid;
                var chargesCannotIncrease10CD1 = _chargesCannotIncrease10CD1; chargesCannotIncrease10CD1.Clean = value; _chargesCannotIncrease10CD1 = chargesCannotIncrease10CD1;
                var chargesCannotIncrease10InitialLE1 = _chargesCannotIncrease10InitialLE1; chargesCannotIncrease10InitialLE1.Clean = value; _chargesCannotIncrease10InitialLE1 = chargesCannotIncrease10InitialLE1;
                var chargesCannotIncrease10LE1 = _chargesCannotIncrease10LE1; chargesCannotIncrease10LE1.Clean = value; _chargesCannotIncrease10LE1 = chargesCannotIncrease10LE1;
                var chargesThatCanChangeCD1 = _chargesThatCanChangeCD1; chargesThatCanChangeCD1.Clean = value; _chargesThatCanChangeCD1 = chargesThatCanChangeCD1;
                var chargesThatCanChangeInitialLE1 = _chargesThatCanChangeInitialLE1; chargesThatCanChangeInitialLE1.Clean = value; _chargesThatCanChangeInitialLE1 = chargesThatCanChangeInitialLE1;
                var chargesThatCanChangeLE1 = _chargesThatCanChangeLE1; chargesThatCanChangeLE1.Clean = value; _chargesThatCanChangeLE1 = chargesThatCanChangeLE1;
                var chargesThatCannotDecreaseCD1 = _chargesThatCannotDecreaseCD1; chargesThatCannotDecreaseCD1.Clean = value; _chargesThatCannotDecreaseCD1 = chargesThatCannotDecreaseCD1;
                var chargesThatCannotDecreaseInitialLE1 = _chargesThatCannotDecreaseInitialLE1; chargesThatCannotDecreaseInitialLE1.Clean = value; _chargesThatCannotDecreaseInitialLE1 = chargesThatCannotDecreaseInitialLE1;
                var chargesThatCannotDecreaseLE1 = _chargesThatCannotDecreaseLE1; chargesThatCannotDecreaseLE1.Clean = value; _chargesThatCannotDecreaseLE1 = chargesThatCannotDecreaseLE1;
                var chargesThatCannotIncreaseCD1 = _chargesThatCannotIncreaseCD1; chargesThatCannotIncreaseCD1.Clean = value; _chargesThatCannotIncreaseCD1 = chargesThatCannotIncreaseCD1;
                var chargesThatCannotIncreaseInitialLE1 = _chargesThatCannotIncreaseInitialLE1; chargesThatCannotIncreaseInitialLE1.Clean = value; _chargesThatCannotIncreaseInitialLE1 = chargesThatCannotIncreaseInitialLE1;
                var chargesThatCannotIncreaseLE1 = _chargesThatCannotIncreaseLE1; chargesThatCannotIncreaseLE1.Clean = value; _chargesThatCannotIncreaseLE1 = chargesThatCannotIncreaseLE1;
                var disclosureLogGUIDForECD = _disclosureLogGUIDForECD; disclosureLogGUIDForECD.Clean = value; _disclosureLogGUIDForECD = disclosureLogGUIDForECD;
                var disclosureLogGUIDReceivedForECD = _disclosureLogGUIDReceivedForECD; disclosureLogGUIDReceivedForECD.Clean = value; _disclosureLogGUIDReceivedForECD = disclosureLogGUIDReceivedForECD;
                var goodFaithAmountInitialLE1 = _goodFaithAmountInitialLE1; goodFaithAmountInitialLE1.Clean = value; _goodFaithAmountInitialLE1 = goodFaithAmountInitialLE1;
                var id = _id; id.Clean = value; _id = id;
                var lEBaselineUsedCannotDecrease = _lEBaselineUsedCannotDecrease; lEBaselineUsedCannotDecrease.Clean = value; _lEBaselineUsedCannotDecrease = lEBaselineUsedCannotDecrease;
                var lEBaselineUsedCannotIncrease = _lEBaselineUsedCannotIncrease; lEBaselineUsedCannotIncrease.Clean = value; _lEBaselineUsedCannotIncrease = lEBaselineUsedCannotIncrease;
                var lEBaselineUsedCannotIncrease10 = _lEBaselineUsedCannotIncrease10; lEBaselineUsedCannotIncrease10.Clean = value; _lEBaselineUsedCannotIncrease10 = lEBaselineUsedCannotIncrease10;
                var lEInitialDTGuid = _lEInitialDTGuid; lEInitialDTGuid.Clean = value; _lEInitialDTGuid = lEInitialDTGuid;
                var lEInitialGuid = _lEInitialGuid; lEInitialGuid.Clean = value; _lEInitialGuid = lEInitialGuid;
                var lEInitialReceivedDateGuid = _lEInitialReceivedDateGuid; lEInitialReceivedDateGuid.Clean = value; _lEInitialReceivedDateGuid = lEInitialReceivedDateGuid;
                var lELatestGuid = _lELatestGuid; lELatestGuid.Clean = value; _lELatestGuid = lELatestGuid;
                var lERevisedReceivedDateGuid = _lERevisedReceivedDateGuid; lERevisedReceivedDateGuid.Clean = value; _lERevisedReceivedDateGuid = lERevisedReceivedDateGuid;
                var lERevisedSentDateGuid = _lERevisedSentDateGuid; lERevisedSentDateGuid.Clean = value; _lERevisedSentDateGuid = lERevisedSentDateGuid;
                var requiredCureAmount = _requiredCureAmount; requiredCureAmount.Clean = value; _requiredCureAmount = requiredCureAmount;
                var safeHarborGuid = _safeHarborGuid; safeHarborGuid.Clean = value; _safeHarborGuid = safeHarborGuid;
                var sSPLGuid = _sSPLGuid; sSPLGuid.Clean = value; _sSPLGuid = sSPLGuid;
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