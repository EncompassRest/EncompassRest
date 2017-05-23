using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class FeeVarianceOther
    {
        public JsonNullable<decimal?> AppliedCureAmount { get; set; }
        public string CannotDecreaseCDBaselineGuid { get; set; }
        public string CannotDecreaseLEBaselineGuid { get; set; }
        public string CannotIncrease10CDBaselineGuid { get; set; }
        public string CannotIncrease10LEBaselineGuid { get; set; }
        public string CannotIncreaseCDBaselineGuid { get; set; }
        public string CannotIncreaseLEBaselineGuid { get; set; }
        public string CDInitialGuid { get; set; }
        public string CDLatestGuid { get; set; }
        public string CDPostConGuid { get; set; }
        public string CDRecentAppliedCure { get; set; }
        public JsonNullable<DateTime?> ChargesCannotIncrease10CD1 { get; set; }
        public JsonNullable<DateTime?> ChargesCannotIncrease10InitialLE1 { get; set; }
        public JsonNullable<DateTime?> ChargesCannotIncrease10LE1 { get; set; }
        public JsonNullable<DateTime?> ChargesThatCanChangeCD1 { get; set; }
        public JsonNullable<DateTime?> ChargesThatCanChangeInitialLE1 { get; set; }
        public JsonNullable<DateTime?> ChargesThatCanChangeLE1 { get; set; }
        public JsonNullable<DateTime?> ChargesThatCannotDecreaseCD1 { get; set; }
        public JsonNullable<DateTime?> ChargesThatCannotDecreaseInitialLE1 { get; set; }
        public JsonNullable<DateTime?> ChargesThatCannotDecreaseLE1 { get; set; }
        public JsonNullable<DateTime?> ChargesThatCannotIncreaseCD1 { get; set; }
        public JsonNullable<DateTime?> ChargesThatCannotIncreaseInitialLE1 { get; set; }
        public JsonNullable<DateTime?> ChargesThatCannotIncreaseLE1 { get; set; }
        public string DisclosureLogGUIDForECD { get; set; }
        public JsonNullable<DateTime?> GoodFaithAmountInitialLE1 { get; set; }
        public string Id { get; set; }
        public JsonNullable<bool?> LEBaselineUsedCannotDecrease { get; set; }
        public JsonNullable<bool?> LEBaselineUsedCannotIncrease { get; set; }
        public JsonNullable<bool?> LEBaselineUsedCannotIncrease10 { get; set; }
        public string LEInitialDTGuid { get; set; }
        public string LEInitialGuid { get; set; }
        public string LELatestGuid { get; set; }
        public JsonNullable<decimal?> RequiredCureAmount { get; set; }
        public string SafeHarborGuid { get; set; }
        public string SSPLGuid { get; set; }
    }
}