using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// RegulationZPayment
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(RegulationZPaymentIndex))]
public sealed partial class RegulationZPayment : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// RegulationZPayment Balance
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Balance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RegulationZPayment Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RegulationZPayment InterestRatePercent
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? InterestRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RegulationZPayment MonthlyPayment
    /// </summary>
    public decimal? MonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RegulationZPayment NumberOfPayments
    /// </summary>
    public int? NumberOfPayments { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// RegulationZPayment PaymentDate
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? PaymentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// RegulationZPayment RegulationZPaymentIndex
    /// </summary>
    public int? RegulationZPaymentIndex { get => GetValue<int?>(); set => SetValue(value); }
}