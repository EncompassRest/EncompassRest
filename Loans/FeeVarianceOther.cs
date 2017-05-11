using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class FeeVarianceOther
    {
        public DateTime? ChargesThatCannotDecreaseInitialLE1 { get; set; }
        public DateTime? ChargesThatCannotDecreaseLE1 { get; set; }
        public DateTime? ChargesThatCannotDecreaseCD1 { get; set; }
        public DateTime? ChargesThatCannotIncreaseInitialLE1 { get; set; }
        public DateTime? ChargesThatCannotIncreaseLE1 { get; set; }
        public DateTime? ChargesThatCannotIncreaseCD1 { get; set; }
        public DateTime? ChargesCannotIncrease10InitialLE1 { get; set; }
        public DateTime? ChargesCannotIncrease10LE1 { get; set; }
        public DateTime? ChargesCannotIncrease10CD1 { get; set; }
        public DateTime? ChargesThatCanChangeInitialLE1 { get; set; }
        public DateTime? ChargesThatCanChangeLE1 { get; set; }
        public DateTime? ChargesThatCanChangeCD1 { get; set; }
        public DateTime? GoodFaithAmountInitialLE1 { get; set; }
        public decimal? RequiredCureAmount { get; set; }
        public decimal? AppliedCureAmount { get; set; }
        public string LEInitialGuid { get; set; }
        public string LELatestGuid { get; set; }
        public string CDInitialGuid { get; set; }
        public string CDLatestGuid { get; set; }
        public string CannotDecreaseLEBaselineGuid { get; set; }
        public string CannotDecreaseCDBaselineGuid { get; set; }
        public string CannotIncreaseLEBaselineGuid { get; set; }
        public string CannotIncreaseCDBaselineGuid { get; set; }
        public string CannotIncrease10LEBaselineGuid { get; set; }
        public string CannotIncrease10CDBaselineGuid { get; set; }
        public bool? LEBaselineUsedCannotDecrease { get; set; }
        public bool? LEBaselineUsedCannotIncrease { get; set; }
        public bool? LEBaselineUsedCannotIncrease10 { get; set; }
        public string CDPostConGuid { get; set; }
        public string SafeHarborGuid { get; set; }
        public string LEInitialDTGuid { get; set; }
        public string CDRecentAppliedCure { get; set; }
        public string DisclosureLogGUIDForECD { get; set; }
        public string SSPLGuid { get; set; }
        public string Id { get; set; }
    }
}