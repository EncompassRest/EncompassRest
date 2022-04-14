namespace EncompassRest.Loans.v3;

/// <summary>
/// ApplicationReference
/// </summary>
public sealed partial class ApplicationReference : EntityReference, IIdentifiable
{
    private DirtyValue<string?>? _legacyId;

    /// <summary>
    /// ApplicationReferenceContract LegacyId
    /// </summary>
    public string? LegacyId { get => _legacyId; set => SetField(ref _legacyId, value); }
}