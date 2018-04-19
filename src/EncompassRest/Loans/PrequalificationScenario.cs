using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PrequalificationScenario
    /// </summary>
    public sealed partial class PrequalificationScenario : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _appraisedValue;
        /// <summary>
        /// PrequalificationScenario AppraisedValue
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? AppraisedValue { get => _appraisedValue; set => _appraisedValue = value; }
        private DirtyValue<decimal?> _apr;
        /// <summary>
        /// PrequalificationScenario Apr
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? Apr { get => _apr; set => _apr = value; }
        private DirtyValue<decimal?> _cashToClose;
        /// <summary>
        /// PrequalificationScenario CashToClose
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? CashToClose { get => _cashToClose; set => _cashToClose = value; }
        private DirtyValue<decimal?> _closingCost;
        /// <summary>
        /// PrequalificationScenario ClosingCost
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? ClosingCost { get => _closingCost; set => _closingCost = value; }
        private DirtyValue<decimal?> _cltv;
        /// <summary>
        /// PrequalificationScenario Cltv
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? Cltv { get => _cltv; set => _cltv = value; }
        private DirtyValue<string> _comments;
        /// <summary>
        /// PrequalificationScenario Comments
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _creditScore;
        /// <summary>
        /// PrequalificationScenario CreditScore
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CreditScore { get => _creditScore; set => _creditScore = value; }
        private DirtyValue<string> _currentStatus;
        /// <summary>
        /// PrequalificationScenario CurrentStatus
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CurrentStatus { get => _currentStatus; set => _currentStatus = value; }
        private DirtyValue<decimal?> _downPaymentAmount;
        /// <summary>
        /// PrequalificationScenario DownPaymentAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? DownPaymentAmount { get => _downPaymentAmount; set => _downPaymentAmount = value; }
        private DirtyValue<decimal?> _downPaymentPercent;
        /// <summary>
        /// PrequalificationScenario DownPaymentPercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? DownPaymentPercent { get => _downPaymentPercent; set => _downPaymentPercent = value; }
        private DirtyValue<decimal?> _fhaUpfrontMIPremiumPercent;
        /// <summary>
        /// PrequalificationScenario FhaUpfrontMIPremiumPercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? FhaUpfrontMIPremiumPercent { get => _fhaUpfrontMIPremiumPercent; set => _fhaUpfrontMIPremiumPercent = value; }
        private DirtyValue<decimal?> _grossNegativeCashFlow;
        /// <summary>
        /// PrequalificationScenario GrossNegativeCashFlow
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? GrossNegativeCashFlow { get => _grossNegativeCashFlow; set => _grossNegativeCashFlow = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// PrequalificationScenario Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _loanAmount;
        /// <summary>
        /// PrequalificationScenario LoanAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? LoanAmount { get => _loanAmount; set => _loanAmount = value; }
        private DirtyValue<decimal?> _ltv;
        /// <summary>
        /// PrequalificationScenario Ltv
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? Ltv { get => _ltv; set => _ltv = value; }
        private DirtyValue<decimal?> _maximumDebt;
        /// <summary>
        /// PrequalificationScenario MaximumDebt
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MaximumDebt { get => _maximumDebt; set => _maximumDebt = value; }
        private DirtyValue<decimal?> _maximumLoanAmount;
        /// <summary>
        /// PrequalificationScenario MaximumLoanAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MaximumLoanAmount { get => _maximumLoanAmount; set => _maximumLoanAmount = value; }
        private DirtyValue<decimal?> _miAndFundingFeeFinancedAmount;
        /// <summary>
        /// PrequalificationScenario MiAndFundingFeeFinancedAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MiAndFundingFeeFinancedAmount { get => _miAndFundingFeeFinancedAmount; set => _miAndFundingFeeFinancedAmount = value; }
        private DirtyValue<decimal?> _minimumIncome;
        /// <summary>
        /// PrequalificationScenario MinimumIncome
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MinimumIncome { get => _minimumIncome; set => _minimumIncome = value; }
        private DirtyValue<decimal?> _monthlyPayment;
        /// <summary>
        /// PrequalificationScenario MonthlyPayment
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MonthlyPayment { get => _monthlyPayment; set => _monthlyPayment = value; }
        private DirtyValue<decimal?> _prepaidItemsEstimatedAmount;
        /// <summary>
        /// PrequalificationScenario PrepaidItemsEstimatedAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? PrepaidItemsEstimatedAmount { get => _prepaidItemsEstimatedAmount; set => _prepaidItemsEstimatedAmount = value; }
        private DirtyValue<int?> _prequalificationScenarioIndex;
        /// <summary>
        /// PrequalificationScenario PrequalificationScenarioIndex
        /// </summary>
        public int? PrequalificationScenarioIndex { get => _prequalificationScenarioIndex; set => _prequalificationScenarioIndex = value; }
        private DirtyValue<decimal?> _qualBottomRatioPercent;
        /// <summary>
        /// PrequalificationScenario QualBottomRatioPercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? QualBottomRatioPercent { get => _qualBottomRatioPercent; set => _qualBottomRatioPercent = value; }
        private DirtyValue<decimal?> _qualTopRatioPercent;
        /// <summary>
        /// PrequalificationScenario QualTopRatioPercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? QualTopRatioPercent { get => _qualTopRatioPercent; set => _qualTopRatioPercent = value; }
        private DirtyValue<decimal?> _salesPrice;
        /// <summary>
        /// PrequalificationScenario SalesPrice
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? SalesPrice { get => _salesPrice; set => _salesPrice = value; }
        private DirtyValue<decimal?> _subordinateFin;
        /// <summary>
        /// PrequalificationScenario SubordinateFin
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? SubordinateFin { get => _subordinateFin; set => _subordinateFin = value; }
        private DirtyValue<decimal?> _totalBaseCost;
        /// <summary>
        /// PrequalificationScenario TotalBaseCost
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalBaseCost { get => _totalBaseCost; set => _totalBaseCost = value; }
        private DirtyValue<decimal?> _totalCashAvailable;
        /// <summary>
        /// PrequalificationScenario TotalCashAvailable
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalCashAvailable { get => _totalCashAvailable; set => _totalCashAvailable = value; }
        private DirtyValue<decimal?> _totalCashLeft;
        /// <summary>
        /// PrequalificationScenario TotalCashLeft
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalCashLeft { get => _totalCashLeft; set => _totalCashLeft = value; }
        private DirtyValue<decimal?> _totalCosts;
        /// <summary>
        /// PrequalificationScenario TotalCosts
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalCosts { get => _totalCosts; set => _totalCosts = value; }
        private DirtyValue<decimal?> _totalFinancing;
        /// <summary>
        /// PrequalificationScenario TotalFinancing
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalFinancing { get => _totalFinancing; set => _totalFinancing = value; }
        private DirtyValue<decimal?> _totalHe;
        /// <summary>
        /// PrequalificationScenario TotalHe
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalHe { get => _totalHe; set => _totalHe = value; }
        private DirtyValue<decimal?> _totalIncome;
        /// <summary>
        /// PrequalificationScenario TotalIncome
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalIncome { get => _totalIncome; set => _totalIncome = value; }
        private DirtyValue<decimal?> _totalLoanAmount;
        /// <summary>
        /// PrequalificationScenario TotalLoanAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalLoanAmount { get => _totalLoanAmount; set => _totalLoanAmount = value; }
        private DirtyValue<decimal?> _totalOtherExpense;
        /// <summary>
        /// PrequalificationScenario TotalOtherExpense
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalOtherExpense { get => _totalOtherExpense; set => _totalOtherExpense = value; }
        private DirtyValue<decimal?> _totalPaidOffMortgage;
        /// <summary>
        /// PrequalificationScenario TotalPaidOffMortgage
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalPaidOffMortgage { get => _totalPaidOffMortgage; set => _totalPaidOffMortgage = value; }
        private DirtyValue<decimal?> _totalPaidOffOthers;
        /// <summary>
        /// PrequalificationScenario TotalPaidOffOthers
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalPaidOffOthers { get => _totalPaidOffOthers; set => _totalPaidOffOthers = value; }
        private DirtyValue<decimal?> _totalPayments;
        /// <summary>
        /// PrequalificationScenario TotalPayments
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalPayments { get => _totalPayments; set => _totalPayments = value; }
        internal override bool DirtyInternal
        {
            get => _appraisedValue.Dirty
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
                || _totalPayments.Dirty;
            set
            {
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
            }
        }
    }
}