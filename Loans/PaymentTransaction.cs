using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class PaymentTransaction
    {
        public string Id { get; set; }
        public string AccountHolder { get; set; }
        public string AccountNumber { get; set; }
        public decimal? AdditionalEscrow { get; set; }
        public decimal? AdditionalPrincipal { get; set; }
        public decimal? BuydownSubsidyAmount { get; set; }
        public string CheckNumber { get; set; }
        public string Comments { get; set; }
        public decimal? CommonAmount { get; set; }
        public DateTime? CommonDate { get; set; }
        public string CreatedById { get; set; }
        public string CreatedByName { get; set; }
        public DateTime? CreatedDateTimeUtc { get; set; }
        public decimal? Escrow { get; set; }
        public string Guid { get; set; }
        public decimal? IndexRate { get; set; }
        public string InstitutionName { get; set; }
        public string InstitutionRouting { get; set; }
        public decimal? Interest { get; set; }
        public decimal? InterestRate { get; set; }
        public decimal? LateFee { get; set; }
        public decimal? LateFeeIfLate { get; set; }
        public DateTime? LatePaymentDate { get; set; }
        public decimal? MiscFee { get; set; }
        public string ModifiedById { get; set; }
        public string ModifiedByName { get; set; }
        public DateTime? ModifiedDateTimeUtc { get; set; }
        public DateTime? PaymentDepositedDate { get; set; }
        public DateTime? PaymentDueDate { get; set; }
        public DateTime? PaymentIndexDate { get; set; }
        public int? PaymentNumber { get; set; }
        public DateTime? PaymentReceivedDate { get; set; }
        public decimal? Principal { get; set; }
        public string Reference { get; set; }
        public string ServicingPaymentMethod { get; set; }
        public string ServicingTransactionType { get; set; }
        public DateTime? StatementDate { get; set; }
        public decimal? TotalAmountDue { get; set; }
        public decimal? TotalAmountReceived { get; set; }
        public decimal? TransactionAmount { get; set; }
        public DateTime? TransactionDate { get; set; }
        public decimal? EscrowUSDAMonthlyPremium { get; set; }
        public decimal? SchedulePayLogMiscFee { get; set; }
        public decimal? EscrowTax { get; set; }
        public decimal? EscrowMortgageInsurance { get; set; }
        public decimal? EscrowHazardInsurance { get; set; }
        public decimal? EscrowFloodInsurance { get; set; }
        public decimal? EscrowCityPropertyTax { get; set; }
        public decimal? EscrowOther1 { get; set; }
        public decimal? EscrowOther2 { get; set; }
        public decimal? EscrowOther3 { get; set; }
    }
}