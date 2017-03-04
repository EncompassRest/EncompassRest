
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class PrequalificationScenario
    {
        public decimal? maximumLoanAmount { get; set; }
        public decimal? ltv { get; set; }
        public decimal? cltv { get; set; }
        public decimal? downPaymentPercent { get; set; }
        public decimal? downPaymentAmount { get; set; }
        public decimal? totalHe { get; set; }
        public decimal? subordinateFin { get; set; }
        public decimal? qualTopRatioPercent { get; set; }
        public decimal? qualBottomRatioPercent { get; set; }
        public int? appraisedValue { get; set; }
        public decimal? monthlyPayment { get; set; }
        public decimal? totalPayments { get; set; }
        public decimal? totalIncome { get; set; }
        public decimal? totalOtherExpense { get; set; }
        public decimal? totalPaidOffMortgage { get; set; }
        public decimal? totalPaidOffOthers { get; set; }
        public decimal? totalBaseCost { get; set; }
        public string comments { get; set; }
        public decimal? totalCashLeft { get; set; }
        public decimal? prepaidItemsEstimatedAmount { get; set; }
        public decimal? totalCosts { get; set; }
        public decimal? totalFinancing { get; set; }
        public decimal? totalCashAvailable { get; set; }
        public decimal? fhaUpfrontMIPremiumPercent { get; set; }
        public decimal? miAndFundingFeeFinancedAmount { get; set; }
        public decimal? totalLoanAmount { get; set; }
        public decimal? grossNegativeCashFlow { get; set; }
        public string currentStatus { get; set; }
        public string creditScore { get; set; }
        public decimal? salesPrice { get; set; }
        public decimal? loanAmount { get; set; }
        public decimal? closingCost { get; set; }
        public decimal? cashToClose { get; set; }
        public decimal? apr { get; set; }
        public decimal? minimumIncome { get; set; }
        public decimal? maximumDebt { get; set; }
        public string id { get; set; }
        public int? prequalificationScenarioIndex { get; set; }

    }
}