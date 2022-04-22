using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// RespaHudDetail
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(LineNumber))]
public sealed partial class RespaHudDetail : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// RespaHudDetail CreditDebt
    /// </summary>
    public StringEnumValue<CreditDebt> CreditDebt { get => GetValue<StringEnumValue<CreditDebt>>(); set => SetValue(value); }

    /// <summary>
    /// RespaHudDetail FWBC
    /// </summary>
    public string? FWBC { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RespaHudDetail HUD1LineItemFromDate
    /// </summary>
    public DateTime? HUD1LineItemFromDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// RespaHudDetail HUD1LineItemToDate
    /// </summary>
    public DateTime? HUD1LineItemToDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// RespaHudDetail Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RespaHudDetail LineItemAmount
    /// </summary>
    public decimal? LineItemAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RespaHudDetail LineItemDescription
    /// </summary>
    public string? LineItemDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RespaHudDetail LineNumber
    /// </summary>
    public int? LineNumber { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// RespaHudDetail RealValue [L206R], [L207R]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? RealValue { get => GetValue<decimal?>(); set => SetValue(value); }
}