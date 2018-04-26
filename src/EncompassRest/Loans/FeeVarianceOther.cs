using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// FeeVarianceOther
    /// </summary>
    public sealed partial class FeeVarianceOther : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _appliedCureAmount;
        /// <summary>
        /// Tolerance Cure Applied Cure Amount [FV.X366]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Tolerance Cure Applied Cure Amount")]
        public decimal? AppliedCureAmount { get => _appliedCureAmount; set => _appliedCureAmount = value; }
        private DirtyValue<string> _cannotDecreaseCDBaselineGuid;
        /// <summary>
        /// Cannot Decrease - CD Baseline Guid [FV.X361]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Cannot Decrease - CD Baseline Guid")]
        public string CannotDecreaseCDBaselineGuid { get => _cannotDecreaseCDBaselineGuid; set => _cannotDecreaseCDBaselineGuid = value; }
        private DirtyValue<string> _cannotDecreaseLEBaselineGuid;
        /// <summary>
        /// Cannot Decrease - LE Baseline Guid [FV.X360]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Cannot Decrease - LE Baseline Guid")]
        public string CannotDecreaseLEBaselineGuid { get => _cannotDecreaseLEBaselineGuid; set => _cannotDecreaseLEBaselineGuid = value; }
        private DirtyValue<string> _cannotIncrease10CDBaselineGuid;
        /// <summary>
        /// Cannot Increase 10 - CD Baseline Guid [FV.X365]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Cannot Increase 10 - CD Baseline Guid")]
        public string CannotIncrease10CDBaselineGuid { get => _cannotIncrease10CDBaselineGuid; set => _cannotIncrease10CDBaselineGuid = value; }
        private DirtyValue<string> _cannotIncrease10LEBaselineGuid;
        /// <summary>
        /// Cannot Increase 10 - LE Baseline Guid [FV.X364]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Cannot Increase 10 - LE Baseline Guid")]
        public string CannotIncrease10LEBaselineGuid { get => _cannotIncrease10LEBaselineGuid; set => _cannotIncrease10LEBaselineGuid = value; }
        private DirtyValue<string> _cannotIncreaseCDBaselineGuid;
        /// <summary>
        /// Cannot Increase - CD Baseline Guid [FV.X363]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Cannot Increase - CD Baseline Guid")]
        public string CannotIncreaseCDBaselineGuid { get => _cannotIncreaseCDBaselineGuid; set => _cannotIncreaseCDBaselineGuid = value; }
        private DirtyValue<string> _cannotIncreaseLEBaselineGuid;
        /// <summary>
        /// Cannot Increase - LE Baseline Guid [FV.X362]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Cannot Increase - LE Baseline Guid")]
        public string CannotIncreaseLEBaselineGuid { get => _cannotIncreaseLEBaselineGuid; set => _cannotIncreaseLEBaselineGuid = value; }
        private DirtyValue<string> _cDInitialGuid;
        /// <summary>
        /// CD Initial Guid [FV.X358]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "CD Initial Guid")]
        public string CDInitialGuid { get => _cDInitialGuid; set => _cDInitialGuid = value; }
        private DirtyValue<string> _cDInitialReceivedDateGuid;
        /// <summary>
        /// CD Initial Received Date Disclosure Tracking Guid [FV.X394]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "CD Initial Received Date Disclosure Tracking Guid")]
        public string CDInitialReceivedDateGuid { get => _cDInitialReceivedDateGuid; set => _cDInitialReceivedDateGuid = value; }
        private DirtyValue<string> _cDLatestGuid;
        /// <summary>
        /// CD Latest Guid [FV.X359]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "CD Latest Guid")]
        public string CDLatestGuid { get => _cDLatestGuid; set => _cDLatestGuid = value; }
        private DirtyValue<string> _cDPostConGuid;
        /// <summary>
        /// CD Post Consummation GUID [FV.X367]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "CD Post Consummation GUID")]
        public string CDPostConGuid { get => _cDPostConGuid; set => _cDPostConGuid = value; }
        private DirtyValue<string> _cDRecentAppliedCure;
        /// <summary>
        /// CD Recent Applied Cure Reason [FV.X386]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "CD Recent Applied Cure Reason")]
        public string CDRecentAppliedCure { get => _cDRecentAppliedCure; set => _cDRecentAppliedCure = value; }
        private DirtyValue<string> _cDRevisedReceivedDateGuid;
        /// <summary>
        /// CD Revised Received Date Disclosure Tracking Guid [FV.X395]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "CD Revised Received Date Disclosure Tracking Guid")]
        public string CDRevisedReceivedDateGuid { get => _cDRevisedReceivedDateGuid; set => _cDRevisedReceivedDateGuid = value; }
        private DirtyValue<DateTime?> _chargesCannotIncrease10CD1;
        /// <summary>
        /// Charges Cannot Increase 10 CD 1 [FV.X55]
        /// </summary>
        [LoanFieldProperty(Description = "Charges Cannot Increase 10 CD 1")]
        public DateTime? ChargesCannotIncrease10CD1 { get => _chargesCannotIncrease10CD1; set => _chargesCannotIncrease10CD1 = value; }
        private DirtyValue<DateTime?> _chargesCannotIncrease10InitialLE1;
        /// <summary>
        /// Charges Cannot Increase 10 Initial LE 1 [FV.X53]
        /// </summary>
        [LoanFieldProperty(Description = "Charges Cannot Increase 10 Initial LE 1")]
        public DateTime? ChargesCannotIncrease10InitialLE1 { get => _chargesCannotIncrease10InitialLE1; set => _chargesCannotIncrease10InitialLE1 = value; }
        private DirtyValue<DateTime?> _chargesCannotIncrease10LE1;
        /// <summary>
        /// Charges Cannot Increase 10 LE 1 [FV.X54]
        /// </summary>
        [LoanFieldProperty(Description = "Charges Cannot Increase 10 LE 1")]
        public DateTime? ChargesCannotIncrease10LE1 { get => _chargesCannotIncrease10LE1; set => _chargesCannotIncrease10LE1 = value; }
        private DirtyValue<DateTime?> _chargesThatCanChangeCD1;
        /// <summary>
        /// Charges that Can Change CD 1 [FV.X216]
        /// </summary>
        [LoanFieldProperty(Description = "Charges that Can Change CD 1")]
        public DateTime? ChargesThatCanChangeCD1 { get => _chargesThatCanChangeCD1; set => _chargesThatCanChangeCD1 = value; }
        private DirtyValue<DateTime?> _chargesThatCanChangeInitialLE1;
        /// <summary>
        /// Charges that Can Change Initial LE 1 [FV.X214]
        /// </summary>
        [LoanFieldProperty(Description = "Charges that Can Change Initial LE 1")]
        public DateTime? ChargesThatCanChangeInitialLE1 { get => _chargesThatCanChangeInitialLE1; set => _chargesThatCanChangeInitialLE1 = value; }
        private DirtyValue<DateTime?> _chargesThatCanChangeLE1;
        /// <summary>
        /// Charges that Can Change LE 1 [FV.X215]
        /// </summary>
        [LoanFieldProperty(Description = "Charges that Can Change LE 1")]
        public DateTime? ChargesThatCanChangeLE1 { get => _chargesThatCanChangeLE1; set => _chargesThatCanChangeLE1 = value; }
        private DirtyValue<DateTime?> _chargesThatCannotDecreaseCD1;
        /// <summary>
        /// Charges That Cannot Decrease CD 1 [FV.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Charges That Cannot Decrease CD 1")]
        public DateTime? ChargesThatCannotDecreaseCD1 { get => _chargesThatCannotDecreaseCD1; set => _chargesThatCannotDecreaseCD1 = value; }
        private DirtyValue<DateTime?> _chargesThatCannotDecreaseInitialLE1;
        /// <summary>
        /// Charges That Cannot Decrease Initial LE 1 [FV.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Charges That Cannot Decrease Initial LE 1")]
        public DateTime? ChargesThatCannotDecreaseInitialLE1 { get => _chargesThatCannotDecreaseInitialLE1; set => _chargesThatCannotDecreaseInitialLE1 = value; }
        private DirtyValue<DateTime?> _chargesThatCannotDecreaseLE1;
        /// <summary>
        /// Charges That Cannot Decrease LE 1 [FV.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Charges That Cannot Decrease LE 1")]
        public DateTime? ChargesThatCannotDecreaseLE1 { get => _chargesThatCannotDecreaseLE1; set => _chargesThatCannotDecreaseLE1 = value; }
        private DirtyValue<DateTime?> _chargesThatCannotIncreaseCD1;
        /// <summary>
        /// Charges That Cannot Increase CD 1 [FV.X29]
        /// </summary>
        [LoanFieldProperty(Description = "Charges That Cannot Increase CD 1")]
        public DateTime? ChargesThatCannotIncreaseCD1 { get => _chargesThatCannotIncreaseCD1; set => _chargesThatCannotIncreaseCD1 = value; }
        private DirtyValue<DateTime?> _chargesThatCannotIncreaseInitialLE1;
        /// <summary>
        /// Charges That Cannot Increase Initial LE 1 [FV.X27]
        /// </summary>
        [LoanFieldProperty(Description = "Charges That Cannot Increase Initial LE 1")]
        public DateTime? ChargesThatCannotIncreaseInitialLE1 { get => _chargesThatCannotIncreaseInitialLE1; set => _chargesThatCannotIncreaseInitialLE1 = value; }
        private DirtyValue<DateTime?> _chargesThatCannotIncreaseLE1;
        /// <summary>
        /// Charges That Cannot Increase LE 1 [FV.X28]
        /// </summary>
        [LoanFieldProperty(Description = "Charges That Cannot Increase LE 1")]
        public DateTime? ChargesThatCannotIncreaseLE1 { get => _chargesThatCannotIncreaseLE1; set => _chargesThatCannotIncreaseLE1 = value; }
        private DirtyValue<string> _disclosureLogGUIDForECD;
        /// <summary>
        /// Disclosure Log GUID used For ECD calculation [FV.X387]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Disclosure Log GUID used For ECD calculation")]
        public string DisclosureLogGUIDForECD { get => _disclosureLogGUIDForECD; set => _disclosureLogGUIDForECD = value; }
        private DirtyValue<string> _disclosureLogGUIDReceivedForECD;
        /// <summary>
        /// Disclosure Log GUID CD Revised Received used For ECD calculation [FV.X389]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Disclosure Log GUID CD Revised Received used For ECD calculation")]
        public string DisclosureLogGUIDReceivedForECD { get => _disclosureLogGUIDReceivedForECD; set => _disclosureLogGUIDReceivedForECD = value; }
        private DirtyValue<DateTime?> _goodFaithAmountInitialLE1;
        /// <summary>
        /// Good Faith Amount Initial LE 1 [FV.X324]
        /// </summary>
        [LoanFieldProperty(Description = "Good Faith Amount Initial LE 1")]
        public DateTime? GoodFaithAmountInitialLE1 { get => _goodFaithAmountInitialLE1; set => _goodFaithAmountInitialLE1 = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// FeeVarianceOther Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _lEBaselineUsedCannotDecrease;
        /// <summary>
        /// Cannot Decrease - LE Baseline Used [FV.X374]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Cannot Decrease - LE Baseline Used")]
        public bool? LEBaselineUsedCannotDecrease { get => _lEBaselineUsedCannotDecrease; set => _lEBaselineUsedCannotDecrease = value; }
        private DirtyValue<bool?> _lEBaselineUsedCannotIncrease;
        /// <summary>
        /// Cannot Increase - LE Baseline Used [FV.X375]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Cannot Increase - LE Baseline Used")]
        public bool? LEBaselineUsedCannotIncrease { get => _lEBaselineUsedCannotIncrease; set => _lEBaselineUsedCannotIncrease = value; }
        private DirtyValue<bool?> _lEBaselineUsedCannotIncrease10;
        /// <summary>
        /// Cannot Increase 10 - LE Baseline Used [FV.X376]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Cannot Increase 10 - LE Baseline Used")]
        public bool? LEBaselineUsedCannotIncrease10 { get => _lEBaselineUsedCannotIncrease10; set => _lEBaselineUsedCannotIncrease10 = value; }
        private DirtyValue<string> _lEInitialDTGuid;
        /// <summary>
        /// LE Initial Disclosure Tracking Guid [FV.X385]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "LE Initial Disclosure Tracking Guid")]
        public string LEInitialDTGuid { get => _lEInitialDTGuid; set => _lEInitialDTGuid = value; }
        private DirtyValue<string> _lEInitialGuid;
        /// <summary>
        /// LE Initial Guid [FV.X356]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "LE Initial Guid")]
        public string LEInitialGuid { get => _lEInitialGuid; set => _lEInitialGuid = value; }
        private DirtyValue<string> _lEInitialReceivedDateGuid;
        /// <summary>
        /// LE Initial Received Date Disclosure Tracking Guid [FV.X392]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "LE Initial Received Date Disclosure Tracking Guid")]
        public string LEInitialReceivedDateGuid { get => _lEInitialReceivedDateGuid; set => _lEInitialReceivedDateGuid = value; }
        private DirtyValue<string> _lELatestGuid;
        /// <summary>
        /// LE Latest Guid [FV.X357]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "LE Latest Guid")]
        public string LELatestGuid { get => _lELatestGuid; set => _lELatestGuid = value; }
        private DirtyValue<string> _lERevisedReceivedDateGuid;
        /// <summary>
        /// LE Revised Received Date Disclosure Tracking Guid [FV.X393]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "LE Revised Received Date Disclosure Tracking Guid")]
        public string LERevisedReceivedDateGuid { get => _lERevisedReceivedDateGuid; set => _lERevisedReceivedDateGuid = value; }
        private DirtyValue<string> _lERevisedSentDateGuid;
        /// <summary>
        /// LE Revised Sent Date Disclosure Tracking Guid [FV.X391]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "LE Revised Sent Date Disclosure Tracking Guid")]
        public string LERevisedSentDateGuid { get => _lERevisedSentDateGuid; set => _lERevisedSentDateGuid = value; }
        private DirtyValue<decimal?> _requiredCureAmount;
        /// <summary>
        /// Tolerance Cure Required Cure Amount [FV.X348]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Tolerance Cure Required Cure Amount")]
        public decimal? RequiredCureAmount { get => _requiredCureAmount; set => _requiredCureAmount = value; }
        private DirtyValue<string> _safeHarborGuid;
        /// <summary>
        /// Safe Harbor GUID [FV.X368]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Safe Harbor GUID")]
        public string SafeHarborGuid { get => _safeHarborGuid; set => _safeHarborGuid = value; }
        private DirtyValue<string> _sSPLGuid;
        /// <summary>
        /// Settlement Services Provider List GUID [FV.X369]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Settlement Services Provider List GUID")]
        public string SSPLGuid { get => _sSPLGuid; set => _sSPLGuid = value; }
        internal override bool DirtyInternal
        {
            get => _appliedCureAmount.Dirty
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
            set
            {
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
            }
        }
    }
}