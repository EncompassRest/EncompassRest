#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class GfePayment : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _fixedRate;
        public decimal? FixedRate { get => _fixedRate; set => _fixedRate = value; }
        private DirtyValue<int?> _gfePaymentIndex;
        public int? GfePaymentIndex { get => _gfePaymentIndex; set => _gfePaymentIndex = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _indexRate;
        public decimal? IndexRate { get => _indexRate; set => _indexRate = value; }
        private DirtyValue<StringEnumValue<YesOrNo>> _isBalanceReduced;
        public StringEnumValue<YesOrNo> IsBalanceReduced { get => _isBalanceReduced; set => _isBalanceReduced = value; }
        private DirtyValue<string> _loanTypeExplanation;
        public string LoanTypeExplanation { get => _loanTypeExplanation; set => _loanTypeExplanation = value; }
        private DirtyValue<decimal?> _marginRate;
        public decimal? MarginRate { get => _marginRate; set => _marginRate = value; }
        private DirtyValue<decimal?> _maximumDifference;
        public decimal? MaximumDifference { get => _maximumDifference; set => _maximumDifference = value; }
        private DirtyValue<decimal?> _maximumRate;
        public decimal? MaximumRate { get => _maximumRate; set => _maximumRate = value; }
        private DirtyValue<decimal?> _minimumDifference;
        public decimal? MinimumDifference { get => _minimumDifference; set => _minimumDifference = value; }
        private DirtyValue<decimal?> _minimumMonthlyPayment;
        public decimal? MinimumMonthlyPayment { get => _minimumMonthlyPayment; set => _minimumMonthlyPayment = value; }
        private DirtyValue<decimal?> _monthlyPaymentYear1;
        public decimal? MonthlyPaymentYear1 { get => _monthlyPaymentYear1; set => _monthlyPaymentYear1 = value; }
        private DirtyValue<decimal?> _monthlyPaymentYear6;
        public decimal? MonthlyPaymentYear6 { get => _monthlyPaymentYear6; set => _monthlyPaymentYear6 = value; }
        private DirtyValue<decimal?> _monthlyPaymentYear6Change;
        public decimal? MonthlyPaymentYear6Change { get => _monthlyPaymentYear6Change; set => _monthlyPaymentYear6Change = value; }
        private DirtyValue<decimal?> _monthlyPaymentYear6MaxChange;
        public decimal? MonthlyPaymentYear6MaxChange { get => _monthlyPaymentYear6MaxChange; set => _monthlyPaymentYear6MaxChange = value; }
        private DirtyValue<bool?> _notOfferedIndicator;
        public bool? NotOfferedIndicator { get => _notOfferedIndicator; set => _notOfferedIndicator = value; }
        private DirtyValue<decimal?> _owedAfter5Years;
        public decimal? OwedAfter5Years { get => _owedAfter5Years; set => _owedAfter5Years = value; }
        private DirtyValue<decimal?> _rateInMonth2;
        public decimal? RateInMonth2 { get => _rateInMonth2; set => _rateInMonth2 = value; }
        private DirtyValue<decimal?> _reducedLoanBalance;
        public decimal? ReducedLoanBalance { get => _reducedLoanBalance; set => _reducedLoanBalance = value; }
        private DirtyValue<StringEnumValue<ReducedStatus>> _reducedStatus;
        public StringEnumValue<ReducedStatus> ReducedStatus { get => _reducedStatus; set => _reducedStatus = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _fixedRate.Dirty
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
            }
            set
            {
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
            }
        }
    }
}