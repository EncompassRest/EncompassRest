using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// EscrowDisbursementTransaction
/// </summary>
public sealed partial class EscrowDisbursementTransaction : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// EscrowDisbursementTransaction Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowDisbursementTransaction CreatedById
    /// </summary>
    public string? CreatedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowDisbursementTransaction CreatedByName
    /// </summary>
    public string? CreatedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowDisbursementTransaction CreatedDateTime
    /// </summary>
    public DateTime? CreatedDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowDisbursementTransaction DisbursementDueDate
    /// </summary>
    public DateTime? DisbursementDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowDisbursementTransaction DisbursementNumber
    /// </summary>
    public int? DisbursementNumber { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowDisbursementTransaction DisbursementType
    /// </summary>
    public string? DisbursementType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowDisbursementTransaction Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowDisbursementTransaction InstitutionName
    /// </summary>
    public string? InstitutionName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowDisbursementTransaction ModifiedById
    /// </summary>
    public string? ModifiedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowDisbursementTransaction ModifiedByName
    /// </summary>
    public string? ModifiedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowDisbursementTransaction ModifiedDateTime
    /// </summary>
    public DateTime? ModifiedDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowDisbursementTransaction ServicingPaymentMethod
    /// </summary>
    public string? ServicingPaymentMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowDisbursementTransaction ServicingTransactionType
    /// </summary>
    public string? ServicingTransactionType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowDisbursementTransaction TransactionAmount
    /// </summary>
    public decimal? TransactionAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowDisbursementTransaction TransactionDate
    /// </summary>
    public DateTime? TransactionDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}