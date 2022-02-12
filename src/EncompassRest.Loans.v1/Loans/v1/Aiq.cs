namespace EncompassRest.Loans.v1;

/// <summary>
/// Aiq
/// </summary>
public sealed partial class Aiq : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _aiqSiteId;
    private DirtyValue<string?>? _cabinetId;
    private DirtyValue<string?>? _docMirrorInFlight;
    private DirtyValue<string?>? _folderId;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _inFlightLoanId;
    private DirtyValue<string?>? _lastUpdateByLisInPst;
    private DirtyValue<string?>? _loanWasMirroredOnPst;
    private DirtyValue<string?>? _propagateData;
    private DirtyValue<string?>? _segmentId;
    private DirtyValue<string?>? _threadId;

    /// <summary>
    /// AIQ Site Id [AIQ.AIQSITEID]
    /// </summary>
    public string? AiqSiteId { get => _aiqSiteId; set => SetField(ref _aiqSiteId, value); }

    /// <summary>
    /// AIQ Cabinet Id [AIQ.CABINETID]
    /// </summary>
    public string? CabinetId { get => _cabinetId; set => SetField(ref _cabinetId, value); }

    /// <summary>
    /// AIQ Doc Mirror In Flight [AIQ.DOCMIRRORINFLIGHT]
    /// </summary>
    public string? DocMirrorInFlight { get => _docMirrorInFlight; set => SetField(ref _docMirrorInFlight, value); }

    /// <summary>
    /// AIQ Folder Id [AIQ.FOLDERID]
    /// </summary>
    public string? FolderId { get => _folderId; set => SetField(ref _folderId, value); }

    /// <summary>
    /// Aiq Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// AIQ In-Flight Loan Id [AIQ.INFLIGHTLOANID]
    /// </summary>
    public string? InFlightLoanId { get => _inFlightLoanId; set => SetField(ref _inFlightLoanId, value); }

    /// <summary>
    /// AIQ Last Update By LIS In Pst [AIQ.LASTUPDATEBYLISINPST]
    /// </summary>
    public string? LastUpdateByLisInPst { get => _lastUpdateByLisInPst; set => SetField(ref _lastUpdateByLisInPst, value); }

    /// <summary>
    /// AIQ Loan Was Mirrored On PST [AIQ.LOANWASMIRROREDONPST]
    /// </summary>
    public string? LoanWasMirroredOnPst { get => _loanWasMirroredOnPst; set => SetField(ref _loanWasMirroredOnPst, value); }

    /// <summary>
    /// AIQ Propagate Data [AIQ.PROPAGATEDATA]
    /// </summary>
    public string? PropagateData { get => _propagateData; set => SetField(ref _propagateData, value); }

    /// <summary>
    /// AIQ Segment Id [AIQ.SEGMENTID]
    /// </summary>
    public string? SegmentId { get => _segmentId; set => SetField(ref _segmentId, value); }

    /// <summary>
    /// AIQ Thread Id [AIQ.THREADID]
    /// </summary>
    public string? ThreadId { get => _threadId; set => SetField(ref _threadId, value); }
}