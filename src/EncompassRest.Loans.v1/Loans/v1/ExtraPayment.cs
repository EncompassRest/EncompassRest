using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ExtraPayment
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(LineNumber))]
public sealed partial class ExtraPayment : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// ExtraPayment Amount
    /// </summary>
    public decimal? Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ExtraPayment Date
    /// </summary>
    public DateTime? Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ExtraPayment ExtraPaymentIndex
    /// </summary>
    public int? ExtraPaymentIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ExtraPayment Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ExtraPayment LineNumber
    /// </summary>
    public int? LineNumber { get => GetValue<int?>(); set => SetValue(value); }
}