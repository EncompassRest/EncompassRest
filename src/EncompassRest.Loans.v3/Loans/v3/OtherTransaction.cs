using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// OtherTransaction
/// </summary>
public sealed partial class OtherTransaction : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// OtherTransaction AccountNumber
    /// </summary>
    public string? AccountNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherTransaction Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherTransaction CreatedById
    /// </summary>
    public string? CreatedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherTransaction CreatedByName
    /// </summary>
    public string? CreatedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherTransaction CreatedDateTime
    /// </summary>
    public DateTime? CreatedDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// OtherTransaction Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherTransaction InstitutionName
    /// </summary>
    public string? InstitutionName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherTransaction InstitutionRouting
    /// </summary>
    public string? InstitutionRouting { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherTransaction ModifiedById
    /// </summary>
    public string? ModifiedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherTransaction ModifiedByName
    /// </summary>
    public string? ModifiedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherTransaction ModifiedDateTime
    /// </summary>
    public DateTime? ModifiedDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// OtherTransaction Reference
    /// </summary>
    public string? Reference { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherTransaction ServicingPaymentMethod
    /// </summary>
    public string? ServicingPaymentMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherTransaction ServicingTransactionType
    /// </summary>
    public string? ServicingTransactionType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherTransaction TransactionAmount
    /// </summary>
    public decimal? TransactionAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// OtherTransaction TransactionDate
    /// </summary>
    public DateTime? TransactionDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}