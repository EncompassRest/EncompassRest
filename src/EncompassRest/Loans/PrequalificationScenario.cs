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
                var v0 = _appraisedValue; v0.Clean = value; _appraisedValue = v0;
                var v1 = _apr; v1.Clean = value; _apr = v1;
                var v2 = _cashToClose; v2.Clean = value; _cashToClose = v2;
                var v3 = _closingCost; v3.Clean = value; _closingCost = v3;
                var v4 = _cltv; v4.Clean = value; _cltv = v4;
                var v5 = _comments; v5.Clean = value; _comments = v5;
                var v6 = _creditScore; v6.Clean = value; _creditScore = v6;
                var v7 = _currentStatus; v7.Clean = value; _currentStatus = v7;
                var v8 = _downPaymentAmount; v8.Clean = value; _downPaymentAmount = v8;
                var v9 = _downPaymentPercent; v9.Clean = value; _downPaymentPercent = v9;
                var v10 = _fhaUpfrontMIPremiumPercent; v10.Clean = value; _fhaUpfrontMIPremiumPercent = v10;
                var v11 = _grossNegativeCashFlow; v11.Clean = value; _grossNegativeCashFlow = v11;
                var v12 = _id; v12.Clean = value; _id = v12;
                var v13 = _loanAmount; v13.Clean = value; _loanAmount = v13;
                var v14 = _ltv; v14.Clean = value; _ltv = v14;
                var v15 = _maximumDebt; v15.Clean = value; _maximumDebt = v15;
                var v16 = _maximumLoanAmount; v16.Clean = value; _maximumLoanAmount = v16;
                var v17 = _miAndFundingFeeFinancedAmount; v17.Clean = value; _miAndFundingFeeFinancedAmount = v17;
                var v18 = _minimumIncome; v18.Clean = value; _minimumIncome = v18;
                var v19 = _monthlyPayment; v19.Clean = value; _monthlyPayment = v19;
                var v20 = _prepaidItemsEstimatedAmount; v20.Clean = value; _prepaidItemsEstimatedAmount = v20;
                var v21 = _prequalificationScenarioIndex; v21.Clean = value; _prequalificationScenarioIndex = v21;
                var v22 = _qualBottomRatioPercent; v22.Clean = value; _qualBottomRatioPercent = v22;
                var v23 = _qualTopRatioPercent; v23.Clean = value; _qualTopRatioPercent = v23;
                var v24 = _salesPrice; v24.Clean = value; _salesPrice = v24;
                var v25 = _subordinateFin; v25.Clean = value; _subordinateFin = v25;
                var v26 = _totalBaseCost; v26.Clean = value; _totalBaseCost = v26;
                var v27 = _totalCashAvailable; v27.Clean = value; _totalCashAvailable = v27;
                var v28 = _totalCashLeft; v28.Clean = value; _totalCashLeft = v28;
                var v29 = _totalCosts; v29.Clean = value; _totalCosts = v29;
                var v30 = _totalFinancing; v30.Clean = value; _totalFinancing = v30;
                var v31 = _totalHe; v31.Clean = value; _totalHe = v31;
                var v32 = _totalIncome; v32.Clean = value; _totalIncome = v32;
                var v33 = _totalLoanAmount; v33.Clean = value; _totalLoanAmount = v33;
                var v34 = _totalOtherExpense; v34.Clean = value; _totalOtherExpense = v34;
                var v35 = _totalPaidOffMortgage; v35.Clean = value; _totalPaidOffMortgage = v35;
                var v36 = _totalPaidOffOthers; v36.Clean = value; _totalPaidOffOthers = v36;
                var v37 = _totalPayments; v37.Clean = value; _totalPayments = v37;
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