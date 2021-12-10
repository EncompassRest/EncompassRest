using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Hud1EsPayTo
/// </summary>
public sealed partial class Hud1EsPayTo : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _address;
    private DirtyValue<decimal?>? _amountLastPay;
    private DirtyValue<decimal?>? _amountNextDue;
    private DirtyValue<string?>? _city;
    private DirtyValue<string?>? _contactName;
    private DirtyValue<decimal?>? _coverageAmount;
    private DirtyValue<DateTime?>? _delinquentDate;
    private DirtyValue<string?>? _email;
    private DirtyValue<string?>? _fax;
    private DirtyValue<StringEnumValue<Hud1EsPayToFeeType>>? _feeType;
    private DirtyValue<int?>? _hud1EsPayToIndex;
    private DirtyValue<decimal?>? _maxDeductibleAmount;
    private DirtyValue<decimal?>? _maxDeductiblePercentage;
    private DirtyValue<string?>? _name;
    private DirtyValue<DateTime?>? _nextDueDate;
    private DirtyValue<DateTime?>? _paymentDate;
    private DirtyValue<string?>? _paymentSchedule;
    private DirtyValue<string?>? _phone;
    private DirtyValue<string?>? _policyNumber;
    private DirtyValue<string?>? _postalCode;
    private DirtyValue<decimal?>? _premium;
    private DirtyValue<DateTime?>? _renewalDate;
    private DirtyValue<string?>? _state;

    /// <summary>
    /// Hud1EsPayToContract Address
    /// </summary>
    public string? Address { get => _address; set => SetField(ref _address, value); }

    /// <summary>
    /// Hud1EsPayToContract AmountLastPay
    /// </summary>
    public decimal? AmountLastPay { get => _amountLastPay; set => SetField(ref _amountLastPay, value); }

    /// <summary>
    /// Hud1EsPayToContract AmountNextDue
    /// </summary>
    public decimal? AmountNextDue { get => _amountNextDue; set => SetField(ref _amountNextDue, value); }

    /// <summary>
    /// Hud1EsPayToContract City
    /// </summary>
    public string? City { get => _city; set => SetField(ref _city, value); }

    /// <summary>
    /// Hud1EsPayToContract ContactName
    /// </summary>
    public string? ContactName { get => _contactName; set => SetField(ref _contactName, value); }

    /// <summary>
    /// Hud1EsPayToContract CoverageAmount
    /// </summary>
    public decimal? CoverageAmount { get => _coverageAmount; set => SetField(ref _coverageAmount, value); }

    /// <summary>
    /// Hud1EsPayToContract DelinquentDate
    /// </summary>
    public DateTime? DelinquentDate { get => _delinquentDate; set => SetField(ref _delinquentDate, value); }

    /// <summary>
    /// Hud1EsPayToContract Email
    /// </summary>
    public string? Email { get => _email; set => SetField(ref _email, value); }

    /// <summary>
    /// Hud1EsPayToContract Fax
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Fax { get => _fax; set => SetField(ref _fax, value); }

    /// <summary>
    /// Hud1EsPayToContract FeeType
    /// </summary>
    public StringEnumValue<Hud1EsPayToFeeType> FeeType { get => _feeType; set => SetField(ref _feeType, value); }

    /// <summary>
    /// Hud1EsPayToContract Hud1EsPayToIndex
    /// </summary>
    public int? Hud1EsPayToIndex { get => _hud1EsPayToIndex; set => SetField(ref _hud1EsPayToIndex, value); }

    /// <summary>
    /// Hud1EsPayToContract MaxDeductibleAmount
    /// </summary>
    public decimal? MaxDeductibleAmount { get => _maxDeductibleAmount; set => SetField(ref _maxDeductibleAmount, value); }

    /// <summary>
    /// Hud1EsPayToContract MaxDeductiblePercentage
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MaxDeductiblePercentage { get => _maxDeductiblePercentage; set => SetField(ref _maxDeductiblePercentage, value); }

    /// <summary>
    /// Hud1EsPayToContract Name
    /// </summary>
    public string? Name { get => _name; set => SetField(ref _name, value); }

    /// <summary>
    /// Hud1EsPayToContract NextDueDate
    /// </summary>
    public DateTime? NextDueDate { get => _nextDueDate; set => SetField(ref _nextDueDate, value); }

    /// <summary>
    /// Hud1EsPayToContract PaymentDate
    /// </summary>
    public DateTime? PaymentDate { get => _paymentDate; set => SetField(ref _paymentDate, value); }

    /// <summary>
    /// Hud1EsPayToContract PaymentSchedule
    /// </summary>
    public string? PaymentSchedule { get => _paymentSchedule; set => SetField(ref _paymentSchedule, value); }

    /// <summary>
    /// Hud1EsPayToContract Phone
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Phone { get => _phone; set => SetField(ref _phone, value); }

    /// <summary>
    /// Hud1EsPayToContract PolicyNumber
    /// </summary>
    public string? PolicyNumber { get => _policyNumber; set => SetField(ref _policyNumber, value); }

    /// <summary>
    /// Hud1EsPayToContract PostalCode
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }

    /// <summary>
    /// Hud1EsPayToContract Premium
    /// </summary>
    public decimal? Premium { get => _premium; set => SetField(ref _premium, value); }

    /// <summary>
    /// Hud1EsPayToContract RenewalDate
    /// </summary>
    public DateTime? RenewalDate { get => _renewalDate; set => SetField(ref _renewalDate, value); }

    /// <summary>
    /// Hud1EsPayToContract State
    /// </summary>
    public string? State { get => _state; set => SetField(ref _state, value); }
}