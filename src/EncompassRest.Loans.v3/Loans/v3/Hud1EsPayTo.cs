using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Hud1EsPayTo
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(Hud1EsPayToIndex))]
public sealed partial class Hud1EsPayTo : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Hud1EsPayTo Address
    /// </summary>
    public string? Address { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo AmountLastPay
    /// </summary>
    public decimal? AmountLastPay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo AmountNextDue
    /// </summary>
    public decimal? AmountNextDue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo City
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo ContactName
    /// </summary>
    public string? ContactName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo CoverageAmount
    /// </summary>
    public decimal? CoverageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo DelinquentDate
    /// </summary>
    public DateTime? DelinquentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo Email
    /// </summary>
    public string? Email { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo Fax
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Fax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo FeeType
    /// </summary>
    public StringEnumValue<Hud1EsPayToFeeType> FeeType { get => GetValue<StringEnumValue<Hud1EsPayToFeeType>>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo Hud1EsPayToIndex
    /// </summary>
    public int? Hud1EsPayToIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo MaxDeductibleAmount
    /// </summary>
    public decimal? MaxDeductibleAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo MaxDeductiblePercentage
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MaxDeductiblePercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo NextDueDate
    /// </summary>
    public DateTime? NextDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo PaymentDate
    /// </summary>
    public DateTime? PaymentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo PaymentSchedule
    /// </summary>
    public string? PaymentSchedule { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo Phone
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Phone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo PolicyNumber
    /// </summary>
    public string? PolicyNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo PostalCode
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo Premium
    /// </summary>
    public decimal? Premium { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo RenewalDate
    /// </summary>
    public DateTime? RenewalDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Hud1EsPayTo State
    /// </summary>
    public string? State { get => GetValue<string?>(); set => SetValue(value); }
}