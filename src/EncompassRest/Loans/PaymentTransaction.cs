using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class PaymentTransaction
    {
        public string AccountHolder { get; set; }
        public string AccountNumber { get; set; }
        public JsonNullable<decimal?> AdditionalEscrow { get; set; }
        public JsonNullable<decimal?> AdditionalPrincipal { get; set; }
        public JsonNullable<decimal?> BuydownSubsidyAmount { get; set; }
        public string CheckNumber { get; set; }
        public string Comments { get; set; }
        public JsonNullable<decimal?> CommonAmount { get; set; }
        public JsonNullable<DateTime?> CommonDate { get; set; }
        public string CreatedById { get; set; }
        public string CreatedByName { get; set; }
        public JsonNullable<DateTime?> CreatedDateTimeUtc { get; set; }
        public JsonNullable<decimal?> Escrow { get; set; }
        public JsonNullable<decimal?> EscrowCityPropertyTax { get; set; }
        public JsonNullable<decimal?> EscrowFloodInsurance { get; set; }
        public JsonNullable<decimal?> EscrowHazardInsurance { get; set; }
        public JsonNullable<decimal?> EscrowMortgageInsurance { get; set; }
        public JsonNullable<decimal?> EscrowOther1 { get; set; }
        public JsonNullable<decimal?> EscrowOther2 { get; set; }
        public JsonNullable<decimal?> EscrowOther3 { get; set; }
        public JsonNullable<decimal?> EscrowTax { get; set; }
        public JsonNullable<decimal?> EscrowUSDAMonthlyPremium { get; set; }
        public string Guid { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> IndexRate { get; set; }
        public string InstitutionName { get; set; }
        public string InstitutionRouting { get; set; }
        public JsonNullable<decimal?> Interest { get; set; }
        public JsonNullable<decimal?> InterestRate { get; set; }
        public JsonNullable<decimal?> LateFee { get; set; }
        public JsonNullable<decimal?> LateFeeIfLate { get; set; }
        public JsonNullable<DateTime?> LatePaymentDate { get; set; }
        public JsonNullable<decimal?> MiscFee { get; set; }
        public string ModifiedById { get; set; }
        public string ModifiedByName { get; set; }
        public JsonNullable<DateTime?> ModifiedDateTimeUtc { get; set; }
        public JsonNullable<DateTime?> PaymentDepositedDate { get; set; }
        public JsonNullable<DateTime?> PaymentDueDate { get; set; }
        public JsonNullable<DateTime?> PaymentIndexDate { get; set; }
        public int? PaymentNumber { get; set; }
        public JsonNullable<DateTime?> PaymentReceivedDate { get; set; }
        public JsonNullable<decimal?> Principal { get; set; }
        public string Reference { get; set; }
        public JsonNullable<decimal?> SchedulePayLogMiscFee { get; set; }
        public string ServicingPaymentMethod { get; set; }
        public string ServicingTransactionType { get; set; }
        public JsonNullable<DateTime?> StatementDate { get; set; }
        public JsonNullable<decimal?> TotalAmountDue { get; set; }
        public JsonNullable<decimal?> TotalAmountReceived { get; set; }
        public JsonNullable<decimal?> TransactionAmount { get; set; }
        public JsonNullable<DateTime?> TransactionDate { get; set; }
    }
}