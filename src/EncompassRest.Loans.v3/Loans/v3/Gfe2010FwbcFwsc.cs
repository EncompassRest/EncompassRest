using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Gfe2010FwbcFwsc
/// </summary>
public sealed partial class Gfe2010FwbcFwsc : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<StringEnumValue<YOrN>>? _fwbc;
    private DirtyValue<string?>? _fwsc;
    private DirtyValue<int?>? _gfe2010FwbcFwscIndex;
    private DirtyValue<StringEnumValue<LineLetter>>? _lineLetter;
    private DirtyValue<int?>? _lineNumber;

    /// <summary>
    /// Gfe2010FwbcFwscContract Fwbc
    /// </summary>
    public StringEnumValue<YOrN> Fwbc { get => _fwbc; set => SetField(ref _fwbc, value); }

    /// <summary>
    /// Gfe2010FwbcFwscContract Fwsc
    /// </summary>
    public string? Fwsc { get => _fwsc; set => SetField(ref _fwsc, value); }

    /// <summary>
    /// Gfe2010FwbcFwscContract Gfe2010FwbcFwscIndex
    /// </summary>
    public int? Gfe2010FwbcFwscIndex { get => _gfe2010FwbcFwscIndex; set => SetField(ref _gfe2010FwbcFwscIndex, value); }

    /// <summary>
    /// Gfe2010FwbcFwscContract LineLetter
    /// </summary>
    public StringEnumValue<LineLetter> LineLetter { get => _lineLetter; set => SetField(ref _lineLetter, value); }

    /// <summary>
    /// Gfe2010FwbcFwscContract LineNumber
    /// </summary>
    public int? LineNumber { get => _lineNumber; set => SetField(ref _lineNumber, value); }
}