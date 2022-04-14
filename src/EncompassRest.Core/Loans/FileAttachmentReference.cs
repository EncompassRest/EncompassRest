namespace EncompassRest.Loans;

/// <summary>
/// FileAttachmentReference
/// </summary>
public sealed partial class FileAttachmentReference : EntityReference, IIdentifiable
{
    private DirtyValue<bool?>? _isActive;

    /// <summary>
    /// FileAttachmentReferenceContract IsActive
    /// </summary>
    public bool? IsActive { get => _isActive; set => SetField(ref _isActive, value); }
}