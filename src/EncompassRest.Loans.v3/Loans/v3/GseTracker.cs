using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// GseTracker
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class GseTracker : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _altId;
    private DirtyValue<string?>? _duFindingsMessageId;
    private DirtyValue<string?>? _duFindingsMessageText;
    private DirtyValue<DateTime?>? _gseCloseByDate;
    private DirtyValue<DateTime?>? _gseCloseByDate2;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _recordTypeId;

    /// <summary>
    /// GSE Rep and Warrant Tracker - Identifier [TQLGSE0099]
    /// </summary>
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Fannie Mae DU Findings Message ID [TQLGSE0001]
    /// </summary>
    public string? DuFindingsMessageId { get => _duFindingsMessageId; set => SetField(ref _duFindingsMessageId, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Fannie Mae DU Findings Message Text [TQLGSE0002]
    /// </summary>
    public string? DuFindingsMessageText { get => _duFindingsMessageText; set => SetField(ref _duFindingsMessageText, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - GSE Close By Date [TQLGSE0003]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? GseCloseByDate { get => _gseCloseByDate; set => SetField(ref _gseCloseByDate, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - GSE Close By Date 2 [TQLGSE0004]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? GseCloseByDate2 { get => _gseCloseByDate2; set => SetField(ref _gseCloseByDate2, value); }

    /// <summary>
    /// GseTrackerContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// GSE Rep and Warrant Tracker - Record Type ID [TQLGSE0098]
    /// </summary>
    public string? RecordTypeId { get => _recordTypeId; set => SetField(ref _recordTypeId, value); }
}