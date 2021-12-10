using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// PaymentTransaction
/// </summary>
public sealed partial class PaymentTransaction : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _accountHolder;
    private DirtyValue<string?>? _accountNumber;
    private DirtyValue<decimal?>? _additionalEscrow;
    private DirtyValue<decimal?>? _additionalPrincipal;
    private DirtyValue<decimal?>? _buydownSubsidyAmount;
    private DirtyValue<string?>? _checkNumber;
    private DirtyValue<string?>? _comments;
    private DirtyValue<decimal?>? _commonAmount;
    private DirtyValue<DateTime?>? _commonDate;
    private DirtyValue<string?>? _createdById;
    private DirtyValue<string?>? _createdByName;
    private DirtyValue<DateTime?>? _createdDateTime;
    private DirtyValue<decimal?>? _escrow;
    private DirtyValue<decimal?>? _escrowCityPropertyTax;
    private DirtyValue<decimal?>? _escrowFloodInsurance;
    private DirtyValue<decimal?>? _escrowHazardInsurance;
    private DirtyValue<decimal?>? _escrowMortgageInsurance;
    private DirtyValue<decimal?>? _escrowOther1;
    private DirtyValue<decimal?>? _escrowOther2;
    private DirtyValue<decimal?>? _escrowOther3;
    private DirtyValue<decimal?>? _escrowTax;
    private DirtyValue<decimal?>? _escrowUsdaMonthlyPremium;
    private DirtyValue<string?>? _guid;
    private DirtyValue<decimal?>? _indexRate;
    private DirtyValue<string?>? _institutionName;
    private DirtyValue<string?>? _institutionRouting;
    private DirtyValue<decimal?>? _interest;
    private DirtyValue<decimal?>? _interestRate;
    private DirtyValue<decimal?>? _lateFee;
    private DirtyValue<decimal?>? _lateFeeIfLate;
    private DirtyValue<DateTime?>? _latePaymentDate;
    private DirtyValue<decimal?>? _miscFee;
    private DirtyValue<string?>? _modifiedById;
    private DirtyValue<string?>? _modifiedByName;
    private DirtyValue<DateTime?>? _modifiedDateTime;
    private DirtyValue<DateTime?>? _paymentDepositedDate;
    private DirtyValue<DateTime?>? _paymentDueDate;
    private DirtyValue<DateTime?>? _paymentIndexDate;
    private DirtyValue<int?>? _paymentNumber;
    private DirtyValue<DateTime?>? _paymentReceivedDate;
    private DirtyValue<decimal?>? _principal;
    private DirtyValue<string?>? _reference;
    private DirtyValue<decimal?>? _schedulePayLogMiscFee;
    private DirtyValue<string?>? _servicingPaymentMethod;
    private DirtyValue<string?>? _servicingTransactionType;
    private DirtyValue<DateTime?>? _statementDate;
    private DirtyValue<decimal?>? _totalAmountDue;
    private DirtyValue<decimal?>? _totalAmountReceived;
    private DirtyValue<decimal?>? _transactionAmount;
    private DirtyValue<DateTime?>? _transactionDate;

    /// <summary>
    /// PaymentTransactionContract AccountHolder
    /// </summary>
    public string? AccountHolder { get => _accountHolder; set => SetField(ref _accountHolder, value); }

    /// <summary>
    /// PaymentTransactionContract AccountNumber
    /// </summary>
    public string? AccountNumber { get => _accountNumber; set => SetField(ref _accountNumber, value); }

    /// <summary>
    /// PaymentTransactionContract AdditionalEscrow
    /// </summary>
    public decimal? AdditionalEscrow { get => _additionalEscrow; set => SetField(ref _additionalEscrow, value); }

    /// <summary>
    /// PaymentTransactionContract AdditionalPrincipal
    /// </summary>
    public decimal? AdditionalPrincipal { get => _additionalPrincipal; set => SetField(ref _additionalPrincipal, value); }

    /// <summary>
    /// PaymentTransactionContract BuydownSubsidyAmount
    /// </summary>
    public decimal? BuydownSubsidyAmount { get => _buydownSubsidyAmount; set => SetField(ref _buydownSubsidyAmount, value); }

    /// <summary>
    /// PaymentTransactionContract CheckNumber
    /// </summary>
    public string? CheckNumber { get => _checkNumber; set => SetField(ref _checkNumber, value); }

    /// <summary>
    /// PaymentTransactionContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// PaymentTransactionContract CommonAmount
    /// </summary>
    public decimal? CommonAmount { get => _commonAmount; set => SetField(ref _commonAmount, value); }

    /// <summary>
    /// PaymentTransactionContract CommonDate
    /// </summary>
    public DateTime? CommonDate { get => _commonDate; set => SetField(ref _commonDate, value); }

    /// <summary>
    /// PaymentTransactionContract CreatedById
    /// </summary>
    public string? CreatedById { get => _createdById; set => SetField(ref _createdById, value); }

    /// <summary>
    /// PaymentTransactionContract CreatedByName
    /// </summary>
    public string? CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }

    /// <summary>
    /// PaymentTransactionContract CreatedDateTime
    /// </summary>
    public DateTime? CreatedDateTime { get => _createdDateTime; set => SetField(ref _createdDateTime, value); }

    /// <summary>
    /// PaymentTransactionContract Escrow
    /// </summary>
    public decimal? Escrow { get => _escrow; set => SetField(ref _escrow, value); }

    /// <summary>
    /// PaymentTransactionContract EscrowCityPropertyTax
    /// </summary>
    public decimal? EscrowCityPropertyTax { get => _escrowCityPropertyTax; set => SetField(ref _escrowCityPropertyTax, value); }

    /// <summary>
    /// PaymentTransactionContract EscrowFloodInsurance
    /// </summary>
    public decimal? EscrowFloodInsurance { get => _escrowFloodInsurance; set => SetField(ref _escrowFloodInsurance, value); }

    /// <summary>
    /// PaymentTransactionContract EscrowHazardInsurance
    /// </summary>
    public decimal? EscrowHazardInsurance { get => _escrowHazardInsurance; set => SetField(ref _escrowHazardInsurance, value); }

    /// <summary>
    /// PaymentTransactionContract EscrowMortgageInsurance
    /// </summary>
    public decimal? EscrowMortgageInsurance { get => _escrowMortgageInsurance; set => SetField(ref _escrowMortgageInsurance, value); }

    /// <summary>
    /// PaymentTransactionContract EscrowOther1
    /// </summary>
    public decimal? EscrowOther1 { get => _escrowOther1; set => SetField(ref _escrowOther1, value); }

    /// <summary>
    /// PaymentTransactionContract EscrowOther2
    /// </summary>
    public decimal? EscrowOther2 { get => _escrowOther2; set => SetField(ref _escrowOther2, value); }

    /// <summary>
    /// PaymentTransactionContract EscrowOther3
    /// </summary>
    public decimal? EscrowOther3 { get => _escrowOther3; set => SetField(ref _escrowOther3, value); }

    /// <summary>
    /// PaymentTransactionContract EscrowTax
    /// </summary>
    public decimal? EscrowTax { get => _escrowTax; set => SetField(ref _escrowTax, value); }

    /// <summary>
    /// PaymentTransactionContract EscrowUsdaMonthlyPremium
    /// </summary>
    public decimal? EscrowUsdaMonthlyPremium { get => _escrowUsdaMonthlyPremium; set => SetField(ref _escrowUsdaMonthlyPremium, value); }

    /// <summary>
    /// PaymentTransactionContract Guid
    /// </summary>
    public string? Guid { get => _guid; set => SetField(ref _guid, value); }

    /// <summary>
    /// PaymentTransactionContract IndexRate
    /// </summary>
    public decimal? IndexRate { get => _indexRate; set => SetField(ref _indexRate, value); }

    /// <summary>
    /// PaymentTransactionContract InstitutionName
    /// </summary>
    public string? InstitutionName { get => _institutionName; set => SetField(ref _institutionName, value); }

    /// <summary>
    /// PaymentTransactionContract InstitutionRouting
    /// </summary>
    public string? InstitutionRouting { get => _institutionRouting; set => SetField(ref _institutionRouting, value); }

    /// <summary>
    /// PaymentTransactionContract Interest
    /// </summary>
    public decimal? Interest { get => _interest; set => SetField(ref _interest, value); }

    /// <summary>
    /// PaymentTransactionContract InterestRate
    /// </summary>
    public decimal? InterestRate { get => _interestRate; set => SetField(ref _interestRate, value); }

    /// <summary>
    /// PaymentTransactionContract LateFee
    /// </summary>
    public decimal? LateFee { get => _lateFee; set => SetField(ref _lateFee, value); }

    /// <summary>
    /// PaymentTransactionContract LateFeeIfLate
    /// </summary>
    public decimal? LateFeeIfLate { get => _lateFeeIfLate; set => SetField(ref _lateFeeIfLate, value); }

    /// <summary>
    /// PaymentTransactionContract LatePaymentDate
    /// </summary>
    public DateTime? LatePaymentDate { get => _latePaymentDate; set => SetField(ref _latePaymentDate, value); }

    /// <summary>
    /// PaymentTransactionContract MiscFee
    /// </summary>
    public decimal? MiscFee { get => _miscFee; set => SetField(ref _miscFee, value); }

    /// <summary>
    /// PaymentTransactionContract ModifiedById
    /// </summary>
    public string? ModifiedById { get => _modifiedById; set => SetField(ref _modifiedById, value); }

    /// <summary>
    /// PaymentTransactionContract ModifiedByName
    /// </summary>
    public string? ModifiedByName { get => _modifiedByName; set => SetField(ref _modifiedByName, value); }

    /// <summary>
    /// PaymentTransactionContract ModifiedDateTime
    /// </summary>
    public DateTime? ModifiedDateTime { get => _modifiedDateTime; set => SetField(ref _modifiedDateTime, value); }

    /// <summary>
    /// PaymentTransactionContract PaymentDepositedDate
    /// </summary>
    public DateTime? PaymentDepositedDate { get => _paymentDepositedDate; set => SetField(ref _paymentDepositedDate, value); }

    /// <summary>
    /// PaymentTransactionContract PaymentDueDate
    /// </summary>
    public DateTime? PaymentDueDate { get => _paymentDueDate; set => SetField(ref _paymentDueDate, value); }

    /// <summary>
    /// PaymentTransactionContract PaymentIndexDate
    /// </summary>
    public DateTime? PaymentIndexDate { get => _paymentIndexDate; set => SetField(ref _paymentIndexDate, value); }

    /// <summary>
    /// PaymentTransactionContract PaymentNumber
    /// </summary>
    public int? PaymentNumber { get => _paymentNumber; set => SetField(ref _paymentNumber, value); }

    /// <summary>
    /// PaymentTransactionContract PaymentReceivedDate
    /// </summary>
    public DateTime? PaymentReceivedDate { get => _paymentReceivedDate; set => SetField(ref _paymentReceivedDate, value); }

    /// <summary>
    /// PaymentTransactionContract Principal
    /// </summary>
    public decimal? Principal { get => _principal; set => SetField(ref _principal, value); }

    /// <summary>
    /// PaymentTransactionContract Reference
    /// </summary>
    public string? Reference { get => _reference; set => SetField(ref _reference, value); }

    /// <summary>
    /// PaymentTransactionContract SchedulePayLogMiscFee
    /// </summary>
    public decimal? SchedulePayLogMiscFee { get => _schedulePayLogMiscFee; set => SetField(ref _schedulePayLogMiscFee, value); }

    /// <summary>
    /// PaymentTransactionContract ServicingPaymentMethod
    /// </summary>
    public string? ServicingPaymentMethod { get => _servicingPaymentMethod; set => SetField(ref _servicingPaymentMethod, value); }

    /// <summary>
    /// PaymentTransactionContract ServicingTransactionType
    /// </summary>
    public string? ServicingTransactionType { get => _servicingTransactionType; set => SetField(ref _servicingTransactionType, value); }

    /// <summary>
    /// PaymentTransactionContract StatementDate
    /// </summary>
    public DateTime? StatementDate { get => _statementDate; set => SetField(ref _statementDate, value); }

    /// <summary>
    /// PaymentTransactionContract TotalAmountDue
    /// </summary>
    public decimal? TotalAmountDue { get => _totalAmountDue; set => SetField(ref _totalAmountDue, value); }

    /// <summary>
    /// PaymentTransactionContract TotalAmountReceived
    /// </summary>
    public decimal? TotalAmountReceived { get => _totalAmountReceived; set => SetField(ref _totalAmountReceived, value); }

    /// <summary>
    /// PaymentTransactionContract TransactionAmount
    /// </summary>
    public decimal? TransactionAmount { get => _transactionAmount; set => SetField(ref _transactionAmount, value); }

    /// <summary>
    /// PaymentTransactionContract TransactionDate
    /// </summary>
    public DateTime? TransactionDate { get => _transactionDate; set => SetField(ref _transactionDate, value); }
}