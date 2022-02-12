using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// GSETracker
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class GSETracker : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _altId;
    private DirtyValue<string?>? _dUFindingsMessageID;
    private DirtyValue<string?>? _dUFindingsMessageText;
    private DirtyValue<DateTime?>? _gSECloseByDate;
    private DirtyValue<DateTime?>? _gSECloseByDate2;
    private DirtyValue<int?>? _gSETrackerIndex;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _recordTypeID;

    /// <summary>
    /// GSE Rep and Warrant Tracker - Identifier [TQLGSENN99]
    /// </summary>
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Fannie Mae DU Findings Message ID [TQLGSENN01]
    /// </summary>
    public string? DUFindingsMessageID { get => _dUFindingsMessageID; set => SetField(ref _dUFindingsMessageID, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Fannie Mae DU Findings Message Text [TQLGSENN02]
    /// </summary>
    public string? DUFindingsMessageText { get => _dUFindingsMessageText; set => SetField(ref _dUFindingsMessageText, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - GSE Close By Date [TQLGSENN03]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? GSECloseByDate { get => _gSECloseByDate; set => SetField(ref _gSECloseByDate, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - GSE Close By Date 2 [TQLGSENN04]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? GSECloseByDate2 { get => _gSECloseByDate2; set => SetField(ref _gSECloseByDate2, value); }

    /// <summary>
    /// GSETracker GSETrackerIndex
    /// </summary>
    public int? GSETrackerIndex { get => _gSETrackerIndex; set => SetField(ref _gSETrackerIndex, value); }

    /// <summary>
    /// GSETracker Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Record Type ID [TQLGSENN98]
    /// </summary>
    public string? RecordTypeID { get => _recordTypeID; set => SetField(ref _recordTypeID, value); }
}