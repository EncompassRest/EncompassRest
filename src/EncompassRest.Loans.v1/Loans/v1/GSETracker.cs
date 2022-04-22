using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// GSETracker
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class GSETracker : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// GSE Rep and Warrant Tracker - Identifier [TQLGSENN99]
    /// </summary>
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Fannie Mae DU Findings Message ID [TQLGSENN01]
    /// </summary>
    public string? DUFindingsMessageID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Fannie Mae DU Findings Message Text [TQLGSENN02]
    /// </summary>
    public string? DUFindingsMessageText { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - GSE Close By Date [TQLGSENN03]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? GSECloseByDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - GSE Close By Date 2 [TQLGSENN04]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? GSECloseByDate2 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// GSETracker GSETrackerIndex
    /// </summary>
    public int? GSETrackerIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// GSETracker Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Record Type ID [TQLGSENN98]
    /// </summary>
    public string? RecordTypeID { get => GetValue<string?>(); set => SetValue(value); }
}