using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PrequalificationScenario
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class PrequalificationScenario : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _appraisedValue;
        /// <summary>
        /// PrequalificationScenario AppraisedValue
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? AppraisedValue { get => _appraisedValue; set => SetField(ref _appraisedValue, value); }
        private DirtyValue<decimal?> _apr;
        /// <summary>
        /// PrequalificationScenario Apr
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? Apr { get => _apr; set => SetField(ref _apr, value); }
        private DirtyValue<decimal?> _cashToClose;
        /// <summary>
        /// PrequalificationScenario CashToClose
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? CashToClose { get => _cashToClose; set => SetField(ref _cashToClose, value); }
        private DirtyValue<decimal?> _closingCost;
        /// <summary>
        /// PrequalificationScenario ClosingCost
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? ClosingCost { get => _closingCost; set => SetField(ref _closingCost, value); }
        private DirtyValue<decimal?> _cltv;
        /// <summary>
        /// PrequalificationScenario Cltv
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? Cltv { get => _cltv; set => SetField(ref _cltv, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// PrequalificationScenario Comments
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<string> _creditScore;
        /// <summary>
        /// PrequalificationScenario CreditScore
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CreditScore { get => _creditScore; set => SetField(ref _creditScore, value); }
        private DirtyValue<string> _currentStatus;
        /// <summary>
        /// PrequalificationScenario CurrentStatus
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CurrentStatus { get => _currentStatus; set => SetField(ref _currentStatus, value); }
        private DirtyValue<decimal?> _downPaymentAmount;
        /// <summary>
        /// PrequalificationScenario DownPaymentAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? DownPaymentAmount { get => _downPaymentAmount; set => SetField(ref _downPaymentAmount, value); }
        private DirtyValue<decimal?> _downPaymentPercent;
        /// <summary>
        /// PrequalificationScenario DownPaymentPercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? DownPaymentPercent { get => _downPaymentPercent; set => SetField(ref _downPaymentPercent, value); }
        private DirtyValue<decimal?> _fhaUpfrontMIPremiumPercent;
        /// <summary>
        /// PrequalificationScenario FhaUpfrontMIPremiumPercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? FhaUpfrontMIPremiumPercent { get => _fhaUpfrontMIPremiumPercent; set => SetField(ref _fhaUpfrontMIPremiumPercent, value); }
        private DirtyValue<decimal?> _grossNegativeCashFlow;
        /// <summary>
        /// PrequalificationScenario GrossNegativeCashFlow
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? GrossNegativeCashFlow { get => _grossNegativeCashFlow; set => SetField(ref _grossNegativeCashFlow, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// PrequalificationScenario Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<decimal?> _loanAmount;
        /// <summary>
        /// PrequalificationScenario LoanAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? LoanAmount { get => _loanAmount; set => SetField(ref _loanAmount, value); }
        private DirtyValue<decimal?> _ltv;
        /// <summary>
        /// PrequalificationScenario Ltv
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? Ltv { get => _ltv; set => SetField(ref _ltv, value); }
        private DirtyValue<decimal?> _maximumDebt;
        /// <summary>
        /// PrequalificationScenario MaximumDebt
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MaximumDebt { get => _maximumDebt; set => SetField(ref _maximumDebt, value); }
        private DirtyValue<decimal?> _maximumLoanAmount;
        /// <summary>
        /// PrequalificationScenario MaximumLoanAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MaximumLoanAmount { get => _maximumLoanAmount; set => SetField(ref _maximumLoanAmount, value); }
        private DirtyValue<decimal?> _miAndFundingFeeFinancedAmount;
        /// <summary>
        /// PrequalificationScenario MiAndFundingFeeFinancedAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MiAndFundingFeeFinancedAmount { get => _miAndFundingFeeFinancedAmount; set => SetField(ref _miAndFundingFeeFinancedAmount, value); }
        private DirtyValue<decimal?> _minimumIncome;
        /// <summary>
        /// PrequalificationScenario MinimumIncome
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MinimumIncome { get => _minimumIncome; set => SetField(ref _minimumIncome, value); }
        private DirtyValue<decimal?> _monthlyPayment;
        /// <summary>
        /// PrequalificationScenario MonthlyPayment
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MonthlyPayment { get => _monthlyPayment; set => SetField(ref _monthlyPayment, value); }
        private DirtyValue<decimal?> _prepaidItemsEstimatedAmount;
        /// <summary>
        /// PrequalificationScenario PrepaidItemsEstimatedAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? PrepaidItemsEstimatedAmount { get => _prepaidItemsEstimatedAmount; set => SetField(ref _prepaidItemsEstimatedAmount, value); }
        private DirtyValue<int?> _prequalificationScenarioIndex;
        /// <summary>
        /// PrequalificationScenario PrequalificationScenarioIndex
        /// </summary>
        public int? PrequalificationScenarioIndex { get => _prequalificationScenarioIndex; set => SetField(ref _prequalificationScenarioIndex, value); }
        private DirtyValue<decimal?> _qualBottomRatioPercent;
        /// <summary>
        /// PrequalificationScenario QualBottomRatioPercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? QualBottomRatioPercent { get => _qualBottomRatioPercent; set => SetField(ref _qualBottomRatioPercent, value); }
        private DirtyValue<decimal?> _qualTopRatioPercent;
        /// <summary>
        /// PrequalificationScenario QualTopRatioPercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? QualTopRatioPercent { get => _qualTopRatioPercent; set => SetField(ref _qualTopRatioPercent, value); }
        private DirtyValue<decimal?> _salesPrice;
        /// <summary>
        /// PrequalificationScenario SalesPrice
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? SalesPrice { get => _salesPrice; set => SetField(ref _salesPrice, value); }
        private DirtyValue<decimal?> _subordinateFin;
        /// <summary>
        /// PrequalificationScenario SubordinateFin
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? SubordinateFin { get => _subordinateFin; set => SetField(ref _subordinateFin, value); }
        private DirtyValue<decimal?> _totalBaseCost;
        /// <summary>
        /// PrequalificationScenario TotalBaseCost
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalBaseCost { get => _totalBaseCost; set => SetField(ref _totalBaseCost, value); }
        private DirtyValue<decimal?> _totalCashAvailable;
        /// <summary>
        /// PrequalificationScenario TotalCashAvailable
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalCashAvailable { get => _totalCashAvailable; set => SetField(ref _totalCashAvailable, value); }
        private DirtyValue<decimal?> _totalCashLeft;
        /// <summary>
        /// PrequalificationScenario TotalCashLeft
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalCashLeft { get => _totalCashLeft; set => SetField(ref _totalCashLeft, value); }
        private DirtyValue<decimal?> _totalCosts;
        /// <summary>
        /// PrequalificationScenario TotalCosts
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalCosts { get => _totalCosts; set => SetField(ref _totalCosts, value); }
        private DirtyValue<decimal?> _totalFinancing;
        /// <summary>
        /// PrequalificationScenario TotalFinancing
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalFinancing { get => _totalFinancing; set => SetField(ref _totalFinancing, value); }
        private DirtyValue<decimal?> _totalHe;
        /// <summary>
        /// PrequalificationScenario TotalHe
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalHe { get => _totalHe; set => SetField(ref _totalHe, value); }
        private DirtyValue<decimal?> _totalIncome;
        /// <summary>
        /// PrequalificationScenario TotalIncome
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalIncome { get => _totalIncome; set => SetField(ref _totalIncome, value); }
        private DirtyValue<decimal?> _totalLoanAmount;
        /// <summary>
        /// PrequalificationScenario TotalLoanAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalLoanAmount { get => _totalLoanAmount; set => SetField(ref _totalLoanAmount, value); }
        private DirtyValue<decimal?> _totalOtherExpense;
        /// <summary>
        /// PrequalificationScenario TotalOtherExpense
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalOtherExpense { get => _totalOtherExpense; set => SetField(ref _totalOtherExpense, value); }
        private DirtyValue<decimal?> _totalPaidOffMortgage;
        /// <summary>
        /// PrequalificationScenario TotalPaidOffMortgage
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalPaidOffMortgage { get => _totalPaidOffMortgage; set => SetField(ref _totalPaidOffMortgage, value); }
        private DirtyValue<decimal?> _totalPaidOffOthers;
        /// <summary>
        /// PrequalificationScenario TotalPaidOffOthers
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalPaidOffOthers { get => _totalPaidOffOthers; set => SetField(ref _totalPaidOffOthers, value); }
        private DirtyValue<decimal?> _totalPayments;
        /// <summary>
        /// PrequalificationScenario TotalPayments
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalPayments { get => _totalPayments; set => SetField(ref _totalPayments, value); }
    }
}