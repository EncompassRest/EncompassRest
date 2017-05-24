using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDisclosure2
    {
        public Value<decimal?> BorrowerClosingCostAtClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerClosingCostAtClosing() => !BorrowerClosingCostAtClosing.Clean;
        public Value<decimal?> BorrowerClosingCostBeforeClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerClosingCostBeforeClosing() => !BorrowerClosingCostBeforeClosing.Clean;
        public Value<decimal?> ClosingCostLenderCredits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostLenderCredits() => !ClosingCostLenderCredits.Clean;
        public Value<decimal?> ClosingCostPaidByOthers { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostPaidByOthers() => !ClosingCostPaidByOthers.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> InitialEscrowSubTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialEscrowSubTotal() => !InitialEscrowSubTotal.Clean;
        public Value<decimal?> LastDisclosedLenderCredits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastDisclosedLenderCredits() => !LastDisclosedLenderCredits.Clean;
        public Value<decimal?> LastDisclosedLoanCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastDisclosedLoanCosts() => !LastDisclosedLoanCosts.Clean;
        public Value<decimal?> LastDisclosedOtherCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastDisclosedOtherCosts() => !LastDisclosedOtherCosts.Clean;
        public Value<decimal?> LCAtClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLCAtClosing() => !LCAtClosing.Clean;
        public Value<decimal?> OriginationChargesSubTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationChargesSubTotal() => !OriginationChargesSubTotal.Clean;
        public Value<decimal?> OtherSubTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherSubTotal() => !OtherSubTotal.Clean;
        public Value<decimal?> PrepaidsSubTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaidsSubTotal() => !PrepaidsSubTotal.Clean;
        public Value<decimal?> SellerClosingCostAtClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerClosingCostAtClosing() => !SellerClosingCostAtClosing.Clean;
        public Value<decimal?> SellerClosingCostBeforeClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerClosingCostBeforeClosing() => !SellerClosingCostBeforeClosing.Clean;
        public Value<decimal?> ServicesDidNotShopSubTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicesDidNotShopSubTotal() => !ServicesDidNotShopSubTotal.Clean;
        public Value<decimal?> ServicesDidShopSubTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicesDidShopSubTotal() => !ServicesDidShopSubTotal.Clean;
        public Value<decimal?> TaxesGovermentFeesSubTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxesGovermentFeesSubTotal() => !TaxesGovermentFeesSubTotal.Clean;
        public Value<decimal?> TotalBorrowerPaidAtClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBorrowerPaidAtClosing() => !TotalBorrowerPaidAtClosing.Clean;
        public Value<decimal?> TotalBorrowerPaidBeforeClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBorrowerPaidBeforeClosing() => !TotalBorrowerPaidBeforeClosing.Clean;
        public Value<decimal?> TotalClosingCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalClosingCost() => !TotalClosingCost.Clean;
        public Value<decimal?> TotalLoanCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalLoanCost() => !TotalLoanCost.Clean;
        public Value<decimal?> TotalOtherCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOtherCost() => !TotalOtherCost.Clean;
        public Value<decimal?> TotalOtherCostAtClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOtherCostAtClosing() => !TotalOtherCostAtClosing.Clean;
        public Value<decimal?> TotalOtherCostBeforeClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOtherCostBeforeClosing() => !TotalOtherCostBeforeClosing.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = BorrowerClosingCostAtClosing.Clean
                    && BorrowerClosingCostBeforeClosing.Clean
                    && ClosingCostLenderCredits.Clean
                    && ClosingCostPaidByOthers.Clean
                    && Id.Clean
                    && InitialEscrowSubTotal.Clean
                    && LastDisclosedLenderCredits.Clean
                    && LastDisclosedLoanCosts.Clean
                    && LastDisclosedOtherCosts.Clean
                    && LCAtClosing.Clean
                    && OriginationChargesSubTotal.Clean
                    && OtherSubTotal.Clean
                    && PrepaidsSubTotal.Clean
                    && SellerClosingCostAtClosing.Clean
                    && SellerClosingCostBeforeClosing.Clean
                    && ServicesDidNotShopSubTotal.Clean
                    && ServicesDidShopSubTotal.Clean
                    && TaxesGovermentFeesSubTotal.Clean
                    && TotalBorrowerPaidAtClosing.Clean
                    && TotalBorrowerPaidBeforeClosing.Clean
                    && TotalClosingCost.Clean
                    && TotalLoanCost.Clean
                    && TotalOtherCost.Clean
                    && TotalOtherCostAtClosing.Clean
                    && TotalOtherCostBeforeClosing.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = BorrowerClosingCostAtClosing; v0.Clean = value; BorrowerClosingCostAtClosing = v0;
                var v1 = BorrowerClosingCostBeforeClosing; v1.Clean = value; BorrowerClosingCostBeforeClosing = v1;
                var v2 = ClosingCostLenderCredits; v2.Clean = value; ClosingCostLenderCredits = v2;
                var v3 = ClosingCostPaidByOthers; v3.Clean = value; ClosingCostPaidByOthers = v3;
                var v4 = Id; v4.Clean = value; Id = v4;
                var v5 = InitialEscrowSubTotal; v5.Clean = value; InitialEscrowSubTotal = v5;
                var v6 = LastDisclosedLenderCredits; v6.Clean = value; LastDisclosedLenderCredits = v6;
                var v7 = LastDisclosedLoanCosts; v7.Clean = value; LastDisclosedLoanCosts = v7;
                var v8 = LastDisclosedOtherCosts; v8.Clean = value; LastDisclosedOtherCosts = v8;
                var v9 = LCAtClosing; v9.Clean = value; LCAtClosing = v9;
                var v10 = OriginationChargesSubTotal; v10.Clean = value; OriginationChargesSubTotal = v10;
                var v11 = OtherSubTotal; v11.Clean = value; OtherSubTotal = v11;
                var v12 = PrepaidsSubTotal; v12.Clean = value; PrepaidsSubTotal = v12;
                var v13 = SellerClosingCostAtClosing; v13.Clean = value; SellerClosingCostAtClosing = v13;
                var v14 = SellerClosingCostBeforeClosing; v14.Clean = value; SellerClosingCostBeforeClosing = v14;
                var v15 = ServicesDidNotShopSubTotal; v15.Clean = value; ServicesDidNotShopSubTotal = v15;
                var v16 = ServicesDidShopSubTotal; v16.Clean = value; ServicesDidShopSubTotal = v16;
                var v17 = TaxesGovermentFeesSubTotal; v17.Clean = value; TaxesGovermentFeesSubTotal = v17;
                var v18 = TotalBorrowerPaidAtClosing; v18.Clean = value; TotalBorrowerPaidAtClosing = v18;
                var v19 = TotalBorrowerPaidBeforeClosing; v19.Clean = value; TotalBorrowerPaidBeforeClosing = v19;
                var v20 = TotalClosingCost; v20.Clean = value; TotalClosingCost = v20;
                var v21 = TotalLoanCost; v21.Clean = value; TotalLoanCost = v21;
                var v22 = TotalOtherCost; v22.Clean = value; TotalOtherCost = v22;
                var v23 = TotalOtherCostAtClosing; v23.Clean = value; TotalOtherCostAtClosing = v23;
                var v24 = TotalOtherCostBeforeClosing; v24.Clean = value; TotalOtherCostBeforeClosing = v24;
                _settingClean = 0;
            }
        }
    }
}