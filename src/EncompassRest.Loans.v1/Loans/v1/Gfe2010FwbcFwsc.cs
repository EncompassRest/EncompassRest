using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Gfe2010FwbcFwsc
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(Gfe2010FwbcFwscIndex) + "," + nameof(LineLetter) + "," + nameof(LineNumber))]
public sealed partial class Gfe2010FwbcFwsc : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Gfe2010FwbcFwsc Fwbc
    /// </summary>
    public string? Fwbc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010FwbcFwsc Fwsc
    /// </summary>
    public string? Fwsc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010FwbcFwsc Gfe2010FwbcFwscIndex
    /// </summary>
    public int? Gfe2010FwbcFwscIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010FwbcFwsc Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010FwbcFwsc LineLetter
    /// </summary>
    public StringEnumValue<LineLetter> LineLetter { get => GetValue<StringEnumValue<LineLetter>>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010FwbcFwsc LineNumber
    /// </summary>
    public int? LineNumber { get => GetValue<int?>(); set => SetValue(value); }
}