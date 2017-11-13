using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class PrequalificationScenario : IDirty
    {
        private DirtyValue<int?> _appraisedValue;
        public int? AppraisedValue { get => _appraisedValue; set => _appraisedValue = value; }
        private DirtyValue<decimal?> _apr;
        public decimal? Apr { get => _apr; set => _apr = value; }
        private DirtyValue<decimal?> _cashToClose;
        public decimal? CashToClose { get => _cashToClose; set => _cashToClose = value; }
        private DirtyValue<decimal?> _closingCost;
        public decimal? ClosingCost { get => _closingCost; set => _closingCost = value; }
        private DirtyValue<decimal?> _cltv;
        public decimal? Cltv { get => _cltv; set => _cltv = value; }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _creditScore;
        public string CreditScore { get => _creditScore; set => _creditScore = value; }
        private DirtyValue<string> _currentStatus;
        public string CurrentStatus { get => _currentStatus; set => _currentStatus = value; }
        private DirtyValue<decimal?> _downPaymentAmount;
        public decimal? DownPaymentAmount { get => _downPaymentAmount; set => _downPaymentAmount = value; }
        private DirtyValue<decimal?> _downPaymentPercent;
        public decimal? DownPaymentPercent { get => _downPaymentPercent; set => _downPaymentPercent = value; }
        private DirtyValue<decimal?> _fhaUpfrontMIPremiumPercent;
        public decimal? FhaUpfrontMIPremiumPercent { get => _fhaUpfrontMIPremiumPercent; set => _fhaUpfrontMIPremiumPercent = value; }
        private DirtyValue<decimal?> _grossNegativeCashFlow;
        public decimal? GrossNegativeCashFlow { get => _grossNegativeCashFlow; set => _grossNegativeCashFlow = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _loanAmount;
        public decimal? LoanAmount { get => _loanAmount; set => _loanAmount = value; }
        private DirtyValue<decimal?> _ltv;
        public decimal? Ltv { get => _ltv; set => _ltv = value; }
        private DirtyValue<decimal?> _maximumDebt;
        public decimal? MaximumDebt { get => _maximumDebt; set => _maximumDebt = value; }
        private DirtyValue<decimal?> _maximumLoanAmount;
        public decimal? MaximumLoanAmount { get => _maximumLoanAmount; set => _maximumLoanAmount = value; }
        private DirtyValue<decimal?> _miAndFundingFeeFinancedAmount;
        public decimal? MiAndFundingFeeFinancedAmount { get => _miAndFundingFeeFinancedAmount; set => _miAndFundingFeeFinancedAmount = value; }
        private DirtyValue<decimal?> _minimumIncome;
        public decimal? MinimumIncome { get => _minimumIncome; set => _minimumIncome = value; }
        private DirtyValue<decimal?> _monthlyPayment;
        public decimal? MonthlyPayment { get => _monthlyPayment; set => _monthlyPayment = value; }
        private DirtyValue<decimal?> _prepaidItemsEstimatedAmount;
        public decimal? PrepaidItemsEstimatedAmount { get => _prepaidItemsEstimatedAmount; set => _prepaidItemsEstimatedAmount = value; }
        private DirtyValue<int?> _prequalificationScenarioIndex;
        public int? PrequalificationScenarioIndex { get => _prequalificationScenarioIndex; set => _prequalificationScenarioIndex = value; }
        private DirtyValue<decimal?> _qualBottomRatioPercent;
        public decimal? QualBottomRatioPercent { get => _qualBottomRatioPercent; set => _qualBottomRatioPercent = value; }
        private DirtyValue<decimal?> _qualTopRatioPercent;
        public decimal? QualTopRatioPercent { get => _qualTopRatioPercent; set => _qualTopRatioPercent = value; }
        private DirtyValue<decimal?> _salesPrice;
        public decimal? SalesPrice { get => _salesPrice; set => _salesPrice = value; }
        private DirtyValue<decimal?> _subordinateFin;
        public decimal? SubordinateFin { get => _subordinateFin; set => _subordinateFin = value; }
        private DirtyValue<decimal?> _totalBaseCost;
        public decimal? TotalBaseCost { get => _totalBaseCost; set => _totalBaseCost = value; }
        private DirtyValue<decimal?> _totalCashAvailable;
        public decimal? TotalCashAvailable { get => _totalCashAvailable; set => _totalCashAvailable = value; }
        private DirtyValue<decimal?> _totalCashLeft;
        public decimal? TotalCashLeft { get => _totalCashLeft; set => _totalCashLeft = value; }
        private DirtyValue<decimal?> _totalCosts;
        public decimal? TotalCosts { get => _totalCosts; set => _totalCosts = value; }
        private DirtyValue<decimal?> _totalFinancing;
        public decimal? TotalFinancing { get => _totalFinancing; set => _totalFinancing = value; }
        private DirtyValue<decimal?> _totalHe;
        public decimal? TotalHe { get => _totalHe; set => _totalHe = value; }
        private DirtyValue<decimal?> _totalIncome;
        public decimal? TotalIncome { get => _totalIncome; set => _totalIncome = value; }
        private DirtyValue<decimal?> _totalLoanAmount;
        public decimal? TotalLoanAmount { get => _totalLoanAmount; set => _totalLoanAmount = value; }
        private DirtyValue<decimal?> _totalOtherExpense;
        public decimal? TotalOtherExpense { get => _totalOtherExpense; set => _totalOtherExpense = value; }
        private DirtyValue<decimal?> _totalPaidOffMortgage;
        public decimal? TotalPaidOffMortgage { get => _totalPaidOffMortgage; set => _totalPaidOffMortgage = value; }
        private DirtyValue<decimal?> _totalPaidOffOthers;
        public decimal? TotalPaidOffOthers { get => _totalPaidOffOthers; set => _totalPaidOffOthers = value; }
        private DirtyValue<decimal?> _totalPayments;
        public decimal? TotalPayments { get => _totalPayments; set => _totalPayments = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _appraisedValue.Dirty
                    || _apr.Dirty
                    || _cashToClose.Dirty
                    || _closingCost.Dirty
                    || _cltv.Dirty
                    || _comments.Dirty
                    || _creditScore.Dirty
                    || _currentStatus.Dirty
                    || _downPaymentAmount.Dirty
                    || _downPaymentPercent.Dirty
                    || _fhaUpfrontMIPremiumPercent.Dirty
                    || _grossNegativeCashFlow.Dirty
                    || _id.Dirty
                    || _loanAmount.Dirty
                    || _ltv.Dirty
                    || _maximumDebt.Dirty
                    || _maximumLoanAmount.Dirty
                    || _miAndFundingFeeFinancedAmount.Dirty
                    || _minimumIncome.Dirty
                    || _monthlyPayment.Dirty
                    || _prepaidItemsEstimatedAmount.Dirty
                    || _prequalificationScenarioIndex.Dirty
                    || _qualBottomRatioPercent.Dirty
                    || _qualTopRatioPercent.Dirty
                    || _salesPrice.Dirty
                    || _subordinateFin.Dirty
                    || _totalBaseCost.Dirty
                    || _totalCashAvailable.Dirty
                    || _totalCashLeft.Dirty
                    || _totalCosts.Dirty
                    || _totalFinancing.Dirty
                    || _totalHe.Dirty
                    || _totalIncome.Dirty
                    || _totalLoanAmount.Dirty
                    || _totalOtherExpense.Dirty
                    || _totalPaidOffMortgage.Dirty
                    || _totalPaidOffOthers.Dirty
                    || _totalPayments.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _appraisedValue.Dirty = value;
                _apr.Dirty = value;
                _cashToClose.Dirty = value;
                _closingCost.Dirty = value;
                _cltv.Dirty = value;
                _comments.Dirty = value;
                _creditScore.Dirty = value;
                _currentStatus.Dirty = value;
                _downPaymentAmount.Dirty = value;
                _downPaymentPercent.Dirty = value;
                _fhaUpfrontMIPremiumPercent.Dirty = value;
                _grossNegativeCashFlow.Dirty = value;
                _id.Dirty = value;
                _loanAmount.Dirty = value;
                _ltv.Dirty = value;
                _maximumDebt.Dirty = value;
                _maximumLoanAmount.Dirty = value;
                _miAndFundingFeeFinancedAmount.Dirty = value;
                _minimumIncome.Dirty = value;
                _monthlyPayment.Dirty = value;
                _prepaidItemsEstimatedAmount.Dirty = value;
                _prequalificationScenarioIndex.Dirty = value;
                _qualBottomRatioPercent.Dirty = value;
                _qualTopRatioPercent.Dirty = value;
                _salesPrice.Dirty = value;
                _subordinateFin.Dirty = value;
                _totalBaseCost.Dirty = value;
                _totalCashAvailable.Dirty = value;
                _totalCashLeft.Dirty = value;
                _totalCosts.Dirty = value;
                _totalFinancing.Dirty = value;
                _totalHe.Dirty = value;
                _totalIncome.Dirty = value;
                _totalLoanAmount.Dirty = value;
                _totalOtherExpense.Dirty = value;
                _totalPaidOffMortgage.Dirty = value;
                _totalPaidOffOthers.Dirty = value;
                _totalPayments.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}