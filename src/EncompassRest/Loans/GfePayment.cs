using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class GfePayment : IClean
    {
        private Value<decimal?> _fixedRate;
        public decimal? FixedRate { get { return _fixedRate; } set { _fixedRate = value; } }
        private Value<int?> _gfePaymentIndex;
        public int? GfePaymentIndex { get { return _gfePaymentIndex; } set { _gfePaymentIndex = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _indexRate;
        public decimal? IndexRate { get { return _indexRate; } set { _indexRate = value; } }
        private Value<string> _isBalanceReduced;
        public string IsBalanceReduced { get { return _isBalanceReduced; } set { _isBalanceReduced = value; } }
        private Value<string> _loanTypeExplanation;
        public string LoanTypeExplanation { get { return _loanTypeExplanation; } set { _loanTypeExplanation = value; } }
        private Value<decimal?> _marginRate;
        public decimal? MarginRate { get { return _marginRate; } set { _marginRate = value; } }
        private Value<decimal?> _maximumDifference;
        public decimal? MaximumDifference { get { return _maximumDifference; } set { _maximumDifference = value; } }
        private Value<decimal?> _maximumRate;
        public decimal? MaximumRate { get { return _maximumRate; } set { _maximumRate = value; } }
        private Value<decimal?> _minimumDifference;
        public decimal? MinimumDifference { get { return _minimumDifference; } set { _minimumDifference = value; } }
        private Value<decimal?> _minimumMonthlyPayment;
        public decimal? MinimumMonthlyPayment { get { return _minimumMonthlyPayment; } set { _minimumMonthlyPayment = value; } }
        private Value<decimal?> _monthlyPaymentYear1;
        public decimal? MonthlyPaymentYear1 { get { return _monthlyPaymentYear1; } set { _monthlyPaymentYear1 = value; } }
        private Value<decimal?> _monthlyPaymentYear6;
        public decimal? MonthlyPaymentYear6 { get { return _monthlyPaymentYear6; } set { _monthlyPaymentYear6 = value; } }
        private Value<decimal?> _monthlyPaymentYear6Change;
        public decimal? MonthlyPaymentYear6Change { get { return _monthlyPaymentYear6Change; } set { _monthlyPaymentYear6Change = value; } }
        private Value<decimal?> _monthlyPaymentYear6MaxChange;
        public decimal? MonthlyPaymentYear6MaxChange { get { return _monthlyPaymentYear6MaxChange; } set { _monthlyPaymentYear6MaxChange = value; } }
        private Value<bool?> _notOfferedIndicator;
        public bool? NotOfferedIndicator { get { return _notOfferedIndicator; } set { _notOfferedIndicator = value; } }
        private Value<decimal?> _owedAfter5Years;
        public decimal? OwedAfter5Years { get { return _owedAfter5Years; } set { _owedAfter5Years = value; } }
        private Value<decimal?> _rateInMonth2;
        public decimal? RateInMonth2 { get { return _rateInMonth2; } set { _rateInMonth2 = value; } }
        private Value<decimal?> _reducedLoanBalance;
        public decimal? ReducedLoanBalance { get { return _reducedLoanBalance; } set { _reducedLoanBalance = value; } }
        private Value<string> _reducedStatus;
        public string ReducedStatus { get { return _reducedStatus; } set { _reducedStatus = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _fixedRate.Clean
                    && _gfePaymentIndex.Clean
                    && _id.Clean
                    && _indexRate.Clean
                    && _isBalanceReduced.Clean
                    && _loanTypeExplanation.Clean
                    && _marginRate.Clean
                    && _maximumDifference.Clean
                    && _maximumRate.Clean
                    && _minimumDifference.Clean
                    && _minimumMonthlyPayment.Clean
                    && _monthlyPaymentYear1.Clean
                    && _monthlyPaymentYear6.Clean
                    && _monthlyPaymentYear6Change.Clean
                    && _monthlyPaymentYear6MaxChange.Clean
                    && _notOfferedIndicator.Clean
                    && _owedAfter5Years.Clean
                    && _rateInMonth2.Clean
                    && _reducedLoanBalance.Clean
                    && _reducedStatus.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var fixedRate = _fixedRate; fixedRate.Clean = value; _fixedRate = fixedRate;
                var gfePaymentIndex = _gfePaymentIndex; gfePaymentIndex.Clean = value; _gfePaymentIndex = gfePaymentIndex;
                var id = _id; id.Clean = value; _id = id;
                var indexRate = _indexRate; indexRate.Clean = value; _indexRate = indexRate;
                var isBalanceReduced = _isBalanceReduced; isBalanceReduced.Clean = value; _isBalanceReduced = isBalanceReduced;
                var loanTypeExplanation = _loanTypeExplanation; loanTypeExplanation.Clean = value; _loanTypeExplanation = loanTypeExplanation;
                var marginRate = _marginRate; marginRate.Clean = value; _marginRate = marginRate;
                var maximumDifference = _maximumDifference; maximumDifference.Clean = value; _maximumDifference = maximumDifference;
                var maximumRate = _maximumRate; maximumRate.Clean = value; _maximumRate = maximumRate;
                var minimumDifference = _minimumDifference; minimumDifference.Clean = value; _minimumDifference = minimumDifference;
                var minimumMonthlyPayment = _minimumMonthlyPayment; minimumMonthlyPayment.Clean = value; _minimumMonthlyPayment = minimumMonthlyPayment;
                var monthlyPaymentYear1 = _monthlyPaymentYear1; monthlyPaymentYear1.Clean = value; _monthlyPaymentYear1 = monthlyPaymentYear1;
                var monthlyPaymentYear6 = _monthlyPaymentYear6; monthlyPaymentYear6.Clean = value; _monthlyPaymentYear6 = monthlyPaymentYear6;
                var monthlyPaymentYear6Change = _monthlyPaymentYear6Change; monthlyPaymentYear6Change.Clean = value; _monthlyPaymentYear6Change = monthlyPaymentYear6Change;
                var monthlyPaymentYear6MaxChange = _monthlyPaymentYear6MaxChange; monthlyPaymentYear6MaxChange.Clean = value; _monthlyPaymentYear6MaxChange = monthlyPaymentYear6MaxChange;
                var notOfferedIndicator = _notOfferedIndicator; notOfferedIndicator.Clean = value; _notOfferedIndicator = notOfferedIndicator;
                var owedAfter5Years = _owedAfter5Years; owedAfter5Years.Clean = value; _owedAfter5Years = owedAfter5Years;
                var rateInMonth2 = _rateInMonth2; rateInMonth2.Clean = value; _rateInMonth2 = rateInMonth2;
                var reducedLoanBalance = _reducedLoanBalance; reducedLoanBalance.Clean = value; _reducedLoanBalance = reducedLoanBalance;
                var reducedStatus = _reducedStatus; reducedStatus.Clean = value; _reducedStatus = reducedStatus;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public GfePayment()
        {
            Clean = true;
        }
    }
}