using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// OtherTransaction
/// </summary>
public sealed partial class OtherTransaction : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _accountNumber;
    private DirtyValue<string?>? _comments;
    private DirtyValue<string?>? _createdById;
    private DirtyValue<string?>? _createdByName;
    private DirtyValue<DateTime?>? _createdDateTime;
    private DirtyValue<string?>? _guid;
    private DirtyValue<string?>? _institutionName;
    private DirtyValue<string?>? _institutionRouting;
    private DirtyValue<string?>? _modifiedById;
    private DirtyValue<string?>? _modifiedByName;
    private DirtyValue<DateTime?>? _modifiedDateTime;
    private DirtyValue<string?>? _reference;
    private DirtyValue<string?>? _servicingPaymentMethod;
    private DirtyValue<string?>? _servicingTransactionType;
    private DirtyValue<decimal?>? _transactionAmount;
    private DirtyValue<DateTime?>? _transactionDate;

    /// <summary>
    /// OtherTransactionContract AccountNumber
    /// </summary>
    public string? AccountNumber { get => _accountNumber; set => SetField(ref _accountNumber, value); }

    /// <summary>
    /// OtherTransactionContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// OtherTransactionContract CreatedById
    /// </summary>
    public string? CreatedById { get => _createdById; set => SetField(ref _createdById, value); }

    /// <summary>
    /// OtherTransactionContract CreatedByName
    /// </summary>
    public string? CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }

    /// <summary>
    /// OtherTransactionContract CreatedDateTime
    /// </summary>
    public DateTime? CreatedDateTime { get => _createdDateTime; set => SetField(ref _createdDateTime, value); }

    /// <summary>
    /// OtherTransactionContract Guid
    /// </summary>
    public string? Guid { get => _guid; set => SetField(ref _guid, value); }

    /// <summary>
    /// OtherTransactionContract InstitutionName
    /// </summary>
    public string? InstitutionName { get => _institutionName; set => SetField(ref _institutionName, value); }

    /// <summary>
    /// OtherTransactionContract InstitutionRouting
    /// </summary>
    public string? InstitutionRouting { get => _institutionRouting; set => SetField(ref _institutionRouting, value); }

    /// <summary>
    /// OtherTransactionContract ModifiedById
    /// </summary>
    public string? ModifiedById { get => _modifiedById; set => SetField(ref _modifiedById, value); }

    /// <summary>
    /// OtherTransactionContract ModifiedByName
    /// </summary>
    public string? ModifiedByName { get => _modifiedByName; set => SetField(ref _modifiedByName, value); }

    /// <summary>
    /// OtherTransactionContract ModifiedDateTime
    /// </summary>
    public DateTime? ModifiedDateTime { get => _modifiedDateTime; set => SetField(ref _modifiedDateTime, value); }

    /// <summary>
    /// OtherTransactionContract Reference
    /// </summary>
    public string? Reference { get => _reference; set => SetField(ref _reference, value); }

    /// <summary>
    /// OtherTransactionContract ServicingPaymentMethod
    /// </summary>
    public string? ServicingPaymentMethod { get => _servicingPaymentMethod; set => SetField(ref _servicingPaymentMethod, value); }

    /// <summary>
    /// OtherTransactionContract ServicingTransactionType
    /// </summary>
    public string? ServicingTransactionType { get => _servicingTransactionType; set => SetField(ref _servicingTransactionType, value); }

    /// <summary>
    /// OtherTransactionContract TransactionAmount
    /// </summary>
    public decimal? TransactionAmount { get => _transactionAmount; set => SetField(ref _transactionAmount, value); }

    /// <summary>
    /// OtherTransactionContract TransactionDate
    /// </summary>
    public DateTime? TransactionDate { get => _transactionDate; set => SetField(ref _transactionDate, value); }
}