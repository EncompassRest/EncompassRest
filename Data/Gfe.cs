using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class Gfe
    {
        public decimal? totalSettlementCharges { get; set; }
        public decimal? agregateAdjustment { get; set; }
        public decimal? mortgageBrokerComissionFee { get; set; }
        public List<GfeFee> gfeFees { get; set; }
        public bool? lockField { get; set; }
        public bool? gfeProvidedByBrokerIndicator { get; set; }
        public decimal? fundingAmount { get; set; }
        public string pocPaid1 { get; set; }
        public string pocPaid2 { get; set; }
        public string pocPaid3 { get; set; }
        public decimal? totalOfInitialFees { get; set; }
        public decimal? compensationFromLenderTotalAmount { get; set; }
        public decimal? creditLifeOrDisabilityPremium { get; set; }
        public List<GfePayoff> gfePayoffs { get; set; }
        public decimal? subtotalOfAllDeductions { get; set; }
        public decimal? estimatedCashAtClosing { get; set; }
        public decimal? finalBalloonPayment { get; set; }
        public DateTime? estimatedDueDate { get; set; }
        public bool? prepaymentPenaltyIndicator { get; set; }
        public bool? prepaymentOtherTypeIndicator { get; set; }
        public string paymentOfPrincipleType { get; set; }
        public int? penaltyNotToExceedMonths { get; set; }
        public List<GfeLien> gfeLiens { get; set; }
        public string loanFromBrokerControledFundsType { get; set; }
        public string brokerName { get; set; }
        public string brokerRepresentative { get; set; }
        public decimal? compensationFromLenderPercentage { get; set; }
        public decimal? compensationFromLenderAmount { get; set; }
        public string brokerLicense { get; set; }
        public string representativeLicense { get; set; }
        public string mortgageBrokerComissionFeePaidToName { get; set; }
        public bool? paymentOfPrincipleIndicator { get; set; }
        public decimal? purchasePayOff { get; set; }
        public List<GfePayment> gfePayments { get; set; }
        public decimal? prepaymentPenaltyAmount { get; set; }
        public int? prepaymentPenaltyPeriod { get; set; }
        public string prepaymentOtherDescription { get; set; }
        public decimal? monthlyPaymentAndEscrow { get; set; }
        public decimal? yearlyTax { get; set; }
        public decimal? yearlyInsurance { get; set; }
        public decimal? totalTaxAndInsurance { get; set; }
        public bool? hasPrepaymentPenaltyIndicator { get; set; }
        public decimal? firstChangePercent { get; set; }
        public decimal? firstChangePayment { get; set; }
        public decimal? maxLifePayment { get; set; }
        public string initialFixedOrArmType { get; set; }
        public int? maxPaymentAfterMonth { get; set; }
        public decimal? yearlyMortgageInsurance { get; set; }
        public decimal? yearlyFloodInsurance { get; set; }
        public decimal? yearlyOtherInsurance { get; set; }
        public string yearlyOtherInsuranceDescription { get; set; }
        public bool? sourcesDeemedReliableIndicator { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public bool? hasAdditionalCompensationIndicator { get; set; }
        public decimal? re882AdditionalCompensation { get; set; }
        public decimal? estimatedCashToBorrower { get; set; }
        public decimal? totalMaximumCostsExpenses { get; set; }
        public decimal? brokerCommission { get; set; }
        public decimal? lenderOriginationFee { get; set; }
        public decimal? totalCostsExpenses { get; set; }
        public bool? hasLateChargesIndicator { get; set; }
        public string natureLien1PayoffDescription { get; set; }
        public string natureLien2PayoffDescription { get; set; }
        public string natureLien3PayoffDescription { get; set; }
        public string natureLien1Description { get; set; }
        public string natureLien2Description { get; set; }
        public string natureLien3Description { get; set; }
        public decimal? principalAmount { get; set; }
        public decimal? totalBrokerCompensationAmount { get; set; }
        public decimal? receivedFromLenderAmount { get; set; }
        public decimal? creditToBorrowerAmount { get; set; }
        public decimal? totalClosingCostWithDiscount { get; set; }
        public decimal? totalPrepaidClosingCost { get; set; }
        public string id { get; set; }

    }
}
