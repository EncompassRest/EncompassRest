using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LoanPurchaseTransaction
/// </summary>
public sealed partial class LoanPurchaseTransaction : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LoanPurchaseTransaction Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanPurchaseTransaction CreatedById
    /// </summary>
    public string? CreatedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanPurchaseTransaction CreatedByName
    /// </summary>
    public string? CreatedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanPurchaseTransaction CreatedDateTimeUtc
    /// </summary>
    public DateTime? CreatedDateTimeUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LoanPurchaseTransaction CreatedTime
    /// </summary>
    public DateTime? CreatedTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LoanPurchaseTransaction FirstPaymenttoInvestor
    /// </summary>
    public DateTime? FirstPaymenttoInvestor { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LoanPurchaseTransaction Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanPurchaseTransaction Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanPurchaseTransaction Investor
    /// </summary>
    public string? Investor { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanPurchaseTransaction InvestorLoanNumber
    /// </summary>
    public string? InvestorLoanNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanPurchaseTransaction ModifiedById
    /// </summary>
    public string? ModifiedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanPurchaseTransaction ModifiedByName
    /// </summary>
    public string? ModifiedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanPurchaseTransaction ModifiedDateTimeUtc
    /// </summary>
    public DateTime? ModifiedDateTimeUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LoanPurchaseTransaction PurchaseAdivceDate
    /// </summary>
    public DateTime? PurchaseAdivceDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LoanPurchaseTransaction PurchaseAmount
    /// </summary>
    public decimal? PurchaseAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanPurchaseTransaction ServicingPaymentMethod
    /// </summary>
    public string? ServicingPaymentMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanPurchaseTransaction ServicingTransactionType
    /// </summary>
    public string? ServicingTransactionType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanPurchaseTransaction TransactionAmount
    /// </summary>
    public decimal? TransactionAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanPurchaseTransaction TransactionDate
    /// </summary>
    public DateTime? TransactionDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}