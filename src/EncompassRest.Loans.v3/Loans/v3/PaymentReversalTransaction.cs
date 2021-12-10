using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// PaymentReversalTransaction
/// </summary>
public sealed partial class PaymentReversalTransaction : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _comments;
    private DirtyValue<string?>? _createdById;
    private DirtyValue<string?>? _createdByName;
    private DirtyValue<DateTime?>? _createdDateTime;
    private DirtyValue<string?>? _guid;
    private DirtyValue<string?>? _modifiedById;
    private DirtyValue<string?>? _modifiedByName;
    private DirtyValue<DateTime?>? _modifiedDateTime;
    private DirtyValue<string?>? _paymentId;
    private DirtyValue<string?>? _reversalType;
    private DirtyValue<string?>? _servicingPaymentMethod;
    private DirtyValue<string?>? _servicingTransactionType;
    private DirtyValue<decimal?>? _transactionAmount;
    private DirtyValue<DateTime?>? _transactionDate;

    /// <summary>
    /// PaymentReversalTransactionContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// PaymentReversalTransactionContract CreatedById
    /// </summary>
    public string? CreatedById { get => _createdById; set => SetField(ref _createdById, value); }

    /// <summary>
    /// PaymentReversalTransactionContract CreatedByName
    /// </summary>
    public string? CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }

    /// <summary>
    /// PaymentReversalTransactionContract CreatedDateTime
    /// </summary>
    public DateTime? CreatedDateTime { get => _createdDateTime; set => SetField(ref _createdDateTime, value); }

    /// <summary>
    /// PaymentReversalTransactionContract Guid
    /// </summary>
    public string? Guid { get => _guid; set => SetField(ref _guid, value); }

    /// <summary>
    /// PaymentReversalTransactionContract ModifiedById
    /// </summary>
    public string? ModifiedById { get => _modifiedById; set => SetField(ref _modifiedById, value); }

    /// <summary>
    /// PaymentReversalTransactionContract ModifiedByName
    /// </summary>
    public string? ModifiedByName { get => _modifiedByName; set => SetField(ref _modifiedByName, value); }

    /// <summary>
    /// PaymentReversalTransactionContract ModifiedDateTime
    /// </summary>
    public DateTime? ModifiedDateTime { get => _modifiedDateTime; set => SetField(ref _modifiedDateTime, value); }

    /// <summary>
    /// PaymentReversalTransactionContract PaymentId
    /// </summary>
    public string? PaymentId { get => _paymentId; set => SetField(ref _paymentId, value); }

    /// <summary>
    /// PaymentReversalTransactionContract ReversalType
    /// </summary>
    public string? ReversalType { get => _reversalType; set => SetField(ref _reversalType, value); }

    /// <summary>
    /// PaymentReversalTransactionContract ServicingPaymentMethod
    /// </summary>
    public string? ServicingPaymentMethod { get => _servicingPaymentMethod; set => SetField(ref _servicingPaymentMethod, value); }

    /// <summary>
    /// PaymentReversalTransactionContract ServicingTransactionType
    /// </summary>
    public string? ServicingTransactionType { get => _servicingTransactionType; set => SetField(ref _servicingTransactionType, value); }

    /// <summary>
    /// PaymentReversalTransactionContract TransactionAmount
    /// </summary>
    public decimal? TransactionAmount { get => _transactionAmount; set => SetField(ref _transactionAmount, value); }

    /// <summary>
    /// PaymentReversalTransactionContract TransactionDate
    /// </summary>
    public DateTime? TransactionDate { get => _transactionDate; set => SetField(ref _transactionDate, value); }
}