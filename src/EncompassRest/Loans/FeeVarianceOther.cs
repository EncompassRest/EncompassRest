using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// FeeVarianceOther
    /// </summary>
    public sealed partial class FeeVarianceOther : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _appliedCureAmount;
        private DirtyValue<string> _cannotDecreaseCDBaselineGuid;
        private DirtyValue<string> _cannotDecreaseLEBaselineGuid;
        private DirtyValue<string> _cannotIncrease10CDBaselineGuid;
        private DirtyValue<string> _cannotIncrease10LEBaselineGuid;
        private DirtyValue<string> _cannotIncreaseCDBaselineGuid;
        private DirtyValue<string> _cannotIncreaseLEBaselineGuid;
        private DirtyValue<string> _cDInitialGuid;
        private DirtyValue<string> _cDInitialReceivedDateGuid;
        private DirtyValue<string> _cDLatestGuid;
        private DirtyValue<string> _cDPostConGuid;
        private DirtyValue<string> _cDRecentAppliedCure;
        private DirtyValue<string> _cDRevisedReceivedDateGuid;
        private DirtyValue<DateTime?> _chargesCannotIncrease10CD1;
        private DirtyValue<DateTime?> _chargesCannotIncrease10InitialLE1;
        private DirtyValue<DateTime?> _chargesCannotIncrease10LE1;
        private DirtyValue<DateTime?> _chargesThatCanChangeCD1;
        private DirtyValue<DateTime?> _chargesThatCanChangeInitialLE1;
        private DirtyValue<DateTime?> _chargesThatCanChangeLE1;
        private DirtyValue<DateTime?> _chargesThatCannotDecreaseCD1;
        private DirtyValue<DateTime?> _chargesThatCannotDecreaseInitialLE1;
        private DirtyValue<DateTime?> _chargesThatCannotDecreaseLE1;
        private DirtyValue<DateTime?> _chargesThatCannotIncreaseCD1;
        private DirtyValue<DateTime?> _chargesThatCannotIncreaseInitialLE1;
        private DirtyValue<DateTime?> _chargesThatCannotIncreaseLE1;
        private DirtyValue<decimal?> _cureAppliedToLenderCredit;
        private DirtyValue<decimal?> _cureAppliedToPrincipalReduction;
        private DirtyValue<string> _disclosureLogGUIDForECD;
        private DirtyValue<string> _disclosureLogGUIDReceivedForECD;
        private DirtyValue<DateTime?> _goodFaithAmountInitialLE1;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _lEBaselineUsedCannotDecrease;
        private DirtyValue<bool?> _lEBaselineUsedCannotIncrease;
        private DirtyValue<bool?> _lEBaselineUsedCannotIncrease10;
        private DirtyValue<string> _lEInitialDTGuid;
        private DirtyValue<string> _lEInitialGuid;
        private DirtyValue<string> _lEInitialReceivedDateGuid;
        private DirtyValue<string> _lELatestGuid;
        private DirtyValue<string> _lERevisedReceivedDateGuid;
        private DirtyValue<string> _lERevisedSentDateGuid;
        private DirtyValue<decimal?> _requiredCureAmount;
        private DirtyValue<string> _safeHarborGuid;
        private DirtyValue<string> _sSPLGuid;

        /// <summary>
        /// Tolerance Cure Applied Cure Amount [FV.X366]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AppliedCureAmount { get => _appliedCureAmount; set => SetField(ref _appliedCureAmount, value); }

        /// <summary>
        /// Cannot Decrease - CD Baseline Guid [FV.X361]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CannotDecreaseCDBaselineGuid { get => _cannotDecreaseCDBaselineGuid; set => SetField(ref _cannotDecreaseCDBaselineGuid, value); }

        /// <summary>
        /// Cannot Decrease - LE Baseline Guid [FV.X360]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CannotDecreaseLEBaselineGuid { get => _cannotDecreaseLEBaselineGuid; set => SetField(ref _cannotDecreaseLEBaselineGuid, value); }

        /// <summary>
        /// Cannot Increase 10 - CD Baseline Guid [FV.X365]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CannotIncrease10CDBaselineGuid { get => _cannotIncrease10CDBaselineGuid; set => SetField(ref _cannotIncrease10CDBaselineGuid, value); }

        /// <summary>
        /// Cannot Increase 10 - LE Baseline Guid [FV.X364]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CannotIncrease10LEBaselineGuid { get => _cannotIncrease10LEBaselineGuid; set => SetField(ref _cannotIncrease10LEBaselineGuid, value); }

        /// <summary>
        /// Cannot Increase - CD Baseline Guid [FV.X363]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CannotIncreaseCDBaselineGuid { get => _cannotIncreaseCDBaselineGuid; set => SetField(ref _cannotIncreaseCDBaselineGuid, value); }

        /// <summary>
        /// Cannot Increase - LE Baseline Guid [FV.X362]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CannotIncreaseLEBaselineGuid { get => _cannotIncreaseLEBaselineGuid; set => SetField(ref _cannotIncreaseLEBaselineGuid, value); }

        /// <summary>
        /// CD Initial Guid [FV.X358]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CDInitialGuid { get => _cDInitialGuid; set => SetField(ref _cDInitialGuid, value); }

        /// <summary>
        /// CD Initial Received Date Disclosure Tracking Guid [FV.X394]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CDInitialReceivedDateGuid { get => _cDInitialReceivedDateGuid; set => SetField(ref _cDInitialReceivedDateGuid, value); }

        /// <summary>
        /// CD Latest Guid [FV.X359]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CDLatestGuid { get => _cDLatestGuid; set => SetField(ref _cDLatestGuid, value); }

        /// <summary>
        /// CD Post Consummation GUID [FV.X367]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CDPostConGuid { get => _cDPostConGuid; set => SetField(ref _cDPostConGuid, value); }

        /// <summary>
        /// CD Recent Applied Cure Reason [FV.X386]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CDRecentAppliedCure { get => _cDRecentAppliedCure; set => SetField(ref _cDRecentAppliedCure, value); }

        /// <summary>
        /// CD Revised Received Date Disclosure Tracking Guid [FV.X395]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CDRevisedReceivedDateGuid { get => _cDRevisedReceivedDateGuid; set => SetField(ref _cDRevisedReceivedDateGuid, value); }

        /// <summary>
        /// Charges Cannot Increase 10 CD 1 [FV.X55]
        /// </summary>
        public DateTime? ChargesCannotIncrease10CD1 { get => _chargesCannotIncrease10CD1; set => SetField(ref _chargesCannotIncrease10CD1, value); }

        /// <summary>
        /// Charges Cannot Increase 10 Initial LE 1 [FV.X53]
        /// </summary>
        public DateTime? ChargesCannotIncrease10InitialLE1 { get => _chargesCannotIncrease10InitialLE1; set => SetField(ref _chargesCannotIncrease10InitialLE1, value); }

        /// <summary>
        /// Charges Cannot Increase 10 LE 1 [FV.X54]
        /// </summary>
        public DateTime? ChargesCannotIncrease10LE1 { get => _chargesCannotIncrease10LE1; set => SetField(ref _chargesCannotIncrease10LE1, value); }

        /// <summary>
        /// Charges that Can Change CD 1 [FV.X216]
        /// </summary>
        public DateTime? ChargesThatCanChangeCD1 { get => _chargesThatCanChangeCD1; set => SetField(ref _chargesThatCanChangeCD1, value); }

        /// <summary>
        /// Charges that Can Change Initial LE 1 [FV.X214]
        /// </summary>
        public DateTime? ChargesThatCanChangeInitialLE1 { get => _chargesThatCanChangeInitialLE1; set => SetField(ref _chargesThatCanChangeInitialLE1, value); }

        /// <summary>
        /// Charges that Can Change LE 1 [FV.X215]
        /// </summary>
        public DateTime? ChargesThatCanChangeLE1 { get => _chargesThatCanChangeLE1; set => SetField(ref _chargesThatCanChangeLE1, value); }

        /// <summary>
        /// Charges That Cannot Decrease CD 1 [FV.X3]
        /// </summary>
        public DateTime? ChargesThatCannotDecreaseCD1 { get => _chargesThatCannotDecreaseCD1; set => SetField(ref _chargesThatCannotDecreaseCD1, value); }

        /// <summary>
        /// Charges That Cannot Decrease Initial LE 1 [FV.X1]
        /// </summary>
        public DateTime? ChargesThatCannotDecreaseInitialLE1 { get => _chargesThatCannotDecreaseInitialLE1; set => SetField(ref _chargesThatCannotDecreaseInitialLE1, value); }

        /// <summary>
        /// Charges That Cannot Decrease LE 1 [FV.X2]
        /// </summary>
        public DateTime? ChargesThatCannotDecreaseLE1 { get => _chargesThatCannotDecreaseLE1; set => SetField(ref _chargesThatCannotDecreaseLE1, value); }

        /// <summary>
        /// Charges That Cannot Increase CD 1 [FV.X29]
        /// </summary>
        public DateTime? ChargesThatCannotIncreaseCD1 { get => _chargesThatCannotIncreaseCD1; set => SetField(ref _chargesThatCannotIncreaseCD1, value); }

        /// <summary>
        /// Charges That Cannot Increase Initial LE 1 [FV.X27]
        /// </summary>
        public DateTime? ChargesThatCannotIncreaseInitialLE1 { get => _chargesThatCannotIncreaseInitialLE1; set => SetField(ref _chargesThatCannotIncreaseInitialLE1, value); }

        /// <summary>
        /// Charges That Cannot Increase LE 1 [FV.X28]
        /// </summary>
        public DateTime? ChargesThatCannotIncreaseLE1 { get => _chargesThatCannotIncreaseLE1; set => SetField(ref _chargesThatCannotIncreaseLE1, value); }

        /// <summary>
        /// Cure Applied to Lender Credit [FV.X396]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CureAppliedToLenderCredit { get => _cureAppliedToLenderCredit; set => SetField(ref _cureAppliedToLenderCredit, value); }

        /// <summary>
        /// Cure Applied to Principal Reduction (POC) [FV.X397]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CureAppliedToPrincipalReduction { get => _cureAppliedToPrincipalReduction; set => SetField(ref _cureAppliedToPrincipalReduction, value); }

        /// <summary>
        /// Disclosure Log GUID used For ECD calculation [FV.X387]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string DisclosureLogGUIDForECD { get => _disclosureLogGUIDForECD; set => SetField(ref _disclosureLogGUIDForECD, value); }

        /// <summary>
        /// Disclosure Log GUID CD Revised Received used For ECD calculation [FV.X389]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string DisclosureLogGUIDReceivedForECD { get => _disclosureLogGUIDReceivedForECD; set => SetField(ref _disclosureLogGUIDReceivedForECD, value); }

        /// <summary>
        /// Good Faith Amount Initial LE 1 [FV.X324]
        /// </summary>
        public DateTime? GoodFaithAmountInitialLE1 { get => _goodFaithAmountInitialLE1; set => SetField(ref _goodFaithAmountInitialLE1, value); }

        /// <summary>
        /// FeeVarianceOther Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Cannot Decrease - LE Baseline Used [FV.X374]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? LEBaselineUsedCannotDecrease { get => _lEBaselineUsedCannotDecrease; set => SetField(ref _lEBaselineUsedCannotDecrease, value); }

        /// <summary>
        /// Cannot Increase - LE Baseline Used [FV.X375]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? LEBaselineUsedCannotIncrease { get => _lEBaselineUsedCannotIncrease; set => SetField(ref _lEBaselineUsedCannotIncrease, value); }

        /// <summary>
        /// Cannot Increase 10 - LE Baseline Used [FV.X376]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? LEBaselineUsedCannotIncrease10 { get => _lEBaselineUsedCannotIncrease10; set => SetField(ref _lEBaselineUsedCannotIncrease10, value); }

        /// <summary>
        /// LE Initial Disclosure Tracking Guid [FV.X385]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LEInitialDTGuid { get => _lEInitialDTGuid; set => SetField(ref _lEInitialDTGuid, value); }

        /// <summary>
        /// LE Initial Guid [FV.X356]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LEInitialGuid { get => _lEInitialGuid; set => SetField(ref _lEInitialGuid, value); }

        /// <summary>
        /// LE Initial Received Date Disclosure Tracking Guid [FV.X392]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LEInitialReceivedDateGuid { get => _lEInitialReceivedDateGuid; set => SetField(ref _lEInitialReceivedDateGuid, value); }

        /// <summary>
        /// LE Latest Guid [FV.X357]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LELatestGuid { get => _lELatestGuid; set => SetField(ref _lELatestGuid, value); }

        /// <summary>
        /// LE Revised Received Date Disclosure Tracking Guid [FV.X393]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LERevisedReceivedDateGuid { get => _lERevisedReceivedDateGuid; set => SetField(ref _lERevisedReceivedDateGuid, value); }

        /// <summary>
        /// LE Revised Sent Date Disclosure Tracking Guid [FV.X391]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LERevisedSentDateGuid { get => _lERevisedSentDateGuid; set => SetField(ref _lERevisedSentDateGuid, value); }

        /// <summary>
        /// Tolerance Cure Required Cure Amount [FV.X348]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? RequiredCureAmount { get => _requiredCureAmount; set => SetField(ref _requiredCureAmount, value); }

        /// <summary>
        /// Safe Harbor GUID [FV.X368]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string SafeHarborGuid { get => _safeHarborGuid; set => SetField(ref _safeHarborGuid, value); }

        /// <summary>
        /// Settlement Services Provider List GUID [FV.X369]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string SSPLGuid { get => _sSPLGuid; set => SetField(ref _sSPLGuid, value); }
    }
}