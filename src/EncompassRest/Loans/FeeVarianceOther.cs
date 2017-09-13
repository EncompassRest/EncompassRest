using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class FeeVarianceOther : IDirty
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _appliedCureAmount.Dirty
                    || _cannotDecreaseCDBaselineGuid.Dirty
                    || _cannotDecreaseLEBaselineGuid.Dirty
                    || _cannotIncrease10CDBaselineGuid.Dirty
                    || _cannotIncrease10LEBaselineGuid.Dirty
                    || _cannotIncreaseCDBaselineGuid.Dirty
                    || _cannotIncreaseLEBaselineGuid.Dirty
                    || _cDInitialGuid.Dirty
                    || _cDInitialReceivedDateGuid.Dirty
                    || _cDLatestGuid.Dirty
                    || _cDPostConGuid.Dirty
                    || _cDRecentAppliedCure.Dirty
                    || _cDRevisedReceivedDateGuid.Dirty
                    || _chargesCannotIncrease10CD1.Dirty
                    || _chargesCannotIncrease10InitialLE1.Dirty
                    || _chargesCannotIncrease10LE1.Dirty
                    || _chargesThatCanChangeCD1.Dirty
                    || _chargesThatCanChangeInitialLE1.Dirty
                    || _chargesThatCanChangeLE1.Dirty
                    || _chargesThatCannotDecreaseCD1.Dirty
                    || _chargesThatCannotDecreaseInitialLE1.Dirty
                    || _chargesThatCannotDecreaseLE1.Dirty
                    || _chargesThatCannotIncreaseCD1.Dirty
                    || _chargesThatCannotIncreaseInitialLE1.Dirty
                    || _chargesThatCannotIncreaseLE1.Dirty
                    || _disclosureLogGUIDForECD.Dirty
                    || _disclosureLogGUIDReceivedForECD.Dirty
                    || _goodFaithAmountInitialLE1.Dirty
                    || _id.Dirty
                    || _lEBaselineUsedCannotDecrease.Dirty
                    || _lEBaselineUsedCannotIncrease.Dirty
                    || _lEBaselineUsedCannotIncrease10.Dirty
                    || _lEInitialDTGuid.Dirty
                    || _lEInitialGuid.Dirty
                    || _lEInitialReceivedDateGuid.Dirty
                    || _lELatestGuid.Dirty
                    || _lERevisedReceivedDateGuid.Dirty
                    || _lERevisedSentDateGuid.Dirty
                    || _requiredCureAmount.Dirty
                    || _safeHarborGuid.Dirty
                    || _sSPLGuid.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _appliedCureAmount.Dirty = value;
                _cannotDecreaseCDBaselineGuid.Dirty = value;
                _cannotDecreaseLEBaselineGuid.Dirty = value;
                _cannotIncrease10CDBaselineGuid.Dirty = value;
                _cannotIncrease10LEBaselineGuid.Dirty = value;
                _cannotIncreaseCDBaselineGuid.Dirty = value;
                _cannotIncreaseLEBaselineGuid.Dirty = value;
                _cDInitialGuid.Dirty = value;
                _cDInitialReceivedDateGuid.Dirty = value;
                _cDLatestGuid.Dirty = value;
                _cDPostConGuid.Dirty = value;
                _cDRecentAppliedCure.Dirty = value;
                _cDRevisedReceivedDateGuid.Dirty = value;
                _chargesCannotIncrease10CD1.Dirty = value;
                _chargesCannotIncrease10InitialLE1.Dirty = value;
                _chargesCannotIncrease10LE1.Dirty = value;
                _chargesThatCanChangeCD1.Dirty = value;
                _chargesThatCanChangeInitialLE1.Dirty = value;
                _chargesThatCanChangeLE1.Dirty = value;
                _chargesThatCannotDecreaseCD1.Dirty = value;
                _chargesThatCannotDecreaseInitialLE1.Dirty = value;
                _chargesThatCannotDecreaseLE1.Dirty = value;
                _chargesThatCannotIncreaseCD1.Dirty = value;
                _chargesThatCannotIncreaseInitialLE1.Dirty = value;
                _chargesThatCannotIncreaseLE1.Dirty = value;
                _disclosureLogGUIDForECD.Dirty = value;
                _disclosureLogGUIDReceivedForECD.Dirty = value;
                _goodFaithAmountInitialLE1.Dirty = value;
                _id.Dirty = value;
                _lEBaselineUsedCannotDecrease.Dirty = value;
                _lEBaselineUsedCannotIncrease.Dirty = value;
                _lEBaselineUsedCannotIncrease10.Dirty = value;
                _lEInitialDTGuid.Dirty = value;
                _lEInitialGuid.Dirty = value;
                _lEInitialReceivedDateGuid.Dirty = value;
                _lELatestGuid.Dirty = value;
                _lERevisedReceivedDateGuid.Dirty = value;
                _lERevisedSentDateGuid.Dirty = value;
                _requiredCureAmount.Dirty = value;
                _safeHarborGuid.Dirty = value;
                _sSPLGuid.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}