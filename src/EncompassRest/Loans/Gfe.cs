using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe
    {
        public string Address { get; set; }
        public JsonNullable<decimal?> AgregateAdjustment { get; set; }
        public JsonNullable<decimal?> BrokerCommission { get; set; }
        public string BrokerLicense { get; set; }
        public string BrokerName { get; set; }
        public string BrokerRepresentative { get; set; }
        public string City { get; set; }
        public JsonNullable<decimal?> CompensationFromLenderAmount { get; set; }
        public JsonNullable<decimal?> CompensationFromLenderPercentage { get; set; }
        public JsonNullable<decimal?> CompensationFromLenderTotalAmount { get; set; }
        public JsonNullable<decimal?> CreditLifeOrDisabilityPremium { get; set; }
        public JsonNullable<decimal?> CreditToBorrowerAmount { get; set; }
        public JsonNullable<decimal?> EstimatedCashAtClosing { get; set; }
        public JsonNullable<decimal?> EstimatedCashToBorrower { get; set; }
        public JsonNullable<DateTime?> EstimatedDueDate { get; set; }
        public JsonNullable<decimal?> FinalBalloonPayment { get; set; }
        public JsonNullable<decimal?> FirstChangePayment { get; set; }
        public JsonNullable<decimal?> FirstChangePercent { get; set; }
        public JsonNullable<decimal?> FundingAmount { get; set; }
        public JsonNullable<List<GfeFee>> GfeFees { get; set; }
        public JsonNullable<List<GfeLien>> GfeLiens { get; set; }
        public JsonNullable<List<GfePayment>> GfePayments { get; set; }
        public JsonNullable<List<GfePayoff>> GfePayoffs { get; set; }
        public JsonNullable<bool?> GfeProvidedByBrokerIndicator { get; set; }
        public JsonNullable<bool?> HasAdditionalCompensationIndicator { get; set; }
        public JsonNullable<bool?> HasLateChargesIndicator { get; set; }
        public JsonNullable<bool?> HasPrepaymentPenaltyIndicator { get; set; }
        public string Id { get; set; }
        public string InitialFixedOrArmType { get; set; }
        public JsonNullable<decimal?> LenderOriginationFee { get; set; }
        public string LoanFromBrokerControledFundsType { get; set; }
        public JsonNullable<bool?> LockField { get; set; }
        public JsonNullable<decimal?> MaxLifePayment { get; set; }
        public JsonNullable<int?> MaxPaymentAfterMonth { get; set; }
        public JsonNullable<decimal?> MonthlyPaymentAndEscrow { get; set; }
        public JsonNullable<decimal?> MortgageBrokerComissionFee { get; set; }
        public string MortgageBrokerComissionFeePaidToName { get; set; }
        public string NatureLien1Description { get; set; }
        public string NatureLien1PayoffDescription { get; set; }
        public string NatureLien2Description { get; set; }
        public string NatureLien2PayoffDescription { get; set; }
        public string NatureLien3Description { get; set; }
        public string NatureLien3PayoffDescription { get; set; }
        public JsonNullable<bool?> PaymentOfPrincipleIndicator { get; set; }
        public string PaymentOfPrincipleType { get; set; }
        public JsonNullable<int?> PenaltyNotToExceedMonths { get; set; }
        public string PocPaid1 { get; set; }
        public string PocPaid2 { get; set; }
        public string PocPaid3 { get; set; }
        public string PostalCode { get; set; }
        public string PrepaymentOtherDescription { get; set; }
        public JsonNullable<bool?> PrepaymentOtherTypeIndicator { get; set; }
        public JsonNullable<decimal?> PrepaymentPenaltyAmount { get; set; }
        public JsonNullable<bool?> PrepaymentPenaltyIndicator { get; set; }
        public JsonNullable<int?> PrepaymentPenaltyPeriod { get; set; }
        public JsonNullable<decimal?> PrincipalAmount { get; set; }
        public JsonNullable<decimal?> PurchasePayOff { get; set; }
        public JsonNullable<decimal?> Re882AdditionalCompensation { get; set; }
        public JsonNullable<decimal?> ReceivedFromLenderAmount { get; set; }
        public string RepresentativeLicense { get; set; }
        public JsonNullable<bool?> SourcesDeemedReliableIndicator { get; set; }
        public string State { get; set; }
        public JsonNullable<decimal?> SubtotalOfAllDeductions { get; set; }
        public JsonNullable<decimal?> TotalBrokerCompensationAmount { get; set; }
        public JsonNullable<decimal?> TotalClosingCostWithDiscount { get; set; }
        public JsonNullable<decimal?> TotalCostsExpenses { get; set; }
        public JsonNullable<decimal?> TotalMaximumCostsExpenses { get; set; }
        public JsonNullable<decimal?> TotalOfInitialFees { get; set; }
        public JsonNullable<decimal?> TotalPrepaidClosingCost { get; set; }
        public JsonNullable<decimal?> TotalSettlementCharges { get; set; }
        public JsonNullable<decimal?> TotalTaxAndInsurance { get; set; }
        public JsonNullable<decimal?> YearlyFloodInsurance { get; set; }
        public JsonNullable<decimal?> YearlyInsurance { get; set; }
        public JsonNullable<decimal?> YearlyMortgageInsurance { get; set; }
        public JsonNullable<decimal?> YearlyOtherInsurance { get; set; }
        public string YearlyOtherInsuranceDescription { get; set; }
        public JsonNullable<decimal?> YearlyTax { get; set; }
    }
}