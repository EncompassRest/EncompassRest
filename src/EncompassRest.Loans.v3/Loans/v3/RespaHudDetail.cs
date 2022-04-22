using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

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
    /// RespaHudDetail Fwbc
    /// </summary>
    public string? Fwbc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RespaHudDetail Hud1LineItemFromDate
    /// </summary>
    public DateTime? Hud1LineItemFromDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// RespaHudDetail Hud1LineItemToDate
    /// </summary>
    public DateTime? Hud1LineItemToDate { get => GetValue<DateTime?>(); set => SetValue(value); }

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