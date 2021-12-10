using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ExtraPayment
/// </summary>
public sealed partial class ExtraPayment : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _amount;
    private DirtyValue<DateTime?>? _date;
    private DirtyValue<int?>? _lineNumber;

    /// <summary>
    /// ExtraPaymentContract Amount
    /// </summary>
    public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

    /// <summary>
    /// ExtraPaymentContract Date
    /// </summary>
    public DateTime? Date { get => _date; set => SetField(ref _date, value); }

    /// <summary>
    /// ExtraPaymentContract LineNumber
    /// </summary>
    public int? LineNumber { get => _lineNumber; set => SetField(ref _lineNumber, value); }
}