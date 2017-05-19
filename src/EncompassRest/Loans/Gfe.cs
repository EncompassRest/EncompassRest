using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Gfe
    {
        public decimal? TotalSettlementCharges { get; set; }
        public decimal? AgregateAdjustment { get; set; }
        public decimal? MortgageBrokerComissionFee { get; set; }
        public List<GfeFee> GfeFees { get; set; }
        public bool? LockField { get; set; }
        public bool? GfeProvidedByBrokerIndicator { get; set; }
        public decimal? FundingAmount { get; set; }
        public string PocPaid1 { get; set; }
        public string PocPaid2 { get; set; }
        public string PocPaid3 { get; set; }
        public decimal? TotalOfInitialFees { get; set; }
        public decimal? CompensationFromLenderTotalAmount { get; set; }
        public decimal? CreditLifeOrDisabilityPremium { get; set; }
        public List<GfePayoff> GfePayoffs { get; set; }
        public decimal? SubtotalOfAllDeductions { get; set; }
        public decimal? EstimatedCashAtClosing { get; set; }
        public decimal? FinalBalloonPayment { get; set; }
        public DateTime? EstimatedDueDate { get; set; }
        public bool? PrepaymentPenaltyIndicator { get; set; }
        public bool? PrepaymentOtherTypeIndicator { get; set; }
        public string PaymentOfPrincipleType { get; set; }
        public int? PenaltyNotToExceedMonths { get; set; }
        public List<GfeLien> GfeLiens { get; set; }
        public string LoanFromBrokerControledFundsType { get; set; }
        public string BrokerName { get; set; }
        public string BrokerRepresentative { get; set; }
        public decimal? CompensationFromLenderPercentage { get; set; }
        public decimal? CompensationFromLenderAmount { get; set; }
        public string BrokerLicense { get; set; }
        public string RepresentativeLicense { get; set; }
        public string MortgageBrokerComissionFeePaidToName { get; set; }
        public bool? PaymentOfPrincipleIndicator { get; set; }
        public decimal? PurchasePayOff { get; set; }
        public List<GfePayment> GfePayments { get; set; }
        public decimal? PrepaymentPenaltyAmount { get; set; }
        public int? PrepaymentPenaltyPeriod { get; set; }
        public string PrepaymentOtherDescription { get; set; }
        public decimal? MonthlyPaymentAndEscrow { get; set; }
        public decimal? YearlyTax { get; set; }
        public decimal? YearlyInsurance { get; set; }
        public decimal? TotalTaxAndInsurance { get; set; }
        public bool? HasPrepaymentPenaltyIndicator { get; set; }
        public decimal? FirstChangePercent { get; set; }
        public decimal? FirstChangePayment { get; set; }
        public decimal? MaxLifePayment { get; set; }
        public string InitialFixedOrArmType { get; set; }
        public int? MaxPaymentAfterMonth { get; set; }
        public decimal? YearlyMortgageInsurance { get; set; }
        public decimal? YearlyFloodInsurance { get; set; }
        public decimal? YearlyOtherInsurance { get; set; }
        public string YearlyOtherInsuranceDescription { get; set; }
        public bool? SourcesDeemedReliableIndicator { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public bool? HasAdditionalCompensationIndicator { get; set; }
        public decimal? Re882AdditionalCompensation { get; set; }
        public decimal? EstimatedCashToBorrower { get; set; }
        public decimal? TotalMaximumCostsExpenses { get; set; }
        public decimal? BrokerCommission { get; set; }
        public decimal? LenderOriginationFee { get; set; }
        public decimal? TotalCostsExpenses { get; set; }
        public bool? HasLateChargesIndicator { get; set; }
        public string NatureLien1PayoffDescription { get; set; }
        public string NatureLien2PayoffDescription { get; set; }
        public string NatureLien3PayoffDescription { get; set; }
        public string NatureLien1Description { get; set; }
        public string NatureLien2Description { get; set; }
        public string NatureLien3Description { get; set; }
        public decimal? PrincipalAmount { get; set; }
        public decimal? TotalBrokerCompensationAmount { get; set; }
        public decimal? ReceivedFromLenderAmount { get; set; }
        public decimal? CreditToBorrowerAmount { get; set; }
        public decimal? TotalClosingCostWithDiscount { get; set; }
        public decimal? TotalPrepaidClosingCost { get; set; }
        public string Id { get; set; }
    }
}