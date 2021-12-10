using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// SchedulePaymentTransaction
/// </summary>
public sealed partial class SchedulePaymentTransaction : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _additionalEscrow;
    private DirtyValue<decimal?>? _additionalPrincipal;
    private DirtyValue<decimal?>? _buydownSubsidyAmount;
    private DirtyValue<decimal?>? _buydownSubsidyAmountDue;
    private DirtyValue<decimal?>? _cityPropertyTax;
    private DirtyValue<string?>? _comments;
    private DirtyValue<string?>? _createdById;
    private DirtyValue<string?>? _createdByName;
    private DirtyValue<DateTime?>? _createdDateTime;
    private DirtyValue<decimal?>? _escrow;
    private DirtyValue<decimal?>? _escrowCityPropertyTaxDue;
    private DirtyValue<decimal?>? _escrowDue;
    private DirtyValue<decimal?>? _escrowFloodInsuranceDue;
    private DirtyValue<decimal?>? _escrowHazardInsuranceDue;
    private DirtyValue<decimal?>? _escrowMortgageInsuranceDue;
    private DirtyValue<decimal?>? _escrowOther1Due;
    private DirtyValue<decimal?>? _escrowOther2Due;
    private DirtyValue<decimal?>? _escrowOther3Due;
    private DirtyValue<decimal?>? _escrowTaxDue;
    private DirtyValue<decimal?>? _escrowUsdaMonthlyPremiumDue;
    private DirtyValue<decimal?>? _floodInsurance;
    private DirtyValue<string?>? _guid;
    private DirtyValue<decimal?>? _hazardInsurance;
    private DirtyValue<decimal?>? _indexRate;
    private DirtyValue<decimal?>? _interest;
    private DirtyValue<decimal?>? _interestDue;
    private DirtyValue<decimal?>? _interestRate;
    private DirtyValue<decimal?>? _lateFee;
    private DirtyValue<DateTime?>? _latePaymentDate;
    private DirtyValue<decimal?>? _miscFee;
    private DirtyValue<decimal?>? _miscFeeDue;
    private DirtyValue<string?>? _modifiedById;
    private DirtyValue<string?>? _modifiedByName;
    private DirtyValue<DateTime?>? _modifiedDateTime;
    private DirtyValue<decimal?>? _mortgageInsurance;
    private DirtyValue<decimal?>? _other1Escrow;
    private DirtyValue<decimal?>? _other2Escrow;
    private DirtyValue<decimal?>? _other3Escrow;
    private DirtyValue<int?>? _paymentNumber;
    private DirtyValue<DateTime?>? _paymentReceiveDate;
    private DirtyValue<decimal?>? _principal;
    private DirtyValue<decimal?>? _principalDue;
    private DirtyValue<string?>? _servicingPaymentMethod;
    private DirtyValue<string?>? _servicingTransactionType;
    private DirtyValue<decimal?>? _taxes;
    private DirtyValue<decimal?>? _totalPastDue;
    private DirtyValue<decimal?>? _transactionAmount;
    private DirtyValue<DateTime?>? _transactionDate;
    private DirtyValue<decimal?>? _unpaidLateFeeDue;
    private DirtyValue<decimal?>? _usdaMonthlyPremium;

    /// <summary>
    /// SchedulePaymentTransactionContract AdditionalEscrow
    /// </summary>
    public decimal? AdditionalEscrow { get => _additionalEscrow; set => SetField(ref _additionalEscrow, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract AdditionalPrincipal
    /// </summary>
    public decimal? AdditionalPrincipal { get => _additionalPrincipal; set => SetField(ref _additionalPrincipal, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract BuydownSubsidyAmount
    /// </summary>
    public decimal? BuydownSubsidyAmount { get => _buydownSubsidyAmount; set => SetField(ref _buydownSubsidyAmount, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract BuydownSubsidyAmountDue
    /// </summary>
    public decimal? BuydownSubsidyAmountDue { get => _buydownSubsidyAmountDue; set => SetField(ref _buydownSubsidyAmountDue, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract CityPropertyTax
    /// </summary>
    public decimal? CityPropertyTax { get => _cityPropertyTax; set => SetField(ref _cityPropertyTax, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract CreatedById
    /// </summary>
    public string? CreatedById { get => _createdById; set => SetField(ref _createdById, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract CreatedByName
    /// </summary>
    public string? CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract CreatedDateTime
    /// </summary>
    public DateTime? CreatedDateTime { get => _createdDateTime; set => SetField(ref _createdDateTime, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract Escrow
    /// </summary>
    public decimal? Escrow { get => _escrow; set => SetField(ref _escrow, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract EscrowCityPropertyTaxDue
    /// </summary>
    public decimal? EscrowCityPropertyTaxDue { get => _escrowCityPropertyTaxDue; set => SetField(ref _escrowCityPropertyTaxDue, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract EscrowDue
    /// </summary>
    public decimal? EscrowDue { get => _escrowDue; set => SetField(ref _escrowDue, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract EscrowFloodInsuranceDue
    /// </summary>
    public decimal? EscrowFloodInsuranceDue { get => _escrowFloodInsuranceDue; set => SetField(ref _escrowFloodInsuranceDue, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract EscrowHazardInsuranceDue
    /// </summary>
    public decimal? EscrowHazardInsuranceDue { get => _escrowHazardInsuranceDue; set => SetField(ref _escrowHazardInsuranceDue, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract EscrowMortgageInsuranceDue
    /// </summary>
    public decimal? EscrowMortgageInsuranceDue { get => _escrowMortgageInsuranceDue; set => SetField(ref _escrowMortgageInsuranceDue, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract EscrowOther1Due
    /// </summary>
    public decimal? EscrowOther1Due { get => _escrowOther1Due; set => SetField(ref _escrowOther1Due, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract EscrowOther2Due
    /// </summary>
    public decimal? EscrowOther2Due { get => _escrowOther2Due; set => SetField(ref _escrowOther2Due, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract EscrowOther3Due
    /// </summary>
    public decimal? EscrowOther3Due { get => _escrowOther3Due; set => SetField(ref _escrowOther3Due, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract EscrowTaxDue
    /// </summary>
    public decimal? EscrowTaxDue { get => _escrowTaxDue; set => SetField(ref _escrowTaxDue, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract EscrowUsdaMonthlyPremiumDue
    /// </summary>
    public decimal? EscrowUsdaMonthlyPremiumDue { get => _escrowUsdaMonthlyPremiumDue; set => SetField(ref _escrowUsdaMonthlyPremiumDue, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract FloodInsurance
    /// </summary>
    public decimal? FloodInsurance { get => _floodInsurance; set => SetField(ref _floodInsurance, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract Guid
    /// </summary>
    public string? Guid { get => _guid; set => SetField(ref _guid, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract HazardInsurance
    /// </summary>
    public decimal? HazardInsurance { get => _hazardInsurance; set => SetField(ref _hazardInsurance, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract IndexRate
    /// </summary>
    public decimal? IndexRate { get => _indexRate; set => SetField(ref _indexRate, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract Interest
    /// </summary>
    public decimal? Interest { get => _interest; set => SetField(ref _interest, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract InterestDue
    /// </summary>
    public decimal? InterestDue { get => _interestDue; set => SetField(ref _interestDue, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract InterestRate
    /// </summary>
    public decimal? InterestRate { get => _interestRate; set => SetField(ref _interestRate, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract LateFee
    /// </summary>
    public decimal? LateFee { get => _lateFee; set => SetField(ref _lateFee, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract LatePaymentDate
    /// </summary>
    public DateTime? LatePaymentDate { get => _latePaymentDate; set => SetField(ref _latePaymentDate, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract MiscFee
    /// </summary>
    public decimal? MiscFee { get => _miscFee; set => SetField(ref _miscFee, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract MiscFeeDue
    /// </summary>
    public decimal? MiscFeeDue { get => _miscFeeDue; set => SetField(ref _miscFeeDue, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract ModifiedById
    /// </summary>
    public string? ModifiedById { get => _modifiedById; set => SetField(ref _modifiedById, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract ModifiedByName
    /// </summary>
    public string? ModifiedByName { get => _modifiedByName; set => SetField(ref _modifiedByName, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract ModifiedDateTime
    /// </summary>
    public DateTime? ModifiedDateTime { get => _modifiedDateTime; set => SetField(ref _modifiedDateTime, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract MortgageInsurance
    /// </summary>
    public decimal? MortgageInsurance { get => _mortgageInsurance; set => SetField(ref _mortgageInsurance, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract Other1Escrow
    /// </summary>
    public decimal? Other1Escrow { get => _other1Escrow; set => SetField(ref _other1Escrow, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract Other2Escrow
    /// </summary>
    public decimal? Other2Escrow { get => _other2Escrow; set => SetField(ref _other2Escrow, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract Other3Escrow
    /// </summary>
    public decimal? Other3Escrow { get => _other3Escrow; set => SetField(ref _other3Escrow, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract PaymentNumber
    /// </summary>
    public int? PaymentNumber { get => _paymentNumber; set => SetField(ref _paymentNumber, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract PaymentReceiveDate
    /// </summary>
    public DateTime? PaymentReceiveDate { get => _paymentReceiveDate; set => SetField(ref _paymentReceiveDate, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract Principal
    /// </summary>
    public decimal? Principal { get => _principal; set => SetField(ref _principal, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract PrincipalDue
    /// </summary>
    public decimal? PrincipalDue { get => _principalDue; set => SetField(ref _principalDue, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract ServicingPaymentMethod
    /// </summary>
    public string? ServicingPaymentMethod { get => _servicingPaymentMethod; set => SetField(ref _servicingPaymentMethod, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract ServicingTransactionType
    /// </summary>
    public string? ServicingTransactionType { get => _servicingTransactionType; set => SetField(ref _servicingTransactionType, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract Taxes
    /// </summary>
    public decimal? Taxes { get => _taxes; set => SetField(ref _taxes, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract TotalPastDue
    /// </summary>
    public decimal? TotalPastDue { get => _totalPastDue; set => SetField(ref _totalPastDue, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract TransactionAmount
    /// </summary>
    public decimal? TransactionAmount { get => _transactionAmount; set => SetField(ref _transactionAmount, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract TransactionDate
    /// </summary>
    public DateTime? TransactionDate { get => _transactionDate; set => SetField(ref _transactionDate, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract UnpaidLateFeeDue
    /// </summary>
    public decimal? UnpaidLateFeeDue { get => _unpaidLateFeeDue; set => SetField(ref _unpaidLateFeeDue, value); }

    /// <summary>
    /// SchedulePaymentTransactionContract UsdaMonthlyPremium
    /// </summary>
    public decimal? UsdaMonthlyPremium { get => _usdaMonthlyPremium; set => SetField(ref _usdaMonthlyPremium, value); }
}