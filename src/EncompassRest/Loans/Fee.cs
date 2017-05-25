using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

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
        private Value<decimal?> _newHUDBorPaidAmount;
        public decimal? NewHUDBorPaidAmount { get { return _newHUDBorPaidAmount; } set { _newHUDBorPaidAmount = value; } }
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
                var v0 = _amount; v0.Clean = value; _amount = v0;
                var v1 = _amountPerDay; v1.Clean = value; _amountPerDay = v1;
                var v2 = _borPaidAmount; v2.Clean = value; _borPaidAmount = v2;
                var v3 = _dateFrom; v3.Clean = value; _dateFrom = v3;
                var v4 = _dateTo; v4.Clean = value; _dateTo = v4;
                var v5 = _days; v5.Clean = value; _days = v5;
                var v6 = _deedAmount; v6.Clean = value; _deedAmount = v6;
                var v7 = _description; v7.Clean = value; _description = v7;
                var v8 = _feeType; v8.Clean = value; _feeType = v8;
                var v9 = _fHA; v9.Clean = value; _fHA = v9;
                var v10 = _fWBC; v10.Clean = value; _fWBC = v10;
                var v11 = _fWSC; v11.Clean = value; _fWSC = v11;
                var v12 = _id; v12.Clean = value; _id = v12;
                var v13 = _includeAboveNumber; v13.Clean = value; _includeAboveNumber = v13;
                var v14 = _lenderCoverage; v14.Clean = value; _lenderCoverage = v14;
                var v15 = _monthlyPayment; v15.Clean = value; _monthlyPayment = v15;
                var v16 = _mortgageAmount; v16.Clean = value; _mortgageAmount = v16;
                var v17 = _newHUDBorPaidAmount; v17.Clean = value; _newHUDBorPaidAmount = v17;
                var v18 = _numberOfMonths; v18.Clean = value; _numberOfMonths = v18;
                var v19 = _ownerCoverage; v19.Clean = value; _ownerCoverage = v19;
                var v20 = _paidBy; v20.Clean = value; _paidBy = v20;
                var v21 = _paidInAdvance; v21.Clean = value; _paidInAdvance = v21;
                var v22 = _paidToBroker; v22.Clean = value; _paidToBroker = v22;
                var v23 = _paidToName; v23.Clean = value; _paidToName = v23;
                var v24 = _paidToOthers; v24.Clean = value; _paidToOthers = v24;
                var v25 = _percentage; v25.Clean = value; _percentage = v25;
                var v26 = _pFC; v26.Clean = value; _pFC = v26;
                var v27 = _pOC; v27.Clean = value; _pOC = v27;
                var v28 = _pTB; v28.Clean = value; _pTB = v28;
                var v29 = _releasesAmount; v29.Clean = value; _releasesAmount = v29;
                var v30 = _sellerPaidAmount; v30.Clean = value; _sellerPaidAmount = v30;
                var v31 = _truncatedAmountPerDay; v31.Clean = value; _truncatedAmountPerDay = v31;
                var v32 = _use4Decimals; v32.Clean = value; _use4Decimals = v32;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}