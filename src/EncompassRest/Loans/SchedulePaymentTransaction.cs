using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class SchedulePaymentTransaction
    {
        public JsonNullable<decimal?> AdditionalEscrow { get; set; }
        public JsonNullable<decimal?> AdditionalPrincipal { get; set; }
        public JsonNullable<decimal?> BuydownSubsidyAmount { get; set; }
        public JsonNullable<decimal?> BuydownSubsidyAmountDue { get; set; }
        public JsonNullable<decimal?> CityPropertyTax { get; set; }
        public string Comments { get; set; }
        public string CreatedById { get; set; }
        public string CreatedByName { get; set; }
        public JsonNullable<DateTime?> CreatedDateTimeUtc { get; set; }
        public JsonNullable<decimal?> Escrow { get; set; }
        public JsonNullable<decimal?> EscrowCityPropertyTaxDue { get; set; }
        public JsonNullable<decimal?> EscrowDue { get; set; }
        public JsonNullable<decimal?> EscrowFloodInsuranceDue { get; set; }
        public JsonNullable<decimal?> EscrowHazardInsuranceDue { get; set; }
        public JsonNullable<decimal?> EscrowMortgageInsuranceDue { get; set; }
        public JsonNullable<decimal?> EscrowOther1Due { get; set; }
        public JsonNullable<decimal?> EscrowOther2Due { get; set; }
        public JsonNullable<decimal?> EscrowOther3Due { get; set; }
        public JsonNullable<decimal?> EscrowTaxDue { get; set; }
        public JsonNullable<decimal?> EscrowUSDAMonthlyPremiumDue { get; set; }
        public JsonNullable<decimal?> FloodInsurance { get; set; }
        public string Guid { get; set; }
        public JsonNullable<decimal?> HazardInsurance { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> IndexRate { get; set; }
        public JsonNullable<decimal?> Interest { get; set; }
        public JsonNullable<decimal?> InterestDue { get; set; }
        public JsonNullable<decimal?> InterestRate { get; set; }
        public JsonNullable<decimal?> LateFee { get; set; }
        public JsonNullable<DateTime?> LatePaymentDate { get; set; }
        public JsonNullable<decimal?> MiscFee { get; set; }
        public JsonNullable<decimal?> MiscFeeDue { get; set; }
        public string ModifiedById { get; set; }
        public string ModifiedByName { get; set; }
        public JsonNullable<DateTime?> ModifiedDateTimeUtc { get; set; }
        public JsonNullable<decimal?> MortgageInsurance { get; set; }
        public JsonNullable<decimal?> Other1Escrow { get; set; }
        public JsonNullable<decimal?> Other2Escrow { get; set; }
        public JsonNullable<decimal?> Other3Escrow { get; set; }
        public int? PaymentNumber { get; set; }
        public JsonNullable<DateTime?> PaymentReceiveDate { get; set; }
        public JsonNullable<decimal?> Principal { get; set; }
        public JsonNullable<decimal?> PrincipalDue { get; set; }
        public string ServicingPaymentMethod { get; set; }
        public string ServicingTransactionType { get; set; }
        public JsonNullable<decimal?> Taxes { get; set; }
        public JsonNullable<decimal?> TotalPastDue { get; set; }
        public JsonNullable<decimal?> TransactionAmount { get; set; }
        public JsonNullable<DateTime?> TransactionDate { get; set; }
        public JsonNullable<decimal?> UnpaidLateFeeDue { get; set; }
        public JsonNullable<decimal?> USDAMonthlyPremium { get; set; }
    }
}