using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class PrequalificationScenario
    {
        public decimal? MaximumLoanAmount { get; set; }
        public decimal? Ltv { get; set; }
        public decimal? Cltv { get; set; }
        public decimal? DownPaymentPercent { get; set; }
        public decimal? DownPaymentAmount { get; set; }
        public decimal? TotalHe { get; set; }
        public decimal? SubordinateFin { get; set; }
        public decimal? QualTopRatioPercent { get; set; }
        public decimal? QualBottomRatioPercent { get; set; }
        public int? AppraisedValue { get; set; }
        public decimal? MonthlyPayment { get; set; }
        public decimal? TotalPayments { get; set; }
        public decimal? TotalIncome { get; set; }
        public decimal? TotalOtherExpense { get; set; }
        public decimal? TotalPaidOffMortgage { get; set; }
        public decimal? TotalPaidOffOthers { get; set; }
        public decimal? TotalBaseCost { get; set; }
        public string Comments { get; set; }
        public decimal? TotalCashLeft { get; set; }
        public decimal? PrepaidItemsEstimatedAmount { get; set; }
        public decimal? TotalCosts { get; set; }
        public decimal? TotalFinancing { get; set; }
        public decimal? TotalCashAvailable { get; set; }
        public decimal? FhaUpfrontMIPremiumPercent { get; set; }
        public decimal? MiAndFundingFeeFinancedAmount { get; set; }
        public decimal? TotalLoanAmount { get; set; }
        public decimal? GrossNegativeCashFlow { get; set; }
        public string CurrentStatus { get; set; }
        public string CreditScore { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? LoanAmount { get; set; }
        public decimal? ClosingCost { get; set; }
        public decimal? CashToClose { get; set; }
        public decimal? Apr { get; set; }
        public decimal? MinimumIncome { get; set; }
        public decimal? MaximumDebt { get; set; }
        public string Id { get; set; }
        public int? PrequalificationScenarioIndex { get; set; }
    }
}