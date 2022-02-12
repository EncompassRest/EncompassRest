using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Gfe2010FwbcFwsc
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(Gfe2010FwbcFwscIndex) + "," + nameof(LineLetter) + "," + nameof(LineNumber))]
public sealed partial class Gfe2010FwbcFwsc : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _fwbc;
    private DirtyValue<string?>? _fwsc;
    private DirtyValue<int?>? _gfe2010FwbcFwscIndex;
    private DirtyValue<string?>? _id;
    private DirtyValue<StringEnumValue<LineLetter>>? _lineLetter;
    private DirtyValue<int?>? _lineNumber;

    /// <summary>
    /// Gfe2010FwbcFwsc Fwbc
    /// </summary>
    public string? Fwbc { get => _fwbc; set => SetField(ref _fwbc, value); }

    /// <summary>
    /// Gfe2010FwbcFwsc Fwsc
    /// </summary>
    public string? Fwsc { get => _fwsc; set => SetField(ref _fwsc, value); }

    /// <summary>
    /// Gfe2010FwbcFwsc Gfe2010FwbcFwscIndex
    /// </summary>
    public int? Gfe2010FwbcFwscIndex { get => _gfe2010FwbcFwscIndex; set => SetField(ref _gfe2010FwbcFwscIndex, value); }

    /// <summary>
    /// Gfe2010FwbcFwsc Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Gfe2010FwbcFwsc LineLetter
    /// </summary>
    public StringEnumValue<LineLetter> LineLetter { get => _lineLetter; set => SetField(ref _lineLetter, value); }

    /// <summary>
    /// Gfe2010FwbcFwsc LineNumber
    /// </summary>
    public int? LineNumber { get => _lineNumber; set => SetField(ref _lineNumber, value); }
}