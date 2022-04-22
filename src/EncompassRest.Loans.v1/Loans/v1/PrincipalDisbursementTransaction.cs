using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// PrincipalDisbursementTransaction
/// </summary>
public sealed partial class PrincipalDisbursementTransaction : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PrincipalDisbursementTransaction Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrincipalDisbursementTransaction CreatedById
    /// </summary>
    public string? CreatedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrincipalDisbursementTransaction CreatedByName
    /// </summary>
    public string? CreatedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrincipalDisbursementTransaction CreatedDateTimeUtc
    /// </summary>
    public DateTime? CreatedDateTimeUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PrincipalDisbursementTransaction DisbursementDate
    /// </summary>
    public DateTime? DisbursementDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PrincipalDisbursementTransaction Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrincipalDisbursementTransaction Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrincipalDisbursementTransaction InstitutionName
    /// </summary>
    public string? InstitutionName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrincipalDisbursementTransaction ModifiedById
    /// </summary>
    public string? ModifiedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrincipalDisbursementTransaction ModifiedByName
    /// </summary>
    public string? ModifiedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrincipalDisbursementTransaction ModifiedDateTimeUtc
    /// </summary>
    public DateTime? ModifiedDateTimeUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PrincipalDisbursementTransaction ServicingPaymentMethod
    /// </summary>
    public string? ServicingPaymentMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrincipalDisbursementTransaction ServicingTransactionType
    /// </summary>
    public string? ServicingTransactionType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PrincipalDisbursementTransaction TransactionAmount
    /// </summary>
    public decimal? TransactionAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrincipalDisbursementTransaction TransactionDate
    /// </summary>
    public DateTime? TransactionDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}