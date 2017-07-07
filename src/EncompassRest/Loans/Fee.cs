using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Fee : IClean
    {
        private Value<decimal?> _amount;
        public decimal? Amount { get { return _amount; } set { _amount = value; } }
        private Value<decimal?> _amountPerDay;
        public decimal? AmountPerDay { get { return _amountPerDay; } set { _amountPerDay = value; } }
        private Value<decimal?> _borPaidAmount;
        public decimal? BorPaidAmount { get { return _borPaidAmount; } set { _borPaidAmount = value; } }
        private Value<DateTime?> _dateFrom;
        public DateTime? DateFrom { get { return _dateFrom; } set { _dateFrom = value; } }
        private Value<DateTime?> _dateTo;
        public DateTime? DateTo { get { return _dateTo; } set { _dateTo = value; } }
        private Value<int?> _days;
        public int? Days { get { return _days; } set { _days = value; } }
        private Value<decimal?> _deedAmount;
        public decimal? DeedAmount { get { return _deedAmount; } set { _deedAmount = value; } }
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private Value<string> _feeType;
        public string FeeType { get { return _feeType; } set { _feeType = value; } }
        private Value<bool?> _fHA;
        public bool? FHA { get { return _fHA; } set { _fHA = value; } }
        private Value<string> _fWBC;
        public string FWBC { get { return _fWBC; } set { _fWBC = value; } }
        private Value<string> _fWSC;
        public string FWSC { get { return _fWSC; } set { _fWSC = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _includeAboveNumber;
        public string IncludeAboveNumber { get { return _includeAboveNumber; } set { _includeAboveNumber = value; } }
        private Value<decimal?> _lenderCoverage;
        public decimal? LenderCoverage { get { return _lenderCoverage; } set { _lenderCoverage = value; } }
        private Value<decimal?> _monthlyPayment;
        public decimal? MonthlyPayment { get { return _monthlyPayment; } set { _monthlyPayment = value; } }
        private Value<decimal?> _mortgageAmount;
        public decimal? MortgageAmount { get { return _mortgageAmount; } set { _mortgageAmount = value; } }
        private Value<NA<decimal>?> _newHUDBorPaidAmount;
        public NA<decimal>? NewHUDBorPaidAmount { get { return _newHUDBorPaidAmount; } set { _newHUDBorPaidAmount = value; } }
        private Value<int?> _numberOfMonths;
        public int? NumberOfMonths { get { return _numberOfMonths; } set { _numberOfMonths = value; } }
        private Value<decimal?> _ownerCoverage;
        public decimal? OwnerCoverage { get { return _ownerCoverage; } set { _ownerCoverage = value; } }
        private Value<string> _paidBy;
        public string PaidBy { get { return _paidBy; } set { _paidBy = value; } }
        private Value<decimal?> _paidInAdvance;
        public decimal? PaidInAdvance { get { return _paidInAdvance; } set { _paidInAdvance = value; } }
        private Value<decimal?> _paidToBroker;
        public decimal? PaidToBroker { get { return _paidToBroker; } set { _paidToBroker = value; } }
        private Value<string> _paidToName;
        public string PaidToName { get { return _paidToName; } set { _paidToName = value; } }
        private Value<decimal?> _paidToOthers;
        public decimal? PaidToOthers { get { return _paidToOthers; } set { _paidToOthers = value; } }
        private Value<decimal?> _percentage;
        public decimal? Percentage { get { return _percentage; } set { _percentage = value; } }
        private Value<bool?> _pFC;
        public bool? PFC { get { return _pFC; } set { _pFC = value; } }
        private Value<bool?> _pOC;
        public bool? POC { get { return _pOC; } set { _pOC = value; } }
        private Value<string> _pTB;
        public string PTB { get { return _pTB; } set { _pTB = value; } }
        private Value<decimal?> _releasesAmount;
        public decimal? ReleasesAmount { get { return _releasesAmount; } set { _releasesAmount = value; } }
        private Value<decimal?> _sellerPaidAmount;
        public decimal? SellerPaidAmount { get { return _sellerPaidAmount; } set { _sellerPaidAmount = value; } }
        private Value<decimal?> _truncatedAmountPerDay;
        public decimal? TruncatedAmountPerDay { get { return _truncatedAmountPerDay; } set { _truncatedAmountPerDay = value; } }
        private Value<bool?> _use4Decimals;
        public bool? Use4Decimals { get { return _use4Decimals; } set { _use4Decimals = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _amount.Clean
                    && _amountPerDay.Clean
                    && _borPaidAmount.Clean
                    && _dateFrom.Clean
                    && _dateTo.Clean
                    && _days.Clean
                    && _deedAmount.Clean
                    && _description.Clean
                    && _feeType.Clean
                    && _fHA.Clean
                    && _fWBC.Clean
                    && _fWSC.Clean
                    && _id.Clean
                    && _includeAboveNumber.Clean
                    && _lenderCoverage.Clean
                    && _monthlyPayment.Clean
                    && _mortgageAmount.Clean
                    && _newHUDBorPaidAmount.Clean
                    && _numberOfMonths.Clean
                    && _ownerCoverage.Clean
                    && _paidBy.Clean
                    && _paidInAdvance.Clean
                    && _paidToBroker.Clean
                    && _paidToName.Clean
                    && _paidToOthers.Clean
                    && _percentage.Clean
                    && _pFC.Clean
                    && _pOC.Clean
                    && _pTB.Clean
                    && _releasesAmount.Clean
                    && _sellerPaidAmount.Clean
                    && _truncatedAmountPerDay.Clean
                    && _use4Decimals.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var amount = _amount; amount.Clean = value; _amount = amount;
                var amountPerDay = _amountPerDay; amountPerDay.Clean = value; _amountPerDay = amountPerDay;
                var borPaidAmount = _borPaidAmount; borPaidAmount.Clean = value; _borPaidAmount = borPaidAmount;
                var dateFrom = _dateFrom; dateFrom.Clean = value; _dateFrom = dateFrom;
                var dateTo = _dateTo; dateTo.Clean = value; _dateTo = dateTo;
                var days = _days; days.Clean = value; _days = days;
                var deedAmount = _deedAmount; deedAmount.Clean = value; _deedAmount = deedAmount;
                var description = _description; description.Clean = value; _description = description;
                var feeType = _feeType; feeType.Clean = value; _feeType = feeType;
                var fHA = _fHA; fHA.Clean = value; _fHA = fHA;
                var fWBC = _fWBC; fWBC.Clean = value; _fWBC = fWBC;
                var fWSC = _fWSC; fWSC.Clean = value; _fWSC = fWSC;
                var id = _id; id.Clean = value; _id = id;
                var includeAboveNumber = _includeAboveNumber; includeAboveNumber.Clean = value; _includeAboveNumber = includeAboveNumber;
                var lenderCoverage = _lenderCoverage; lenderCoverage.Clean = value; _lenderCoverage = lenderCoverage;
                var monthlyPayment = _monthlyPayment; monthlyPayment.Clean = value; _monthlyPayment = monthlyPayment;
                var mortgageAmount = _mortgageAmount; mortgageAmount.Clean = value; _mortgageAmount = mortgageAmount;
                var newHUDBorPaidAmount = _newHUDBorPaidAmount; newHUDBorPaidAmount.Clean = value; _newHUDBorPaidAmount = newHUDBorPaidAmount;
                var numberOfMonths = _numberOfMonths; numberOfMonths.Clean = value; _numberOfMonths = numberOfMonths;
                var ownerCoverage = _ownerCoverage; ownerCoverage.Clean = value; _ownerCoverage = ownerCoverage;
                var paidBy = _paidBy; paidBy.Clean = value; _paidBy = paidBy;
                var paidInAdvance = _paidInAdvance; paidInAdvance.Clean = value; _paidInAdvance = paidInAdvance;
                var paidToBroker = _paidToBroker; paidToBroker.Clean = value; _paidToBroker = paidToBroker;
                var paidToName = _paidToName; paidToName.Clean = value; _paidToName = paidToName;
                var paidToOthers = _paidToOthers; paidToOthers.Clean = value; _paidToOthers = paidToOthers;
                var percentage = _percentage; percentage.Clean = value; _percentage = percentage;
                var pFC = _pFC; pFC.Clean = value; _pFC = pFC;
                var pOC = _pOC; pOC.Clean = value; _pOC = pOC;
                var pTB = _pTB; pTB.Clean = value; _pTB = pTB;
                var releasesAmount = _releasesAmount; releasesAmount.Clean = value; _releasesAmount = releasesAmount;
                var sellerPaidAmount = _sellerPaidAmount; sellerPaidAmount.Clean = value; _sellerPaidAmount = sellerPaidAmount;
                var truncatedAmountPerDay = _truncatedAmountPerDay; truncatedAmountPerDay.Clean = value; _truncatedAmountPerDay = truncatedAmountPerDay;
                var use4Decimals = _use4Decimals; use4Decimals.Clean = value; _use4Decimals = use4Decimals;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Fee()
        {
            Clean = true;
        }
    }
}