using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDisclosure2
    {
        private Value<decimal?> _borrowerClosingCostAtClosing;
        public decimal? BorrowerClosingCostAtClosing { get { return _borrowerClosingCostAtClosing; } set { _borrowerClosingCostAtClosing = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerClosingCostAtClosing() => !_borrowerClosingCostAtClosing.Clean;
        private Value<decimal?> _borrowerClosingCostBeforeClosing;
        public decimal? BorrowerClosingCostBeforeClosing { get { return _borrowerClosingCostBeforeClosing; } set { _borrowerClosingCostBeforeClosing = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerClosingCostBeforeClosing() => !_borrowerClosingCostBeforeClosing.Clean;
        private Value<decimal?> _closingCostLenderCredits;
        public decimal? ClosingCostLenderCredits { get { return _closingCostLenderCredits; } set { _closingCostLenderCredits = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostLenderCredits() => !_closingCostLenderCredits.Clean;
        private Value<decimal?> _closingCostPaidByOthers;
        public decimal? ClosingCostPaidByOthers { get { return _closingCostPaidByOthers; } set { _closingCostPaidByOthers = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostPaidByOthers() => !_closingCostPaidByOthers.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<decimal?> _initialEscrowSubTotal;
        public decimal? InitialEscrowSubTotal { get { return _initialEscrowSubTotal; } set { _initialEscrowSubTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialEscrowSubTotal() => !_initialEscrowSubTotal.Clean;
        private Value<decimal?> _lastDisclosedLenderCredits;
        public decimal? LastDisclosedLenderCredits { get { return _lastDisclosedLenderCredits; } set { _lastDisclosedLenderCredits = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastDisclosedLenderCredits() => !_lastDisclosedLenderCredits.Clean;
        private Value<decimal?> _lastDisclosedLoanCosts;
        public decimal? LastDisclosedLoanCosts { get { return _lastDisclosedLoanCosts; } set { _lastDisclosedLoanCosts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastDisclosedLoanCosts() => !_lastDisclosedLoanCosts.Clean;
        private Value<decimal?> _lastDisclosedOtherCosts;
        public decimal? LastDisclosedOtherCosts { get { return _lastDisclosedOtherCosts; } set { _lastDisclosedOtherCosts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastDisclosedOtherCosts() => !_lastDisclosedOtherCosts.Clean;
        private Value<decimal?> _lCAtClosing;
        public decimal? LCAtClosing { get { return _lCAtClosing; } set { _lCAtClosing = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLCAtClosing() => !_lCAtClosing.Clean;
        private Value<decimal?> _originationChargesSubTotal;
        public decimal? OriginationChargesSubTotal { get { return _originationChargesSubTotal; } set { _originationChargesSubTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationChargesSubTotal() => !_originationChargesSubTotal.Clean;
        private Value<decimal?> _otherSubTotal;
        public decimal? OtherSubTotal { get { return _otherSubTotal; } set { _otherSubTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherSubTotal() => !_otherSubTotal.Clean;
        private Value<decimal?> _prepaidsSubTotal;
        public decimal? PrepaidsSubTotal { get { return _prepaidsSubTotal; } set { _prepaidsSubTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaidsSubTotal() => !_prepaidsSubTotal.Clean;
        private Value<decimal?> _sellerClosingCostAtClosing;
        public decimal? SellerClosingCostAtClosing { get { return _sellerClosingCostAtClosing; } set { _sellerClosingCostAtClosing = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerClosingCostAtClosing() => !_sellerClosingCostAtClosing.Clean;
        private Value<decimal?> _sellerClosingCostBeforeClosing;
        public decimal? SellerClosingCostBeforeClosing { get { return _sellerClosingCostBeforeClosing; } set { _sellerClosingCostBeforeClosing = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerClosingCostBeforeClosing() => !_sellerClosingCostBeforeClosing.Clean;
        private Value<decimal?> _servicesDidNotShopSubTotal;
        public decimal? ServicesDidNotShopSubTotal { get { return _servicesDidNotShopSubTotal; } set { _servicesDidNotShopSubTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicesDidNotShopSubTotal() => !_servicesDidNotShopSubTotal.Clean;
        private Value<decimal?> _servicesDidShopSubTotal;
        public decimal? ServicesDidShopSubTotal { get { return _servicesDidShopSubTotal; } set { _servicesDidShopSubTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicesDidShopSubTotal() => !_servicesDidShopSubTotal.Clean;
        private Value<decimal?> _taxesGovermentFeesSubTotal;
        public decimal? TaxesGovermentFeesSubTotal { get { return _taxesGovermentFeesSubTotal; } set { _taxesGovermentFeesSubTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxesGovermentFeesSubTotal() => !_taxesGovermentFeesSubTotal.Clean;
        private Value<decimal?> _totalBorrowerPaidAtClosing;
        public decimal? TotalBorrowerPaidAtClosing { get { return _totalBorrowerPaidAtClosing; } set { _totalBorrowerPaidAtClosing = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBorrowerPaidAtClosing() => !_totalBorrowerPaidAtClosing.Clean;
        private Value<decimal?> _totalBorrowerPaidBeforeClosing;
        public decimal? TotalBorrowerPaidBeforeClosing { get { return _totalBorrowerPaidBeforeClosing; } set { _totalBorrowerPaidBeforeClosing = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBorrowerPaidBeforeClosing() => !_totalBorrowerPaidBeforeClosing.Clean;
        private Value<decimal?> _totalClosingCost;
        public decimal? TotalClosingCost { get { return _totalClosingCost; } set { _totalClosingCost = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalClosingCost() => !_totalClosingCost.Clean;
        private Value<decimal?> _totalLoanCost;
        public decimal? TotalLoanCost { get { return _totalLoanCost; } set { _totalLoanCost = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalLoanCost() => !_totalLoanCost.Clean;
        private Value<decimal?> _totalOtherCost;
        public decimal? TotalOtherCost { get { return _totalOtherCost; } set { _totalOtherCost = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOtherCost() => !_totalOtherCost.Clean;
        private Value<decimal?> _totalOtherCostAtClosing;
        public decimal? TotalOtherCostAtClosing { get { return _totalOtherCostAtClosing; } set { _totalOtherCostAtClosing = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOtherCostAtClosing() => !_totalOtherCostAtClosing.Clean;
        private Value<decimal?> _totalOtherCostBeforeClosing;
        public decimal? TotalOtherCostBeforeClosing { get { return _totalOtherCostBeforeClosing; } set { _totalOtherCostBeforeClosing = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOtherCostBeforeClosing() => !_totalOtherCostBeforeClosing.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _borrowerClosingCostAtClosing.Clean
                    && _borrowerClosingCostBeforeClosing.Clean
                    && _closingCostLenderCredits.Clean
                    && _closingCostPaidByOthers.Clean
                    && _id.Clean
                    && _initialEscrowSubTotal.Clean
                    && _lastDisclosedLenderCredits.Clean
                    && _lastDisclosedLoanCosts.Clean
                    && _lastDisclosedOtherCosts.Clean
                    && _lCAtClosing.Clean
                    && _originationChargesSubTotal.Clean
                    && _otherSubTotal.Clean
                    && _prepaidsSubTotal.Clean
                    && _sellerClosingCostAtClosing.Clean
                    && _sellerClosingCostBeforeClosing.Clean
                    && _servicesDidNotShopSubTotal.Clean
                    && _servicesDidShopSubTotal.Clean
                    && _taxesGovermentFeesSubTotal.Clean
                    && _totalBorrowerPaidAtClosing.Clean
                    && _totalBorrowerPaidBeforeClosing.Clean
                    && _totalClosingCost.Clean
                    && _totalLoanCost.Clean
                    && _totalOtherCost.Clean
                    && _totalOtherCostAtClosing.Clean
                    && _totalOtherCostBeforeClosing.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _borrowerClosingCostAtClosing; v0.Clean = value; _borrowerClosingCostAtClosing = v0;
                var v1 = _borrowerClosingCostBeforeClosing; v1.Clean = value; _borrowerClosingCostBeforeClosing = v1;
                var v2 = _closingCostLenderCredits; v2.Clean = value; _closingCostLenderCredits = v2;
                var v3 = _closingCostPaidByOthers; v3.Clean = value; _closingCostPaidByOthers = v3;
                var v4 = _id; v4.Clean = value; _id = v4;
                var v5 = _initialEscrowSubTotal; v5.Clean = value; _initialEscrowSubTotal = v5;
                var v6 = _lastDisclosedLenderCredits; v6.Clean = value; _lastDisclosedLenderCredits = v6;
                var v7 = _lastDisclosedLoanCosts; v7.Clean = value; _lastDisclosedLoanCosts = v7;
                var v8 = _lastDisclosedOtherCosts; v8.Clean = value; _lastDisclosedOtherCosts = v8;
                var v9 = _lCAtClosing; v9.Clean = value; _lCAtClosing = v9;
                var v10 = _originationChargesSubTotal; v10.Clean = value; _originationChargesSubTotal = v10;
                var v11 = _otherSubTotal; v11.Clean = value; _otherSubTotal = v11;
                var v12 = _prepaidsSubTotal; v12.Clean = value; _prepaidsSubTotal = v12;
                var v13 = _sellerClosingCostAtClosing; v13.Clean = value; _sellerClosingCostAtClosing = v13;
                var v14 = _sellerClosingCostBeforeClosing; v14.Clean = value; _sellerClosingCostBeforeClosing = v14;
                var v15 = _servicesDidNotShopSubTotal; v15.Clean = value; _servicesDidNotShopSubTotal = v15;
                var v16 = _servicesDidShopSubTotal; v16.Clean = value; _servicesDidShopSubTotal = v16;
                var v17 = _taxesGovermentFeesSubTotal; v17.Clean = value; _taxesGovermentFeesSubTotal = v17;
                var v18 = _totalBorrowerPaidAtClosing; v18.Clean = value; _totalBorrowerPaidAtClosing = v18;
                var v19 = _totalBorrowerPaidBeforeClosing; v19.Clean = value; _totalBorrowerPaidBeforeClosing = v19;
                var v20 = _totalClosingCost; v20.Clean = value; _totalClosingCost = v20;
                var v21 = _totalLoanCost; v21.Clean = value; _totalLoanCost = v21;
                var v22 = _totalOtherCost; v22.Clean = value; _totalOtherCost = v22;
                var v23 = _totalOtherCostAtClosing; v23.Clean = value; _totalOtherCostAtClosing = v23;
                var v24 = _totalOtherCostBeforeClosing; v24.Clean = value; _totalOtherCostBeforeClosing = v24;
                _settingClean = 0;
            }
        }
    }
}