using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Gfe2010WholePoc
/// </summary>
public sealed partial class Gfe2010WholePoc : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<int?>? _gfe2010WholePocIndex;
    private DirtyValue<int?>? _lineNumber;
    private DirtyValue<decimal?>? _wholePoc;
    private DirtyValue<StringEnumValue<WholePocPaidByType>>? _wholePocPaidByType;

    /// <summary>
    /// Gfe2010WholePocContract Gfe2010WholePocIndex
    /// </summary>
    public int? Gfe2010WholePocIndex { get => _gfe2010WholePocIndex; set => SetField(ref _gfe2010WholePocIndex, value); }

    /// <summary>
    /// Gfe2010WholePocContract LineNumber
    /// </summary>
    public int? LineNumber { get => _lineNumber; set => SetField(ref _lineNumber, value); }

    /// <summary>
    /// Gfe2010WholePocContract WholePoc
    /// </summary>
    public decimal? WholePoc { get => _wholePoc; set => SetField(ref _wholePoc, value); }

    /// <summary>
    /// Gfe2010WholePocContract WholePocPaidByType
    /// </summary>
    public StringEnumValue<WholePocPaidByType> WholePocPaidByType { get => _wholePocPaidByType; set => SetField(ref _wholePocPaidByType, value); }
}