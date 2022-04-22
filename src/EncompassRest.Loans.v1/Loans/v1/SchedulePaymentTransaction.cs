using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// SchedulePaymentTransaction
/// </summary>
public sealed partial class SchedulePaymentTransaction : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// SchedulePaymentTransaction AdditionalEscrow
    /// </summary>
    public decimal? AdditionalEscrow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction AdditionalPrincipal
    /// </summary>
    public decimal? AdditionalPrincipal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction BuydownSubsidyAmount
    /// </summary>
    public decimal? BuydownSubsidyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction BuydownSubsidyAmountDue
    /// </summary>
    public decimal? BuydownSubsidyAmountDue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction CityPropertyTax
    /// </summary>
    public decimal? CityPropertyTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction CreatedById
    /// </summary>
    public string? CreatedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction CreatedByName
    /// </summary>
    public string? CreatedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction CreatedDateTimeUtc
    /// </summary>
    public DateTime? CreatedDateTimeUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction Escrow
    /// </summary>
    public decimal? Escrow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction EscrowCityPropertyTaxDue
    /// </summary>
    public decimal? EscrowCityPropertyTaxDue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction EscrowDue
    /// </summary>
    public decimal? EscrowDue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction EscrowFloodInsuranceDue
    /// </summary>
    public decimal? EscrowFloodInsuranceDue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction EscrowHazardInsuranceDue
    /// </summary>
    public decimal? EscrowHazardInsuranceDue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction EscrowMortgageInsuranceDue
    /// </summary>
    public decimal? EscrowMortgageInsuranceDue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction EscrowOther1Due
    /// </summary>
    public decimal? EscrowOther1Due { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction EscrowOther2Due
    /// </summary>
    public decimal? EscrowOther2Due { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction EscrowOther3Due
    /// </summary>
    public decimal? EscrowOther3Due { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction EscrowTaxDue
    /// </summary>
    public decimal? EscrowTaxDue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction EscrowUSDAMonthlyPremiumDue
    /// </summary>
    public decimal? EscrowUSDAMonthlyPremiumDue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction FloodInsurance
    /// </summary>
    public decimal? FloodInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction HazardInsurance
    /// </summary>
    public decimal? HazardInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction IndexRate
    /// </summary>
    public decimal? IndexRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction Interest
    /// </summary>
    public decimal? Interest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction InterestDue
    /// </summary>
    public decimal? InterestDue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction InterestRate
    /// </summary>
    public decimal? InterestRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction LateFee
    /// </summary>
    public decimal? LateFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction LatePaymentDate
    /// </summary>
    public DateTime? LatePaymentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction MiscFee
    /// </summary>
    public decimal? MiscFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction MiscFeeDue
    /// </summary>
    public decimal? MiscFeeDue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction ModifiedById
    /// </summary>
    public string? ModifiedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction ModifiedByName
    /// </summary>
    public string? ModifiedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction ModifiedDateTimeUtc
    /// </summary>
    public DateTime? ModifiedDateTimeUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction MortgageInsurance
    /// </summary>
    public decimal? MortgageInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction Other1Escrow
    /// </summary>
    public decimal? Other1Escrow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction Other2Escrow
    /// </summary>
    public decimal? Other2Escrow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction Other3Escrow
    /// </summary>
    public decimal? Other3Escrow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction PaymentNumber
    /// </summary>
    public int? PaymentNumber { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction PaymentReceiveDate
    /// </summary>
    public DateTime? PaymentReceiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction Principal
    /// </summary>
    public decimal? Principal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction PrincipalDue
    /// </summary>
    public decimal? PrincipalDue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction ServicingPaymentMethod
    /// </summary>
    public string? ServicingPaymentMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction ServicingTransactionType
    /// </summary>
    public string? ServicingTransactionType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction Taxes
    /// </summary>
    public decimal? Taxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction TotalPastDue
    /// </summary>
    public decimal? TotalPastDue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction TransactionAmount
    /// </summary>
    public decimal? TransactionAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction TransactionDate
    /// </summary>
    public DateTime? TransactionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction UnpaidLateFeeDue
    /// </summary>
    public decimal? UnpaidLateFeeDue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SchedulePaymentTransaction USDAMonthlyPremium
    /// </summary>
    public decimal? USDAMonthlyPremium { get => GetValue<decimal?>(); set => SetValue(value); }
}