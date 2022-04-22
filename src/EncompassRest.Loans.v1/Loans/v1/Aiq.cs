namespace EncompassRest.Loans.v1;

/// <summary>
/// Aiq
/// </summary>
public sealed partial class Aiq : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// AIQ Site Id [AIQ.AIQSITEID]
    /// </summary>
    public string? AiqSiteId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AIQ Cabinet Id [AIQ.CABINETID]
    /// </summary>
    public string? CabinetId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AIQ Doc Mirror In Flight [AIQ.DOCMIRRORINFLIGHT]
    /// </summary>
    public string? DocMirrorInFlight { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AIQ Folder Id [AIQ.FOLDERID]
    /// </summary>
    public string? FolderId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Aiq Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AIQ In-Flight Loan Id [AIQ.INFLIGHTLOANID]
    /// </summary>
    public string? InFlightLoanId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AIQ Last Update By LIS In Pst [AIQ.LASTUPDATEBYLISINPST]
    /// </summary>
    public string? LastUpdateByLisInPst { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AIQ Loan Was Mirrored On PST [AIQ.LOANWASMIRROREDONPST]
    /// </summary>
    public string? LoanWasMirroredOnPst { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AIQ Propagate Data [AIQ.PROPAGATEDATA]
    /// </summary>
    public string? PropagateData { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AIQ Segment Id [AIQ.SEGMENTID]
    /// </summary>
    public string? SegmentId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AIQ Thread Id [AIQ.THREADID]
    /// </summary>
    public string? ThreadId { get => GetValue<string?>(); set => SetValue(value); }
}