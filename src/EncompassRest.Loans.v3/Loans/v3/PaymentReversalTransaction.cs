using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// PaymentReversalTransaction
/// </summary>
public sealed partial class PaymentReversalTransaction : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PaymentReversalTransaction Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentReversalTransaction CreatedById
    /// </summary>
    public string? CreatedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentReversalTransaction CreatedByName
    /// </summary>
    public string? CreatedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentReversalTransaction CreatedDateTime
    /// </summary>
    public DateTime? CreatedDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentReversalTransaction Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentReversalTransaction ModifiedById
    /// </summary>
    public string? ModifiedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentReversalTransaction ModifiedByName
    /// </summary>
    public string? ModifiedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentReversalTransaction ModifiedDateTime
    /// </summary>
    public DateTime? ModifiedDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentReversalTransaction PaymentId
    /// </summary>
    public string? PaymentId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentReversalTransaction ReversalType
    /// </summary>
    public string? ReversalType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentReversalTransaction ServicingPaymentMethod
    /// </summary>
    public string? ServicingPaymentMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentReversalTransaction ServicingTransactionType
    /// </summary>
    public string? ServicingTransactionType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentReversalTransaction TransactionAmount
    /// </summary>
    public decimal? TransactionAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PaymentReversalTransaction TransactionDate
    /// </summary>
    public DateTime? TransactionDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}