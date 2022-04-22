using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// EscrowInterestTransaction
/// </summary>
public sealed partial class EscrowInterestTransaction : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// EscrowInterestTransaction Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowInterestTransaction CreatedById
    /// </summary>
    public string? CreatedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowInterestTransaction CreatedByName
    /// </summary>
    public string? CreatedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowInterestTransaction CreatedDateTimeUtc
    /// </summary>
    public DateTime? CreatedDateTimeUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowInterestTransaction Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowInterestTransaction Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowInterestTransaction ModifiedById
    /// </summary>
    public string? ModifiedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowInterestTransaction ModifiedByName
    /// </summary>
    public string? ModifiedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowInterestTransaction ModifiedDateTimeUtc
    /// </summary>
    public DateTime? ModifiedDateTimeUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowInterestTransaction ServicingPaymentMethod
    /// </summary>
    public string? ServicingPaymentMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowInterestTransaction ServicingTransactionType
    /// </summary>
    public string? ServicingTransactionType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowInterestTransaction TransactionAmount
    /// </summary>
    public decimal? TransactionAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EscrowInterestTransaction TransactionDate
    /// </summary>
    public DateTime? TransactionDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}