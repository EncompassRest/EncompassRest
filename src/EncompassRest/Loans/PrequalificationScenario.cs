using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class PrequalificationScenario : IClean
    {
        private Value<int?> _appraisedValue;
        public int? AppraisedValue { get { return _appraisedValue; } set { _appraisedValue = value; } }
        private Value<decimal?> _apr;
        public decimal? Apr { get { return _apr; } set { _apr = value; } }
        private Value<decimal?> _cashToClose;
        public decimal? CashToClose { get { return _cashToClose; } set { _cashToClose = value; } }
        private Value<decimal?> _closingCost;
        public decimal? ClosingCost { get { return _closingCost; } set { _closingCost = value; } }
        private Value<decimal?> _cltv;
        public decimal? Cltv { get { return _cltv; } set { _cltv = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<string> _creditScore;
        public string CreditScore { get { return _creditScore; } set { _creditScore = value; } }
        private Value<string> _currentStatus;
        public string CurrentStatus { get { return _currentStatus; } set { _currentStatus = value; } }
        private Value<decimal?> _downPaymentAmount;
        public decimal? DownPaymentAmount { get { return _downPaymentAmount; } set { _downPaymentAmount = value; } }
        private Value<decimal?> _downPaymentPercent;
        public decimal? DownPaymentPercent { get { return _downPaymentPercent; } set { _downPaymentPercent = value; } }
        private Value<decimal?> _fhaUpfrontMIPremiumPercent;
        public decimal? FhaUpfrontMIPremiumPercent { get { return _fhaUpfrontMIPremiumPercent; } set { _fhaUpfrontMIPremiumPercent = value; } }
        private Value<decimal?> _grossNegativeCashFlow;
        public decimal? GrossNegativeCashFlow { get { return _grossNegativeCashFlow; } set { _grossNegativeCashFlow = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _loanAmount;
        public decimal? LoanAmount { get { return _loanAmount; } set { _loanAmount = value; } }
        private Value<decimal?> _ltv;
        public decimal? Ltv { get { return _ltv; } set { _ltv = value; } }
        private Value<decimal?> _maximumDebt;
        public decimal? MaximumDebt { get { return _maximumDebt; } set { _maximumDebt = value; } }
        private Value<decimal?> _maximumLoanAmount;
        public decimal? MaximumLoanAmount { get { return _maximumLoanAmount; } set { _maximumLoanAmount = value; } }
        private Value<decimal?> _miAndFundingFeeFinancedAmount;
        public decimal? MiAndFundingFeeFinancedAmount { get { return _miAndFundingFeeFinancedAmount; } set { _miAndFundingFeeFinancedAmount = value; } }
        private Value<decimal?> _minimumIncome;
        public decimal? MinimumIncome { get { return _minimumIncome; } set { _minimumIncome = value; } }
        private Value<decimal?> _monthlyPayment;
        public decimal? MonthlyPayment { get { return _monthlyPayment; } set { _monthlyPayment = value; } }
        private Value<decimal?> _prepaidItemsEstimatedAmount;
        public decimal? PrepaidItemsEstimatedAmount { get { return _prepaidItemsEstimatedAmount; } set { _prepaidItemsEstimatedAmount = value; } }
        private Value<int?> _prequalificationScenarioIndex;
        public int? PrequalificationScenarioIndex { get { return _prequalificationScenarioIndex; } set { _prequalificationScenarioIndex = value; } }
        private Value<decimal?> _qualBottomRatioPercent;
        public decimal? QualBottomRatioPercent { get { return _qualBottomRatioPercent; } set { _qualBottomRatioPercent = value; } }
        private Value<decimal?> _qualTopRatioPercent;
        public decimal? QualTopRatioPercent { get { return _qualTopRatioPercent; } set { _qualTopRatioPercent = value; } }
        private Value<decimal?> _salesPrice;
        public decimal? SalesPrice { get { return _salesPrice; } set { _salesPrice = value; } }
        private Value<decimal?> _subordinateFin;
        public decimal? SubordinateFin { get { return _subordinateFin; } set { _subordinateFin = value; } }
        private Value<decimal?> _totalBaseCost;
        public decimal? TotalBaseCost { get { return _totalBaseCost; } set { _totalBaseCost = value; } }
        private Value<decimal?> _totalCashAvailable;
        public decimal? TotalCashAvailable { get { return _totalCashAvailable; } set { _totalCashAvailable = value; } }
        private Value<decimal?> _totalCashLeft;
        public decimal? TotalCashLeft { get { return _totalCashLeft; } set { _totalCashLeft = value; } }
        private Value<decimal?> _totalCosts;
        public decimal? TotalCosts { get { return _totalCosts; } set { _totalCosts = value; } }
        private Value<decimal?> _totalFinancing;
        public decimal? TotalFinancing { get { return _totalFinancing; } set { _totalFinancing = value; } }
        private Value<decimal?> _totalHe;
        public decimal? TotalHe { get { return _totalHe; } set { _totalHe = value; } }
        private Value<decimal?> _totalIncome;
        public decimal? TotalIncome { get { return _totalIncome; } set { _totalIncome = value; } }
        private Value<decimal?> _totalLoanAmount;
        public decimal? TotalLoanAmount { get { return _totalLoanAmount; } set { _totalLoanAmount = value; } }
        private Value<decimal?> _totalOtherExpense;
        public decimal? TotalOtherExpense { get { return _totalOtherExpense; } set { _totalOtherExpense = value; } }
        private Value<decimal?> _totalPaidOffMortgage;
        public decimal? TotalPaidOffMortgage { get { return _totalPaidOffMortgage; } set { _totalPaidOffMortgage = value; } }
        private Value<decimal?> _totalPaidOffOthers;
        public decimal? TotalPaidOffOthers { get { return _totalPaidOffOthers; } set { _totalPaidOffOthers = value; } }
        private Value<decimal?> _totalPayments;
        public decimal? TotalPayments { get { return _totalPayments; } set { _totalPayments = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _appraisedValue.Clean
                    && _apr.Clean
                    && _cashToClose.Clean
                    && _closingCost.Clean
                    && _cltv.Clean
                    && _comments.Clean
                    && _creditScore.Clean
                    && _currentStatus.Clean
                    && _downPaymentAmount.Clean
                    && _downPaymentPercent.Clean
                    && _fhaUpfrontMIPremiumPercent.Clean
                    && _grossNegativeCashFlow.Clean
                    && _id.Clean
                    && _loanAmount.Clean
                    && _ltv.Clean
                    && _maximumDebt.Clean
                    && _maximumLoanAmount.Clean
                    && _miAndFundingFeeFinancedAmount.Clean
                    && _minimumIncome.Clean
                    && _monthlyPayment.Clean
                    && _prepaidItemsEstimatedAmount.Clean
                    && _prequalificationScenarioIndex.Clean
                    && _qualBottomRatioPercent.Clean
                    && _qualTopRatioPercent.Clean
                    && _salesPrice.Clean
                    && _subordinateFin.Clean
                    && _totalBaseCost.Clean
                    && _totalCashAvailable.Clean
                    && _totalCashLeft.Clean
                    && _totalCosts.Clean
                    && _totalFinancing.Clean
                    && _totalHe.Clean
                    && _totalIncome.Clean
                    && _totalLoanAmount.Clean
                    && _totalOtherExpense.Clean
                    && _totalPaidOffMortgage.Clean
                    && _totalPaidOffOthers.Clean
                    && _totalPayments.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var appraisedValue = _appraisedValue; appraisedValue.Clean = value; _appraisedValue = appraisedValue;
                var apr = _apr; apr.Clean = value; _apr = apr;
                var cashToClose = _cashToClose; cashToClose.Clean = value; _cashToClose = cashToClose;
                var closingCost = _closingCost; closingCost.Clean = value; _closingCost = closingCost;
                var cltv = _cltv; cltv.Clean = value; _cltv = cltv;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var creditScore = _creditScore; creditScore.Clean = value; _creditScore = creditScore;
                var currentStatus = _currentStatus; currentStatus.Clean = value; _currentStatus = currentStatus;
                var downPaymentAmount = _downPaymentAmount; downPaymentAmount.Clean = value; _downPaymentAmount = downPaymentAmount;
                var downPaymentPercent = _downPaymentPercent; downPaymentPercent.Clean = value; _downPaymentPercent = downPaymentPercent;
                var fhaUpfrontMIPremiumPercent = _fhaUpfrontMIPremiumPercent; fhaUpfrontMIPremiumPercent.Clean = value; _fhaUpfrontMIPremiumPercent = fhaUpfrontMIPremiumPercent;
                var grossNegativeCashFlow = _grossNegativeCashFlow; grossNegativeCashFlow.Clean = value; _grossNegativeCashFlow = grossNegativeCashFlow;
                var id = _id; id.Clean = value; _id = id;
                var loanAmount = _loanAmount; loanAmount.Clean = value; _loanAmount = loanAmount;
                var ltv = _ltv; ltv.Clean = value; _ltv = ltv;
                var maximumDebt = _maximumDebt; maximumDebt.Clean = value; _maximumDebt = maximumDebt;
                var maximumLoanAmount = _maximumLoanAmount; maximumLoanAmount.Clean = value; _maximumLoanAmount = maximumLoanAmount;
                var miAndFundingFeeFinancedAmount = _miAndFundingFeeFinancedAmount; miAndFundingFeeFinancedAmount.Clean = value; _miAndFundingFeeFinancedAmount = miAndFundingFeeFinancedAmount;
                var minimumIncome = _minimumIncome; minimumIncome.Clean = value; _minimumIncome = minimumIncome;
                var monthlyPayment = _monthlyPayment; monthlyPayment.Clean = value; _monthlyPayment = monthlyPayment;
                var prepaidItemsEstimatedAmount = _prepaidItemsEstimatedAmount; prepaidItemsEstimatedAmount.Clean = value; _prepaidItemsEstimatedAmount = prepaidItemsEstimatedAmount;
                var prequalificationScenarioIndex = _prequalificationScenarioIndex; prequalificationScenarioIndex.Clean = value; _prequalificationScenarioIndex = prequalificationScenarioIndex;
                var qualBottomRatioPercent = _qualBottomRatioPercent; qualBottomRatioPercent.Clean = value; _qualBottomRatioPercent = qualBottomRatioPercent;
                var qualTopRatioPercent = _qualTopRatioPercent; qualTopRatioPercent.Clean = value; _qualTopRatioPercent = qualTopRatioPercent;
                var salesPrice = _salesPrice; salesPrice.Clean = value; _salesPrice = salesPrice;
                var subordinateFin = _subordinateFin; subordinateFin.Clean = value; _subordinateFin = subordinateFin;
                var totalBaseCost = _totalBaseCost; totalBaseCost.Clean = value; _totalBaseCost = totalBaseCost;
                var totalCashAvailable = _totalCashAvailable; totalCashAvailable.Clean = value; _totalCashAvailable = totalCashAvailable;
                var totalCashLeft = _totalCashLeft; totalCashLeft.Clean = value; _totalCashLeft = totalCashLeft;
                var totalCosts = _totalCosts; totalCosts.Clean = value; _totalCosts = totalCosts;
                var totalFinancing = _totalFinancing; totalFinancing.Clean = value; _totalFinancing = totalFinancing;
                var totalHe = _totalHe; totalHe.Clean = value; _totalHe = totalHe;
                var totalIncome = _totalIncome; totalIncome.Clean = value; _totalIncome = totalIncome;
                var totalLoanAmount = _totalLoanAmount; totalLoanAmount.Clean = value; _totalLoanAmount = totalLoanAmount;
                var totalOtherExpense = _totalOtherExpense; totalOtherExpense.Clean = value; _totalOtherExpense = totalOtherExpense;
                var totalPaidOffMortgage = _totalPaidOffMortgage; totalPaidOffMortgage.Clean = value; _totalPaidOffMortgage = totalPaidOffMortgage;
                var totalPaidOffOthers = _totalPaidOffOthers; totalPaidOffOthers.Clean = value; _totalPaidOffOthers = totalPaidOffOthers;
                var totalPayments = _totalPayments; totalPayments.Clean = value; _totalPayments = totalPayments;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public PrequalificationScenario()
        {
            Clean = true;
        }
    }
}