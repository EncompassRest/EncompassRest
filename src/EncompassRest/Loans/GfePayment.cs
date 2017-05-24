using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class GfePayment
    {
        private Value<decimal?> _fixedRate;
        public decimal? FixedRate { get { return _fixedRate; } set { _fixedRate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFixedRate() => !_fixedRate.Clean;
        private Value<int?> _gfePaymentIndex;
        public int? GfePaymentIndex { get { return _gfePaymentIndex; } set { _gfePaymentIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfePaymentIndex() => !_gfePaymentIndex.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<decimal?> _indexRate;
        public decimal? IndexRate { get { return _indexRate; } set { _indexRate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIndexRate() => !_indexRate.Clean;
        private Value<string> _isBalanceReduced;
        public string IsBalanceReduced { get { return _isBalanceReduced; } set { _isBalanceReduced = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsBalanceReduced() => !_isBalanceReduced.Clean;
        private Value<string> _loanTypeExplanation;
        public string LoanTypeExplanation { get { return _loanTypeExplanation; } set { _loanTypeExplanation = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanTypeExplanation() => !_loanTypeExplanation.Clean;
        private Value<decimal?> _marginRate;
        public decimal? MarginRate { get { return _marginRate; } set { _marginRate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMarginRate() => !_marginRate.Clean;
        private Value<decimal?> _maximumDifference;
        public decimal? MaximumDifference { get { return _maximumDifference; } set { _maximumDifference = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumDifference() => !_maximumDifference.Clean;
        private Value<decimal?> _maximumRate;
        public decimal? MaximumRate { get { return _maximumRate; } set { _maximumRate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumRate() => !_maximumRate.Clean;
        private Value<decimal?> _minimumDifference;
        public decimal? MinimumDifference { get { return _minimumDifference; } set { _minimumDifference = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumDifference() => !_minimumDifference.Clean;
        private Value<decimal?> _minimumMonthlyPayment;
        public decimal? MinimumMonthlyPayment { get { return _minimumMonthlyPayment; } set { _minimumMonthlyPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumMonthlyPayment() => !_minimumMonthlyPayment.Clean;
        private Value<decimal?> _monthlyPaymentYear1;
        public decimal? MonthlyPaymentYear1 { get { return _monthlyPaymentYear1; } set { _monthlyPaymentYear1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPaymentYear1() => !_monthlyPaymentYear1.Clean;
        private Value<decimal?> _monthlyPaymentYear6;
        public decimal? MonthlyPaymentYear6 { get { return _monthlyPaymentYear6; } set { _monthlyPaymentYear6 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPaymentYear6() => !_monthlyPaymentYear6.Clean;
        private Value<decimal?> _monthlyPaymentYear6Change;
        public decimal? MonthlyPaymentYear6Change { get { return _monthlyPaymentYear6Change; } set { _monthlyPaymentYear6Change = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPaymentYear6Change() => !_monthlyPaymentYear6Change.Clean;
        private Value<decimal?> _monthlyPaymentYear6MaxChange;
        public decimal? MonthlyPaymentYear6MaxChange { get { return _monthlyPaymentYear6MaxChange; } set { _monthlyPaymentYear6MaxChange = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPaymentYear6MaxChange() => !_monthlyPaymentYear6MaxChange.Clean;
        private Value<bool?> _notOfferedIndicator;
        public bool? NotOfferedIndicator { get { return _notOfferedIndicator; } set { _notOfferedIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNotOfferedIndicator() => !_notOfferedIndicator.Clean;
        private Value<decimal?> _owedAfter5Years;
        public decimal? OwedAfter5Years { get { return _owedAfter5Years; } set { _owedAfter5Years = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOwedAfter5Years() => !_owedAfter5Years.Clean;
        private Value<decimal?> _rateInMonth2;
        public decimal? RateInMonth2 { get { return _rateInMonth2; } set { _rateInMonth2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateInMonth2() => !_rateInMonth2.Clean;
        private Value<decimal?> _reducedLoanBalance;
        public decimal? ReducedLoanBalance { get { return _reducedLoanBalance; } set { _reducedLoanBalance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReducedLoanBalance() => !_reducedLoanBalance.Clean;
        private Value<string> _reducedStatus;
        public string ReducedStatus { get { return _reducedStatus; } set { _reducedStatus = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReducedStatus() => !_reducedStatus.Clean;
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
                var v0 = _fixedRate; v0.Clean = value; _fixedRate = v0;
                var v1 = _gfePaymentIndex; v1.Clean = value; _gfePaymentIndex = v1;
                var v2 = _id; v2.Clean = value; _id = v2;
                var v3 = _indexRate; v3.Clean = value; _indexRate = v3;
                var v4 = _isBalanceReduced; v4.Clean = value; _isBalanceReduced = v4;
                var v5 = _loanTypeExplanation; v5.Clean = value; _loanTypeExplanation = v5;
                var v6 = _marginRate; v6.Clean = value; _marginRate = v6;
                var v7 = _maximumDifference; v7.Clean = value; _maximumDifference = v7;
                var v8 = _maximumRate; v8.Clean = value; _maximumRate = v8;
                var v9 = _minimumDifference; v9.Clean = value; _minimumDifference = v9;
                var v10 = _minimumMonthlyPayment; v10.Clean = value; _minimumMonthlyPayment = v10;
                var v11 = _monthlyPaymentYear1; v11.Clean = value; _monthlyPaymentYear1 = v11;
                var v12 = _monthlyPaymentYear6; v12.Clean = value; _monthlyPaymentYear6 = v12;
                var v13 = _monthlyPaymentYear6Change; v13.Clean = value; _monthlyPaymentYear6Change = v13;
                var v14 = _monthlyPaymentYear6MaxChange; v14.Clean = value; _monthlyPaymentYear6MaxChange = v14;
                var v15 = _notOfferedIndicator; v15.Clean = value; _notOfferedIndicator = v15;
                var v16 = _owedAfter5Years; v16.Clean = value; _owedAfter5Years = v16;
                var v17 = _rateInMonth2; v17.Clean = value; _rateInMonth2 = v17;
                var v18 = _reducedLoanBalance; v18.Clean = value; _reducedLoanBalance = v18;
                var v19 = _reducedStatus; v19.Clean = value; _reducedStatus = v19;
                _settingClean = 0;
            }
        }
    }
}