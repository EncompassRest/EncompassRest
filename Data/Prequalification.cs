
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class Prequalification
    {
        public string numberOfMonths { get; set; }
        public decimal? percentOfHomeAppreciation { get; set; }
        public List<PrequalificationScenario> prequalificationScenarios { get; set; }
        public decimal? downPaymentAmount { get; set; }
        public decimal? maxPropValue { get; set; }
        public decimal? maxLoanLimit { get; set; }
        public decimal? costIncreasePerYear { get; set; }
        public decimal? totalCashFlow { get; set; }
        public decimal? monthlyHomeEquity { get; set; }
        public decimal? totalHomeEquity { get; set; }
        public decimal? monthlyHomeAppreciation { get; set; }
        public decimal? totalHomeAppreciation { get; set; }
        public decimal? percentOfInvestmentInterest { get; set; }
        public decimal? monthlyInvestmentInterest { get; set; }
        public decimal? totalInvestmentInterest { get; set; }
        public decimal? totalHousingExpense { get; set; }
        public decimal? percentOfIncomeTax { get; set; }
        public decimal? monthlyIncomeTax { get; set; }
        public decimal? totalIncomeTax { get; set; }
        public decimal? monthlyBenefit { get; set; }
        public decimal? totalBenefit { get; set; }
        public int? monthlySavings { get; set; }
        public int? totalLoanSavings { get; set; }
        public int? totalPaidOffBalance { get; set; }
        public int? totalPaidOffMonthly { get; set; }
        public int? cashOutBalance { get; set; }
        public int? totalLiabilityPayment { get; set; }
        public int? totalLiabilityUnpaid { get; set; }
        public string qualificationStatus { get; set; }
        public decimal? totalOtherExpenses { get; set; }
        public string withinLimits1 { get; set; }
        public string withinLimits2 { get; set; }
        public string withinLimits3 { get; set; }
        public string withinLimits4 { get; set; }
        public string withinLimits5 { get; set; }
        public string withinLimits6 { get; set; }
        public string withinLimits7 { get; set; }
        public string withinLimits8 { get; set; }
        public string withinLimits9 { get; set; }
        public string favorableOption { get; set; }
        public decimal? avgMoPmtSavings { get; set; }
        public decimal? totalGain { get; set; }
        public decimal? rentersInsurance { get; set; }
        public decimal? beforeTaxRentMoPmt { get; set; }
        public decimal? beforeTaxOwnMoPmt { get; set; }
        public decimal? annualHomeMaintenance { get; set; }
        public decimal? totalRentPmtOverYears { get; set; }
        public decimal? totalOwnPmtOverYears { get; set; }
        public decimal? totalOwnTaxSavings { get; set; }
        public decimal? afterTaxRentMoSavings { get; set; }
        public decimal? afterTaxOwnMoSavings { get; set; }
        public decimal? homeSellingPriceAfterYears { get; set; }
        public decimal? minusLoanBalance { get; set; }
        public decimal? minusDownPmtAndClosingCosts { get; set; }
        public decimal? investmentGain { get; set; }
        public decimal? totalPmtSavings { get; set; }
        public decimal? combinedGain { get; set; }
        public decimal? percentAnnualHomeMaint { get; set; }
        public int? yearsForComparison { get; set; }
        public decimal? rentalCost { get; set; }
        public string id { get; set; }

    }
}