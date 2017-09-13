using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class GfePayment : IDirty
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _fixedRate.Dirty
                    || _gfePaymentIndex.Dirty
                    || _id.Dirty
                    || _indexRate.Dirty
                    || _isBalanceReduced.Dirty
                    || _loanTypeExplanation.Dirty
                    || _marginRate.Dirty
                    || _maximumDifference.Dirty
                    || _maximumRate.Dirty
                    || _minimumDifference.Dirty
                    || _minimumMonthlyPayment.Dirty
                    || _monthlyPaymentYear1.Dirty
                    || _monthlyPaymentYear6.Dirty
                    || _monthlyPaymentYear6Change.Dirty
                    || _monthlyPaymentYear6MaxChange.Dirty
                    || _notOfferedIndicator.Dirty
                    || _owedAfter5Years.Dirty
                    || _rateInMonth2.Dirty
                    || _reducedLoanBalance.Dirty
                    || _reducedStatus.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _fixedRate.Dirty = value;
                _gfePaymentIndex.Dirty = value;
                _id.Dirty = value;
                _indexRate.Dirty = value;
                _isBalanceReduced.Dirty = value;
                _loanTypeExplanation.Dirty = value;
                _marginRate.Dirty = value;
                _maximumDifference.Dirty = value;
                _maximumRate.Dirty = value;
                _minimumDifference.Dirty = value;
                _minimumMonthlyPayment.Dirty = value;
                _monthlyPaymentYear1.Dirty = value;
                _monthlyPaymentYear6.Dirty = value;
                _monthlyPaymentYear6Change.Dirty = value;
                _monthlyPaymentYear6MaxChange.Dirty = value;
                _notOfferedIndicator.Dirty = value;
                _owedAfter5Years.Dirty = value;
                _rateInMonth2.Dirty = value;
                _reducedLoanBalance.Dirty = value;
                _reducedStatus.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}