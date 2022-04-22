using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// InterimServicingTransaction
/// </summary>
public sealed partial class InterimServicingTransaction : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// InterimServicingTransaction Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicingTransaction CreatedById
    /// </summary>
    public string? CreatedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicingTransaction CreatedByName
    /// </summary>
    public string? CreatedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicingTransaction CreatedDateTimeUtc
    /// </summary>
    public DateTime? CreatedDateTimeUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicingTransaction Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicingTransaction Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicingTransaction ModifiedById
    /// </summary>
    public string? ModifiedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicingTransaction ModifiedByName
    /// </summary>
    public string? ModifiedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicingTransaction ModifiedDateTimeUtc
    /// </summary>
    public DateTime? ModifiedDateTimeUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicingTransaction ServicingPaymentMethod
    /// </summary>
    public string? ServicingPaymentMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicingTransaction ServicingTransactionType
    /// </summary>
    public string? ServicingTransactionType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicingTransaction TransactionAmount
    /// </summary>
    public decimal? TransactionAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicingTransaction TransactionDate
    /// </summary>
    public DateTime? TransactionDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}