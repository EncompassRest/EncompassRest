using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class PrequalificationScenario
    {
        public JsonNullable<int?> AppraisedValue { get; set; }
        public JsonNullable<decimal?> Apr { get; set; }
        public JsonNullable<decimal?> CashToClose { get; set; }
        public JsonNullable<decimal?> ClosingCost { get; set; }
        public JsonNullable<decimal?> Cltv { get; set; }
        public string Comments { get; set; }
        public string CreditScore { get; set; }
        public string CurrentStatus { get; set; }
        public JsonNullable<decimal?> DownPaymentAmount { get; set; }
        public JsonNullable<decimal?> DownPaymentPercent { get; set; }
        public JsonNullable<decimal?> FhaUpfrontMIPremiumPercent { get; set; }
        public JsonNullable<decimal?> GrossNegativeCashFlow { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> LoanAmount { get; set; }
        public JsonNullable<decimal?> Ltv { get; set; }
        public JsonNullable<decimal?> MaximumDebt { get; set; }
        public JsonNullable<decimal?> MaximumLoanAmount { get; set; }
        public JsonNullable<decimal?> MiAndFundingFeeFinancedAmount { get; set; }
        public JsonNullable<decimal?> MinimumIncome { get; set; }
        public JsonNullable<decimal?> MonthlyPayment { get; set; }
        public JsonNullable<decimal?> PrepaidItemsEstimatedAmount { get; set; }
        public int? PrequalificationScenarioIndex { get; set; }
        public JsonNullable<decimal?> QualBottomRatioPercent { get; set; }
        public JsonNullable<decimal?> QualTopRatioPercent { get; set; }
        public JsonNullable<decimal?> SalesPrice { get; set; }
        public JsonNullable<decimal?> SubordinateFin { get; set; }
        public JsonNullable<decimal?> TotalBaseCost { get; set; }
        public JsonNullable<decimal?> TotalCashAvailable { get; set; }
        public JsonNullable<decimal?> TotalCashLeft { get; set; }
        public JsonNullable<decimal?> TotalCosts { get; set; }
        public JsonNullable<decimal?> TotalFinancing { get; set; }
        public JsonNullable<decimal?> TotalHe { get; set; }
        public JsonNullable<decimal?> TotalIncome { get; set; }
        public JsonNullable<decimal?> TotalLoanAmount { get; set; }
        public JsonNullable<decimal?> TotalOtherExpense { get; set; }
        public JsonNullable<decimal?> TotalPaidOffMortgage { get; set; }
        public JsonNullable<decimal?> TotalPaidOffOthers { get; set; }
        public JsonNullable<decimal?> TotalPayments { get; set; }
    }
}