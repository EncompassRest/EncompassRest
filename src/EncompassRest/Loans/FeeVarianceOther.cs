using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class FeeVarianceOther
    {
        public Value<decimal?> AppliedCureAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppliedCureAmount() => !AppliedCureAmount.Clean;
        public Value<string> CannotDecreaseCDBaselineGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCannotDecreaseCDBaselineGuid() => !CannotDecreaseCDBaselineGuid.Clean;
        public Value<string> CannotDecreaseLEBaselineGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCannotDecreaseLEBaselineGuid() => !CannotDecreaseLEBaselineGuid.Clean;
        public Value<string> CannotIncrease10CDBaselineGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCannotIncrease10CDBaselineGuid() => !CannotIncrease10CDBaselineGuid.Clean;
        public Value<string> CannotIncrease10LEBaselineGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCannotIncrease10LEBaselineGuid() => !CannotIncrease10LEBaselineGuid.Clean;
        public Value<string> CannotIncreaseCDBaselineGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCannotIncreaseCDBaselineGuid() => !CannotIncreaseCDBaselineGuid.Clean;
        public Value<string> CannotIncreaseLEBaselineGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCannotIncreaseLEBaselineGuid() => !CannotIncreaseLEBaselineGuid.Clean;
        public Value<string> CDInitialGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDInitialGuid() => !CDInitialGuid.Clean;
        public Value<string> CDLatestGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDLatestGuid() => !CDLatestGuid.Clean;
        public Value<string> CDPostConGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDPostConGuid() => !CDPostConGuid.Clean;
        public Value<string> CDRecentAppliedCure { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDRecentAppliedCure() => !CDRecentAppliedCure.Clean;
        public Value<DateTime?> ChargesCannotIncrease10CD1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesCannotIncrease10CD1() => !ChargesCannotIncrease10CD1.Clean;
        public Value<DateTime?> ChargesCannotIncrease10InitialLE1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesCannotIncrease10InitialLE1() => !ChargesCannotIncrease10InitialLE1.Clean;
        public Value<DateTime?> ChargesCannotIncrease10LE1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesCannotIncrease10LE1() => !ChargesCannotIncrease10LE1.Clean;
        public Value<DateTime?> ChargesThatCanChangeCD1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesThatCanChangeCD1() => !ChargesThatCanChangeCD1.Clean;
        public Value<DateTime?> ChargesThatCanChangeInitialLE1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesThatCanChangeInitialLE1() => !ChargesThatCanChangeInitialLE1.Clean;
        public Value<DateTime?> ChargesThatCanChangeLE1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesThatCanChangeLE1() => !ChargesThatCanChangeLE1.Clean;
        public Value<DateTime?> ChargesThatCannotDecreaseCD1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesThatCannotDecreaseCD1() => !ChargesThatCannotDecreaseCD1.Clean;
        public Value<DateTime?> ChargesThatCannotDecreaseInitialLE1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesThatCannotDecreaseInitialLE1() => !ChargesThatCannotDecreaseInitialLE1.Clean;
        public Value<DateTime?> ChargesThatCannotDecreaseLE1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesThatCannotDecreaseLE1() => !ChargesThatCannotDecreaseLE1.Clean;
        public Value<DateTime?> ChargesThatCannotIncreaseCD1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesThatCannotIncreaseCD1() => !ChargesThatCannotIncreaseCD1.Clean;
        public Value<DateTime?> ChargesThatCannotIncreaseInitialLE1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesThatCannotIncreaseInitialLE1() => !ChargesThatCannotIncreaseInitialLE1.Clean;
        public Value<DateTime?> ChargesThatCannotIncreaseLE1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesThatCannotIncreaseLE1() => !ChargesThatCannotIncreaseLE1.Clean;
        public Value<string> DisclosureLogGUIDForECD { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureLogGUIDForECD() => !DisclosureLogGUIDForECD.Clean;
        public Value<DateTime?> GoodFaithAmountInitialLE1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGoodFaithAmountInitialLE1() => !GoodFaithAmountInitialLE1.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> LEBaselineUsedCannotDecrease { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEBaselineUsedCannotDecrease() => !LEBaselineUsedCannotDecrease.Clean;
        public Value<bool?> LEBaselineUsedCannotIncrease { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEBaselineUsedCannotIncrease() => !LEBaselineUsedCannotIncrease.Clean;
        public Value<bool?> LEBaselineUsedCannotIncrease10 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEBaselineUsedCannotIncrease10() => !LEBaselineUsedCannotIncrease10.Clean;
        public Value<string> LEInitialDTGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEInitialDTGuid() => !LEInitialDTGuid.Clean;
        public Value<string> LEInitialGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEInitialGuid() => !LEInitialGuid.Clean;
        public Value<string> LELatestGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLELatestGuid() => !LELatestGuid.Clean;
        public Value<decimal?> RequiredCureAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredCureAmount() => !RequiredCureAmount.Clean;
        public Value<string> SafeHarborGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSafeHarborGuid() => !SafeHarborGuid.Clean;
        public Value<string> SSPLGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSSPLGuid() => !SSPLGuid.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AppliedCureAmount.Clean
                    && CannotDecreaseCDBaselineGuid.Clean
                    && CannotDecreaseLEBaselineGuid.Clean
                    && CannotIncrease10CDBaselineGuid.Clean
                    && CannotIncrease10LEBaselineGuid.Clean
                    && CannotIncreaseCDBaselineGuid.Clean
                    && CannotIncreaseLEBaselineGuid.Clean
                    && CDInitialGuid.Clean
                    && CDLatestGuid.Clean
                    && CDPostConGuid.Clean
                    && CDRecentAppliedCure.Clean
                    && ChargesCannotIncrease10CD1.Clean
                    && ChargesCannotIncrease10InitialLE1.Clean
                    && ChargesCannotIncrease10LE1.Clean
                    && ChargesThatCanChangeCD1.Clean
                    && ChargesThatCanChangeInitialLE1.Clean
                    && ChargesThatCanChangeLE1.Clean
                    && ChargesThatCannotDecreaseCD1.Clean
                    && ChargesThatCannotDecreaseInitialLE1.Clean
                    && ChargesThatCannotDecreaseLE1.Clean
                    && ChargesThatCannotIncreaseCD1.Clean
                    && ChargesThatCannotIncreaseInitialLE1.Clean
                    && ChargesThatCannotIncreaseLE1.Clean
                    && DisclosureLogGUIDForECD.Clean
                    && GoodFaithAmountInitialLE1.Clean
                    && Id.Clean
                    && LEBaselineUsedCannotDecrease.Clean
                    && LEBaselineUsedCannotIncrease.Clean
                    && LEBaselineUsedCannotIncrease10.Clean
                    && LEInitialDTGuid.Clean
                    && LEInitialGuid.Clean
                    && LELatestGuid.Clean
                    && RequiredCureAmount.Clean
                    && SafeHarborGuid.Clean
                    && SSPLGuid.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AppliedCureAmount; v0.Clean = value; AppliedCureAmount = v0;
                var v1 = CannotDecreaseCDBaselineGuid; v1.Clean = value; CannotDecreaseCDBaselineGuid = v1;
                var v2 = CannotDecreaseLEBaselineGuid; v2.Clean = value; CannotDecreaseLEBaselineGuid = v2;
                var v3 = CannotIncrease10CDBaselineGuid; v3.Clean = value; CannotIncrease10CDBaselineGuid = v3;
                var v4 = CannotIncrease10LEBaselineGuid; v4.Clean = value; CannotIncrease10LEBaselineGuid = v4;
                var v5 = CannotIncreaseCDBaselineGuid; v5.Clean = value; CannotIncreaseCDBaselineGuid = v5;
                var v6 = CannotIncreaseLEBaselineGuid; v6.Clean = value; CannotIncreaseLEBaselineGuid = v6;
                var v7 = CDInitialGuid; v7.Clean = value; CDInitialGuid = v7;
                var v8 = CDLatestGuid; v8.Clean = value; CDLatestGuid = v8;
                var v9 = CDPostConGuid; v9.Clean = value; CDPostConGuid = v9;
                var v10 = CDRecentAppliedCure; v10.Clean = value; CDRecentAppliedCure = v10;
                var v11 = ChargesCannotIncrease10CD1; v11.Clean = value; ChargesCannotIncrease10CD1 = v11;
                var v12 = ChargesCannotIncrease10InitialLE1; v12.Clean = value; ChargesCannotIncrease10InitialLE1 = v12;
                var v13 = ChargesCannotIncrease10LE1; v13.Clean = value; ChargesCannotIncrease10LE1 = v13;
                var v14 = ChargesThatCanChangeCD1; v14.Clean = value; ChargesThatCanChangeCD1 = v14;
                var v15 = ChargesThatCanChangeInitialLE1; v15.Clean = value; ChargesThatCanChangeInitialLE1 = v15;
                var v16 = ChargesThatCanChangeLE1; v16.Clean = value; ChargesThatCanChangeLE1 = v16;
                var v17 = ChargesThatCannotDecreaseCD1; v17.Clean = value; ChargesThatCannotDecreaseCD1 = v17;
                var v18 = ChargesThatCannotDecreaseInitialLE1; v18.Clean = value; ChargesThatCannotDecreaseInitialLE1 = v18;
                var v19 = ChargesThatCannotDecreaseLE1; v19.Clean = value; ChargesThatCannotDecreaseLE1 = v19;
                var v20 = ChargesThatCannotIncreaseCD1; v20.Clean = value; ChargesThatCannotIncreaseCD1 = v20;
                var v21 = ChargesThatCannotIncreaseInitialLE1; v21.Clean = value; ChargesThatCannotIncreaseInitialLE1 = v21;
                var v22 = ChargesThatCannotIncreaseLE1; v22.Clean = value; ChargesThatCannotIncreaseLE1 = v22;
                var v23 = DisclosureLogGUIDForECD; v23.Clean = value; DisclosureLogGUIDForECD = v23;
                var v24 = GoodFaithAmountInitialLE1; v24.Clean = value; GoodFaithAmountInitialLE1 = v24;
                var v25 = Id; v25.Clean = value; Id = v25;
                var v26 = LEBaselineUsedCannotDecrease; v26.Clean = value; LEBaselineUsedCannotDecrease = v26;
                var v27 = LEBaselineUsedCannotIncrease; v27.Clean = value; LEBaselineUsedCannotIncrease = v27;
                var v28 = LEBaselineUsedCannotIncrease10; v28.Clean = value; LEBaselineUsedCannotIncrease10 = v28;
                var v29 = LEInitialDTGuid; v29.Clean = value; LEInitialDTGuid = v29;
                var v30 = LEInitialGuid; v30.Clean = value; LEInitialGuid = v30;
                var v31 = LELatestGuid; v31.Clean = value; LELatestGuid = v31;
                var v32 = RequiredCureAmount; v32.Clean = value; RequiredCureAmount = v32;
                var v33 = SafeHarborGuid; v33.Clean = value; SafeHarborGuid = v33;
                var v34 = SSPLGuid; v34.Clean = value; SSPLGuid = v34;
                _settingClean = 0;
            }
        }
    }
}