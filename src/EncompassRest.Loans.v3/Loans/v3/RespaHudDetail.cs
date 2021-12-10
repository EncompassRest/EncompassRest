using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// RespaHudDetail
/// </summary>
public sealed partial class RespaHudDetail : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<StringEnumValue<CreditDebt>>? _creditDebt;
    private DirtyValue<string?>? _fwbc;
    private DirtyValue<DateTime?>? _hud1LineItemFromDate;
    private DirtyValue<DateTime?>? _hud1LineItemToDate;
    private DirtyValue<decimal?>? _lineItemAmount;
    private DirtyValue<string?>? _lineItemDescription;
    private DirtyValue<int?>? _lineNumber;
    private DirtyValue<decimal?>? _realValue;

    /// <summary>
    /// RespaHudDetailContract CreditDebt
    /// </summary>
    public StringEnumValue<CreditDebt> CreditDebt { get => _creditDebt; set => SetField(ref _creditDebt, value); }

    /// <summary>
    /// RespaHudDetailContract Fwbc
    /// </summary>
    public string? Fwbc { get => _fwbc; set => SetField(ref _fwbc, value); }

    /// <summary>
    /// RespaHudDetailContract Hud1LineItemFromDate
    /// </summary>
    public DateTime? Hud1LineItemFromDate { get => _hud1LineItemFromDate; set => SetField(ref _hud1LineItemFromDate, value); }

    /// <summary>
    /// RespaHudDetailContract Hud1LineItemToDate
    /// </summary>
    public DateTime? Hud1LineItemToDate { get => _hud1LineItemToDate; set => SetField(ref _hud1LineItemToDate, value); }

    /// <summary>
    /// RespaHudDetailContract LineItemAmount
    /// </summary>
    public decimal? LineItemAmount { get => _lineItemAmount; set => SetField(ref _lineItemAmount, value); }

    /// <summary>
    /// RespaHudDetailContract LineItemDescription
    /// </summary>
    public string? LineItemDescription { get => _lineItemDescription; set => SetField(ref _lineItemDescription, value); }

    /// <summary>
    /// RespaHudDetailContract LineNumber
    /// </summary>
    public int? LineNumber { get => _lineNumber; set => SetField(ref _lineNumber, value); }

    /// <summary>
    /// RespaHudDetailContract RealValue [L206R], [L207R]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? RealValue { get => _realValue; set => SetField(ref _realValue, value); }
}