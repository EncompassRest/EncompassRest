using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// GseTracker
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class GseTracker : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// GSE Rep and Warrant Tracker - Identifier [TQLGSE0099]
    /// </summary>
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Fannie Mae DU Findings Message ID [TQLGSE0001]
    /// </summary>
    public string? DuFindingsMessageId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Fannie Mae DU Findings Message Text [TQLGSE0002]
    /// </summary>
    public string? DuFindingsMessageText { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - GSE Close By Date [TQLGSE0003]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? GseCloseByDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - GSE Close By Date 2 [TQLGSE0004]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? GseCloseByDate2 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// GseTracker Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Record Type ID [TQLGSE0098]
    /// </summary>
    public string? RecordTypeId { get => GetValue<string?>(); set => SetValue(value); }
}