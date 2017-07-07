using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDisclosure2 : IClean
    {
        private Value<decimal?> _borrowerClosingCostAtClosing;
        public decimal? BorrowerClosingCostAtClosing { get { return _borrowerClosingCostAtClosing; } set { _borrowerClosingCostAtClosing = value; } }
        private Value<decimal?> _borrowerClosingCostBeforeClosing;
        public decimal? BorrowerClosingCostBeforeClosing { get { return _borrowerClosingCostBeforeClosing; } set { _borrowerClosingCostBeforeClosing = value; } }
        private Value<decimal?> _closingCostLenderCredits;
        public decimal? ClosingCostLenderCredits { get { return _closingCostLenderCredits; } set { _closingCostLenderCredits = value; } }
        private Value<decimal?> _closingCostPaidByOthers;
        public decimal? ClosingCostPaidByOthers { get { return _closingCostPaidByOthers; } set { _closingCostPaidByOthers = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _initialEscrowSubTotal;
        public decimal? InitialEscrowSubTotal { get { return _initialEscrowSubTotal; } set { _initialEscrowSubTotal = value; } }
        private Value<decimal?> _lastDisclosedLenderCredits;
        public decimal? LastDisclosedLenderCredits { get { return _lastDisclosedLenderCredits; } set { _lastDisclosedLenderCredits = value; } }
        private Value<decimal?> _lastDisclosedLoanCosts;
        public decimal? LastDisclosedLoanCosts { get { return _lastDisclosedLoanCosts; } set { _lastDisclosedLoanCosts = value; } }
        private Value<decimal?> _lastDisclosedOtherCosts;
        public decimal? LastDisclosedOtherCosts { get { return _lastDisclosedOtherCosts; } set { _lastDisclosedOtherCosts = value; } }
        private Value<decimal?> _lCAtClosing;
        public decimal? LCAtClosing { get { return _lCAtClosing; } set { _lCAtClosing = value; } }
        private Value<decimal?> _originationChargesSubTotal;
        public decimal? OriginationChargesSubTotal { get { return _originationChargesSubTotal; } set { _originationChargesSubTotal = value; } }
        private Value<decimal?> _otherSubTotal;
        public decimal? OtherSubTotal { get { return _otherSubTotal; } set { _otherSubTotal = value; } }
        private Value<decimal?> _prepaidsSubTotal;
        public decimal? PrepaidsSubTotal { get { return _prepaidsSubTotal; } set { _prepaidsSubTotal = value; } }
        private Value<decimal?> _sellerClosingCostAtClosing;
        public decimal? SellerClosingCostAtClosing { get { return _sellerClosingCostAtClosing; } set { _sellerClosingCostAtClosing = value; } }
        private Value<decimal?> _sellerClosingCostBeforeClosing;
        public decimal? SellerClosingCostBeforeClosing { get { return _sellerClosingCostBeforeClosing; } set { _sellerClosingCostBeforeClosing = value; } }
        private Value<decimal?> _servicesDidNotShopSubTotal;
        public decimal? ServicesDidNotShopSubTotal { get { return _servicesDidNotShopSubTotal; } set { _servicesDidNotShopSubTotal = value; } }
        private Value<decimal?> _servicesDidShopSubTotal;
        public decimal? ServicesDidShopSubTotal { get { return _servicesDidShopSubTotal; } set { _servicesDidShopSubTotal = value; } }
        private Value<decimal?> _taxesGovermentFeesSubTotal;
        public decimal? TaxesGovermentFeesSubTotal { get { return _taxesGovermentFeesSubTotal; } set { _taxesGovermentFeesSubTotal = value; } }
        private Value<decimal?> _totalBorrowerPaidAtClosing;
        public decimal? TotalBorrowerPaidAtClosing { get { return _totalBorrowerPaidAtClosing; } set { _totalBorrowerPaidAtClosing = value; } }
        private Value<decimal?> _totalBorrowerPaidBeforeClosing;
        public decimal? TotalBorrowerPaidBeforeClosing { get { return _totalBorrowerPaidBeforeClosing; } set { _totalBorrowerPaidBeforeClosing = value; } }
        private Value<decimal?> _totalClosingCost;
        public decimal? TotalClosingCost { get { return _totalClosingCost; } set { _totalClosingCost = value; } }
        private Value<decimal?> _totalLoanCost;
        public decimal? TotalLoanCost { get { return _totalLoanCost; } set { _totalLoanCost = value; } }
        private Value<decimal?> _totalOtherCost;
        public decimal? TotalOtherCost { get { return _totalOtherCost; } set { _totalOtherCost = value; } }
        private Value<decimal?> _totalOtherCostAtClosing;
        public decimal? TotalOtherCostAtClosing { get { return _totalOtherCostAtClosing; } set { _totalOtherCostAtClosing = value; } }
        private Value<decimal?> _totalOtherCostBeforeClosing;
        public decimal? TotalOtherCostBeforeClosing { get { return _totalOtherCostBeforeClosing; } set { _totalOtherCostBeforeClosing = value; } }
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
                var borrowerClosingCostAtClosing = _borrowerClosingCostAtClosing; borrowerClosingCostAtClosing.Clean = value; _borrowerClosingCostAtClosing = borrowerClosingCostAtClosing;
                var borrowerClosingCostBeforeClosing = _borrowerClosingCostBeforeClosing; borrowerClosingCostBeforeClosing.Clean = value; _borrowerClosingCostBeforeClosing = borrowerClosingCostBeforeClosing;
                var closingCostLenderCredits = _closingCostLenderCredits; closingCostLenderCredits.Clean = value; _closingCostLenderCredits = closingCostLenderCredits;
                var closingCostPaidByOthers = _closingCostPaidByOthers; closingCostPaidByOthers.Clean = value; _closingCostPaidByOthers = closingCostPaidByOthers;
                var id = _id; id.Clean = value; _id = id;
                var initialEscrowSubTotal = _initialEscrowSubTotal; initialEscrowSubTotal.Clean = value; _initialEscrowSubTotal = initialEscrowSubTotal;
                var lastDisclosedLenderCredits = _lastDisclosedLenderCredits; lastDisclosedLenderCredits.Clean = value; _lastDisclosedLenderCredits = lastDisclosedLenderCredits;
                var lastDisclosedLoanCosts = _lastDisclosedLoanCosts; lastDisclosedLoanCosts.Clean = value; _lastDisclosedLoanCosts = lastDisclosedLoanCosts;
                var lastDisclosedOtherCosts = _lastDisclosedOtherCosts; lastDisclosedOtherCosts.Clean = value; _lastDisclosedOtherCosts = lastDisclosedOtherCosts;
                var lCAtClosing = _lCAtClosing; lCAtClosing.Clean = value; _lCAtClosing = lCAtClosing;
                var originationChargesSubTotal = _originationChargesSubTotal; originationChargesSubTotal.Clean = value; _originationChargesSubTotal = originationChargesSubTotal;
                var otherSubTotal = _otherSubTotal; otherSubTotal.Clean = value; _otherSubTotal = otherSubTotal;
                var prepaidsSubTotal = _prepaidsSubTotal; prepaidsSubTotal.Clean = value; _prepaidsSubTotal = prepaidsSubTotal;
                var sellerClosingCostAtClosing = _sellerClosingCostAtClosing; sellerClosingCostAtClosing.Clean = value; _sellerClosingCostAtClosing = sellerClosingCostAtClosing;
                var sellerClosingCostBeforeClosing = _sellerClosingCostBeforeClosing; sellerClosingCostBeforeClosing.Clean = value; _sellerClosingCostBeforeClosing = sellerClosingCostBeforeClosing;
                var servicesDidNotShopSubTotal = _servicesDidNotShopSubTotal; servicesDidNotShopSubTotal.Clean = value; _servicesDidNotShopSubTotal = servicesDidNotShopSubTotal;
                var servicesDidShopSubTotal = _servicesDidShopSubTotal; servicesDidShopSubTotal.Clean = value; _servicesDidShopSubTotal = servicesDidShopSubTotal;
                var taxesGovermentFeesSubTotal = _taxesGovermentFeesSubTotal; taxesGovermentFeesSubTotal.Clean = value; _taxesGovermentFeesSubTotal = taxesGovermentFeesSubTotal;
                var totalBorrowerPaidAtClosing = _totalBorrowerPaidAtClosing; totalBorrowerPaidAtClosing.Clean = value; _totalBorrowerPaidAtClosing = totalBorrowerPaidAtClosing;
                var totalBorrowerPaidBeforeClosing = _totalBorrowerPaidBeforeClosing; totalBorrowerPaidBeforeClosing.Clean = value; _totalBorrowerPaidBeforeClosing = totalBorrowerPaidBeforeClosing;
                var totalClosingCost = _totalClosingCost; totalClosingCost.Clean = value; _totalClosingCost = totalClosingCost;
                var totalLoanCost = _totalLoanCost; totalLoanCost.Clean = value; _totalLoanCost = totalLoanCost;
                var totalOtherCost = _totalOtherCost; totalOtherCost.Clean = value; _totalOtherCost = totalOtherCost;
                var totalOtherCostAtClosing = _totalOtherCostAtClosing; totalOtherCostAtClosing.Clean = value; _totalOtherCostAtClosing = totalOtherCostAtClosing;
                var totalOtherCostBeforeClosing = _totalOtherCostBeforeClosing; totalOtherCostBeforeClosing.Clean = value; _totalOtherCostBeforeClosing = totalOtherCostBeforeClosing;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public ClosingDisclosure2()
        {
            Clean = true;
        }
    }
}