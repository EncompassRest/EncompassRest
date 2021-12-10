using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// EscrowDisbursementTransaction
/// </summary>
public sealed partial class EscrowDisbursementTransaction : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _comments;
    private DirtyValue<string?>? _createdById;
    private DirtyValue<string?>? _createdByName;
    private DirtyValue<DateTime?>? _createdDateTime;
    private DirtyValue<DateTime?>? _disbursementDueDate;
    private DirtyValue<int?>? _disbursementNumber;
    private DirtyValue<string?>? _disbursementType;
    private DirtyValue<string?>? _guid;
    private DirtyValue<string?>? _institutionName;
    private DirtyValue<string?>? _modifiedById;
    private DirtyValue<string?>? _modifiedByName;
    private DirtyValue<DateTime?>? _modifiedDateTime;
    private DirtyValue<string?>? _servicingPaymentMethod;
    private DirtyValue<string?>? _servicingTransactionType;
    private DirtyValue<decimal?>? _transactionAmount;
    private DirtyValue<DateTime?>? _transactionDate;

    /// <summary>
    /// EscrowDisbursementTransactionContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// EscrowDisbursementTransactionContract CreatedById
    /// </summary>
    public string? CreatedById { get => _createdById; set => SetField(ref _createdById, value); }

    /// <summary>
    /// EscrowDisbursementTransactionContract CreatedByName
    /// </summary>
    public string? CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }

    /// <summary>
    /// EscrowDisbursementTransactionContract CreatedDateTime
    /// </summary>
    public DateTime? CreatedDateTime { get => _createdDateTime; set => SetField(ref _createdDateTime, value); }

    /// <summary>
    /// EscrowDisbursementTransactionContract DisbursementDueDate
    /// </summary>
    public DateTime? DisbursementDueDate { get => _disbursementDueDate; set => SetField(ref _disbursementDueDate, value); }

    /// <summary>
    /// EscrowDisbursementTransactionContract DisbursementNumber
    /// </summary>
    public int? DisbursementNumber { get => _disbursementNumber; set => SetField(ref _disbursementNumber, value); }

    /// <summary>
    /// EscrowDisbursementTransactionContract DisbursementType
    /// </summary>
    public string? DisbursementType { get => _disbursementType; set => SetField(ref _disbursementType, value); }

    /// <summary>
    /// EscrowDisbursementTransactionContract Guid
    /// </summary>
    public string? Guid { get => _guid; set => SetField(ref _guid, value); }

    /// <summary>
    /// EscrowDisbursementTransactionContract InstitutionName
    /// </summary>
    public string? InstitutionName { get => _institutionName; set => SetField(ref _institutionName, value); }

    /// <summary>
    /// EscrowDisbursementTransactionContract ModifiedById
    /// </summary>
    public string? ModifiedById { get => _modifiedById; set => SetField(ref _modifiedById, value); }

    /// <summary>
    /// EscrowDisbursementTransactionContract ModifiedByName
    /// </summary>
    public string? ModifiedByName { get => _modifiedByName; set => SetField(ref _modifiedByName, value); }

    /// <summary>
    /// EscrowDisbursementTransactionContract ModifiedDateTime
    /// </summary>
    public DateTime? ModifiedDateTime { get => _modifiedDateTime; set => SetField(ref _modifiedDateTime, value); }

    /// <summary>
    /// EscrowDisbursementTransactionContract ServicingPaymentMethod
    /// </summary>
    public string? ServicingPaymentMethod { get => _servicingPaymentMethod; set => SetField(ref _servicingPaymentMethod, value); }

    /// <summary>
    /// EscrowDisbursementTransactionContract ServicingTransactionType
    /// </summary>
    public string? ServicingTransactionType { get => _servicingTransactionType; set => SetField(ref _servicingTransactionType, value); }

    /// <summary>
    /// EscrowDisbursementTransactionContract TransactionAmount
    /// </summary>
    public decimal? TransactionAmount { get => _transactionAmount; set => SetField(ref _transactionAmount, value); }

    /// <summary>
    /// EscrowDisbursementTransactionContract TransactionDate
    /// </summary>
    public DateTime? TransactionDate { get => _transactionDate; set => SetField(ref _transactionDate, value); }
}