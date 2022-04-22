using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// PaymentTransaction
/// </summary>
public sealed partial class PaymentTransaction : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PaymentTransaction AccountHolder
    /// </summary>
    public string? AccountHolder { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction AccountNumber
    /// </summary>
    public string? AccountNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction AdditionalEscrow
    /// </summary>
    public decimal? AdditionalEscrow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction AdditionalPrincipal
    /// </summary>
    public decimal? AdditionalPrincipal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction BuydownSubsidyAmount
    /// </summary>
    public decimal? BuydownSubsidyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction CheckNumber
    /// </summary>
    public string? CheckNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction CommonAmount
    /// </summary>
    public decimal? CommonAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction CommonDate
    /// </summary>
    public DateTime? CommonDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction CreatedById
    /// </summary>
    public string? CreatedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction CreatedByName
    /// </summary>
    public string? CreatedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction CreatedDateTimeUtc
    /// </summary>
    public DateTime? CreatedDateTimeUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction Escrow
    /// </summary>
    public decimal? Escrow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction EscrowCityPropertyTax
    /// </summary>
    public decimal? EscrowCityPropertyTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction EscrowFloodInsurance
    /// </summary>
    public decimal? EscrowFloodInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction EscrowHazardInsurance
    /// </summary>
    public decimal? EscrowHazardInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction EscrowMortgageInsurance
    /// </summary>
    public decimal? EscrowMortgageInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction EscrowOther1
    /// </summary>
    public decimal? EscrowOther1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction EscrowOther2
    /// </summary>
    public decimal? EscrowOther2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction EscrowOther3
    /// </summary>
    public decimal? EscrowOther3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction EscrowTax
    /// </summary>
    public decimal? EscrowTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction EscrowUSDAMonthlyPremium
    /// </summary>
    public decimal? EscrowUSDAMonthlyPremium { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction IndexRate
    /// </summary>
    public decimal? IndexRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction InstitutionName
    /// </summary>
    public string? InstitutionName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction InstitutionRouting
    /// </summary>
    public string? InstitutionRouting { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction Interest
    /// </summary>
    public decimal? Interest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction InterestRate
    /// </summary>
    public decimal? InterestRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction LateFee
    /// </summary>
    public decimal? LateFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction LateFeeIfLate
    /// </summary>
    public decimal? LateFeeIfLate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction LatePaymentDate
    /// </summary>
    public DateTime? LatePaymentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction MiscFee
    /// </summary>
    public decimal? MiscFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction ModifiedById
    /// </summary>
    public string? ModifiedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction ModifiedByName
    /// </summary>
    public string? ModifiedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction ModifiedDateTimeUtc
    /// </summary>
    public DateTime? ModifiedDateTimeUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction PaymentDepositedDate
    /// </summary>
    public DateTime? PaymentDepositedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction PaymentDueDate
    /// </summary>
    public DateTime? PaymentDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction PaymentIndexDate
    /// </summary>
    public DateTime? PaymentIndexDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction PaymentNumber
    /// </summary>
    public int? PaymentNumber { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction PaymentReceivedDate
    /// </summary>
    public DateTime? PaymentReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction Principal
    /// </summary>
    public decimal? Principal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction Reference
    /// </summary>
    public string? Reference { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction SchedulePayLogMiscFee
    /// </summary>
    public decimal? SchedulePayLogMiscFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction ServicingPaymentMethod
    /// </summary>
    public string? ServicingPaymentMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction ServicingTransactionType
    /// </summary>
    public string? ServicingTransactionType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction StatementDate
    /// </summary>
    public DateTime? StatementDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction TotalAmountDue
    /// </summary>
    public decimal? TotalAmountDue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction TotalAmountReceived
    /// </summary>
    public decimal? TotalAmountReceived { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction TransactionAmount
    /// </summary>
    public decimal? TransactionAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentTransaction TransactionDate
    /// </summary>
    public DateTime? TransactionDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}