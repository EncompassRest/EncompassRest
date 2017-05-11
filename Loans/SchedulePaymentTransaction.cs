using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class SchedulePaymentTransaction
    {
        public string Id { get; set; }
        public decimal? BuydownSubsidyAmountDue { get; set; }
        public string Comments { get; set; }
        public string CreatedById { get; set; }
        public string CreatedByName { get; set; }
        public DateTime? CreatedDateTimeUtc { get; set; }
        public decimal? EscrowDue { get; set; }
        public string Guid { get; set; }
        public decimal? IndexRate { get; set; }
        public decimal? InterestDue { get; set; }
        public decimal? InterestRate { get; set; }
        public DateTime? LatePaymentDate { get; set; }
        public decimal? MiscFeeDue { get; set; }
        public string ModifiedById { get; set; }
        public string ModifiedByName { get; set; }
        public DateTime? ModifiedDateTimeUtc { get; set; }
        public int? PaymentNumber { get; set; }
        public decimal? PrincipalDue { get; set; }
        public string ServicingPaymentMethod { get; set; }
        public string ServicingTransactionType { get; set; }
        public decimal? TotalPastDue { get; set; }
        public decimal? TransactionAmount { get; set; }
        public DateTime? TransactionDate { get; set; }
        public decimal? UnpaidLateFeeDue { get; set; }
        public DateTime? PaymentReceiveDate { get; set; }
        public decimal? EscrowTaxDue { get; set; }
        public decimal? EscrowHazardInsuranceDue { get; set; }
        public decimal? EscrowMortgageInsuranceDue { get; set; }
        public decimal? EscrowFloodInsuranceDue { get; set; }
        public decimal? EscrowCityPropertyTaxDue { get; set; }
        public decimal? EscrowOther1Due { get; set; }
        public decimal? EscrowOther2Due { get; set; }
        public decimal? EscrowOther3Due { get; set; }
        public decimal? EscrowUSDAMonthlyPremiumDue { get; set; }
        public decimal? Principal { get; set; }
        public decimal? Interest { get; set; }
        public decimal? Escrow { get; set; }
        public decimal? MiscFee { get; set; }
        public decimal? LateFee { get; set; }
        public decimal? AdditionalPrincipal { get; set; }
        public decimal? AdditionalEscrow { get; set; }
        public decimal? Taxes { get; set; }
        public decimal? HazardInsurance { get; set; }
        public decimal? MortgageInsurance { get; set; }
        public decimal? FloodInsurance { get; set; }
        public decimal? CityPropertyTax { get; set; }
        public decimal? Other1Escrow { get; set; }
        public decimal? Other2Escrow { get; set; }
        public decimal? Other3Escrow { get; set; }
        public decimal? USDAMonthlyPremium { get; set; }
        public decimal? BuydownSubsidyAmount { get; set; }
    }
}